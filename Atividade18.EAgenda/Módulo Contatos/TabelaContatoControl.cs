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

namespace Atividade18.EAgenda.Módulo_Contatos
{
     public partial class TabelaContatoControl : UserControl
     {
          public TabelaContatoControl()
          {
               InitializeComponent();
               ConfigurarColunas();
               tabelaContatos.ConfigurarGridLeitura();
               tabelaContatos.ConfigurarGridZebrado();
          }

          public void AtualizarRegistros(List<Contato> contatos)
          {
               tabelaContatos.Rows.Clear();
               foreach (Contato contato in contatos)
               {
                    tabelaContatos.Rows.Add(contato.id, contato.nome, contato.telefone, contato.email, contato.cargo, contato.empresa);
               }
          }

          public int ObterIdContatoSelecionado()
          {
               int id;
               try
               {
                    id = Convert.ToInt32(tabelaContatos.SelectedRows[0].Cells["id"].Value);
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
                         Name = "nome",
                         HeaderText = "Nome"
                    },
                new DataGridViewTextBoxColumn()
                    {
                         Name = "telefone",
                         HeaderText = "Telefone"
                    },
                new DataGridViewTextBoxColumn()
                    {
                         Name = "email",
                         HeaderText = "E-mail"
                    },
                new DataGridViewTextBoxColumn()
                    {
                         Name = "cargo",
                         HeaderText = "Cargo"
                    },
                new DataGridViewTextBoxColumn()
                    {
                         Name = "empresa",
                         HeaderText = "Empresa"
                    }
               };
               tabelaContatos.Columns.AddRange(colunas);
          }
     }
}
