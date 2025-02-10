import React, { useState } from "react";
import axios from "axios";
import { useNavigate } from "react-router-dom";

const Register = () => {
    const [username, setUsername] = useState("");
    const [password, setPassword] = useState("");
    const navigate = useNavigate();

    const handleRegister = async (e) => {
        e.preventDefault();

        try {
            const response = await axios.post(
                "https://localhost:7293/api/user/register",
                { username, password }
            );

            if (response.status === 200) {
                alert("User registered successfully!");
                navigate("/login"); // Redirect to login page
            }
        } catch (error) {
            alert("Error registering user");
            console.error("Registration error:", error);
        }
    };

    return (
        <div>
            <h1>Register</h1>
            <form onSubmit={handleRegister}>
                <input
                    type="text"
                    placeholder="Username"
                    value={username}
                    onChange={(e) => setUsername(e.target.value)}
                />
                <input
                    type="password"
                    placeholder="Password"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
                />
                <button type="submit">Register</button>
            </form>
            <button onClick={() => navigate("/login")}>Back to Login</button>
        </div>
    );
};

export default Register;