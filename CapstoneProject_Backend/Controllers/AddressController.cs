using CapstoneProject_Backend.DAL;
using CapstoneProject_Backend.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace CapstoneProject_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly AddressService1 addressService;
        public AddressController(AddressService1 addressService)
        {
            this.addressService = addressService;
        }
        [HttpGet]
        [Route("GetAddressByUserId")]
        public async Task<IEnumerable<Address>> GetCartByAddressIdAsync(int Id)
        {
            try
            {
                var response = await addressService.GetAddressByUserIdAsync(Id);
                if (response == null)
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
        [HttpPut]
        [Route("AddAddress")]
        public async Task<IActionResult> AddAddress(Address address)
        {
            if (address == null)
            {
                return BadRequest();
            }
            try
            {
                var response = await addressService.AddAddressAsync(address);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }
    }
}
