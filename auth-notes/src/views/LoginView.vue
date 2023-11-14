<template>
<div>
 <input placeholder="Nombre de usuario" v-model="username" />
 <input placeholder="Password"  v-model="password"/>
 <button @click="loginUser">Login </button>
</div>
</template>

<script
lang="ts"
setup
>
import {ref} from 'vue';
import { authStore } from '@/store/auth';
import {useRouter} from 'vue-router';

const router = useRouter();
const auth = authStore();
let username = ref('');
let password = ref('');



const loginUser = () => 
{
    if(username.value === 'sgalarza' && password.value === '123456')
    {
       auth.setToken("1234567890123456789123456789");
       router.push({name : 'notes'})
    }
    else 
    {
        alert('Credencailes incorrectas');
    }
}
</script>