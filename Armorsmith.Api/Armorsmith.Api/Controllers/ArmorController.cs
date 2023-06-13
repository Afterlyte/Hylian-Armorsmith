using Armorsmith.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace Armorsmith.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArmorController
    {
        private readonly ArmorService _armorService;

        public ArmorController(ArmorService armorService)
        {
            _armorService = armorService;
        }

        [HttpGet("Armor")]
        public async Task<Armor> GetArmor(string name)
        {
            return await _armorService.GetArmorAsync(name);
        }

        [HttpPost("FilteredArmorList")]
        public async Task<List<Armor>> GetFilteredArmorList(int[] setFilters, bool head, bool body, bool legs)
        {
            List<int> slots = new List<int>();
            if (head) slots.Add(0);
            if (body) slots.Add(1);
            if (legs) slots.Add(2);
            return await _armorService.GetFilteredArmorListAsync(setFilters, slots.ToArray());
        }
    }
}
