import React, { useState } from 'react';
import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';
import Profile from './components/Profile';
import Register from './components/Register';
import Login from './components/Login';
import Dashboard from './components/Dashboard';
import UserList from './components/UserList';
import PrivateRoute from './components/PirvateRoute';
import EmployeeForm from './components/EmployeeForm';
import EmployeeList from './components/EmployeeList';
import './App.css';
import './Userlist.css';
import './Sidebar.css';
import './Login.css';

const App = () => {
  const [isLoggedIn, setIsLoggedIn] = useState(false);
  const [user, setUser] = useState(null); // Track logged-in user
  const [selectedEmployee, setSelectedEmployee] = useState(null); // Track selected employee for editing

  // Function to update login state and store user data
  const handleLoginSuccess = (userData) => {
    setIsLoggedIn(true);
    setUser(userData); // Store user data (e.g., name)
  };

  const handleEmployeeUpdate = (employee) => {
    setSelectedEmployee(employee);
  };

  const handleSave = () => {
    setSelectedEmployee(null);
  };

  return (
    <>
      <Router>
        <div style={{ display: 'flex' }}>
          {/* Sidebar */}
          <div className="sidebar">
            <h2>Human Resource</h2>

            {/* Sidebar Links */}
            <ul>
              {!isLoggedIn ? (
                <>
                  <li className="nav-item">
                    <Link to="/register" className="nav-link">Register</Link>
                  </li>
                  <li className="nav-item">
                    <Link to="/login" className="nav-link">Login</Link>
                  </li>
                </>
              ) : (
                <li className="nav-item">
                  <span className="nav-link">Welcome, {user?.name}</span> {/* Display logged-in user's name */}
                </li>
              )}
            </ul>
          </div>

          <div className="main-content">
            <h1>Welcome to Human Resource</h1>

            {isLoggedIn && (
              <div>
                <h2>Employee Management</h2>
                <EmployeeForm employee={selectedEmployee} onSave={handleSave} />
                <EmployeeList onEmployeeUpdate={handleEmployeeUpdate} />
              </div>
            )}

            {/* Define Routes */}
            <Routes>
              <Route path="/register" element={<Register />} />
              <Route path="/login" element={<Login onLoginSuccess={handleLoginSuccess} />} />
              <Route path="/dashboard" element={<Dashboard />} />
              <Route path="/profile" element={<Profile />} />
              <Route path="/users" element={<UserList />} />
              <Route path="/employeeform" element={<EmployeeForm />} />
              <Route path="/employeelist" element={<EmployeeList />} />
            </Routes>
          </div>
        </div>
      </Router>
    </>
  );
};

export default App;
