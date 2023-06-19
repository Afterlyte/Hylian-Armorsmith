import { Material, MaterialType } from "./material";

export enum ArmorSlot {
  Head = "Head",
  Body = "Body",
  Legs = "Legs",
}

export enum ArmorSet {
  Archaic = "Archaic",
  Awakening = "Awakening",
  Barbarian = "Barbarian",
  Charged = "Charged",
  Climbers = "Climbers",
  Dark = "Dark",
  Depths = "Depths",
  DesertVoe = "Desert Voe",
  Ember = "Ember",
  EvilSprit = "Evil Sprit",
  FierceDeity = "Fierce Deity",
  Flamebreaker = "Flamebreaker",
  Froggy = "Froggy",
  Frostbite = "Frostbite",
  Glide = "Glide",
  Hero = "Hero",
  Hylian = "Hylian",
  Miners = "Miners",
  Mystic = "Mystic",
  None = "Miscellaneous",
  Phantom = "Phantom",
  Radiant = "Radiant",
  RoyalGuard = "Royal Guard",
  Rubber = "Rubber",
  Sky = "Sky",
  Snowquill = "Snowquill",
  Soldiers = "Soldiers",
  Stealth = "Stealth",
  Time = "Time",
  Tingle = "Tingle",
  Twilight = "Twilight",
  Wild = "Wild",
  Wind = "Wind",
  Yiga = "Yiga",
  Zonaite = "Zonaite",
  Zora = "Zora",
}

export class Armor {
  id: number = -1;
  name: string;
  set: ArmorSet;
  slot: ArmorSlot;
  defensePoints: Array<number>;
  upgradeMaterials: Array<Material>;

  constructor(
    id: number,
    set: ArmorSet = ArmorSet.None,
    slot: ArmorSlot,
    name: string,
    defensePoints: Array<number>,
    upgradeMaterials: Array<Material>
  ) {
    this.id = id;
    this.set = set;
    this.slot = slot;
    this.name = name;
    this.defensePoints = defensePoints;
    this.upgradeMaterials = upgradeMaterials;
  }
}
