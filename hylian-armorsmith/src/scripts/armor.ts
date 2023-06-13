import { Material } from "./material";

export enum ArmorSlot {
  Head = 0,
  Body = 1,
  Legs = 2,
}

export enum ArmorSet {
  None = -1,
  Awakening = 0,
  Barbarian = 1,
  Charged = 2,
  Climbing = 3,
  Dark = 4,
  Depths = 5,
  DesertVoe = 6,
  Ember = 7,
  FierceDeity = 8,
  Flamebreaker = 9,
  Froggy = 10,
  Frostbite = 11,
  Glide = 12,
  Hero = 13,
  Hylian = 14,
  Miner = 15,
  Radiant = 16,
  RoyalGuard = 17,
  Rubber = 18,
  Sky = 19,
  Snowquill = 20,
  Soldier = 21,
  Stealth = 22,
  Time = 23,
  Twilight = 24,
  Wild = 25,
  Wind = 26,
  Yiga = 27,
  Zonaite = 28,
  Zora = 29,
  AmberEarrings = 30,
  AncientHerosAspects = 31,
  ChampionsTunic = 32,
  DiamondCirclet = 33,
  OpalEarrings = 34,
  RubyCirclet = 35,
  SandBoots = 36,
  SapphireCirclet = 37,
  SheiksMask = 38,
  SnowBoots = 39,
  TopazEarrings = 40,
  TunicOfMemories = 41,
  VahMedohDivineHelm = 42,
  VahNaborisDivineHelm = 43,
  VahRudaniaDivineHelm = 44,
  VahRutaDivineHelm = 45,
}

export enum Level {
  Base = 0,
  LevelOne = 1,
  LevelTwo = 2,
  LevelThree = 3,
  LevelFour = 4,
}

export class Armor {
  set: ArmorSet;
  slot: ArmorSlot;
  name: string;
  defensePoints: number;
  level: Level;
  upgradeMaterials: Material[][];

  constructor(
    set: ArmorSet = ArmorSet.None,
    slot: ArmorSlot,
    name: string,
    defensePoints: number,
    level: Level = Level.Base,
    upgradeMaterials: Material[][]
  ) {
    this.set = set;
    this.slot = slot;
    this.name = name;
    this.defensePoints = defensePoints;
    this.level = level;
    this.upgradeMaterials = upgradeMaterials;
  }

  upgradeLevelMaterials(upgradeLevel: number): Array<Material> {
    return this.upgradeMaterials[upgradeLevel - 1];
  }

  get id(): number {
    return this.set.valueOf() * 3 + this.slot.valueOf();
  }
}
