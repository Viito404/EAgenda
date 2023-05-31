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
                    tabelaCompromisso.Rows.Add(compromisso.id, compromisso.assunto, compromisso.data);
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
                    }   
               };

               tabelaCompromisso.Columns.AddRange(colunas);
          }
     }
}
