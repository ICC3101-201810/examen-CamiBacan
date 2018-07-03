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
    public partial class Nombre : Form
    {
        public Nombre()
        {
            InitializeComponent();
        }

        private void button_comenzar_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            Partida partida = new Partida(name);
            partida.ShowDialog();
            Close();

        }

        private void button_atras_Click(object sender, EventArgs e)
        {
            Close();            
        }
    }
}
