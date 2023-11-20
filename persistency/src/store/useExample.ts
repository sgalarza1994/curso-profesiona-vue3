import { defineStore } from "pinia"

export const  useExample = defineStore('useExample',{
     state : () => { 
        return {
            count : 1,
            
        }
       
    
    },
     actions : {
        increment(val  =1)
        {
            this.count += val;
        }
     },
     persist : {
        storage :  sessionStorage,
        paths :  ['count']
     }
});
