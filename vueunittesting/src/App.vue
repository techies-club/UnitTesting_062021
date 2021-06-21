<template>
  <div id="app">
    <img alt="Vue logo" src="./assets/logo.png" />
    <HelloWorld msg="Welcome to Your Vue.js App" />
    <counter></counter>
    <password-strength-checker></password-strength-checker>
    <userComponent></userComponent>
  </div>
</template>

<script>
import HelloWorld from "./components/HelloWorld.vue";
import Counter from "./components/Counter";
import PasswordStrengthChecker from "./components/PasswordStrengthChecker";
import userComponent from "./components/userComponent";
export default {
  name: "App",
  components: {
    HelloWorld,
    Counter,
    PasswordStrengthChecker,
    userComponent,
  },
};
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
