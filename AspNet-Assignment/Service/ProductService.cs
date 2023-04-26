using AspNet_Assignment.Contexts;
using AspNet_Assignment.Models.Products;
using AspNetCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNet_Assignment.Service
{
    public class ProductService
    {
        private readonly IdentityContext _context;

        public ProductService(IdentityContext context)
        {
            _context = context;
        }

        public async Task AddProductAsync(ProductEntity entity)
        {
            _context.Products.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductEntity>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
