﻿using Microsoft.EntityFrameworkCore;
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

        }
    }
}
