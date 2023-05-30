namespace Atividade18.EAgenda.Módulo_Tarefas
{
     partial class TelaTarefasForm
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
               tboxId = new TextBox();
               label1 = new Label();
               tboxTitulo = new TextBox();
               label2 = new Label();
               combPrioridades = new ComboBox();
               label6 = new Label();
               dtpData = new DateTimePicker();
               label3 = new Label();
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
               btnCadastrar.TabIndex = 16;
               btnCadastrar.Text = "Cadastrar";
               btnCadastrar.UseVisualStyleBackColor = false;
               btnCadastrar.Click += btnCadastrar_Click;
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
               btnCancelar.TabIndex = 15;
               btnCancelar.Text = "Cancelar";
               btnCancelar.UseVisualStyleBackColor = false;
               // 
               // tboxId
               // 
               tboxId.Anchor = AnchorStyles.None;
               tboxId.BackColor = SystemColors.ActiveBorder;
               tboxId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               tboxId.Location = new Point(218, 137);
               tboxId.Name = "tboxId";
               tboxId.ReadOnly = true;
               tboxId.Size = new Size(55, 23);
               tboxId.TabIndex = 18;
               tboxId.Text = "0";
               // 
               // label1
               // 
               label1.Anchor = AnchorStyles.None;
               label1.AutoSize = true;
               label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label1.Location = new Point(194, 140);
               label1.Name = "label1";
               label1.Size = new Size(21, 15);
               label1.TabIndex = 17;
               label1.Text = "Nº";
               // 
               // tboxTitulo
               // 
               tboxTitulo.Anchor = AnchorStyles.None;
               tboxTitulo.Location = new Point(218, 178);
               tboxTitulo.Name = "tboxTitulo";
               tboxTitulo.Size = new Size(357, 23);
               tboxTitulo.TabIndex = 20;
               // 
               // label2
               // 
               label2.Anchor = AnchorStyles.None;
               label2.AutoSize = true;
               label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label2.Location = new Point(173, 181);
               label2.Name = "label2";
               label2.Size = new Size(42, 15);
               label2.TabIndex = 19;
               label2.Text = "Título ";
               // 
               // combPrioridades
               // 
               combPrioridades.DisplayMember = "nome";
               combPrioridades.DropDownStyle = ComboBoxStyle.DropDownList;
               combPrioridades.FormattingEnabled = true;
               combPrioridades.Location = new Point(218, 216);
               combPrioridades.Name = "combPrioridades";
               combPrioridades.Size = new Size(186, 23);
               combPrioridades.TabIndex = 29;
               // 
               // label6
               // 
               label6.Anchor = AnchorStyles.None;
               label6.AutoSize = true;
               label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label6.Location = new Point(146, 219);
               label6.Name = "label6";
               label6.Size = new Size(69, 15);
               label6.TabIndex = 28;
               label6.Text = "Prioridades";
               // 
               // dtpData
               // 
               dtpData.CustomFormat = "dd/MM/yyyy";
               dtpData.Format = DateTimePickerFormat.Custom;
               dtpData.Location = new Point(218, 256);
               dtpData.Name = "dtpData";
               dtpData.Size = new Size(357, 23);
               dtpData.TabIndex = 31;
               // 
               // label3
               // 
               label3.Anchor = AnchorStyles.None;
               label3.AutoSize = true;
               label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label3.Location = new Point(139, 262);
               label3.Name = "label3";
               label3.Size = new Size(76, 15);
               label3.TabIndex = 30;
               label3.Text = "Data Criação";
               // 
               // TelaTarefasForm
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(709, 461);
               Controls.Add(dtpData);
               Controls.Add(label3);
               Controls.Add(combPrioridades);
               Controls.Add(label6);
               Controls.Add(tboxTitulo);
               Controls.Add(label2);
               Controls.Add(tboxId);
               Controls.Add(label1);
               Controls.Add(btnCadastrar);
               Controls.Add(btnCancelar);
               Name = "TelaTarefasForm";
               Text = "Cadastrando Tarefa";
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private Button btnCadastrar;
          private Button btnCancelar;
          private TextBox tboxId;
          private Label label1;
          private TextBox tboxTitulo;
          private Label label2;
          private ComboBox combPrioridades;
          private Label label6;
          private DateTimePicker dtpData;
          private Label label3;
     }
}