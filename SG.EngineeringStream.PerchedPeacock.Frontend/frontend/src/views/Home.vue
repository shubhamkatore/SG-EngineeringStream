<template>
  <div class="home">
    <div v-if="!CurrentUser.firstName">
      <h1>To use application,please login first or sign up.</h1>
    </div>
    <ParkingSummary :parkingData="allParkings[0]" />
    <!-- <div v-for="(parking,index) in allParkings" :key="index">
      <ParkingSummary :parkingData="parking" />
    </div>-->
    <div v-if="CurrentUser.firstName"></div>
  </div>
</template>

<script>
import { mapGetters, mapActions } from "vuex";
import ParkingSummary from "../components/ParkingSummary.vue";

export default {
  name: "home",
  components: {
    ParkingSummary
  },
  created() {
    this.loadParkings();
  },
  computed: {
    ...mapGetters(["CurrentUser", "allParkings"])
  },
  methods: {
    ...mapActions(["loadParkings"])
  },
  components: {}
};
</script>