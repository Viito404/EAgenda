using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Atividade18.EAgenda.Módulo_Tarefas
{
     public class RepositorioTarefasEmArquivo : IRepositorioTarefa
     {
          private static int contadorId = 0;
          private List<Tarefa> tarefas = new List<Tarefa>();
          private const string NOME_ARQUIVO_TAREFAS = "Módulo Tarefas/Tarefas.bin";

          public void Editar(int id, Tarefa tarefa)
          {
               throw new NotImplementedException();
          }

          public void Inserir(Tarefa novaTarefa)
          {
               contadorId++;
               novaTarefa.id = contadorId;
               tarefas.Add(novaTarefa);

               GravarTarefasEmArquivo();
          }

          private void GravarTarefasEmArquivo()
          {
               BinaryFormatter serializador = new BinaryFormatter();
               MemoryStream streamTarefa = new MemoryStream();

               serializador.Serialize(streamTarefa, tarefas);
               byte[] tarefasBytes = streamTarefa.ToArray();

               File.WriteAllBytes(NOME_ARQUIVO_TAREFAS, tarefasBytes);
          }

          public void Remover(Tarefa tarefaSelecionada)
          {
               throw new NotImplementedException();
          }

          public Tarefa SelecionarPorId(int id)
          {
               throw new NotImplementedException();
          }

          public List<Tarefa>? SelecionarRegistros()
          {
               throw new NotImplementedException();
          }

          public List<Tarefa>? SelecionarTarefasConcluidas()
          {
               throw new NotImplementedException();
          }

          public List<Tarefa>? SelecionarTarefasPendentes()
          {
               throw new NotImplementedException();
          }
     }
}
