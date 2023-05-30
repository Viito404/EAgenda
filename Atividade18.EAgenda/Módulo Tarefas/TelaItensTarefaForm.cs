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
     public partial class TelaItensTarefaForm : Form
     {
          private Tarefa tarefa;
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
               string titulo = tboxTitulo.Text;
               ItemTarefa itemTarefa = new ItemTarefa(tboxDescricao.Text);
               lbItensTarefa.Items.Add(itemTarefa);
          }
     }
}
