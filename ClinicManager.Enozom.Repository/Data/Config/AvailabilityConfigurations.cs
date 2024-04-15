using ClinicManager.Enozom.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Enozom.Repository.Data.Config
{
    internal class AvailabilityConfigurations : IEntityTypeConfiguration<Availability>
    {
        public void Configure(EntityTypeBuilder<Availability> builder)
        {
            builder.Property(A => A.Id).UseMySqlIdentityColumn();
            builder.Property(A => A.StartTime)
                .IsRequired();
            builder.Property(A => A.EndTime)
                .IsRequired();
            builder.Property(A => A.DayOfWeek) 
                .IsRequired();
        }
    }
}
