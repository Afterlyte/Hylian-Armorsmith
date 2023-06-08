<template>
  <div class="ml-4 mr-4">
    <v-card class="pt-2 pb-2 justify-center">
      <v-card-title class="pb-4">
        <div class="text-center">Materials List</div>
      </v-card-title>
      <v-list class="pb-4">
        <div v-for="m in materials" :key="m.typeName">
          <v-row class="justify-center" v-if="m.count>0">
            {{ m.typeName }}: {{ m.count }}
          </v-row>
        </div>
      </v-list>
    </v-card>
  </div>
</template>

<script setup lang="ts">
import { Material, MaterialType } from "@/scripts/material";
import { ref } from "vue";

const materials = ref<Array<Material>>([]);
  
for (const type of Object.values(MaterialType)) {
  const material = new Material(type, 0);
  materials.value.push(material);
}

materials.value[1].count = 1;
</script>
