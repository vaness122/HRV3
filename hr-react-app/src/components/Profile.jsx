import React, { useState, useEffect } from "react";
import axios from "axios";
import Sidebar from "./Sidebar";
import { useParams } from "react-router-dom";

const Profile = () => {
  const { id } = useParams();
  const [employee, setEmployee] = useState({});
  const [loading, setLoading] = useState(false);
  const [profilePicture, setProfilePicture] = useState(null); // New state for handling profile picture
  const [file, setFile] = useState(null); // State for the uploaded file

  useEffect(() => {
    fetchEmployee();
  }, []);

  const fetchEmployee = async () => {
    setLoading(true);
    try {
      const response = await axios.get(`https://localhost:7293/api/Employee/${id}`);
      setEmployee(response.data);
    } catch (err) {
      console.error("Error fetching employee:", err);
    } finally {
      setLoading(false);
    }
  };

  const handleFileChange = (event) => {
    const file = event.target.files[0];
    setFile(file);
    setProfilePicture(URL.createObjectURL(file)); // Display the selected image
  };

  const handleUpload = async () => {
    if (!file) {
      console.error("No file selected");
      return;
    }

    const formData = new FormData();
    formData.append("profilePicture", file);

    try {
      const response = await axios.post(`https://localhost:7293/api/Employee/upload/${id}`, formData, {
        headers: {
          "Content-Type": "multipart/form-data",
        },
      });
      console.log("Profile picture uploaded:", response.data);
      setEmployee((prevState) => ({
        ...prevState,
        profilePicture: response.data.profilePicture, // Update employee state with new profile picture URL
      }));
    } catch (err) {
      console.error("Error uploading profile picture:", err);
    }
  };

  if (loading) {
    return <div>Loading...</div>;
  }

  return (
    <div className="bg-gray-50 min-h-screen">
      <Sidebar />
      <div className="container mx-auto py-8">
        <div className="grid grid-cols-1 sm:grid-cols-3 gap-6 px-4">
          {/* Profile Info Section */}
          <div className="bg-white shadow-lg rounded-lg p-6">
            {/* Upload New Profile Picture */}
            <div className="flex flex-col items-center mb-6">
              <input
                type="file"
                accept="image/*"
                onChange={handleFileChange}
                className="mb-4 p-2 border border-gray-300 rounded-md w-full sm:w-auto"
              />
              <button
                onClick={handleUpload}
                className="bg-green-500 hover:bg-green-600 text-white py-2 px-4 rounded-lg"
              >
                Upload Picture
              </button>
            </div>

            <div className="flex flex-col items-center">
              {/* Profile Picture */}
              <img
                src={profilePicture || employee.profilePicture || "https://via.placeholder.com/150"}
                alt="Profile"
                className="w-32 h-32 bg-gray-300 rounded-full mb-4 object-cover"
              />
              {/* Name */}
              <h1 className="text-2xl font-semibold text-gray-800">
                {employee.firstName} {employee.middleName} {employee.lastName}
              </h1>
              {/* Basic Info */}
              <p className="text-gray-600 mt-2">{employee.age} years old, {employee.gender}</p>
              <div className="mt-4 flex gap-4">
                <a href="#" className="bg-blue-500 hover:bg-blue-600 text-white py-2 px-4 rounded-lg">Edit</a>
                <a href="#" className="bg-gray-300 hover:bg-gray-400 text-gray-700 py-2 px-4 rounded-lg">Resume</a>
              </div>
            </div>

            <hr className="my-6 border-t border-gray-300" />
            {/* Details Section */}
            <div>
              <span className="text-gray-700 uppercase font-bold tracking-wider mb-2 block">Details</span>
              <ul className="text-gray-700">
                <li className="mb-2"><strong>Address:</strong> {employee.address}</li>
                <li className="mb-2"><strong>Age:</strong> {employee.age}</li>
                <li className="mb-2"><strong>Gender:</strong> {employee.gender}</li>
              </ul>
            </div>
          </div>

          {/* About Me & Experience Section */}
          <div className="bg-white shadow-lg rounded-lg p-6 sm:col-span-2">
            <h2 className="text-xl font-semibold mb-4">About Me</h2>
            <p className="text-gray-700">
              Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed finibus est vitae tortor ullamcorper, ut vestibulum velit convallis.
              Aenean posuere risus non velit egestas suscipit. Nunc finibus vel ante id euismod. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae.
            </p>
            <h3 className="font-semibold text-center mt-6 mb-4">Find me on</h3>
            <div className="flex justify-center items-center gap-6 my-6">
              {/* Social Links */}
              <a href="#" target="_blank" className="text-gray-700 hover:text-blue-600" aria-label="Visit profile on LinkedIn">
                <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 448 512" className="h-6 w-6">
                  <path fill="currentColor" d="M100.28 448H7.4V148.9h92.88zM53.79 108.1C24.09 108.1 0 83.5 0 53.8a53.79 53.79 0 0 1 107.58 0c0 29.7-24.1 54.3-53.79 54.3zM447.9 448h-92.68V302.4c0-34.7-.7-79.2-48.29-79.2-48.29 0-55.69 37.7-55.69 76.7V448h-92.78V148.9h89.08v40.8h1.3c12.4-23.5 42.69-48.3 87.88-48.3 94 0 111.28 61.9 111.28 142.3V448z" />
                </svg>
              </a>
              <a href="#" target="_blank" className="text-gray-700 hover:text-red-600" aria-label="Visit profile on YouTube">
                <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 576 512" className="h-6 w-6">
                  <path fill="currentColor" d="M549.655 124.083c-6.281-23.65-24.787-42.276-48.284-48.597C458.781 64 288 64 288 64S117.22 64 74.629 75.486c-23.497 6.322-42.003 24.947-48.284 48.597-11.412 42.867-11.412 132.305-11.412 132.305s0 89.438 11.412 132.305c6.281 23.65 24.787 41.5 48.284 47.821C117.22 448 288 448 288 448s170.78 0 213.371-11.486c23.497-6.321 42.003-24.171 48.284-47.821 11.412-42.867 11.412-132.305 11.412-132.305s0-89.438-11.412-132.305zm-317.51 213.508V175.185l142.739 81.205-142.739 81.201z" />
                </svg>
              </a>
              {/* Add more social icons here as needed */}
            </div>

            <h2 className="text-xl font-semibold mt-6 mb-4">Experience</h2>
            <div className="space-y-6">
              {/* Example Experience Section */}
              <div className="flex justify-between items-center">
                <span className="text-gray-700 font-bold">Employee</span>
                <p className="text-gray-600">
                  <span className="mr-2">at Company</span>
                  <span>2017 - 2019</span>
                </p>
              </div>
              <p className="text-gray-700">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed finibus est vitae tortor ullamcorper, ut vestibulum velit convallis.
                Aenean posuere risus non velit egestas suscipit.
              </p>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Profile;
