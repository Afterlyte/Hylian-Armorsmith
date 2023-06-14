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
            Armor armor = await _db.Armors
                .Include(a => a.DefensePoints)
                .Include(a => a.UpgradeMaterials)
                .Where(a => a.Name == name).FirstAsync();
            return armor;
        }

        internal async Task<List<Armor>> GetFilteredArmorListAsync(string[] setFilters, string[] slotFilters)
        {
            return await _db.Armors
                .Include(a => a.DefensePoints)
                .Include(a => a.UpgradeMaterials)
                .Where(a => setFilters.Contains(a.Set) && slotFilters.Contains(a.Slot)).ToListAsync();
        }
    }
}