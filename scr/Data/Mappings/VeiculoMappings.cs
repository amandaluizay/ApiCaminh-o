using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Models;

namespace Data.Mappings
{
    public class VeiculoMapping : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.AnoModelo)
                .IsRequired()
                .HasColumnType("INT");

            builder.Property(p => p.AnoFabricaco)
                .IsRequired()
                .HasColumnType("INT");

            
        }
    }
}
