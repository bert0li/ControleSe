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
    public class EmailMap : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> entity)
        {
            entity.ToTable("Email");
            entity.HasKey(m => m.Id);
            entity.Property(m => m.Smtp).HasMaxLength(200).IsRequired();
            entity.Property(m => m.Porta).IsRequired();
            entity.Property(m => m.Ssl).IsRequired();
            entity.Property(m => m.EnderecoEmail).HasMaxLength(200).IsRequired();
            entity.Property(m => m.SenhaEmail).HasMaxLength(100).IsRequired();

            entity.HasOne(m => m.Usuario)
                  .WithOne(m => m.Email)
                  .HasPrincipalKey<Usuario>(m => m.Id)
                  .OnDelete(DeleteBehavior.NoAction);
        }
    }
}