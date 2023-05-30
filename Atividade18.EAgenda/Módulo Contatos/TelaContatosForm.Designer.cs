namespace Atividade18.EAgenda.Módulo_Contatos
{
     partial class TelaContatosForm
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
               label1 = new Label();
               tboxId = new TextBox();
               tboxNome = new TextBox();
               label2 = new Label();
               label3 = new Label();
               mtboxTelefone = new MaskedTextBox();
               label4 = new Label();
               gbObrigatorios = new GroupBox();
               tboxEmail = new TextBox();
               tboxEmpresa = new TextBox();
               label5 = new Label();
               tboxCargo = new TextBox();
               label6 = new Label();
               btnCancelar = new Button();
               btnCadastrar = new Button();
               gbObrigatorios.SuspendLayout();
               SuspendLayout();
               // 
               // label1
               // 
               label1.Anchor = AnchorStyles.None;
               label1.AutoSize = true;
               label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label1.Location = new Point(178, 101);
               label1.Name = "label1";
               label1.Size = new Size(21, 15);
               label1.TabIndex = 0;
               label1.Text = "Nº";
               // 
               // tboxId
               // 
               tboxId.Anchor = AnchorStyles.None;
               tboxId.BackColor = SystemColors.ActiveBorder;
               tboxId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               tboxId.Location = new Point(202, 98);
               tboxId.Name = "tboxId";
               tboxId.ReadOnly = true;
               tboxId.Size = new Size(55, 23);
               tboxId.TabIndex = 1;
               tboxId.Text = "0";
               // 
               // tboxNome
               // 
               tboxNome.Anchor = AnchorStyles.None;
               tboxNome.Location = new Point(202, 145);
               tboxNome.Name = "tboxNome";
               tboxNome.Size = new Size(357, 23);
               tboxNome.TabIndex = 3;
               // 
               // label2
               // 
               label2.Anchor = AnchorStyles.None;
               label2.AutoSize = true;
               label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label2.Location = new Point(159, 148);
               label2.Name = "label2";
               label2.Size = new Size(41, 15);
               label2.TabIndex = 2;
               label2.Text = "Nome";
               // 
               // label3
               // 
               label3.Anchor = AnchorStyles.None;
               label3.AutoSize = true;
               label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label3.Location = new Point(6, 38);
               label3.Name = "label3";
               label3.Size = new Size(56, 15);
               label3.TabIndex = 4;
               label3.Text = "Telefone";
               // 
               // mtboxTelefone
               // 
               mtboxTelefone.Anchor = AnchorStyles.None;
               mtboxTelefone.Location = new Point(65, 35);
               mtboxTelefone.Mask = "(00) 0000-0000";
               mtboxTelefone.Name = "mtboxTelefone";
               mtboxTelefone.RejectInputOnFirstFailure = true;
               mtboxTelefone.Size = new Size(126, 23);
               mtboxTelefone.TabIndex = 5;
               // 
               // label4
               // 
               label4.Anchor = AnchorStyles.None;
               label4.AutoSize = true;
               label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label4.Location = new Point(222, 38);
               label4.Name = "label4";
               label4.Size = new Size(41, 15);
               label4.TabIndex = 6;
               label4.Text = "E-mail";
               // 
               // gbObrigatorios
               // 
               gbObrigatorios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
               gbObrigatorios.Controls.Add(mtboxTelefone);
               gbObrigatorios.Controls.Add(tboxEmail);
               gbObrigatorios.Controls.Add(label3);
               gbObrigatorios.Controls.Add(label4);
               gbObrigatorios.Location = new Point(137, 184);
               gbObrigatorios.Name = "gbObrigatorios";
               gbObrigatorios.Size = new Size(440, 83);
               gbObrigatorios.TabIndex = 8;
               gbObrigatorios.TabStop = false;
               // 
               // tboxEmail
               // 
               tboxEmail.Anchor = AnchorStyles.None;
               tboxEmail.Location = new Point(269, 35);
               tboxEmail.Name = "tboxEmail";
               tboxEmail.Size = new Size(153, 23);
               tboxEmail.TabIndex = 7;
               // 
               // tboxEmpresa
               // 
               tboxEmpresa.Anchor = AnchorStyles.None;
               tboxEmpresa.Location = new Point(202, 290);
               tboxEmpresa.Name = "tboxEmpresa";
               tboxEmpresa.Size = new Size(126, 23);
               tboxEmpresa.TabIndex = 10;
               // 
               // label5
               // 
               label5.Anchor = AnchorStyles.None;
               label5.AutoSize = true;
               label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label5.Location = new Point(145, 293);
               label5.Name = "label5";
               label5.Size = new Size(54, 15);
               label5.TabIndex = 9;
               label5.Text = "Empresa";
               // 
               // tboxCargo
               // 
               tboxCargo.Anchor = AnchorStyles.None;
               tboxCargo.Location = new Point(406, 290);
               tboxCargo.Name = "tboxCargo";
               tboxCargo.Size = new Size(153, 23);
               tboxCargo.TabIndex = 12;
               // 
               // label6
               // 
               label6.Anchor = AnchorStyles.None;
               label6.AutoSize = true;
               label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label6.Location = new Point(361, 293);
               label6.Name = "label6";
               label6.Size = new Size(39, 15);
               label6.TabIndex = 11;
               label6.Text = "Cargo";
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
               btnCancelar.TabIndex = 13;
               btnCancelar.Text = "Cancelar";
               btnCancelar.UseVisualStyleBackColor = false;
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
               btnCadastrar.TabIndex = 14;
               btnCadastrar.Text = "Cadastrar";
               btnCadastrar.UseVisualStyleBackColor = false;
               btnCadastrar.Click += btnCadastrar_Click;
               // 
               // TelaContatosForm
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(709, 461);
               Controls.Add(btnCadastrar);
               Controls.Add(btnCancelar);
               Controls.Add(tboxCargo);
               Controls.Add(label6);
               Controls.Add(tboxEmpresa);
               Controls.Add(label5);
               Controls.Add(gbObrigatorios);
               Controls.Add(tboxNome);
               Controls.Add(label2);
               Controls.Add(tboxId);
               Controls.Add(label1);
               Name = "TelaContatosForm";
               Text = "Cadastrando Contato";
               gbObrigatorios.ResumeLayout(false);
               gbObrigatorios.PerformLayout();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private Label label1;
          private TextBox tboxId;
          private TextBox tboxNome;
          private Label label2;
          private Label label3;
          private MaskedTextBox mtboxTelefone;
          private Label label4;
          private GroupBox gbObrigatorios;
          private TextBox textBox1;
          private Label label5;
          private TextBox tboxCargo;
          private Label label6;
          private TextBox tboxEmail;
          private Button btnCancelar;
          private Button btnCadastrar;
          private TextBox tboxEmpresa;
     }
}