import axios from 'axios';

const api = axios.create({
  baseURL: 'https://localhost:7293/api/', // changed base URL
});

export const register = async (username, password) => {
  try {
    const response = await api.post('User/register', { // changed endpoint to 'User/register'
      username,
      password,
    });
    return response.data;
  } catch (error) {
    throw error;
  }
};
