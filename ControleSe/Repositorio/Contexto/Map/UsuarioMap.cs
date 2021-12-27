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
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> entity)
        {
            entity.ToTable("Usuario");
            entity.HasKey(m => m.Id);
            entity.Property(m => m.Nome).HasMaxLength(200).IsRequired();
            entity.Property(m => m.UsuarioAcesso).HasMaxLength(50).IsRequired();
            entity.Property(m => m.SenhaAcesso).HasMaxLength(50).IsRequired();
            entity.Property(m => m.Ativo);

            entity.HasMany(m => m.Dividas)
                  .WithOne(m => m.Usuario)
                  .HasForeignKey(m => m.UsuarioId)
                  .OnDelete(DeleteBehavior.NoAction);

            entity.HasMany(m => m.Entradas)
                  .WithOne(m => m.Usuario)
                  .HasForeignKey(m => m.UsuarioId)
                  .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
