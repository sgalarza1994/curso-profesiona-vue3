import { createRouter, createWebHistory, RouteRecordRaw } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import LoginView from '../views/LoginView.vue';
import NotesView from '../views/NotesView.vue'
import { authStore } from '@/store/auth';

const routes: Array<RouteRecordRaw> = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },
  {
    path: '/about',
    name: 'about',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/AboutView.vue')
  },
  {
    path : '/login',
    name : 'login',
    component : LoginView,
    meta : { 
      requireAuth : false
    }
  },
  {
    path : '/notes',
    name : 'notes',
    component : NotesView,
    meta : { 
      requireAuth : true
    }
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

router.beforeEach((to,from,next) => { 
  const auth = authStore();
  const authSuccess  = auth.token ? true : false;  
  const needAuth = to.meta.requireAuth;
  if(needAuth && !authSuccess )
  {
    next('login')
  }
  else 
  {
    next();
  }
});
export default router
