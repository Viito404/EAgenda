namespace Atividade18.EAgenda.Módulo_Contatos
{
     partial class ListaContatoControl
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
               lbContatos = new ListBox();
               SuspendLayout();
               // 
               // lbContatos
               // 
               lbContatos.Dock = DockStyle.Fill;
               lbContatos.FormattingEnabled = true;
               lbContatos.ItemHeight = 15;
               lbContatos.Location = new Point(0, 0);
               lbContatos.Name = "lbContatos";
               lbContatos.Size = new Size(713, 477);
               lbContatos.TabIndex = 0;
               // 
               // ListaContatoControl
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               Controls.Add(lbContatos);
               Name = "ListaContatoControl";
               Size = new Size(713, 477);
               ResumeLayout(false);
          }

          #endregion

          private ListBox lbContatos;
     }
}
