import React, { useEffect, useState } from 'react';
import axios from 'axios';

const UserList = () => {
  const [users, setUsers] = useState([]);

  // Fetch user list from API
  const fetchUsers = async () => {
    try {
      const response = await axios.get("https://localhost:7293/api/User/getAll");
      setUsers(response.data);
    } catch (err) {
      console.error("Error fetching users:", err);
    }
  };

  useEffect(() => {
    fetchUsers();
  }, []);

  // Delete a user
  const deleteUser = async (userId) => {
    try {
      await axios.delete(`https://localhost:7293/api/User/delete/${userId}`);
      setUsers(users.filter(user => user.id !== userId));
    } catch (err) {
      console.error("Error deleting user:", err);
    }
  };

  // Update a user (both username and password)
  const updateUser = async (userId) => {
    const newUsername = prompt("Enter new username:");
    const newPassword = prompt("Enter new password:");

    if (newUsername || newPassword) {
      try {
        const updatedUser = {};

        if (newUsername) updatedUser.username = newUsername;
        if (newPassword) updatedUser.password = newPassword;

        await axios.put(`https://localhost:7293/api/User/update/${userId}`, updatedUser);
        
        // Update users state with the new values
        setUsers(users.map(user => 
          user.id === userId ? { ...user, ...updatedUser } : user
        ));
      } catch (err) {
        console.error("Error updating user:", err);
      }
    }
  };

  return (
    <div>
      <h2>User List</h2>
      <ul>
        {users.map((user) => (
          <li key={user.id}>
            {user.username}
            <button onClick={() => updateUser(user.id)}>Update</button>
            <button onClick={() => deleteUser(user.id)}>Delete</button>
          </li>
        ))}
      </ul>
    </div>
  );
};

export default UserList;
