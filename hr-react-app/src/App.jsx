import React, { useState, useEffect } from 'react';
import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';
import Profile from './components/Profile';
import Register from './components/Register';
import Login from './components/Login';
import Dashboard from './components/Dashboard';
import UserList from './components/UserList';

import './App.css';

const App = () => {
  const [isLoggedIn, setIsLoggedIn] = useState(false);
  const [username, setUsername] = useState('');

  // Check localStorage for login status on mount
  useEffect(() => {
    const storedUsername = localStorage.getItem('username');
    if (storedUsername) {
      setIsLoggedIn(true);
      setUsername(storedUsername);
    }
  }, []);

  // Function to update login state
  const handleLoginSuccess = (username) => {
    setIsLoggedIn(true);
    setUsername(username);
    localStorage.setItem('username', username); // Store username in localStorage
  };

  // Function to handle logout
  const handleLogout = () => {
    setIsLoggedIn(false);
    setUsername('');
    localStorage.removeItem('username'); // Remove username from localStorage
  };

  return (
    <>
      <Router>
        <div>
          <h1>Human Resource</h1>

          {/* Navigation Bar */}
          {!isLoggedIn && (
            <nav className="navbar">
              <ul className="navbar-nav">
                <li className="nav-item">
                  <Link to="/register" className="nav-link">
                    Register
                  </Link>
                </li>

                <li className="nav-item">
                  <Link to="/login" className="nav-link">
                    Login
                  </Link>
                </li>
              </ul>
            </nav>
          )}

          {/* Display Logout Button if Logged In */}
          {isLoggedIn && (
            <button onClick={handleLogout}>Logout</button>
          )}

          {/* Define Routes */}
          <Routes>
            <Route
              path="/register"
              element={<Register />}
            />
            <Route
              path="/login"
              element={<Login onLoginSuccess={handleLoginSuccess} />}
            />
            <Route path="/dashboard" element={<Dashboard username={username} />} />
            <Route path="/profile" element={<Profile />} />
            <Route path="/users" element={<UserList />} />
          </Routes>
        </div>
      </Router>
    </>
  );
};

export default App;
