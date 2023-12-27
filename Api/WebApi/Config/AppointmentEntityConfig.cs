using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebApi.Models.Entities;

namespace WebApi.Config
{
    public class AppointmentEntityConfig : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.AppointmentDate).IsRequired();
            builder.HasOne(p=>p.Doctor).WithMany().HasForeignKey(p => p.DoctorId);
        }
    }
}
