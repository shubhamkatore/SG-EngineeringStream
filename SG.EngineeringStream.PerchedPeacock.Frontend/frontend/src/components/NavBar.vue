<template>
  <nav class="navbar" role="navigation" aria-label="main navigation">
    <div class="navbar-brand">
      <a class="navbar-item" href="/">
        <b>PerchedPeacock</b>
      </a>

      <a
        role="button"
        class="navbar-burger burger"
        aria-label="menu"
        aria-expanded="false"
        data-target="navbarBasicExample"
      >
        <span aria-hidden="true"></span>
        <span aria-hidden="true"></span>
        <span aria-hidden="true"></span>
      </a>
    </div>

    <div id="navbarBasicExample" class="navbar-menu">
      <div class="navbar-start">
        <a class="navbar-item">Home</a>

        <a class="navbar-item">Documentation</a>

        <div class="navbar-item has-dropdown is-hoverable">
          <a class="navbar-link">More</a>

          <div class="navbar-dropdown">
            <a class="navbar-item">About</a>
            <a class="navbar-item">Jobs</a>
            <a class="navbar-item">Contact</a>
            <hr class="navbar-divider" />
            <a class="navbar-item">Report an issue</a>
          </div>
        </div>
      </div>
      <div v-if="!CurrentUser.firstName">
        <div class="navbar-end">
          <div class="navbar-item">
            <div class="buttons">
              <a class="button is-primary" @click="isRegistrationModalActive = true">
                <strong>Sign up</strong>
              </a>
              <a class="button is-light" @click="isSignModalActive = true">Log in</a>
            </div>
          </div>
        </div>
      </div>
      <div v-if="CurrentUser.firstName">Hello {{CurrentUser.firstName}}</div>
      <b-modal :active.sync="isRegistrationModalActive" has-modal-card trap-focus>
        <SignUp></SignUp>
      </b-modal>
      <b-modal :active.sync="isSignModalActive" has-modal-card trap-focus>
        <Login></Login>
      </b-modal>
    </div>
  </nav>
</template>

<script>
import SignUp from "@/components/SignUp.vue";
import Login from "@/components/Login.vue";
import { mapGetters } from "vuex";
export default {
  name: "NavBar",
  components: {
    SignUp,
    Login
  },
  computed: {
    ...mapGetters(["CurrentUser"])
  },
  data() {
    return {
      isRegistrationModalActive: false,
      isSignModalActive: false
    };
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
</style>
