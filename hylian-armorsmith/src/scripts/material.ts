export enum MaterialType {
  Rupee = "Rupee",
  BokoblinHorn = "Bokoblin Horn",
  BlueBokoblinHorn = "Blue Bokoblin Horn",
  BokoblinFang = "Bokoblin Fang",
  Amber = "Amber",
  BokoblinGuts = "Bokoblin Guts",
  BlackBokoblinHorn = "Black Bokoblin Horn",
  SilverBokoblinHorn = "Silver Bokoblin Horn",
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
