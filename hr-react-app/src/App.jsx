// App.js
import React from 'react';
import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';

import Register from './components/Register';
import Login from './components/Login';

import './App.css';

const App = () => {
  return (
    <>
    <Router>
      <div>
        <h1>Human Resource </h1>

        {/* Navigation Bar */}
        <nav className="navbar">
          <ul className="navbar-nav">
          
            <li className="n7av-item">
              <Link to="/register" className="nav-link">Register</Link>
            </li>
           
            <li ClassName="nav-item">
              <Link to ="/login" className="nav-link">Login</Link>
            </li>
           
          </ul>
        </nav>

        {/* Define Routes */}
        <Routes>
       
          <Route path="/register" element={<Register />} />
          <Route path="/login" element={<Login/>} />
         
        </Routes>
      </div>
    </Router>
    </>
  );
};

export default App;

