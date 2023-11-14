import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import VueCookies  from 'vue-cookies'
import Vuession from 'vue-session';

const app = createApp(App);



app.use(router).use(VueCookies,{ expires : '1d'}).
use(Vuession).
mount('#app')


//$cookies.set('auth',1000,expires:'3d');
//$cookies.get('auth)
//$cookies.remove('auth');
//$cookies.isKey('auth');
//$cookies.keys();


//$session.start();
// $session.set('auth',123)
//$session.get('auth');
// $session.id();
//$session.renew();
//$session.destroy();