using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Repositories
{
    public class InMemItemsRepository
    {
        private readonly List<Item> items = new(){
            new Item { Id=Guid.NewGuid(),Name = "Potion", Price=9, CreatedDate =DateTimeOffset.UtcNow },
            new Item { Id=Guid.NewGuid(),Name = "Iron Sword", Price=20, CreatedDate =DateTimeOffset.UtcNow },
            new Item { Id=Guid.NewGuid(),Name = "Bronze Shield", Price=22, CreatedDate =DateTimeOffset.UtcNow }

        };
        //GET/items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            return items;
        }
        public Task<Item> GetItem(Guid id){
            var item = items.Where(item => item.Id ==id).SingleOrDefault();
        }

    }
}