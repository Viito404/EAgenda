using Atividade18.EAgenda.Módulo_Contatos;

namespace Atividade18.EAgenda.Módulo_Compromissos
{
     public partial class TelaCompromissosForm : Form
     {
          public TelaCompromissosForm(List<Contato> listaContatos)
          {
               InitializeComponent();
               this.ConfigurarDialog();
               CarregarContatos(listaContatos);
          }

          private void CarregarContatos(List<Contato> contatos)
          {
               foreach (Contato contato in contatos)
               {
                    combContatos.Items.Add(contato);
               }             
          }

          public Compromisso ObterCompromisso()
          {
               int id = Convert.ToInt32(tboxId.Text);
               string assunto = tboxAssunto.Text;

               DateTime data = dtpData.Value;

               TimeSpan horarioInicio = dtpHorarioInicio.Value.TimeOfDay;
               TimeSpan horarioFinal = dtpHorarioTermino.Value.TimeOfDay;
               LocalCompromissoEnum tipo;

               if (rbOnline.Checked)
               {
                    tipo = LocalCompromissoEnum.Online;
               }
               else if (rbPresencial.Checked)
               {
                    tipo = LocalCompromissoEnum.Presencial;
               }
               else
               {
                    tipo = LocalCompromissoEnum.Nenhum;
               }

               Contato contato = (Contato)combContatos.SelectedItem;

               string local;
               if (rbOnline.Checked)
                    local = tboxOnline.Text;
               else
                    local = tboxPresencial.Text;


               return new Compromisso(assunto, data, horarioInicio, horarioFinal, contato, local, tipo, id);
          }

          public void ConfigurarTela(Compromisso compromissoSelecionado)
          {
               tboxId.Text = compromissoSelecionado.id.ToString();
               tboxAssunto.Text = compromissoSelecionado.assunto;
               dtpData.Value = compromissoSelecionado.data;
               dtpHorarioInicio.Value = DateTime.Now.Date.Add(compromissoSelecionado.horarioInicio);
               dtpHorarioTermino.Value = DateTime.Now.Date.Add(compromissoSelecionado.horarioFinal);

               if (compromissoSelecionado.contato != null)
               {
                    cbMarcarContatos.Checked = true;
                    combContatos.SelectedItem = compromissoSelecionado.contato;
               }

               if (compromissoSelecionado.localCompromisso == LocalCompromissoEnum.Presencial)
               {
                    rbPresencial.Checked = true;
                    tboxPresencial.Text = compromissoSelecionado.localPresencial;
               }
               else
               {
                    rbOnline.Checked = true;
                    tboxOnline.Text = compromissoSelecionado.localOnline;
               }
          }

          private void btnCadastrar_Click(object sender, EventArgs e)
          {
               Compromisso compromisso = ObterCompromisso();

               string[] erros = compromisso.ValidarErros();

               if (erros.Length > 0)
               {
                    TelaPrincipalForm.Instancia.AtualizarRodape(erros[0], TipoStatusEnum.Erro);

                    DialogResult = DialogResult.None;
               }
          }

          private void rbPresencial_CheckedChanged(object sender, EventArgs e)
          {
               tboxPresencial.Enabled = true;
               tboxOnline.Enabled = false;
               tboxOnline.Text = "";
          }

          private void rbOnline_CheckedChanged(object sender, EventArgs e)
          {
               tboxOnline.Enabled = true;
               tboxPresencial.Enabled = false;
               tboxPresencial.Text = "";
          }

          private void cbMarcarContatos_CheckedChanged(object sender, EventArgs e)
          {
               combContatos.Enabled = !combContatos.Enabled;
               combContatos.SelectedIndex = -1;
          }
     }
}
