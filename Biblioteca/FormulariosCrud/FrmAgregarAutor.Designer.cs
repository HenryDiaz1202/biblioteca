namespace Biblioteca.FormulariosCrud
{
    partial class FrmAgregarAutor
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbNacionalidad = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtApellidos = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombres = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdAutor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAutor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(883, 358);
            this.panelControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.cbNacionalidad);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.txtNombres);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.txtIdAutor);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(67, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 312);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBox2.Location = new System.Drawing.Point(14, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(542, 1);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca.Properties.Resources.ruben;
            this.pictureBox1.Location = new System.Drawing.Point(14, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(489, 241);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 37);
            this.btnCancelar.TabIndex = 13;
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
            this.btnGuardar.Location = new System.Drawing.Point(609, 241);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 37);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbNacionalidad
            // 
            this.cbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNacionalidad.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.cbNacionalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbNacionalidad.FormattingEnabled = true;
            this.cbNacionalidad.Items.AddRange(new object[] {
            "Afgano",
            "Albanés",
            "Alemán",
            "Andorrano",
            "Angola",
            "Antigua o Barbudan",
            "Arabia Saudita",
            "Argelino",
            "Argentina",
            "armenio",
            "Australiano",
            "Austriaco",
            "Azerbaiyano, azerí",
            "Bahameño",
            "Bahrein",
            "Barbados",
            "Basotho",
            "Belga",
            "Beliceño",
            "bengalí",
            "Beninés, Beninois",
            "Bielorruso",
            "birmano",
            "Bissau-Guineano",
            "boliviano",
            "Bosnio o herzegovinio",
            "brasileño",
            "Bruneián",
            "Bulgarian",
            "Burkinabé",
            "Burundiano",
            "Butanés",
            "Cabo Verde",
            "Camboyano",
            "camerunés",
            "canadiense",
            "Centroafricano",
            "Chadiano",
            "Checo",
            "Chileno",
            "Chino",
            "Chipriota",
            "colombianas",
            "Comoras, comorenses",
            "congoleña",
            "congoleña",
            "Costa Rica",
            "croata",
            "Cubano",
            "danés",
            "de Sri Lanka",
            "Djibouti",
            "Dominicanas",
            "Dominicanas",
            "Ecuatoguineano, ecuatoguineano",
            "ecuatoriano",
            "Egipcio",
            "Emirati, Emirian, Emiri",
            "Eritreo",
            "Esloveno, esloveno",
            "Español",
            "Estadounidense",
            "Estonia",
            "etíope",
            "Fijian",
            "Filipino",
            "Finnish",
            "Francés",
            "Gabonés",
            "Gambiano",
            "georgiano",
            "ghanés",
            "Gibraltar",
            "Granada",
            "Griego, helénico",
            "guatemalteco",
            "Guineano",
            "Guyana",
            "Holandés, neerlandés",
            "hondureña",
            "Húngaro, Magyar",
            "I-Kiribati",
            "indio",
            "Indonesian",
            "Iraní, persa",
            "iraquí",
            "irlandés",
            "islandés",
            "Islas Marshall",
            "israelí",
            "Italiano",
            "jamaicano",
            "Japonés",
            "Jordano",
            "Kazajo, kazajo",
            "Keniano",
            "Kirguistán, Kirguistán, Kirgiz, Kirguizistán",
            "Kittitian o Nevisian",
            "Kuwaití",
            "Lao, laosiano",
            "Letón, Lettish",
            "libanés",
            "Liberiano",
            "Libio",
            "Liechtenstein",
            "lituano",
            "Luxemburgo, luxemburgués",
            "macedonio",
            "madagascarí",
            "Malasio",
            "Malawiano",
            "Maldivas",
            "Maliense, Malinés",
            "maltés",
            "Marfileño",
            "Marfileño",
            "Marianan del norte",
            "marroquí",
            "Martiniquais, Martinica",
            "mauriciano",
            "mauritano",
            "Mexicano",
            "Micronesia",
            "Moldavo",
            "Monégasque, Monacan",
            "mongol",
            "montenegrino",
            "Motswana, Botswana",
            "mozambiqueño",
            "namibio",
            "nauruana",
            "Nepalí, nepalí",
            "nicaragüense",
            "Nigeriano",
            "Nigeriano",
            "Norcoreano",
            "Norwegian",
            "Nueva Zelanda, Zelanian",
            "omaní",
            "Palauan",
            "palestino",
            "panameño",
            "Papua Nueva Guinea, Papuan",
            "Paquistaní",
            "paraguayo",
            "peruano",
            "polaco",
            "Portuguese",
            "puertorriqueño",
            "Qatar",
            "Reino Unido, Británico",
            "Ruandés",
            "rumano",
            "Ruso",
            "Saint Lucian",
            "salvadoreño",
            "Sammarinese",
            "Samoano",
            "San Vicente, Vicentino",
            "São Toméan",
            "Senegal",
            "serbio",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Sirio",
            "Slovak",
            "Solomon Island",
            "somalí",
            "sudafricano",
            "Sudán del sur",
            "sudanés",
            "suizo",
            "Surcoreano",
            "surinamés",
            "Swazi",
            "Swedish",
            "Tajikistani",
            "Tanzania",
            "Thai",
            "Timorense",
            "Timorense",
            "Togolés",
            "Tokelauan",
            "Tonga",
            "Trinidad y Tobago",
            "tunecino",
            "turco",
            "Turkmenistán",
            "tuvaluano",
            "ucranio",
            "Uganda",
            "uruguayo",
            "Uzbeko, uzbeko",
            "venezolano",
            "vietnamita",
            "yemenita",
            "Zambia",
            "zimbabuo"});
            this.cbNacionalidad.Location = new System.Drawing.Point(457, 179);
            this.cbNacionalidad.Name = "cbNacionalidad";
            this.cbNacionalidad.Size = new System.Drawing.Size(266, 31);
            this.cbNacionalidad.Sorted = true;
            this.cbNacionalidad.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl5.Location = new System.Drawing.Point(457, 147);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(90, 19);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Nacionalidad";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(457, 94);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtApellidos.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidos.Properties.Appearance.Options.UseFont = true;
            this.txtApellidos.Properties.Appearance.Options.UseForeColor = true;
            this.txtApellidos.Size = new System.Drawing.Size(266, 30);
            this.txtApellidos.TabIndex = 9;
            this.txtApellidos.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl4.Location = new System.Drawing.Point(457, 61);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 19);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Apellidos";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(186, 180);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtNombres.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombres.Properties.Appearance.Options.UseFont = true;
            this.txtNombres.Properties.Appearance.Options.UseForeColor = true;
            this.txtNombres.Size = new System.Drawing.Size(245, 30);
            this.txtNombres.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl3.Location = new System.Drawing.Point(197, 147);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 19);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Nombres";
            // 
            // txtIdAutor
            // 
            this.txtIdAutor.Location = new System.Drawing.Point(186, 94);
            this.txtIdAutor.Name = "txtIdAutor";
            this.txtIdAutor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtIdAutor.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdAutor.Properties.Appearance.Options.UseFont = true;
            this.txtIdAutor.Properties.Appearance.Options.UseForeColor = true;
            this.txtIdAutor.Size = new System.Drawing.Size(245, 30);
            this.txtIdAutor.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl2.Location = new System.Drawing.Point(186, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(114, 19);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Código de autor";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.25F);
            this.labelControl1.Location = new System.Drawing.Point(14, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(146, 27);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Registrar autor";
            // 
            // FrmAgregarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 358);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmAgregarAutor";
            this.Text = "FrmAgregarAutor";
            this.Load += new System.EventHandler(this.FrmAgregarAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAutor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbNacionalidad;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtApellidos;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNombres;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtIdAutor;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}