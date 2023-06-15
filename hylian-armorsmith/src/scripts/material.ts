export enum MaterialType {
  Amber = "Amber",
  BlackBokoblinHorn = "Black Bokoblin Horn",
  BlackBossBokoblinHorn = "Black Boss Bokoblin Horn",
  BladedRhinoBeetle = "Bladed Rhino Beetle",
  BlueBokoblinHorn = "Blue Bokoblin Horn",
  BlueBossBokoblinHorn = "Blue Boss Bokoblin Horn",
  BlueManedLynelMaceHorn = "Blue-Maned Lynel Mace Horn",
  BlueManedLynelSaberHorn = "Blue-Maned Lynel Saber Horn",
  BlueWhiteFroxFang = "Blue-White Frox Fang",
  BokoblinFang = "Bokoblin Fang",
  BokoblinGuts = "Bokoblin Guts",
  BokoblinHorn = "Bokoblin Horn",
  BossBokoblinGuts = "Boss Bokoblin Guts",
  BossBokoblinHorn = "Boss Bokoblin Horn",
  ChuchuJelly = "Chuchu Jelly",
  DarkClump = "Dark Clump",
  DeepFirefly = "Deep Firefly",
  ElectricDarner = "Electric Darner",
  ElectricKeeseWing = "Electric Keese Wing",
  ElectricLizalfosHorn = "Electric Lizalfos Horn",
  FireKeeseWing = "Fire Keese Wing",
  Flint = "Flint",
  FroxFang = "Frox Fang",
  FroxFingernail = "Frox Fingernail",
  GleeokGuts = "Gleeok Guts",
  GleeokThunderHorn = "Gleeok Thunder Horn",
  HightailLizard = "Hightail Lizard",
  HinoxGuts = "Hinox Guts",
  HotFootedFrog = "Hot-Footed Frog",
  IceKeeseWing = "Ice Keese Wing",
  KeeseEyeball = "Keese Eyeball",
  KeeseWing = "Keese Wing",
  LargeZonaiCharge = "Large Zonai Charge",
  LargeZonaite = "Large Zonaite",
  LizalfosTail = "Lizalfos Tail",
  LuminousStone = "Luminous Stone",
  LynelGuts = "Lynel Guts",
  LynelHoof = "Lynel Hoof",
  LynelMaceHorn = "Lynel Mace Horn",
  LynelSaberHorn = "Lynel Saber Horn",
  MightyThistle = "Mighty Thistle",
  MoblinGuts = "Moblin Guts",
  MoldugaGuts = "Molduga Guts",
  ObsidianFroxFang = "Obsidian Frox Fang",
  RazorclawCrab = "Razorclaw Crab",
  Razorshroom = "Razorshroom",
  Rupee = "Rupee",
  Rushroom = "Rushroom",
  Sapphire = "Sapphire",
  ShockFruit = "Shock Fruit",
  ShockLikeStone = "Shock Like Stone",
  SilverBokoblinHorn = "Silver Bokoblin Horn",
  SilverBossBokoblinHorn = "Silver Boss Bokoblin Horn",
  StarFragment = "Star Fragment",
  SwiftViolet = "Swift Violet",
  ThunderwingButterfly = "Thunderwing Butterfly",
  VoltfinTrout = "Voltfin Trout",
  WhiteManedLynelMaceHorn = "White-Maned Lynel Mace Horn",
  WhiteManedLynelSaberHorn = "White-Maned Lynel Saber Horn",
  Zonaite = "Zonaite",
}

export class Material {
  level: number = 0;
  material: MaterialType;
  count: number;

  constructor(type: MaterialType, count: number, level: number) {
    this.material = type;
    this.count = count;
    this.level = level;
  }
}
