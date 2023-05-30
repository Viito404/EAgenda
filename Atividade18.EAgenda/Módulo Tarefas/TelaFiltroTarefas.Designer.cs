namespace Atividade18.EAgenda.Módulo_Tarefas
{
     partial class TelaFiltroTarefas
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

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               btnFiltrar = new Button();
               btnCancelar = new Button();
               rbConcluidas = new RadioButton();
               rbPendentes = new RadioButton();
               rbTodas = new RadioButton();
               SuspendLayout();
               // 
               // btnFiltrar
               // 
               btnFiltrar.Anchor = AnchorStyles.None;
               btnFiltrar.BackColor = SystemColors.ButtonHighlight;
               btnFiltrar.DialogResult = DialogResult.OK;
               btnFiltrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               btnFiltrar.Location = new Point(241, 404);
               btnFiltrar.Name = "btnFiltrar";
               btnFiltrar.Size = new Size(75, 45);
               btnFiltrar.TabIndex = 20;
               btnFiltrar.Text = "Filtrar";
               btnFiltrar.UseVisualStyleBackColor = false;
               btnFiltrar.Click += btnFiltrar_Click;
               // 
               // btnCancelar
               // 
               btnCancelar.Anchor = AnchorStyles.None;
               btnCancelar.BackColor = SystemColors.ButtonHighlight;
               btnCancelar.DialogResult = DialogResult.Cancel;
               btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               btnCancelar.Location = new Point(322, 404);
               btnCancelar.Name = "btnCancelar";
               btnCancelar.Size = new Size(75, 45);
               btnCancelar.TabIndex = 19;
               btnCancelar.Text = "Cancelar";
               btnCancelar.UseVisualStyleBackColor = false;
               // 
               // rbConcluidas
               // 
               rbConcluidas.AutoSize = true;
               rbConcluidas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               rbConcluidas.Location = new Point(105, 200);
               rbConcluidas.Name = "rbConcluidas";
               rbConcluidas.Size = new Size(181, 19);
               rbConcluidas.TabIndex = 35;
               rbConcluidas.TabStop = true;
               rbConcluidas.Text = "Visualizar Tarefas Concluídas";
               rbConcluidas.UseVisualStyleBackColor = true;
               // 
               // rbPendentes
               // 
               rbPendentes.AutoSize = true;
               rbPendentes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               rbPendentes.Location = new Point(105, 175);
               rbPendentes.Name = "rbPendentes";
               rbPendentes.Size = new Size(182, 19);
               rbPendentes.TabIndex = 33;
               rbPendentes.TabStop = true;
               rbPendentes.Text = "Visualizar Tarefas Pendentes";
               rbPendentes.UseVisualStyleBackColor = true;
               // 
               // rbTodas
               // 
               rbTodas.AutoSize = true;
               rbTodas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               rbTodas.Location = new Point(105, 150);
               rbTodas.Name = "rbTodas";
               rbTodas.Size = new Size(168, 19);
               rbTodas.TabIndex = 34;
               rbTodas.TabStop = true;
               rbTodas.Text = "Visualizar Todas as Tarefas";
               rbTodas.UseVisualStyleBackColor = true;
               // 
               // TelaFiltroTarefas
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(409, 461);
               Controls.Add(rbConcluidas);
               Controls.Add(rbPendentes);
               Controls.Add(rbTodas);
               Controls.Add(btnFiltrar);
               Controls.Add(btnCancelar);
               Name = "TelaFiltroTarefas";
               Text = "Filtrando Itens Tarefa";
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private Button btnFiltrar;
          private Button btnCancelar;
          private RadioButton rbConcluidas;
          private RadioButton rbPendentes;
          private RadioButton rbTodas;
     }
}