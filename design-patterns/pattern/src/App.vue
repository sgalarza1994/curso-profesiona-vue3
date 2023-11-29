<template>
  <button @click="updateMs">MOdificar mesaje</button>
   <LoaderHelper  :url="myApy" :componentToShow="HelloWorld"/>
   <HelloWorld />
</template>

<script lang="ts" setup>
import {provide,ref} from 'vue'
import HelloWorld from './components/HelloWorld.vue';
import LoaderHelper from './components/LoaderHelper.vue';

const msg = ref("desde el padre");

const myApy ="http/google.com"

const updateMs = () => 
{
  msg.value= "El boton lo modifico"
}


provide('msg',msg)
</script>

<style lang="scss">
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
