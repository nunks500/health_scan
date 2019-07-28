using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using healthscan_BE.Handlers;
using healthscan_BE.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace healthscan_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductHandler productHandler;

        public ProductController(IProductHandler productHandler)
        {
            this.productHandler = productHandler;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<Product> Get(int barcodeId)
        {
             return await this.productHandler.GetProductByBarcode(barcodeId);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
