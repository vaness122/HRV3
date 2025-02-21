import React, { useEffect, useState } from 'react';
import axios from 'axios';
import Sidebar from './Sidebar';

const UserList = () => {
  const [users, setUsers] = useState([]);
  const [loading, setLoading] = useState(false); 

  
  const fetchUsers = async () => {
    setLoading(true); 
    try {
      const response = await axios.get("https://localhost:7293/api/User/getAll");
      setUsers(response.data);
    } catch (err) {
      console.error("Error fetching users:", err);
    } finally {
      setLoading(false); 
    }
  };

  useEffect(() => {
    fetchUsers();
  }, []);

  // Delete a user
 const deleteUser = async (userId) => {
  console.log("Deleting user ID:", userId);

  setLoading(true);
  try {
    await axios.delete(`https://localhost:7293/api/User/delete/${userId}`);
    setUsers(users.filter(user => user.id !== userId));
    alert('User deleted successfully!');
  } catch (err) {
    console.error("Error deleting user:", err);
    alert('Error deleting user: ' + err.response?.data?.message || err.message);
  } finally {
    setLoading(false);
  }
};

  const updateUser = async (userId) => {
    const newUsername = prompt("Enter new username:");
    const newPassword = prompt("Enter new password:");
  
    if (!newUsername && !newPassword) {
      alert("Please provide a new username or password.");
      return;
    }
  
    const updatedUser = {};
  
    if (newUsername) updatedUser.username = newUsername;
    if (newPassword) updatedUser.password = newPassword;
  
    console.log("Updating user ID:", userId);
    console.log("Data being sent:", updatedUser);
  
    setLoading(true);
    try {
      const response = await axios.put(
        `https://localhost:7293/api/User/update/${userId}`,
        updatedUser,
        { headers: { 'Content-Type': 'application/json' } }
      );
  
      console.log("Update response:", response.data);
  
      setUsers(users.map((user) =>
        user.id === userId ? { ...user, ...updatedUser } : user
      ));
      alert('User updated successfully!');
    } catch (err) {
      console.error('Error updating user:', err);
      alert('Error updating user: ' + err.response?.data?.message || err.message);
    } finally {
      setLoading(false);
    }
  };

  return (
    <div>
      <Sidebar />
      <div className="container mx-auto p-15">
        <div className="overflow-x-auto rounded-lg shadow">
          <table className="w-full text-sm text-left text-gray-500 dark:text-gray-400">
            <thead className="text-xs text-gray-700 uppercase bg-gray-50 dark:bg-gray-800 dark:text-gray-400">
              <tr>
                <th scope="col" className="px-6 py-10">ID</th>
                <th scope="col" className="px-6 py-10">Name</th>
                <th scope="col" className="px-6 py-10">Actions</th>
              </tr>
            </thead>

            <tbody>
              {loading ? (
                <tr>
                  <td colSpan="3" className="text-center py-4">Loading...</td>
                </tr>
              ) : (
                users.map((user) => (
                  <tr key={user.id} className="bg-white border-b dark:bg-gray-900 dark:border-gray-700">
                    <td className="px-6 py-4">{user.id}</td>
                    <td className="px-6 py-4">{user.username}</td>
                    <td className="px-6 py-4">
                      <button onClick={() => updateUser(user.id)} className="text-blue-500 hover:text-blue-700">
                        Update
                      </button>
                      <button onClick={() => deleteUser(user.id)} className="text-red-500 hover:text-red-700 ml-2">
                        Delete
                      </button>
                    </td>
                  </tr>
                ))
              )}
            </tbody>
          </table>
        </div>
      </div>
    </div>
  );
};

export default UserList;
