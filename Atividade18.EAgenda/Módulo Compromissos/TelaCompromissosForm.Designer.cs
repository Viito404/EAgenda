namespace Atividade18.EAgenda.Módulo_Compromissos
{
     partial class TelaCompromissosForm
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
               tboxId = new TextBox();
               label1 = new Label();
               btnCadastrar = new Button();
               btnCancelar = new Button();
               tboxAssunto = new TextBox();
               label2 = new Label();
               label3 = new Label();
               dtpData = new DateTimePicker();
               dtpHorarioInicio = new DateTimePicker();
               label4 = new Label();
               dtpHorarioTermino = new DateTimePicker();
               label5 = new Label();
               cbMarcarContatos = new CheckBox();
               label6 = new Label();
               combContatos = new ComboBox();
               rbPresencial = new RadioButton();
               rbOnline = new RadioButton();
               gbLocalCompromisso = new GroupBox();
               tboxOnline = new TextBox();
               tboxPresencial = new TextBox();
               gbLocalCompromisso.SuspendLayout();
               SuspendLayout();
               // 
               // tboxId
               // 
               tboxId.Anchor = AnchorStyles.None;
               tboxId.BackColor = SystemColors.ActiveBorder;
               tboxId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               tboxId.Location = new Point(184, 61);
               tboxId.Name = "tboxId";
               tboxId.ReadOnly = true;
               tboxId.Size = new Size(55, 23);
               tboxId.TabIndex = 3;
               tboxId.Text = "0";
               // 
               // label1
               // 
               label1.Anchor = AnchorStyles.None;
               label1.AutoSize = true;
               label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label1.Location = new Point(160, 64);
               label1.Name = "label1";
               label1.Size = new Size(21, 15);
               label1.TabIndex = 2;
               label1.Text = "Nº";
               // 
               // btnCadastrar
               // 
               btnCadastrar.Anchor = AnchorStyles.None;
               btnCadastrar.BackColor = SystemColors.ButtonHighlight;
               btnCadastrar.DialogResult = DialogResult.OK;
               btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               btnCadastrar.Location = new Point(542, 404);
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
               btnCancelar.Location = new Point(623, 404);
               btnCancelar.Name = "btnCancelar";
               btnCancelar.Size = new Size(75, 45);
               btnCancelar.TabIndex = 15;
               btnCancelar.Text = "Cancelar";
               btnCancelar.UseVisualStyleBackColor = false;
               // 
               // tboxAssunto
               // 
               tboxAssunto.Anchor = AnchorStyles.None;
               tboxAssunto.Location = new Point(184, 99);
               tboxAssunto.Name = "tboxAssunto";
               tboxAssunto.Size = new Size(357, 23);
               tboxAssunto.TabIndex = 18;
               // 
               // label2
               // 
               label2.Anchor = AnchorStyles.None;
               label2.AutoSize = true;
               label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label2.Location = new Point(130, 102);
               label2.Name = "label2";
               label2.Size = new Size(51, 15);
               label2.TabIndex = 17;
               label2.Text = "Assunto";
               // 
               // label3
               // 
               label3.Anchor = AnchorStyles.None;
               label3.AutoSize = true;
               label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label3.Location = new Point(148, 144);
               label3.Name = "label3";
               label3.Size = new Size(33, 15);
               label3.TabIndex = 19;
               label3.Text = "Data";
               // 
               // dtpData
               // 
               dtpData.CustomFormat = "dd/MM/yyyy";
               dtpData.Format = DateTimePickerFormat.Custom;
               dtpData.Location = new Point(184, 138);
               dtpData.Name = "dtpData";
               dtpData.Size = new Size(357, 23);
               dtpData.TabIndex = 20;
               // 
               // dtpHorarioInicio
               // 
               dtpHorarioInicio.CustomFormat = "HH:mm";
               dtpHorarioInicio.Format = DateTimePickerFormat.Custom;
               dtpHorarioInicio.Location = new Point(184, 175);
               dtpHorarioInicio.Name = "dtpHorarioInicio";
               dtpHorarioInicio.RightToLeft = RightToLeft.No;
               dtpHorarioInicio.ShowUpDown = true;
               dtpHorarioInicio.Size = new Size(89, 23);
               dtpHorarioInicio.TabIndex = 22;
               // 
               // label4
               // 
               label4.Anchor = AnchorStyles.None;
               label4.AutoSize = true;
               label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label4.Location = new Point(144, 181);
               label4.Name = "label4";
               label4.Size = new Size(37, 15);
               label4.TabIndex = 21;
               label4.Text = "Início";
               // 
               // dtpHorarioTermino
               // 
               dtpHorarioTermino.CustomFormat = "HH:mm";
               dtpHorarioTermino.Format = DateTimePickerFormat.Custom;
               dtpHorarioTermino.Location = new Point(452, 177);
               dtpHorarioTermino.Name = "dtpHorarioTermino";
               dtpHorarioTermino.ShowUpDown = true;
               dtpHorarioTermino.Size = new Size(89, 23);
               dtpHorarioTermino.TabIndex = 24;
               // 
               // label5
               // 
               label5.Anchor = AnchorStyles.None;
               label5.AutoSize = true;
               label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label5.Location = new Point(393, 183);
               label5.Name = "label5";
               label5.Size = new Size(53, 15);
               label5.TabIndex = 23;
               label5.Text = "Término";
               // 
               // cbMarcarContatos
               // 
               cbMarcarContatos.AutoSize = true;
               cbMarcarContatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               cbMarcarContatos.Location = new Point(184, 215);
               cbMarcarContatos.Name = "cbMarcarContatos";
               cbMarcarContatos.Size = new Size(194, 19);
               cbMarcarContatos.TabIndex = 25;
               cbMarcarContatos.Text = "Deseja selecionar um contato?";
               cbMarcarContatos.UseVisualStyleBackColor = true;
               cbMarcarContatos.CheckedChanged += cbMarcarContatos_CheckedChanged;
               // 
               // label6
               // 
               label6.Anchor = AnchorStyles.None;
               label6.AutoSize = true;
               label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label6.Location = new Point(130, 244);
               label6.Name = "label6";
               label6.Size = new Size(51, 15);
               label6.TabIndex = 26;
               label6.Text = "Contato";
               // 
               // combContatos
               // 
               combContatos.DisplayMember = "nome";
               combContatos.DropDownStyle = ComboBoxStyle.DropDownList;
               combContatos.Enabled = false;
               combContatos.FormattingEnabled = true;
               combContatos.Location = new Point(184, 240);
               combContatos.Name = "combContatos";
               combContatos.Size = new Size(186, 23);
               combContatos.TabIndex = 27;
               // 
               // rbPresencial
               // 
               rbPresencial.AutoSize = true;
               rbPresencial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               rbPresencial.Location = new Point(6, 35);
               rbPresencial.Name = "rbPresencial";
               rbPresencial.Size = new Size(81, 19);
               rbPresencial.TabIndex = 28;
               rbPresencial.TabStop = true;
               rbPresencial.Text = "Presencial";
               rbPresencial.UseVisualStyleBackColor = true;
               rbPresencial.CheckedChanged += rbPresencial_CheckedChanged;
               // 
               // rbOnline
               // 
               rbOnline.AutoSize = true;
               rbOnline.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               rbOnline.Location = new Point(6, 60);
               rbOnline.Name = "rbOnline";
               rbOnline.Size = new Size(61, 19);
               rbOnline.TabIndex = 29;
               rbOnline.TabStop = true;
               rbOnline.Text = "Online";
               rbOnline.UseVisualStyleBackColor = true;
               rbOnline.CheckedChanged += rbOnline_CheckedChanged;
               // 
               // gbLocalCompromisso
               // 
               gbLocalCompromisso.Controls.Add(tboxOnline);
               gbLocalCompromisso.Controls.Add(tboxPresencial);
               gbLocalCompromisso.Controls.Add(rbPresencial);
               gbLocalCompromisso.Controls.Add(rbOnline);
               gbLocalCompromisso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               gbLocalCompromisso.Location = new Point(184, 281);
               gbLocalCompromisso.Name = "gbLocalCompromisso";
               gbLocalCompromisso.Size = new Size(357, 100);
               gbLocalCompromisso.TabIndex = 30;
               gbLocalCompromisso.TabStop = false;
               gbLocalCompromisso.Text = "Local Compromisso";
               // 
               // tboxOnline
               // 
               tboxOnline.Anchor = AnchorStyles.None;
               tboxOnline.Enabled = false;
               tboxOnline.Location = new Point(84, 57);
               tboxOnline.Name = "tboxOnline";
               tboxOnline.Size = new Size(267, 23);
               tboxOnline.TabIndex = 32;
               // 
               // tboxPresencial
               // 
               tboxPresencial.Anchor = AnchorStyles.None;
               tboxPresencial.Enabled = false;
               tboxPresencial.Location = new Point(84, 31);
               tboxPresencial.Name = "tboxPresencial";
               tboxPresencial.Size = new Size(267, 23);
               tboxPresencial.TabIndex = 31;
               // 
               // TelaCompromissosForm
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(709, 461);
               Controls.Add(gbLocalCompromisso);
               Controls.Add(combContatos);
               Controls.Add(label6);
               Controls.Add(cbMarcarContatos);
               Controls.Add(dtpHorarioTermino);
               Controls.Add(label5);
               Controls.Add(dtpHorarioInicio);
               Controls.Add(label4);
               Controls.Add(dtpData);
               Controls.Add(label3);
               Controls.Add(tboxAssunto);
               Controls.Add(label2);
               Controls.Add(btnCadastrar);
               Controls.Add(btnCancelar);
               Controls.Add(tboxId);
               Controls.Add(label1);
               Name = "TelaCompromissosForm";
               Text = "Cadastrando Compromisso";
               gbLocalCompromisso.ResumeLayout(false);
               gbLocalCompromisso.PerformLayout();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private TextBox tboxId;
          private Label label1;
          private Button btnCadastrar;
          private Button btnCancelar;
          private TextBox tboxAssunto;
          private Label label2;
          private Label label3;
          private DateTimePicker dtpData;
          private DateTimePicker dtpHorarioInicio;
          private Label label4;
          private DateTimePicker dtpHorarioTermino;
          private Label label5;
          private CheckBox cbMarcarContatos;
          private Label label6;
          private ComboBox combContatos;
          private RadioButton rbPresencial;
          private RadioButton rbOnline;
          private GroupBox gbLocalCompromisso;
          private TextBox tboxOnline;
          private TextBox tboxPresencial;
     }
}