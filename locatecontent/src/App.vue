<template>

   <div>
    <select v-model="$i18n.locale">
      <option  v-for="locale in $i18n.availableLocales" :key="'locale-${locale}'"  :value="locale"> {{ locale }} </option>
    </select>
   </div>

  <h1>{{$t("message.hello", {name : username})}} </h1>
  <p>{{ $t("message.content")}}</p>
</template>

<script lang="ts" setup>
import {ref} from 'vue';

const username = ref('Pedro');
</script>

<style>

</style>
