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
            builder.Property(p => p.SelectedDay).IsRequired();
            builder.Property(p => p.SelectedHours).IsRequired();

        }
    }
}
