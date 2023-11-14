import {ref,Ref} from 'vue';
class AuthService 
{
    private jwt: Ref<string>
    private error:Ref<string>

    constructor(){
        this.jwt = ref("");
        this.error = ref("");
    }

    getJwt(){
        return this.jwt;
    }
    getError(){
        return this.error;
    }

    async login(email:string,password:string):Promise<boolean>
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
            if('errors' in response)
            {
                this.error.value = "Login failed"
                return false;
            }
            this.jwt  = response.data.access_token;
            return true;
        }
        catch(error:any)
        {
            console.log('error',error);
            this.error.value = error;
            return false;
        }
    }


}

export default AuthService;