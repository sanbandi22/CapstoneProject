using CapstoneProject_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace CapstoneProject_Backend.DAL
{
    public interface AddressService1
    {
        public Task<IEnumerable<Address>> GetAddressByUserIdAsync(int Id);
        public Task<int> AddAddressAsync(Address address);
    }
}
