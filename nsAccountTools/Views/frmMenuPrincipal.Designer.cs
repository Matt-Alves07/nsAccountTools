namespace nsAccountTools.Views
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnListas = new System.Windows.Forms.Button();
            this.btnFolha = new System.Windows.Forms.Button();
            this.btnDePara = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1062, 50);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::nsAccountTools.Properties.Resources.home;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(120, 50);
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            this.btnHome.Text = "  &Início";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::nsAccountTools.Properties.Resources.exit;
            this.btnSair.Location = new System.Drawing.Point(962, 0);
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
            // btnListas
            // 
            this.btnListas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListas.FlatAppearance.BorderSize = 0;
            this.btnListas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListas.Image = global::nsAccountTools.Properties.Resources.list;
            this.btnListas.Location = new System.Drawing.Point(654, 210);
            this.btnListas.Name = "btnListas";
            this.btnListas.Size = new System.Drawing.Size(230, 200);
            this.btnListas.TabIndex = 4;
            this.btnListas.TabStop = false;
            this.btnListas.Text = "LIsta de dados da Contabilização";
            this.btnListas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListas.UseVisualStyleBackColor = true;
            this.btnListas.Click += new System.EventHandler(this.btnListas_Click);
            // 
            // btnFolha
            // 
            this.btnFolha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFolha.FlatAppearance.BorderSize = 0;
            this.btnFolha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolha.Image = global::nsAccountTools.Properties.Resources.progress;
            this.btnFolha.Location = new System.Drawing.Point(418, 210);
            this.btnFolha.Name = "btnFolha";
            this.btnFolha.Size = new System.Drawing.Size(230, 200);
            this.btnFolha.TabIndex = 3;
            this.btnFolha.TabStop = false;
            this.btnFolha.Text = "Contabilização parcial da Folha";
            this.btnFolha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFolha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFolha.UseVisualStyleBackColor = true;
            this.btnFolha.Click += new System.EventHandler(this.btnFolha_Click);
            // 
            // btnDePara
            // 
            this.btnDePara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDePara.FlatAppearance.BorderSize = 0;
            this.btnDePara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDePara.Image = global::nsAccountTools.Properties.Resources.search;
            this.btnDePara.Location = new System.Drawing.Point(182, 210);
            this.btnDePara.Name = "btnDePara";
            this.btnDePara.Size = new System.Drawing.Size(230, 200);
            this.btnDePara.TabIndex = 2;
            this.btnDePara.TabStop = false;
            this.btnDePara.Text = "Encontrar registros de De-Para";
            this.btnDePara.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDePara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDePara.UseVisualStyleBackColor = true;
            this.btnDePara.Click += new System.EventHandler(this.btnDePara_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(1062, 597);
            this.Controls.Add(this.btnListas);
            this.Controls.Add(this.btnFolha);
            this.Controls.Add(this.btnDePara);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nsAccoutTools";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDePara;
        private System.Windows.Forms.Button btnFolha;
        private System.Windows.Forms.Button btnListas;
    }
}