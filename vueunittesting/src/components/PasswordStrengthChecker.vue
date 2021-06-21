<template>
  <div id="divPassword" class="d-flex text-danger justify-content-center">
    <h4 style="margin-top: 10%; text-align: center">
      Password Strength Checker
    </h4>
    <br />
    <input
      v-model="password"
      @blur="checkStrength"
      type="password"
      placeholder="Type your password"
      id="PassEntry"
      class="form-control passwordInput"
    />
    <br />
    <span id="StrengthDisp">{{ this.strengthBadge }}</span>
    <br />
  </div>
</template>

<script>
export default {
  name: "PasswordStrengthChecker",
  data() {
    return {
      password: "",
      strengthBadge: "",
    };
  },
  methods: {
    checkStrength() {
      this.strengthChecker(this.password);
    },
    strengthChecker(PasswordParameter) {
      //has at least one lowercase letter (?=.*[a-z]), one uppercase letter (?=.*[A-Z]), one digit (?=.*[0-9]), one special character (?=.*[^A-Za-z0-9]), and is at least eight characters long(?=.{8,}).
      let strongPassword = new RegExp(
        "(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^A-Za-z0-9])(?=.{8,})"
      );
      //If the password is at least six characters long and meets all the other requirements, or has no digit but meets the rest of the requirements
      let mediumPassword = new RegExp(
        "((?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^A-Za-z0-9])(?=.{6,}))|((?=.*[a-z])(?=.*[A-Z])(?=.*[^A-Za-z0-9])(?=.{8,}))"
      );
      if (strongPassword.test(PasswordParameter)) {
        this.strengthBadge = "Strong";
      } else if (mediumPassword.test(PasswordParameter)) {
        this.strengthBadge = "Medium";
      } else {
        this.strengthBadge = "Weak";
      }
    },
  },
};
</script>

<style>
.passwordInput {
  margin-top: 5%;
  text-align: center;
}

.displayBadge {
  margin-top: 5%;
  font-size: xx-large;
  text-align: center;
}
</style>
