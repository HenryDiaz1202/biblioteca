namespace Biblioteca.FormulariosCrud
{
    partial class FrmEditAutorDocumento
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtUpdateActs = new System.Windows.Forms.DataGridView();
            this.IdDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbAutoresList = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dtAutoresDoc = new System.Windows.Forms.DataGridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdDocm = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtUpdateActs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAutoresDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdDocm.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(561, 572);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.dtUpdateActs);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.cbAutoresList);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.dtAutoresDoc);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.txtIdDocm);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 545);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl4.Location = new System.Drawing.Point(16, 302);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(171, 19);
            this.labelControl4.TabIndex = 44;
            this.labelControl4.Text = "Lista de autores, nuevos";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl3.Location = new System.Drawing.Point(16, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(177, 19);
            this.labelControl3.TabIndex = 43;
            this.labelControl3.Text = "Lista de autores, actuales";
            // 
            // dtUpdateActs
            // 
            this.dtUpdateActs.AllowUserToAddRows = false;
            this.dtUpdateActs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtUpdateActs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUpdateActs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDocumento,
            this.IdAutor});
            this.dtUpdateActs.Location = new System.Drawing.Point(16, 332);
            this.dtUpdateActs.Name = "dtUpdateActs";
            this.dtUpdateActs.ReadOnly = true;
            this.dtUpdateActs.Size = new System.Drawing.Size(497, 163);
            this.dtUpdateActs.TabIndex = 42;
            this.dtUpdateActs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtUpdateActs_CellContentClick);
            // 
            // IdDocumento
            // 
            this.IdDocumento.HeaderText = "Id de Documento";
            this.IdDocumento.Name = "IdDocumento";
            this.IdDocumento.ReadOnly = true;
            // 
            // IdAutor
            // 
            this.IdAutor.HeaderText = "Id de Autor";
            this.IdAutor.Name = "IdAutor";
            this.IdAutor.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Biblioteca.Properties.Resources._1282956_close_delete_deny_no_out_icon;
            this.pictureBox1.Location = new System.Drawing.Point(488, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(399, 501);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 37);
            this.btnGuardar.TabIndex = 38;
            this.btnGuardar.Text = "Actualizar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbAutoresList
            // 
            this.cbAutoresList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutoresList.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.cbAutoresList.FormattingEnabled = true;
            this.cbAutoresList.Location = new System.Drawing.Point(186, 51);
            this.cbAutoresList.Name = "cbAutoresList";
            this.cbAutoresList.Size = new System.Drawing.Size(327, 31);
            this.cbAutoresList.TabIndex = 36;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.button3.Location = new System.Drawing.Point(416, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 40);
            this.button3.TabIndex = 35;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtAutoresDoc
            // 
            this.dtAutoresDoc.AllowUserToAddRows = false;
            this.dtAutoresDoc.AllowUserToDeleteRows = false;
            this.dtAutoresDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtAutoresDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAutoresDoc.Location = new System.Drawing.Point(16, 147);
            this.dtAutoresDoc.Name = "dtAutoresDoc";
            this.dtAutoresDoc.ReadOnly = true;
            this.dtAutoresDoc.Size = new System.Drawing.Size(497, 144);
            this.dtAutoresDoc.TabIndex = 31;
            this.dtAutoresDoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAutoresDoc_CellContentClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl1.Location = new System.Drawing.Point(186, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 19);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Autores";
            // 
            // txtIdDocm
            // 
            this.txtIdDocm.Location = new System.Drawing.Point(16, 52);
            this.txtIdDocm.Name = "txtIdDocm";
            this.txtIdDocm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtIdDocm.Properties.Appearance.Options.UseFont = true;
            this.txtIdDocm.Properties.ReadOnly = true;
            this.txtIdDocm.Size = new System.Drawing.Size(152, 30);
            this.txtIdDocm.TabIndex = 27;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl2.Location = new System.Drawing.Point(16, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(156, 19);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Código de documento";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(21, 509);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 13);
            this.linkLabel1.TabIndex = 45;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Limpiar datos";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // FrmEditAutorDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 572);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditAutorDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditAutorDocumento";
            this.Load += new System.EventHandler(this.FrmEditAutorDocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtUpdateActs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAutoresDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdDocm.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbAutoresList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtAutoresDoc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit txtIdDocm;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DataGridView dtUpdateActs;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAutor;
        private System.Windows.Forms.LinkLabel linkLabel1;

    }
}