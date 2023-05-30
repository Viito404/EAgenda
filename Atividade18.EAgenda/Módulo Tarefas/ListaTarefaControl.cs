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
