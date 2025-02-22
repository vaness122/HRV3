import React, { useState } from 'react';
import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';
import Profile from './components/Profile';
import Register from './components/Register';
import Login from './components/Login';
import Dashboard from './components/Dashboard';
import UserList from './components/UserList';
import './App.css';
import './Register.css';
import './Sidebar.css';
import EmployeeProfile from './components/EmployeeProfile';

const App = () => {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  // Function to update login state
  const handleLoginSuccess = () => {
    setIsLoggedIn(true);
  };

  return (
    <Router>
      <div style={{ display: 'flex' }}>
        {/* Sidebar */}
        {!isLoggedIn && (
          <div className="sidebar">
            <h2>Human Resource</h2>

            {/* Sidebar Links */}
            <ul>
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
          </div>
        )}

        {/* Main Content */}
        <div className="main-content">
          <h1>Welcome to Human Resource</h1>

          {/* Define Routes */}
          <Routes>
            <Route path="/register" element={<Register />} />
            <Route path="/login" element={<Login onLoginSuccess={handleLoginSuccess} />} />
            <Route path="/dashboard" element={<Dashboard />} />
            <Route path="/profile" element={<Profile />} />
            <Route path="/users" element={<UserList />} />
            <Route path="/employprofile" element = {<EmployeeProfile/>}/>
          </Routes>
        </div>
      </div>
    </Router>
  );
};

export default App;
