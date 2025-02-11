// components/Register.js
import React, { useState } from 'react';
import { register } from '../services/api'; // Import the register function

const Register = () => {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const [confirmPassword, setConfirmPassword] = useState('');
  const [error, setError] = useState(null);

  const handleSubmit = async (event) => {
    event.preventDefault();
    if (password !== confirmPassword) {
      setError('Passwords do not match');
      return;
    }
    try {
      const data = await register(username, password); // Use the API service
      if (data.success) {
        // Redirect to login
        window.location.href = '/';
      } else {
        setError(data.error);
      }
    } catch (error) {
      setError(error.message);
    }
  };

  return (
    <section class="bg-gray-50 dark:bg-gray-900">
       <div class="w-full bg-white rounded-lg shadow dark:border md:mt-0 sm:max-w-md xl:p-0 dark:bg-gray-800 dark:border-gray-700">
       <div class="p-6 space-y-4 md:space-y-6 sm:p-8">
    <form  class="space-y-4 md:space-y-2"  onSubmit={handleSubmit}>

    <div>
      <label for="text" class="block mb-2 text-sm font-medium text-gray-900 dark:text-white">Username:</label>
      <input
        type="text" 
        class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-primary-600 focus:border-primary-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
        value={username}
        onChange={(event) => setUsername(event.target.value)}
      />
      </div>

      <br />

      <div>
      <label class="block mb-2 text-sm font-medium text-gray-900 dark:text-white">Password:</label>
      <input
        type="password"
        class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-primary-600 focus:border-primary-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
        value={password}
        onChange={(event) => setPassword(event.target.value)}
      />
    </div>

      <br />

      <div>
      <label  class="block mb-2 text-sm font-medium text-gray-900 dark:text-white">Confirm Password:</label>
      <input
        type="password"
        class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-primary-600 focus:border-primary-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
        value={confirmPassword}
        onChange={(event) => setConfirmPassword(event.target.value)}
      />
      </div>
      
      <br />
      <button  
      type="submit"  
      class="dark:focus:ring-primary-800">Register</button>
      {error && <p style={{ color: 'red' }}>{error}</p>}
    </form>
    </div>
    </div>
    </section>
  );
};

export default Register;
