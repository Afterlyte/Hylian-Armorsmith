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
            var armorLines = System.IO.File.ReadAllLines("Content/Armor.csv");
            if (db.Armors.Count() < armorLines.Length / 5)
            {
                for (int i = 0; i < armorLines.Length; i += 5)
                {
                    var parts = armorLines[i].Split(",");
                    Armor armor = new()
                    {
                        Set = parts[1],
                        Slot = parts[2],
                        Name = parts[3]
                    };
                    armor.DefensePoints.Add(new()
                    {
                        DefensePoints = int.Parse(parts[0])
                    });
                    for (int j = 1; j < 5; j++)
                    {
                        parts = armorLines[i + j].Split(",");
                        armor.DefensePoints.Add(new()
                        {
                            DefensePoints = int.Parse(parts[0])
                        });
                        for (int k = 1; k < parts.Length; k += 2)
                        {
                            if (!(parts[k] == "")) armor.UpgradeMaterials.Add(new()
                            {
                                Level = j - 1,
                                Material = parts[k],
                                Count = int.Parse(parts[k + 1])
                            });
                        }
                    }
                    db.Armors.Add(armor);
                }
                db.SaveChanges();
            }
        }
    }
}
