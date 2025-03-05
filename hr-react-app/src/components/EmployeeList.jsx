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
            setEmployees(employees.filter((employee) => employee.id!== employeeId));
        } catch (err) {
            console.error('Error deleting employee:', err);
        }
    };

    const handleEditClick = (employee) => {
        setEditingEmployeeId(employee.id); // Set the ID of the employee being edited
        setFormData({...employee }); // Initialize form data with the employee's data
    };

    const handleCancelClick = () => {
        setEditingEmployeeId(null); // Cancel editing
    };

    const handleInputChange = (e) => {
        const { name, value } = e.target;
        setFormData({...formData, [name]: value }); // Update form data on input change
    };

    const handleUpdateEmployee = async () => {
        try {
            await axios.put(`https://localhost:7293/api/Employee/update/${editingEmployeeId}`, formData); // Update the employee in the database
            setEmployees(
                employees.map((employee) =>
                    employee.id === editingEmployeeId? {...employee,...formData } : employee
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
            {loading? (
                <p>Loading...</p>
            ) : (
                <table>
                    <thead>
                        <tr>
                            <th>Id</th>
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
                                {editingEmployeeId === employee.id? (
                                    <>
                                        <td><input type="text" name="firstName" value={formData.firstName || ''} onChange={handleInputChange} /></td>
                                        <td><input type="text" name="middleName" value={formData.middleName || ''} onChange={handleInputChange} /></td>
                                        <td><input type="text" name="lastName" value={formData.lastName || ''} onChange={handleInputChange} /></td>
                                        <td><input type="number" name="age" value={formData.age || ''} onChange={handleInputChange} /></td>
                                        <td><input type="text" name="gender" value={formData.gender || ''} onChange={handleInputChange} /></td>
                                        <td><input type="text" name="address" value={formData.address || ''} onChange={handleInputChange} /></td>
                                        <td>
                                            <button style={{ padding: '8px 12px', margin: '5px' }} onClick={handleUpdateEmployee}>Save</button>
                                            <button style={{ padding: '8px 12px', margin: '5px' }} onClick={handleCancelClick}>Cancel</button>
                                        </td>
                                    </>
                                ) : (
                                    <>
                                        <td>{employee.employeeId}</td>
                                        <td>{employee.firstName}</td>
                                        <td>{employee.middleName}</td>
                                        <td>{employee.lastName}</td>
                                        <td>{employee.age}</td>
                                        <td>{employee.gender}</td>
                                        <td>{employee.address}</td>
                                        <td>
                                        <button style={{ padding: '5px 12px', margin: '5px', fontSize: '12px', background: 'lightgreen', width: '50px' }} onClick={() => handleEditClick(employee)}>
  <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" strokeWidth={1.5} stroke="currentColor" className="size-6">
    <path strokeLinecap="round" strokeLinejoin="round" d="m16.862 4.487 1.687-1.688a1.875 1.875 0 1 1 2.652 2.652L10.582 16.07a4.5 4.5 0 0 1-1.897 1.13L6 18l.8-2.685a4.5 4.5 0 0 1 1.13-1.897l8.932-8.931Zm0 0L19.5 7.125M18 14v4.75A2.25 2.25 0 0 1 15.75 21H5.25A2.25 2.25 0 0 1 3 18.75V8.25A2.25 2.25 0 0 1 5.25 6H10" />
  </svg>
  
</button>

<button style={{ padding: '5px 12px', margin: '5px', fontSize: '12px', background: 'gray', width: '50px' }} onClick={() => deleteEmployee(employee.id)}>
  <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" strokeWidth={1.5} stroke="currentColor" className="size-6">
    <path strokeLinecap="round" strokeLinejoin="round" d="m14.74 9-.346 9m-4.788 0L9.26 9m9.968-3.21c.342.052.682.107 1.022.166m-1.022-.165L18.16 19.673a2.25 2.25 0 0 1-2.244 2.077H8.084a2.25 2.25 0 0 1-2.244-2.077L4.772 5.79m14.456 0a48.108 48.108 0 0 0-3.478-.397m-12.562c.34-.059.68-.114 1.022-.165m0 0a48.11 48.11 0 0 1 3.478-.397m7.5 0v-.916c0-1.18-.91-2.164-2.09-2.201a51.964 51.964 0 0 0-3.32 0c-1.18.037-2.09 1.022-2.09 2.201v.916m7.5 0a48.667 48.667 0 0 1-7.5 0" />
  </svg>
  
</button>

    <Link to={`/employee/${employee.id}/profile`}>
    <button style={{ padding: '4px 11px', margin: '2px', fontSize: '12px', width: '50px' }}>
  <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" strokeWidth={1.5} stroke="currentColor" className="size-6">
    <path strokeLinecap="round" strokeLinejoin="round" d="M17.982 18.725A7.488 7.488 0 0 0 12 15.75a7.488 7.488 0 0 0-5.982 2.975m11.963 0a9 9 0 1 0-11.963 0m11.963 0A8.966 8.966 0 0 1 12 21a8.966 8.966 0 0 1-5.982-2.275M15 9.75a3 3 0 1 1-6 0 3 3 0 0 1 6 0Z" />
  </svg>
 
</button>

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
