import { reactive } from "vue";
import { Material, MaterialType } from "@/scripts/material";

export const store = reactive({
    materialList: [] as Material[],
    loadMaterials: function() {
        this.materialList = [];
    },
    addMaterial: function(material: Material) {
        for( let i = 0; i < this.materialList.length; i++) {
            if (this.materialList[i].type == material.type) {
                this.materialList[i].count = this.materialList[i].count + material.count;
                return;
            }
        }
            this.materialList.push(material);
    }
});