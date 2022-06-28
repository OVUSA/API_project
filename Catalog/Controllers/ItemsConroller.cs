using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using Catalog.Entities;
using System.Collections.Generic;
namespace Catalog.Conrollers
{

    //GET/items
    [ApiController]
    [Route("[items]")]
    public class ItemsConroller : ControllerBase
    {
        private readonly InMemItemsRepository repository;

        public ItemsConroller()
        {
            repository = new InMemItemsRepository();
        }
        //GET
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
        var items  = repository.GetItems();
        return items;
        }
    }
}