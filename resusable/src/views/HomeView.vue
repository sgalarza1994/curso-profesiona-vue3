<template>
  <MainLayout>
     
       <template #main>
        <h1>Mi Home</h1>
       </template>

       <template #aux>
        <h1>Mi Aitj </h1>
        <p> x {{ x }} y {{  y }}</p>
       </template>
  </MainLayout>

</template>

<script lang="ts" setup>
import MainLayout from '../layouts/MainLayout.vue';
import {ref,onMounted,onUnmounted} from 'vue'
import {useMouse} from '@/composables/useMouse'

const  {x,y} = useMouse();

</script>
