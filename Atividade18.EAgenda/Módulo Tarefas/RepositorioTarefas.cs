namespace Atividade18.EAgenda.Módulo_Tarefas
{
    public class RepositorioTarefas : RepositorioBase<Tarefa>
     {
        public RepositorioTarefas(List<Tarefa> listaTarefas)
        {
               this.dados = listaTarefas;
        }

          public override List<Tarefa> SelecionarRegistros()
          {
               return dados.OrderByDescending(x => x.prioridade).ToList();
          }
          public List<Tarefa> SelecionarTarefasPendentes()
          {
               return dados.Where(x => x.PercentualConcluido != 100)
                    .OrderByDescending(x => x.prioridade)
                    .ToList();
          }

          public List<Tarefa>? SelecionarTarefasConcluidas()
          {
               return dados.Where(x => x.PercentualConcluido == 100)
                    .OrderByDescending(x => x.prioridade)
                    .ToList();
          }
     }
}
