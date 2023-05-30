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
     public partial class TelaFiltroTarefas : Form
     {
          public TelaFiltroTarefas()
          {
               InitializeComponent();
               this.ConfigurarDialog();
          }

          public StatusTarefasEnum ObterFiltroTarefa()
          {
               if (rbTodas.Checked)
               {
                    return StatusTarefasEnum.Todas;
               }
               else if (rbPendentes.Checked)
               {
                    return StatusTarefasEnum.Pendentes;
               }
               else if (rbConcluidas.Checked)
               {
                    return StatusTarefasEnum.Concluidas;
               }
               else
               {
                    return StatusTarefasEnum.Nenhuma;
               }
          }

          private void btnFiltrar_Click(object sender, EventArgs e)
          {
               StatusTarefasEnum statusFiltro = ObterFiltroTarefa();

               if (statusFiltro == StatusTarefasEnum.Nenhuma)
               {
                    TelaPrincipalForm.Instancia.AtualizarRodape("Selecione uma opção de filtro!", TipoStatusEnum.Erro);
                    DialogResult = DialogResult.None;
               }
          }
     }
}
