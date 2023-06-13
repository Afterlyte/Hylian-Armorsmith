using System.ComponentModel.DataAnnotations;

namespace Armorsmith.Api.Data
{
    public class Defense
    {
        [Key]
        public int Id { get; set; }
        public int DefensePoints { get; set; }
    }
}
