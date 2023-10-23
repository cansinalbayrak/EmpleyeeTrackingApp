using EmployeeTrackingApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingApp.DAL.Mapping
{
    internal class SystemUserMap : IEntityTypeConfiguration<SystemUser>
    {
        void IEntityTypeConfiguration<SystemUser>.Configure(EntityTypeBuilder<SystemUser> builder)
        {
            builder.HasKey(f => f.Id);
            builder.HasAlternateKey(u => u.Username);
            builder.Property(u => u.Username).HasMaxLength(70).IsRequired(true);
            builder.Property(u => u.Password).IsRequired(true);

        }
    }
}
