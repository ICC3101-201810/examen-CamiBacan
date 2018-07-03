using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_PartidaNueva_Click(object sender, EventArgs e)
        {
            Nombre nombre = new Nombre();
            nombre.ShowDialog();
        }

        private void button_Posiciones_Click(object sender, EventArgs e)
        {
            Posiciones_Historicas posiciones_Historicas = new Posiciones_Historicas();
            posiciones_Historicas.ShowDialog();
            Hide();
            Show();
        }

        private void button_partidasGuardadas_Click(object sender, EventArgs e)
        {

        }
    }
}
