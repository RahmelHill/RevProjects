using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Resturant_webapi.Models;

namespace Resturant_webapi.Controllers
{
    #region OrdersController
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;

        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        OrdersInfo model = new OrdersInfo();

        [HttpPost]
        [Route("makeOrder")]
        public IActionResult MakeOrder(OrdersInfo newOrder)
        {
            try
            {
                return Created("", model.MakeOrder(newOrder));
            }
            catch (System.Exception es)
            {
                return BadRequest(es.Message);
            }
        }
        [HttpGet]
        [Route("listOfOrders")]
        public IActionResult GetOrdersList()
        {
            return Ok(model.GetOrdersList());
        }

        [HttpGet]
        [Route("ordersById")]
        public IActionResult GetOrdersInfo(int cust_Id)
        {
            try
            {
                return Ok(model.GetOrdersInfo(cust_Id));
            }
            catch (System.Exception es)
            {

                return BadRequest(es.Message);
            }
        //}
        //[HttpGet]
        //[Route("totalCost")]
        //public IActionResult GetOrdersTotal(int cust_Id)
        //{
        //    try
        //    {
        //        return Ok(model.GetOrdersTotal(cust_Id));
        //    }
        //    catch (System.Exception es)
        //    {

        //        return BadRequest(es.Message);
        //    }
        }
        #endregion
    }
}
