using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

public class EmbeddingSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.EmbeddingSettings;
    
    public string ModelPath { get; set; } = "Models/all-MiniLM-L6-v2.onnx";
    
    public string VocabPath { get; set; } = "Models/vocab.txt";
    
    public string TokenizerPath { get; set; } = "Models/tokenizer.json";
    
    public int Dimension { get; set; } = 384;
    
    public bool Enabled { get; set; } = true;
}
