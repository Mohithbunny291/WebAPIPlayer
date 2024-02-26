using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIPlayer.Model;

namespace WebAPIPlayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        public static List<Player> players = new List<Player>()
        {
            new Player{Id=211, Name="Ramu", AvgScore=1202.41, Team="OSL"},
            new Player{Id=221, Name="Gani", AvgScore=1122.41, Team="OSL"},
            new Player{Id=231, Name="Mani", AvgScore=1402.41, Team="OSL"}

        };
        [HttpGet]
        public ActionResult<IEnumerable<Player>> Get()
        {
            return players;
        }
    }

}
