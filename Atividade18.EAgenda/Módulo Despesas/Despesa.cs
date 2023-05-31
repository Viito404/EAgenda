using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade18.EAgenda.Módulo_Despesas
{
     public class Despesa : EntidadeBase<Despesa>
     {
          public string descricao;
          public decimal valor;
          public DateTime data;
          public FormaPagamentoEnum pagamento;

          public List<Categoria> categorias;

          public Despesa(string descricao, decimal valor, DateTime data, FormaPagamentoEnum pagamento)
          {
               this.descricao = descricao;
               this.valor = valor;
               this.data = data;
               this.pagamento = pagamento;
               categorias = new List<Categoria>();
          }

          public override void AtualizarRegistros(Despesa despesaAtualizada)
          {
               descricao = despesaAtualizada.descricao;
               valor = despesaAtualizada.valor;
               data = despesaAtualizada.data;
               pagamento = despesaAtualizada.pagamento;
               categorias = despesaAtualizada.categorias;
          }

          public override string[] ValidarErros()
          {
               List<string> erros = new List<string>();

               if(string.IsNullOrWhiteSpace(descricao))
                    erros.Add("O campo \"Descrição\" é obrigatório!");

               if (valor <= 0)
                    erros.Add("Insira um valor maior que 0!");

               if (data == DateTime.MinValue)
                    erros.Add("O campo \"Data\" é obrigatório!");

               if (pagamento == FormaPagamentoEnum.Nenhum)
                    erros.Add("O campo \"Forma Pagamento\" é obrigatório!");

               return erros.ToArray();
          }
     }
}
