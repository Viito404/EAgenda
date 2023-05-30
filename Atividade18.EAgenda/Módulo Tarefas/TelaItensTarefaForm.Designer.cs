namespace Atividade18.EAgenda.Módulo_Tarefas
{
     partial class TelaItensTarefaForm
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
               tboxTitulo = new TextBox();
               label2 = new Label();
               tboxId = new TextBox();
               label1 = new Label();
               btnCadastrar = new Button();
               btnCancelar = new Button();
               lbItensTarefa = new ListBox();
               label3 = new Label();
               tboxDescricao = new TextBox();
               btnAdicionar = new Button();
               SuspendLayout();
               // 
               // tboxTitulo
               // 
               tboxTitulo.Anchor = AnchorStyles.None;
               tboxTitulo.BackColor = SystemColors.ActiveBorder;
               tboxTitulo.Location = new Point(155, 113);
               tboxTitulo.Name = "tboxTitulo";
               tboxTitulo.ReadOnly = true;
               tboxTitulo.Size = new Size(403, 23);
               tboxTitulo.TabIndex = 24;
               // 
               // label2
               // 
               label2.Anchor = AnchorStyles.None;
               label2.AutoSize = true;
               label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label2.Location = new Point(107, 116);
               label2.Name = "label2";
               label2.Size = new Size(42, 15);
               label2.TabIndex = 23;
               label2.Text = "Título ";
               // 
               // tboxId
               // 
               tboxId.Anchor = AnchorStyles.None;
               tboxId.BackColor = SystemColors.ActiveBorder;
               tboxId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               tboxId.Location = new Point(155, 72);
               tboxId.Name = "tboxId";
               tboxId.ReadOnly = true;
               tboxId.Size = new Size(55, 23);
               tboxId.TabIndex = 22;
               tboxId.Text = "0";
               // 
               // label1
               // 
               label1.Anchor = AnchorStyles.None;
               label1.AutoSize = true;
               label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label1.Location = new Point(128, 75);
               label1.Name = "label1";
               label1.Size = new Size(21, 15);
               label1.TabIndex = 21;
               label1.Text = "Nº";
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
               btnCadastrar.TabIndex = 26;
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
               btnCancelar.TabIndex = 25;
               btnCancelar.Text = "Cancelar";
               btnCancelar.UseVisualStyleBackColor = false;
               // 
               // lbItensTarefa
               // 
               lbItensTarefa.FormattingEnabled = true;
               lbItensTarefa.ItemHeight = 15;
               lbItensTarefa.Location = new Point(155, 185);
               lbItensTarefa.Name = "lbItensTarefa";
               lbItensTarefa.Size = new Size(403, 184);
               lbItensTarefa.TabIndex = 27;
               // 
               // label3
               // 
               label3.Anchor = AnchorStyles.None;
               label3.AutoSize = true;
               label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label3.Location = new Point(88, 151);
               label3.Name = "label3";
               label3.Size = new Size(61, 15);
               label3.TabIndex = 28;
               label3.Text = "Descrição";
               // 
               // tboxDescricao
               // 
               tboxDescricao.Anchor = AnchorStyles.None;
               tboxDescricao.BackColor = SystemColors.ButtonHighlight;
               tboxDescricao.Location = new Point(155, 147);
               tboxDescricao.Name = "tboxDescricao";
               tboxDescricao.Size = new Size(403, 23);
               tboxDescricao.TabIndex = 29;
               // 
               // btnAdicionar
               // 
               btnAdicionar.Anchor = AnchorStyles.None;
               btnAdicionar.BackColor = SystemColors.ButtonHighlight;
               btnAdicionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               btnAdicionar.Location = new Point(564, 147);
               btnAdicionar.Name = "btnAdicionar";
               btnAdicionar.Size = new Size(39, 23);
               btnAdicionar.TabIndex = 30;
               btnAdicionar.Text = "Add";
               btnAdicionar.UseVisualStyleBackColor = false;
               btnAdicionar.Click += btnAdicionar_Click;
               // 
               // TelaItensTarefaForm
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(709, 461);
               Controls.Add(btnAdicionar);
               Controls.Add(tboxDescricao);
               Controls.Add(label3);
               Controls.Add(lbItensTarefa);
               Controls.Add(btnCadastrar);
               Controls.Add(btnCancelar);
               Controls.Add(tboxTitulo);
               Controls.Add(label2);
               Controls.Add(tboxId);
               Controls.Add(label1);
               Name = "TelaItensTarefaForm";
               Text = "Cadastrando Itens Tarefa";
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private TextBox tboxTitulo;
          private Label label2;
          private TextBox tboxId;
          private Label label1;
          private Button btnCadastrar;
          private Button btnCancelar;
          private ListBox lbItensTarefa;
          private Label label3;
          private TextBox tboxDescricao;
          private Button btnAdicionar;
     }
}