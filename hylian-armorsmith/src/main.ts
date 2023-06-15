/**
 * main.ts
 *
 * Bootstraps Vuetify and other plugins then mounts the App`
 */

// Components
import App from "./App.vue";

// Composables
import { createApp } from "vue";

// Plugins
import { registerPlugins } from "@/plugins";
import Axios from "axios";

if (typeof localStorage === "undefined" || localStorage == null) {
  var LocalStorage = require("node-localstorage").LocalStorage;
  localStorage = new LocalStorage("./scratch");
}
Axios.defaults.baseURL = "https://localhost:7113/";

const app = createApp(App);

registerPlugins(app);

app.mount("#app");
