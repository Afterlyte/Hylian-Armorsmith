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
        public async Task<List<Armor>> GetFilteredArmorList(string[] setFilters, bool head, bool body, bool legs)
        {
            List<string> slots = new();
            if (head) slots.Add("Head");
            if (body) slots.Add("Body");
            if (legs) slots.Add("Legs");
            return await _armorService.GetFilteredArmorListAsync(setFilters, slots.ToArray());
        }

        [HttpGet("FullMaterialList")]
        public async Task<List<string>> GetFullMaterialList()
        {
            return await _armorService.GetFullMaterialListAsync();
        }

        [HttpGet("FullArmorSetList")]
        public async Task<List<string>> GetFullArmorSetList()
        {
            return await _armorService.GetFullArmorSetListAsync();
        }
    }
}
