using Atividade18.EAgenda.Módulo_Contatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade18.EAgenda.Módulo_Despesas
{
     public class ControladorCategoria : ControladorBase
     {
          private RepositorioCategorias repositorioCategorias;
          private TabelaCategoriaControl tabelaCategorias;
          public ControladorCategoria(RepositorioCategorias repositorioCategorias)
          {
               this.repositorioCategorias = repositorioCategorias;
          }

          public override string ToolTipInserir => "Inserir Categoria";

          public override string ToolTipEditar => "Editar Categoria";

          public override string ToolTipExcluir => "Remover Categoria";

          public override void Editar()
          {
               Categoria categoria = ObterCategoriaSelecionada();

               if (categoria == null)
               {
                    MessageBox.Show($"Selecione uma categoria primeiro!",
                        "Edição de Categoria",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
               }

               TelaCategoriasForm telaCategoriasForm = new TelaCategoriasForm();

               telaCategoriasForm.ConfigurarTela(categoria);
               DialogResult opcaoEscolhida = telaCategoriasForm.ShowDialog();

               if(opcaoEscolhida == DialogResult.OK)
               {
                    Categoria categoriaAtualizada = telaCategoriasForm.ObterCategoria();
                    repositorioCategorias.Editar(categoriaAtualizada.id, categoriaAtualizada);
                    CarregarCategorias();
                    TelaPrincipalForm.Instancia.AtualizarRodape("Categoria editada com sucesso!", TipoStatusEnum.Sucesso);
               }
          }

          private Categoria ObterCategoriaSelecionada()
          {
               int id = tabelaCategorias.ObterIdCategoriaSelecionada();
               return repositorioCategorias.SelecionarPorId(id);
          }

          public override void Excluir()
          {
               Categoria categoria = ObterCategoriaSelecionada();

               if (categoria == null)
               {
                    MessageBox.Show($"Selecione uma categoria primeiro!",
                        "Exclusão de Categoria",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
               }


               DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a categoria {categoria.titulo}?", "Exclusão de Categorias",
                                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

               if (opcaoEscolhida == DialogResult.OK)
               {
                    repositorioCategorias.Remover(categoria);

                    CarregarCategorias();
                    TelaPrincipalForm.Instancia.AtualizarRodape("Categoria deletada com sucesso!", TipoStatusEnum.Sucesso);
               }
          }

          public override void Inserir()
          {
               TelaCategoriasForm telaCategorias = new TelaCategoriasForm();
               DialogResult opcaoEscolhida = telaCategorias.ShowDialog();

               if(opcaoEscolhida == DialogResult.OK)
               {
                    Categoria novaCategoria = telaCategorias.ObterCategoria();
                    repositorioCategorias.Inserir(novaCategoria);
                    CarregarCategorias();
                    TelaPrincipalForm.Instancia.AtualizarRodape("Categoria inserida com sucesso!", TipoStatusEnum.Sucesso);
               }
          }

          private void CarregarCategorias()
          {
               List<Categoria> listaCategorias = repositorioCategorias.SelecionarRegistros();
               tabelaCategorias.AtualizarCategorias(listaCategorias);
          }

          public override UserControl ObterListas()
          {
               tabelaCategorias = new TabelaCategoriaControl();

               CarregarCategorias();

               return tabelaCategorias;
          }

          public override string ObterTipoCadastro()
          {
               return "Cadastro de Categorias";
          }
     }
}
