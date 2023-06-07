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
            if(db.Armors.Any())
            {
                var climbersBandana = new Armor("Climber's Bandana", ArmorSet.Climbers, ArmorSlot.Head, 3, Level.Base);
                climbersBandana.SetUpgradeMaterials(new Material[] { new Material(MaterialType.KeeseWing, 3), new Material(MaterialType.Rushroom, 3) }, 1);
                climbersBandana.SetUpgradeMaterials(new Material[] { new Material(MaterialType.ElectricKeeseWing, 5), new Material(MaterialType.HightailLizard, 5) }, 2);
                climbersBandana.SetUpgradeMaterials(new Material[] { new Material(MaterialType.HotFootedFrog, 10), new Material(MaterialType.IceKeeseWing, 8) }, 3);
                climbersBandana.SetUpgradeMaterials(new Material[] { new Material(MaterialType.SwiftViolet, 20), new Material(MaterialType.FireKeeseWing, 10) }, 4);
                db.Armors.Add(climbersBandana);
                var climbingGear = new Armor("Climbing Gear", ArmorSet.Climbers, ArmorSlot.Body, 3, Level.Base);
                climbingGear.SetUpgradeMaterials(new Material[] { new Material(MaterialType.KeeseWing, 3), new Material(MaterialType.Rushroom, 3) }, 1);
                climbingGear.SetUpgradeMaterials(new Material[] { new Material(MaterialType.ElectricKeeseWing, 5), new Material(MaterialType.HightailLizard, 5) }, 2);
                climbingGear.SetUpgradeMaterials(new Material[] { new Material(MaterialType.HotFootedFrog, 10), new Material(MaterialType.IceKeeseWing, 8) }, 3);
                climbingGear.SetUpgradeMaterials(new Material[] { new Material(MaterialType.SwiftViolet, 20), new Material(MaterialType.FireKeeseWing, 10) }, 4);
                db.Armors.Add(climbersBandana);
                var climbingBoots = new Armor("Climbing Boots", ArmorSet.Climbers, ArmorSlot.Legs, 3, Level.Base);
                climbingBoots.SetUpgradeMaterials(new Material[] { new Material(MaterialType.KeeseWing, 3), new Material(MaterialType.Rushroom, 3) }, 1);
                climbingBoots.SetUpgradeMaterials(new Material[] { new Material(MaterialType.ElectricKeeseWing, 5), new Material(MaterialType.HightailLizard, 5) }, 2);
                climbingBoots.SetUpgradeMaterials(new Material[] { new Material(MaterialType.HotFootedFrog, 10), new Material(MaterialType.IceKeeseWing, 8) }, 3);
                climbingBoots.SetUpgradeMaterials(new Material[] { new Material(MaterialType.SwiftViolet, 20), new Material(MaterialType.FireKeeseWing, 10) }, 4);
                db.Armors.Add(climbersBandana);
            }
        }
    }
}
