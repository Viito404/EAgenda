namespace Atividade18.EAgenda.Módulo_Compromissos
{
     public partial class TelaFiltroCompromissosForm : Form
     {
          public TelaFiltroCompromissosForm()
          {
               InitializeComponent();
               this.ConfigurarDialog();
          }

          public FiltroPeriodoCompromissosEnum ObterPeriodoFiltro()
          {
               if (rbTodos.Checked)
               {
                    return FiltroPeriodoCompromissosEnum.Todos;
               }
               else if (rbPassados.Checked)
               {
                    return FiltroPeriodoCompromissosEnum.Passados;
               }
               else if (rbFuturos.Checked)
               {
                    return FiltroPeriodoCompromissosEnum.Futuros;
               }
               else
               {
                    return FiltroPeriodoCompromissosEnum.Nenhum;
               }
          }

          public DateTime ObterInicioPeriodo()
          {
               return dtpInicioPeriodo.Value;
          }
          public DateTime ObterFimPeriodo()
          {
               return dtpFimPeriodo.Value;
          }

          private void rbFuturos_CheckedChanged(object sender, EventArgs e)
          {
               dtpInicioPeriodo.Enabled = !dtpInicioPeriodo.Enabled;
               dtpFimPeriodo.Enabled = !dtpFimPeriodo.Enabled;
          }

          private void btnFiltrar_Click(object sender, EventArgs e)
          {
               FiltroPeriodoCompromissosEnum filtro = ObterPeriodoFiltro();

               if (filtro == FiltroPeriodoCompromissosEnum.Nenhum)
               {
                    TelaPrincipalForm.Instancia.AtualizarRodape("Selecione uma opção de filtro!", TipoStatusEnum.Erro);
                    DialogResult = DialogResult.None;
               }
          }
     }
}
