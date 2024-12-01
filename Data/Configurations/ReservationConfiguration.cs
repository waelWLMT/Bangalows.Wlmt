using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasOne<Client>(reservation => reservation.Client)
               .WithMany(client=> client.Reservations)
               .HasForeignKey(reservation=> reservation.ClientId)
               .IsRequired()
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Bangalow>(x => x.Bangalow)
               .WithMany(bangalow=> bangalow.Reservations)
               .HasForeignKey(reservation => reservation.BangalowId)
               .IsRequired()
               .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
