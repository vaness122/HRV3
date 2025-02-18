import React, { useState } from 'react';
import { Link } from 'react-router-dom';

const Sidebar = () => {
  const [isCollapsed, setIsCollapsed] = useState(false);

  
  const toggleSidebar = () => {
    setIsCollapsed(!isCollapsed);
  };

  return (
    <div
      className={`sidebar ${isCollapsed ? 'collapsed' : ''}`}
      style={{
        width: isCollapsed ? '60px' : '250px', // Adjust width based on collapse state
        height: '100vh',
        backgroundColor: 'gray',
        padding: '20px',
        transition: 'width 0.3s ease',
        position: 'fixed', // Ensure sidebar stays fixed on the left
        top: 0, 
        bottom: 0,
      }}
    >
      <button onClick={toggleSidebar} className="toggle-btn" style={{ position: 'absolute', top: '20px', right: '-30px' }}>
        {isCollapsed ? '>' : '<'}
      </button>
      <h3 style={{ display: isCollapsed ? 'none' : 'block' }}>Dashboard</h3>
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
