using System.Collections.Generic;
//Where able to access the character data/objects through the dotnet_rpg Models directorives/
using dotnet_rpg.Models;

//We add CharacterService so we can access the CharacterService folder
namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        //Creating the interface methods (aka the abstract files like a header in) with its return type, name, parameters/arguements
        Task<List<Character>> GetAllCharacters();
        Task<Character> GetCharacterById(int id);
        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}