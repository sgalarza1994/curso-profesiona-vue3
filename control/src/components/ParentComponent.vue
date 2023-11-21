<template>
    <img v-lazy="{src: 'https://fastly.picsum.photos/id/702/1280/800.jpg?hmac=jOEyi7cHZ9je59y9D9y4mLCfG-uZHJAZQoGFDnn5ugM',
        loading:'logo.png',
        error: 'logo.png',
        delay : 500
        }"  />
<!-- <div>
Hola
<ChildComponent ref="percentageComponent"/>
<button @click="banco">Agregar Cuenta bancaria</button>
</div> -->
</template>

<script lang="ts" setup>
import {ref} from 'vue';
// import ChildComponent from './ChildComponent.vue';
// const percentageComponent = ref(null);


// const banco = () => 
// {
//     alert('Cuenta subida')
//     //conectar con el servico y subir la informacion
//     percentageComponent.value.recalculate();
// }



</script>