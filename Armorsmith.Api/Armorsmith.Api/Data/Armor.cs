namespace Armorsmith.Api.Data
{
    public enum ArmorSet
    {
        Hylian = 0,
        Climbers = 1,
        Stealth = 2,
        Radiant = 3,
        Other
    }

    public enum ArmorSlot
    {
        Head = 0,
        Body = 1,
        Legs = 2
    }

    public enum Level
    {
        Base = 0,
        LevelOne = 1,
        LevelTwo = 2,
        LevelThree = 3,
        LevelFour = 4
    }

    public class Armor
    {
        public string Name { get; set; }
        public ArmorSet Set { get; set; }
        public ArmorSlot Slot { get; set; }
        public int DefensePoints { get; set; }
        public Level Level { get; set; }
        public Material[][] UpgradeMaterials { get; set; }

        public Armor(string name, ArmorSet set, ArmorSlot slot, int defensePoints, Level level)
        {
            Name = name;
            Set = set;
            Slot = slot;
            DefensePoints = defensePoints;
            Level = level;
            UpgradeMaterials = new Material[4][];
        }

        public void SetUpgradeMaterials(Material[] materials, int level)
        {
            UpgradeMaterials[level - 1] = materials;
        }
    }
}
