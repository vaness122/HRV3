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
<<<<<<< HEAD
     
      style={{
        // Adjust width based on collapse state
        height: '100vh',
        backgroundColor: 'gray',
        padding: '75px',
       
=======
      className="sidebar"
      style={{
        width: '250px', // Fixed width of the sidebar
        height: '100vh',
        backgroundColor: 'gray',
        padding: '20px',
>>>>>>> 4fc4e583ad7e7e56d961add70852947468bf468e
        position: 'fixed', // Ensure sidebar stays fixed on the left
        top: 0,
        bottom: 0,
        left :0
      }}
    >
<<<<<<< HEAD
      <button onClick={toggleSidebar} className="toggle-btn" style={{ position: 'absolute', top: '20px', right: '-30px' }}>
        {}
      </button>
      <h3 style={{ display: isCollapsed ? 'none' : 'block' }}>Dashboard</h3>
      <ul>
=======
      {/* Sidebar Header */}
      <h3>Dashboard</h3>

      {/* Sidebar Links */}
      <ul className="sidebar-links">
>>>>>>> 4fc4e583ad7e7e56d961add70852947468bf468e
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