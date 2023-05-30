namespace Atividade18.EAgenda
{
     partial class TelaPrincipalForm
     {
          /// <summary>
          ///  Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          ///  Clean up any resources being used.
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
          ///  Required method for Designer support - do not modify
          ///  the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               components = new System.ComponentModel.Container();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
               ssRodape = new StatusStrip();
               tssStatus = new ToolStripStatusLabel();
               msCabecalho = new MenuStrip();
               cadastrosMenuItem = new ToolStripMenuItem();
               contatosMenuItem = new ToolStripMenuItem();
               compromissosMenuItem = new ToolStripMenuItem();
               tarefasMenuItem = new ToolStripMenuItem();
               toolStrip1 = new ToolStrip();
               btnInserir = new ToolStripButton();
               btnEditar = new ToolStripButton();
               btnExcluir = new ToolStripButton();
               toolStripSeparator2 = new ToolStripSeparator();
               btnFiltrar = new ToolStripButton();
               toolStripSeparator1 = new ToolStripSeparator();
               btnAddItens = new ToolStripButton();
               toolStripSeparator3 = new ToolStripSeparator();
               btnChecar = new ToolStripButton();
               toolStripSeparator4 = new ToolStripSeparator();
               tslTipoCadastros = new ToolStripLabel();
               panelRegistros = new Panel();
               temporizador = new System.Windows.Forms.Timer(components);
               ssRodape.SuspendLayout();
               msCabecalho.SuspendLayout();
               toolStrip1.SuspendLayout();
               SuspendLayout();
               // 
               // ssRodape
               // 
               ssRodape.Items.AddRange(new ToolStripItem[] { tssStatus });
               ssRodape.Location = new Point(0, 439);
               ssRodape.Name = "ssRodape";
               ssRodape.Size = new Size(709, 22);
               ssRodape.TabIndex = 0;
               ssRodape.Text = "statusStrip1";
               // 
               // tssStatus
               // 
               tssStatus.Name = "tssStatus";
               tssStatus.Size = new Size(39, 17);
               tssStatus.Text = "Status";
               // 
               // msCabecalho
               // 
               msCabecalho.Items.AddRange(new ToolStripItem[] { cadastrosMenuItem });
               msCabecalho.Location = new Point(0, 0);
               msCabecalho.Name = "msCabecalho";
               msCabecalho.Size = new Size(709, 24);
               msCabecalho.TabIndex = 1;
               msCabecalho.Text = "msCabecalho";
               // 
               // cadastrosMenuItem
               // 
               cadastrosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contatosMenuItem, compromissosMenuItem, tarefasMenuItem });
               cadastrosMenuItem.Name = "cadastrosMenuItem";
               cadastrosMenuItem.Size = new Size(71, 20);
               cadastrosMenuItem.Text = "Cadastros";
               // 
               // contatosMenuItem
               // 
               contatosMenuItem.Name = "contatosMenuItem";
               contatosMenuItem.Size = new Size(154, 22);
               contatosMenuItem.Text = "Contatos";
               contatosMenuItem.Click += contatosMenuItem_Click;
               // 
               // compromissosMenuItem
               // 
               compromissosMenuItem.Name = "compromissosMenuItem";
               compromissosMenuItem.Size = new Size(154, 22);
               compromissosMenuItem.Text = "Compromissos";
               compromissosMenuItem.Click += compromissosMenuItem_Click;
               // 
               // tarefasMenuItem
               // 
               tarefasMenuItem.Name = "tarefasMenuItem";
               tarefasMenuItem.Size = new Size(154, 22);
               tarefasMenuItem.Text = "Tarefas";
               tarefasMenuItem.Click += tarefasMenuItem_Click;
               // 
               // toolStrip1
               // 
               toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator2, btnFiltrar, toolStripSeparator1, btnAddItens, toolStripSeparator3, btnChecar, toolStripSeparator4, tslTipoCadastros });
               toolStrip1.Location = new Point(0, 24);
               toolStrip1.Name = "toolStrip1";
               toolStrip1.Size = new Size(709, 45);
               toolStrip1.TabIndex = 2;
               toolStrip1.Text = "toolStrip1";
               // 
               // btnInserir
               // 
               btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
               btnInserir.Enabled = false;
               btnInserir.Image = Properties.Resources.addIcon;
               btnInserir.ImageScaling = ToolStripItemImageScaling.None;
               btnInserir.ImageTransparentColor = Color.Magenta;
               btnInserir.Name = "btnInserir";
               btnInserir.Padding = new Padding(7);
               btnInserir.Size = new Size(42, 42);
               btnInserir.Text = "toolStripButton1";
               btnInserir.ToolTipText = "Inserir";
               btnInserir.Click += btnInserir_Click;
               // 
               // btnEditar
               // 
               btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
               btnEditar.Enabled = false;
               btnEditar.Image = Properties.Resources.editIcon;
               btnEditar.ImageScaling = ToolStripItemImageScaling.None;
               btnEditar.ImageTransparentColor = Color.Magenta;
               btnEditar.Name = "btnEditar";
               btnEditar.Padding = new Padding(7);
               btnEditar.Size = new Size(42, 42);
               btnEditar.Text = "toolStripButton2";
               btnEditar.ToolTipText = "Editar";
               btnEditar.Click += btnEditar_Click;
               // 
               // btnExcluir
               // 
               btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
               btnExcluir.Enabled = false;
               btnExcluir.Image = Properties.Resources.deleteIcon;
               btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
               btnExcluir.ImageTransparentColor = Color.Magenta;
               btnExcluir.Name = "btnExcluir";
               btnExcluir.Padding = new Padding(7);
               btnExcluir.Size = new Size(42, 42);
               btnExcluir.Text = "toolStripButton3";
               btnExcluir.ToolTipText = "Excluir";
               btnExcluir.Click += btnExcluir_Click;
               // 
               // toolStripSeparator2
               // 
               toolStripSeparator2.Name = "toolStripSeparator2";
               toolStripSeparator2.Size = new Size(6, 45);
               // 
               // btnFiltrar
               // 
               btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
               btnFiltrar.Enabled = false;
               btnFiltrar.Image = Properties.Resources.filterIcon;
               btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
               btnFiltrar.ImageTransparentColor = Color.Magenta;
               btnFiltrar.Name = "btnFiltrar";
               btnFiltrar.Padding = new Padding(7);
               btnFiltrar.Size = new Size(42, 42);
               btnFiltrar.Text = "toolStripButton3";
               btnFiltrar.ToolTipText = "Filtrar";
               btnFiltrar.Click += btnFiltrar_Click;
               // 
               // toolStripSeparator1
               // 
               toolStripSeparator1.Name = "toolStripSeparator1";
               toolStripSeparator1.Size = new Size(6, 45);
               // 
               // btnAddItens
               // 
               btnAddItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
               btnAddItens.Enabled = false;
               btnAddItens.Image = Properties.Resources.addTaskIcon;
               btnAddItens.ImageScaling = ToolStripItemImageScaling.None;
               btnAddItens.ImageTransparentColor = Color.Magenta;
               btnAddItens.Name = "btnAddItens";
               btnAddItens.Padding = new Padding(7);
               btnAddItens.Size = new Size(42, 42);
               btnAddItens.Text = "btnAddItens";
               btnAddItens.ToolTipText = "Adicionar Item";
               btnAddItens.Click += btnAddItens_Click;
               // 
               // toolStripSeparator3
               // 
               toolStripSeparator3.Name = "toolStripSeparator3";
               toolStripSeparator3.Size = new Size(6, 45);
               // 
               // btnChecar
               // 
               btnChecar.DisplayStyle = ToolStripItemDisplayStyle.Image;
               btnChecar.Enabled = false;
               btnChecar.Image = Properties.Resources.checklistIcon;
               btnChecar.ImageScaling = ToolStripItemImageScaling.None;
               btnChecar.ImageTransparentColor = Color.Magenta;
               btnChecar.Name = "btnChecar";
               btnChecar.Padding = new Padding(7);
               btnChecar.Size = new Size(42, 42);
               btnChecar.Text = "btnAddItens";
               btnChecar.ToolTipText = "Checar Itens";
               btnChecar.Click += btnChecar_Click;
               // 
               // toolStripSeparator4
               // 
               toolStripSeparator4.Name = "toolStripSeparator4";
               toolStripSeparator4.Size = new Size(6, 45);
               // 
               // tslTipoCadastros
               // 
               tslTipoCadastros.Name = "tslTipoCadastros";
               tslTipoCadastros.Size = new Size(90, 42);
               tslTipoCadastros.Text = "Tipos Cadastros";
               // 
               // panelRegistros
               // 
               panelRegistros.BackColor = SystemColors.ActiveBorder;
               panelRegistros.Dock = DockStyle.Fill;
               panelRegistros.Location = new Point(0, 69);
               panelRegistros.Name = "panelRegistros";
               panelRegistros.Size = new Size(709, 370);
               panelRegistros.TabIndex = 3;
               // 
               // temporizador
               // 
               temporizador.Interval = 1000;
               // 
               // TelaPrincipalForm
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(709, 461);
               Controls.Add(panelRegistros);
               Controls.Add(toolStrip1);
               Controls.Add(ssRodape);
               Controls.Add(msCabecalho);
               Icon = (Icon)resources.GetObject("$this.Icon");
               MainMenuStrip = msCabecalho;
               MinimumSize = new Size(725, 500);
               Name = "TelaPrincipalForm";
               Text = "E-Agenda1.0";
               ssRodape.ResumeLayout(false);
               ssRodape.PerformLayout();
               msCabecalho.ResumeLayout(false);
               msCabecalho.PerformLayout();
               toolStrip1.ResumeLayout(false);
               toolStrip1.PerformLayout();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private StatusStrip ssRodape;
          private ToolStripStatusLabel tssStatus;
          private MenuStrip msCabecalho;
          private ToolStripMenuItem cadastrosMenuItem;
          private ToolStripMenuItem contatosMenuItem;
          private ToolStripMenuItem compromissosMenuItem;
          private ToolStripMenuItem tarefasMenuItem;
          private ToolStrip toolStrip1;
          private ToolStripButton btnInserir;
          private ToolStripButton btnEditar;
          private ToolStripButton btnExcluir;
          private Panel panelRegistros;
          private ToolStripLabel tslTipoCadastros;
          private System.Windows.Forms.Timer temporizador;
          private ToolStripButton btnFiltrar;
          private ToolStripSeparator toolStripSeparator2;
          private ToolStripSeparator toolStripSeparator1;
          private ToolStripButton btnAddItens;
          private ToolStripSeparator toolStripSeparator3;
          private ToolStripButton btnChecar;
          private ToolStripSeparator toolStripSeparator4;
     }
}