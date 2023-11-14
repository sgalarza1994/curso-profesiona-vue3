<template>
  <div class="home">
    <img alt="Vue logo" src="../assets/logo.png">
    <button @click="loginUser">LOGIN</button>
    <button @click="loginSession">SESSIo</button>

  </div>
</template>

<script lang="ts" setup>
import { defineComponent,inject } from 'vue';
import { VueCookies } from 'vue-cookies';
import Vuession from 'vue-session';
const $cookies = inject<VueCookies>('$cookies'); 
  const $session = inject<Vuession>('$session'); 
const loginUser = () => 
{
  let token = "123456789";
  $cookies!.set("auth",token);
}
const loginSession = () => 
{
  let token = "123456789";
  $session!.star();

}
</script>
