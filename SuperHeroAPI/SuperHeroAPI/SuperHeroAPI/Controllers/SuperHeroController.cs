using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes()
        {
            return new List<SuperHero>
            {
                new SuperHero
                {
                     FirstName = "Peter",
                     LastName = "Parker",
                     Name = "SpiderMan",
                     Place = "NYC",
                }
            };
        }

    }
}
