import React, { useState, useEffect } from "react";
import axios from "axios";
import Sidebar from "./Sidebar";
const EmployeeList = ({ onEmployeeUpdate }) => {
  const [employees, setEmployees] = useState([]);
  const [loading, setLoading] = useState(false);

  useEffect(() => {
    fetchEmployees();
  }, []);

  const fetchEmployees = async () => {
    setLoading(true);
    try {
      const response = await axios.get('https://localhost:7293/api/Employee');
      setEmployees(response.data);
    } catch (err) {
      console.error('Error fetching employees:', err);
    } finally {
      setLoading(false);
    }
  };

  const deleteEmployee = async (employeeId) => {
    try {
      await axios.delete(`https://localhost:7293/api/Employee/${employeeId}`);
      setEmployees(employees.filter((employee) => employee.id !== employeeId));
    } catch (err) {
      console.error('Error deleting employee:', err);
    }
  };

  return (
    
    <div>
        <Sidebar/>
      <h2>Employee List</h2>
      {loading ? (
        <p>Loading...</p>
      ) : (
        <table>
          <thead>
            <tr>
              <th>First Name</th>
              <th>Middle Name</th>
              <th>Last Name</th>
              <th>Age</th>
              <th>Gender</th>
              <th>Address</th>
              <th>Actions</th>
            </tr>
          </thead>
          <tbody>
            {employees.map((employee) => (
              <tr key={employee.id}>
                <td>{employee.firstName}</td>
                <td>{employee.middleName}</td>
                <td>{employee.lastName}</td>
                <td>{employee.age}</td>
                <td>{employee.gender}</td>
                <td>{employee.address}</td>
                <td>
                  <button onClick={() => onEmployeeUpdate(employee)}>Update</button>
                  <button onClick={() => deleteEmployee(employee.id)}>Delete</button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
};

export default EmployeeList;
