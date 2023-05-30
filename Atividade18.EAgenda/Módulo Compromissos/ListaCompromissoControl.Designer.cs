namespace Atividade18.EAgenda.Módulo_Compromissos
{
     partial class ListaCompromissoControl
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
               lbCompromissos = new ListBox();
               SuspendLayout();
               // 
               // lbCompromissos
               // 
               lbCompromissos.Dock = DockStyle.Fill;
               lbCompromissos.FormattingEnabled = true;
               lbCompromissos.ItemHeight = 15;
               lbCompromissos.Location = new Point(0, 0);
               lbCompromissos.Name = "lbCompromissos";
               lbCompromissos.Size = new Size(713, 477);
               lbCompromissos.TabIndex = 0;
               // 
               // ListaCompromissoControl
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               Controls.Add(lbCompromissos);
               Name = "ListaCompromissoControl";
               Size = new Size(713, 477);
               ResumeLayout(false);
          }

          #endregion

          private ListBox lbCompromissos;
     }
}
