import Vue from 'vue'
import App from './App.vue'
 import ElementUI from 'element-ui'
 import '../theme/index.css'//可以自定义主题
Vue.config.productionTip = false

Vue.use(ElementUI)
new Vue({
  render: h => h(App),
}).$mount('#app')
