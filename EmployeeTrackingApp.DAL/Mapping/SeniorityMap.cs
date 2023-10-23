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
    internal class SeniorityMap : IEntityTypeConfiguration<Seniority>
    {
        void IEntityTypeConfiguration<Seniority>.Configure(EntityTypeBuilder<Seniority> builder)
        {
            builder.HasKey(f => f.Id);


        }
    }
}
