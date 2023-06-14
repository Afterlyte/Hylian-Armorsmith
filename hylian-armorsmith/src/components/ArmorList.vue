<template>
  <div class="d-flex flex-column">
    <v-row v-for="a in armorList" :key="a.id" class="ml-4 mt-4 mb-1">
      <v-card height="100" width="250" class="">
        <v-card-title>{{ a.name }}</v-card-title>
        <v-checkbox
          label="Obtained"
          v-model="obtained[a.id]"
          @update:model-value="updateMaterialList"
        ></v-checkbox>
      </v-card>
      <v-card height="100" class="">
        <v-card-title>Current Level {{ currentLevels[a.id] }}</v-card-title>
        <v-card-actions>
          <v-radio-group
            v-model="currentLevels[a.id]"
            inline
            dense
            @update:model-value="updateMaterialList"
            :disabled="!obtained[a.id]"
          >
            <v-radio label="Base" value="0"></v-radio>
            <v-radio label="Level 1" value="1"></v-radio>
            <v-radio label="Level 2" value="2"></v-radio>
            <v-radio label="Level 3" value="3"></v-radio>
            <v-radio label="Level 4" value="4"></v-radio>
          </v-radio-group>
        </v-card-actions>
      </v-card>
      <v-card height="100" class="">
        <v-card-title>Goal Level {{ goalLevels[a.id] }}</v-card-title>
        <v-card-actions>
          <v-radio-group
            v-model="goalLevels[a.id]"
            inline
            dense
            @update:model-value="updateMaterialList"
            :disabled="!obtained[a.id]"
          >
            <v-radio label="Base" value="0"></v-radio>
            <v-radio label="Level 1" value="1"></v-radio>
            <v-radio label="Level 2" value="2"></v-radio>
            <v-radio label="Level 3" value="3"></v-radio>
            <v-radio label="Level 4" value="4"></v-radio>
          </v-radio-group>
        </v-card-actions>
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
const armorList = ref<Array<Armor>>([]);
const subArmorList = ref<Array<Armor>>([]);
const currentLevels = ref<Array<number>>([]);
const goalLevels = ref<Array<number>>([]);
const obtained = ref<Array<boolean>>([]);

const props = defineProps<{
  slotValues: string[];
  setValues: string[];
}>();

watch(
  () => [props.setValues, props.slotValues, obtained.value],
  () => {
    console.log(props.setValues, props.slotValues);
    Axios.post("/Armor/FilteredArmorList", props.setValues, {
      params: {
        head: props.slotValues.includes("Head"),
        body: props.slotValues.includes("Body"),
        legs: props.slotValues.includes("Legs"),
      },
    })
      .then((response) => {
        armorList.value = response.data as Armor[];
        updateMaterialList();
        console.log(armorList.value);
      })
      .catch((e) => {
        console.log(e);
      });
  },
  { immediate: true }
);

updateMaterialList();

function updateMaterialList() {
  store.loadMaterials();
  subArmorList.value = JSON.parse(
    JSON.stringify(
      armorList.value.filter((a) => obtained.value.at(a.id) == true)
    )
  ) as Armor[];

  console.log(subArmorList.value);
  if (subArmorList.value.length > 0) {
    subArmorList.value.forEach((a) => {
      for (let j = currentLevels.value[a.id]; j < goalLevels.value[a.id]; j++) {
        console.log(j);
        console.log(currentLevels.value);
        console.log(a.id);
        console.log(subArmorList.value.find((s) => s.id == a.id));
        if (subArmorList.value.find((s) => s.id == a.id)) {
          let armor: Armor = subArmorList.value.find(
            (s) => s.id == a.id
          ) as Armor;
          let levelMaterials: Material[] = armor.upgradeMaterials.filter(
            (m) => m.level == j
          );
          levelMaterials.forEach((m) => {
            store.addMaterial(m);
          });
        }
      }
    });
  }
}
</script>
