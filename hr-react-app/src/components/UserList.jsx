import React, { useEffect, useState } from 'react';
import axios from 'axios';
import Sidebar from './Sidebar';

const UserList = () => {
  const [users, setUsers] = useState([]);
  const [loading, setLoading] = useState(false);
  const [message, setMessage] = useState(''); // State to store the success/error message
  const [messageType, setMessageType] = useState(''); // State to store the message type (success/error)

  const fetchUsers = async () => {
    setLoading(true);
    try {
      const response = await axios.get('https://localhost:7293/api/User/getAll');
      setUsers(response.data);
    } catch (err) {
      console.error('Error fetching users:', err);
      setMessage('Error fetching users: ' + (err.response?.data?.message || err.message));
      setMessageType('error');
    } finally {
      setLoading(false);
    }
  };

  useEffect(() => {
    fetchUsers();
  }, []);

  // Function to close the message box after 5 seconds
  const closeMessage = () => {
    setMessage('');
    setMessageType('');
  };

  // Delete a user
  const deleteUser = async (userId) => {
    setLoading(true);
    try {
      await axios.delete(`https://localhost:7293/api/User/delete/${userId}`);
      setUsers(users.filter(user => user.id !== userId));
      setMessage('User deleted successfully!');
      setMessageType('success');
      setTimeout(closeMessage, 5000); // Hide the message after 5 seconds
    } catch (err) {
      console.error('Error deleting user:', err);
      setMessage('Error deleting user: ' + (err.response?.data?.message || err.message));
      setMessageType('error');
      setTimeout(closeMessage, 5000); // Hide the message after 5 seconds
    } finally {
      setLoading(false);
    }
  };

  // Update user details
  const updateUser = async (userId) => {
    const newUsername = prompt('Enter new username:');
    const newPassword = prompt('Enter new password:');

    if (!newUsername && !newPassword) {
      setMessage('Please provide a new username or password.');
      setMessageType('warning');
      setTimeout(closeMessage, 5000); // Hide the message after 5 seconds
      return;
    }

    const updatedUser = {};
    if (newUsername) updatedUser.username = newUsername;
    if (newPassword) updatedUser.password = newPassword;

    setLoading(true);
    try {
      await axios.put(
        `https://localhost:7293/api/User/update/${userId}`,
        updatedUser,
        { headers: { 'Content-Type': 'application/json' } }
      );

      setUsers(users.map((user) =>
        user.id === userId ? { ...user, ...updatedUser } : user
      ));
      setMessage('User updated successfully!');
      setMessageType('success');
      setTimeout(closeMessage, 5000); // Hide the message after 5 seconds
    } catch (err) {
      console.error('Error updating user:', err);
      setMessage('Error updating user: ' + (err.response?.data?.message || err.message));
      setMessageType('error');
      setTimeout(closeMessage, 5000); // Hide the message after 5 seconds
    } finally {
      setLoading(false);
    }
  };

  return (
    <div>
      <Sidebar />
      <div className="container mx-auto p-20">
        {/* Message Display */}
        {message && (
          <div
            className={`fixed top-1/2 left-1/2 transform -translate-x-1/2 -translate-y-1/2 w-96 p-4 rounded-md text-white text-center 
            ${messageType === 'success' ? 'bg-green-500' : 
              messageType === 'error' ? 'bg-red-500' : 'bg-yellow-500'}`}
            style={{ zIndex: 999 }}
          >
            {message}
          </div>
        )}

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
                      <button onClick={() => updateUser(user.id)} className="text-blue-500 hover:text-blue-700 mr-4">
                        Update
                      </button>
                      <button onClick={() => deleteUser(user.id)} className="text-red-500 hover:text-red-700">
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