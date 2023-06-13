using System.ComponentModel.DataAnnotations;

namespace Armorsmith.Api.Data
{
    public class Armor
    {
        [Key]
        public string? Name { get; set; }
        public int Set { get; set; }
        public int Slot { get; set; }
        public List<Defense> DefensePoints { get; set; } = new List<Defense>(5);
        public List<MaterialValue> UpgradeMaterials { get; set; } = new List<MaterialValue>(4);
    }
}
