using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade18.EAgenda.Módulo_Despesas
{
     public class RepositorioCategoriasEmMemoria : RepositorioEmMemoriaBase<Categoria>
     {
          public RepositorioCategoriasEmMemoria(List<Categoria> dados) : base(dados)
          {
          }
     }
}
