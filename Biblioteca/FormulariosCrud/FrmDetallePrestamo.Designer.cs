namespace Biblioteca.FormulariosCrud
{
    partial class FrmDetallePrestamo
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
            this.txtIdPrestamo = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.dtRegistro = new System.Windows.Forms.DataGridView();
            this.IdPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dtCargar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdPrestamo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCargar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(971, 429);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtIdPrestamo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.searchControl1);
            this.panel1.Controls.Add(this.dtRegistro);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtCargar);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 364);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.Location = new System.Drawing.Point(18, 63);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtIdPrestamo.Properties.Appearance.Options.UseFont = true;
            this.txtIdPrestamo.Properties.ReadOnly = true;
            this.txtIdPrestamo.Size = new System.Drawing.Size(115, 30);
            this.txtIdPrestamo.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.button1.Location = new System.Drawing.Point(178, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 38);
            this.button1.TabIndex = 53;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtCantidad.Location = new System.Drawing.Point(734, 61);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(196, 29);
            this.txtCantidad.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label6.Location = new System.Drawing.Point(730, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "Cantidad";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(566, 306);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(162, 37);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(734, 306);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(196, 37);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Biblioteca.Properties.Resources._3069190_search_research_icon__1_;
            this.button3.Location = new System.Drawing.Point(521, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 27);
            this.button3.TabIndex = 43;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(158, 62);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.NullValuePrompt = "Ingrese título del documento a buscar ...";
            this.searchControl1.Size = new System.Drawing.Size(357, 30);
            this.searchControl1.TabIndex = 42;
            // 
            // dtRegistro
            // 
            this.dtRegistro.AllowUserToAddRows = false;
            this.dtRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPrestamo,
            this.IdDoc,
            this.Titu,
            this.Cantidad,
            this.newD});
            this.dtRegistro.Location = new System.Drawing.Point(483, 99);
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.ReadOnly = true;
            this.dtRegistro.Size = new System.Drawing.Size(447, 194);
            this.dtRegistro.TabIndex = 33;
            // 
            // IdPrestamo
            // 
            this.IdPrestamo.HeaderText = "Préstamo";
            this.IdPrestamo.Name = "IdPrestamo";
            this.IdPrestamo.ReadOnly = true;
            // 
            // IdDoc
            // 
            this.IdDoc.HeaderText = "Documento";
            this.IdDoc.Name = "IdDoc";
            this.IdDoc.ReadOnly = true;
            // 
            // Titu
            // 
            this.Titu.HeaderText = "Título";
            this.Titu.Name = "Titu";
            this.Titu.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // newD
            // 
            this.newD.HeaderText = "newD";
            this.newD.Name = "newD";
            this.newD.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label2.Location = new System.Drawing.Point(154, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Documentos (Título)";
            // 
            // dtCargar
            // 
            this.dtCargar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCargar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCargar.Location = new System.Drawing.Point(18, 99);
            this.dtCargar.Name = "dtCargar";
            this.dtCargar.Size = new System.Drawing.Size(459, 194);
            this.dtCargar.TabIndex = 28;
            this.dtCargar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCargar_CellContentClick);
            // 
            // FrmDetallePrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 429);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetallePrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDetallePrestamo";
            this.Load += new System.EventHandler(this.FrmDetallePrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdPrestamo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCargar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private System.Windows.Forms.DataGridView dtRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtCargar;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Button button1;
        public DevExpress.XtraEditors.TextEdit txtIdPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn newD;
    }
}