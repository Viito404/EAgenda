using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade18.EAgenda.Módulo_Despesas.Categorias
{
     public interface IRepositorioCategoria
     {
          void Editar(int id, Categoria categoriaAtualizada);
          void Inserir(Categoria novaCategoria);
          void Remover(Categoria categoria);
          Categoria SelecionarPorId(int id);
          List<Categoria> SelecionarRegistros();
     }
}
