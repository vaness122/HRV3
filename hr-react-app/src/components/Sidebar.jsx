// Sidebar.jsx
import React from 'react';
import { Link } from 'react-router-dom';

const Sidebar = () => {
  return (
    <div className="sidebar" style={{ width: '250px', height: '100%', backgroundColor: 'white', padding: '20px' }}>
      <h3>Dashboard</h3>
      <ul>
        <li>
          <Link to="/profile">Profile</Link>
        </li>
        <li>
          <Link to="/users">User List</Link>
        </li>
      </ul>
    </div>
  );
};

export default Sidebar;
