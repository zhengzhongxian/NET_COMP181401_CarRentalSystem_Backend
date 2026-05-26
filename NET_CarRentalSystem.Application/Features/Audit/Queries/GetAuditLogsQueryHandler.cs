using System.Net;
using System.Net.Http;
using System.Text.Json.Nodes;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Interfaces.Http;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Application.Features.Audit.Queries;

public class GetAuditLogsQueryHandler(
    IApiClient apiClient,
    IConfiguration configuration,
    ILogger<GetAuditLogsQueryHandler> logger) : IRequestHandler<GetAuditLogsQuery, PagedList<AuditLogDto>>
{
    public async Task<PagedList<AuditLogDto>> Handle(GetAuditLogsQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var elasticNodeUri = configuration["Serilog:WriteTo:2:Args:nodeUris"] ?? "http://localhost:9200";
            var elasticUrl = $"{elasticNodeUri.TrimEnd('/')}/renticar-logs-*/_search";
            
            object queryFilter = string.IsNullOrWhiteSpace(request.SearchKeyword)
                ? new { match_phrase_prefix = new { messageTemplate = "[AuditLog]" } }
                : new
                {
                    @bool = new
                    {
                        must = new object[]
                        {
                            new { match_phrase_prefix = new { messageTemplate = "[AuditLog]" } },
                            new
                            {
                                multi_match = new
                                {
                                    query = request.SearchKeyword,
                                    fields = new[] { "Message", "Properties.Action", "Properties.EntityName", "Properties.UserId", "Properties.ChangedProperties" }
                                }
                            }
                        }
                    }
                };

            var queryObj = new
            {
                from = (request.PageNumber - 1) * request.PageSize,
                size = request.PageSize,
                sort = new object[]
                {
                    new Dictionary<string, object> { { "@timestamp", new { order = "desc", unmapped_type = "boolean" } } }
                },
                query = queryFilter
            };

            // Dùng PostStringAsync để nhận raw string, tránh lỗi JsonHelper.FromJson<JsonNode>
            var responseString = await apiClient.PostStringAsync(elasticUrl, queryObj, null, cancellationToken);
            var parsed = JsonNode.Parse(responseString);
            
            if (parsed == null)
            {
                logger.LogError("Failed to fetch audit logs from Elasticsearch: Response is null or empty");
                return new PagedList<AuditLogDto>([], 0, request.PageNumber, request.PageSize);
            }
            
            var hitsTotal = parsed["hits"]?["total"]?["value"]?.GetValue<int>() ?? 0;
            var hitsArray = parsed["hits"]?["hits"]?.AsArray();

            var logs = new List<AuditLogDto>();

            if (hitsArray != null)
            {
                foreach (var hit in hitsArray)
                {
                    var source = hit["_source"];
                    if (source == null) continue;

                    // Debug: log cấu trúc document ES đầu tiên
                    if (logs.Count == 0)
                    {
                        logger.LogInformation("ES first hit _source keys: {Keys}", source.ToJsonString());
                    }

                    // Serilog ES sink lưu properties ở nhiều path tùy version:
                    // - source["fields"]["Action"] (ESv7 default)
                    // - source["Properties"]["Action"]
                    // - source["Action"] (flattened)
                    var props = source["fields"] ?? source["Properties"] ?? source["properties"];

                    var log = new AuditLogDto
                    {
                        Timestamp = source["@timestamp"]?.ToString() ?? source["Timestamp"]?.ToString(),
                        Message = source["message"]?.ToString() ?? source["Message"]?.ToString() ?? source["@m"]?.ToString(),
                        Action = props?["Action"]?.ToString() ?? source["Action"]?.ToString(),
                        EntityName = props?["EntityName"]?.ToString() ?? source["EntityName"]?.ToString(),
                        EntityId = props?["EntityId"]?.ToString() ?? source["EntityId"]?.ToString(),
                        UserId = props?["UserId"]?.ToString() ?? source["UserId"]?.ToString(),
                        IpAddress = props?["IpAddress"]?.ToString() ?? source["IpAddress"]?.ToString(),
                        RequestPath = props?["RequestPath"]?.ToString() ?? source["RequestPath"]?.ToString(),
                        ChangedProperties = props?["ChangedProperties"]?.ToString() ?? source["ChangedProperties"]?.ToString(),
                        OldValues = props?["OldValues"]?.ToString() ?? source["OldValues"]?.ToString(),
                        NewValues = props?["NewValues"]?.ToString() ?? source["NewValues"]?.ToString(),
                    };
                    logs.Add(log);
                }
            }

            return new PagedList<AuditLogDto>(logs, hitsTotal, request.PageNumber, request.PageSize);
        }
        catch (HttpRequestException httpEx) when (httpEx.StatusCode == HttpStatusCode.NotFound)
        {
            return new PagedList<AuditLogDto>([], 0, request.PageNumber, request.PageSize);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error occurred while fetching audit logs from Elasticsearch.");
            return new PagedList<AuditLogDto>([], 0, request.PageNumber, request.PageSize);
        }
    }
}
