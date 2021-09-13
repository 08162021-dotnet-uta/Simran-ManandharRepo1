using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBStoreContext.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsLayer.EFModels;

namespace OnlineStoreUi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            using (OnlineStoreDBContext entities = new OnlineStoreDBContext())
            {
                return entities.Products.ToList();
            }
        }

    }
}