namespace nsAccountTools.Views
{
    partial class frmScriptGenerator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScriptGenerator));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbDelete = new System.Windows.Forms.RadioButton();
            this.gpbUpdate = new System.Windows.Forms.GroupBox();
            this.gpbConta = new System.Windows.Forms.GroupBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.gpbNatureza = new System.Windows.Forms.GroupBox();
            this.rdbCredito = new System.Windows.Forms.RadioButton();
            this.rdbDebito = new System.Windows.Forms.RadioButton();
            this.rdbAmbas = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.btnGerar = new System.Windows.Forms.Button();
            this.ttpHint = new System.Windows.Forms.ToolTip(this.components);
            this.txtScript = new System.Windows.Forms.TextBox();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpbUpdate.SuspendLayout();
            this.gpbConta.SuspendLayout();
            this.gpbNatureza.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(679, 50);
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
            this.btnSair.Location = new System.Drawing.Point(579, 0);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbDelete);
            this.panel1.Controls.Add(this.gpbUpdate);
            this.panel1.Controls.Add(this.btnGerar);
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 218);
            this.panel1.TabIndex = 3;
            // 
            // rdbDelete
            // 
            this.rdbDelete.AutoSize = true;
            this.rdbDelete.FlatAppearance.BorderSize = 0;
            this.rdbDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbDelete.Location = new System.Drawing.Point(19, 135);
            this.rdbDelete.Name = "rdbDelete";
            this.rdbDelete.Size = new System.Drawing.Size(74, 21);
            this.rdbDelete.TabIndex = 3;
            this.rdbDelete.TabStop = true;
            this.rdbDelete.Text = "Apagar";
            this.ttpHint.SetToolTip(this.rdbDelete, "Gera script para deletar os registros selecionados");
            this.rdbDelete.UseVisualStyleBackColor = true;
            this.rdbDelete.CheckedChanged += new System.EventHandler(this.rdbDelete_CheckedChanged);
            // 
            // gpbUpdate
            // 
            this.gpbUpdate.Controls.Add(this.gpbConta);
            this.gpbUpdate.Controls.Add(this.gpbNatureza);
            this.gpbUpdate.Controls.Add(this.rdbUpdate);
            this.gpbUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbUpdate.Location = new System.Drawing.Point(13, 4);
            this.gpbUpdate.Name = "gpbUpdate";
            this.gpbUpdate.Size = new System.Drawing.Size(654, 124);
            this.gpbUpdate.TabIndex = 2;
            this.gpbUpdate.TabStop = false;
            // 
            // gpbConta
            // 
            this.gpbConta.Controls.Add(this.txtConta);
            this.gpbConta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbConta.Location = new System.Drawing.Point(169, 18);
            this.gpbConta.Name = "gpbConta";
            this.gpbConta.Size = new System.Drawing.Size(482, 103);
            this.gpbConta.TabIndex = 5;
            this.gpbConta.TabStop = false;
            this.gpbConta.Text = "Nova Conta";
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(7, 49);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(469, 22);
            this.txtConta.TabIndex = 0;
            // 
            // gpbNatureza
            // 
            this.gpbNatureza.Controls.Add(this.rdbCredito);
            this.gpbNatureza.Controls.Add(this.rdbDebito);
            this.gpbNatureza.Controls.Add(this.rdbAmbas);
            this.gpbNatureza.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpbNatureza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbNatureza.Location = new System.Drawing.Point(3, 18);
            this.gpbNatureza.Name = "gpbNatureza";
            this.gpbNatureza.Size = new System.Drawing.Size(166, 103);
            this.gpbNatureza.TabIndex = 4;
            this.gpbNatureza.TabStop = false;
            this.gpbNatureza.Text = "Natureza da Conta";
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
            this.rdbCredito.Text = "Crédito";
            this.ttpHint.SetToolTip(this.rdbCredito, "Altera apenas a natureza a Crédito");
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
            this.rdbDebito.Text = "Débito";
            this.ttpHint.SetToolTip(this.rdbDebito, "Altera apenas a natureza a débito");
            this.rdbDebito.UseVisualStyleBackColor = true;
            // 
            // rdbAmbas
            // 
            this.rdbAmbas.AutoSize = true;
            this.rdbAmbas.Checked = true;
            this.rdbAmbas.FlatAppearance.BorderSize = 0;
            this.rdbAmbas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbAmbas.Location = new System.Drawing.Point(7, 22);
            this.rdbAmbas.Name = "rdbAmbas";
            this.rdbAmbas.Size = new System.Drawing.Size(71, 21);
            this.rdbAmbas.TabIndex = 0;
            this.rdbAmbas.TabStop = true;
            this.rdbAmbas.Text = "Ambas";
            this.ttpHint.SetToolTip(this.rdbAmbas, "Altera ambas as naturezas");
            this.rdbAmbas.UseVisualStyleBackColor = true;
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Checked = true;
            this.rdbUpdate.FlatAppearance.BorderSize = 0;
            this.rdbUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbUpdate.Location = new System.Drawing.Point(6, 0);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(70, 21);
            this.rdbUpdate.TabIndex = 3;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "Alterar";
            this.ttpHint.SetToolTip(this.rdbUpdate, "Gera script para alterar os registros selecionados");
            this.rdbUpdate.UseVisualStyleBackColor = true;
            this.rdbUpdate.CheckedChanged += new System.EventHandler(this.rdbUpdate_CheckedChanged);
            // 
            // btnGerar
            // 
            this.btnGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGerar.FlatAppearance.BorderSize = 0;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Image = global::nsAccountTools.Properties.Resources.script;
            this.btnGerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerar.Location = new System.Drawing.Point(0, 170);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(679, 48);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.TabStop = false;
            this.btnGerar.Text = "  &Gerar Script";
            this.btnGerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtScript
            // 
            this.txtScript.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtScript.Location = new System.Drawing.Point(0, 281);
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(679, 285);
            this.txtScript.TabIndex = 4;
            // 
            // frmScriptGenerator
            // 
            this.AcceptButton = this.btnGerar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(679, 566);
            this.Controls.Add(this.txtScript);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScriptGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Script";
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbUpdate.ResumeLayout(false);
            this.gpbUpdate.PerformLayout();
            this.gpbConta.ResumeLayout(false);
            this.gpbConta.PerformLayout();
            this.gpbNatureza.ResumeLayout(false);
            this.gpbNatureza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.GroupBox gpbUpdate;
        private System.Windows.Forms.GroupBox gpbNatureza;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.RadioButton rdbDelete;
        private System.Windows.Forms.GroupBox gpbConta;
        private System.Windows.Forms.RadioButton rdbAmbas;
        private System.Windows.Forms.RadioButton rdbCredito;
        private System.Windows.Forms.RadioButton rdbDebito;
        private System.Windows.Forms.ToolTip ttpHint;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtScript;
    }
}