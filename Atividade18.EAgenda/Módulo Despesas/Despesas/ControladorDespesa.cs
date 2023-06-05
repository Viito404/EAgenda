using Atividade18.EAgenda.Módulo_Despesas.Categorias;
using Atividade18.EAgenda.Módulo_Despesas.Despesas;
using Atividade18.EAgenda.Módulo_Despesas.Despesas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade18.EAgenda.Módulo_Despesas.Despesas
{
     public class ControladorDespesa : ControladorBase
     {
          private IRepositorioDespesa repositorioDespesas;
          private TabelaDespesaControl tabelaDespesas;

          public ControladorDespesa(IRepositorioDespesa repositorioDespesas)
          {
               this.repositorioDespesas = repositorioDespesas;
          }

          public override string ToolTipInserir => "Inserir Despesa";

          public override string ToolTipEditar => "Editar Despesa";

          public override string ToolTipExcluir => "Remover Despesa";

          public override void Editar()
          {
               Despesa despesa = ObterDespesaSelecionada();

               if (despesa == null)
               {
                    MessageBox.Show($"Selecione uma Despesa primeiro!",
                        "Edição de Despesa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
               }

               TelaDespesasForm telaDespesasForm = new TelaDespesasForm();

               telaDespesasForm.ConfigurarTela(despesa);
               DialogResult opcaoEscolhida = telaDespesasForm.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    Despesa DespesaAtualizada = telaDespesasForm.ObterDespesa();
                    repositorioDespesas.Editar(DespesaAtualizada.id, DespesaAtualizada);
                    CarregarDespesas();
                    TelaPrincipalForm.Instancia.AtualizarRodape("Despesa editada com sucesso!", TipoStatusEnum.Sucesso);
               }
          }

          private Despesa ObterDespesaSelecionada()
          {
               int id = tabelaDespesas.ObterIdDespesaSelecionada();
               return repositorioDespesas.SelecionarPorId(id);
          }

          public override void Excluir()
          {
               Despesa despesa = ObterDespesaSelecionada();

               if (despesa == null)
               {
                    MessageBox.Show($"Selecione uma despesa primeiro!",
                        "Exclusão de Despesa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
               }


               DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a despesa {despesa.descricao}?", "Exclusão de Despesas",
                                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

               if (opcaoEscolhida == DialogResult.OK)
               {
                    repositorioDespesas.Remover(despesa);

                    CarregarDespesas();
                    TelaPrincipalForm.Instancia.AtualizarRodape("Despesa deletada com sucesso!", TipoStatusEnum.Sucesso);
               }
          }

          public override void Inserir()
          {
               TelaDespesasForm telaDespesas = new TelaDespesasForm();
               DialogResult opcaoEscolhida = telaDespesas.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    Despesa novaDespesa = telaDespesas.ObterDespesa();
                    repositorioDespesas.Inserir(novaDespesa);
                    CarregarDespesas();
                    TelaPrincipalForm.Instancia.AtualizarRodape("Despesa inserida com sucesso!", TipoStatusEnum.Sucesso);
               }
          }

          public override UserControl ObterListas()
          {
               tabelaDespesas = new TabelaDespesaControl();

               CarregarDespesas();

               return tabelaDespesas;
          }

          private void CarregarDespesas()
          {
               List<Despesa> listaDespesas = repositorioDespesas.SelecionarRegistros();
               tabelaDespesas.AtualizarDespesas(listaDespesas);
          }

          public override string ObterTipoCadastro()
          {
               return "Cadastro de Despesas";
          }
     }
}
