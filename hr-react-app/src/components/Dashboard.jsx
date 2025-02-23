import React from 'react';
import Sidebar from './Sidebar';

const Dashboard = ({ username }) => {
  return (
    <div style={{ display: 'flex' }}>
      {/* Sidebar */}
      <Sidebar />

      {/* Main Dashboard Content */}
      <div className="dashboard" style={{ marginLeft: '260px', padding: '20px' }}>

        <h1>Welcome, {username} to your Dashboard!</h1>
    

      </div>
    </div>
  );
};

export default Dashboard;
