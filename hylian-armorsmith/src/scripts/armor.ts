import { Material } from "./material";

export enum ArmorSlot {
  Head = "Head",
  Body = "Body",
  Legs = "Legs",
}

export enum ArmorSet {
  None = "None",
  Archaic = "Archaic",
  Hylian = "Hylian",
  RoyalGuard = "Royal Guard",
  Soldiers = "Soldier's",
  Awakening = "Awakening",
  Barbarian = "Barbarian",
  Charged = "Charged",
  Climbers = "Climbers",
  Dark = "Dark",
  Depths = "Depths",
  DesertVoe = "Desert Voe",
  Ember = "Ember",
  FierceDeity = "Fierce Deity",
  Flamebreaker = "Flamebreaker",
  Froggy = "Froggy",
  Frostbite = "Frostbite",
  Glide = "Glide",
  Hero = "Hero",
  Miner = "Miner's",
  Radiant = "Radiant",
  Rubber = "Rubber",
  Sky = "Sky",
  Snowquill = "Snowquill",
  Stealth = "Stealth",
  Time = "Time",
  Twilight = "Twilight",
  Wild = "Wild",
  Wind = "Wind",
  Yiga = "Yiga",
  Zonaite = "Zonaite",
  Zora = "Zora",
  EvilSpirit = "Evil Spirit",
  Mystic = "Mystic",
  Phantom = "Phantom",
  Tingle = "Tingle",
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
