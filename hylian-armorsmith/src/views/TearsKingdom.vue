<template>
  <v-card class="mt-16 h-100">
    <v-layout :full-height="true">
      <v-navigation-drawer width="250" color="transparent" border="none">
        <v-divider></v-divider>
        <v-card
          prepend-icon="mdi-filter"
          class="justify-center ma-4"
          title="Filters"
          color="rgb(13,146,99)"
          theme="dark"
        >
          <v-container fluid>
            <v-select
              v-model="slotValues"
              :items="slots"
              label="Armor Slot"
              multiple
              density="compact"
            >
              <template v-slot:selection="{ index }">
                <v-chip v-if="index < 1">
                  <span>{{ slotValues.length }} selected</span>
                </v-chip>
              </template>
            </v-select>
            <v-select
              v-model="setValues"
              :items="sets"
              label="Armor Set"
              multiple
              density="compact"
            >
              <template v-slot:selection="{ index }">
                <v-chip v-if="index < 1">
                  <span>{{ setValues.length }} selected</span>
                </v-chip>
              </template>
            </v-select>
          </v-container>
        </v-card>
        <MaterialsList />
      </v-navigation-drawer>

      <v-main style="min-height: 300px">
        <v-divider></v-divider>
        <ArmorList :slotValues="slotValues" :setValues="setValues"></ArmorList>
      </v-main>
    </v-layout>
  </v-card>
</template>

<script setup lang="ts">
import MaterialsList from "@/components/MaterialsList.vue";
import ArmorList from "@/components/ArmorList.vue";
import { ref, watch } from "vue";
import { ArmorSet, ArmorSlot } from "@/scripts/armor";

const slots = Object.keys(ArmorSlot);
const slotValues = ref<Array<string>>([]);
const sets = Object.keys(ArmorSet);
const setValues = ref<Array<string>>([]);

initUserData();

function initUserData() {
  slotValues.value = JSON.parse(
    (localStorage.getItem("slots") as string) == null
      ? '["Head", "Body", "Legs"]'
      : (localStorage.getItem("slots") as string)
  );
  setValues.value = JSON.parse(
    (localStorage.getItem("sets") as string) == null
      ? '["Hylian"]'
      : (localStorage.getItem("sets") as string)
  );
}

watch(
  () => [setValues.value, slotValues.value],
  () => {
    localStorage.setItem("sets", JSON.stringify(setValues.value));
    localStorage.setItem("slots", JSON.stringify(slotValues.value));
  }
);
</script>
