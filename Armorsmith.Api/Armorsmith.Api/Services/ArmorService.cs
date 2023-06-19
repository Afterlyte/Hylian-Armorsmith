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

        public async Task<List<Armor>> GetFilteredArmorListAsync(string[] setFilters, string[] slotFilters)
        {
            return await _db.Armors
                .Include(a => a.DefensePoints)
                .Include(a => a.UpgradeMaterials)
                .Where(a => setFilters.Contains(a.Set) && slotFilters.Contains(a.Slot)).ToListAsync();
        }

        public async Task<List<string>> GetFullMaterialListAsync()
        {
            List<string> materials = new();
            await _db.Armors.Include(a => a.UpgradeMaterials).ForEachAsync(a => a.UpgradeMaterials.ForEach(m => materials.Add("'" + m.Material! + "'' = '" + m.Material! + "'")));
            return materials.Distinct().OrderBy(m => m).ToList();
        }

        public async Task<List<string>> GetFullArmorSetListAsync()
        {
            List<string> armorSets = new();
            await _db.Armors.ForEachAsync(a => armorSets.Add("'" + a.Set! + "'' = '" + a.Set! + "'"));
            return armorSets.Distinct().OrderBy(a => a).ToList();
        }
    }
}