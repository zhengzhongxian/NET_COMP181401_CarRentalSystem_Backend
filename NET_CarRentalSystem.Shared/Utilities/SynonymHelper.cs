namespace NET_CarRentalSystem.Shared.Utilities;

public static class SynonymHelper
{
    private static readonly string[][] SynonymGroups =
    [
        ["xe hơi", "ô tô", "xe oto", "xe 4 bánh", "car", "automobile", "xe con"],
        ["xe máy", "xe gắn máy", "mô tô", "xe 2 bánh", "motorbike", "motorcycle", "scooter"],
        ["suv", "xe địa hình", "xe đa dụng", "crossover", "sport utility"],
        ["sedan", "xe sedan", "xe 4 chỗ", "xe hạng trung"],
        ["hatchback", "xe hatchback", "xe compact", "xe cỡ nhỏ"],
        ["pickup", "xe bán tải", "bán tải", "truck", "xe tải nhỏ"],
        ["mpv", "xe gia đình", "xe 7 chỗ", "minivan", "xe đa chỗ"],
        ["coupe", "xe thể thao", "xe 2 cửa", "sports car"],
        ["convertible", "xe mui trần", "mui trần", "cabriolet", "xe mui xếp"],
        ["wagon", "xe wagon", "estate", "xe 5 cửa"],
        ["van", "xe van", "xe khách", "xe 16 chỗ", "xe du lịch"],

        ["xăng", "petrol", "gasoline", "gas", "benzin"],
        ["dầu", "diesel", "dầu diesel", "động cơ dầu"],
        ["điện", "electric", "xe điện", "ev", "bev", "battery electric"],
        ["hybrid", "xe hybrid", "xăng điện", "xe lai", "phev"],
        
        ["số tự động", "tự động", "automatic", "at", "auto"],
        ["số sàn", "số tay", "manual", "mt", "tay số"],
        ["cvt", "vô cấp", "biến thiên liên tục"],
        ["dct", "ly hợp kép", "dual clutch"],
        
        ["gps", "định vị", "dẫn đường", "navigation", "nav", "bản đồ"],
        ["camera lùi", "camera hậu", "rear camera", "camera sau", "reversing camera"],
        ["camera 360", "camera toàn cảnh", "surround view", "bird view"],
        ["cảm biến", "sensor", "cảm biến va chạm", "parking sensor", "cảm biến đỗ xe"],
        ["túi khí", "airbag", "túi khí an toàn", "air bag"],
        ["điều hòa", "máy lạnh", "air conditioning", "ac", "air con"],
        ["ghế da", "nội thất da", "leather seat", "da", "leather interior"],
        ["sunroof", "cửa sổ trời", "panorama", "panoramic roof", "trần kính"],
        ["cruise control", "kiểm soát hành trình", "ga tự động"],
        ["bluetooth", "kết nối không dây", "wireless"],
        ["usb", "cổng usb", "usb port", "sạc điện thoại"],
        ["carplay", "apple carplay", "android auto"],
        ["abs", "chống bó cứng phanh", "anti-lock brake"],
        ["esp", "cân bằng điện tử", "electronic stability"],

        ["toyota", "toy", "toyota motor"],
        ["honda", "hon", "honda motor"],
        ["hyundai", "huyndai", "hundai", "huyn"],
        ["mercedes", "merc", "mercedes-benz", "benz", "mercedes benz"],
        ["bmw", "beamer", "bimmer"],
        ["mazda", "mazd"],
        ["ford", "fo"],
        ["kia", "ki"],
        ["vinfast", "vf", "vin"],
        ["nissan", "niss"],
        ["mitsubishi", "mitsu", "mit"],
        ["chevrolet", "chevy", "chev"],
        ["audi", "aud"],
        ["lexus", "lex"],
        ["volkswagen", "vw", "volks"],
        ["peugeot", "peug"],
        ["suzuki", "suzu"],

        ["trắng", "white", "màu trắng", "trắng ngọc trai"],
        ["đen", "black", "màu đen", "đen bóng"],
        ["đỏ", "red", "màu đỏ", "đỏ rượu vang"],
        ["xanh", "blue", "màu xanh", "xanh dương", "xanh navy"],
        ["bạc", "silver", "màu bạc", "bạc ánh kim"],
        ["xám", "gray", "grey", "màu xám"],
        ["vàng", "yellow", "gold", "màu vàng", "vàng cát"],
        ["nâu", "brown", "màu nâu", "nâu đồng"],
        ["cam", "orange", "màu cam"],
        ["xanh lá", "green", "màu xanh lá"],
        
        ["4 chỗ", "bốn chỗ", "4 seats", "four seater"],
        ["5 chỗ", "năm chỗ", "5 seats", "five seater"],
        ["7 chỗ", "bảy chỗ", "7 seats", "seven seater"],
        ["9 chỗ", "chín chỗ", "9 seats", "nine seater"],
        
        ["nhỏ", "small", "compact", "cỡ nhỏ", "mini"],
        ["lớn", "large", "big", "cỡ lớn", "full size"],
        ["vừa", "medium", "mid-size", "cỡ vừa", "trung bình"],
        
        ["rẻ", "giá rẻ", "tiết kiệm", "cheap", "budget", "affordable", "kinh tế"],
        ["sang trọng", "cao cấp", "luxury", "premium", "hạng sang", "vip"],
        ["mới", "mới nhất", "new", "latest", "đời mới", "model mới"],
        ["cũ", "secondhand", "used", "xe cũ", "qua sử dụng"],
        ["phổ biến", "popular", "hot", "bán chạy", "ưa chuộng"],
        ["tiết kiệm xăng", "tiết kiệm nhiên liệu", "fuel efficient", "eco", "tiết kiệm"],
        ["mạnh mẽ", "powerful", "khỏe", "động cơ mạnh"],
        ["an toàn", "safe", "safety", "bảo vệ"],
        
        ["thuê", "rent", "rental", "cho thuê", "thuê xe"],
        ["ngày", "day", "daily", "theo ngày"],
        ["tuần", "week", "weekly", "theo tuần"],
        ["tháng", "month", "monthly", "theo tháng"],
        ["có tài xế", "driver", "with driver", "kèm tài xế", "có lái xe"],
        ["tự lái", "self drive", "không tài xế", "tự thuê"]
    ];

