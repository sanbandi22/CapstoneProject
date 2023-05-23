using CapstoneProject_Backend.DAL;
using CapstoneProject_Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace CapstoneProject_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService1 userService;
        public UserController(UserService1 userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        [Route("GetUserList")]
        public async Task<List<Users>> GetUsersAsync()
        {
            try
            {
                return await userService.GetUsersListAsync();
            }
            catch(Exception)
            {
                throw;
            }
        }
        [HttpGet]
        [Route("GetUserById")]
        public async Task<IEnumerable<Users>> GetUserByIdAsync(int Id)
        {
            try
            {
                var response = await userService.GetUserByIdAsync(Id);
                if(response==null)
                {
                    return null;
                }
                return response;
            }
            catch
            {
                throw;
            }
        }
        [HttpGet]
        [Route("Login")]
        public async Task<IEnumerable<Users>> Login(string email, string password)
        {
            try
            {
                var response = await userService.Login(email, password);
                if(response==null)
                {
                    return null;
                }
                return response;
            }
            catch
            {
                throw;
            }
        }
        [HttpPut("AddUser")]
        public async Task<IActionResult> AddUserAsync(Users users)
        {
            if(users==null)
            {
                return BadRequest();
            }
            try
            {
                var response = await userService.AddUserAsync(users);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }
        [HttpDelete("DeleteUser")]
        public async Task<IActionResult> DeleteUserAsync(int Id)
        {
            if(Id==null)
            {
                return BadRequest();
            }
            try
            {
                var response = await userService.DeleteUserAsync(Id);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }
        
    }
}
