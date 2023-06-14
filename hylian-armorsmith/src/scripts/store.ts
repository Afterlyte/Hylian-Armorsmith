import { reactive } from "vue";
import { Material } from "@/scripts/material";

export const store = reactive({
  materialList: [] as Material[],
  loadMaterials: function () {
    this.materialList = new Array<Material>(0);
  },
  resetMaterials: function () {
    for (let i = 0; i < this.materialList.length; i++) {
      this.materialList[i].count = 0;
    }
  },
  addMaterial: function (material: Material) {
    for (let i = 0; i < this.materialList.length; i++) {
      if (this.materialList[i].material == material.material) {
        this.materialList[i].count =
          this.materialList[i].count + material.count;
        return;
      }
    }
    this.materialList.push(
      new Material(material.material, material.count, material.level)
    );
  },
});
