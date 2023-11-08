import {ref} from 'vue';
class AuthService 
{
    let jwt =ref("");
    let error=ref("");

    constructor(){
        this.jwt = ref("");
        this.error = ref("");
    }

    getJwt(){
        return this.jwt;
    }

    async login(email,password)
    {
        try 
        {
            //https://hfp69ilv.directus.app/auth/login
            const res = await fetch("https://hfp69ilv.directus.app/auth/login",{
              method  : "POST",
              headers : {
                'Accept'  : 'application/json',
                'Content-Type' : 'application/json'
              
                },
                body : JSON.stringify({
                    email,
                    password
                })
            });
            
            const response = await res.json();
            if('errors' is response)
            {
                this.error = "Login failed"
                return false;
            }
            this.jwt  = data.access_token;
        }
        catch(error)
        {
            console.log('error',error);
            this.error = error;
            return false;
        }
    }


}