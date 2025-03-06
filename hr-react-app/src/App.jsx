import React, { useState, useEffect, useCallback, useMemo } from 'react';
import { BrowserRouter as Router, Route, Routes, Link, Navigate } from 'react-router-dom';
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
    const [user, setUser] = useState(null);
    const [selectedEmployee, setSelectedEmployee] = useState(null);
    const [isEmployeeListReady, setIsEmployeeListReady] = useState(false);

    const handleLoginSuccess = (userData) => {
        setIsLoggedIn(true);
        setUser(userData);
    };

    const handleEmployeeUpdate = useCallback((employee) => {
        console.log("Setting selectedEmployee:", employee);
        setSelectedEmployee(employee);
    }, []);

    const handleSave = useCallback(() => {
        console.log("Clearing selectedEmployee");
        setSelectedEmployee(null);
    }, []);

    useEffect(() => {
        if (isLoggedIn) {
            setIsEmployeeListReady(true);
        }
    }, [isLoggedIn]);

    // Use useMemo to memoize the props object
    const employeeListProps = useMemo(() => ({
        onEmployeeUpdate: handleEmployeeUpdate,
    }), [handleEmployeeUpdate]);

    const PrivateRoute = ({ children }) => {
        if (!isLoggedIn) {
            return <Navigate to="/login" state={{ from: window.location.pathname }} replace />;
        }
        return children;
    }

    return (
      <>
      <Router>
          <div style={{ display: 'flex' }}>
              <div className="sidebar">
                  <h2>Human Resource</h2>
                  <ul>
                      {!isLoggedIn? (
                          <>
                              <li className="nav-item">
                                  <Link to="/login" className="nav-link">Login</Link>
                              </li>
                          </>
                      ) : (
                          <li className="nav-item">
                              <span className="nav-link">Welcome, {user?.name}</span>
                          </li>
                      )}
                  </ul>
              </div>

              <div className="main-content">
                  <Routes>
                      <Route path="/register" element={<Register />} />
                      <Route path="/login" element={<Login onLoginSuccess={handleLoginSuccess} />} />
                      <Route path="/dashboard" element={
                          <PrivateRoute>
                              <Dashboard />
                          </PrivateRoute>
                      } />
                      <Route path="/profile" element={
                          <PrivateRoute>
                              <Profile />
                          </PrivateRoute>
                      } />
                      <Route path="/users" element={
                          <PrivateRoute>
                              <UserList />
                          </PrivateRoute>
                      } />
                      <Route path="/employeeform" element={
                          <PrivateRoute>
                              <EmployeeForm />
                          </PrivateRoute>
                      } />
                      <Route path="/employeelist" element={
                          <PrivateRoute>
                              <EmployeeList />
                          </PrivateRoute>
                      } />
                      <Route path="/employee/:id/profile" element={
                          <PrivateRoute>
                              <Profile />
                          </PrivateRoute>
                      } />
                      <Route path="/employee/edit/:id" element={
                          <PrivateRoute>
                              <EmployeeForm />
                          </PrivateRoute>
                      } />
                  </Routes>
              </div>
          </div>
      </Router>
  </>
);
};

export default App;
