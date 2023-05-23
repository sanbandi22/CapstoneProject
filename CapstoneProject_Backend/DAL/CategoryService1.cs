﻿using CapstoneProject_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace CapstoneProject_Backend.DAL
{
    public interface CategoryService1
    {
        public Task<List<Category>> GetCategoryListAsync();
        public Task<IEnumerable<Category>> GetCategoryByIdAsync(int Id);
        public Task<int> AddCategoryAsync(Category category);
        public Task<int> DeleteCategoryAsync(int Id);
        public Task<int> UpdateCategoryAsync(int Id, Category category);
    }
}
