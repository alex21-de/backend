using Enterprise.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Infrastructure.Configurations
{
    public class BlogConfiguration : IEntityTypeConfiguration<BlogEntity>
    {
        public void Configure(EntityTypeBuilder<BlogEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User);
        }
    }
}
