<template>
  <v-card class="mt-16 h-100">
    <v-layout>
      <v-navigation-drawer width="250">
        <v-divider></v-divider>
        <v-card
          prepend-icon="mdi-filter"
          class="justify-center ma-4"
          title="Filters"
        >
          <v-container fluid>
            <v-select
              v-model="slotValues"
              :items="slots"
              label="Armor Slot"
              multiple
            >
              <template v-slot:selection="{ item, index }">
                <v-chip v-if="index < 1">
                  <span>{{ item.title }}</span>
                </v-chip>
                <span
                  v-if="index === 1"
                  class="text-gray text-caption align-self-center"
                  >(+{{ slotValues.length - 1 }} others)</span
                >
              </template>
            </v-select>
            <v-select
              v-model="setValues"
              :items="sets"
              label="Armor Set"
              multiple
            >
              <template v-slot:selection="{ item, index }">
                <v-chip v-if="index < 1">
                  <span>{{ item.title }}</span>
                </v-chip>
                <span
                  v-if="index === 1"
                  class="text-gray text-caption align-self-center"
                  >(+{{ setValues.length - 1 }} others)</span
                >
              </template>
            </v-select>
          </v-container>
          <v-list-group value="Armor Set">
            <template v-slot:activator="{ props }">
              <v-list-item
                v-bind="props"
                title="Armor Set"
                class="justify-center"
              />
            </template>
          </v-list-group>
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
import { ref } from "vue";
import { ArmorSet, ArmorSlot } from "@/scripts/armor";

const slots = Object.keys(ArmorSlot);
const slotValues = ref<Array<string>>([]);
const sets = Object.keys(ArmorSet);
const setValues = ref<Array<string>>([]);
</script>
