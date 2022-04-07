using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Bidder.Data.Entities;

namespace Bidder.Business.Data.Config
{
    class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(r => r.NameAr).IsRequired();
            builder.Property(r => r.NameEn).IsRequired();
        }
    }
}