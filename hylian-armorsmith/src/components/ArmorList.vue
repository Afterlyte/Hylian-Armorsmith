<template>
  <div class="d-flex flex-column">
    <v-row v-for="a in armorList" :key="a.name" class="px-6 pt-6">
      <v-card width="480" class="pa-4">
        <v-card-title>{{ a.name }}</v-card-title>
        <v-card-subtitle>Current Level</v-card-subtitle>
        <v-radio-group v-bind="currentLevels[a.id]" inline>
          <v-radio label="Base" value="0"></v-radio>
          <v-radio label="Level 1" value="1"></v-radio>
          <v-radio label="Level 2" value="2"></v-radio>
          <v-radio label="Level 3" value="3"></v-radio>
          <v-radio label="Level 4" value="4"></v-radio>
        </v-radio-group>
        <v-card-subtitle>Goal Level</v-card-subtitle>
        <v-radio-group v-bind="goalLevels[a.id]" inline>
          <v-radio label="Base" value="0"></v-radio>
          <v-radio label="Level 1" value="1"></v-radio>
          <v-radio label="Level 2" value="2"></v-radio>
          <v-radio label="Level 3" value="3"></v-radio>
          <v-radio label="Level 4" value="4"></v-radio>
        </v-radio-group>
      </v-card>
    </v-row>
  </div>
</template>

<script setup lang="ts">
import { Armor, ArmorSet, ArmorSlot, Level } from "@/scripts/armor";
import { Material, MaterialType } from "@/scripts/material";
import { computed, ref } from "vue";

let armorList = Array<Armor>(2);
const currentLevels = ref<Array<number>>(new Array<number>(armorList.length));
const goalLevels = ref<Array<number>>(new Array<number>(armorList.length));

armorList = [
  new Armor(ArmorSet.Climbers, ArmorSlot.Body, "Climbing Gear", 3, Level.Base, [
    [
      new Material(MaterialType.BokoblinHorn, 3),
      new Material(MaterialType.ChuchuJelly, 3),
      new Material(MaterialType.LynelGuts, 3),
    ],
    [
      new Material(MaterialType.BokoblinHorn, 3),
      new Material(MaterialType.ChuchuJelly, 3),
      new Material(MaterialType.LynelGuts, 3),
    ],
    [
      new Material(MaterialType.BokoblinHorn, 3),
      new Material(MaterialType.ChuchuJelly, 3),
      new Material(MaterialType.LynelGuts, 3),
    ],
    [
      new Material(MaterialType.BokoblinHorn, 3),
      new Material(MaterialType.ChuchuJelly, 3),
      new Material(MaterialType.LynelGuts, 3),
    ],
  ]),
  new Armor(
    ArmorSet.Climbers,
    ArmorSlot.Head,
    "Climber's Bandana",
    3,
    Level.Base,
    [
      [
        new Material(MaterialType.BokoblinHorn, 3),
        new Material(MaterialType.ChuchuJelly, 3),
        new Material(MaterialType.LynelGuts, 3),
      ],
      [
        new Material(MaterialType.BokoblinHorn, 3),
        new Material(MaterialType.ChuchuJelly, 3),
        new Material(MaterialType.LynelGuts, 3),
      ],
      [
        new Material(MaterialType.BokoblinHorn, 3),
        new Material(MaterialType.ChuchuJelly, 3),
        new Material(MaterialType.LynelGuts, 3),
      ],
      [
        new Material(MaterialType.BokoblinHorn, 3),
        new Material(MaterialType.ChuchuJelly, 3),
        new Material(MaterialType.LynelGuts, 3),
      ],
    ]
  ),
];
console.log(currentLevels.value);
console.log(goalLevels.value);
</script>
