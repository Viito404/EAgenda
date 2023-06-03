namespace Atividade18.EAgenda.Módulo_Contatos
{
    public class ControladorContato : ControladorBase
     {
          IRepositorioContato repositorioContatos;
          private TabelaContatoControl tabelaContato;

          public ControladorContato(IRepositorioContato repositorioContatos)
          {
               this.repositorioContatos = repositorioContatos;
          }

          public override string ToolTipInserir => "Inserir Contato";

          public override string ToolTipEditar => "Editar Contato"; 

          public override string ToolTipExcluir => "Remover Contato"; 

          public override void Inserir()
          {
               TelaContatosForm telaContato = new TelaContatosForm();

               DialogResult opcaoEscolhida = telaContato.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    Contato contato = telaContato.Contato;              

                    repositorioContatos.Inserir(contato);

                    CarregarContatos();
                    TelaPrincipalForm.Instancia.AtualizarRodape("Contato inserido com sucesso!", TipoStatusEnum.Sucesso);
               }
          }
          public override void Editar()
          {
               Contato contato = ObterContatoSelecionado();

               if (contato == null)
               {
                    MessageBox.Show($"Selecione um contato primeiro!",
                        "Edição de Contatos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return;
               }

               TelaContatosForm telaContato = new TelaContatosForm();
               telaContato.Contato = contato;

               DialogResult opcaoEscolhida = telaContato.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    repositorioContatos.Editar(telaContato.Contato.id, telaContato.Contato);

                    CarregarContatos();
                    TelaPrincipalForm.Instancia.AtualizarRodape("Contato editado com sucesso!", TipoStatusEnum.Sucesso);
               }
          }
          public override void Excluir()
          {
               Contato contato = ObterContatoSelecionado();

               if (contato == null)
               {
                    MessageBox.Show($"Selecione um contato primeiro!",
                        "Exclusão de Contatos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return;
               }

               DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o contato {contato.nome}?", "Exclusão de Contatos",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

               if (opcaoEscolhida == DialogResult.OK)
               {
                    repositorioContatos.Remover(contato);

                    CarregarContatos();
                    TelaPrincipalForm.Instancia.AtualizarRodape("Contato deletado com sucesso!", TipoStatusEnum.Sucesso);
               }
          }

          private Contato ObterContatoSelecionado()
          {
               int id = tabelaContato.ObterIdContatoSelecionado();
               return repositorioContatos.SelecionarPorId(id);
          }

          private void CarregarContatos()
          {
               List<Contato> contatos = repositorioContatos.SelecionarRegistros();
               tabelaContato.AtualizarRegistros(contatos);
          }
          public override UserControl ObterListas()
          {
               tabelaContato = new TabelaContatoControl();

               CarregarContatos();

               return tabelaContato;
          }
          public override string ObterTipoCadastro()
          {
               return "Cadastro de Contatos";
          }
     }
}
