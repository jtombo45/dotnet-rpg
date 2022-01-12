namespace dotnet_rpg.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        //Hitpoints: character's health
        public int HitPoints { get; set; } = 100;
        //Strength: How powerful a character's attack is
        public int Strength { get; set; } = 10;
        //Defense: Skill that reduces the chance an enemy will deal Physical Damage
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;


    }
}