using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REDJayREST.Models.EF;
using System.Linq;
namespace REDJayREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminApprovalController : ControllerBase
    {
        redjayDBContext dbREDJay = new redjayDBContext();

        [HttpPut]
        [Route("Approve_Boots/{changes:int}")]
        public IActionResult EditBoots(int changes)
        {

            var editboots = (from c in dbREDJay.UserBoots
                                     where c.PkBootsId == changes
                                     select c).SingleOrDefault();
            if (editboots != null)
            {
                editboots.AdminApproval = true;
                dbREDJay.SaveChanges();
               
                       return Ok("Boots have been approved");
                
            }
            else
            {
                return BadRequest("Boots have not been approved");
            }

        }
        //done--------------------------------------------------------------
        [HttpPut]
        [Route("Approve_FullPieceSuit/{changes:int}")]
        public IActionResult EditFullPieceSuit(int changes)
        {

            var editfullpiecesuit = (from c in dbREDJay.UserFullPieceSuits
                                     where c.PkFullSuit == changes
                                     select c).SingleOrDefault();
            if (editfullpiecesuit != null)
            {
                editfullpiecesuit.AdminApproval = true;
                dbREDJay.SaveChanges();

                return Ok("Full Piece Suit has been approved");

            }
            else
            {
                return BadRequest("Full Piece Suit has not been approved");
            }

        }
        //done--------------------------------------------------------------

        [HttpPut]
        [Route("Approve_JacketsCoat/{changes:int}")]
        public IActionResult EditJacketsCoat(int changes)
        {

            var editjacketscoat = (from c in dbREDJay.UserJacketsCoats
                                     where c.PkJacketCoatId == changes
                                     select c).SingleOrDefault();
            if (editjacketscoat != null)
            {
                editjacketscoat.AdminApproval = true;
                dbREDJay.SaveChanges();

                return Ok("Jackets and Coats have been approved");

            }
            else
            {
                return BadRequest("Jackets and Coats have not been approved");
            }

        }
        //done--------------------------------------------------------------

        [HttpPut]
        [Route("Approve_Jeans{changes:int}")]
        public IActionResult EditJeans(int changes)
        {

            var editjeans = (from c in dbREDJay.UserJeans
                                   where c.PkJeansId == changes
                                   select c).SingleOrDefault();
            if (editjeans != null)
            {
                editjeans.AdminApproval = true;
                dbREDJay.SaveChanges();

                return Ok("Jeans have been approved");

            }
            else
            {
                return BadRequest("Jeans have not been approved");
            }

        }

        //done--------------------------------------------------------------

        [HttpPut]
        [Route("Approve_Sandals{changes:int}")]
        public IActionResult EditSandals(int changes)
        {

            var editsandal = (from c in dbREDJay.UserSandals
                              where c.PkSandalsId == changes
                              select c).SingleOrDefault();
            if (editsandal != null)
            {
                editsandal.AdminApproval = true;
                dbREDJay.SaveChanges();

                return Ok("Sandals have been approved");

            }
            else
            {
                return BadRequest("Sandals and Coats have not been approved");
            }

        }
        //done--------------------------------------------------------------


        [HttpPut]
        [Route("Approve_Shirts{changes:int}")]
        public IActionResult EditShirts(int changes)
        {

            var editshirt = (from c in dbREDJay.UserShirts
                             where c.PkShirtId == changes
                             select c).SingleOrDefault();
            if (editshirt != null)
            {
                editshirt.AdminApproval = true;
                dbREDJay.SaveChanges();

                return Ok("Shirts have been approved");

            }
            else
            {
                return BadRequest("Shirts have not been approved");
            }

        }
        //done--------------------------------------------------------------


        [HttpPut]
        [Route("Approve_Sneakers{changes:int}")]
        public IActionResult EditSneakers(int changes)
        {

            var editsneaker = (from c in dbREDJay.UserSneakers
                               where c.PkSneakerId == changes
                               select c).SingleOrDefault();
            if (editsneaker != null)
            {
                editsneaker.AdminApproval = true;
                dbREDJay.SaveChanges();

                return Ok("Sneakers have been approved");

            }
            else
            {
                return BadRequest("Sneakers have not been approved");
            }

        }

        //done--------------------------------------------------------------

        [HttpPut]
        [Route("Approve_SuitTop{changes:int}")]
        public IActionResult EditSuitTop(int changes)
        {

            var editsuittop = (from c in dbREDJay.UserSuitTops
                               where c. PkSuitTop == changes
                               select c).SingleOrDefault();
            if (editsuittop != null)
            {
                editsuittop.AdminApproval = true;
                dbREDJay.SaveChanges();

                return Ok("Suit Top has been approved");

            }
            else
            {
                return BadRequest("Suit Top has not been approved");
            }

        }

        //done--------------------------------------------------------------

        [HttpPut]
        [Route("Approve_SuitBottom{changes:int}")]
        public IActionResult EditSuitBottom(int changes)
        {

            var editsuitbottom = (from c in dbREDJay.UserSuitBottoms
                                  where c.PkSuitBottom == changes
                                  select c).SingleOrDefault();
            if (editsuitbottom != null)
            {
                editsuitbottom.AdminApproval = true;
                dbREDJay.SaveChanges();

                return Ok("Suit Bottom has been approved");

            }
            else
            {
                return BadRequest("Suit Bottom has not been approved");
            }

        }
        //done--------------------------------------------------------------


        [HttpPut]
        [Route("Approve_Shorts{changes:int}")]
        public IActionResult EditShorts(int changes)
        {

            var editshorts = (from c in dbREDJay.UserShorts
                              where c.PkShortsId == changes
                              select c).SingleOrDefault();
            if (editshorts != null)
            {
                editshorts.AdminApproval = true;
                dbREDJay.SaveChanges();

                return Ok("Shorts have been approved");

            }
            else
            {
                return BadRequest("Shorts have not been approved");
            }

        }

        //done--------------------------------------------------------------

        [HttpPut]
        [Route("Approve_TankTops{changes:int}")]
        public IActionResult EditTankTops(int changes)
        {

            var edittanktop = (from c in dbREDJay.UserTankTops
                               where c.PkTankTopId == changes
                               select c).SingleOrDefault();
            if (edittanktop != null)
            {
                edittanktop.AdminApproval = true;
                dbREDJay.SaveChanges();

                return Ok("Tank Tops have been approved");

            }
            else
            {
                return BadRequest("Tank Tops have not been approved");
            }

        }
        //done--------------------------------------------------------------


        [HttpPut]
        [Route("Approve_Sweats{changes:int}")]
        public IActionResult EditSweats(int changes)
        {

            var editsweats = (from c in dbREDJay.UserSweats
                              where c.PkSweatsId == changes
                              select c).SingleOrDefault();
            if (editsweats != null)
            {
                editsweats.AdminApproval = true;
                dbREDJay.SaveChanges();

                return Ok("Sweats have been approved");

            }
            else
            {
                return BadRequest("Sweats have not been approved");
            }

        }





    }
}
