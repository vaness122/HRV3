import React from 'react';
import Sidebar from './Sidebar';

const Dashboard = () => {
  return (
    <div style={{ display: 'flex' }}>
      {/* Sidebar */}
      <Sidebar />

      {/* Main Dashboard Content */}
      <div className="dashboard" style={{ marginLeft: '260px', padding: '20px' }}>
        <h1>Welcome to your Dashboard!</h1>
        {/* Add additional dashboard components or content here */}
      </div>
    </div>
  );
};

export default Dashboard;