namespace nsAccountTools
{
    partial class frmInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicial));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.gpbInfoConexao = new System.Windows.Forms.GroupBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.gpbCreate = new System.Windows.Forms.GroupBox();
            this.rdbNaoCriar = new System.Windows.Forms.RadioButton();
            this.rdbCriar = new System.Windows.Forms.RadioButton();
            this.gpbKeep = new System.Windows.Forms.GroupBox();
            this.rdbNaoManter = new System.Windows.Forms.RadioButton();
            this.rdbManter = new System.Windows.Forms.RadioButton();
            this.pgbCreate = new System.Windows.Forms.ProgressBar();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.gpbInfoConexao.SuspendLayout();
            this.gpbCreate.SuspendLayout();
            this.gpbKeep.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(607, 50);
            this.pnlMenu.TabIndex = 0;
            // 
            // gpbInfoConexao
            // 
            this.gpbInfoConexao.Controls.Add(this.txtDatabase);
            this.gpbInfoConexao.Controls.Add(this.lblDatabase);
            this.gpbInfoConexao.Controls.Add(this.txtPass);
            this.gpbInfoConexao.Controls.Add(this.lblPass);
            this.gpbInfoConexao.Controls.Add(this.txtUser);
            this.gpbInfoConexao.Controls.Add(this.lblUser);
            this.gpbInfoConexao.Controls.Add(this.txtPort);
            this.gpbInfoConexao.Controls.Add(this.lblPort);
            this.gpbInfoConexao.Controls.Add(this.txtHost);
            this.gpbInfoConexao.Controls.Add(this.lblHost);
            this.gpbInfoConexao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbInfoConexao.Location = new System.Drawing.Point(13, 57);
            this.gpbInfoConexao.Name = "gpbInfoConexao";
            this.gpbInfoConexao.Size = new System.Drawing.Size(582, 168);
            this.gpbInfoConexao.TabIndex = 1;
            this.gpbInfoConexao.TabStop = false;
            this.gpbInfoConexao.Text = "Informe os dados para conectar ao banco de dados: ";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(10, 135);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(556, 22);
            this.txtDatabase.TabIndex = 4;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.BackColor = System.Drawing.Color.Transparent;
            this.lblDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDatabase.Location = new System.Drawing.Point(7, 114);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(178, 17);
            this.lblDatabase.TabIndex = 7;
            this.lblDatabase.Text = "Nome do Banco de Dados:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(306, 89);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(260, 22);
            this.txtPass.TabIndex = 3;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPass.Location = new System.Drawing.Point(303, 68);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(133, 17);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Senha do Postgres:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(10, 89);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(260, 22);
            this.txtUser.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUser.Location = new System.Drawing.Point(7, 68);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(141, 17);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuário do Postgres:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(306, 43);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(260, 22);
            this.txtPort.TabIndex = 1;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPort.Location = new System.Drawing.Point(303, 22);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(123, 17);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Porta do Servidor:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(10, 43);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(260, 22);
            this.txtHost.TabIndex = 0;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.BackColor = System.Drawing.Color.Transparent;
            this.lblHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHost.Location = new System.Drawing.Point(7, 22);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(150, 17);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Endereço do Servidor:";
            // 
            // gpbCreate
            // 
            this.gpbCreate.Controls.Add(this.rdbNaoCriar);
            this.gpbCreate.Controls.Add(this.rdbCriar);
            this.gpbCreate.Location = new System.Drawing.Point(13, 232);
            this.gpbCreate.Name = "gpbCreate";
            this.gpbCreate.Size = new System.Drawing.Size(582, 52);
            this.gpbCreate.TabIndex = 2;
            this.gpbCreate.TabStop = false;
            this.gpbCreate.Text = "Criar as funcionalidades necessárias no banco de dados?";
            // 
            // rdbNaoCriar
            // 
            this.rdbNaoCriar.AutoSize = true;
            this.rdbNaoCriar.FlatAppearance.BorderSize = 0;
            this.rdbNaoCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbNaoCriar.Location = new System.Drawing.Point(306, 22);
            this.rdbNaoCriar.Name = "rdbNaoCriar";
            this.rdbNaoCriar.Size = new System.Drawing.Size(54, 21);
            this.rdbNaoCriar.TabIndex = 1;
            this.rdbNaoCriar.TabStop = true;
            this.rdbNaoCriar.Text = "Não";
            this.rdbNaoCriar.UseVisualStyleBackColor = true;
            // 
            // rdbCriar
            // 
            this.rdbCriar.AutoSize = true;
            this.rdbCriar.FlatAppearance.BorderSize = 0;
            this.rdbCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbCriar.Location = new System.Drawing.Point(7, 22);
            this.rdbCriar.Name = "rdbCriar";
            this.rdbCriar.Size = new System.Drawing.Size(107, 21);
            this.rdbCriar.TabIndex = 0;
            this.rdbCriar.TabStop = true;
            this.rdbCriar.Text = "Sim(Padrão)";
            this.rdbCriar.UseVisualStyleBackColor = true;
            // 
            // gpbKeep
            // 
            this.gpbKeep.Controls.Add(this.rdbNaoManter);
            this.gpbKeep.Controls.Add(this.rdbManter);
            this.gpbKeep.Location = new System.Drawing.Point(13, 290);
            this.gpbKeep.Name = "gpbKeep";
            this.gpbKeep.Size = new System.Drawing.Size(582, 52);
            this.gpbKeep.TabIndex = 3;
            this.gpbKeep.TabStop = false;
            this.gpbKeep.Text = "Manter as funcionalidades necessárias no banco de dados?";
            // 
            // rdbNaoManter
            // 
            this.rdbNaoManter.AutoSize = true;
            this.rdbNaoManter.FlatAppearance.BorderSize = 0;
            this.rdbNaoManter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbNaoManter.Location = new System.Drawing.Point(306, 22);
            this.rdbNaoManter.Name = "rdbNaoManter";
            this.rdbNaoManter.Size = new System.Drawing.Size(110, 21);
            this.rdbNaoManter.TabIndex = 1;
            this.rdbNaoManter.TabStop = true;
            this.rdbNaoManter.Text = "Não(Padrão)";
            this.rdbNaoManter.UseVisualStyleBackColor = true;
            // 
            // rdbManter
            // 
            this.rdbManter.AutoSize = true;
            this.rdbManter.FlatAppearance.BorderSize = 0;
            this.rdbManter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbManter.Location = new System.Drawing.Point(7, 22);
            this.rdbManter.Name = "rdbManter";
            this.rdbManter.Size = new System.Drawing.Size(51, 21);
            this.rdbManter.TabIndex = 0;
            this.rdbManter.TabStop = true;
            this.rdbManter.Text = "Sim";
            this.rdbManter.UseVisualStyleBackColor = true;
            // 
            // pgbCreate
            // 
            this.pgbCreate.Location = new System.Drawing.Point(13, 349);
            this.pgbCreate.Name = "pgbCreate";
            this.pgbCreate.Size = new System.Drawing.Size(582, 23);
            this.pgbCreate.Step = 25;
            this.pgbCreate.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbCreate.TabIndex = 4;
            this.pgbCreate.Visible = false;
            // 
            // BtnConectar
            // 
            this.BtnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConectar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnConectar.FlatAppearance.BorderSize = 0;
            this.BtnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConectar.Image = global::nsAccountTools.Properties.Resources.server;
            this.BtnConectar.Location = new System.Drawing.Point(0, 381);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(607, 55);
            this.BtnConectar.TabIndex = 5;
            this.BtnConectar.TabStop = false;
            this.BtnConectar.Text = "  &Conectar";
            this.BtnConectar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConectar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::nsAccountTools.Properties.Resources.exit;
            this.btnSair.Location = new System.Drawing.Point(522, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 50);
            this.btnSair.TabIndex = 0;
            this.btnSair.TabStop = false;
            this.btnSair.Text = "  &Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmInicial
            // 
            this.AcceptButton = this.BtnConectar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(607, 436);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.pgbCreate);
            this.Controls.Add(this.gpbKeep);
            this.Controls.Add(this.gpbCreate);
            this.Controls.Add(this.gpbInfoConexao);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nsAccountTools - Login";
            this.Shown += new System.EventHandler(this.frmInicial_Shown);
            this.pnlMenu.ResumeLayout(false);
            this.gpbInfoConexao.ResumeLayout(false);
            this.gpbInfoConexao.PerformLayout();
            this.gpbCreate.ResumeLayout(false);
            this.gpbCreate.PerformLayout();
            this.gpbKeep.ResumeLayout(false);
            this.gpbKeep.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gpbInfoConexao;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.GroupBox gpbCreate;
        private System.Windows.Forms.RadioButton rdbCriar;
        private System.Windows.Forms.RadioButton rdbNaoCriar;
        private System.Windows.Forms.GroupBox gpbKeep;
        private System.Windows.Forms.RadioButton rdbNaoManter;
        private System.Windows.Forms.RadioButton rdbManter;
        private System.Windows.Forms.ProgressBar pgbCreate;
        private System.Windows.Forms.Button BtnConectar;
    }
}

