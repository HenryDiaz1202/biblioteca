using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Biblioteca.FormulariosCrud
{
    public partial class FrmAgregarPrestamo_cs : DevExpress.XtraEditors.XtraForm
    {
        public FrmAgregarPrestamo_cs()
        {
            InitializeComponent();
        }

       
        private void FrmAgregarPrestamo_cs_Load(object sender, EventArgs e)
        {

            DataTable Datos_usuario = new DataTable();
            MySqlCommand comando = new MySqlCommand();
            string consulta = "select IdLector, Concat (NombresLector, ' ' ,ApellidosLector) as Lector from Lectores;";
            comando.CommandText = consulta;
            Datos_usuario = Conexion.Ejecutar(comando);
            this.cbLector.DataSource = Datos_usuario;

            this.cbLector.DisplayMember = "Lector";
            this.cbLector.ValueMember = "IdLector";

            txtIdLector.Text = cbLector.SelectedValue.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAgregarLector frmagregarlector = new FrmAgregarLector();
            frmagregarlector.ShowDialog();
        }

        private void cbLector_TextChanged(object sender, EventArgs e)
        {
            txtIdLector.Text = cbLector.SelectedValue.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             MySqlCommand comando_ingresar = new MySqlCommand();
             string IdLector, IdPrestamo,consulta;
             DateTime FechaPrestamo;
            TimeSpan HoraEntrada, HoraSalida;

             IdLector = txtIdLector.Text;
             IdPrestamo = "PM-"+txtIdPrestamo.Text;
             FechaPrestamo = dtPrestamo.Value.Date;
             HoraEntrada = tmHoraEntrada.Value.TimeOfDay;
             HoraSalida = tmHoraSalida.Value.TimeOfDay;

             consulta = "INSERT INTO Prestamos (IdPrestamo, FechaPrestamo, HoraEntrada, HoraSalida, IdLector) VALUES (@IdPrestamo, @FechaPrestamo, @HoraEntrada, @HoraSalida, @IdLector);";
             comando_ingresar.Parameters.Add("@IdPrestamo", MySqlDbType.VarChar).Value = IdPrestamo;
             comando_ingresar.Parameters.Add("@FechaPrestamo", MySqlDbType.DateTime).Value = FechaPrestamo;
             comando_ingresar.Parameters.Add("@HoraEntrada", MySqlDbType.Time).Value = HoraEntrada;
             comando_ingresar.Parameters.Add("@HoraSalida", MySqlDbType.Time).Value = HoraSalida;
             comando_ingresar.Parameters.Add("@IdLector", MySqlDbType.VarChar).Value = IdLector;
             comando_ingresar.CommandText = consulta;
             int resultado = Conexion.EjecutarOrden(comando_ingresar);
             if (resultado > 0)
             {
                 //MessageBox.Show("Datos ingresados correctamete!!!!!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 FrmDetallePrestamo frmdetalleprestamo = new FrmDetallePrestamo();
                 frmdetalleprestamo.txtIdPrestamo.Text = "PM-"+txtIdPrestamo.Text;
                 frmdetalleprestamo.ShowDialog();
                 limpiarcajas();
             }
             else
             {
                 MessageBox.Show("Error al ingresar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

        }

        private void limpiarcajas()
        {
 	        
        }
    }
    
}