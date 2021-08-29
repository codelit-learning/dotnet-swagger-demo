using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace SwaggerDemo
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly ILogger<ItemsController> _logger;
        private readonly SwaggerContext _context;

        public ItemsController(ILogger<ItemsController> logger, SwaggerContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IAsyncEnumerable<Item> Get()
        {
            return _context.Items;
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            _context.Add<Item>(item);
            _context.SaveChanges();
            return Ok(true);
        }   
    }
}