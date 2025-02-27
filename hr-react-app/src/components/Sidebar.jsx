import React, { useState } from 'react';
import { Link, useNavigate } from 'react-router-dom';

const Sidebar = () => {
  const navigate = useNavigate();
  const [isManagementExpanded, setIsManagementExpanded] = useState(false);

  const handleLogout = () => {
    localStorage.removeItem('userToken');
    navigate('/login');
  };

  const handleManagementClick = () => {
    setIsManagementExpanded(!isManagementExpanded);
  };

  return (
    <div
      className="sidebar"
      style={{
        width: '250px', // Fixed width of the sidebar
        height: '100vh',
        backgroundColor: 'gray',
        padding: '20px',
        position: 'fixed', // Ensure sidebar stays fixed on the left
        top: 0,
        bottom: 0,
      }}
    >
      {/* Sidebar Header */}
      <h3>Dashboard</h3>

      {/* Sidebar Links */}
      <ul className="sidebar-links">
       
        
        <li>
          <button className="management-btn" onClick={handleManagementClick}>
            Management
          </button>
          {isManagementExpanded && (
            <ul className="management-dropdown">
              <li>
                <Link to="/employeeform">Employee Form</Link>
              </li>
              <li>
                <Link to="/employeelist">Employee </Link>
              </li>
            </ul>
          )}
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
