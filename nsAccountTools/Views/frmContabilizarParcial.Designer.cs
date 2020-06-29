namespace nsAccountTools.Views
{
    partial class frmContabilizarParcial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContabilizarParcial));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlComponents = new System.Windows.Forms.Panel();
            this.cbbGrupo = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cbbEmpresa = new System.Windows.Forms.ComboBox();
            this.lblEstabelecimento = new System.Windows.Forms.Label();
            this.cbbEstabelecimento = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbbTipo = new System.Windows.Forms.ComboBox();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpDataTermino = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblDataTermino = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlComponents.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(900, 50);
            this.pnlMenu.TabIndex = 3;
            // 
            // pnlComponents
            // 
            this.pnlComponents.Controls.Add(this.pnlDate);
            this.pnlComponents.Controls.Add(this.lblTipo);
            this.pnlComponents.Controls.Add(this.cbbTipo);
            this.pnlComponents.Controls.Add(this.lblEstabelecimento);
            this.pnlComponents.Controls.Add(this.cbbEstabelecimento);
            this.pnlComponents.Controls.Add(this.lblEmpresa);
            this.pnlComponents.Controls.Add(this.cbbEmpresa);
            this.pnlComponents.Controls.Add(this.lblGrupo);
            this.pnlComponents.Controls.Add(this.cbbGrupo);
            this.pnlComponents.Location = new System.Drawing.Point(0, 57);
            this.pnlComponents.Name = "pnlComponents";
            this.pnlComponents.Size = new System.Drawing.Size(900, 140);
            this.pnlComponents.TabIndex = 4;
            // 
            // cbbGrupo
            // 
            this.cbbGrupo.DropDownHeight = 110;
            this.cbbGrupo.DropDownWidth = 200;
            this.cbbGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbGrupo.FormattingEnabled = true;
            this.cbbGrupo.IntegralHeight = false;
            this.cbbGrupo.Location = new System.Drawing.Point(12, 15);
            this.cbbGrupo.Name = "cbbGrupo";
            this.cbbGrupo.Size = new System.Drawing.Size(170, 24);
            this.cbbGrupo.TabIndex = 0;
            this.cbbGrupo.SelectedIndexChanged += new System.EventHandler(this.cbbGrupo_SelectedIndexChanged);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGrupo.Location = new System.Drawing.Point(188, 18);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(101, 17);
            this.lblGrupo.TabIndex = 1;
            this.lblGrupo.Text = "<SELECIONE>";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmpresa.Location = new System.Drawing.Point(188, 48);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(101, 17);
            this.lblEmpresa.TabIndex = 3;
            this.lblEmpresa.Text = "<SELECIONE>";
            // 
            // cbbEmpresa
            // 
            this.cbbEmpresa.DropDownHeight = 110;
            this.cbbEmpresa.DropDownWidth = 200;
            this.cbbEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbEmpresa.FormattingEnabled = true;
            this.cbbEmpresa.IntegralHeight = false;
            this.cbbEmpresa.Location = new System.Drawing.Point(12, 45);
            this.cbbEmpresa.Name = "cbbEmpresa";
            this.cbbEmpresa.Size = new System.Drawing.Size(170, 24);
            this.cbbEmpresa.TabIndex = 1;
            this.cbbEmpresa.SelectedValueChanged += new System.EventHandler(this.cbbEmpresa_SelectedValueChanged);
            // 
            // lblEstabelecimento
            // 
            this.lblEstabelecimento.AutoSize = true;
            this.lblEstabelecimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEstabelecimento.Location = new System.Drawing.Point(188, 78);
            this.lblEstabelecimento.Name = "lblEstabelecimento";
            this.lblEstabelecimento.Size = new System.Drawing.Size(101, 17);
            this.lblEstabelecimento.TabIndex = 5;
            this.lblEstabelecimento.Text = "<SELECIONE>";
            // 
            // cbbEstabelecimento
            // 
            this.cbbEstabelecimento.DropDownHeight = 110;
            this.cbbEstabelecimento.DropDownWidth = 200;
            this.cbbEstabelecimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbEstabelecimento.FormattingEnabled = true;
            this.cbbEstabelecimento.IntegralHeight = false;
            this.cbbEstabelecimento.Location = new System.Drawing.Point(12, 75);
            this.cbbEstabelecimento.Name = "cbbEstabelecimento";
            this.cbbEstabelecimento.Size = new System.Drawing.Size(170, 24);
            this.cbbEstabelecimento.TabIndex = 2;
            this.cbbEstabelecimento.SelectedValueChanged += new System.EventHandler(this.cbbEstabelecimento_SelectedValueChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipo.Location = new System.Drawing.Point(188, 108);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(101, 17);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "<SELECIONE>";
            // 
            // cbbTipo
            // 
            this.cbbTipo.DropDownHeight = 110;
            this.cbbTipo.DropDownWidth = 200;
            this.cbbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.IntegralHeight = false;
            this.cbbTipo.Location = new System.Drawing.Point(12, 105);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(170, 24);
            this.cbbTipo.TabIndex = 3;
            this.cbbTipo.SelectedValueChanged += new System.EventHandler(this.cbbTipo_SelectedValueChanged);
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.lblDataTermino);
            this.pnlDate.Controls.Add(this.lblInicio);
            this.pnlDate.Controls.Add(this.dtpDataTermino);
            this.pnlDate.Controls.Add(this.dtpDataInicio);
            this.pnlDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDate.Location = new System.Drawing.Point(688, 0);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(212, 140);
            this.pnlDate.TabIndex = 9;
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(6, 43);
            this.dtpDataInicio.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(200, 22);
            this.dtpDataInicio.TabIndex = 4;
            // 
            // dtpDataTermino
            // 
            this.dtpDataTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataTermino.Location = new System.Drawing.Point(6, 103);
            this.dtpDataTermino.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpDataTermino.Name = "dtpDataTermino";
            this.dtpDataTermino.Size = new System.Drawing.Size(200, 22);
            this.dtpDataTermino.TabIndex = 5;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInicio.Location = new System.Drawing.Point(3, 18);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(94, 17);
            this.lblInicio.TabIndex = 11;
            this.lblInicio.Text = "Data de Início";
            // 
            // lblDataTermino
            // 
            this.lblDataTermino.AutoSize = true;
            this.lblDataTermino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDataTermino.Location = new System.Drawing.Point(3, 78);
            this.lblDataTermino.Name = "lblDataTermino";
            this.lblDataTermino.Size = new System.Drawing.Size(114, 17);
            this.lblDataTermino.TabIndex = 12;
            this.lblDataTermino.Text = "Data de Término";
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::nsAccountTools.Properties.Resources.exit;
            this.btnSair.Location = new System.Drawing.Point(800, 0);
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
            this.panel1.Controls.Add(this.btnProcessar);
            this.panel1.Location = new System.Drawing.Point(0, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 50);
            this.panel1.TabIndex = 5;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcessar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProcessar.FlatAppearance.BorderSize = 0;
            this.btnProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessar.Image = global::nsAccountTools.Properties.Resources.thunder;
            this.btnProcessar.Location = new System.Drawing.Point(0, 0);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(900, 50);
            this.btnProcessar.TabIndex = 0;
            this.btnProcessar.TabStop = false;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Location = new System.Drawing.Point(0, 257);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(900, 334);
            this.lblStatus.TabIndex = 6;
            // 
            // frmContabilizarParcial
            // 
            this.AcceptButton = this.btnProcessar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlComponents);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmContabilizarParcial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contabilização Parcial da Folha";
            this.Shown += new System.EventHandler(this.frmContabilizarParcial_Shown);
            this.pnlMenu.ResumeLayout(false);
            this.pnlComponents.ResumeLayout(false);
            this.pnlComponents.PerformLayout();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel pnlComponents;
        private System.Windows.Forms.ComboBox cbbGrupo;
        private System.Windows.Forms.Label lblEstabelecimento;
        private System.Windows.Forms.ComboBox cbbEstabelecimento;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cbbEmpresa;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbbTipo;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.Label lblDataTermino;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpDataTermino;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Label lblStatus;
    }
}