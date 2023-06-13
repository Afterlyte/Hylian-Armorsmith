namespace Armorsmith.Api.Data
{
    public static class Seeder
    {
        public static void Seed(AppDbContext context)
        {
            SeedArmor(context);
        }

        public static void SeedArmor(AppDbContext db)
        {
            if (!db.Armors.Any())
            {
                var armorLines = System.IO.File.ReadAllLines("Content/Armor.csv");
                for (int i = 0; i < armorLines.Length; i += 5)
                {
                    var parts = armorLines[i].Split(",");
                    Armor armor = new()
                    {
                        Set = int.Parse(parts[1]),
                        Slot = int.Parse(parts[2]),
                        Name = parts[3]
                    };
                    armor.DefensePoints[0] = int.Parse(parts[0]);
                    for (int j = 1; j < 5; j++)
                    {
                        parts = armorLines[i + j].Split(",");
                        armor.DefensePoints[j] = int.Parse(parts[0]);
                        List<string> materials = new();
                        for (int k = 1; k < parts.Length; k += 2)
                        {
                            materials.Add(parts[k].Trim());
                            materials.Add(parts[k + 1].Trim());
                        }
                        armor.UpgradeMaterials[j - 1] = materials.ToArray();
                    }
                }
            }
        }
    }
}
