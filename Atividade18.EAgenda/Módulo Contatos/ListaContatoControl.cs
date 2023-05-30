namespace Atividade18.EAgenda.Módulo_Contatos
{
     public partial class ListaContatoControl : UserControl
     {
          public ListaContatoControl()
          {
               InitializeComponent();
          }
          public void AtualizarRegistros(List<Contato> contatos)
          {
              lbContatos.Items.Clear();

               foreach (Contato contato in contatos)
               {
                   lbContatos.Items.Add(contato);
               }              
          }
          public Contato ObterContatoSelecionado()
          {
               return (Contato)lbContatos.SelectedItem;
          }
     }
}
