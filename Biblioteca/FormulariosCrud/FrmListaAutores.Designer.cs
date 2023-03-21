namespace Biblioteca.FormulariosCrud
{
    partial class FrmListaAutores
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
            this.cbNacionalidad = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtApellidos = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombres = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdAutor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAutor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(883, 541);
            this.panelControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbNacionalidad);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.txtNombres);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.txtIdAutor);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.searchControl1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(69, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 517);
            this.panel1.TabIndex = 1;
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
            "Argelino",
            "Andorrano",
            "Angola",
            "Antigua o Barbudan",
            "Argentina",
            "armenio",
            "Australiano",
            "Austriaco",
            "Azerbaiyano, azerí",
            "Bahameño",
            "Bahrein",
            "bengalí",
            "Barbados",
            "Bielorruso",
            "Belga",
            "Beliceño",
            "Beninés, Beninois",
            "Butanés",
            "boliviano",
            "Bosnio o herzegovinio",
            "Motswana, Botswana",
            "brasileño",
            "Bruneián",
            "Bulgarian",
            "Burkinabé",
            "birmano",
            "Burundiano",
            "Cabo Verde",
            "Camboyano",
            "camerunés",
            "canadiense",
            "Centroafricano",
            "Chadiano",
            "Chileno",
            "Chino",
            "colombianas",
            "Comoras, comorenses",
            "congoleña",
            "congoleña",
            "Costa Rica",
            "Marfileño",
            "croata",
            "Cubano",
            "Chipriota",
            "Checo",
            "danés",
            "Djibouti",
            "Dominicanas",
            "Dominicanas",
            "Timorense",
            "ecuatoriano",
            "Egipcio",
            "salvadoreño",
            "Ecuatoguineano, ecuatoguineano",
            "Eritreo",
            "Estonia",
            "etíope",
            "Fijian",
            "Finnish",
            "Francés",
            "Gabonés",
            "Gambiano",
            "georgiano",
            "Alemán",
            "ghanés",
            "Gibraltar",
            "Griego, helénico",
            "Granada",
            "guatemalteco",
            "Guineano",
            "Bissau-Guineano",
            "Guyana",
            "danza del África Occidental, danza afro haitiana,",
            "hondureña",
            "Húngaro, Magyar",
            "islandés",
            "indio",
            "Indonesian",
            "Iraní, persa",
            "iraquí",
            "irlandés",
            "israelí",
            "Italiano",
            "Marfileño",
            "jamaicano",
            "Japonés",
            "Jordano",
            "Kazajo, kazajo",
            "Keniano",
            "I-Kiribati",
            "Norcoreano",
            "Surcoreano",
            "Kuwaití",
            "Kirguistán, Kirguistán, Kirgiz, Kirguizistán",
            "Lao, laosiano",
            "Letón, Lettish",
            "libanés",
            "Basotho",
            "Liberiano",
            "Libio",
            "Liechtenstein",
            "lituano",
            "Luxemburgo, luxemburgués",
            "macedonio",
            "madagascarí",
            "Malawiano",
            "Malasio",
            "Maldivas",
            "Maliense, Malinés",
            "maltés",
            "Islas Marshall",
            "Martiniquais, Martinica",
            "mauritano",
            "mauriciano",
            "Mexicano",
            "Micronesia",
            "Moldavo",
            "Monégasque, Monacan",
            "mongol",
            "montenegrino",
            "marroquí",
            "mozambiqueño",
            "namibio",
            "nauruana",
            "Nepalí, nepalí",
            "Holandés, neerlandés",
            "Nueva Zelanda, Nueva Zelanda, Zelanian",
            "nicaragüense",
            "Nigeriano",
            "Nigeriano",
            "Marianan del norte",
            "Norwegian",
            "omaní",
            "Paquistaní",
            "Palauan",
            "palestino",
            "panameño",
            "Papua Nueva Guinea, Papuan",
            "paraguayo",
            "peruano",
            "Filipino, filipino",
            "polaco",
            "Portuguese",
            "puertorriqueño",
            "Qatar",
            "rumano",
            "Ruso",
            "Ruandés",
            "Kittitian o Nevisian",
            "Saint Lucian",
            "San Vicente, Vicentino",
            "Samoano",
            "Sammarinese",
            "São Toméan",
            "Arabia Saudita, Arabia Saudita",
            "Senegal",
            "serbio",
            "Seychelles",
            "Sierra Leona",
            "Singapur, Singapur",
            "Slovak",
            "Esloveno, esloveno",
            "Solomon Island",
            "somalí",
            "sudafricano",
            "Sudán del sur",
            "Español",
            "de Sri Lanka",
            "sudanés",
            "surinamés",
            "Swazi",
            "Swedish",
            "suizo",
            "Sirio",
            "Tajikistani",
            "Tanzania",
            "Thai",
            "Timorense",
            "Togolés",
            "Tokelauan",
            "Tonga",
            "Trinidad y Tobago",
            "tunecino",
            "turco",
            "Turkmenistán",
            "tuvaluano",
            "Uganda",
            "ucranio",
            "Emirati, Emirian, Emiri",
            "Reino Unido, Británico",
            "Estadounidense",
            "uruguayo",
            "Uzbeko, uzbeko",
            "venezolano",
            "vietnamita",
            "yemenita",
            "Zambia",
            "zimbabuo"});
            this.cbNacionalidad.Location = new System.Drawing.Point(319, 218);
            this.cbNacionalidad.Name = "cbNacionalidad";
            this.cbNacionalidad.Size = new System.Drawing.Size(266, 31);
            this.cbNacionalidad.TabIndex = 30;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton1.Location = new System.Drawing.Point(607, 76);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 23);
            this.simpleButton1.TabIndex = 29;
            this.simpleButton1.Text = "Actualizar formulario";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Biblioteca.Properties.Resources._3069190_search_research_icon__1_;
            this.button1.Location = new System.Drawing.Point(388, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 27);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(607, 211);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 37);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Eliminar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Blue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(607, 145);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 37);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Actualizar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBox2.Location = new System.Drawing.Point(21, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(542, 1);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl5.Location = new System.Drawing.Point(319, 188);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(90, 19);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Nacionalidad";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(319, 149);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtApellidos.Properties.Appearance.Options.UseFont = true;
            this.txtApellidos.Size = new System.Drawing.Size(266, 30);
            this.txtApellidos.TabIndex = 19;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl4.Location = new System.Drawing.Point(319, 119);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 19);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Apellidos";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(21, 218);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtNombres.Properties.Appearance.Options.UseFont = true;
            this.txtNombres.Size = new System.Drawing.Size(271, 30);
            this.txtNombres.TabIndex = 17;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl3.Location = new System.Drawing.Point(21, 188);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 19);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Nombres";
            // 
            // txtIdAutor
            // 
            this.txtIdAutor.Location = new System.Drawing.Point(21, 149);
            this.txtIdAutor.Name = "txtIdAutor";
            this.txtIdAutor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtIdAutor.Properties.Appearance.Options.UseFont = true;
            this.txtIdAutor.Properties.ReadOnly = true;
            this.txtIdAutor.Size = new System.Drawing.Size(271, 30);
            this.txtIdAutor.TabIndex = 15;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl2.Location = new System.Drawing.Point(21, 119);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(114, 19);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Código de autor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(700, 232);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(21, 69);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.NullValuePrompt = "Ingrese nombre de autor a buscar ...";
            this.searchControl1.Size = new System.Drawing.Size(361, 30);
            this.searchControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.25F);
            this.labelControl1.Location = new System.Drawing.Point(21, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(271, 27);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Lista de autores registrados";
            // 
            // FrmListaAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 541);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmListaAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListaAutores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListaAutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAutor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtApellidos;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNombres;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtIdAutor;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox cbNacionalidad;


    }
}