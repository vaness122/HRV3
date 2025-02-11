// components/Register.js
import React, { useState } from 'react';


const Register = () => {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const [confirmPassword, setConfirmPassword] = useState('');
  const [error, setError] = useState(null);

  const handleSubmit = async (event) => {
    event.preventDefault();
    if (password!== confirmPassword) {
      setError('Passwords do not match');
      return;
    }
    try {
      const response = await fetch('https://localhost:5001/api/user/register', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ username, password }),
      });
      const data = await response.json();
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
    <form onSubmit={handleSubmit}>
      <label>Username:</label>
      <input type="text" value={username} onChange={(event) => setUsername(event.target.value)} />
      <br />
      <label>Password:</label>
      <input type="password" value={password} onChange={(event) => setPassword(event.target.value)} />
      <br />
      <label>Confirm Password:</label>
      <input type="password" value={confirmPassword} onChange={(event) => setConfirmPassword(event.target.value)} />
      <br />
      <button type="submit">Register</button>
      {error && <p style={{ color: 'red' }}>{error}</p>}
    </form>
  );
};

export default Register;
