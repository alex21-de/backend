using Enterprise.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<UserEntity?> GetByIdAsync(Guid id);
        Task AddAsync(UserEntity user);
        Task SaveChangesAsync();
    }
}
