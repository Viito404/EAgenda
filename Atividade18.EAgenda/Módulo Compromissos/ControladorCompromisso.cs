using Atividade18.EAgenda.Módulo_Contatos;

namespace Atividade18.EAgenda.Módulo_Compromissos
{
     public class ControladorCompromisso : ControladorBase
     {
          private RepositorioContatos repositorioContato;
          private RepositorioCompromissos repositorioCompromisso;
         TabelaCompromissoControl tabelaCompromisso;

          public ControladorCompromisso(RepositorioContatos repositorioContato, RepositorioCompromissos repositorioCompromisso)
          {
               this.repositorioContato = repositorioContato;
               this.repositorioCompromisso = repositorioCompromisso;
          }

          public override string ToolTipInserir => "Inserir Compromisso";

          public override string ToolTipEditar => "Editar Compromisso";

          public override string ToolTipExcluir => "Remover Compromisso";

          public override string ToolTipFiltrar => "Fltrar Compromissos";

          public override bool InserirHabilitado => true;
          public override bool EditarHabilitado => true;
          public override bool ExcluirHabilitado => true;
          public override bool FiltrarHabilitado => true;

          public override void Editar()
          {
               Compromisso compromissoSelecionado = ObterCompromissoSelecionado();

               if (compromissoSelecionado == null)
               {
                    MessageBox.Show($"Selecione um compromisso primeiro!",
                       "Edição de Compromissos",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);

                    return;
               }
               List<Contato> contatos = repositorioContato.SelecionarRegistros();
               TelaCompromissosForm telaCompromisso = new TelaCompromissosForm(contatos);

               telaCompromisso.ConfigurarTela(compromissoSelecionado);

               DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    Compromisso compromisso = telaCompromisso.ObterCompromisso();

                    repositorioCompromisso.Editar(compromisso.id, compromisso);

                    CarregarCompromissos();
                    TelaPrincipalForm.Instancia.AtualizarRodape("Compromisso editado com sucesso!", TipoStatusEnum.Sucesso);
               }
          }

          private Compromisso ObterCompromissoSelecionado()
          {
               int id = tabelaCompromisso.ObterIdCompromissoSelecionado();
               return repositorioCompromisso.SelecionarPorId(id);
          }

          public override void Excluir()
          {
               Compromisso compromissoSelecionado = ObterCompromissoSelecionado();

               if (compromissoSelecionado == null)
               {
                    MessageBox.Show($"Selecione um compromisso primeiro!",
                       "Exclusão de Compromissos",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);

                    return;
               }

               DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o compromisso {compromissoSelecionado.assunto}?",
        "Exclusão de Compromissos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

               if (opcaoEscolhida == DialogResult.OK)
               {
                    repositorioCompromisso.Remover(compromissoSelecionado);

                    CarregarCompromissos();
                    TelaPrincipalForm.Instancia.AtualizarRodape("Compromisso deletado com sucesso!", TipoStatusEnum.Sucesso);
               }
          }

          public override void Inserir()
          {
               List<Contato> contatos = repositorioContato.SelecionarRegistros();
               TelaCompromissosForm telaCompromisso = new TelaCompromissosForm(contatos);

               DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    Compromisso compromisso = telaCompromisso.ObterCompromisso();

                    repositorioCompromisso.Inserir(compromisso);

                    CarregarCompromissos();
                    TelaPrincipalForm.Instancia.AtualizarRodape("Compromisso inserido com sucesso!", TipoStatusEnum.Sucesso);
               }
          }

          public override void Filtrar()
          {
               TelaFiltroCompromissosForm telaFiltro = new TelaFiltroCompromissosForm();
               DialogResult opcaoEscolhida = telaFiltro.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    FiltroPeriodoCompromissosEnum periodoCompromissos = telaFiltro.ObterPeriodoFiltro();
                    List<Compromisso> compromissos = null;


                    if (periodoCompromissos == FiltroPeriodoCompromissosEnum.Todos)
                         compromissos = repositorioCompromisso.SelecionarRegistros();

                    else if (periodoCompromissos == FiltroPeriodoCompromissosEnum.Passados)
                    {
                         compromissos = repositorioCompromisso.SelecionarCompromissosPassados(DateTime.Now);
                    }
                    else if (periodoCompromissos == FiltroPeriodoCompromissosEnum.Futuros)
                    {
                         DateTime dataInicio = telaFiltro.ObterInicioPeriodo();
                         DateTime dataFinal = telaFiltro.ObterFimPeriodo();
                         compromissos = repositorioCompromisso.SelecionarCompromissosFuturos(dataInicio, dataFinal);
                    }
                    else
                    {
                         TelaPrincipalForm.Instancia.AtualizarRodape("Selecione algum filtro!", TipoStatusEnum.Erro);
                    }

                    CarregarCompromissosFiltrados(compromissos);
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {compromissos.Count} compromisso(s)", TipoStatusEnum.Visualizando);
               }
          }

          private void CarregarCompromissosFiltrados(List<Compromisso> compromissosFiltrados)
          {
               tabelaCompromisso.AtualizarRegistros(compromissosFiltrados);
          }

          private void CarregarCompromissos()
          {
               List<Compromisso> compromissos = repositorioCompromisso.SelecionarRegistros();

               tabelaCompromisso.AtualizarRegistros(compromissos);
          }

          public override UserControl ObterListas()
          {
               if (tabelaCompromisso == null)
               {
                    tabelaCompromisso = new TabelaCompromissoControl();
               }

               CarregarCompromissos();

               return tabelaCompromisso;
          }

          public override string ObterTipoCadastro()
          {
               return "Cadastro de Compromissos";
          }
     }
}
