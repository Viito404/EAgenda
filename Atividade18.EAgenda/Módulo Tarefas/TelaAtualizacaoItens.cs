using System.Data;
namespace Atividade18.EAgenda.Módulo_Tarefas
{
     public partial class TelaAtualizacaoItens : Form
     {
          public TelaAtualizacaoItens(Tarefa tarefa)
          {
               InitializeComponent();
               this.ConfigurarDialog();
               ConfigurarTela(tarefa);
          }
          private void ConfigurarTela(Tarefa tarefa)
          {
               tboxId.Text = tarefa.id.ToString();
               tboxTitulo.Text = tarefa.titulo;

               int i = 0;

               foreach (ItemTarefa item in tarefa.itens)
               {
                    clbItensTarefa.Items.Add(item);

                    if (item.concluido)
                         clbItensTarefa.SetItemChecked(i, true);

                    i++;
               }
          }

          public List<ItemTarefa> ObterItensMarcados()
          {
               return clbItensTarefa.CheckedItems
                    .Cast<ItemTarefa>()
                    .ToList();
          }

          public List<ItemTarefa> ObterItensDesmarcados()
          {
               return clbItensTarefa.Items
                    .Cast<ItemTarefa>()
                    .Except(ObterItensMarcados())
                    .ToList();
          }
     }
}
