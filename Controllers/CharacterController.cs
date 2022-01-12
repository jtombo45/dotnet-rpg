using dotnet_rpg.Models;
using dotnet_rpg.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    //Adding attributes:
    //This attribute indicates the type and the derive types used to serve HTTP API responses, and enables several API specific features
    //like attribute routing and automatic HTTP 400 responses, if something is wrong with the models 
    [ApiController]
    //This is the routing attribute: means that this controller can be accessed by its name. In our case, it would be character
    [Route("[controller]")]
    //Controller Base is a base class for MVC controller without View Support, but can add View if we use Controller instead, must have user directive
    public class CharacterController : ControllerBase
    {
        //Injecting the Service
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            //The underscore is similar to using "this" to initialize a variable which calls the character service
            _characterService = characterService;
        }

        //This allows us to send specific HTTP status codes backs to client together with the actual data that we requested
        //It also combines the Route which is used to define the URL extension needed in order to get the data
        [HttpGet("GetAll")]
        //[Route("GetAll")]
        public async Task<ActionResult<List<Character>>> Get()
        {
            //With Ok(knight) we sent the status code 200 ok and our mock character back
            //Other options would be something like a bad request for 400 -> BadRequest(knight)
            //Or 404 not found status code -> NotFound(knight)
            //We use "await" keyword to the actual service call and that's how we can asynchronous method
            return Ok(await _characterService.GetAllCharacters());
        }
        //We use brackets: {} to pass arguements
        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetSingle(int id)
        {
            //Finds/Returns the first element in the list that matches the id if not it returns a null value
            return Ok(await _characterService.GetCharacterById(id));
        }
        [HttpPost]
        //Adding a new character with the POST method
        public async Task<ActionResult<Character>> AddCharacter(Character newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}