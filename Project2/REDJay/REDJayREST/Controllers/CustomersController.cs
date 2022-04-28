using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REDJayREST.Models.EF;
namespace REDJayREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        redjayDBContext dbREDJay = new redjayDBContext();

        [HttpGet]
        [Route("List_of_Customers")]
        public IActionResult GetCustomerslist()
        {
            var output =
            from c in dbREDJay.Customers
            join ci in dbREDJay.Cities on c.FkCityId equals ci.PkCityId
            join s in dbREDJay.States on c.FkStateId equals s.PkStateId
            join con in dbREDJay.Countries on c.FkCountryId equals con.PkCountryId
            join u in dbREDJay.Users on c.FkUsernameId equals u.PkUserId
            select new
            {
                c.CustomerFirstName,
                c.CustomerLastName,
                c.CustomerAddress,
                ci.CityName,
                s.StateName,
                con.CountryName,
                u.UserName,

            };
            return Ok(output);
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
        //adding a new cust needs username first
        [HttpPost]
        [Route("Register_Customer")]


        public IActionResult AddCustomer(string FirstName, string LastName, string Address, string email, int usernameID, int cityID, int stateID, int countryID)
        {
            Customer newCust = new Customer() { CustomerFirstName = FirstName, CustomerLastName = LastName, CustomerAddress = Address, CustomerEmail = email,FkUsernameId = usernameID, FkCityId = cityID, FkStateId = stateID, FkCountryId = countryID };
            
            if (newCust != null)
            {
                Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Customer> entityEntry = dbREDJay.Customers.Add(newCust);
                dbREDJay.SaveChanges();
                return Created("", "Customer Added Successfully");
            }
            else
                return BadRequest("Unsuccessful Customer Registration");

        }



    }
}
