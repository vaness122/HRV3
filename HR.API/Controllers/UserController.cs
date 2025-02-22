using HR.DAL.Models;
using HR.DAL.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _userRepository;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserRepo userRepository, ILogger<UserController> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            try
            {
                await _userRepository.AddUser(user.Username, user.Password);
                return Ok("User registered successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error: " + ex.Message);
            }
        }
    

    [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] User user)
        {
            try
            {
                bool isAuthenticated = _userRepository.AuthenticUser(user.Username, user.Password);
                if (isAuthenticated)
                {
                    return Ok("Authentication successful.");
                }
                else
                {
                    return Unauthorized("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error: " + ex.Message);
            }
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update(int id,  [FromBody] User user)

        {
            try
            {
                await _userRepository.UpdateUser(user.Username, user.Username,id);
                await _userRepository.UpdateUserPassword(user.Username, user.Password, id);
                return Ok("User updated successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error: " + ex.Message);
            }
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _userRepository.DeleteUser(id);
                return Ok("User deleted successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error: " + ex.Message);
            }
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllEmployees()
        {
            try
            {
                var users = await _userRepository.GetAllUserAsyncs();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error: " + ex.Message);
            }
        }
    }
}