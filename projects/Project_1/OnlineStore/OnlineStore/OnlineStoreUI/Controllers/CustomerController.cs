using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsLayer.EFModels;
using DBStoreContext.Models;

namespace OnlineStoreUi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
            public IEnumerable<Customer> Get()
        {
            using (OnlineStoreDBContext entities = new OnlineStoreDBContext())
            {
                return entities.Customers.ToList();
            }
        }

        //public Customer Get(int id)
        //{
        //    using (OnlineStoreDBContext entities = new OnlineStoreDBContext())
        //    {
        //        return entities.Customers.FirstOrDefault(e => e.CustomerId == id);
        //    }
        //}
    }
}