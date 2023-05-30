using Atividade18.EAgenda.Módulo_Tarefas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade18.EAgenda.Módulo_Compromissos
{
     public partial class TabelaCompromissoControl : UserControl
     {
          public TabelaCompromissoControl()
          {
               InitializeComponent();
               ConfigurarColunas();
               tabelaCompromisso.ConfigurarGridLeitura();
               tabelaCompromisso.ConfigurarGridZebrado();
          }

          public void AtualizarRegistros(List<Compromisso> compromissos)
          {
               tabelaCompromisso.Rows.Clear();
               foreach (Compromisso compromisso in compromissos)
               {
                    tabelaCompromisso.Rows.Add(compromisso.id, compromisso.assunto, compromisso.data, compromisso.contato);
               }
          }

          public int ObterIdCompromissoSelecionado()
          {
               int id;
               try
               {
                    id = Convert.ToInt32(tabelaCompromisso.SelectedRows[0].Cells["id"].Value);
               }
               catch
               {
                    id = -1;
               }

               return id;
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
                         Name = "assunto",
                         HeaderText = "Assunto"
                    },
                    new DataGridViewTextBoxColumn()
                    {
                         Name = "data",
                         HeaderText = "Data"
                    },
                    new DataGridViewTextBoxColumn()
                    {
                         Name = "contato",
                         HeaderText = "Contato"
                    }
               };

               tabelaCompromisso.Columns.AddRange(colunas);
          }
     }
}
