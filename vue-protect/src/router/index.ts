import { createRouter, createWebHistory, RouteRecordRaw } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import LoginView from '../views/Login.vue';
const routes: Array<RouteRecordRaw> = [
  {
    path: '/',
    name: 'home',
    component: HomeView,
    meta :{
      requireAuth:false
    }
  },
  {
    path: '/about',
    name: 'about',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/AboutView.vue'),
    meta :{
      requireAuth:true
    }
  },
  {
    path : '/login',
    name : 'login',
    component : LoginView,
    meta :{
      requireAuth:false
    }
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})


router.beforeEach((to,from,next) =>{
  const auth = false;
  const needAuth = to.meta.requireAuth;


  if(needAuth && !auth)
  {
    next('login');
  }
  else 
  {
    next();
  }






})

export default router
