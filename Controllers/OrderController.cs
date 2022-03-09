using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using WebAppOrder.Domain;

namespace WebAppOrder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        public IActionResult InsertOrder(Order order)
        {
            try
            {

                return Accepted(order);
            }
            catch (Exception ex)
            {
                _logger.LogError("Erro ao tentar criar um novo pedido");

                return new StatusCodeResult(500);
            }
        }
    }
}
