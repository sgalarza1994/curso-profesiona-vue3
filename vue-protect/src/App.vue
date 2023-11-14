<template>
  <div>
    <input  v-model="note" />
    <button @click="sentToServer">Guardar</button>
  </div>
</template>

<script lang="ts" setup>
import {ref} from 'vue';

let note = ref('');

const sentToServer = async () => 
{
  const response = await fetch('',{
    method : 'POST',
    headers : {
      'Content-type' : 'application/json',
      'Acc[t]' : 'applicationJson',
      'authorization': 'Bearer' + note.value
    },
    body : JSON.stringify({note : note.value})
  })
}
</script>