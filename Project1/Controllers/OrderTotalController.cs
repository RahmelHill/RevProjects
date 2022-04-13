using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Resturant_webapi.Models;


namespace Resturant_webapi.Controllers
{
    #region Ordertotal
    [Route("api/[controller]")]
    [ApiController]
    public class OrderTotalController : ControllerBase
    {
        private readonly ILogger<OrderTotalController> _logger;

        public OrderTotalController(ILogger<OrderTotalController> logger)
        {
            _logger = logger;
        }
        OrderTotalModel model = new OrderTotalModel();
        [HttpGet]
        [Route("totalCost")]
        public IActionResult GetOrdersTotal(int cust_Id)
        {
            try
            {
                return Ok(model.GetOrdersTotal(cust_Id));
            }
            catch (System.Exception es)
            {

                return BadRequest(es.Message);
            }
        }
        #endregion
    }

}