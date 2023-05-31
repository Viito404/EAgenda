namespace Atividade18.EAgenda.Módulo_Contatos
{
     public class Contato : EntidadeBase<Contato>
     {
          public string nome { get; set; }
          public string telefone;
          public string email;
          public string cargo;
          public string empresa;

          public Contato(string nome, string telefone, string email, string cargo, string empresa)
          {
               this.nome = nome;
               this.telefone = telefone;
               this.email = email;
               this.cargo = cargo;
               this.empresa = empresa;
          }
          public override void AtualizarRegistros(Contato contatoAtualizado)
          {
               this.nome = contatoAtualizado.nome;
               this.telefone = contatoAtualizado.telefone;
               this.email = contatoAtualizado.email;
               this.cargo = contatoAtualizado.cargo;
               this.empresa = contatoAtualizado.empresa;
          }

          public override string[] ValidarErros()
          {
              List<string> listaErros = new List<string>();

               if (telefone == "(  )     -")
                    listaErros.Add("Campo \"Telefone\" está vazio!");

               if (string.IsNullOrEmpty(email))
                    listaErros.Add("Campo \"E-mail\" está vazio!");

               return listaErros.ToArray();
          }
     }
}
