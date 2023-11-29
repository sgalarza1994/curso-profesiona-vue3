<template>
    <div v-if="!data">Cargando....</div>
    <component v-else
    :is="componentToShow"
    :data="data"
    >
    
    </component>
</template>

<script lang="ts" setup>
import {ref,defineProps,onMounted} from 'vue'

const props = defineProps(['url','componentToShow'])


const data = ref();

onMounted(async() => {
    data.value = await fetch(props.url)
})
</script>