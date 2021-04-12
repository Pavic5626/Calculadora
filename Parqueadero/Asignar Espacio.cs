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
    public partial class Asignar_Espacio : Form
    {
        public Asignar_Espacio()
        {
            InitializeComponent();
        }

        private void BtnAsignar_Click(object sender, EventArgs e)
        {
            // Genero un mensaje que indique el exito de la grabacion de datos
            MessageBox.Show("El Vehiculo fue ingresado correctamente y le Fue Asiganado un espacio de parqueo" + TxtUbicacion);
        }
    }
}
