const axios = require("axios");

async function validateEmail(email) {
  //call service and check if user is returned
  let user = await axios.get("http://127.0.0.1:8088/getUsers/" + email);
  //   console.log(user);
  //   console.log(user.data);
  return user;
}

function add(a, b) {
  return a + b;
}

module.exports = { validateEmail, add };
