using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parqueadero
{
    public partial class Registro : Form
    {
        Cliente usuario = new Cliente();


        public Registro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblParqueadero_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            usuario.Cedula = TxtCedula.Text;
            usuario.Nombre = TxtNombre.Text;
            usuario.Color = CmbColor.Text;
            usuario.Marca = CmbMarca.Text;
            usuario.Matricula = TxtMatricula.Text;
            usuario.Modelo = TxtModelo.Text;

            Form Asignar_Espacio = new Asignar_Espacio();
            Asignar_Espacio.Show();
                        
        }

        private void BtnRetirar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Vehiculo fue Retirado Correctamente");

            this.TxtNombre.Text = "";
            this.TxtCedula.Text = "";
            this.CmbMarca.Text = "";
            this.TxtMatricula.Text = "";
            this.CmbColor.Text = "";
            this.TxtModelo.Text = "";
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Salir de la aplicacion de Se lo Cuidamos?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MessageBoxButtons botones = MessageBoxButtons.YesNoCancel;
            DialogResult dr = MessageBox.Show("confirma tu salida", "Titulo botones", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                Form Registro = new Registro();
                Registro.Show();
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Vehiculo a retirar es :" + TxtMatricula) ;
        }
    }
}
