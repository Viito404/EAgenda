using Atividade18.EAgenda.Módulo_Contatos;

namespace Atividade18.EAgenda.Módulo_Compromissos
{
     public class Compromisso : EntidadeBase<Compromisso>
     {
          public string assunto;
          public DateTime data;
          public TimeSpan horarioInicio;
          public TimeSpan horarioFinal;
          public Contato contato;
          public string localPresencial;
          public string localOnline;
          public LocalCompromissoEnum localCompromisso;

          public Compromisso(string assunto,
               DateTime data,
               TimeSpan horarioInicio,
               TimeSpan horarioFinal,
               Contato contato,
               string tipoLocal,
               LocalCompromissoEnum localCompromisso,
               int id)
          {
               this.assunto = assunto;
               this.data = data;
               this.horarioInicio = horarioInicio;
               this.horarioFinal = horarioFinal;
               this.contato = contato;
               this.localCompromisso = localCompromisso;
               this.id = id;
               if (localCompromisso == LocalCompromissoEnum.Presencial)
                    this.localPresencial = tipoLocal;

               else
                    this.localOnline = tipoLocal;            
          }

          public override void AtualizarRegistros(Compromisso compromissoAtualizado)
          {
               this.assunto = compromissoAtualizado.assunto;
               this.data = compromissoAtualizado.data;
               this.horarioInicio = compromissoAtualizado.horarioInicio;
               this.horarioFinal = compromissoAtualizado.horarioFinal;
               this.contato = compromissoAtualizado.contato;
               this.localCompromisso = compromissoAtualizado.localCompromisso;

               if (compromissoAtualizado.localCompromisso == LocalCompromissoEnum.Presencial)
                    this.localPresencial =  compromissoAtualizado.localPresencial;

               else
                    this.localOnline = compromissoAtualizado.localOnline;
          }

          public override string[] ValidarErros()
          {
               List<string> erros = new List<string>();

               if (string.IsNullOrEmpty(assunto))
                    erros.Add("O campo \"Assunto\" está vazio!");

               if (localCompromisso == LocalCompromissoEnum.Nenhum)
                    erros.Add("Entre com o tipo do local do compromisso!");

               if (localCompromisso == LocalCompromissoEnum.Presencial && string.IsNullOrEmpty(localPresencial))
                    erros.Add("Entre com o local presencial do compromisso!");

               if (localCompromisso == LocalCompromissoEnum.Online && string.IsNullOrEmpty(localOnline))
                    erros.Add("Entre com o local online do compromisso!");

               return erros.ToArray();
          }

          public override string ToString()
          {
               return $"Id: {id} | Assunto: {assunto} | Data: {data}";
          }

          public override bool Equals(object? obj)
          {
               return obj is Compromisso compromisso &&
                      id == compromisso.id &&
                      assunto == compromisso.assunto &&
                      data == compromisso.data &&
                      horarioInicio.Equals(compromisso.horarioInicio) &&
                      horarioFinal.Equals(compromisso.horarioFinal) &&
                      EqualityComparer<Contato>.Default.Equals(contato, compromisso.contato) &&
                      localPresencial == compromisso.localPresencial &&
                      localOnline == compromisso.localOnline &&
                      localCompromisso == compromisso.localCompromisso;
          }
     }
}
