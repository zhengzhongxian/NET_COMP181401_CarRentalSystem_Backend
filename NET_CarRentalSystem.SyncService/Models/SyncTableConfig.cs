namespace NET_CarRentalSystem.SyncService.Models
{
    public class SyncTableConfig(string tableName, string primaryKeyColumn, Type primaryKeyType)
    {
        public string TableName { get; } = tableName;
        public string PrimaryKeyColumn { get; } = primaryKeyColumn;
        public Type PrimaryKeyType { get; } = primaryKeyType;
    }
}