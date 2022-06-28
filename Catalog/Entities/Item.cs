namespace Catalog.Entities
{

    public class Item
    {
        public Guid Id { get; init; }
        public String Name { get; init; }
        public decimal Price { get; set; }

        public DateTimeOffset CreateDate { get; init; }
    }
}
