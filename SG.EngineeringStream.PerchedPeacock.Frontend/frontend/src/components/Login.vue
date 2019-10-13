<template>
  <div>
    <div class="modal-card" style="width: auto">
      <header class="modal-card-head">
        <p class="modal-card-title">Login</p>
      </header>
      <section class="modal-card-body">
        <b-field label="Email">
          <b-input type="email" :value="email" v-model="email" placeholder="Your email" required></b-input>
        </b-field>

        <b-field label="Password">
          <b-input
            type="password"
            :value="password"
            v-model="password"
            password-reveal
            placeholder="Your password"
            required
          ></b-input>
        </b-field>

        <b-checkbox>Remember me</b-checkbox>
      </section>
      <footer class="modal-card-foot">
        <button class="button" type="button" @click="$parent.close()">Close</button>
        <button class="button is-primary" @click="login()">Login</button>
      </footer>
    </div>
  </div>
</template>

<script>
import service from "../service";
import { mapMutations, mapActions } from "vuex";

export default {
  name: "Login",
  data() {
    return {
      email: "",
      password: ""
    };
  },
  methods: {
    ...mapMutations(["setLoggedInUser"]),
    ...mapActions(["loadParkings"]),
    async login() {
      var loggedInUser = await service.login({
        Email: this.email,
        Password: this.password
      });
      if (loggedInUser && loggedInUser.firstName) {
        this.setLoggedInUser(loggedInUser);
        this.$buefy.snackbar.open(`User LoggedIn Successfully`);
        this.$parent.close();
        this.loadParkings();
      }
    }
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
</style>
