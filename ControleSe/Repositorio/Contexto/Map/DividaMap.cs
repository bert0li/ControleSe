using ControleSe.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSe.Repositorio.Contexto.Map
{
    public class DividaMap : IEntityTypeConfiguration<Divida>
    {
        public void Configure(EntityTypeBuilder<Divida> entity)
        {
            entity.ToTable("Divida");
            entity.HasKey(m => m.Id);
            entity.Property(m => m.Nome).HasMaxLength(200).IsRequired();
            entity.Property(m => m.Descricao).HasMaxLength(400).IsRequired(false);
            entity.Property(m => m.Valor).HasDefaultValue(0).IsRequired();
            entity.Property(m => m.TipoDivida).HasConversion<int>();
            entity.Property(m => m.DataVencimento).HasColumnType("date").IsRequired();
            entity.Property(m => m.DataPagamento).HasColumnType("date").IsRequired(false);
            entity.Property(m => m.Pago);

            entity.HasOne(m => m.Usuario)
                  .WithMany(m => m.Dividas)
                  .HasForeignKey(m => m.UsuarioId)
                  .OnDelete(DeleteBehavior.NoAction);

            entity.HasIndex(i => i.Nome)
                  .HasDatabaseName("index_nome_divida");
        }
    }
}
