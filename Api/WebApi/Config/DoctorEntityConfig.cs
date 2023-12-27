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


            builder.HasData(
                    new Doctor() { Id = Guid.NewGuid(), DoctorName = "Citizen1", DoctorSurname = "Surname", CitizenEmail = "citizen1@gmail.com", CreatedDate = DateTime.UtcNow },
                    new Doctor() { Id = Guid.NewGuid(), DoctorName = "Citizen2", DoctorSurname = "Surname", CitizenEmail = "citizen2@gmail.com", CreatedDate = DateTime.UtcNow },
                    new Doctor() { Id = Guid.NewGuid(), DoctorName = "Citizen3", DoctorSurname = "Surname", CitizenEmail = "citizen3@gmail.com", CreatedDate = DateTime.UtcNow },
                    new Doctor() { Id = Guid.NewGuid(), DoctorName = "Citizen4", DoctorSurname = "Surname", CitizenEmail = "citizen4@gmail.com", CreatedDate = DateTime.UtcNow },
                    new Doctor() { Id = Guid.NewGuid(), DoctorName = "Citizen5", DoctorSurname = "Surname", CitizenEmail = "citizen5@gmail.com", CreatedDate = DateTime.UtcNow }
                );
        }
    }
}
