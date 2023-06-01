using System;
using System.Collections.Generic;
using System.Linq;
namespace Atividade18.EAgenda.Módulo_Tarefas
{
     public interface IRepositorioTarefa
     {
          void Editar(int id, Tarefa tarefa);
          void Inserir(Tarefa novaTarefa);
          void Remover(Tarefa tarefaSelecionada);
          Tarefa SelecionarPorId(int id);
          List<Tarefa>? SelecionarRegistros();
          List<Tarefa>? SelecionarTarefasConcluidas();
          List<Tarefa>? SelecionarTarefasPendentes();
     }
}
