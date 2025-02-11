import axios from 'axios';

const API_URL = 'https://localhost:7095/api/User'; // Base URL

export const register = async (username, password) => {
  try {
    const response = await axios.post(`${API_URL}/register`, { username, password });
    return response.data;
  } catch (error) {
    throw error;
  }
};

