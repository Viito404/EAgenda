using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade18.EAgenda.Módulo_Despesas.Categorias
{
     public class RepositorioCategoriasEmArquivo : RepositorioEmArquivoBase<Categoria>, IRepositorioCategoria
     {
          public RepositorioCategoriasEmArquivo(ContextoDados contexto) : base(contexto)
          {
          }

          protected override List<Categoria> ObterRegistros()
          {
               return contextoDados.categorias;
          }
     }
}
