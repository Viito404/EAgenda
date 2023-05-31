using System.Data;
namespace Atividade18.EAgenda.Módulo_Tarefas
{
     public partial class TelaItensTarefaForm : Form
     {
          private Tarefa tarefa;
          List<ItemTarefa> tarefaList = new List<ItemTarefa>();
          public TelaItensTarefaForm(Tarefa tarefa)
          {
               InitializeComponent();
               this.ConfigurarDialog();
               this.tarefa = tarefa;
               ConfigurarTela();
          }

          private void ConfigurarTela()
          {
               tboxId.Text = tarefa.id.ToString();
               tboxTitulo.Text = tarefa.titulo;
               lbItensTarefa.Items.AddRange(tarefa.itens.ToArray());
          }

          public List<ItemTarefa> ObterItensTarefa()
          {
               return lbItensTarefa.Items.Cast<ItemTarefa>().ToList();
          }
          private void btnAdicionar_Click(object sender, EventArgs e)
          {
               string titulo = tboxDescricao.Text;

               ItemTarefa itemTarefa = new ItemTarefa(titulo);
               lbItensTarefa.Items.Add(itemTarefa); 
               tarefaList.Add(new ItemTarefa(titulo));               
          }

          private void btnCadastrar_Click(object sender, EventArgs e)
          {
               lbItensTarefa.Items.Clear();
               foreach (ItemTarefa item in tarefaList)
               {
                    lbItensTarefa.Items.Add(item);
               }
          }
     }
}
