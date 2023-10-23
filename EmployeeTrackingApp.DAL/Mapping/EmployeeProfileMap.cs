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
    public class EmployeeProfileMap : IEntityTypeConfiguration<EmployeeProfile>
    {
        void IEntityTypeConfiguration<EmployeeProfile>.Configure(EntityTypeBuilder<EmployeeProfile> builder)
        {
            builder.HasKey(f => f.Id);

        }
    }
}
