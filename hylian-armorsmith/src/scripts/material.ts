export enum MaterialType {
  Rupee = "Rupee",
  BokoblinHorn = "Bokoblin Horn",
  BlueBokoblinHorn = "Blue Bokoblin Horn",
  BokoblinFang = "Bokoblin Fang",
  Amber = "Amber",
  BokoblinGuts = "Bokoblin Guts",
  BlackBokoblinHorn = "Black Bokoblin Horn",
  SilverBokoblinHorn = "Silver Bokoblin Horn",
  HinoxToenail = "Hinox Toenail",
  DinraalScale = "Dinraal's Scale",
  HinoxTooth = "Hinox Tooth",
  DinraalClaw = "Dinraal's Claw",
  HinoxGuts = "Hinox Guts",
  DinraalFang = "Dinraal's Fang",
  DinraalHorn = "Dinraal's Horn",
  LynelGuts = "Lynel Guts",
  NaydraScale = "Naydra's Scale",
  NaydraClaw = "Naydra's Claw",
  NaydraFang = "Naydra's Fang",
  NaydraHorn = "Naydra's Horn",
  FaroshScale = "Farosh's Scale",
  FaroshClaw = "Farosh's Claw",
  FaroshFang = "Farosh's Fang",
  FaroshHorn = "Farosh's Horn",
  KeeseWing = "Keese Wing",
  Rushroom = "Rushroom",
  ElectricKeeseWing = "Electric Keese Wing",
  HightailLizard = "Hightail Lizard",
  HotFootedFrog = "Hot-Footed Frog",
  IceKeeseWing = "Ice Keese Wing",
  SwiftViolet = "Swift Violet",
  FireKeeseWing = "Fire Keese Wing",
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
