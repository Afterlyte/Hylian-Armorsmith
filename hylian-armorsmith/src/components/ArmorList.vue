<template>
  <div class="d-flex flex-column">
    <v-row v-for="(a, i) in armorList" :key="a.name" class="px-6 pt-6">
      <v-card width="480" class="pa-4">
        <v-card-title>{{ a.name }}</v-card-title>
        <v-card-subtitle>Current Level {{ currentLevels[i] }}</v-card-subtitle>
        <v-radio-group
          v-model="currentLevels[i]"
          inline
          @update:model-value="updateMaterialList"
        >
          <v-radio label="Base" value="0"></v-radio>
          <v-radio label="Level 1" value="1"></v-radio>
          <v-radio label="Level 2" value="2"></v-radio>
          <v-radio label="Level 3" value="3"></v-radio>
          <v-radio label="Level 4" value="4"></v-radio>
        </v-radio-group>
        <v-card-subtitle>Goal Level {{ goalLevels[i] }}</v-card-subtitle>
        <v-radio-group
          v-model="goalLevels[i]"
          inline
          @update:model-value="updateMaterialList"
        >
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
import { Armor, ArmorSet, ArmorSlot } from "@/scripts/armor";
import { Material, MaterialType } from "@/scripts/material";
import { store } from "@/scripts/store";
import Axios from "axios";
import { watch } from "vue";
import { ref } from "vue";

store.loadMaterials();
let armorList = ref(Array<Armor>());
const currentLevels = ref(new Array<number>(armorList.value.length));
const goalLevels = ref(new Array<number>(armorList.value.length));

const props = defineProps<{
  slotValues: string[];
  setValues: string[];
}>();

watch(
  () => [props.setValues, props.slotValues],
  () => {
    const config = {
      headers: {
        head: props.slotValues.includes("Head"),
        body: props.slotValues.includes("Body"),
        legs: props.slotValues.includes("Legs"),
      },
      data: {
        setFilters: props.setValues,
      },
    };
    Axios.post("/Armor/GetFilteredArmorList", config).then((response) => {
      armorList.value = response.data as Armor[];
    });
  }
);

armorList = ref([
  new Armor(
    0,
    ArmorSet.Hylian,
    ArmorSlot.Body,
    "Climbing Gear",
    [3, 6, 9, 12, 15],
    [
      new Material(MaterialType.BokoblinHorn, 3, 1),
      new Material(MaterialType.ChuchuJelly, 3, 1),
      new Material(MaterialType.LynelGuts, 3, 1),
      new Material(MaterialType.BokoblinHorn, 3, 2),
      new Material(MaterialType.ChuchuJelly, 3, 2),
      new Material(MaterialType.LynelGuts, 3, 2),
      new Material(MaterialType.BokoblinHorn, 3, 3),
      new Material(MaterialType.ChuchuJelly, 3, 3),
      new Material(MaterialType.LynelGuts, 3, 3),
      new Material(MaterialType.BokoblinHorn, 3, 4),
      new Material(MaterialType.ChuchuJelly, 3, 4),
      new Material(MaterialType.LynelGuts, 3, 4),
    ]
  ),
  new Armor(
    1,
    ArmorSet.Climbing,
    ArmorSlot.Head,
    "Climber's Bandana",
    [3, 6, 9, 12, 15],
    [
      new Material(MaterialType.BokoblinHorn, 3, 1),
      new Material(MaterialType.ChuchuJelly, 3, 1),
      new Material(MaterialType.LynelGuts, 3, 1),
      new Material(MaterialType.BokoblinHorn, 3, 2),
      new Material(MaterialType.ChuchuJelly, 3, 2),
      new Material(MaterialType.LynelGuts, 3, 2),
      new Material(MaterialType.BokoblinHorn, 3, 3),
      new Material(MaterialType.ChuchuJelly, 3, 3),
      new Material(MaterialType.LynelGuts, 3, 3),
      new Material(MaterialType.BokoblinHorn, 3, 4),
      new Material(MaterialType.ChuchuJelly, 3, 4),
      new Material(MaterialType.LynelGuts, 3, 4),
    ]
  ),
]);
console.log(currentLevels.value);
console.log(goalLevels.value);

function updateMaterialList() {
  store.loadMaterials();
  armorList.value.forEach((a) => {
    for (
      let j = +currentLevels.value[a.id] + 1;
      j <= goalLevels.value[a.id];
      j++
    ) {
      console.log(armorList.value[a.id].upgradeMaterials[j]);
      let levelMaterials: Material[] = armorList.value[
        a.id
      ].upgradeMaterials.filter((m) => m.level == j);
      levelMaterials.forEach((m) => {
        store.addMaterial(m);
      });
    }
  });
  //console.log(store.materialList);
}
</script>
