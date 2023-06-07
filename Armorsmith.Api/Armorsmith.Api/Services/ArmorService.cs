using Armorsmith.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace Armorsmith.Api
{
    public class ArmorService
    {
        private readonly AppDbContext _db;
        
        public ArmorService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Armor> GetArmorAsync(string name)
        {
            Armor armor = await _db.Armors.Where(a => a.Name == name).FirstAsync();
            return armor;
        }
    }
}