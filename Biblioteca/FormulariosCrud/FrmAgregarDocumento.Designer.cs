namespace Biblioteca.FormulariosCrud
{
    partial class FrmAgregarDocumento
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
            this.txtNumPaginas = new System.Windows.Forms.NumericUpDown();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtObservacion = new System.Windows.Forms.RichTextBox();
            this.dtRegistro = new System.Windows.Forms.DateTimePicker();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dtPublicacion = new System.Windows.Forms.DateTimePicker();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTitulo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdDoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidadRegistro = new System.Windows.Forms.NumericUpDown();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1064, 467);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtCantidadRegistro);
            this.panel1.Controls.Add(this.labelControl9);
            this.panel1.Controls.Add(this.txtNumPaginas);
            this.panel1.Controls.Add(this.cbCategoria);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.txtObservacion);
            this.panel1.Controls.Add(this.dtRegistro);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.dtPublicacion);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.txtIdDoc);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(37, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 408);
            this.panel1.TabIndex = 4;
            // 
            // txtNumPaginas
            // 
            this.txtNumPaginas.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtNumPaginas.Location = new System.Drawing.Point(647, 174);
            this.txtNumPaginas.Name = "txtNumPaginas";
            this.txtNumPaginas.Size = new System.Drawing.Size(149, 30);
            this.txtNumPaginas.TabIndex = 27;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.cbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "LIBRO",
            "DOCUMENTO",
            "MONOGRAFÍA",
            "FOLLETO",
            "REVISTA",
            "INVESTIGACIÓN"});
            this.cbCategoria.Location = new System.Drawing.Point(647, 254);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(297, 31);
            this.cbCategoria.TabIndex = 26;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl5.Location = new System.Drawing.Point(647, 221);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 19);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Categoría";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl4.Location = new System.Drawing.Point(647, 130);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(79, 38);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Número de \r\npáginas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(647, 337);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 37);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(802, 337);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(142, 37);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca.Properties.Resources.libros;
            this.pictureBox1.Location = new System.Drawing.Point(26, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBox2.Location = new System.Drawing.Point(26, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(542, 1);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl8.Location = new System.Drawing.Point(259, 305);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(87, 19);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "Observación";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtObservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtObservacion.Location = new System.Drawing.Point(259, 330);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(358, 54);
            this.txtObservacion.TabIndex = 18;
            this.txtObservacion.Text = "";
            // 
            // dtRegistro
            // 
            this.dtRegistro.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.dtRegistro.Location = new System.Drawing.Point(259, 255);
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.Size = new System.Drawing.Size(358, 30);
            this.dtRegistro.TabIndex = 17;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl7.Location = new System.Drawing.Point(259, 220);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(121, 19);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Fecha de registro";
            // 
            // dtPublicacion
            // 
            this.dtPublicacion.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.dtPublicacion.Location = new System.Drawing.Point(259, 173);
            this.dtPublicacion.Name = "dtPublicacion";
            this.dtPublicacion.Size = new System.Drawing.Size(358, 30);
            this.dtPublicacion.TabIndex = 15;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl6.Location = new System.Drawing.Point(259, 139);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(146, 19);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Fecha de publicación";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(576, 94);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtTitulo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTitulo.Properties.Appearance.Options.UseFont = true;
            this.txtTitulo.Properties.Appearance.Options.UseForeColor = true;
            this.txtTitulo.Size = new System.Drawing.Size(368, 30);
            this.txtTitulo.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl3.Location = new System.Drawing.Point(576, 66);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 19);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Título";
            // 
            // txtIdDoc
            // 
            this.txtIdDoc.Location = new System.Drawing.Point(259, 94);
            this.txtIdDoc.Name = "txtIdDoc";
            this.txtIdDoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtIdDoc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdDoc.Properties.Appearance.Options.UseFont = true;
            this.txtIdDoc.Properties.Appearance.Options.UseForeColor = true;
            this.txtIdDoc.Size = new System.Drawing.Size(297, 30);
            this.txtIdDoc.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl2.Location = new System.Drawing.Point(259, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(156, 19);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Código de documento";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.25F);
            this.labelControl1.Location = new System.Drawing.Point(26, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(202, 27);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Registrar documento";
            // 
            // txtCantidadRegistro
            // 
            this.txtCantidadRegistro.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtCantidadRegistro.Location = new System.Drawing.Point(802, 174);
            this.txtCantidadRegistro.Name = "txtCantidadRegistro";
            this.txtCantidadRegistro.Size = new System.Drawing.Size(142, 30);
            this.txtCantidadRegistro.TabIndex = 29;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl9.Location = new System.Drawing.Point(802, 130);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(72, 38);
            this.labelControl9.TabIndex = 28;
            this.labelControl9.Text = "Cantidad \r\na registrar";
            // 
            // FrmAgregarDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 467);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmAgregarDocumento";
            this.Text = "FrmAgregarDocumento";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtRegistro;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.DateTimePicker dtPublicacion;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtTitulo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtIdDoc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.RichTextBox txtObservacion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbCategoria;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.NumericUpDown txtNumPaginas;
        private System.Windows.Forms.NumericUpDown txtCantidadRegistro;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}