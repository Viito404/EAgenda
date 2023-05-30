namespace Atividade18.EAgenda.Módulo_Tarefas
{
     partial class TelaAtualizacaoItens
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
               btnCadastrar = new Button();
               btnCancelar = new Button();
               tboxTitulo = new TextBox();
               label2 = new Label();
               tboxId = new TextBox();
               label1 = new Label();
               clbItensTarefa = new CheckedListBox();
               SuspendLayout();
               // 
               // btnCadastrar
               // 
               btnCadastrar.Anchor = AnchorStyles.None;
               btnCadastrar.BackColor = SystemColors.ButtonHighlight;
               btnCadastrar.DialogResult = DialogResult.OK;
               btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               btnCadastrar.Location = new Point(541, 404);
               btnCadastrar.Name = "btnCadastrar";
               btnCadastrar.Size = new Size(75, 45);
               btnCadastrar.TabIndex = 36;
               btnCadastrar.Text = "Cadastrar";
               btnCadastrar.UseVisualStyleBackColor = false;
               // 
               // btnCancelar
               // 
               btnCancelar.Anchor = AnchorStyles.None;
               btnCancelar.BackColor = SystemColors.ButtonHighlight;
               btnCancelar.DialogResult = DialogResult.Cancel;
               btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               btnCancelar.Location = new Point(622, 404);
               btnCancelar.Name = "btnCancelar";
               btnCancelar.Size = new Size(75, 45);
               btnCancelar.TabIndex = 35;
               btnCancelar.Text = "Cancelar";
               btnCancelar.UseVisualStyleBackColor = false;
               // 
               // tboxTitulo
               // 
               tboxTitulo.Anchor = AnchorStyles.None;
               tboxTitulo.BackColor = SystemColors.ActiveBorder;
               tboxTitulo.Location = new Point(156, 113);
               tboxTitulo.Name = "tboxTitulo";
               tboxTitulo.ReadOnly = true;
               tboxTitulo.Size = new Size(403, 23);
               tboxTitulo.TabIndex = 34;
               // 
               // label2
               // 
               label2.Anchor = AnchorStyles.None;
               label2.AutoSize = true;
               label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label2.Location = new Point(108, 116);
               label2.Name = "label2";
               label2.Size = new Size(42, 15);
               label2.TabIndex = 33;
               label2.Text = "Título ";
               // 
               // tboxId
               // 
               tboxId.Anchor = AnchorStyles.None;
               tboxId.BackColor = SystemColors.ActiveBorder;
               tboxId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               tboxId.Location = new Point(156, 72);
               tboxId.Name = "tboxId";
               tboxId.ReadOnly = true;
               tboxId.Size = new Size(55, 23);
               tboxId.TabIndex = 32;
               tboxId.Text = "0";
               // 
               // label1
               // 
               label1.Anchor = AnchorStyles.None;
               label1.AutoSize = true;
               label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label1.Location = new Point(129, 75);
               label1.Name = "label1";
               label1.Size = new Size(21, 15);
               label1.TabIndex = 31;
               label1.Text = "Nº";
               // 
               // clbItensTarefa
               // 
               clbItensTarefa.CheckOnClick = true;
               clbItensTarefa.FormattingEnabled = true;
               clbItensTarefa.Location = new Point(156, 187);
               clbItensTarefa.Name = "clbItensTarefa";
               clbItensTarefa.Size = new Size(403, 184);
               clbItensTarefa.TabIndex = 41;
               // 
               // TelaAtualizacaoItens
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(709, 461);
               Controls.Add(clbItensTarefa);
               Controls.Add(btnCadastrar);
               Controls.Add(btnCancelar);
               Controls.Add(tboxTitulo);
               Controls.Add(label2);
               Controls.Add(tboxId);
               Controls.Add(label1);
               Name = "TelaAtualizacaoItens";
               Text = "TelaAtualizacaoItens";
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion
          private Button btnCadastrar;
          private Button btnCancelar;
          private TextBox tboxTitulo;
          private Label label2;
          private TextBox tboxId;
          private Label label1;
          private CheckedListBox clbItensTarefa;
     }
}