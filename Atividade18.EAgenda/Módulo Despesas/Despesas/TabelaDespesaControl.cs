using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade18.EAgenda.Módulo_Despesas.Despesas
{
     public partial class TabelaDespesaControl : UserControl
     {
          public TabelaDespesaControl()
          {
               InitializeComponent();
               ConfigurarColunas();
               tabelaDespesas.ConfigurarGridLeitura();
               tabelaDespesas.ConfigurarGridZebrado();
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
                         Name = "descricao",
                         HeaderText = "Descrição"
                    },
                    new DataGridViewTextBoxColumn()
                    {
                         Name = "data",
                         HeaderText = "Data"
                    },
                    new DataGridViewTextBoxColumn()
                    {
                         Name = "valor",
                         HeaderText = "Valor"
                    },
                    new DataGridViewTextBoxColumn()
                    {
                         Name = "pagamento",
                         HeaderText = "Forma De Pagameto"
                    }
 };

               tabelaDespesas.Columns.AddRange(colunas);
          }

          public void AtualizarDespesas(List<Despesa> listaDespesas)
          {
               tabelaDespesas.Rows.Clear();

               foreach (Despesa despesa in listaDespesas)
               {
                    tabelaDespesas.Rows.Add(despesa.id, despesa.descricao, despesa.data, despesa.valor, despesa.pagamento);
               }
          }

          public int ObterIdDespesaSelecionada()
          {
               if (tabelaDespesas.SelectedRows.Count == 0)
                    return -1;

               int id = Convert.ToInt32(tabelaDespesas.SelectedRows[0].Cells["id"].Value);
               return id;
          }
     }
}
