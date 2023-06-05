namespace Atividade18.EAgenda.Módulo_Despesas.Despesas
{
     partial class TabelaDespesaControl
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
               tabelaDespesas = new DataGridView();
               ((System.ComponentModel.ISupportInitialize)tabelaDespesas).BeginInit();
               SuspendLayout();
               // 
               // tabelaDespesas
               // 
               tabelaDespesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               tabelaDespesas.Dock = DockStyle.Fill;
               tabelaDespesas.Location = new Point(0, 0);
               tabelaDespesas.Name = "tabelaDespesas";
               tabelaDespesas.RowTemplate.Height = 25;
               tabelaDespesas.Size = new Size(461, 301);
               tabelaDespesas.TabIndex = 0;
               // 
               // TabelaDespesaControl
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               Controls.Add(tabelaDespesas);
               Name = "TabelaDespesaControl";
               Size = new Size(461, 301);
               ((System.ComponentModel.ISupportInitialize)tabelaDespesas).EndInit();
               ResumeLayout(false);
          }

          #endregion

          private DataGridView tabelaDespesas;
     }
}
