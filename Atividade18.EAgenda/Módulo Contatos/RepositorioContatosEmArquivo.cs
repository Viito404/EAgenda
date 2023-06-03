using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade18.EAgenda.Módulo_Contatos
{
     public class RepositorioContatosEmArquivo : RepositorioEmArquivoBase<Contato>, IRepositorioContato
     {
          public RepositorioContatosEmArquivo(ContextoDados contexto) : base(contexto)
          {
          }

          protected override List<Contato> ObterRegistros()
          {
               return contextoDados.contatos;
          }
     }
}
