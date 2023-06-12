<template>
  <div class="d-flex flex-column">
    <v-row v-for="(a, i) in armorList" :key="a.name" class="px-6 pt-6">
      <v-card width="480" class="pa-4">
        <v-card-title>{{ a.name }}</v-card-title>
        <v-card-subtitle>Current Level {{ currentLevels[i] }}</v-card-subtitle>
        <v-radio-group v-model="currentLevels[i]" inline @update:model-value="updateMaterialList">
          <v-radio label="Base" value="0"></v-radio>
          <v-radio label="Level 1" value="1"></v-radio>
          <v-radio label="Level 2" value="2"></v-radio>
          <v-radio label="Level 3" value="3"></v-radio>
          <v-radio label="Level 4" value="4"></v-radio>
        </v-radio-group>
        <v-card-subtitle>Goal Level {{ goalLevels[i] }}</v-card-subtitle>
        <v-radio-group v-model="goalLevels[i]" inline @update:model-value="updateMaterialList">
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
import { store } from "@/scripts/store";
import { computed, ref } from "vue";


store.loadMaterials();
let armorList = Array<Armor>(2);
const currentLevels = ref(new Array<number>(armorList.length));
const goalLevels = ref(new Array<number>(armorList.length));

armorList = ref([
  new Armor(ArmorSet.Climbers, ArmorSlot.Body, "Climbing Gear", 3, Level.Base, [
    [],
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
      [],
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
]);
console.log(currentLevels.value);
console.log(goalLevels.value);

function updateMaterialList() {
  store.loadMaterials();
  for (let i=0; i<armorList.length; i++) {
    for (let j=currentLevels.value[i]+1; j<=goalLevels.value[i]; j++) {
      console.log(armorList[i].upgradeMaterials[j]);
      /*for(let k=0; k<armorList[i].upgradeMaterials[j].length; k++) {
        store.addMaterial(armorList[i].upgradeMaterials[j][k]);
      }*/
    }
  }
  //console.log(store.materialList);
}
</script>
