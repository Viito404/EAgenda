using Atividade18.EAgenda.Módulo_Compromissos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade18.EAgenda.Módulo_Tarefas
{
     public partial class TelaTarefasForm : Form
     {
          public TelaTarefasForm()
          {
               InitializeComponent();
               this.ConfigurarDialog();
               ConfigurarPrioridades();
          }

          private void ConfigurarPrioridades()
          {
               PrioridadesTarefasEnum[] prioridades = Enum.GetValues<PrioridadesTarefasEnum>();
               List<PrioridadesTarefasEnum> prioridadesLista = new List<PrioridadesTarefasEnum>(prioridades);

               prioridadesLista.Remove(PrioridadesTarefasEnum.Nenhum);

               foreach (PrioridadesTarefasEnum prioridade in prioridadesLista)
               {
                    combPrioridades.Items.Add(prioridade);
               }
          }

          private void btnCadastrar_Click(object sender, EventArgs e)
          {
               Tarefa tarefa = ObterTarefa();

               string[] erros = tarefa.ValidarErros();

               if (erros.Length > 0)
               {
                    TelaPrincipalForm.Instancia.AtualizarRodape(erros[0], TipoStatusEnum.Erro);

                    DialogResult = DialogResult.None;
               }
          }

          public Tarefa ObterTarefa()
          {
               int id = Convert.ToInt32(tboxId.Text);
               string titulo = tboxTitulo.Text;
               PrioridadesTarefasEnum prioridade = new PrioridadesTarefasEnum();
               if(combPrioridades.SelectedIndex != -1)
               {
                    prioridade = (PrioridadesTarefasEnum)combPrioridades.SelectedItem;
               }

               else 
                    prioridade = PrioridadesTarefasEnum.Nenhum;

               DateTime dataCriacao = dtpData.Value;

               return new Tarefa(id, titulo, prioridade, dataCriacao);
          }

          public void ConfigurarTela(Tarefa tarefa)
          {
               tboxId.Text = tarefa.id.ToString();
               tboxTitulo.Text = tarefa.titulo;
               combPrioridades.SelectedItem = tarefa.prioridade;
               dtpData.Value = tarefa.dataCriacao;

               if (tarefa.id > 0)
                    dtpData.Enabled = false;
          }
     }
}
