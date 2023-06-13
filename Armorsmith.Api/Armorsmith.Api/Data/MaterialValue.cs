using System.ComponentModel.DataAnnotations;

namespace Armorsmith.Api.Data
{
    public class MaterialValue
    {
        [Key]
        public int Id { get; set; }
        public int Level { get; set; }
        public string? Material { get; set; }
        public int Count { get; set; }
    }
}
