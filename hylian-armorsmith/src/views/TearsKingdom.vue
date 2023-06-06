<template>
  <v-card>
    <v-layout>
      <v-app-bar title="Hylian Armorsmith"></v-app-bar>
      <v-navigation-drawer width="250">
        <v-divider></v-divider>
        <v-card
          prepend-icon="mdi-filter"
          class="justify-center ma-4"
          title="Filters"
        >
          <v-list-group value="Armor Slot">
            <template v-slot:activator="{ props }">
              <v-list-item
                v-bind="props"
                title="Armor Slot"
                class="justify-center"
              />
            </template>
          </v-list-group>
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
        <ArmorList></ArmorList>
      </v-main>
    </v-layout>
  </v-card>
</template>

<script setup lang="ts">
import MaterialsList from "@/components/MaterialsList.vue";
import ArmorList from "@/components/ArmorList.vue";
</script>
