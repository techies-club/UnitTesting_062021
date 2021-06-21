<template>
  <div id="divUser">
    <p>
      <b>User Module</b>
    </p>
    <ul>
      <li>
        <a href="#">Home</a> &nbsp; <a href="#">About</a> &nbsp;
        <a href="#" id="aMember">{{
          this.isValidUser ? "My Profile" : "Register Me"
        }}</a>
      </li>
    </ul>
    <input type="text" id="txtEmail" v-model="email" /><br />
    <input
      type="button"
      id="btnValidate"
      value="Validate Me"
      @click="checkUser"
    />
  </div>
</template>

<script>
const userService = require("../userService");

export default {
  name: "userComponent",
  data() {
    return {
      email: "",
      isValidUser: false,
    };
  },
  methods: {
    async checkUser() {
      let user = await userService.validateEmail(this.email);
      console.log(user);
      console.log(user.data);
      console.log(user.data.length);
      this.isValidUser = user.data && user.data.length && user.data.length > 0;
      console.log(this.isValidUser);
    },
  },
  //   computed:
  //   {
  //       isValidUser: function () {

  //       }

  //   }
  // eslint-disable-next-line prettier/prettier
};
</script>

<style></style>
