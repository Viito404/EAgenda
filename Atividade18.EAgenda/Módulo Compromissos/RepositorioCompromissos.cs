namespace Atividade18.EAgenda.Módulo_Compromissos
{
     public class RepositorioCompromissos : RepositorioBase<Compromisso>
     {
        public RepositorioCompromissos(List<Compromisso> listaCompromissos)
        {
            this.dados = listaCompromissos;
        }
          public List<Compromisso> SelecionarCompromissosPassados(DateTime hoje)
          {
               return dados.Where(x => x.data.Date < hoje.Date).ToList();
          }

          public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
          {
               return dados
                   .Where(x => x.data > dataInicio)
                   .Where(x => x.data < dataFinal)
                   .ToList();
          }
     }
}
