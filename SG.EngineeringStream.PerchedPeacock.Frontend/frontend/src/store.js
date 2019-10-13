import Vue from "vue";
import Vuex from "vuex";
import service from "./service";

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    User: {},
    Parkings: []
  },
  getters: {
    CurrentUser: state => state.User,
    allParkings: state => state.Parkings
  },
  mutations: {
    setLoggedInUser(state, user) {
      state.User = user;
    },
    setParkings(state, parkings) {
      state.Parkings = parkings;
    }
  },
  actions: {
    async loadParkings({ commit }) {
      let parkings = await service.getAllParkings();
      commit("setParkings", parkings);
    }
  }
});
