namespace Atividade18.EAgenda.Módulo_Tarefas
{
     public partial class ListaTarefaControl : UserControl
     {
          public ListaTarefaControl()
          {
               InitializeComponent();
          }

          public void AtualizarRegistros(List<Tarefa> tarefas)
          {
               lbTarefas.Items.Clear();
               lbTarefas.Items.AddRange(tarefas.ToArray());
          }

          public Tarefa ObterTarefaSelecionada()
          {
               return (Tarefa)lbTarefas.SelectedItem;
          }
     }
}
