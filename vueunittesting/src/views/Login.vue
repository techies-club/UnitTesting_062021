<template>
  <div id="divLogin" class="about">
    <h1>This is Login</h1>
    ID : <input data-testid="loginid" v-model="login" /> <br />
    PIN : <input data-testid="loginpin" v-model="pin" /> <br />
    <input
      data-testid="loginbutton"
      type="button"
      value="Login"
      @click="loginMe"
    />
    <br />
    <label style="color: red" data-testid="error">{{ this.error }}</label>
  </div>
</template>

<script>
export default {
  name: "Login",
  data() {
    return {
      login: "",
      pin: "",
      error: "",
    };
  },
  methods: {
    loginMe() {
      if (this.login == "xxx" && this.pin == 123) {
        this.$router.push("about");
      } else {
        this.error = "Invalid login";
      }
    },
  },
};
</script>

<style></style>
