using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REDJayREST.Models.EF;
namespace REDJayREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        redjayDBContext dbREDJay = new redjayDBContext();

        [HttpGet]
        [Route("List_of_Boots")]
        public IActionResult GetBootslist()
        {
            var bootslist = from b in dbREDJay.Boots
                            select b;
            return Ok(bootslist);
        }

        [HttpGet]
        [Route("List_of_Full_Piece_Suits")]
        public IActionResult GetFullPieceSuitList()
        {
            var suitslist = from s in dbREDJay.FullPieceSuits
                            select s;
            return Ok(suitslist);
        }

        [HttpGet]
        [Route("List_of_Jackets/Coats")]
        public IActionResult GetJacketslist()
        {
            var jacketslist = from j in dbREDJay.JacketsCoats
                              select j;
            return Ok(jacketslist);
        }

        [HttpGet]
        [Route("List_of_Jeans")]
        public IActionResult GetJeanslist()
        {
            var jeanslist = from j in dbREDJay.Jeans
                            select j;
            return Ok(jeanslist);
        }

        [HttpGet]
        [Route("List_of_Sandals")]
        public IActionResult GetSandalslist()
        {
            var sandalslist = from s in dbREDJay.Sandals
                              select s;
            return Ok(sandalslist);
        }

        [HttpGet]
        [Route("List_of_Shorts")]
        public IActionResult GetClotheslist()
        {
            var shortslist = from s in dbREDJay.Shorts
                             select s;
            return Ok(shortslist);
        }

        [HttpGet]
        [Route("List_of_Sneakers")]
        public IActionResult GetSneakerslist()
        {
            var sneakerslist = from s in dbREDJay.Sneakers
                               select s;
            return Ok(sneakerslist);
        }

        [HttpGet]
        [Route("List_of_Suit_Bottoms")]
        public IActionResult GetSuitBottomslist()
        {
            var suitbottomslist = from b in dbREDJay.SuitBottoms
                                  select b;
            return Ok(suitbottomslist);
        }

        [HttpGet]
        [Route("List_of_Suit_Tops")]
        public IActionResult GetSuitTopslist()
        {
            var suittopslist = from t in dbREDJay.SuitTops
                               select t;
            return Ok(suittopslist);
        }

        [HttpGet]
        [Route("List_of_Sweats")]
        public IActionResult GetSweatslist()
        {
            var sweatslist = from s in dbREDJay.Sweats
                             select s;
            return Ok(sweatslist);
        }


        [HttpGet]
        [Route("List_of_Shirts")]
        public IActionResult GetShirtslist()
        {
            var shirtslist = from t in dbREDJay.Shirts
                              select t;
            return Ok(shirtslist);
        }

        [HttpGet]
        [Route("List_of_Tank_Tops")]
        public IActionResult GetTankTopslist()
        {
            var tanktopslist = from b in dbREDJay.Boots
                               select b;
            return Ok(tanktopslist);
        }
    }
}
