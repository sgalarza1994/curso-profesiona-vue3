import { createApp } from 'vue'
import App from './App.vue'

import  {createI18n} from 'vue-i18n';
import { messages } from './lang/message';

const i18n = createI18n({
 //Options
    locale: 'en',
    fallbackLocale : 'en',
    messages
});

const app = createApp(App);
app.use(i18n);
app.mount('#app')
