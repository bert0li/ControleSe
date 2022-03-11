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
    //public class EmailsEnviadosMap : IEntityTypeConfiguration<EmailsEnviados>
    //{
    //    public void Configure(EntityTypeBuilder<EmailsEnviados> entity)
    //    {
    //        entity.ToTable("EmailsEnviados");
    //        entity.HasKey(m => m.Id);
    //        entity.Property(m => m.Cc).HasMaxLength(200);
    //        entity.Property(m => m.EmailDestinatario).HasMaxLength(200).IsRequired();
    //        entity.Property(m => m.Assunto).HasMaxLength(200).IsRequired();
    //        entity.Property(m => m.Mensagem).HasMaxLength(300).IsRequired(false);

    //        entity.HasOne(m => m.Email)
    //              .WithMany(m => m.EmailsEnviados)
    //              .HasForeignKey(m => m.EmailId)
    //              .OnDelete(DeleteBehavior.NoAction);
    //    }
    //}
}
