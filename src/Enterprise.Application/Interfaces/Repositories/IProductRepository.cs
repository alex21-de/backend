using Enterprise.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task<Product?> GetByIdAsync(Guid id);
    }
}
