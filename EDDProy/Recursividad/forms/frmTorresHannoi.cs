using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Recursividad.Clases;

namespace EDDemo.Recursividad.forms
{
    public partial class frmTorresHannoi : Form
    {
        private TorresHannoi hanoi = new TorresHannoi();
        public frmTorresHannoi()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener la cantidad de discos seleccionada en el NumericUpDown
            int cantidadDiscos = (int)numericUpDown1.Value;

            // Calcular los movimientos necesarios
            int movimientos = hanoi.CalcularMovimientos(cantidadDiscos);

            // Mostrar el resultado en el Label
            label3.Text = "";
            label3.Text = $"{movimientos}";
            hanoi.Movimientos = string.Empty;

            // Crear una instancia de TorresDeHanoi
            TorresHannoi hannoi = new TorresHannoi();

            // Calcular los movimientos
            hanoi.ResolverHanoi(cantidadDiscos, "A", "C", "B");

            // Mostrar los movimientos en el Label
            label4.Text = "";
            label4.Text = hanoi.Movimientos;
            
        }

        private void frmTorresHannoi_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
