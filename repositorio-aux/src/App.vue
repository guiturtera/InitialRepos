<template>
  <div id="app">
    <Contato/>
  </div>
</template>

<script>
import Contato from './components/Contato.vue'

export default {
  name: 'App',
  components: {
    Contato
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
