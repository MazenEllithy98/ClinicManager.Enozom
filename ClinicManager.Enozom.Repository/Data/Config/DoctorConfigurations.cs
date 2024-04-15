using ClinicManager.Enozom.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Enozom.Repository.Data.Config
{
    internal class DoctorConfigurations : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.Property(D => D.Id).UseMySqlIdentityColumn();
            builder.Property(D => D.Name)
                .IsRequired().HasMaxLength(100);
        }
    }
}
