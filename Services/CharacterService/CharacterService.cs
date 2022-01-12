
using dotnet_rpg.Models;


namespace dotnet_rpg.Services.CharacterService
{
    //This is the implementation class of the abstract class ICharacterService.cs
    //We add " : ICharacterService" so we can access the abstract methods and implement them
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{ Id=1, Name = "Sam"}
        };

        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            //Finds/Returns the first element in the list that matches the id if not it returns a null value
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}