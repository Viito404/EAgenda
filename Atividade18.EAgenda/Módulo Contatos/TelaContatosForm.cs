namespace Atividade18.EAgenda.Módulo_Contatos
{
    public partial class TelaContatosForm : Form
     {
          private Contato contato;
          public TelaContatosForm()
          {
               InitializeComponent();
               this.ConfigurarDialog();
          }

          public Contato Contato
          {
               set
               {
                    tboxId.Text = value.id.ToString();
                    tboxNome.Text = value.nome;
                    mtboxTelefone.Text = value.telefone;
                    tboxEmail.Text = value.email;
                    tboxCargo.Text = value.cargo;
                    tboxEmpresa.Text = value.empresa;
               }
               get
               {
                    return contato;
               }
          }
          private void btnCadastrar_Click(object sender, EventArgs e)
          {
               string nome = tboxNome.Text;
               string telefone = mtboxTelefone.Text;
               string email = tboxEmail.Text;
               string empresa = tboxEmpresa.Text;
               string cargo = tboxCargo.Text;

               contato = new Contato(nome, telefone, email, cargo, empresa);

               if (tboxId.Text != "0")
                    contato.id = Convert.ToInt32(tboxId.Text);

               string[] erros = contato.ValidarErros();

               if (!mtboxTelefone.MaskFull)
               {
                    Array.Resize(ref erros, erros.Length + 1);
                    erros[erros.Length - 1] = "Campo \"Telefone\" está incompleto!";
               }

               if (erros.Length > 0)
               {
                    TelaPrincipalForm.Instancia.AtualizarRodape(erros[0], TipoStatusEnum.Erro);
                    DialogResult = DialogResult.None;
               }

          }
     }
}
