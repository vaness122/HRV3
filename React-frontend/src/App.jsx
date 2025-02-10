import React from 'react';
import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';

import AddStudent from './components/Register';
import './App.css';

const App = () => {
    return (
        <Router>
            <div>
                <h1>Student Management</h1>

                {/* Navigation Bar */}
                <nav className="navbar">
                    <ul className="navbar-nav">
                        <li className="nav-item">
                            <Link to="/register" className="nav-link">Student List</Link>
                        </li>
                       
                    </ul>
                </nav>

                {/* Define Routes */}
                <Routes>
                    <Route path="/register" element={<Register />} />
                
                </Routes>
            </div>
        </Router>
    );
};

export default App;
