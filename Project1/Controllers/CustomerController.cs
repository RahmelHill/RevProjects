using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Resturant_webapi.Models;



namespace Resturant_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        CustomerInfo model = new CustomerInfo();
        [HttpPost]
        [Route("addCustomer")]
        public IActionResult AddCustomer(CustomerInfo newCustomer)
        {
            try
            {
                return Created("", model.AddCustomer(newCustomer));
            }
            catch (System.Exception es)
            {
                return BadRequest(es.Message);
            }
        }
            [HttpGet]
            [Route("customerList")]
            public IActionResult GetCustomerList()
            {
                return Ok(model.GetCustomerList());
            }

            [HttpGet]
            [Route("customerInfo")]
            public IActionResult GetCustomerInfo(int cust_Id)
            {
                try
                {
                    return Ok(model.GetCustomerInfo(cust_Id));
                }
                catch (System.Exception es)
                {

                    return BadRequest(es.Message);
                }
            }

        }
    }
