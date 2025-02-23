import React, { useState } from 'react';
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

  // Function to update login state
  const handleLoginSuccess = (username) => {
    setIsLoggedIn(true);
    setUsername(username);
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
