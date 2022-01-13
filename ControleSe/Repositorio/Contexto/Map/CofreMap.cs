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
    public class CofreMap : IEntityTypeConfiguration<Cofre>
    {
        public void Configure(EntityTypeBuilder<Cofre> entity)
        {
            entity.ToTable("Cofre");
            entity.HasKey(m => m.Id);
            entity.Property(m => m.TotalCobre).HasColumnType("decimal(65, 2)").IsRequired();
            entity.Ignore(m => m.EhIncluir);

            entity.HasOne(m => m.Usuario)
                  .WithOne(m => m.Cofre)
                  .HasPrincipalKey<Cofre>(m => m.Id)
                  .OnDelete(DeleteBehavior.NoAction);
        }
    }
}