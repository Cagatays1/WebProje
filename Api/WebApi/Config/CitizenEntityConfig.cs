using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models.Entities;

namespace WebApi.Config
{
    public class CitizenEntityConfig : IEntityTypeConfiguration<Citizen>
    {
        public void Configure(EntityTypeBuilder<Citizen> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CitizenName).IsRequired();
            builder.Property(p => p.CitizenSurname).IsRequired();
            builder.Property(p => p.CitizenEmail).IsRequired();


            builder.HasData(
                    new Citizen() { Id = Guid.NewGuid(), CitizenName = "Citizen1", CitizenSurname = "Surname" ,CitizenEmail = "citizen1@gmail.com", CreatedDate = DateTime.UtcNow },
                    new Citizen() { Id = Guid.NewGuid(), CitizenName = "Citizen2", CitizenSurname = "Surname" ,CitizenEmail = "citizen2@gmail.com", CreatedDate = DateTime.UtcNow },
                    new Citizen() { Id = Guid.NewGuid(), CitizenName = "Citizen3", CitizenSurname = "Surname" ,CitizenEmail = "citizen3@gmail.com", CreatedDate = DateTime.UtcNow },
                    new Citizen() { Id = Guid.NewGuid(), CitizenName = "Citizen4", CitizenSurname = "Surname" ,CitizenEmail = "citizen4@gmail.com", CreatedDate = DateTime.UtcNow },
                    new Citizen() { Id = Guid.NewGuid(), CitizenName = "Citizen5", CitizenSurname = "Surname" ,CitizenEmail = "citizen5@gmail.com", CreatedDate = DateTime.UtcNow }
                );
        }
    }
}
