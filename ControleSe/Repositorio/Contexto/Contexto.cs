using ControleSe.Entidade;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSe.Repositorio.Contexto
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Divida> Divida { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<Cofre> Cofre { get; set; }
        public DbSet<Email> Email { get; set; }

        //public DbSet<EmailsEnviados> EmailsEnviados { get; set; }

        public Contexto() { }

        public Contexto(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connectionStringMySql = "server=easyinfo.zapto.org; initial catalog=Bertoli; user id=root; password=casarao08009890";
            //var connectionStringMySql = "server=easyinfo.zapto.org; initial catalog=ControleSe; user id=root; password=casarao08009890";

            //optionsBuilder.UseMySql(connectionStringMySql, ServerVersion.AutoDetect(connectionStringMySql),
            //                        o => o.EnableRetryOnFailure(
            //                                maxRetryCount: 3,
            //                                maxRetryDelay: TimeSpan.FromSeconds(5),
            //                                errorNumbersToAdd: null)
            //                        .MigrationsHistoryTable("HistoricoMigracao"));

            optionsBuilder.UseSqlServer(
                "server=DESENV;initial catalog=ControleSe;user id=sa;password=bertoli1836"
                //@"server=CODER\SQLEXPRESS;initial catalog=ControleSe;user id=sa;password=bertoli1836"
                , p =>
                  p.EnableRetryOnFailure(
                      maxRetryCount: 3,
                      maxRetryDelay: TimeSpan.FromSeconds(5),
                      errorNumbersToAdd: null)
                  .MigrationsHistoryTable("HistoricoMigracao"));

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* Varre um determinado assembly para todos os tipos que o implementam 
             IEntityTypeConfiguratione registra/configura cada um automaticamente */
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Contexto).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}