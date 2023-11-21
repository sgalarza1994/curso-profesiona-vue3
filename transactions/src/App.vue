<template>
  
  <!--Transaction Group-->
   <TransitionGroup name="list" tag="ul">
    <li v-for="note in notes" :key="note">
     <v-icon name="bi-file-code-fill" scale="2" />{{ note }}
    </li>
    
   </TransitionGroup>
  <input type="text" v-model="note" />
  <button @click="handleNote">Save Note</button>


  <!--Transaction Simple-->
  <!-- <button @click="show = !show">Mostrar - Ocultar</button>
  <Transition>
    <h1 v-if="show">Hello World Animado</h1>
  </Transition> -->

</template>

<script lang="ts" setup>
import {ref} from 'vue';
const show = ref(false)
const notes = ref([]);
const note = ref('')

const handleNote = () => 
{
  notes.value.push(note.value);
  note.value = "";
}
</script>

<style lang="scss">


.list-enter-active,.v-leave-active{
 transition: all 0.5s ease;
}
.list-enter-from,.v-leave-to{
 opacity: 0;
 transform: translateX(30px);
}



// .v-enter-active,.v-leave-active{
//  transition: opacity 0.5s ease;
// }
// .v-enter-from,.v-leave-to{
//  opacity: 0;
// }
// enter-from // opactity : 0
// enter-active // opacity 2s ease 
// enter-to // opacity : 1

// leave-from 
// leave-active
// leave-to

</style>
