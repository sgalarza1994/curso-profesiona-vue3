import {defineStore} from 'pinia';

export const notesStore = defineStore('notes',{ 
    state : () => {
        return {
            notes:[]
        }
    },
    actions : {
        setToken(note:never){
            this.notes.push(note)
        }
    }
})