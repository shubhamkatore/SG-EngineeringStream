<template>
  <div class="parkingsummary">
    <h1>
      <b>Name : {{ parkingData.name }}</b>
    </h1>
    <h2>Location : {{parkingData.location}}</h2>
    <h2>Capacity : {{parkingData.capacity}}</h2>
    <h2>Available Space : {{parkingData.availableSpace}}</h2>
  </div>
</template>

<script>
export default {
  name: "ParkingSummary",
  props: ["parkingData"],
  computed: {},
  methods: {}
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style lang="scss">
.parkingsummary {
  padding-left: 30px;
  padding-right: 30px;
  max-width: calc(100% - 180px);
  margin-left: 160px;
}
</style>