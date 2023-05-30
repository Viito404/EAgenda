namespace Atividade18.EAgenda.Módulo_Contatos
{
     public class RepositorioContatos : RepositorioBase<Contato>
     {
          public RepositorioContatos(List<Contato> listaContatos)
          {
               this.dados = listaContatos;
          }
     }
}
