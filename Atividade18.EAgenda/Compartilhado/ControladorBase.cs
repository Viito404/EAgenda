namespace Atividade18.EAgenda.Compartilhado
{
     public abstract class ControladorBase
     {
          #region Mudar o texto dos botões
          public abstract string ToolTipInserir { get; }

          public abstract string ToolTipEditar { get; }

          public abstract string ToolTipExcluir { get; }

          public virtual string ToolTipFiltrar { get; }

          public virtual string ToolTipAdicionarItens { get; }

          public virtual string ToolTipAtualizarItens { get; }
          #endregion

          #region Habilitar e desabilitar botões
          public virtual bool InserirHabilitado { get { return true; } }
          public virtual bool EditarHabilitado { get { return true; } }
          public virtual bool ExcluirHabilitado { get { return true; } }

          public virtual bool FiltrarHabilitado { get { return false; } }
          public virtual bool AdicionarItensHabilitado { get { return false; } }
          public virtual bool ConcluirItensHabilitado { get { return false; } }
          #endregion

          public abstract void Excluir();
          public abstract void Inserir();
          public abstract void Editar();

          public abstract UserControl ObterListas();

          public abstract string ObterTipoCadastro();

          public virtual void Filtrar()
          {
               
          }

          public virtual void AdicionarItem()
          {
               
          }

          public virtual void ChecarItens()
          {
               
          }
     }
}
