namespace Atividade18.EAgenda.Módulo_Tarefas
{
     partial class TabelaTarefaControl
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
               tabelaTarefa = new DataGridView();
               ((System.ComponentModel.ISupportInitialize)tabelaTarefa).BeginInit();
               SuspendLayout();
               // 
               // tabelaTarefa
               // 
               tabelaTarefa.AllowUserToAddRows = false;
               tabelaTarefa.AllowUserToDeleteRows = false;
               tabelaTarefa.AllowUserToResizeColumns = false;
               tabelaTarefa.AllowUserToResizeRows = false;
               tabelaTarefa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
               tabelaTarefa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               tabelaTarefa.Dock = DockStyle.Fill;
               tabelaTarefa.Location = new Point(0, 0);
               tabelaTarefa.MultiSelect = false;
               tabelaTarefa.Name = "tabelaTarefa";
               tabelaTarefa.ReadOnly = true;
               tabelaTarefa.RowTemplate.Height = 25;
               tabelaTarefa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
               tabelaTarefa.Size = new Size(610, 493);
               tabelaTarefa.TabIndex = 0;
               // 
               // TabelaTarefaControl
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               Controls.Add(tabelaTarefa);
               Name = "TabelaTarefaControl";
               Size = new Size(610, 493);
               ((System.ComponentModel.ISupportInitialize)tabelaTarefa).EndInit();
               ResumeLayout(false);
          }

          #endregion

          private DataGridView tabelaTarefa;
     }
}
