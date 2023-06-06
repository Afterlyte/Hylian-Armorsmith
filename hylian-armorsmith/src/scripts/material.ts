export enum MaterialType {
  None = "",
  BokoblinHorn = "Bokoblin Horn",
  LynelGuts = "Lynel Guts",
  ChuchuJelly = "Chuchu Jelly",
}

export class Material {
  type: MaterialType;
  count: number;

  constructor(type: MaterialType, count: number) {
    this.type = type ?? MaterialType.None;
    this.count = count;
  }

  get typeName() {
    return this.type.toString();
  }
}
