using BlazorCrudApp.Data;
using BlazorCrudApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudApp.Services
{
    public class ProductService
    {
        private readonly AppDbContext _db;

        public ProductService(AppDbContext db) => _db = db;

        public async Task<List<Product>> GetAllAsync() => await _db.Products.AsNoTracking().OrderByDescending(p => p.Id).ToListAsync();

        public async Task<Product?> GetByIdAsync(int id) => await _db.Products.FindAsync(id);

        public async Task<int> CreateAsync(Product product)
        {
            _db.Products.Add(product);
            await _db.SaveChangesAsync();

            return product.Id;  
        }

        public async Task<bool> UpdateAsync(Product product)
        {
            var existing = await _db.Products.FindAsync(product.Id);

            if (existing is null) return false;

            existing.Name = product.Name;
            existing.Price = product.Price;
            existing.Stock = product.Stock;

            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id) 
        {
            var existing = await _db.Products.FindAsync(id);

            if(existing is null) return false;

            _db.Products.Remove(existing);

            await _db.SaveChangesAsync();
            return true;
        }
    }
}
