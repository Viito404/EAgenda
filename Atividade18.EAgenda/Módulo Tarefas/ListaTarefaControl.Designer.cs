namespace Atividade18.EAgenda.Módulo_Tarefas
{
     partial class ListaTarefaControl
     {
          /// <summary> 
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary> 
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Component Designer generated code

          /// <summary> 
          /// Required method for Designer support - do not modify 
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               lbTarefas = new ListBox();
               SuspendLayout();
               // 
               // lbTarefas
               // 
               lbTarefas.Dock = DockStyle.Fill;
               lbTarefas.FormattingEnabled = true;
               lbTarefas.ItemHeight = 15;
               lbTarefas.Location = new Point(0, 0);
               lbTarefas.Name = "lbTarefas";
               lbTarefas.Size = new Size(713, 477);
               lbTarefas.TabIndex = 1;
               // 
               // ListaTarefaControl
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               Controls.Add(lbTarefas);
               Name = "ListaTarefaControl";
               Size = new Size(713, 477);
               ResumeLayout(false);
          }

          #endregion

          private ListBox lbTarefas;
     }
}
