using Atividade18.EAgenda.Compartilhado;
using Atividade18.EAgenda.Módulo_Contatos;
using Atividade18.EAgenda.Módulo_Compromissos;
using Atividade18.EAgenda.Módulo_Tarefas;

namespace Atividade18.EAgenda
{
     public partial class TelaPrincipalForm : Form
     {
          private ControladorBase controlador;
          private RepositorioContatos repositorioContatos = new RepositorioContatos(new List<Contato>());
          private RepositorioCompromissos repositorioCompromissos = new RepositorioCompromissos(new List<Compromisso>());
          private RepositorioTarefas repositorioTarefas = new RepositorioTarefas(new List<Tarefa>());
          private int contador = 5;

          private static TelaPrincipalForm telaPrincipal;
          public TelaPrincipalForm()
          {
               InitializeComponent();
               PopularEntidades();
               temporizador.Interval = 1000;
               temporizador.Tick += Timer_tick;
               telaPrincipal = this;
          }


          private void PopularEntidades()
          {
               Contato contato1 = new Contato("Pedro Cabral", "(49)3292-3226", "pedro121@gmail.com", "Gestor empresarial", "Shumtaza");
               Contato contato2 = new Contato("Ricardo Alves", "(45)3342-8641", "ricardoalvestxi13@gmail.com", "Professor", "EEP Lima");
               Contato contato3 = new Contato("Marcelo Pereira", "(42)3221-2142", "marceelo212@gmail.com", "Maquinista", "PSul Transportadoras");
               Contato contato4 = new Contato("Diogo Branco", "(47)3312-4236", "digod3391@gmail.com", "Cientista de dados", "Edimas");
               Contato contato5 = new Contato("Paulo dos Santos", "(48)3743-3126", "pauloosantoss@gmail.com", "Programador", "Alluera");

               repositorioContatos.Inserir(contato1);
               repositorioContatos.Inserir(contato2);
               repositorioContatos.Inserir(contato3);
               repositorioContatos.Inserir(contato4);
               repositorioContatos.Inserir(contato5);

               Compromisso compromisso1 = new Compromisso("Reunião com Paulo", new DateTime(2023, 5, 20), new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0), contato5, "www.cadwd.com.br", LocalCompromissoEnum.Online, 1);
               Compromisso compromisso2 = new Compromisso("Futebol", new DateTime(2023, 7, 20), new TimeSpan(10, 0, 0), new TimeSpan(7, 0, 0), null, "Praça da sé", LocalCompromissoEnum.Online, 2);
               Compromisso compromisso3 = new Compromisso("Reunião com Ricardo", new DateTime(2023, 6, 20), new TimeSpan(10, 0, 0), new TimeSpan(7, 0, 0), contato2, "www.cadwd.com.br", LocalCompromissoEnum.Online, 3);
               Compromisso compromisso4 = new Compromisso("Reunião com Marcelo", new DateTime(2023, 9, 20), new TimeSpan(10, 0, 0), new TimeSpan(7, 0, 0), contato3, "www.cadwd.com.br", LocalCompromissoEnum.Online, 4);
               Compromisso compromisso5 = new Compromisso("Reunião com Pedro", new DateTime(2023, 10, 20), new TimeSpan(10, 0, 0), new TimeSpan(7, 0, 0), contato1, "www.cadwd.com.br", LocalCompromissoEnum.Online, 5);

               repositorioCompromissos.Inserir(compromisso1);
               repositorioCompromissos.Inserir(compromisso2);
               repositorioCompromissos.Inserir(compromisso3);
               repositorioCompromissos.Inserir(compromisso4);
               repositorioCompromissos.Inserir(compromisso5);

               Tarefa tarefa1 = new Tarefa(1, "Limpar casa", PrioridadesTarefasEnum.Normal, new DateTime(2023,5,29));
               Tarefa tarefa2 = new Tarefa(2, "Dar Banho PET", PrioridadesTarefasEnum.Alta, new DateTime(2023, 5, 30));
               Tarefa tarefa3 = new Tarefa(3, "Trabalho Escolar", PrioridadesTarefasEnum.Normal, new DateTime(2023, 5, 31));
               Tarefa tarefa4 = new Tarefa(4, "Levar juninho no parquinho", PrioridadesTarefasEnum.Baixa, new DateTime(2023, 5, 25));
               Tarefa tarefa5 = new Tarefa(5, "Aulas particulares", PrioridadesTarefasEnum.Alta, new DateTime(2023, 5, 24));

               tarefa1.AdicionarItens(new ItemTarefa("A"));
               tarefa1.AdicionarItens(new ItemTarefa("B"));
               tarefa1.AdicionarItens(new ItemTarefa("C"));

               tarefa2.AdicionarItens(new ItemTarefa("D"));
               tarefa2.AdicionarItens(new ItemTarefa("E"));
               tarefa2.AdicionarItens(new ItemTarefa("F"));

               tarefa3.AdicionarItens(new ItemTarefa("G"));
               tarefa3.AdicionarItens(new ItemTarefa("H"));
               tarefa3.AdicionarItens(new ItemTarefa("I"));

               tarefa4.AdicionarItens(new ItemTarefa("J"));
               tarefa4.AdicionarItens(new ItemTarefa("K"));
               tarefa4.AdicionarItens(new ItemTarefa("L"));

               tarefa5.AdicionarItens(new ItemTarefa("M"));
               tarefa5.AdicionarItens(new ItemTarefa("N"));
               tarefa5.AdicionarItens(new ItemTarefa("O"));

               repositorioTarefas.Inserir(tarefa1);
               repositorioTarefas.Inserir(tarefa2);
               repositorioTarefas.Inserir(tarefa3);
               repositorioTarefas.Inserir(tarefa4);
               repositorioTarefas.Inserir(tarefa5);   
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
     }
}