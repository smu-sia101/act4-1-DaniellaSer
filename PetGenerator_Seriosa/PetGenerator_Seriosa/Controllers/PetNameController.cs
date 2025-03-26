using Microsoft.AspNetCore.Mvc;

namespace PetGenerator_Seriosa.Controllers
{
    [ApiController]
    [Route("api/petname")]
    public class PetNameController : ControllerBase
    {
        private string[] dog = new string[] {
            "Buddy", "Max", "Charlie", "Rocky", "Rex"
        };

        private string[] cat = new string[] {
            "Whiskers", "Mittens", "Luna", "Simba", "Tiger"
        };

        private string[] bird = new string[] {
            "Tweety", "Sky", "Chirpy", "Raven", "Sunny"
        };

        [HttpPost("generate")]
        public IActionResult Post(string animaltype)
        {
            Random rnd = new Random();
            string generatedName = string.Empty;

            if (animaltype == "dog")
            {
                int dogIndex = rnd.Next(dog.Length);
                generatedName = dog[dogIndex];
            }
            else if (animaltype == "cat")
            {
                int catIndex = rnd.Next(cat.Length);
                generatedName = cat[catIndex];
            }
            else if (animaltype == "bird")
            {
                int birdIndex = rnd.Next(bird.Length);
                generatedName = bird[birdIndex];
            }
            else
            {
                return BadRequest("Invalid");
            }

            return Ok(new { animaltype = animaltype,name = generatedName});
        }
    }
}
