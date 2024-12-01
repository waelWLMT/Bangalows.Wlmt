using Core.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class BangalowComercialConfiguration : IEntityTypeConfiguration<BangalowComercial>
    {
        public void Configure(EntityTypeBuilder<BangalowComercial> builder)
        {
            builder.HasOne(bc => bc.Commercial).WithMany(c => c.BangalowComercial).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(bc => bc.Bangalow).WithMany(b => b.BangalowComercials).OnDelete(DeleteBehavior.NoAction);
            builder.HasKey(bc => new { bc.ComercialId, bc.BangalowId });
                
        }
    }
}
