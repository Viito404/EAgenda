using Atividade18.EAgenda.Módulo_Compromissos;
using Atividade18.EAgenda.Módulo_Contatos;
using Atividade18.EAgenda.Módulo_Tarefas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade18.EAgenda.Módulo_Despesas.Despesas
{
     public partial class TelaDespesasForm : Form
     {
          string erro = " ";
          public TelaDespesasForm()
          {
               InitializeComponent();
               this.ConfigurarDialog();
               CarregarFormasPgmt();
          }

          private void CarregarFormasPgmt()
          {
               FormaPagamentoEnum[] formaPgmt = Enum.GetValues<FormaPagamentoEnum>();
               List<FormaPagamentoEnum> formaPgmtLista = new List<FormaPagamentoEnum>(formaPgmt);

               formaPgmtLista.Remove(FormaPagamentoEnum.Nenhum);

               foreach (FormaPagamentoEnum pagamento in formaPgmtLista)
               {
                    combPgmt.Items.Add(pagamento);
               }
          }

          public Despesa ObterDespesa()
          {
               Despesa despesa = null;
               int id = Convert.ToInt32(tboxId.Text);
               string descricao = tboxDescricao.Text;
               decimal valor = 0;
               try
               {
                    valor = Convert.ToDecimal(tBoxValor.Text);
               }
               catch
               {
                    erro = "Insira um valor númerico no campo \"Valor\"";
               }

               DateTime data = dtpData.Value;
               FormaPagamentoEnum tipoPgmt;
               if (combPgmt.SelectedIndex != -1)
                    tipoPgmt = (FormaPagamentoEnum)combPgmt.SelectedItem;

               else
                    tipoPgmt = FormaPagamentoEnum.Nenhum;

               return despesa = new Despesa(id, descricao, valor, data, tipoPgmt);
          }

          public void ConfigurarTela(Despesa despesaAtualizada)
          {
               tboxId.Text = despesaAtualizada.id.ToString();
               tboxDescricao.Text = despesaAtualizada.descricao;
               dtpData.Value = despesaAtualizada.data;
               combPgmt.SelectedItem = despesaAtualizada.pagamento;
          }

          private void btnCadastrar_Click(object sender, EventArgs e)
          {
               Despesa despesa = ObterDespesa();
               string[] erros = despesa.ValidarErros();

               if (erro != " ")
               {
                    TelaPrincipalForm.Instancia.AtualizarRodape(erro, TipoStatusEnum.Erro);
                    DialogResult = DialogResult.None;
               }


               else if (erros.Count() > 0)
               {
                    TelaPrincipalForm.Instancia.AtualizarRodape(erros[0], TipoStatusEnum.Erro);
                    DialogResult = DialogResult.None;
               }
          }
     }
}
