using System.Net;
using System.Net.Http;
using System.Text.Json.Nodes;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Interfaces.Http;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Application.Features.Impersonation.Queries;

public class GetDevLogsQueryHandler(
    IApiClient apiClient,
    IConfiguration configuration,
    ILogger<GetDevLogsQueryHandler> logger) : IRequestHandler<GetDevLogsQuery, PagedList<DevLogDto>>
{
    public async Task<PagedList<DevLogDto>> Handle(GetDevLogsQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var elasticNodeUri = configuration["Serilog:WriteTo:2:Args:nodeUris"] ?? "http://localhost:9200";
            var elasticUrl = $"{elasticNodeUri.TrimEnd('/')}/renticar-logs-*/_search";
            
            var mustClauses = new List<object>();
            
            if (!string.IsNullOrWhiteSpace(request.SearchKeyword))
            {
                var kw = request.SearchKeyword.Trim();
                mustClauses.Add(new
                {
                    @bool = new
                    {
                        should = new object[]
                        {
                            new {
                                multi_match = new
                                {
                                    query = kw,
                                    fields = new[]
                                    {
                                        "message", "Message", "@m", "messageTemplate", "MessageTemplate",
                                        "exception", "Exception",
                                        "fields.SourceContext", "Properties.SourceContext", "properties.SourceContext",
                                        "fields.RequestPath", "Properties.RequestPath", "properties.RequestPath",
                                        "fields.ActionName", "Properties.ActionName", "properties.ActionName",
                                        "fields.MachineName", "Properties.MachineName", "properties.MachineName",
                                        "fields.ThreadId", "Properties.ThreadId", "properties.ThreadId"
                                    },
                                    type = "phrase_prefix"
                                }
                            },
                            new {
                                query_string = new
                                {
                                    query = $"*{kw}*",
                                    fields = new[]
                                    {
                                        "message", "Message", "@m", "messageTemplate", "MessageTemplate",
                                        "exception", "Exception",
                                        "fields.*", "Properties.*", "properties.*"
                                    },
                                    default_operator = "AND",
                                    allow_leading_wildcard = true,
                                    analyze_wildcard = true
                                }
                            }
                        }
                    }
                });
            }
            
            if (!string.IsNullOrWhiteSpace(request.LogLevel))
            {
                var lvl = request.LogLevel.Trim();
                mustClauses.Add(new
                {
                    @bool = new
                    {
                        should = new object[]
                        {
                            new { term = new Dictionary<string, object> { { "level.keyword", lvl } } },
                            new { term = new Dictionary<string, object> { { "Level.keyword", lvl } } },
                            new { term = new Dictionary<string, object> { { "fields.Level.keyword", lvl } } },
                            new { term = new Dictionary<string, object> { { "level", lvl } } },
                            new { term = new Dictionary<string, object> { { "Level", lvl } } },
                            new { term = new Dictionary<string, object> { { "level", lvl.ToLower() } } },
                            new { term = new Dictionary<string, object> { { "Level", lvl.ToLower() } } },
                            new { term = new Dictionary<string, object> { { "level", lvl.ToUpper() } } },
                            new { term = new Dictionary<string, object> { { "Level", lvl.ToUpper() } } },
                            new { match = new Dictionary<string, object> { { "level", lvl } } },
                            new { match = new Dictionary<string, object> { { "Level", lvl } } }
                        }
                    }
                });
            }
            
            if (!string.IsNullOrWhiteSpace(request.StartDate) || !string.IsNullOrWhiteSpace(request.EndDate))
            {
                var range = new Dictionary<string, object>();
                if (!string.IsNullOrWhiteSpace(request.StartDate))
                    range["gte"] = request.StartDate;
                if (!string.IsNullOrWhiteSpace(request.EndDate))
                    range["lte"] = request.EndDate;

                mustClauses.Add(new
                {
                    range = new Dictionary<string, object>
                    {
                        { "@timestamp", range }
                    }
                });
            }

            object queryFilter = mustClauses.Count == 0
                ? new { match_all = new { } }
                : new { @bool = new { must = mustClauses } };

            var queryObj = new
            {
                from = (request.PageNumber - 1) * request.PageSize,
                size = request.PageSize,
                sort = new object[]
                {
                    new Dictionary<string, object>
                    {
                        { "@timestamp", new { order = "desc", unmapped_type = "boolean" } }
                    }
                },
                query = queryFilter
            };

            var responseString = await apiClient.PostStringAsync(elasticUrl, queryObj, null, cancellationToken);
            var parsed = JsonNode.Parse(responseString);

            if (parsed == null)
            {
                logger.LogError("[DevLogs] Failed to fetch logs from Elasticsearch: Response is null");
                return new PagedList<DevLogDto>([], 0, request.PageNumber, request.PageSize);
            }

            var hitsTotal = parsed["hits"]?["total"]?["value"]?.GetValue<int>() ?? 0;
            var hitsArray = parsed["hits"]?["hits"]?.AsArray();

            var logs = new List<DevLogDto>();

            if (hitsArray != null)
            {
                logs.AddRange(from source in hitsArray.Select(hit => hit?["_source"]).OfType<JsonNode>()
                let props = source["fields"] ?? source["Properties"] ?? source["properties"]
                select new DevLogDto
                {
                    Timestamp = source["@timestamp"]?.ToString() ?? source["Timestamp"]?.ToString(),
                    Level = source["level"]?.ToString() ?? source["Level"]?.ToString() ?? props?["Level"]?.ToString(),
                    MessageTemplate = source["messageTemplate"]?.ToString() ?? source["MessageTemplate"]?.ToString(),
                    RenderedMessage = source["message"]?.ToString() ?? source["Message"]?.ToString() ?? source["@m"]?.ToString(),
                    Exception = source["exception"]?.ToString() ?? source["Exception"]?.ToString(),
                    SourceContext = props?["SourceContext"]?.ToString() ?? source["SourceContext"]?.ToString(),
                    RequestPath = props?["RequestPath"]?.ToString() ?? source["RequestPath"]?.ToString(),
                    ActionName = props?["ActionName"]?.ToString() ?? source["ActionName"]?.ToString(),
                    MachineName = props?["MachineName"]?.ToString() ?? source["MachineName"]?.ToString(),
                    ThreadId = props?["ThreadId"]?.ToString() ?? source["ThreadId"]?.ToString(),
                    Properties = props?.ToJsonString()
                });
            }

            return new PagedList<DevLogDto>(logs, hitsTotal, request.PageNumber, request.PageSize);
        }
        catch (HttpRequestException httpEx) when (httpEx.StatusCode == HttpStatusCode.NotFound)
        {
            return new PagedList<DevLogDto>([], 0, request.PageNumber, request.PageSize);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[DevLogs] Error occurred while fetching dev logs from Elasticsearch.");
            return new PagedList<DevLogDto>([], 0, request.PageNumber, request.PageSize);
        }
    }
}
