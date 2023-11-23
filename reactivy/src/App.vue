<template>

 <h1>count {{ $count }}</h1>
 <button @click="$sayHello()">Dijo</button>
<!-- 
   <h3>Count: {{ obj.count }}</h3> -->
   
   <!-- <h3>Count: {{ count() }}</h3>
  <button @click="$event => count.update((v)=> v+1)">Increment</button>
  <button @click="count.set(0)">Reset</button> -->
  <!-- <h3>Count: {{ count() }}</h3>
  <button @click="$event => setCount((v)=> v+1)">Increment</button> -->
</template>

<script lang="ts" setup>
// import {createSignal} from 'vue-signals/solid';
// const [count,setCount] = createSignal(0);

// import {signal} from 'vue-signals/angular'

// const count = signal(0);
// import {reactive,ref} from 'vue';

// const obj = reactive({ 
//    count: 0
// })


</script>

<style>

</style>
