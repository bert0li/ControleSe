﻿using ControleSe.Entidade;
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
            entity.Property(m => m.TotalCobre).IsRequired();
        }
    }
}