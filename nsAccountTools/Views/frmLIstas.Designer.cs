namespace nsAccountTools.Views
{
    partial class frmLIstas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLIstas));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.tbcListas = new System.Windows.Forms.TabControl();
            this.tbpFatosOrigem = new System.Windows.Forms.TabPage();
            this.dgvFatosOrigem = new System.Windows.Forms.DataGridView();
            this.fato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.persona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.scritta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbpCapitulosTags = new System.Windows.Forms.TabPage();
            this.lblFatos = new System.Windows.Forms.Label();
            this.cbbFatos = new System.Windows.Forms.ComboBox();
            this.lblCapitulos = new System.Windows.Forms.Label();
            this.cbbCapitulo = new System.Windows.Forms.ComboBox();
            this.dgvCapitulosTags = new System.Windows.Forms.DataGridView();
            this.capitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenu.SuspendLayout();
            this.tbcListas.SuspendLayout();
            this.tbpFatosOrigem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatosOrigem)).BeginInit();
            this.tbpCapitulosTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapitulosTags)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1052, 50);
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
            this.btnSair.Location = new System.Drawing.Point(952, 0);
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
            // tbcListas
            // 
            this.tbcListas.Controls.Add(this.tbpFatosOrigem);
            this.tbcListas.Controls.Add(this.tbpCapitulosTags);
            this.tbcListas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcListas.Location = new System.Drawing.Point(0, 50);
            this.tbcListas.Name = "tbcListas";
            this.tbcListas.SelectedIndex = 0;
            this.tbcListas.Size = new System.Drawing.Size(1052, 508);
            this.tbcListas.TabIndex = 3;
            // 
            // tbpFatosOrigem
            // 
            this.tbpFatosOrigem.Controls.Add(this.dgvFatosOrigem);
            this.tbpFatosOrigem.Location = new System.Drawing.Point(4, 25);
            this.tbpFatosOrigem.Name = "tbpFatosOrigem";
            this.tbpFatosOrigem.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFatosOrigem.Size = new System.Drawing.Size(1044, 479);
            this.tbpFatosOrigem.TabIndex = 0;
            this.tbpFatosOrigem.Text = "Fatos/Origem";
            this.tbpFatosOrigem.UseVisualStyleBackColor = true;
            // 
            // dgvFatosOrigem
            // 
            this.dgvFatosOrigem.AllowUserToAddRows = false;
            this.dgvFatosOrigem.AllowUserToDeleteRows = false;
            this.dgvFatosOrigem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFatosOrigem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFatosOrigem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFatosOrigem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fato,
            this.financas,
            this.persona,
            this.scritta});
            this.dgvFatosOrigem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFatosOrigem.Location = new System.Drawing.Point(3, 3);
            this.dgvFatosOrigem.Name = "dgvFatosOrigem";
            this.dgvFatosOrigem.ReadOnly = true;
            this.dgvFatosOrigem.RowHeadersWidth = 51;
            this.dgvFatosOrigem.RowTemplate.Height = 24;
            this.dgvFatosOrigem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFatosOrigem.Size = new System.Drawing.Size(1038, 473);
            this.dgvFatosOrigem.TabIndex = 0;
            // 
            // fato
            // 
            this.fato.HeaderText = "Fato";
            this.fato.MinimumWidth = 6;
            this.fato.Name = "fato";
            this.fato.ReadOnly = true;
            // 
            // financas
            // 
            this.financas.HeaderText = "Finanças SQL";
            this.financas.MinimumWidth = 6;
            this.financas.Name = "financas";
            this.financas.ReadOnly = true;
            this.financas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.financas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // persona
            // 
            this.persona.HeaderText = "Persona SQL";
            this.persona.MinimumWidth = 6;
            this.persona.Name = "persona";
            this.persona.ReadOnly = true;
            this.persona.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.persona.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // scritta
            // 
            this.scritta.HeaderText = "Scritta SQL";
            this.scritta.MinimumWidth = 6;
            this.scritta.Name = "scritta";
            this.scritta.ReadOnly = true;
            this.scritta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.scritta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tbpCapitulosTags
            // 
            this.tbpCapitulosTags.Controls.Add(this.dgvCapitulosTags);
            this.tbpCapitulosTags.Controls.Add(this.lblCapitulos);
            this.tbpCapitulosTags.Controls.Add(this.cbbCapitulo);
            this.tbpCapitulosTags.Controls.Add(this.lblFatos);
            this.tbpCapitulosTags.Controls.Add(this.cbbFatos);
            this.tbpCapitulosTags.Location = new System.Drawing.Point(4, 25);
            this.tbpCapitulosTags.Name = "tbpCapitulosTags";
            this.tbpCapitulosTags.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCapitulosTags.Size = new System.Drawing.Size(1044, 479);
            this.tbpCapitulosTags.TabIndex = 1;
            this.tbpCapitulosTags.Text = "Capítulos/Tags";
            this.tbpCapitulosTags.UseVisualStyleBackColor = true;
            // 
            // lblFatos
            // 
            this.lblFatos.AutoSize = true;
            this.lblFatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFatos.Location = new System.Drawing.Point(182, 9);
            this.lblFatos.Name = "lblFatos";
            this.lblFatos.Size = new System.Drawing.Size(101, 17);
            this.lblFatos.TabIndex = 3;
            this.lblFatos.Text = "<SELECIONE>";
            // 
            // cbbFatos
            // 
            this.cbbFatos.DropDownHeight = 200;
            this.cbbFatos.DropDownWidth = 400;
            this.cbbFatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbFatos.FormattingEnabled = true;
            this.cbbFatos.IntegralHeight = false;
            this.cbbFatos.Location = new System.Drawing.Point(6, 6);
            this.cbbFatos.Name = "cbbFatos";
            this.cbbFatos.Size = new System.Drawing.Size(170, 24);
            this.cbbFatos.TabIndex = 2;
            this.cbbFatos.Text = "<SELECIONE>";
            this.cbbFatos.SelectedValueChanged += new System.EventHandler(this.cbbFatos_SelectedValueChanged);
            // 
            // lblCapitulos
            // 
            this.lblCapitulos.AutoSize = true;
            this.lblCapitulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCapitulos.Location = new System.Drawing.Point(182, 39);
            this.lblCapitulos.Name = "lblCapitulos";
            this.lblCapitulos.Size = new System.Drawing.Size(101, 17);
            this.lblCapitulos.TabIndex = 5;
            this.lblCapitulos.Text = "<SELECIONE>";
            // 
            // cbbCapitulo
            // 
            this.cbbCapitulo.DropDownHeight = 200;
            this.cbbCapitulo.DropDownWidth = 400;
            this.cbbCapitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCapitulo.FormattingEnabled = true;
            this.cbbCapitulo.IntegralHeight = false;
            this.cbbCapitulo.Location = new System.Drawing.Point(6, 36);
            this.cbbCapitulo.Name = "cbbCapitulo";
            this.cbbCapitulo.Size = new System.Drawing.Size(170, 24);
            this.cbbCapitulo.TabIndex = 4;
            this.cbbCapitulo.Text = "<SELECIONE>";
            this.cbbCapitulo.SelectedValueChanged += new System.EventHandler(this.cbbCapitulo_SelectedValueChanged);
            // 
            // dgvCapitulosTags
            // 
            this.dgvCapitulosTags.AllowUserToAddRows = false;
            this.dgvCapitulosTags.AllowUserToDeleteRows = false;
            this.dgvCapitulosTags.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapitulosTags.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCapitulosTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapitulosTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.capitulo,
            this.tag});
            this.dgvCapitulosTags.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCapitulosTags.Location = new System.Drawing.Point(3, 66);
            this.dgvCapitulosTags.Name = "dgvCapitulosTags";
            this.dgvCapitulosTags.ReadOnly = true;
            this.dgvCapitulosTags.RowHeadersWidth = 51;
            this.dgvCapitulosTags.RowTemplate.Height = 24;
            this.dgvCapitulosTags.Size = new System.Drawing.Size(1038, 410);
            this.dgvCapitulosTags.TabIndex = 6;
            // 
            // capitulo
            // 
            this.capitulo.HeaderText = "Capítulo";
            this.capitulo.MinimumWidth = 6;
            this.capitulo.Name = "capitulo";
            this.capitulo.ReadOnly = true;
            // 
            // tag
            // 
            this.tag.HeaderText = "Tag";
            this.tag.MinimumWidth = 6;
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            // 
            // frmLIstas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(1052, 558);
            this.Controls.Add(this.tbcListas);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLIstas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listas úteis";
            this.Shown += new System.EventHandler(this.frmLIstas_Shown);
            this.pnlMenu.ResumeLayout(false);
            this.tbcListas.ResumeLayout(false);
            this.tbpFatosOrigem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatosOrigem)).EndInit();
            this.tbpCapitulosTags.ResumeLayout(false);
            this.tbpCapitulosTags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapitulosTags)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TabControl tbcListas;
        private System.Windows.Forms.TabPage tbpFatosOrigem;
        private System.Windows.Forms.TabPage tbpCapitulosTags;
        private System.Windows.Forms.DataGridView dgvFatosOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn fato;
        private System.Windows.Forms.DataGridViewCheckBoxColumn financas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn persona;
        private System.Windows.Forms.DataGridViewCheckBoxColumn scritta;
        private System.Windows.Forms.Label lblFatos;
        private System.Windows.Forms.ComboBox cbbFatos;
        private System.Windows.Forms.Label lblCapitulos;
        private System.Windows.Forms.ComboBox cbbCapitulo;
        private System.Windows.Forms.DataGridView dgvCapitulosTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
    }
}