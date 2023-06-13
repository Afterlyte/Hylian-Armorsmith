<template>
  <div class="ml-4 mr-4">
    <v-card class="pt-2 pb-2 justify-center">
      <v-card-title class="pb-2">
        <div class="text-center">Materials List</div>
      </v-card-title>
      <v-list class="pb-4">
        <div v-for="m in store.materialList" :key="m.typeName">
          <v-row class="justify-center pt-1 pb-1" v-if="m.count > 0">
            {{ m.typeName }}: {{ m.count }}
          </v-row>
        </div>
      </v-list>
    </v-card>
  </div>
</template>

<script setup lang="ts">
import { store } from "@/scripts/store";
</script>
