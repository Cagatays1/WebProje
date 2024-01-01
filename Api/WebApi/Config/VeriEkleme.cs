using Bogus;
using Microsoft.EntityFrameworkCore;
using WebApi.Context;
using WebApi.Models.Entities;
using WebApi.Models.Entities.Common;

namespace WebApi.Config
{
    public class VeriEkleme
    {
        public async Task SeedAsync(IConfiguration configuration)
        {
            var dbContextBuilder = new DbContextOptionsBuilder();
            dbContextBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            var context = new DatabaseContext(dbContextBuilder.Options);


            List<string> policlinicNames = PoliclinicName.PoliclinicNames();
            int counter = 0;
            int policlinicCount = policlinicNames.Count;
            var policlinics = new Faker<Policlinic>("tr")
                    .RuleFor(i => i.Id, i => Guid.NewGuid())
                    .RuleFor(i => i.CreatedDate,
                                               i => i.Date.Between(DateTime.Now.AddDays(-100), DateTime.Now))
                    .RuleFor(i => i.Name, i => policlinicNames[counter++])
                .Generate(policlinicCount);

            await context.Policlinics.AddRangeAsync(policlinics);


            var citizens = new Faker<Citizen>("tr")
                    .RuleFor(i => i.Id, i => Guid.NewGuid())
                    .RuleFor(i => i.CreatedDate,
                            i => i.Date.Between(DateTime.Now.AddDays(-100), DateTime.Now))
                    .RuleFor(i => i.CitizenName, i => i.Person.FirstName)
                    .RuleFor(i => i.CitizenEmail, i => i.Person.Email)
                    .RuleFor(i => i.CitizenSurname, i => i.Person.LastName)
                .Generate(500);

            await context.Citizens.AddRangeAsync(citizens);


            var policlinicIds = policlinics.Select(i => i.Id);

            var doctors = new Faker<Doctor>("tr")
                    .RuleFor(i => i.Id, i => Guid.NewGuid())
                    .RuleFor(i => i.CreatedDate,
                                i => i.Date.Between(DateTime.Now.AddDays(-100), DateTime.Now))
                    .RuleFor(i => i.DoctorName, i => i.Person.FirstName)
                    .RuleFor(i => i.DoctorSurname, i => i.Person.LastName)
                    .RuleFor(i => i.PoliclinicId, i => i.PickRandom(policlinicIds))
                .Generate(100);

            await context.Doctors.AddRangeAsync(doctors);


            var doctorIds = doctors.Select(i => i.Id);


            var citizenIds = citizens.Select(i => i.Id);

            var guids = Enumerable.Range(0, 150).Select(i => Guid.NewGuid()).ToList();
            int counter1 = 0;

            var appointments = new Faker<Appointment>("tr")
                    .RuleFor(i => i.Id, i => guids[counter1++])
                    .RuleFor(i => i.CreatedDate,
                                i => i.Date.Between(DateTime.Now.AddDays(-100), DateTime.Now))
                    .RuleFor(i => i.AppointmentDate, i => i.Date.Between(DateTime.Now, DateTime.Now.AddDays(30)))
                    .RuleFor(i => i.CitizenId, i => i.PickRandom(citizenIds))
                    .RuleFor(i => i.DoctorId, i => i.PickRandom(doctorIds))
                .Generate(150);

            await context.Appointments.AddRangeAsync(appointments);

            await context.SaveChangesAsync();
        }
    }
}
