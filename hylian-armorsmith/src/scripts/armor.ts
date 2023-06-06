import { Material } from "./material";

export enum ArmorSlot {
  Head = 0,
  Body = 1,
  Legs = 2,
}

export enum ArmorSet {
  Hylian = 0,
  Climbers = 1,
  Other = 2,
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
  upgradeMaterials: Array<Array<Material>>;

  constructor(
    set: ArmorSet = ArmorSet.Other,
    slot: ArmorSlot,
    name: string,
    defensePoints: number,
    level: Level = Level.Base,
    upgradeMaterials: Array<Array<Material>> = new Array<Array<Material>>(4)
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
