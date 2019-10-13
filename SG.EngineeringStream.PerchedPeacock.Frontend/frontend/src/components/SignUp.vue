<template>
  <div>
    <div class="modal-card" style="width: auto">
      <header class="modal-card-head">
        <p class="modal-card-title">Sign Up</p>
      </header>
      <section class="modal-card-body">
        <b-field label="First Name">
          <b-input
            type="text"
            :value="firstName"
            v-model="firstName"
            placeholder="Enter Your First Name"
            required
          ></b-input>
        </b-field>
        <b-field label="Last Name">
          <b-input
            type="text"
            :value="lastName"
            v-model="lastName"
            placeholder="Enter Your Last Name"
            required
          ></b-input>
        </b-field>
        <b-field label="Email">
          <b-input type="email" :value="email" v-model="email" placeholder="Your email" required></b-input>
        </b-field>
        <b-field label="User Name">
          <b-input
            type="text"
            :value="userName"
            v-model="userName"
            placeholder="Choose User Name"
            required
          ></b-input>
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
      </section>
      <footer class="modal-card-foot">
        <button class="button" type="button" @click="$parent.close()">Close</button>
        <button class="button is-primary" @click="signUp()">Sign Up</button>
        <b-loading :is-full-page="true" :active.sync="isLoading" :can-cancel="true"></b-loading>
      </footer>
    </div>
  </div>
</template>

<script>
import service from "../service";
export default {
  name: "SignUp",
  data() {
    return {
      firstName: "",
      lastName: "",
      email: "",
      userName: "",
      password: "",
      isLoading: false
    };
  },
  methods: {
    async signUp() {
      this.isLoading = true;
      let registerUser = await service.signUp({
        FirstName: this.firstName,
        LastName: this.lastName,
        Email: this.email,
        Username: this.userName,
        Password: this.password
      });
      this.isLoading = false;
      if (registerUser) {
        this.$buefy.snackbar.open(`User Registered Successfully`);
        this.$parent.close();
      }
    }
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
</style>
