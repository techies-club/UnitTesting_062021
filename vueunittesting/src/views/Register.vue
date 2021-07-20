<template>
  <div id="divRegister" class="about">
    <h1>Register here!!</h1>
    ID : <input data-testid="loginid" v-model="login" /> <br />
    PIN : <input data-testid="loginpin" v-model="pin" /> <br />
    RE-PIN : <input data-testid="loginrepin" v-model="repin" /> <br />
    <input
      data-testid="registerbutton"
      type="button"
      value="Register"
      @click="registerMe"
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
      repin: "",
      error: "",
    };
  },
  methods: {
    registerMe() {
      if (this.pin != this.repin) {
        this.error = "confirm pin";
      } else {
        this.$router.push("about");
      }
    },
  },
};
</script>

<style></style>
