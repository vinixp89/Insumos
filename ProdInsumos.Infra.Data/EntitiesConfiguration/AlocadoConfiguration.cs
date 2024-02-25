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
    public class AlocadoConfiguration : IEntityTypeConfiguration<Alocado>
    {
        public void Configure(EntityTypeBuilder<Alocado> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdFuncionario).IsRequired();
            builder.Property(x => x.IdComputador).IsRequired();
            builder.Property(x => x.DataRecebido).IsRequired();
            builder.Property(x => x.DataEntrega).IsRequired();
            builder.Property(x => x.Entregue).IsRequired();

            builder.HasOne(x => x.Funcionario).WithMany(x => x.Alocado)
                .HasForeignKey(x => x.IdFuncionario).OnDelete(DeleteBehavior.NoAction);



        }
    }
}
