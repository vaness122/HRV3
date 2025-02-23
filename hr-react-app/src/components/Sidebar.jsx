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
     
      style={{
        // Adjust width based on collapse state
        height: '100vh',
        backgroundColor: 'gray',
        padding: '75px',
       
        position: 'fixed', // Ensure sidebar stays fixed on the left
        top: 0,
        bottom: 0,
        left :0
      }}
    >
      <button onClick={toggleSidebar} className="toggle-btn" style={{ position: 'absolute', top: '20px', right: '-30px' }}>
        {}
      </button>
      <h3 style={{ display: isCollapsed ? 'none' : 'block' }}>Dashboard</h3>
      <ul>
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