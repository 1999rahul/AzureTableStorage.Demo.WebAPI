using Azure.Data.Tables;
using Azure;

namespace TableStorage.Demo.WebAPI
{
    public class GroceryItemEntity : ITableEntity
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }//Partation Key
        public int Price { get; set; }
        public string? PartitionKey { get; set; }
        public string? RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }
}
