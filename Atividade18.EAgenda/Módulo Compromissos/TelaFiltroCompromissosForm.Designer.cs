namespace Atividade18.EAgenda.Módulo_Compromissos
{
     partial class TelaFiltroCompromissosForm
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
               rbPassados = new RadioButton();
               rbTodos = new RadioButton();
               rbFuturos = new RadioButton();
               label1 = new Label();
               label2 = new Label();
               dtpFimPeriodo = new DateTimePicker();
               dtpInicioPeriodo = new DateTimePicker();
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
               btnFiltrar.TabIndex = 18;
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
               btnCancelar.TabIndex = 17;
               btnCancelar.Text = "Cancelar";
               btnCancelar.UseVisualStyleBackColor = false;
               // 
               // rbPassados
               // 
               rbPassados.AutoSize = true;
               rbPassados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               rbPassados.Location = new Point(106, 131);
               rbPassados.Name = "rbPassados";
               rbPassados.Size = new Size(211, 19);
               rbPassados.TabIndex = 30;
               rbPassados.TabStop = true;
               rbPassados.Text = "Visualizar Compromissos Passados";
               rbPassados.UseVisualStyleBackColor = true;
               // 
               // rbTodos
               // 
               rbTodos.AutoSize = true;
               rbTodos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               rbTodos.Location = new Point(106, 106);
               rbTodos.Name = "rbTodos";
               rbTodos.Size = new Size(210, 19);
               rbTodos.TabIndex = 31;
               rbTodos.TabStop = true;
               rbTodos.Text = "Visualizar Todos os Compromissos";
               rbTodos.UseVisualStyleBackColor = true;
               // 
               // rbFuturos
               // 
               rbFuturos.AutoSize = true;
               rbFuturos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               rbFuturos.Location = new Point(106, 156);
               rbFuturos.Name = "rbFuturos";
               rbFuturos.Size = new Size(208, 19);
               rbFuturos.TabIndex = 32;
               rbFuturos.TabStop = true;
               rbFuturos.Text = "Visualizar Compromissos Futuros ";
               rbFuturos.UseVisualStyleBackColor = true;
               rbFuturos.CheckedChanged += rbFuturos_CheckedChanged;
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label1.Location = new Point(69, 235);
               label1.Name = "label1";
               label1.Size = new Size(83, 15);
               label1.TabIndex = 35;
               label1.Text = "Início Período";
               // 
               // label2
               // 
               label2.AutoSize = true;
               label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label2.Location = new Point(79, 264);
               label2.Name = "label2";
               label2.Size = new Size(73, 15);
               label2.TabIndex = 36;
               label2.Text = "Fim Período";
               // 
               // dtpFimPeriodo
               // 
               dtpFimPeriodo.Enabled = false;
               dtpFimPeriodo.Location = new Point(155, 258);
               dtpFimPeriodo.Name = "dtpFimPeriodo";
               dtpFimPeriodo.Size = new Size(200, 23);
               dtpFimPeriodo.TabIndex = 34;
               // 
               // dtpInicioPeriodo
               // 
               dtpInicioPeriodo.Enabled = false;
               dtpInicioPeriodo.Location = new Point(155, 229);
               dtpInicioPeriodo.Name = "dtpInicioPeriodo";
               dtpInicioPeriodo.Size = new Size(200, 23);
               dtpInicioPeriodo.TabIndex = 33;
               // 
               // TelaFiltroCompromissosForm
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(409, 461);
               Controls.Add(label2);
               Controls.Add(label1);
               Controls.Add(dtpFimPeriodo);
               Controls.Add(dtpInicioPeriodo);
               Controls.Add(rbFuturos);
               Controls.Add(rbPassados);
               Controls.Add(rbTodos);
               Controls.Add(btnFiltrar);
               Controls.Add(btnCancelar);
               Name = "TelaFiltroCompromissosForm";
               Text = "Filtrando Compromissos";
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private Button btnFiltrar;
          private Button btnCancelar;
          private RadioButton rbPassados;
          private RadioButton rbTodos;
          private RadioButton rbFuturos;
          private Label label1;
          private Label label2;
          private DateTimePicker dtpFimPeriodo;
          private DateTimePicker dtpInicioPeriodo;
     }
}