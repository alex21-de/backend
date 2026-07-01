using Enterprise.Application.Interfaces.Repositories;
using Enterprise.Domain.Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _db;

        public ProductRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(Product product)
        {
            _db.Products.Add(product);

            await _db.SaveChangesAsync();
        }

        public Task<Product?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
