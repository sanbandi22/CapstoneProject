using CapstoneProject_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace CapstoneProject_Backend.DAL
{
    public interface CartService1
    {
        public Task<List<Cart>> GetCartListAsync();
        public Task<IEnumerable<Cart>> GetCartByIdAsync(int Id);
        public Task<IEnumerable<Cart>> GetCartByUserIdAsync(int Id);
        public Task<int> AddCartAsync(Cart cart);
        public Task<int> DeleteCartAsync(int Id);
        public Task<int> EmptyCartAsync();
    }
}
