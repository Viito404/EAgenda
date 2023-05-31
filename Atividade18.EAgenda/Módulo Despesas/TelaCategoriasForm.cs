using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade18.EAgenda.Módulo_Despesas
{
     public partial class TelaCategoriasForm : Form
     {
          public TelaCategoriasForm()
          {
               InitializeComponent();
               this.ConfigurarDialog();
          }

          public Categoria ObterCategoria()
          {
               int id = Convert.ToInt32(tboxId.Text);
               string titulo = tboxTitulo.Text;

               return new Categoria(id, titulo);
          }

          public void ConfigurarTela(Categoria categoria)
          {
               tboxId.Text = categoria.id.ToString();
               tboxTitulo.Text = categoria.titulo;
          }

          private void btnCadastrar_Click(object sender, EventArgs e)
          {
               Categoria categoria = ObterCategoria();


               string[] erros = categoria.ValidarErros();
               if(erros.Count() > 0)
               {
                    TelaPrincipalForm.Instancia.AtualizarRodape(erros[0], TipoStatusEnum.Erro);
                    DialogResult = DialogResult.None;
               }
          }
     }
}
