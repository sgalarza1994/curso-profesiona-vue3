<template>

  <h1>Notres</h1>
  <input v-model="note" />

  <!-- <nav>
     <h3>{{ store.count }}</h3>
    <button @click="store.increment(1)">Anñadir</button>
  </nav> -->
  <router-view/>
</template>


<script lang="ts" setup>
import {ref,watchEffect,watch} from 'vue';
import {useExample} from '@/store/useExample';
const store = useExample();

const note = ref('');

//watchEffect(() => { })
watch(note,() =>  {
  alert('valor modificado:'+note.value)
});



</script>
<style lang="scss">

</style>
