<template>
  <img alt="Vue logo" src="./assets/logo.png">
  <Nbuse>

  </Nbuse>
</template>

<script>
    import Nbuse from './components/NbUse.vue'
export default {
  name: 'App',
  components: {
      Nbuse
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
