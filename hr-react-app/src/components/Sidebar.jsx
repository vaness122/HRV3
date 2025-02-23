import React from 'react'; 
import { Link, useNavigate } from 'react-router-dom';

const Sidebar = () => {
  const navigate = useNavigate(); 
 
  const handleLogout = () => {
   
    localStorage.removeItem('userToken'); 
    navigate('/login');
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
          <Link to="/profile">Profile</Link>
        </li>
        <li>
          <Link to="/users">User List</Link>
        </li>
        <li>
          <Link to="/employeeform">EmployeeForm</Link>
        </li>
        <li>
          <Link to="/employeelist">EmployeeList</Link>
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