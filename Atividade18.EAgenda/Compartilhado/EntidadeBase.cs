using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade18.EAgenda.Compartilhado
{
     public abstract class EntidadeBase<TEntidade>
     {
          public int id;

          public abstract string[] ValidarErros();

          public abstract void AtualizarRegistros(TEntidade entidade);
     }
}
