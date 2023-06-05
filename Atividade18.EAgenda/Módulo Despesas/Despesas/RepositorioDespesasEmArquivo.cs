using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade18.EAgenda.Módulo_Despesas.Despesas
{
     public class RepositorioDespesasEmArquivo : RepositorioEmArquivoBase<Despesa>, IRepositorioDespesa
     {
          public RepositorioDespesasEmArquivo(ContextoDados contexto) : base(contexto)
          {
          }

          protected override List<Despesa> ObterRegistros()
          {
               return contextoDados.despesas;
          }
     }
}
