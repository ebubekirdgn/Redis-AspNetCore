﻿using RedisApp.API.Model;

namespace RedisApp.API.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAsync();

        Task<Product> GetByIdAsync(int id);

        Task<Product> CreateAsync(Product product);
    }
}