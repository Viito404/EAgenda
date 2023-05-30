namespace Atividade18.EAgenda.Módulo_Compromissos
{
     public partial class ListaCompromissoControl : UserControl
     {
          public ListaCompromissoControl()
          {
               InitializeComponent();
          }

          public void AtualizarRegistros(List<Compromisso> compromissos)
          {
               lbCompromissos.Items.Clear();

               foreach (Compromisso compromisso in compromissos)
               {
                    lbCompromissos.Items.Add(compromisso);
               }
          }

          public Compromisso ObterCompromissoSelecionado()
          {
               return (Compromisso)lbCompromissos.SelectedItem;
          }
     }
}
