using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REDJayREST.Models.EF;
namespace REDJayREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        redjayDBContext dbREDJay = new redjayDBContext();

        [HttpGet]
        [Route("UserID")]
        public IActionResult GetUserId()
        {
            var userid = from j in dbREDJay.Users
                              select j;
            return Ok(userid);
        }

        [HttpPost]
        [Route("Make_Username")]
        public IActionResult MakeUsername(string username, string password)
        {
            User newUser = new User() { UserName = username, Password = password };
            if (newUser != null)
            {
                Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<User> entityEntry = dbREDJay.Users.Add(newUser);
                dbREDJay.SaveChanges();
                return Created("", "User added Successfully");
            }
            else
                return BadRequest("User not added successfully");
        }
    }
}
