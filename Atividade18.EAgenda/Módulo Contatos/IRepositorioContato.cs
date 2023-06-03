using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade18.EAgenda.Módulo_Contatos
{
     public interface IRepositorioContato
     {
          void Editar(int id, Contato contato);
          void Inserir(Contato contato);
          void Remover(Contato contato);
          Contato SelecionarPorId(int id);
          List<Contato> SelecionarRegistros();
     }
}
