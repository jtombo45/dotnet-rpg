using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
    //Describes the types a character can be for the RPG game
    //Json Converter so it doesn't show int
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        [EnumMember(Value = "Knight")]
        Knight,
        [EnumMember(Value = "Mage")]
        Mage,
        [EnumMember(Value = "Cleric")]
        Cleric
    }
}