using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Biblioteca
{
    public partial class Form2 : Form
    {
        DataTable Datos_obtenidos = new DataTable();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox1;

            MySqlCommand comando = new MySqlCommand();
            string consulta = "select * from Usuarios;";
            comando.CommandText = consulta;
            Datos_obtenidos = Conexion.Ejecutar(comando);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, clave;

            usuario = txtUser.Text;
            clave = txtPassword.Text;

            for (int i = 0; i < Datos_obtenidos.Rows.Count; i++)
            {

                if (usuario == Datos_obtenidos.Rows[i][1].ToString() && clave == Datos_obtenidos.Rows[i][2].ToString())
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
