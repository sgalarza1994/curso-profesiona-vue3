<template>
    <div class="container">
       <div class="auxbar">
        <AuxBar />
       </div>
       <div class="main-content-contenedor">
        <MenuBar />
       </div>
       <div class="main-content">
        <slot name="main"></slot>
       </div>
       <div class="main-content">
        <slot name="aux"></slot>
       </div>

    </div>
</template>

  <script lang="ts" setup>
import AuxBar from '../components/AuxBar.vue';
import MenuBar from '../components/MenuBar.vue';



</script>