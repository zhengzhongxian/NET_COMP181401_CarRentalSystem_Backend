using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.SyncDataTool.Configurations;

public class SyncDataToolSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.SyncDataToolSettings;
    
    public int SyncIntervalInSeconds { get; set; } = 2;
    
    public int DbRetryDelayInSeconds { get; set; } = 5;
    
    public List<SyncTableConfig> TablesToSync { get; set; } = [];
}

public class SyncTableConfig(string tableName, string primaryKeyColumn)
{
    public string TableName { get; } = tableName;

    public string PrimaryKeyColumn { get; } = primaryKeyColumn;
}