import React from 'react';
import { Link, useNavigate } from 'react-router-dom';

const Sidebar = () => {
  const navigate = useNavigate(); // React Router's navigate hook for redirection

  // Function to handle logout
  const handleLogout = () => {
    // Clear any authentication data (for example, a token in localStorage or sessionStorage)
    localStorage.removeItem('userToken'); // Example of clearing token from localStorage
    
    // Redirect the user to the login page
    navigate('/login'); // Redirect to login after logout
  };

  return (
    <div className="sidebar">
      <div className="sidebar-header">
        <h3>Dashboard</h3>
      </div>

      {/* Sidebar Links below Dashboard */}
      <ul className="sidebar-links">
        <li>
          <Link to="/profile">Profile</Link>
        </li>
        <li>
          <Link to="/users">User List</Link>
        </li>
        <li>
          <Link to="/employeeprofile">EmployeeProfile</Link>
        </li>
      </ul>

      {/* Logout button */}
      <button className="logout-btn" onClick={handleLogout}>
        Logout
      </button>
    </div>
  );
};

export default Sidebar;
