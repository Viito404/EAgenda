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
     public partial class TabelaTarefaControl : UserControl
     {
          public TabelaTarefaControl()
          {
               InitializeComponent();
               ConfigurarColunas();
               tabelaTarefa.ConfigurarGridLeitura();
               tabelaTarefa.ConfigurarGridZebrado();
          }

          private void ConfigurarColunas()
          {
               DataGridViewColumn[] colunas = new DataGridViewColumn[]
               {
                    new DataGridViewTextBoxColumn()
                    {
                         Name = "id",
                         HeaderText = "Nº"
                    },

                    new DataGridViewTextBoxColumn()
                    {
                         Name = "titulo",
                         HeaderText = "Título"
                    },

                    new DataGridViewTextBoxColumn()
                    {
                         Name = "prioridade",
                         HeaderText = "Prioridade"
                    },

                    new DataGridViewTextBoxColumn()
                    {
                         Name = "percentualConcluido",
                         HeaderText = "(%) Concluída"
                    },

                    new DataGridViewTextBoxColumn()
                    {
                         Name = "dataConclusao",
                         HeaderText = "Data Conclusão"
                    }
               };

               tabelaTarefa.Columns.AddRange(colunas);
          }

          public void AtualizarRegistros(List<Tarefa> listaTarefas)
          {
               tabelaTarefa.Rows.Clear();
               foreach (Tarefa tarefa in listaTarefas)
               {
                    tabelaTarefa.Rows.Add(tarefa.id, tarefa.titulo, tarefa.prioridade, tarefa.PercentualConcluido, tarefa.dataConclusao);
               }
          }

          public int ObterIdTarefaSelecionada()
          {
               int id;
               try
               {
                    id = Convert.ToInt32(tabelaTarefa.SelectedRows[0].Cells["id"].Value);
               }
               catch
               {
                    id = -1;
               }

               return id;
          }
     }
}
