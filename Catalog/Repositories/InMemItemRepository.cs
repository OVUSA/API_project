using System.Collections.Generic;
using Catalog.Entities;
namespace Catalog.Repositories{
    public class InMemItemRepository{
        private readonly List<Item> item = new(){
            new Item { Id=Guid.NewGuid(),Name = "Potion", Price=9, CreatedDate =DateTimeOffset.UtcNow },
            new Item { Id=Guid.NewGuid(),Name = "Iron Sword", Price=20, CreatedDate =DateTimeOffset.UtcNow },
            new Item { Id=Guid.NewGuid(),Name = "Bronze Shield", Price=22, CreatedDate =DateTimeOffset.UtcNow }

        };

    }
}