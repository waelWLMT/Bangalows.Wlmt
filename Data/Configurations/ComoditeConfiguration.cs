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
    public class ComoditeConfiguration : IEntityTypeConfiguration<Comodite>
    {
        public void Configure(EntityTypeBuilder<Comodite> builder)
        {
           builder.HasData(           
                new Comodite { Id = 1, Libelle = "Vue En Mer"},
                new Comodite { Id = 2, Libelle = "Jardin" },
                new Comodite { Id = 3, Libelle = "Lit Enfant" },
                new Comodite { Id = 4, Libelle = "Frigo" },
                new Comodite { Id = 5, Libelle = "Picsine" },
                new Comodite { Id = 6, Libelle ="Place parking"},
                new Comodite { Id = 7, Libelle = "Console de jeux vidéo"},
                new Comodite { Id = 8, Libelle= "jacuzzi Spa" },
                new Comodite { Id = 9, Libelle = "Wifi" },
                new Comodite { Id = 10, Libelle = "Systéme de son-surround" },
                new Comodite { Id = 11, Libelle = "DVD et Livres" },
                new Comodite { Id = 12, Libelle = "Netflix" }
           );
        }
    }
}
