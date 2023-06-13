namespace Armorsmith.Api.Data
{
    public class Armor
    {
        public string Name { get; set; } = string.Empty;
        public int Set { get; set; }
        public int Slot { get; set; }
        public int[] DefensePoints { get; set; } = new int[5];
        public string[][] UpgradeMaterials { get; set; } = new string[4][];
    }
}
