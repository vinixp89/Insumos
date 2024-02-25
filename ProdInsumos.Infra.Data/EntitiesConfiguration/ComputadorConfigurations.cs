using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProdInsumos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdInsumos.Infra.Data.EntitiesConfiguration
{
    public class ComputadorConfiguration : IEntityTypeConfiguration<Computador>
    {
        public void Configure(EntityTypeBuilder<Computador> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Setor).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Disco).HasMaxLength(50).IsRequired();
            builder.Property(x => x.TamanhoDisco).HasMaxLength(100000000).IsRequired();
            builder.Property(x => x.Marca).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Modelo).HasMaxLength(50).IsRequired();
            builder.Property(x => x.SistemaOperacional).HasMaxLength(50).IsRequired();
            builder.Property(x => x.MemoriaRam).HasMaxLength(100000).IsRequired();


        }
    }
}
