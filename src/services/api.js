import axios from "axios";
const API = axios.create({
    baseURL: "http://localhost:5014/api"
});

export default API;