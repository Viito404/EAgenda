namespace Atividade18.EAgenda.Compartilhado
{
     public abstract class EntidadeBase<TEntidade>
     {
          public int id;

          public abstract string[] ValidarErros();

          public abstract void AtualizarRegistros(TEntidade entidade);
     }
}
