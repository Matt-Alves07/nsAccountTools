namespace nsAccountTools.Views
{
    partial class frmListaDePara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDePara));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.tbcInfo = new System.Windows.Forms.TabControl();
            this.tbpEmpresa = new System.Windows.Forms.TabPage();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.cbbGrupo = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cbbEmpresa = new System.Windows.Forms.ComboBox();
            this.tbpFato = new System.Windows.Forms.TabPage();
            this.lblFato = new System.Windows.Forms.Label();
            this.cbbFato = new System.Windows.Forms.ComboBox();
            this.lblCapitulo = new System.Windows.Forms.Label();
            this.cbbCapitulo = new System.Windows.Forms.ComboBox();
            this.tbpConta = new System.Windows.Forms.TabPage();
            this.gpbContas = new System.Windows.Forms.GroupBox();
            this.txtContas = new System.Windows.Forms.TextBox();
            this.gpbNatureza = new System.Windows.Forms.GroupBox();
            this.rdbCredito = new System.Windows.Forms.RadioButton();
            this.rdbDebito = new System.Windows.Forms.RadioButton();
            this.rdbAmbas = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvDadosUsuarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selecinado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aberturaSecundaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contaDebito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contaCrédito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenu.SuspendLayout();
            this.tbcInfo.SuspendLayout();
            this.tbpEmpresa.SuspendLayout();
            this.tbpFato.SuspendLayout();
            this.tbpConta.SuspendLayout();
            this.gpbContas.SuspendLayout();
            this.gpbNatureza.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1138, 50);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::nsAccountTools.Properties.Resources.exit;
            this.btnSair.Location = new System.Drawing.Point(1038, 0);
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
            // tbcInfo
            // 
            this.tbcInfo.Controls.Add(this.tbpEmpresa);
            this.tbcInfo.Controls.Add(this.tbpFato);
            this.tbcInfo.Controls.Add(this.tbpConta);
            this.tbcInfo.Location = new System.Drawing.Point(0, 56);
            this.tbcInfo.Name = "tbcInfo";
            this.tbcInfo.SelectedIndex = 0;
            this.tbcInfo.Size = new System.Drawing.Size(1138, 146);
            this.tbcInfo.TabIndex = 2;
            // 
            // tbpEmpresa
            // 
            this.tbpEmpresa.Controls.Add(this.lblGrupo);
            this.tbpEmpresa.Controls.Add(this.cbbGrupo);
            this.tbpEmpresa.Controls.Add(this.lblEmpresa);
            this.tbpEmpresa.Controls.Add(this.cbbEmpresa);
            this.tbpEmpresa.Location = new System.Drawing.Point(4, 25);
            this.tbpEmpresa.Name = "tbpEmpresa";
            this.tbpEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEmpresa.Size = new System.Drawing.Size(1130, 117);
            this.tbpEmpresa.TabIndex = 0;
            this.tbpEmpresa.Text = "Dados de Empresa";
            this.tbpEmpresa.UseVisualStyleBackColor = true;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGrupo.Location = new System.Drawing.Point(264, 28);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(101, 17);
            this.lblGrupo.TabIndex = 5;
            this.lblGrupo.Text = "<SELECIONE>";
            // 
            // cbbGrupo
            // 
            this.cbbGrupo.DropDownWidth = 400;
            this.cbbGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbGrupo.FormattingEnabled = true;
            this.cbbGrupo.Location = new System.Drawing.Point(8, 25);
            this.cbbGrupo.Name = "cbbGrupo";
            this.cbbGrupo.Size = new System.Drawing.Size(250, 24);
            this.cbbGrupo.TabIndex = 4;
            this.cbbGrupo.SelectedValueChanged += new System.EventHandler(this.cbbGrupo_SelectedValueChanged);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmpresa.Location = new System.Drawing.Point(264, 57);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(101, 17);
            this.lblEmpresa.TabIndex = 2;
            this.lblEmpresa.Text = "<SELECIONE>";
            // 
            // cbbEmpresa
            // 
            this.cbbEmpresa.DropDownWidth = 400;
            this.cbbEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbEmpresa.FormattingEnabled = true;
            this.cbbEmpresa.Location = new System.Drawing.Point(8, 54);
            this.cbbEmpresa.Name = "cbbEmpresa";
            this.cbbEmpresa.Size = new System.Drawing.Size(250, 24);
            this.cbbEmpresa.TabIndex = 0;
            this.cbbEmpresa.SelectedValueChanged += new System.EventHandler(this.cbbEmpresa_SelectedValueChanged);
            // 
            // tbpFato
            // 
            this.tbpFato.Controls.Add(this.lblFato);
            this.tbpFato.Controls.Add(this.cbbFato);
            this.tbpFato.Controls.Add(this.lblCapitulo);
            this.tbpFato.Controls.Add(this.cbbCapitulo);
            this.tbpFato.Location = new System.Drawing.Point(4, 25);
            this.tbpFato.Name = "tbpFato";
            this.tbpFato.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFato.Size = new System.Drawing.Size(1130, 117);
            this.tbpFato.TabIndex = 1;
            this.tbpFato.Text = "Dados de Fato/Capítulo";
            this.tbpFato.UseVisualStyleBackColor = true;
            // 
            // lblFato
            // 
            this.lblFato.AutoSize = true;
            this.lblFato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFato.Location = new System.Drawing.Point(264, 28);
            this.lblFato.Name = "lblFato";
            this.lblFato.Size = new System.Drawing.Size(101, 17);
            this.lblFato.TabIndex = 9;
            this.lblFato.Text = "<SELECIONE>";
            // 
            // cbbFato
            // 
            this.cbbFato.DropDownWidth = 400;
            this.cbbFato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbFato.FormattingEnabled = true;
            this.cbbFato.Location = new System.Drawing.Point(8, 25);
            this.cbbFato.Name = "cbbFato";
            this.cbbFato.Size = new System.Drawing.Size(250, 24);
            this.cbbFato.TabIndex = 8;
            this.cbbFato.SelectedValueChanged += new System.EventHandler(this.cbbFato_SelectedValueChanged);
            // 
            // lblCapitulo
            // 
            this.lblCapitulo.AutoSize = true;
            this.lblCapitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCapitulo.Location = new System.Drawing.Point(264, 57);
            this.lblCapitulo.Name = "lblCapitulo";
            this.lblCapitulo.Size = new System.Drawing.Size(101, 17);
            this.lblCapitulo.TabIndex = 7;
            this.lblCapitulo.Text = "<SELECIONE>";
            // 
            // cbbCapitulo
            // 
            this.cbbCapitulo.DropDownWidth = 400;
            this.cbbCapitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCapitulo.FormattingEnabled = true;
            this.cbbCapitulo.Location = new System.Drawing.Point(8, 54);
            this.cbbCapitulo.Name = "cbbCapitulo";
            this.cbbCapitulo.Size = new System.Drawing.Size(250, 24);
            this.cbbCapitulo.TabIndex = 6;
            this.cbbCapitulo.SelectedValueChanged += new System.EventHandler(this.cbbCapitulo_SelectedValueChanged);
            // 
            // tbpConta
            // 
            this.tbpConta.Controls.Add(this.gpbContas);
            this.tbpConta.Controls.Add(this.gpbNatureza);
            this.tbpConta.Location = new System.Drawing.Point(4, 25);
            this.tbpConta.Name = "tbpConta";
            this.tbpConta.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConta.Size = new System.Drawing.Size(1130, 117);
            this.tbpConta.TabIndex = 2;
            this.tbpConta.Text = "Dados de Conta(s)";
            this.tbpConta.UseVisualStyleBackColor = true;
            // 
            // gpbContas
            // 
            this.gpbContas.Controls.Add(this.txtContas);
            this.gpbContas.Location = new System.Drawing.Point(180, 7);
            this.gpbContas.Name = "gpbContas";
            this.gpbContas.Size = new System.Drawing.Size(942, 106);
            this.gpbContas.TabIndex = 1;
            this.gpbContas.TabStop = false;
            this.gpbContas.Text = "Informe a(s) conta(s) ";
            // 
            // txtContas
            // 
            this.txtContas.Location = new System.Drawing.Point(7, 49);
            this.txtContas.Name = "txtContas";
            this.txtContas.Size = new System.Drawing.Size(929, 22);
            this.txtContas.TabIndex = 0;
            // 
            // gpbNatureza
            // 
            this.gpbNatureza.Controls.Add(this.rdbCredito);
            this.gpbNatureza.Controls.Add(this.rdbDebito);
            this.gpbNatureza.Controls.Add(this.rdbAmbas);
            this.gpbNatureza.Location = new System.Drawing.Point(9, 7);
            this.gpbNatureza.Name = "gpbNatureza";
            this.gpbNatureza.Size = new System.Drawing.Size(165, 106);
            this.gpbNatureza.TabIndex = 0;
            this.gpbNatureza.TabStop = false;
            this.gpbNatureza.Text = "Natureza da conta ";
            // 
            // rdbCredito
            // 
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.FlatAppearance.BorderSize = 0;
            this.rdbCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbCredito.Location = new System.Drawing.Point(7, 76);
            this.rdbCredito.Name = "rdbCredito";
            this.rdbCredito.Size = new System.Drawing.Size(73, 21);
            this.rdbCredito.TabIndex = 2;
            this.rdbCredito.TabStop = true;
            this.rdbCredito.Text = "Crédito";
            this.rdbCredito.UseVisualStyleBackColor = true;
            // 
            // rdbDebito
            // 
            this.rdbDebito.AutoSize = true;
            this.rdbDebito.FlatAppearance.BorderSize = 0;
            this.rdbDebito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbDebito.Location = new System.Drawing.Point(7, 49);
            this.rdbDebito.Name = "rdbDebito";
            this.rdbDebito.Size = new System.Drawing.Size(69, 21);
            this.rdbDebito.TabIndex = 1;
            this.rdbDebito.TabStop = true;
            this.rdbDebito.Text = "Débito";
            this.rdbDebito.UseVisualStyleBackColor = true;
            // 
            // rdbAmbas
            // 
            this.rdbAmbas.AutoSize = true;
            this.rdbAmbas.FlatAppearance.BorderSize = 0;
            this.rdbAmbas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbAmbas.Location = new System.Drawing.Point(7, 22);
            this.rdbAmbas.Name = "rdbAmbas";
            this.rdbAmbas.Size = new System.Drawing.Size(71, 21);
            this.rdbAmbas.TabIndex = 0;
            this.rdbAmbas.TabStop = true;
            this.rdbAmbas.Text = "Ambas";
            this.rdbAmbas.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Location = new System.Drawing.Point(0, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 48);
            this.panel1.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Image = global::nsAccountTools.Properties.Resources.thunder;
            this.btnLimpar.Location = new System.Drawing.Point(589, 0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(545, 48);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "  Processa&r";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = global::nsAccountTools.Properties.Resources.search_small;
            this.btnPesquisar.Location = new System.Drawing.Point(0, 0);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(589, 48);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.TabStop = false;
            this.btnPesquisar.Text = "  &Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvDadosUsuarios
            // 
            this.dgvDadosUsuarios.AllowUserToAddRows = false;
            this.dgvDadosUsuarios.AllowUserToDeleteRows = false;
            this.dgvDadosUsuarios.AllowUserToResizeRows = false;
            this.dgvDadosUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDadosUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvDadosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.selecinado,
            this.descricao,
            this.abertura,
            this.aberturaSecundaria,
            this.contaDebito,
            this.contaCrédito});
            this.dgvDadosUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDadosUsuarios.Location = new System.Drawing.Point(0, 259);
            this.dgvDadosUsuarios.Name = "dgvDadosUsuarios";
            this.dgvDadosUsuarios.RowHeadersWidth = 51;
            this.dgvDadosUsuarios.RowTemplate.Height = 24;
            this.dgvDadosUsuarios.Size = new System.Drawing.Size(1138, 344);
            this.dgvDadosUsuarios.TabIndex = 4;
            this.dgvDadosUsuarios.TabStop = false;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // selecinado
            // 
            this.selecinado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.selecinado.HeaderText = "Selecionar";
            this.selecinado.MinimumWidth = 6;
            this.selecinado.Name = "selecinado";
            this.selecinado.Width = 81;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 6;
            this.descricao.Name = "descricao";
            // 
            // abertura
            // 
            this.abertura.HeaderText = "Abertura";
            this.abertura.MinimumWidth = 6;
            this.abertura.Name = "abertura";
            // 
            // aberturaSecundaria
            // 
            this.aberturaSecundaria.HeaderText = "Abertura Secundária";
            this.aberturaSecundaria.MinimumWidth = 6;
            this.aberturaSecundaria.Name = "aberturaSecundaria";
            // 
            // contaDebito
            // 
            this.contaDebito.HeaderText = "Conta Débito";
            this.contaDebito.MinimumWidth = 6;
            this.contaDebito.Name = "contaDebito";
            // 
            // contaCrédito
            // 
            this.contaCrédito.HeaderText = "Conta Crédito";
            this.contaCrédito.MinimumWidth = 6;
            this.contaCrédito.Name = "contaCrédito";
            // 
            // frmListaDePara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(1138, 603);
            this.Controls.Add(this.dgvDadosUsuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbcInfo);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmListaDePara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de contas de De-Para";
            this.Shown += new System.EventHandler(this.frmListaDePara_Shown);
            this.pnlMenu.ResumeLayout(false);
            this.tbcInfo.ResumeLayout(false);
            this.tbpEmpresa.ResumeLayout(false);
            this.tbpEmpresa.PerformLayout();
            this.tbpFato.ResumeLayout(false);
            this.tbpFato.PerformLayout();
            this.tbpConta.ResumeLayout(false);
            this.gpbContas.ResumeLayout(false);
            this.gpbContas.PerformLayout();
            this.gpbNatureza.ResumeLayout(false);
            this.gpbNatureza.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TabControl tbcInfo;
        private System.Windows.Forms.TabPage tbpEmpresa;
        private System.Windows.Forms.TabPage tbpFato;
        private System.Windows.Forms.TabPage tbpConta;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cbbEmpresa;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ComboBox cbbGrupo;
        private System.Windows.Forms.Label lblFato;
        private System.Windows.Forms.ComboBox cbbFato;
        private System.Windows.Forms.Label lblCapitulo;
        private System.Windows.Forms.ComboBox cbbCapitulo;
        private System.Windows.Forms.GroupBox gpbNatureza;
        private System.Windows.Forms.RadioButton rdbCredito;
        private System.Windows.Forms.RadioButton rdbDebito;
        private System.Windows.Forms.RadioButton rdbAmbas;
        private System.Windows.Forms.GroupBox gpbContas;
        private System.Windows.Forms.TextBox txtContas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvDadosUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecinado;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn abertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn aberturaSecundaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn contaDebito;
        private System.Windows.Forms.DataGridViewTextBoxColumn contaCrédito;
    }
}