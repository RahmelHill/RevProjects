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
    public class MenuController : ControllerBase
    {
        private readonly ILogger<MenuController> _logger;

        public MenuController(ILogger<MenuController> logger)
        {
            _logger = logger;
        }
        MenuInfo model = new MenuInfo();

        [HttpGet]
        [Route("Menu")]
        public IActionResult GetMenuList()
        {
            return Ok(model.GetMenuList());
        }
    }
}