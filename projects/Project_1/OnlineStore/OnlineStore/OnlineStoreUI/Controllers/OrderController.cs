using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBStoreContext.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsLayer.EFModels;
using Microsoft.EntityFrameworkCore;

namespace OnlineStoreUi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class OrderController : ControllerBase
  {

    private readonly OnlineStoreDBContext _context;

    public OrderController(OnlineStoreDBContext context)
    {
      _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
    {
      return await _context.Orders.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Order>> GetOrder(int id)
    {
      var order = await _context.Orders.FindAsync(id);

      if (order == null)
      {
        return NotFound();
      }

      return order;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutOrder(int id, Order order)
    {
      if (id != order.OrderId)
      {
        return BadRequest();
      }

      _context.Entry(order).State = EntityState.Modified;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!OrderExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }


    [HttpPost]
    public async Task<ActionResult<Order>> PostOrder(Order order)
    {
      _context.Database.ExecuteSqlRaw($"insert into Orders (CustomerId) values ('{order.CustomerId}')");
      await _context.SaveChangesAsync();

      return Created($"~order/{order.OrderId}", order);
    }

    private bool OrderExists(int id)
    {
      return _context.Orders.Any(e => e.OrderId == id);
    }

  }
}