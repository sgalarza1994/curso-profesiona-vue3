<template>
  <div class="home">
     <h1>Counter App</h1>
    <h2 id="countInfo">Contador {{ count }}</h2>
    <button  @click="$event => count++">Incrmentar</button>
  </div>
</template>

<script lang="ts" setup>
import {ref} from 'vue';

const count  =ref(0);
</script>
