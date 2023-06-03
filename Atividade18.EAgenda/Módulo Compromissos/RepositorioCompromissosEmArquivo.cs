using Atividade18.EAgenda.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade18.EAgenda.Módulo_Compromissos
{
     public class RepositorioCompromissosEmArquivo : RepositorioEmArquivoBase<Compromisso>, IRepositorioCompromisso
     {
          public RepositorioCompromissosEmArquivo(ContextoDados contexto) : base(contexto)
          {
          }

          public List<Compromisso>? SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
          {
               return ObterRegistros()
                    .Where(x => x.data > dataInicio)
                    .Where(x=> x.data < dataFinal)
                    .ToList();
          }

          public List<Compromisso>? SelecionarCompromissosPassados(DateTime now)
          {
               return ObterRegistros()
                    .Where(x => x.data.Date < now.Date)
                    .ToList();
          }

          protected override List<Compromisso> ObterRegistros()
          {
               return contextoDados.compromissos;
          }
     }
}
