import React, { useState, useEffect } from "react";
import axios from "axios";
import Sidebar from "./Sidebar";
import { Link } from "react-router-dom"; // Removed useNavigate

const EmployeeList = () => {
    const [employees, setEmployees] = useState([]);
    const [loading, setLoading] = useState(false);
    const [editingEmployeeId, setEditingEmployeeId] = useState(null); // State for tracking the employee being edited
    const [formData, setFormData] = useState({}); // State to hold form data for the employee being edited

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

    const handleEditClick = (employee) => {
        setEditingEmployeeId(employee.id); // Set the ID of the employee being edited
        setFormData({ ...employee }); // Initialize form data with the employee's data
    };

    const handleCancelClick = () => {
        setEditingEmployeeId(null); // Cancel editing
    };

    const handleInputChange = (e) => {
        const { name, value } = e.target;
        setFormData({ ...formData, [name]: value }); // Update form data on input change
    };

    const handleUpdateEmployee = async () => {
        try {
            await axios.put(`https://localhost:7293/api/Employee/update/${editingEmployeeId}`, formData); // Update the employee in the database
            setEmployees(
                employees.map((employee) =>
                    employee.id === editingEmployeeId ? { ...employee, ...formData } : employee
                )
            ); // Update the employee in the local state
            setEditingEmployeeId(null); // Exit editing mode
        } catch (err) {
            console.error('Error updating employee:', err);
        }
    };

    return (
        <div>
            <Sidebar />
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
                                {editingEmployeeId === employee.id ? (
                                    <>
                                        <td><input type="text" name="firstName" value={formData.firstName || ''} onChange={handleInputChange} /></td>
                                        <td><input type="text" name="middleName" value={formData.middleName || ''} onChange={handleInputChange} /></td>
                                        <td><input type="text" name="lastName" value={formData.lastName || ''} onChange={handleInputChange} /></td>
                                        <td><input type="number" name="age" value={formData.age || ''} onChange={handleInputChange} /></td>
                                        <td><input type="text" name="gender" value={formData.gender || ''} onChange={handleInputChange} /></td>
                                        <td><input type="text" name="address" value={formData.address || ''} onChange={handleInputChange} /></td>
                                        <td>
                                            <button onClick={handleUpdateEmployee}>Save</button>
                                            <button onClick={handleCancelClick}>Cancel</button>
                                        </td>
                                    </>
                                ) : (
                                    <>
                                        <td>{employee.firstName}</td>
                                        <td>{employee.middleName}</td>
                                        <td>{employee.lastName}</td>
                                        <td>{employee.age}</td>
                                        <td>{employee.gender}</td>
                                        <td>{employee.address}</td>
                                        <td>
                                            <button onClick={() => handleEditClick(employee)}>Update</button>
                                            <button onClick={() => deleteEmployee(employee.id)}>Delete</button>
                                            <Link to={`/employee/${employee.id}/profile`}>
                                                <button>Profile</button>
                                            </Link>
                                        </td>
                                    </>
                                )}
                            </tr>
                        ))}
                    </tbody>
                </table>
            )}
        </div>
    );
};

export default EmployeeList;