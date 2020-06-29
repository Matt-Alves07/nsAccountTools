namespace nsAccountTools.Views
{
    partial class frmAlterarHistorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarHistorico));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tbcInfo = new System.Windows.Forms.TabControl();
            this.tbpLancamentosRubricas = new System.Windows.Forms.TabPage();
            this.btnSair = new System.Windows.Forms.Button();
            this.tbpHistorico = new System.Windows.Forms.TabPage();
            this.tbpEmpresa = new System.Windows.Forms.TabPage();
            this.lblGrupoEmpresarial = new System.Windows.Forms.Label();
            this.cbbGrupo = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cbbEmpresa = new System.Windows.Forms.ComboBox();
            this.lblFato = new System.Windows.Forms.Label();
            this.cbbFato = new System.Windows.Forms.ComboBox();
            this.cbbCapitulo = new System.Windows.Forms.ComboBox();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.pnlAlterar = new System.Windows.Forms.Panel();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.gpbOpcao = new System.Windows.Forms.GroupBox();
            this.rdbLancamentos = new System.Windows.Forms.RadioButton();
            this.rdbRubricas = new System.Windows.Forms.RadioButton();
            this.lblCapitulo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.tbcInfo.SuspendLayout();
            this.tbpLancamentosRubricas.SuspendLayout();
            this.tbpHistorico.SuspendLayout();
            this.tbpEmpresa.SuspendLayout();
            this.pnlAlterar.SuspendLayout();
            this.gpbOpcao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(800, 50);
            this.pnlMenu.TabIndex = 3;
            // 
            // tbcInfo
            // 
            this.tbcInfo.Controls.Add(this.tbpEmpresa);
            this.tbcInfo.Controls.Add(this.tbpLancamentosRubricas);
            this.tbcInfo.Controls.Add(this.tbpHistorico);
            this.tbcInfo.Location = new System.Drawing.Point(0, 56);
            this.tbcInfo.Name = "tbcInfo";
            this.tbcInfo.SelectedIndex = 0;
            this.tbcInfo.Size = new System.Drawing.Size(800, 112);
            this.tbcInfo.TabIndex = 4;
            // 
            // tbpLancamentosRubricas
            // 
            this.tbpLancamentosRubricas.Controls.Add(this.gpbOpcao);
            this.tbpLancamentosRubricas.Controls.Add(this.lblFato);
            this.tbpLancamentosRubricas.Controls.Add(this.cbbFato);
            this.tbpLancamentosRubricas.Controls.Add(this.lblCapitulo);
            this.tbpLancamentosRubricas.Controls.Add(this.cbbCapitulo);
            this.tbpLancamentosRubricas.Location = new System.Drawing.Point(4, 25);
            this.tbpLancamentosRubricas.Name = "tbpLancamentosRubricas";
            this.tbpLancamentosRubricas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLancamentosRubricas.Size = new System.Drawing.Size(792, 83);
            this.tbpLancamentosRubricas.TabIndex = 0;
            this.tbpLancamentosRubricas.Text = "Lançamentos/Rubricas";
            this.tbpLancamentosRubricas.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::nsAccountTools.Properties.Resources.exit;
            this.btnSair.Location = new System.Drawing.Point(700, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 50);
            this.btnSair.TabIndex = 0;
            this.btnSair.TabStop = false;
            this.btnSair.Text = "  &Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tbpHistorico
            // 
            this.tbpHistorico.Controls.Add(this.txtHistorico);
            this.tbpHistorico.Location = new System.Drawing.Point(4, 25);
            this.tbpHistorico.Name = "tbpHistorico";
            this.tbpHistorico.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHistorico.Size = new System.Drawing.Size(792, 83);
            this.tbpHistorico.TabIndex = 2;
            this.tbpHistorico.Text = "Histórico";
            this.tbpHistorico.UseVisualStyleBackColor = true;
            // 
            // tbpEmpresa
            // 
            this.tbpEmpresa.Controls.Add(this.lblGrupoEmpresarial);
            this.tbpEmpresa.Controls.Add(this.cbbGrupo);
            this.tbpEmpresa.Controls.Add(this.lblEmpresa);
            this.tbpEmpresa.Controls.Add(this.cbbEmpresa);
            this.tbpEmpresa.Location = new System.Drawing.Point(4, 25);
            this.tbpEmpresa.Name = "tbpEmpresa";
            this.tbpEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEmpresa.Size = new System.Drawing.Size(792, 83);
            this.tbpEmpresa.TabIndex = 3;
            this.tbpEmpresa.Text = "Empresa";
            this.tbpEmpresa.UseVisualStyleBackColor = true;
            // 
            // lblGrupoEmpresarial
            // 
            this.lblGrupoEmpresarial.AutoSize = true;
            this.lblGrupoEmpresarial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGrupoEmpresarial.Location = new System.Drawing.Point(264, 17);
            this.lblGrupoEmpresarial.Name = "lblGrupoEmpresarial";
            this.lblGrupoEmpresarial.Size = new System.Drawing.Size(101, 17);
            this.lblGrupoEmpresarial.TabIndex = 13;
            this.lblGrupoEmpresarial.Text = "<SELECIONE>";
            // 
            // cbbGrupo
            // 
            this.cbbGrupo.DropDownWidth = 400;
            this.cbbGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbGrupo.FormattingEnabled = true;
            this.cbbGrupo.Location = new System.Drawing.Point(8, 14);
            this.cbbGrupo.Name = "cbbGrupo";
            this.cbbGrupo.Size = new System.Drawing.Size(250, 24);
            this.cbbGrupo.TabIndex = 12;
            this.cbbGrupo.TabStop = false;
            this.cbbGrupo.SelectedValueChanged += new System.EventHandler(this.cbbGrupo_SelectedValueChanged);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmpresa.Location = new System.Drawing.Point(264, 46);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(101, 17);
            this.lblEmpresa.TabIndex = 11;
            this.lblEmpresa.Text = "<SELECIONE>";
            // 
            // cbbEmpresa
            // 
            this.cbbEmpresa.DropDownWidth = 400;
            this.cbbEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbEmpresa.FormattingEnabled = true;
            this.cbbEmpresa.Location = new System.Drawing.Point(8, 43);
            this.cbbEmpresa.Name = "cbbEmpresa";
            this.cbbEmpresa.Size = new System.Drawing.Size(250, 24);
            this.cbbEmpresa.TabIndex = 10;
            this.cbbEmpresa.TabStop = false;
            this.cbbEmpresa.SelectedValueChanged += new System.EventHandler(this.cbbEmpresa_SelectedValueChanged);
            // 
            // lblFato
            // 
            this.lblFato.AutoSize = true;
            this.lblFato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFato.Location = new System.Drawing.Point(264, 17);
            this.lblFato.Name = "lblFato";
            this.lblFato.Size = new System.Drawing.Size(101, 17);
            this.lblFato.TabIndex = 13;
            this.lblFato.Text = "<SELECIONE>";
            // 
            // cbbFato
            // 
            this.cbbFato.DropDownWidth = 400;
            this.cbbFato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbFato.FormattingEnabled = true;
            this.cbbFato.Location = new System.Drawing.Point(8, 14);
            this.cbbFato.Name = "cbbFato";
            this.cbbFato.Size = new System.Drawing.Size(250, 24);
            this.cbbFato.TabIndex = 12;
            this.cbbFato.SelectedValueChanged += new System.EventHandler(this.cbbFato_SelectedValueChanged);
            // 
            // cbbCapitulo
            // 
            this.cbbCapitulo.DropDownWidth = 400;
            this.cbbCapitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCapitulo.FormattingEnabled = true;
            this.cbbCapitulo.Location = new System.Drawing.Point(8, 43);
            this.cbbCapitulo.Name = "cbbCapitulo";
            this.cbbCapitulo.Size = new System.Drawing.Size(250, 24);
            this.cbbCapitulo.TabIndex = 10;
            this.cbbCapitulo.SelectedValueChanged += new System.EventHandler(this.cbbCapitulo_SelectedValueChanged);
            // 
            // txtHistorico
            // 
            this.txtHistorico.Location = new System.Drawing.Point(9, 24);
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.Size = new System.Drawing.Size(775, 22);
            this.txtHistorico.TabIndex = 0;
            // 
            // pnlAlterar
            // 
            this.pnlAlterar.Controls.Add(this.btnProcessar);
            this.pnlAlterar.Location = new System.Drawing.Point(4, 174);
            this.pnlAlterar.Name = "pnlAlterar";
            this.pnlAlterar.Size = new System.Drawing.Size(792, 40);
            this.pnlAlterar.TabIndex = 6;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcessar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProcessar.FlatAppearance.BorderSize = 0;
            this.btnProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessar.Image = global::nsAccountTools.Properties.Resources.thunder;
            this.btnProcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessar.Location = new System.Drawing.Point(0, 0);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(792, 40);
            this.btnProcessar.TabIndex = 0;
            this.btnProcessar.Text = "  &Processar";
            this.btnProcessar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // gpbOpcao
            // 
            this.gpbOpcao.Controls.Add(this.rdbRubricas);
            this.gpbOpcao.Controls.Add(this.rdbLancamentos);
            this.gpbOpcao.Dock = System.Windows.Forms.DockStyle.Right;
            this.gpbOpcao.Location = new System.Drawing.Point(630, 3);
            this.gpbOpcao.Name = "gpbOpcao";
            this.gpbOpcao.Size = new System.Drawing.Size(159, 77);
            this.gpbOpcao.TabIndex = 14;
            this.gpbOpcao.TabStop = false;
            this.gpbOpcao.Text = "Opção a alterar";
            // 
            // rdbLancamentos
            // 
            this.rdbLancamentos.AutoSize = true;
            this.rdbLancamentos.Checked = true;
            this.rdbLancamentos.FlatAppearance.BorderSize = 0;
            this.rdbLancamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbLancamentos.Location = new System.Drawing.Point(7, 22);
            this.rdbLancamentos.Name = "rdbLancamentos";
            this.rdbLancamentos.Size = new System.Drawing.Size(113, 21);
            this.rdbLancamentos.TabIndex = 0;
            this.rdbLancamentos.TabStop = true;
            this.rdbLancamentos.Text = "Lançamentos";
            this.rdbLancamentos.UseVisualStyleBackColor = true;
            // 
            // rdbRubricas
            // 
            this.rdbRubricas.AutoSize = true;
            this.rdbRubricas.FlatAppearance.BorderSize = 0;
            this.rdbRubricas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbRubricas.Location = new System.Drawing.Point(7, 49);
            this.rdbRubricas.Name = "rdbRubricas";
            this.rdbRubricas.Size = new System.Drawing.Size(84, 21);
            this.rdbRubricas.TabIndex = 1;
            this.rdbRubricas.Text = "Rubricas";
            this.rdbRubricas.UseVisualStyleBackColor = true;
            // 
            // lblCapitulo
            // 
            this.lblCapitulo.AutoSize = true;
            this.lblCapitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCapitulo.Location = new System.Drawing.Point(264, 46);
            this.lblCapitulo.Name = "lblCapitulo";
            this.lblCapitulo.Size = new System.Drawing.Size(101, 17);
            this.lblCapitulo.TabIndex = 11;
            this.lblCapitulo.Text = "<SELECIONE>";
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Location = new System.Drawing.Point(0, 217);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(800, 233);
            this.lblStatus.TabIndex = 7;
            // 
            // frmAlterarHistorico
            // 
            this.AcceptButton = this.btnProcessar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pnlAlterar);
            this.Controls.Add(this.tbcInfo);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlterarHistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlterarHistorico";
            this.Shown += new System.EventHandler(this.frmAlterarHistorico_Shown);
            this.pnlMenu.ResumeLayout(false);
            this.tbcInfo.ResumeLayout(false);
            this.tbpLancamentosRubricas.ResumeLayout(false);
            this.tbpLancamentosRubricas.PerformLayout();
            this.tbpHistorico.ResumeLayout(false);
            this.tbpHistorico.PerformLayout();
            this.tbpEmpresa.ResumeLayout(false);
            this.tbpEmpresa.PerformLayout();
            this.pnlAlterar.ResumeLayout(false);
            this.gpbOpcao.ResumeLayout(false);
            this.gpbOpcao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TabControl tbcInfo;
        private System.Windows.Forms.TabPage tbpLancamentosRubricas;
        private System.Windows.Forms.TabPage tbpEmpresa;
        private System.Windows.Forms.TabPage tbpHistorico;
        private System.Windows.Forms.Label lblGrupoEmpresarial;
        private System.Windows.Forms.ComboBox cbbGrupo;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cbbEmpresa;
        private System.Windows.Forms.Label lblFato;
        private System.Windows.Forms.ComboBox cbbFato;
        private System.Windows.Forms.ComboBox cbbCapitulo;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.Panel pnlAlterar;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.GroupBox gpbOpcao;
        private System.Windows.Forms.RadioButton rdbLancamentos;
        private System.Windows.Forms.RadioButton rdbRubricas;
        private System.Windows.Forms.Label lblCapitulo;
        private System.Windows.Forms.Label lblStatus;
    }
}