namespace nsAccountTools.Views
{
    partial class frmOpcoesFolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpcoesFolha));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlterarHistorico = new System.Windows.Forms.Button();
            this.btnContabilizar = new System.Windows.Forms.Button();
            this.btnReverter = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
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
            this.pnlMenu.TabIndex = 2;
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
            // btnAlterarHistorico
            // 
            this.btnAlterarHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarHistorico.FlatAppearance.BorderSize = 0;
            this.btnAlterarHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarHistorico.Image = global::nsAccountTools.Properties.Resources.atualizar_historico;
            this.btnAlterarHistorico.Location = new System.Drawing.Point(85, 173);
            this.btnAlterarHistorico.Name = "btnAlterarHistorico";
            this.btnAlterarHistorico.Size = new System.Drawing.Size(200, 150);
            this.btnAlterarHistorico.TabIndex = 3;
            this.btnAlterarHistorico.TabStop = false;
            this.btnAlterarHistorico.Text = "Alterar histórico";
            this.btnAlterarHistorico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarHistorico.UseVisualStyleBackColor = true;
            // 
            // btnContabilizar
            // 
            this.btnContabilizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContabilizar.FlatAppearance.BorderSize = 0;
            this.btnContabilizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContabilizar.Image = global::nsAccountTools.Properties.Resources.progress;
            this.btnContabilizar.Location = new System.Drawing.Point(291, 173);
            this.btnContabilizar.Name = "btnContabilizar";
            this.btnContabilizar.Size = new System.Drawing.Size(200, 150);
            this.btnContabilizar.TabIndex = 4;
            this.btnContabilizar.TabStop = false;
            this.btnContabilizar.Text = "Contabilização por tipos";
            this.btnContabilizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnContabilizar.UseVisualStyleBackColor = true;
            // 
            // btnReverter
            // 
            this.btnReverter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReverter.FlatAppearance.BorderSize = 0;
            this.btnReverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReverter.Image = global::nsAccountTools.Properties.Resources.undo;
            this.btnReverter.Location = new System.Drawing.Point(497, 173);
            this.btnReverter.Name = "btnReverter";
            this.btnReverter.Size = new System.Drawing.Size(200, 150);
            this.btnReverter.TabIndex = 6;
            this.btnReverter.TabStop = false;
            this.btnReverter.Text = "Reversão por tipos";
            this.btnReverter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReverter.UseVisualStyleBackColor = true;
            // 
            // frmOpcoesFolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReverter);
            this.Controls.Add(this.btnContabilizar);
            this.Controls.Add(this.btnAlterarHistorico);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOpcoesFolha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opções da Folha de Pagamento";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlterarHistorico;
        private System.Windows.Forms.Button btnContabilizar;
        private System.Windows.Forms.Button btnReverter;
    }
}