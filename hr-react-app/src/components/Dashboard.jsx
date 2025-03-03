import React, { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import Sidebar from './Sidebar';

const Dashboard = () => {
    const navigate = useNavigate();
    const [isLoggedIn, setIsLoggedIn] = useState(false);
    const [isLoading, setIsLoading] = useState(true); // Add loading state

    useEffect(() => {
        // Check if userToken exists in localStorage
        const token = localStorage.getItem("userToken");
        if (!token) {
            // If no token, redirect to login page
            console.log("No token found, redirecting to /login");
            navigate("/login"); // Explicitly navigate to the login route
        } else {
            setIsLoggedIn(true);
        }
        setIsLoading(false); // Set loading to false after checking token
    }, [navigate]);

    const handleLogout = () => {
        localStorage.removeItem("userToken");
        setIsLoggedIn(false);
        navigate("/login");
    };

    if (isLoading) {
        return (
            <div style={{ display: 'flex' }}>
                <Sidebar />
                <div className="dashboard" style={{ marginLeft: '260px', padding: '20px' }}>
                    <h1>Loading...</h1>
                </div>
            </div>
        );
    }

    return (
        <div style={{ display: 'flex' }}>
            <Sidebar />
            <div className="dashboard" style={{ marginLeft: '260px', padding: '20px' }}>
                {isLoggedIn ? (
                    <>
                        <h1>Welcome to your Dashboard!</h1>
                        <button onClick={handleLogout}>Logout</button>
                    </>
                ) : (
                    <h1>Please log in to access the dashboard.</h1>
                )}
            </div>
        </div>
    );
};

export default Dashboard;