    private static readonly Dictionary<string, HashSet<string>> SynonymLookup = BuildSynonymLookup();

    private static Dictionary<string, HashSet<string>> BuildSynonymLookup()
    {
        var lookup = new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase);
        
        foreach (var group in SynonymGroups)
        {
            var synonymSet = new HashSet<string>(group, StringComparer.OrdinalIgnoreCase);
            foreach (var term in group)
            {
                lookup[term.ToLower()] = synonymSet;
            }
        }
        
        return lookup;
    }

    public static List<string> ExpandWithSynonyms(string term)
    {
        if (string.IsNullOrWhiteSpace(term))
            return [];

        var lowerTerm = term.ToLower().Trim();
        
        if (SynonymLookup.TryGetValue(lowerTerm, out var synonyms))
        {
            return synonyms.ToList();
        }
        
        return [term];
    }

    public static List<string> ExpandPhraseWithSynonyms(string phrase)
    {
        if (string.IsNullOrWhiteSpace(phrase))
            return [];

        var words = phrase.ToLower()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Where(w => w.Length >= 2)
            .ToList();

        var expandedTerms = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (var word in words)
        {
            // Add original word
            expandedTerms.Add(word);
            
            // Add synonyms if any
            if (SynonymLookup.TryGetValue(word, out var synonyms))
            {
                foreach (var synonym in synonyms)
                {
                    expandedTerms.Add(synonym);
                }
            }
        }

        return expandedTerms.ToList();
    }
}
