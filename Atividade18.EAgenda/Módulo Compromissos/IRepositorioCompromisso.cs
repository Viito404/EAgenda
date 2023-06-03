using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade18.EAgenda.Módulo_Compromissos
{
     public interface IRepositorioCompromisso
     {
          void Editar(int id, Compromisso compromisso);
          void Inserir(Compromisso compromisso);
          void Remover(Compromisso compromissoSelecionado);
          List<Compromisso>? SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal);
          List<Compromisso>? SelecionarCompromissosPassados(DateTime now);
          Compromisso SelecionarPorId(int id);
          List<Compromisso>? SelecionarRegistros();
     }
}
