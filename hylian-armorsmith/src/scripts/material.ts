export enum MaterialType {
  None = "",
  BokoblinHorn = "Bokoblin Horn",
  LynelGuts = "Lynel Guts",
  ChuchuJelly = "Chuchu Jelly",
}

export class Material {
  level: number = 0;
  material: MaterialType;
  count: number;

  constructor(type: MaterialType, count: number, level: number) {
    this.material = type ?? MaterialType.None;
    this.count = count;
    this.level = level;
  }

  get typeName() {
    return this.material.toString();
  }
}
