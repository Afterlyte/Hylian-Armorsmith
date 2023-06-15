<template>
  <div class="d-flex flex-column">
    <v-row v-for="a in armorList" :key="a.id" class="ml-4 mt-4 mb-1">
      <v-card height="100" width="250" class="parchment mr-2">
        <v-card-title>{{ a.name }}</v-card-title>
        <v-checkbox
          label="Obtained"
          v-model="obtained[a.id]"
          @update:model-value="updateMaterialList"
        ></v-checkbox>
      </v-card>
      <v-card height="100" class="parchment mr-2">
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
      <v-card height="100" class="parchment">
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

initUserData();

function initUserData() {
  if (localStorage.getItem("obtained") == null) {
    localStorage.clear();
    localStorage.setItem("obtained", JSON.stringify(new Array<boolean>()));
    localStorage.setItem("current", JSON.stringify(new Array<number>()));
    localStorage.setItem("goal", JSON.stringify(new Array<number>()));
  }
  currentLevels.value = JSON.parse(
    (localStorage.getItem("current") as string) === "undefined" || null
      ? "[]"
      : (localStorage.getItem("current") as string)
  );
  goalLevels.value = JSON.parse(
    (localStorage.getItem("goal") as string) === "undefined" || null
      ? "[]"
      : (localStorage.getItem("goal") as string)
  );
  obtained.value = JSON.parse(
    (localStorage.getItem("obtained") as string) === "undefined" || null
      ? "[]"
      : (localStorage.getItem("obtained") as string)
  );
}

const props = defineProps<{
  slotValues: string[];
  setValues: string[];
}>();

watch(
  () => [props.setValues, props.slotValues, obtained.value],
  () => {
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
      })
      .catch((e) => {
        console.log(e);
      });
  },
  { immediate: true }
);

function updateMaterialList() {
  store.loadMaterials();
  console.log(
    localStorage.getItem("obtained"),
    localStorage.getItem("current"),
    localStorage.getItem("goal")
  );
  localStorage.setItem("obtained", JSON.stringify(obtained.value));
  localStorage.setItem("current", JSON.stringify(currentLevels.value));
  localStorage.setItem("goal", JSON.stringify(goalLevels.value));
  subArmorList.value = JSON.parse(
    JSON.stringify(
      armorList.value.filter((a) => obtained.value.at(a.id) == true)
    )
  ) as Armor[];

  if (subArmorList.value.length > 0) {
    subArmorList.value.forEach((a) => {
      for (let j = currentLevels.value[a.id]; j < goalLevels.value[a.id]; j++) {
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
