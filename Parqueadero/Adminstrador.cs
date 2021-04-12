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
    public partial class Adminstrador : Form
    {
        public Adminstrador()
        {
            InitializeComponent();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            Form Registro = new Registro();
            Registro.Show();
            Hide();
        }
    }
}
