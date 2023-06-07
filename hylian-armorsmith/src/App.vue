<template>
  <v-app>
    <v-dialog v-model="signInDialogue" persistent max-width="600px">
      <v-card>
        <v-card-title>Sign In</v-card-title>
        <v-card-text>
          <v-form>
            <v-text-field
              v-model="email"
              label="Email"
              type="email"
              required
            ></v-text-field>
            <v-text-field
              v-model="password"
              label="Password"
              type="password"
              required
            ></v-text-field>
          </v-form>
        </v-card-text>
        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn
            @click="
              signInDialogue = false;
              signUpDialogue = true;
            "
            >Sign Up</v-btn
          >
          <v-btn @click="signInDialogue = false">Cancel</v-btn>
          <v-btn color="primary" @click="signIn">Sign In</v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>
    <v-dialog v-model="signUpDialogue" persistent max-width="600px">
      <v-card>
        <v-card-title>Sign Up</v-card-title>
        <v-card-text>
          <v-form>
            <v-text-field
              v-model="email"
              label="Email"
              type="email"
              required
            ></v-text-field>
            <v-text-field
              v-model="password"
              label="Password"
              type="password"
              required
            ></v-text-field>
          </v-form>
        </v-card-text>
        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn @click="signUpDialogue = false">Cancel</v-btn>
          <v-btn color="primary" @click="signUp">Sign Up</v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>
    <v-app-bar title="Hylian Armorsmith">
      <div v-if="!signedIn">
        <v-btn
          icon="mdi-account-outline"
          @click="signInDialogue = true"
        ></v-btn>
      </div>
      <div v-else>
        <v-menu>
          <template v-slot:activator="{ props }">
            <v-btn icon="mdi-account" v-bind="props"></v-btn>
          </template>

          <v-list>
            <v-list-item>
              <v-list-item-title @click="signOut">Sign Out</v-list-item-title>
            </v-list-item>
          </v-list>
        </v-menu>
      </div>
    </v-app-bar>
    <router-view />
  </v-app>
</template>

<script lang="ts" setup>
import { ref } from "vue";

const signInDialogue = ref(false);
const email = ref("");
const password = ref("");

const signUpDialogue = ref(false);

const signedIn = ref(false);

function signIn() {
  signedIn.value = true;
  signInDialogue.value = false;
}

function signUp() {
  signedIn.value = true;
  signUpDialogue.value = false;
}

function signOut() {
  signedIn.value = false;
}
</script>
