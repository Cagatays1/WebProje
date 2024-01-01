using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models.Entities;

namespace WebApi.Config
{
    public class DoctorEntityConfig
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.DoctorName).IsRequired();
            builder.Property(p => p.DoctorSurname).IsRequired();

        }
    }
}
