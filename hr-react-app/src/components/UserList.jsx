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
    
   <div class="container mx-auto p-6">
        <div class="overflow-x-auto rounded-lg shadow">
            <table class="w-full text-sm text-left text-gray-500 dark:text-gray-400">
                
                <thead class="text-xs text-gray-700 uppercase bg-gray-50 dark:bg-gray-800 dark:text-gray-400">
                    <tr>
                        <th scope="col" class="px-6 py-3">
                            <button class="flex items-center">
                                Name
                                <svg class="w-3 h-3 ml-1.5" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 24 24">
                                    <path d="M8.574 11.024h6.852a2.075 2.075 0 0 0 1.847-1.086 1.9 1.9 0 0 0-.11-1.986L13.736 2.9a2.122 2.122 0 0 0-3.472 0L6.837 7.952a1.9 1.9 0 0 0-.11 1.986 2.074 2.074 0 0 0 1.847 1.086Zm6.852 1.952H8.574a2.072 2.072 0 0 0-1.847 1.087 1.9 1.9 0 0 0 .11 1.985l3.426 5.05a2.123 2.123 0 0 0 3.472 0l3.427-5.05a1.9 1.9 0 0 0 .11-1.985 2.074 2.074 0 0 0-1.846-1.087Z"/>
                                </svg>
                            </button>
                            
                        </th>
                        
                        
                        
                    </tr>
                </thead>

                <tbody>
                    <tr class="bg-white border-b dark:bg-gray-900 dark:border-gray-700 ">
                        <ul>
        {users.map((user) => (
          <tr  lassName="bg-white border-b dark:bg-gray-900 dark:border-gray-700" >
          
            <td  class="px-6 py-4">{user.username}</td>
            <td  class="px-6 py-4"><button  onClick={() => updateUser(user.id)}>Update</button></td>
            <td  class="px-6 py-4"><button onClick={() => deleteUser(user.id)}>Delete</button></td>
          </tr>
        ))}
      </ul>
                    </tr>
                    </tbody>
      
   </table>
   <div class="flex items-center justify-between p-4 bg-white dark:bg-gray-900">
                <button class="px-3 py-1 bg-gray-200 dark:bg-gray-700 rounded">Previous</button>
                <span class="text-sm text-gray-700 dark:text-gray-400">Page 1 of 10</span>
                <button class="px-3 py-1 bg-gray-200 dark:bg-gray-700 rounded">Next</button>
            </div>
   </div>
   </div>
  );
};

export default UserList;
