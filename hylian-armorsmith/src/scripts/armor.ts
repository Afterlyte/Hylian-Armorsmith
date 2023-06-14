import { Material } from "./material";

export enum ArmorSlot {
  Head = "Head",
  Body = "Body",
  Legs = "Legs",
}

export enum ArmorSet {
  Archaic = "Archaic",
  Barbarian = "Barbarian",
  Charged = "Charged",
  Climbing = "Climbing",
  Dark = "Dark",
  Depths = "Depths",
  DesertVoe = "Desert Voe",
  Ember = "Ember",
  EvilSpirit = "Evil Sprit",
  FierceDeity = "Fierce Deity",
  Flamebreaker = "Flamebreaker",
  Froggy = "Froggy",
  Frostbite = "Frostbite",
  Glide = "Glide",
  HeroOfAwakening = "Hero of Awakening",
  HeroOfTheSky = "Hero of the Sky",
  HeroOfTheWild = "Hero of the Wild",
  HeroOfTime = "Hero of Time",
  HeroOfTwilight = "Hero of Twilight",
  HeroOfWinds = "Hero of Winds",
  Hero = "Hero",
  Hylian = "Hylian",
  Miner = "Miner",
  Mystic = "Mystic",
  Phantom = "Phantom",
  Radiant = "Radiant",
  RoyalGuard = "Royal Guard",
  Rubber = "Rubber",
  Snowquill = "Snowquill",
  Soldier = "Soldier",
  Stealth = "Stealth",
  Tingle = "Tingle",
  Yiga = "Yiga",
  Zonaite = "Zonaite",
  Zora = "Zora",
  Jewelry = "Jewelry",
  Boots = "Boots",
  Masks = "Masks",
  DivineHelms = "Divine Helms",
  Miscellaneous = "Miscellaneous",
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
    set: ArmorSet = ArmorSet.Miscellaneous,
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
