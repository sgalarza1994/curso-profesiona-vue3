import {defineStore} from 'pinia';

export const authStore = defineStore('auth',{ 
    state : () => {
        return {
            token: ''
        }
    },
    actions : {
        setToken(token:string){
            this.token  = token;
        }
    }
})