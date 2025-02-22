import React, { useState } from 'react';

const EmployeeProfile = () => {
  const [profile, setProfile] = useState({
    firstName: '',
    lastName: '',
    age: '',
    address: '',
    sex: '',
  });

  const handleChange = (e) => {
    const { name, value } = e.target;
    setProfile((prevProfile) => ({
      ...prevProfile,
      [name]: value,
    }));
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    alert('Profile submitted successfully');
    // Here, you can send the profile data to a backend or perform other actions
  };

  return (
    <div className="flex justify-center items-center min-h-screen bg-gray-100 py-8">
      <div className="bg-white shadow-lg rounded-lg w-full sm:max-w-md p-8">
        <h1 className="text-2xl font-bold text-center text-gray-800 mb-6">Employee Profile</h1>
        <form onSubmit={handleSubmit} className="space-y-6">
          <div>
            <label htmlFor="firstName" className="block text-sm font-medium text-gray-700">
              First Name
            </label>
            <input
              type="text"
              id="firstName"
              name="firstName"
              value={profile.firstName}
              onChange={handleChange}
              className="mt-2 block w-full p-3 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
              required
            />
          </div>

          <div>
            <label htmlFor="lastName" className="block text-sm font-medium text-gray-700">
              Last Name
            </label>
            <input
              type="text"
              id="lastName"
              name="lastName"
              value={profile.lastName}
              onChange={handleChange}
              className="mt-2 block w-full p-3 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
              required
            />
          </div>

          <div>
            <label htmlFor="age" className="block text-sm font-medium text-gray-700">
              Age
            </label>
            <input
              type="number"
              id="age"
              name="age"
              value={profile.age}
              onChange={handleChange}
              className="mt-2 block w-full p-3 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
              required
            />
          </div>

          <div>
            <label htmlFor="address" className="block text-sm font-medium text-gray-700">
              Address
            </label>
            <input
              type="text"
              id="address"
              name="address"
              value={profile.address}
              onChange={handleChange}
              className="mt-2 block w-full p-3 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
              required
            />
          </div>

          <div>
            <label htmlFor="sex" className="block text-sm font-medium text-gray-700">
              Sex
            </label>
            <select
              id="sex"
              name="sex"
              value={profile.sex}
              onChange={handleChange}
              className="mt-2 block w-full p-3 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
              required
            >
              <option value="">Select Gender</option>
              <option value="Male">Male</option>
              <option value="Female">Female</option>
              <option value="Other">Other</option>
            </select>
          </div>

          <button
            type="submit"
            className="w-full bg-blue-500 text-white py-3 rounded-md hover:bg-blue-600 transition duration-200 ease-in-out"
          >
            Submit Profile
          </button>
        </form>
      </div>
    </div>
  );
};

export default EmployeeProfile;
