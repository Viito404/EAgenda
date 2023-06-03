using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Atividade18.EAgenda.Módulo_Tarefas
{
     public class RepositorioTarefasEmArquivo : RepositorioEmArquivoBase<Tarefa>, IRepositorioTarefa
     {
          public RepositorioTarefasEmArquivo(ContextoDados contexto) : base(contexto)
          {
          }

          public List<Tarefa>? SelecionarTarefasConcluidas()
          {
               return ObterRegistros()
                     .Where(x => x.PercentualConcluido == 100)
                     .ToList();
          }

          public List<Tarefa>? SelecionarTarefasPendentes()
          {
               return ObterRegistros()
                     .Where(x => x.PercentualConcluido < 100)
                     .ToList();
          }

          protected override List<Tarefa> ObterRegistros()
          {
               return contextoDados.tarefas;
          }
     }
}
