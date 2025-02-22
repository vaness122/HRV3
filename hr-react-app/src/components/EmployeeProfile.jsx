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
    <div className="container mx-auto p-8">
      <h1 className="text-2xl font-bold text-center mb-6">Employee Profile</h1>
      <form onSubmit={handleSubmit} className="bg-white p-6 rounded-lg shadow-md">
        <div className="mb-4">
          <label htmlFor="firstName" className="block text-sm font-medium text-gray-700">
            First Name
          </label>
          <input
            type="text"
            id="firstName"
            name="firstName"
            value={profile.firstName}
            onChange={handleChange}
            className="mt-1 block w-full p-2.5 border border-gray-300 rounded-md"
            required
          />
        </div>

        <div className="mb-4">
          <label htmlFor="lastName" className="block text-sm font-medium text-gray-700">
            Last Name
          </label>
          <input
            type="text"
            id="lastName"
            name="lastName"
            value={profile.lastName}
            onChange={handleChange}
            className="mt-1 block w-full p-2.5 border border-gray-300 rounded-md"
            required
          />
        </div>

        <div className="mb-4">
          <label htmlFor="age" className="block text-sm font-medium text-gray-700">
            Age
          </label>
          <input
            type="number"
            id="age"
            name="age"
            value={profile.age}
            onChange={handleChange}
            className="mt-1 block w-full p-2.5 border border-gray-300 rounded-md"
            required
          />
        </div>

        <div className="mb-4">
          <label htmlFor="address" className="block text-sm font-medium text-gray-700">
            Address
          </label>
          <input
            type="text"
            id="address"
            name="address"
            value={profile.address}
            onChange={handleChange}
            className="mt-1 block w-full p-2.5 border border-gray-300 rounded-md"
            required
          />
        </div>

        <div className="mb-4">
          <label htmlFor="sex" className="block text-sm font-medium text-gray-700">
            Sex
          </label>
          <select
            id="sex"
            name="sex"
            value={profile.sex}
            onChange={handleChange}
            className="mt-1 block w-full p-2.5 border border-gray-300 rounded-md"
            required
          >
            <option value="">Select Gender</option>
            <option value="Male">Male</option>
            <option value="Female">Female</option>
            <option value="Other">Other</option>
          </select>
        </div>

        <button type="submit" className="w-full bg-blue-500 text-white p-2.5 rounded-md mt-4">
          Submit Profile
        </button>
      </form>
    </div>
  );
};

export default EmployeeProfile;
