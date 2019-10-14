<template>
  <div class="home">
    <div v-if="!CurrentUser.firstName">
      <h1>To use application,please login first or sign up.</h1>
    </div>

    <div v-if="CurrentUser.firstName" class="container">
      <h1>Available Parkings</h1>
      <div v-for="(parkingData,index) in allParkings" :key="index">
        <div class="parkingsummary">
          <h1>
            <b>Name : {{ parkingData.name }}</b>
          </h1>
          <h2>Location : {{parkingData.location}}</h2>
          <h2>Capacity : {{parkingData.capacity}}</h2>
          <h2>Available Space : {{parkingData.availableSpace}}</h2>
          <button class="button is-primary" @click="bookParking(parkingData.id)">Book</button>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { mapGetters, mapActions } from "vuex";

export default {
  name: "home",
  components: {},
  created() {
    this.loadParkings();
  },
  computed: {
    ...mapGetters(["CurrentUser", "allParkings"])
  },
  methods: {
    ...mapActions(["loadParkings"]),
    async bookParking(Id) {}
  },
  components: {}
};
</script>
<style>
.parkingsummary {
  padding: 30px;
  margin-left: 50px;
  border: solid;
}
.container {
  display: flex;
}
</style>