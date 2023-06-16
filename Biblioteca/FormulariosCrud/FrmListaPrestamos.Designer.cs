namespace Biblioteca.FormulariosCrud
{
    partial class FrmListaPrestamos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tmHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.tmHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtIdPrestamo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtIdLector = new System.Windows.Forms.TextBox();
            this.cbLector = new System.Windows.Forms.ComboBox();
            this.dtPrestamo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdPrestamo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(893, 522);
            this.panelControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.tmHoraSalida);
            this.panel1.Controls.Add(this.tmHoraEntrada);
            this.panel1.Controls.Add(this.txtIdPrestamo);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtIdLector);
            this.panel1.Controls.Add(this.cbLector);
            this.panel1.Controls.Add(this.dtPrestamo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 498);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(849, 207);
            this.dataGridView1.TabIndex = 55;
            // 
            // tmHoraSalida
            // 
            this.tmHoraSalida.CalendarFont = new System.Drawing.Font("Tahoma", 10.25F);
            this.tmHoraSalida.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.tmHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tmHoraSalida.Location = new System.Drawing.Point(161, 189);
            this.tmHoraSalida.Name = "tmHoraSalida";
            this.tmHoraSalida.Size = new System.Drawing.Size(139, 30);
            this.tmHoraSalida.TabIndex = 54;
            // 
            // tmHoraEntrada
            // 
            this.tmHoraEntrada.CalendarFont = new System.Drawing.Font("Tahoma", 10.25F);
            this.tmHoraEntrada.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.tmHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tmHoraEntrada.Location = new System.Drawing.Point(8, 189);
            this.tmHoraEntrada.Name = "tmHoraEntrada";
            this.tmHoraEntrada.Size = new System.Drawing.Size(147, 30);
            this.tmHoraEntrada.TabIndex = 53;
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.Location = new System.Drawing.Point(59, 115);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtIdPrestamo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdPrestamo.Properties.Appearance.Options.UseFont = true;
            this.txtIdPrestamo.Properties.Appearance.Options.UseForeColor = true;
            this.txtIdPrestamo.Size = new System.Drawing.Size(163, 28);
            this.txtIdPrestamo.TabIndex = 50;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl2.Location = new System.Drawing.Point(13, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(147, 19);
            this.labelControl2.TabIndex = 49;
            this.labelControl2.Text = "Código del préstamo";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton1.Location = new System.Drawing.Point(743, 15);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 23);
            this.simpleButton1.TabIndex = 48;
            this.simpleButton1.Text = "Actualizar formulario";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(508, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(167, 37);
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
            this.btnGuardar.Location = new System.Drawing.Point(683, 236);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(174, 37);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtIdLector
            // 
            this.txtIdLector.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtIdLector.Location = new System.Drawing.Point(233, 116);
            this.txtIdLector.Name = "txtIdLector";
            this.txtIdLector.ReadOnly = true;
            this.txtIdLector.Size = new System.Drawing.Size(68, 24);
            this.txtIdLector.TabIndex = 26;
            // 
            // cbLector
            // 
            this.cbLector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLector.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.cbLector.FormattingEnabled = true;
            this.cbLector.Location = new System.Drawing.Point(307, 115);
            this.cbLector.Name = "cbLector";
            this.cbLector.Size = new System.Drawing.Size(349, 27);
            this.cbLector.TabIndex = 25;
            // 
            // dtPrestamo
            // 
            this.dtPrestamo.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.dtPrestamo.Location = new System.Drawing.Point(307, 189);
            this.dtPrestamo.Name = "dtPrestamo";
            this.dtPrestamo.Size = new System.Drawing.Size(349, 30);
            this.dtPrestamo.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label1.Location = new System.Drawing.Point(224, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lector";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label5.Location = new System.Drawing.Point(161, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "H. Salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label4.Location = new System.Drawing.Point(9, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Hora. Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label3.Location = new System.Drawing.Point(303, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBox2.Location = new System.Drawing.Point(16, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(542, 1);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.25F);
            this.labelControl1.Location = new System.Drawing.Point(16, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(184, 27);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Lista de préstamos";
            // 
            // FrmListaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 522);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmListaPrestamos";
            this.Text = "Lista de préstamos";
            this.Load += new System.EventHandler(this.FrmListaPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdPrestamo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker tmHoraSalida;
        private System.Windows.Forms.DateTimePicker tmHoraEntrada;
        private DevExpress.XtraEditors.TextEdit txtIdPrestamo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtIdLector;
        private System.Windows.Forms.ComboBox cbLector;
        private System.Windows.Forms.DateTimePicker dtPrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}