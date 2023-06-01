namespace Atividade18.EAgenda.Módulo_Tarefas
{
     [Serializable]
     public class Tarefa : EntidadeBase<Tarefa>
     {
          public string titulo;
          public DateTime dataCriacao;
          public DateTime? dataConclusao;
          public PrioridadesTarefasEnum prioridade;
          public decimal PercentualConcluido;
          public List<ItemTarefa> itens;

          public Tarefa(int id, string titulo, PrioridadesTarefasEnum prioridade, DateTime dataCriacao)
          {
               this.id = id;
               this.titulo = titulo;
               this.prioridade = prioridade;
               this.dataCriacao = dataCriacao;
               itens = new List<ItemTarefa>();
          }

          public override void AtualizarRegistros(Tarefa tarefaAtualizada)
          {
               this.id = tarefaAtualizada.id;
               this.titulo = tarefaAtualizada.titulo;
               this.prioridade = tarefaAtualizada.prioridade;
               this.dataCriacao = tarefaAtualizada.dataCriacao;
               this.dataConclusao = tarefaAtualizada.dataConclusao;
          }

          public override string[] ValidarErros()
          {
               List<string> erros = new List<string>();

               if(prioridade == PrioridadesTarefasEnum.Nenhum)
               {
                    erros.Add("Entre com a prioridade da tarefa!");
               }

               return erros.ToArray();
          }

          public override string ToString()
          {
               return $"Id: {id} | Título: {titulo} | Data: {dataCriacao} | Prioridade: {prioridade} | Percentual Concluído: {PercentualConcluido}% | Data Conclusão: {dataConclusao}";
          }

          public void AdicionarItens(ItemTarefa item)
          {
               itens.Add(item);
          }

          public void ConcluirItens(ItemTarefa item)
          {
               ItemTarefa itemSelecionado = itens.FirstOrDefault(x => x.Equals(item));
               itemSelecionado.Concluir();

               CalcularPercentualConcluido();
          }

          private void CalcularPercentualConcluido()
          {
               decimal qtdConcluidos = itens.Count(x => x.concluido == true);
               decimal qtdItens = itens.Count();
               PercentualConcluido = Math.Round(((qtdConcluidos / qtdItens) * 100), 2);
          }

          public void DesconcluirItens(ItemTarefa item)
          {
               ItemTarefa itemSelecionado = itens.FirstOrDefault(x => x.Equals(item));

               itemSelecionado.Desmarcar();

               CalcularPercentualConcluido();
          }

          public void VerificarConclusaoItens()
          {
               if (PercentualConcluido == 100)
                    dataConclusao = DateTime.Now;
               else
               {
                    dataConclusao = null;
               }
          }
     }
}
