using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade18.EAgenda.Módulo_Despesas.Despesas
{
     public interface IRepositorioDespesa
     {
          void Editar(int id, Despesa DespesaAtualizada);
          void Inserir(Despesa novaDespesa);
          void Remover(Despesa Despesa);
          Despesa SelecionarPorId(int id);
          List<Despesa> SelecionarRegistros();

     }
}
