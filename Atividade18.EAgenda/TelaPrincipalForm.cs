using Atividade18.EAgenda.Compartilhado;
using Atividade18.EAgenda.Módulo_Contatos;
using Atividade18.EAgenda.Módulo_Compromissos;
using Atividade18.EAgenda.Módulo_Tarefas;
using Atividade18.EAgenda.Módulo_Despesas;
using Atividade18.EAgenda.Módulo_Despesas.Categorias;
using Atividade18.EAgenda.Módulo_Despesas.Despesas;

namespace Atividade18.EAgenda
{
     public partial class TelaPrincipalForm : Form
     {
          private ControladorBase controlador;
          private static ContextoDados contexto = new ContextoDados(carregarDados:true);        
          private IRepositorioContato repositorioContatos = new RepositorioContatosEmArquivo(contexto);
          private IRepositorioCompromisso repositorioCompromissos = new RepositorioCompromissosEmArquivo(contexto);
          private IRepositorioTarefa repositorioTarefas = new RepositorioTarefasEmArquivo(contexto);
          private IRepositorioCategoria repositorioCategorias = new RepositorioCategoriasEmArquivo(contexto);
          private IRepositorioDespesa repositorioDespesas = new RepositorioDespesasEmArquivo(contexto);
          private int contador = 5;

          private static TelaPrincipalForm telaPrincipal;
          public TelaPrincipalForm()
          {
               InitializeComponent();
               temporizador.Interval = 1000;
               temporizador.Tick += Timer_tick;
               telaPrincipal = this;
          }

          public void AtualizarRodape(string mensagem, TipoStatusEnum tipoStatus)
          {
               contador = 5;
               Color cor = default;
               switch (tipoStatus)
               {
                    case TipoStatusEnum.Nenhum: break;
                    case TipoStatusEnum.Erro: cor = Color.Red; break;
                    case TipoStatusEnum.Sucesso: cor = Color.Green; break;
                    case TipoStatusEnum.Visualizando: cor = Color.DarkGray; break;
               }

               tssStatus.ForeColor = cor;
               tssStatus.Text = mensagem;

               if (tipoStatus != TipoStatusEnum.Visualizando)
                    temporizador.Start();
          }
          private void Timer_tick(object? sender, EventArgs e)
          {
               contador--;

               if (contador == 0)
               {
                    tssStatus.ForeColor = default;
                    tssStatus.Text = "Status";
                    temporizador.Stop();
               }
          }
          public static TelaPrincipalForm Instancia
          {
               get
               {
                    if (telaPrincipal == null)
                         telaPrincipal = new TelaPrincipalForm();

                    return telaPrincipal;
               }
          }
          private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
          {
               tslTipoCadastros.Text = controlador.ObterTipoCadastro();
               ConfigurarBarraFerramentas(controladorBase);
               ConfigurarToolTips(controladorBase);
               ConfigurarListas(controladorBase);
          }
          private void ConfigurarBarraFerramentas(ControladorBase controlador)
          {
               toolStrip1.Enabled = true;
               ConfigurarToolTips(controlador);
               ConfigurarEstados(controlador);
          }
          private void ConfigurarToolTips(ControladorBase controlador)
          {
               btnInserir.ToolTipText = controlador.ToolTipInserir;
               btnEditar.ToolTipText = controlador.ToolTipEditar;
               btnExcluir.ToolTipText = controlador.ToolTipExcluir;
               btnFiltrar.ToolTipText = controlador.ToolTipFiltrar;
               btnAddItens.ToolTipText = controlador.ToolTipAdicionarItens;
               btnChecar.ToolTipText = controlador.ToolTipAtualizarItens;
          }
          private void ConfigurarListas(ControladorBase controladorBase)
          {
               UserControl listas = controladorBase.ObterListas();
               listas.Dock = DockStyle.Fill;
               panelRegistros.Controls.Clear();
               panelRegistros.Controls.Add(listas);
          }
          private void contatosMenuItem_Click(object sender, EventArgs e)
          {
               controlador = new ControladorContato(repositorioContatos);
               ConfigurarTelaPrincipal(controlador);
          }
          private void compromissosMenuItem_Click(object sender, EventArgs e)
          {
               controlador = new ControladorCompromisso(repositorioContatos, repositorioCompromissos);
               ConfigurarTelaPrincipal(controlador);
          }
          private bool VerificarControlador()
          {
               if (controlador == null)
               {
                    AtualizarRodape("Selecione um tipo de cadastro antes!", TipoStatusEnum.Erro);
                    return false;
               }

               return true;
          }
          private void btnInserir_Click(object sender, EventArgs e)
          {
               if (VerificarControlador())
                    controlador.Inserir();
          }
          private void btnEditar_Click(object sender, EventArgs e)
          {
               if (VerificarControlador())
                    controlador.Editar();
          }
          private void btnExcluir_Click(object sender, EventArgs e)
          {
               if (VerificarControlador())
                    controlador.Excluir();
          }
          private void btnFiltrar_Click(object sender, EventArgs e)
          {
               if (VerificarControlador())
                    controlador.Filtrar();
          }
          private void tarefasMenuItem_Click(object sender, EventArgs e)
          {
               controlador = new ControladorTarefa(repositorioTarefas);
               ConfigurarTelaPrincipal(controlador);
          }
          private void btnAddItens_Click(object sender, EventArgs e)
          {
               if (VerificarControlador())
                    controlador.AdicionarItem();
          }
          private void btnChecar_Click(object sender, EventArgs e)
          {
               if (VerificarControlador())
                    controlador.ChecarItens();
          }
          private void ConfigurarEstados(ControladorBase controlador)
          {
               btnInserir.Enabled = controlador.InserirHabilitado;
               btnEditar.Enabled = controlador.EditarHabilitado;
               btnExcluir.Enabled = controlador.ExcluirHabilitado;
               btnFiltrar.Enabled = controlador.FiltrarHabilitado;
               btnAddItens.Enabled = controlador.AdicionarItensHabilitado;
               btnChecar.Enabled = controlador.ConcluirItensHabilitado;
          }
          private void categoriasMenuItem_Click(object sender, EventArgs e)
          {
               controlador = new ControladorCategoria(repositorioCategorias);
               ConfigurarTelaPrincipal(controlador);
          }

          private void despesasMenuItem_Click(object sender, EventArgs e)
          {
               controlador = new ControladorDespesa(repositorioDespesas);
               ConfigurarTelaPrincipal(controlador);
          }
     }
}