using Mscc.GenerativeAI;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Mscc.GenerativeAI.Types;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Services.AI;
using NET_CarRentalSystem.Application.Models.AI;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Infrastructure.Services.AI;

public class GeminiService : IGeminiService
{
    private readonly GoogleAI _client;
    private readonly GeminiSettings _settings;
    private readonly ILogger<GeminiService> _logger;

    public GeminiService(
        IOptions<GeminiSettings> settings,
        ILogger<GeminiService> logger)
    {
        _settings = settings.Value;
        _logger = logger;
        _client = new GoogleAI(apiKey: _settings.ApiKey);
    }

    public async Task<AiEnhancedQueryParams> ParseAndEnhanceVehicleQueryAsync(
        string searchKeyword,
        IDapperRepository dapperRepository,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(_settings.ApiKey) || _settings.ApiKey == "YOUR_GEMINI_API_KEY_HERE")
        {
            _logger.LogWarning("[GeminiAI] API key not configured, skipping AI parsing");
            return CreateFallback(searchKeyword);
        }
        
        try
        {
            var prompt = BuildEnhancementPrompt(searchKeyword);

            _logger.LogInformation("[GeminiAI] Parsing keyword: {Keyword}", searchKeyword);
            
            GenerateContentResponse? response;
            try
            {
                var model = _client.GenerativeModel(model: Model.Gemini25Flash);
                response = await model.GenerateContent(prompt, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogWarning(httpEx, "[GeminiAI] Network error, falling back to keyword search");
                return CreateFallback(searchKeyword);
            }
            catch (TaskCanceledException)
            {
                _logger.LogWarning("[GeminiAI] Request timeout, falling back to keyword search");
                return CreateFallback(searchKeyword);
            }
            catch (GeminiApiException geminiEx)
            {
                _logger.LogWarning(geminiEx, "[GeminiAI] Gemini API error, falling back to keyword search");
                return CreateFallback(searchKeyword);
            }
            
            if (response.Text == null)
            {
                _logger.LogWarning("[GeminiAI] Empty response from Gemini API");
                return CreateFallback(searchKeyword);
            }
            
            var jsonResponse = response.Text;
            
            jsonResponse = StripMarkdownCodeBlock(jsonResponse);

            _logger.LogDebug("[GeminiAI] Response: {Response}", jsonResponse);
            
            var parsedIntent = jsonResponse.FromJson<VehicleSearchIntent>();

            if (parsedIntent == null)
            {
                _logger.LogWarning("[GeminiAI] Failed to parse response for keyword: {Keyword}", searchKeyword);
                return CreateFallback(searchKeyword);
            }

            parsedIntent.OriginalQuery = searchKeyword;
            
            var result = await MapToEnhancedParams(parsedIntent, dapperRepository, cancellationToken).ConfigureAwait(false);
            
            _logger.LogInformation("[GeminiAI] Successfully parsed. Intent: {Intent}", result.ParsedIntent);
            
            return result;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "[GeminiAI] Unexpected error for keyword: {Keyword}", searchKeyword);
            return CreateFallback(searchKeyword);
        }
    }

    private string BuildEnhancementPrompt(string keyword)
    {
        return $$"""
                 You are a Vietnamese vehicle rental search assistant. Your job is to extract search parameters from user queries.

                 USER QUERY: "{{keyword}}"

                 === DATABASE SCHEMA ===
                 CATEGORY CODES (exact values in DB): SEDAN, SUV, HATCHBACK, MINIVAN
                 - SEDAN: xe 4-5 chỗ phổ thông (Toyota Vios, Honda City)
                 - SUV: xe 7 chỗ gầm cao (Fortuner, CRV, Santa Fe)
                 - HATCHBACK: xe nhỏ gọn đô thị (i10, Morning)
                 - MINIVAN: xe gia đình rộng (Innova, Stargazer)

                 FUEL TYPES (exact values in DB): Gasoline, Diesel, Electric
                 - Gasoline (xăng): phổ biến cho thành phố
                 - Diesel (dầu): tiết kiệm nhiên liệu, phù hợp đường dài
                 - Electric (điện): thân thiện môi trường

                 TRANSMISSION CODES (exact values in DB): AT, MT
                 - AT: số tự động (automatic)
                 - MT: số sàn (manual)

                 LOCATIONS/CITIES (exact values in DB): Hồ Chí Minh, Hà Nội, Đà Nẵng, Khánh Hòa (Nha Trang)

                 VEHICLE ATTRIBUTES (stored in JSON, examples):
                 - GPS, định vị
                 - Túi khí, airbag
                 - Camera lùi, camera hành trình
                 - Cảm biến, sensor
                 - Bluetooth, USB, sạc điện thoại
                 - Màn hình, giải trí
                 - Cửa sổ trời, sunroof
                 - Ghế da, nội thất cao cấp

                 === OUTPUT FORMAT ===
                 Return ONLY valid JSON (no markdown):
                 {
                   "categoryCode": "SEDAN|SUV|HATCHBACK|MINIVAN or null",
                   "fuelType": "Gasoline|Diesel|Electric or null",
                   "transmissionCode": "AT|MT or null",
                   "locationCity": "City name or null",
                   "attributeKeywords": ["keyword1", "keyword2"],
                   "excludeAttributeKeywords": ["excluded1", "excluded2"],
                   "minPrice": number or null,
                   "maxPrice": number or null,
                   "sortBy": "Price|Rating|Date or null",
                   "sortDirection": "ASC|DESC",
                   "parsedIntent": "Tóm tắt ngắn bằng tiếng Việt"
                 }

                 === RULES ===
                 1. NEGATION HANDLING (QUAN TRỌNG):
                    - "không có GPS", "không cần GPS" → excludeAttributeKeywords=["GPS"]
                    - "không camera", "không túi khí" → excludeAttributeKeywords=["camera", "túi khí"]
                    - "có GPS", "cần GPS" → attributeKeywords=["GPS"]
                    
                 2. SYNONYMS & SMART MATCHING:
                    - "xe gia đình", "xe rộng rãi" → categoryCode="MINIVAN" or "SUV"
                    - "xe tiết kiệm xăng" → fuelType="Diesel" or "Electric"
                    - "xe sang", "xe cao cấp" → sortBy="Price", sortDirection="DESC"
                    - "xe nhỏ", "xe đi lại" → categoryCode="HATCHBACK"

                 3. SORTING:
                    - "rẻ nhất", "giá thấp", "tiết kiệm" → sortBy="Price", sortDirection="ASC"
                    - "đắt nhất", "cao cấp", "sang trọng" → sortBy="Price", sortDirection="DESC"
                    - "tốt nhất", "đánh giá cao" → sortBy="Rating", sortDirection="DESC"
                    - "mới nhất" → sortBy="Date", sortDirection="DESC"
                    - Default: sortBy="Rating", sortDirection="DESC"

                 4. CATEGORY MATCHING:
                    - "4 chỗ", "sedan" → SEDAN
                    - "7 chỗ", "suv", "gầm cao" → SUV  
                    - "nhỏ gọn", "hatchback", "đô thị" → HATCHBACK
                    - "gia đình", "minivan", "mpv" → MINIVAN

                 5. PRICE (VND per HOUR):
                    - "500k/ngày" → 20833 (500000÷24)
                    - "1 triệu/ngày" → 41667 (1000000÷24)
                    - "dưới 800k" → maxPrice=33333

                 6. ATTRIBUTES:
                    - Extract keywords like: GPS, túi khí, camera, bluetooth, cửa sổ trời
                    - Put them in attributeKeywords array for JSON search

                 === EXAMPLES ===
                 Input: "xe 7 chỗ số tự động có GPS ở Sài Gòn"
                 Output: {"categoryCode":"SUV","transmissionCode":"AT","locationCity":"Hồ Chí Minh","attributeKeywords":["GPS"],"sortBy":"Rating","sortDirection":"DESC","parsedIntent":"Xe SUV 7 chỗ số tự động có GPS tại Hồ Chí Minh"}

                 Input: "xe điện giá rẻ nhất"
                 Output: {"fuelType":"Electric","sortBy":"Price","sortDirection":"ASC","parsedIntent":"Xe điện sắp xếp theo giá tăng dần"}

                 Input: "xe không có GPS"
                 Output: {"excludeAttributeKeywords":["GPS"],"sortBy":"Rating","sortDirection":"DESC","parsedIntent":"Xe không có GPS"}

                 Input: "sedan có camera lùi nhưng không cần túi khí"
                 Output: {"categoryCode":"SEDAN","attributeKeywords":["camera lùi"],"excludeAttributeKeywords":["túi khí"],"sortBy":"Rating","sortDirection":"DESC","parsedIntent":"Xe sedan có camera lùi, không cần túi khí"}

                 Input: "xe ở Đà Nẵng dưới 1 triệu/ngày"
                 Output: {"locationCity":"Đà Nẵng","maxPrice":41667,"sortBy":"Rating","sortDirection":"DESC","parsedIntent":"Xe tại Đà Nẵng giá dưới 1 triệu/ngày"}

                 Now analyze the user query and return JSON:
                 """;
    }

    private async Task<AiEnhancedQueryParams> MapToEnhancedParams(
        VehicleSearchIntent intent,
        IDapperRepository dapperRepository,
        CancellationToken cancellationToken)
    {
        var result = new AiEnhancedQueryParams
        {
            MinPrice = intent.MinPrice,
            MaxPrice = intent.MaxPrice,
            SortBy = intent.SortBy,
            SortDirection = intent.SortDirection ?? "DESC",
            ParsedIntent = intent.ParsedIntent ?? "",
            FallbackKeyword = intent.OriginalQuery,
            AttributeKeywords = intent.AttributeKeywords,
            ExcludeAttributeKeywords = intent.ExcludeAttributeKeywords
        };
        
        var categorySearch = intent.CategoryCode ?? intent.CategoryKeyword;
        if (!string.IsNullOrEmpty(categorySearch))
        {
            const string categorySql = """

                                       SELECT TOP 1 vehicle_categorie_id 
                                       FROM vehicle_categories 
                                       WHERE LOWER(category_code) = @Code OR LOWER(category_code) LIKE @Keyword
                                       """;
            
            result.CategoryId = await dapperRepository.ExecuteScalarAsync<Guid?>(
                categorySql, 
                new Dictionary<string, object> 
                { 
                    { "Code", categorySearch.ToLower() },
                    { "Keyword", $"%{categorySearch.ToLower()}%" }
                },
                cancellationToken: cancellationToken);
        }

        // Map FuelId
        if (!string.IsNullOrEmpty(intent.FuelType))
        {
            const string fuelSql = """

                                   SELECT TOP 1 fuel_id 
                                   FROM fuels 
                                   WHERE LOWER(name) = @Name OR LOWER(name) LIKE @Keyword
                                   """;
            
            result.FuelId = await dapperRepository.ExecuteScalarAsync<Guid?>(
                fuelSql,
                new Dictionary<string, object> 
                { 
                    { "Name", intent.FuelType.ToLower() },
                    { "Keyword", $"%{intent.FuelType.ToLower()}%" }
                },
                cancellationToken: cancellationToken);
        }

        // Map LocationId: use LocationCity first, fallback to LocationName
        var locationSearch = intent.LocationCity ?? intent.LocationName;
        if (!string.IsNullOrEmpty(locationSearch))
        {
            const string locationSql = """

                                       SELECT TOP 1 location_id 
                                       FROM locations 
                                       WHERE LOWER(city) = @City 
                                          OR LOWER(city) LIKE @Keyword 
                                          OR LOWER(name) LIKE @Keyword
                                       """;
            
            result.LocationId = await dapperRepository.ExecuteScalarAsync<Guid?>(
                locationSql,
                new Dictionary<string, object> 
                { 
                    { "City", locationSearch.ToLower() },
                    { "Keyword", $"%{locationSearch.ToLower()}%" }
                },
                cancellationToken: cancellationToken);
        }

        return result;
    }

    private static AiEnhancedQueryParams CreateFallback(string keyword)
    {
        return new AiEnhancedQueryParams
        {
            FallbackKeyword = keyword,
            ParsedIntent = "Using keyword search (AI unavailable)",
            SortBy = "Rating",
            SortDirection = "DESC"
        };
    }
    
    private static string StripMarkdownCodeBlock(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return text;
            
        var trimmed = text.Trim();

        if (!trimmed.StartsWith("```")) return trimmed.Trim();
        var firstNewLine = trimmed.IndexOf('\n');
        if (firstNewLine > 0)
        {
            trimmed = trimmed[(firstNewLine + 1)..];
        }
            
        if (trimmed.EndsWith("```"))
        {
            trimmed = trimmed[..^3];
        }

        return trimmed.Trim();
    }
}
