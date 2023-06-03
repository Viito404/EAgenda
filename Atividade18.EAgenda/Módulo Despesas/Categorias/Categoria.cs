using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade18.EAgenda.Módulo_Despesas
{
     public class Categoria : EntidadeBase<Categoria>
     {
          public string titulo;
          public List<Despesa> despesas;

        public Categoria()
        {
            
        }
        public Categoria(string titulo)
          {
               this.titulo = titulo;
               despesas = new List<Despesa>();
          }
          public Categoria(int id, string titulo)
          {
               this.id = id;
               this.titulo = titulo;
               despesas = new List<Despesa>();
          }

          public override void AtualizarRegistros(Categoria categoriaAtualizada)
          {
               titulo = categoriaAtualizada.titulo;
          }

          public override string[] ValidarErros()
          {
               List<string> erros = new List<string>();

               if (string.IsNullOrWhiteSpace(titulo))
                    erros.Add("O campo \"Título\" é obrigatório!");

               return erros.ToArray();
          }
     }
}
