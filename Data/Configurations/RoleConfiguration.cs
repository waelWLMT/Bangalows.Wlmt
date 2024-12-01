using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role { Id = 1, Libelle = "Admin", Code = "Admin", Description = "Administrateur" },
                new Role { Id = 2, Libelle = "Client" , Code = "Client" , Description = "Client ou locataire d'un bangalow" },
                new Role { Id = 3, Libelle = "Commercial" , Code = "Commercial" , Description = "Responsable sur la location d'une ou plusieurs bangalows" },
                new Role { Id = 4, Libelle = "Proprietaire", Code = "Proprietaire" , Description = "Proprietaire d'un ou plusieurs bangalows",  }
                );
        }
    }
}
