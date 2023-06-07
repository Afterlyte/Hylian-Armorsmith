namespace Armorsmith.Api.Data
{
    public enum MaterialType
    {
        None,
        KeeseWing,
        Rushroom,
        ElectricKeeseWing,
        HightailLizard,
        HotFootedFrog,
        IceKeeseWing,
        SwiftViolet,
        FireKeeseWing
    }

    public class Material
    {
        public MaterialType Type { get; set; } = MaterialType.None;
        public int Count { get; set; }

        public Material(MaterialType type, int count)
        {
            Type = type;
            Count = count;
        }
    }
}
