import React from 'react';
import { Navigate } from 'react-router-dom';

// A wrapper for private routes
const PrivateRoute = ({ element, isLoggedIn }) => {
  if (!isLoggedIn) {
    // Redirect them to the login page if not logged in
    return <Navigate to="/login" />;
  }

  return element;
};

export default PrivateRoute;
