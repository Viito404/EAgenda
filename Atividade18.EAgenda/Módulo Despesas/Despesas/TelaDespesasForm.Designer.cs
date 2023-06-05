namespace Atividade18.EAgenda.Módulo_Despesas.Despesas
{
     partial class TelaDespesasForm
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
               dtpData = new DateTimePicker();
               label3 = new Label();
               tboxDescricao = new TextBox();
               label2 = new Label();
               tboxId = new TextBox();
               label1 = new Label();
               btnCadastrar = new Button();
               btnCancelar = new Button();
               tBoxValor = new TextBox();
               label4 = new Label();
               label6 = new Label();
               combPgmt = new ComboBox();
               SuspendLayout();
               // 
               // dtpData
               // 
               dtpData.CustomFormat = "dd/MM/yyyy";
               dtpData.Format = DateTimePickerFormat.Custom;
               dtpData.Location = new Point(201, 222);
               dtpData.Name = "dtpData";
               dtpData.Size = new Size(357, 23);
               dtpData.TabIndex = 26;
               // 
               // label3
               // 
               label3.Anchor = AnchorStyles.None;
               label3.AutoSize = true;
               label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label3.Location = new Point(165, 228);
               label3.Name = "label3";
               label3.Size = new Size(33, 15);
               label3.TabIndex = 25;
               label3.Text = "Data";
               // 
               // tboxDescricao
               // 
               tboxDescricao.Anchor = AnchorStyles.None;
               tboxDescricao.Location = new Point(201, 183);
               tboxDescricao.Name = "tboxDescricao";
               tboxDescricao.Size = new Size(357, 23);
               tboxDescricao.TabIndex = 24;
               // 
               // label2
               // 
               label2.Anchor = AnchorStyles.None;
               label2.AutoSize = true;
               label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label2.Location = new Point(137, 186);
               label2.Name = "label2";
               label2.Size = new Size(61, 15);
               label2.TabIndex = 23;
               label2.Text = "Descrição";
               // 
               // tboxId
               // 
               tboxId.Anchor = AnchorStyles.None;
               tboxId.BackColor = SystemColors.ActiveBorder;
               tboxId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               tboxId.Location = new Point(201, 145);
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
               label1.Location = new Point(177, 148);
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
               btnCadastrar.TabIndex = 28;
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
               btnCancelar.TabIndex = 27;
               btnCancelar.Text = "Cancelar";
               btnCancelar.UseVisualStyleBackColor = false;
               // 
               // tBoxValor
               // 
               tBoxValor.Anchor = AnchorStyles.None;
               tBoxValor.Location = new Point(413, 263);
               tBoxValor.Name = "tBoxValor";
               tBoxValor.Size = new Size(145, 23);
               tBoxValor.TabIndex = 30;
               // 
               // label4
               // 
               label4.Anchor = AnchorStyles.None;
               label4.AutoSize = true;
               label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label4.Location = new Point(372, 266);
               label4.Name = "label4";
               label4.Size = new Size(35, 15);
               label4.TabIndex = 29;
               label4.Text = "Valor";
               // 
               // label6
               // 
               label6.Anchor = AnchorStyles.None;
               label6.AutoSize = true;
               label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label6.Location = new Point(101, 266);
               label6.Name = "label6";
               label6.Size = new Size(97, 15);
               label6.TabIndex = 31;
               label6.Text = "Tipo Pagamento";
               // 
               // combPgmt
               // 
               combPgmt.DropDownStyle = ComboBoxStyle.DropDownList;
               combPgmt.FormattingEnabled = true;
               combPgmt.Location = new Point(201, 263);
               combPgmt.Name = "combPgmt";
               combPgmt.Size = new Size(145, 23);
               combPgmt.TabIndex = 32;
               // 
               // TelaDespesasForm
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(709, 461);
               Controls.Add(combPgmt);
               Controls.Add(label6);
               Controls.Add(tBoxValor);
               Controls.Add(label4);
               Controls.Add(btnCadastrar);
               Controls.Add(btnCancelar);
               Controls.Add(dtpData);
               Controls.Add(label3);
               Controls.Add(tboxDescricao);
               Controls.Add(label2);
               Controls.Add(tboxId);
               Controls.Add(label1);
               Name = "TelaDespesasForm";
               Text = "Cadastrando Despesa";
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private DateTimePicker dtpData;
          private Label label3;
          private TextBox tboxDescricao;
          private Label label2;
          private TextBox tboxId;
          private Label label1;
          private Button btnCadastrar;
          private Button btnCancelar;
          private TextBox tBoxValor;
          private Label label4;
          private Label label6;
          private ComboBox combPgmt;
     }
}