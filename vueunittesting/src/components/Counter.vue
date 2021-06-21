/* eslint-disable prettier/prettier */
<template>
  <div id="testDiv">
    Here is Button
    <button @click="sum++">UP</button>
    <p>Total : {{ sum }}</p>
  </div>
</template>

<script>
export default {
  name: "Counter",
  data() {
    return {
      sum: 0,
    };
  },
};
</script>

<style></style>
