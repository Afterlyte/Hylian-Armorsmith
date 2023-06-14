using System.ComponentModel.DataAnnotations;

namespace Armorsmith.Api.Data
{
    public class Armor
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Set { get; set; }
        public string? Slot { get; set; }
        public List<Defense> DefensePoints { get; set; } = new List<Defense>(5);
        public List<MaterialValue> UpgradeMaterials { get; set; } = new List<MaterialValue>(4);
    }
}
