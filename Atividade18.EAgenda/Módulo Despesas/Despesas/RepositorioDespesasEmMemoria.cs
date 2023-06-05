using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade18.EAgenda.Módulo_Despesas.Despesas
{
     public class RepositorioDespesasEmMemoria : RepositorioEmMemoriaBase<Despesa>, IRepositorioDespesa
     {
          public RepositorioDespesasEmMemoria(List<Despesa> dados) : base(dados)
          {
          }
     }
}
