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

        [HttpGet]
        public async Task<Armor> GetArmor(string name)
        {
            return await _armorService.GetArmorAsync(name);
        }
    }
}
