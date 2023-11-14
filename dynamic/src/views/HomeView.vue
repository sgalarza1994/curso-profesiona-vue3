<template>
  <div class="home">
    <h1>Listado de Usuarios</h1>
    <div>
      <button @click="handleLayout(ListLayout)">Ver en lista</button>
      <button @click="handleLayout(CardLayout)">Ver en tarjetas</button>
      <button @click="handleLayout(TableLayout)">Ver en tabla</button>
    </div>
    <component
    :is="layout"
    :content="users"
    ></component>


  </div>
</template>

<script lang="ts" setup>
import {ref,defineAsyncComponent} from 'vue';

const ListLayout = defineAsyncComponent(() => import('../layouts/ListLayout.vue'));
const TableLayout = defineAsyncComponent(() => import('../layouts/TablaLayout.vue'));
const CardLayout = defineAsyncComponent(() => import('../layouts/CardLayout.vue'));
const layout  =ref(ListLayout);

const handleLayout = (cmp) => 
{
  layout.value = cmp;
}


const users = ref([
  {
    name : "Steven",
    age : 29,
    position : 'fullStack'
  },
  {
    name : "Alberto",
    age : 29,
    position : 'fullStack'
  }
]);




</script>
