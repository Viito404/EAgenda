namespace Atividade18.EAgenda.Módulo_Tarefas
{
     public class ControladorTarefa : ControladorBase
     {
          private IRepositorioTarefa repositorioTarefas;
          private TabelaTarefaControl tabelaTarefa;
          public ControladorTarefa(IRepositorioTarefa repositorioTarefas)
          {
               this.repositorioTarefas = repositorioTarefas;
          }

          public override string ToolTipInserir => "Inserir Tarefa";

          public override string ToolTipEditar => "Editar Tarefa";

          public override string ToolTipExcluir => "Remover Tarefa";

          public override string ToolTipFiltrar => "Filtrar Tarefa";

          public override string ToolTipAdicionarItens => "Adicionar Itens";

          public override string ToolTipAtualizarItens => "Checar Itens";

          public override bool FiltrarHabilitado => true;

          public override bool AdicionarItensHabilitado => true;

          public override bool ConcluirItensHabilitado => true;

          public override void Editar()
          {
               Tarefa tarefaSelecionada = ObterTarefaSelecionada();

               if (tarefaSelecionada == null)
               {
                    MessageBox.Show($"Selecione uma tarefa primeiro!",
                        "Edição de Tarefas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return;
               }

               TelaTarefasForm telaTarefa = new TelaTarefasForm();
               telaTarefa.ConfigurarTela(tarefaSelecionada);
               DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    Tarefa tarefa = telaTarefa.ObterTarefa();
                    repositorioTarefas.Editar(tarefa.id, tarefa);
                    CarregarTarefas();
                    TelaPrincipalForm.Instancia.AtualizarRodape("Tarefa editada com sucesso!", TipoStatusEnum.Sucesso);
               }
          }

          public override void Filtrar()
          {
               TelaFiltroTarefas telaFiltro = new TelaFiltroTarefas();
               DialogResult opcaoEscolhida = telaFiltro.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    StatusTarefasEnum filtroTarefas = telaFiltro.ObterFiltroTarefa();
                    List<Tarefa> tarefas = null;


                    if (filtroTarefas == StatusTarefasEnum.Todas)
                         tarefas = repositorioTarefas.SelecionarRegistros();

                    else if (filtroTarefas == StatusTarefasEnum.Pendentes)
                    {
                         tarefas = repositorioTarefas.SelecionarTarefasPendentes();
                    }
                    else if (filtroTarefas == StatusTarefasEnum.Concluidas)
                    {
                         tarefas = repositorioTarefas.SelecionarTarefasConcluidas();
                    }
                    else
                    {
                         TelaPrincipalForm.Instancia.AtualizarRodape("Selecione algum filtro!", TipoStatusEnum.Erro);
                    }

                    CarregarTarefasFiltradas(tarefas);
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {tarefas.Count} tarefa(s)", TipoStatusEnum.Visualizando);
               }

          }

          private void CarregarTarefasFiltradas(List<Tarefa> listaTarefas)
          {
               tabelaTarefa.AtualizarRegistros(listaTarefas);
          }

          public override void Excluir()
          {
               Tarefa tarefaSelecionada = ObterTarefaSelecionada();

               if (tarefaSelecionada == null)
               {
                    MessageBox.Show($"Selecione um tarefa primeiro!",
                       "Exclusão de Compromissos",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);

                    return;
               }

               DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a tarefa {tarefaSelecionada.titulo}?",
        "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

               if (opcaoEscolhida == DialogResult.OK)
               {
                    repositorioTarefas.Remover(tarefaSelecionada);

                    CarregarTarefas();
                    TelaPrincipalForm.Instancia.AtualizarRodape("Tarefa deletada com sucesso!", TipoStatusEnum.Sucesso);
               }
          }

          public override void Inserir()
          {
               TelaTarefasForm telaTarefa = new TelaTarefasForm();
               DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    Tarefa novaTarefa = telaTarefa.ObterTarefa();
                    repositorioTarefas.Inserir(novaTarefa);
                    CarregarTarefas();
                    TelaPrincipalForm.Instancia.AtualizarRodape("Tarefa inserida com sucesso!", TipoStatusEnum.Sucesso);
               }
          }

          private void CarregarTarefas()
          {
               List<Tarefa> listaTarefas = repositorioTarefas.SelecionarRegistros();
               tabelaTarefa.AtualizarRegistros(listaTarefas);
          }

          public override UserControl ObterListas()
          {
               tabelaTarefa = new TabelaTarefaControl();

               CarregarTarefas();

               return tabelaTarefa;
          }

          public override void AdicionarItem()
          {
               Tarefa tarefaSelecionada = ObterTarefaSelecionada();

               if (tarefaSelecionada == null)
               {
                    MessageBox.Show($"Selecione uma tarefa primeiro!",
                        "Adição de Item em Tarefas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return;
               }

               TelaItensTarefaForm telaItemTarefa = new TelaItensTarefaForm(tarefaSelecionada);
               DialogResult opcaoEscolhida = telaItemTarefa.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {

                    List<ItemTarefa> itemTarefa = telaItemTarefa.ObterItensTarefa();

                    foreach (ItemTarefa item in itemTarefa)
                    {
                         tarefaSelecionada.AdicionarItens(item);
                    }
                    repositorioTarefas.Editar(tarefaSelecionada.id, tarefaSelecionada);
                    CarregarTarefas();
                    TelaPrincipalForm.Instancia.AtualizarRodape("Itens adicionados com sucesso!", TipoStatusEnum.Sucesso);
               }
          }

          private Tarefa ObterTarefaSelecionada()
          {
               int id = tabelaTarefa.ObterIdTarefaSelecionada();
               return repositorioTarefas.SelecionarPorId(id);
          }

          public override void ChecarItens()
          {
               Tarefa tarefaSelecionada = ObterTarefaSelecionada();

               if (tarefaSelecionada == null)
               {
                    MessageBox.Show($"Selecione uma tarefa primeiro!",
                        "Adição de Item em Tarefas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return;
               }

               TelaAtualizacaoItens telaChecagemItens = new TelaAtualizacaoItens(tarefaSelecionada);
               DialogResult opcaoEscolhida = telaChecagemItens.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    List<ItemTarefa> itensMarcados = telaChecagemItens.ObterItensMarcados();
                    List<ItemTarefa> itensDesmarcados = telaChecagemItens.ObterItensDesmarcados();

                    foreach (ItemTarefa item in itensMarcados)
                    {
                         tarefaSelecionada.ConcluirItens(item);
                    }
                    foreach (ItemTarefa item in itensDesmarcados)
                    {
                         tarefaSelecionada.DesconcluirItens(item);
                    }
                    tarefaSelecionada.VerificarConclusaoItens();
                    repositorioTarefas.Editar(tarefaSelecionada.id, tarefaSelecionada);

                    CarregarTarefas();

                    TelaPrincipalForm.Instancia.AtualizarRodape("Itens atualizados com sucesso!", TipoStatusEnum.Sucesso);
               }
          }
          public override string ObterTipoCadastro()
          {
               return "Cadastro de Tarefas";
          }
     }
}
