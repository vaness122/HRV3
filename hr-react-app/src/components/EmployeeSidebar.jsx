import React from "react";
import { Link } from "react-router-dom";

const EmployeeSideBar = () => {
  return (
    <div>
      <ul>
        <li><Link to="/employees">Employee List</Link></li>
        <li><Link to="/employees/:id">View Employee Profile</Link></li>
        <li><Link to="/employees/:id/edit">Edit Employee Profile</Link></li>
      </ul>
    </div>
  );
};

export default Sidebar;
