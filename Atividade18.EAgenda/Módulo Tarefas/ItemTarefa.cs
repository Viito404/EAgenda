namespace Atividade18.EAgenda.Módulo_Tarefas
{
     public class ItemTarefa 
     {
          public string titulo;
          public bool concluido;

          public ItemTarefa(string titulo)
          {
               this.titulo = titulo;
          }

          public override string ToString()
          {
               return titulo;
          }

          public void Concluir()
          {
               concluido = true;
          }
          public override bool Equals(object? obj)
          {
               return obj is ItemTarefa tarefa &&
                      titulo == tarefa.titulo &&
                      concluido == tarefa.concluido;
          }

          public void Desmarcar()
          {
               concluido = false;
          }

          public string[] ValidarErros()
          {
               List<string> erros = new List<string>();

               if (string.IsNullOrEmpty(titulo))
               {
                    erros.Add("Entre com a atividade da tarefa!");
               }

               return erros.ToArray();
          }
     }
}
