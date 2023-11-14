<template>
    <div class="container">
    
    <div class="form-group">
        <div class="mb-3 row">
    <label for="staticEmail" class="col-sm-2 col-form-label">Email</label>
    <div class="col-sm-10">
      <input v-model="email" type="text"  class="form-control-plaintext" id="staticEmail">
    </div>
  </div>
  <div class="mb-3 row">
    <label for="inputPassword" class="col-sm-2 col-form-label">Password</label>
    <div class="col-sm-10">
      <input v-model="password" type="password" class="form-control" id="inputPassword">
    </div>

   
  </div>
  <button @click="authUser"  class="btn btn-primary">Login</button>
    </div>
</div>
</template>

<script lang="ts" setup>
import {Ref,ref} from 'vue';
import AuthService from '../services/AuthService'

let email:Ref<string> = ref("");
let password:Ref<string> = ref("");

  const authUser = async () => 
  {
     const auth = new AuthService();
     const response = await auth.login(email.value,password.value)
     if(response)
     {
      alert('login exitoso')
     }
     else 
     {
      alert('error al realizar el token');
     }
  }

</script>