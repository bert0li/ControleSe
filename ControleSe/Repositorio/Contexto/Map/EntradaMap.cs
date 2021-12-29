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
    public class EntradaMap : IEntityTypeConfiguration<Entrada>
    {
        public void Configure(EntityTypeBuilder<Entrada> entity)
        {
            entity.ToTable("Entrada");
            entity.HasKey(m => m.Id);
            entity.Property(m => m.ValorEntrada).IsRequired();
            entity.Property(m => m.DataEntrada).HasColumnType("date").IsRequired();
            entity.Property(m => m.Observacao).HasMaxLength(150).IsRequired(false);

            entity.HasOne(m => m.Usuario)
                  .WithMany(m => m.Entradas)
                  .HasForeignKey(m => m.UsuarioId)
                  .OnDelete(DeleteBehavior.NoAction);

            entity.HasIndex(i => i.DataEntrada)
                  .HasDatabaseName("index_dataEntrada_entrada");
        }
    }
}