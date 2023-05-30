namespace Atividade18.EAgenda.Módulo_Contatos
{
     partial class TabelaContatoControl
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
               tabelaContatos = new DataGridView();
               ((System.ComponentModel.ISupportInitialize)tabelaContatos).BeginInit();
               SuspendLayout();
               // 
               // tabelaContatos
               // 
               tabelaContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               tabelaContatos.Dock = DockStyle.Fill;
               tabelaContatos.Location = new Point(0, 0);
               tabelaContatos.Name = "tabelaContatos";
               tabelaContatos.RowTemplate.Height = 25;
               tabelaContatos.Size = new Size(582, 503);
               tabelaContatos.TabIndex = 0;              
               // 
               // TabelaContatosControl
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               Controls.Add(tabelaContatos);
               Name = "TabelaContatosControl";
               Size = new Size(582, 503);
               ((System.ComponentModel.ISupportInitialize)tabelaContatos).EndInit();
               ResumeLayout(false);
          }

          #endregion

          private DataGridView tabelaContatos;
     }
}
