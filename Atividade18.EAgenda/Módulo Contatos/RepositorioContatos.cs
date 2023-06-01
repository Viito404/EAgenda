namespace Atividade18.EAgenda.Módulo_Contatos
{
     public class RepositorioContatos : RepositorioEmMemoriaBase<Contato>
     {
          public RepositorioContatos(List<Contato> listaContatos)
          {
               this.dados = listaContatos;
          }
     }
}
