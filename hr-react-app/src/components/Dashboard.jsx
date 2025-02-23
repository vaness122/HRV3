import React, { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import Sidebar from './Sidebar';

const Dashboard = () => {
  const navigate = useNavigate();
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  useEffect(() => {
    // Check if userToken exists in localStorage
    const token = localStorage.getItem("userToken");
    if (!token) {
      // If no token, redirect to login page
      navigate("/login");
    } else {
      setIsLoggedIn(true);
    }
  }, [navigate]);

  return (
    <div style={{ display: 'flex' }}>
      <Sidebar />
      <div className="dashboard" style={{ marginLeft: '260px', padding: '20px' }}>
        {isLoggedIn ? (
          <h1>Welcome to your Dashboard!</h1>
        ) : (
          <h1>Redirecting to Login...</h1>
        )}
      </div>
    </div>
  );
};

export default Dashboard;
