﻿using ControleSe.Entidade;
using ControleSe.Entidade.Base;
using ControleSe.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSe.Servico
{
    public class ServicoCofre : ServicoBase
    {
        public string ObterValorTotalCofre(Usuario usuarioLogado)
        {
            try
            {
                string valorNoCofre = string.Empty;

                using (var contexto = new Contexto())
                {
                    var cofre = contexto.Cofre.Include(i => i.Usuario)
                                              .Where(w => w.UsuarioId == usuarioLogado.Id)
                                              .FirstOrDefault();

                    valorNoCofre = cofre.TotalCobre.ToString("C2");

                    return valorNoCofre;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Tuple<decimal, DateTime>> ObterUltimasEntradas(Usuario usuarioLogado)
        {
            try
            {
                IList<Tuple<decimal, DateTime>> tuple = new List<Tuple<decimal, DateTime>>();
                IEnumerable<Entrada> ultimasEntradas = null;

                using (var contexto = new Contexto())
                {
                    ultimasEntradas = contexto.Entrada
                                              .Where(w => w.UsuarioId == usuarioLogado.Id)
                                              .OrderByDescending(o => o.Id)
                                              .Take(4)
                                              .ToList();
                }

                if (usuarioLogado != null)
                {
                    foreach (var entrada in ultimasEntradas)
                    {
                        tuple.Add(Tuple.Create(entrada.ValorEntrada, entrada.DataEntrada));
                    }
                }

                return tuple;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}