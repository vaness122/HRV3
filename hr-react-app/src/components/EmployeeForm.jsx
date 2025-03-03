import React, { useState, useEffect } from "react";
import axios from "axios";
import Sidebar from "./Sidebar";

const EmployeeForm = ({ employee, onSave }) => {
  const [formData, setFormData] = useState({
    firstName: "",
    middleName: "",
    lastName: "",
    age: "",
    gender: "",
    address: "",
  });

  const [error, setError] = useState(""); // For storing any error messages

  // Set the form data when the component is first loaded or when employee prop is updated
  useEffect(() => {
    if (employee) {
      setFormData({
        firstName: employee.firstName || "",
        middleName: employee.middleName || "",
        lastName: employee.lastName || "",
        age: employee.age || "",
        gender: employee.gender || "",
        address: employee.address || "",
        UserId: employee.UserId 
      });
    }
  }, [employee]);

  // Handle input field changes
  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prevData) => ({
      ...prevData,
      [name]: value,
    }));
  };

  // Handle form submit (either add or update employee)
  const handleSubmit = async (e) => {
    e.preventDefault();

    // Form validation
    if (!formData.firstName || !formData.lastName || !formData.age || !formData.gender || !formData.address) {
      setError("Please fill in all fields.");
      return;
    }

    try {
      // If employee is provided, update the existing employee
      if (employee) {
        formData.UserId = 1;
        await axios.put(`https://localhost:7293/api/Employee/update/${employee.id}`, formData);
      } else {
        // Otherwise, add a new employee
        formData.UserId = 1;
        console.log(JSON.stringify(formData));
        await axios.post("https://localhost:7293/api/Employee/add", formData);
      }
      setError(""); // Clear any previous errors
     // onSave(); // Notify the parent to refresh or handle the updated data
    } catch (err) {
      console.error("Error saving employee:", err);
      setError("Failed to save employee data. Please try again.");
    }
  };

  return (
    <div>
      <Sidebar />
      <form onSubmit={handleSubmit}>
        <h2>{employee ? "Update" : "Add"} Employee</h2>
        
        {error && <div style={{ color: "red" }}>{error}</div>} {/* Display error messages */}
        
        <div>
          <label>First Name</label>
          <input
            type="text"
            name="firstName"
            value={formData.firstName}
            onChange={handleChange}
          />
        </div>
        <div>
          <label>Middle Name</label>
          <input
            type="text"
            name="middleName"
            value={formData.middleName}
            onChange={handleChange}
          />
        </div>
        <div>
          <label>Last Name</label>
          <input
            type="text"
            name="lastName"
            value={formData.lastName}
            onChange={handleChange}
          />
        </div>
        <div>
          <label>Age</label>
          <input
            type="number"
            name="age"
            value={formData.age}
            onChange={handleChange}
          />
        </div>
        <div>
          <label>Gender</label>
          <select
            name="gender"
            value={formData.gender}
            onChange={handleChange}
          >
            <option value="">Select Gender</option>
            <option value="M">Male</option>
            <option value="F">Female</option>
          </select>
        </div>
        <div>
          <label>Address</label>
          <input
            type="text"
            name="address"
            value={formData.address}
            onChange={handleChange}
          />
        </div>
        <button type="submit">{employee ? "Update" : "Add"} Employee</button>
      </form>
    </div>
  );
};

export default EmployeeForm;