namespace Atividade18.EAgenda.Módulo_Despesas
{
     public partial class TabelaCategoriaControl : UserControl
     {
          public TabelaCategoriaControl()
          {
               InitializeComponent();
               ConfigurarColunas();
               tabelaCategorias.ConfigurarGridLeitura();
               tabelaCategorias.ConfigurarGridZebrado();
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
                    }
               };

               tabelaCategorias.Columns.AddRange(colunas);
          }

          public void AtualizarCategorias(List<Categoria> listaCategorias)
          {
               tabelaCategorias.Rows.Clear();

               foreach (Categoria categoria in listaCategorias)
               {
                    tabelaCategorias.Rows.Add(categoria.id, categoria.titulo);
               }
          }

          public int ObterIdCategoriaSelecionada()
          {
               if(tabelaCategorias.SelectedRows.Count == 0)
                    return -1;

               int id = Convert.ToInt32(tabelaCategorias.SelectedRows[0].Cells["id"].Value);
               return id;
          }
     }
}
