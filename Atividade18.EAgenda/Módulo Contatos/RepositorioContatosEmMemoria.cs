namespace Atividade18.EAgenda.Módulo_Contatos
{
     public class RepositorioContatosEmMemoria : RepositorioEmMemoriaBase<Contato>
     {
          public RepositorioContatosEmMemoria(List<Contato> listaContatos)
          {
               this.dados = listaContatos;
          }
     }
}
