import axios from "axios";
import * as constants from "./Utility/constants";

export default {
  async signUp(user) {
    return await axios
      .post(
        `${constants.apiEndpoint}/${constants.userController}/register`,
        user
      )
      .then(response => {
        if (response.data) return response.data;
      });
  },
  async login(user) {
    return await axios
      .post(`${constants.apiEndpoint}/${constants.userController}/signin`, user)
      .then(response => {
        if (response.data) return response.data;
      });
  },
  async getAllParkings() {
    return await axios
      .get(`${constants.apiEndpoint}/${constants.parkingController}`)
      .then(response => {
        if (response.data) return response.data;
      });
  }
};
