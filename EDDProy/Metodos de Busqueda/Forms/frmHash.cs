using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EDDemo.Metodos_de_Busqueda.Forms
{
    public partial class frmHash : Form
    {
        private Hash tablaHash;
        public frmHash()
        {
            InitializeComponent();
            tablaHash = new Hash();

            // Leer datos desde el archivo
            string rutaArchivo = "datos.txt";
            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);
                foreach (string linea in lineas)
                {
                    string[] partes = linea.Split(',');
                    if (partes.Length == 2)
                    {
                        int clave = int.Parse(partes[0].Trim());
                        string valor = partes[1].Trim();
                        tablaHash.Insertar(clave, valor);
                    }
                }
            }
            else
            {
                MessageBox.Show("El archivo no existe. Asegúrate de que 'datos.txt' esté en el directorio correcto.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmHash_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener la clave desde el TextBox
            if (int.TryParse(textBox1.Text, out int claveBuscada))
            {
                // Llamar a la función Buscar en la clase Hash
                string resultado = tablaHash.Buscar(claveBuscada);
                if (resultado != null)
                {
                    label3.Text = $" {claveBuscada} :  {resultado}";
                }
                else
                {
                    MessageBox.Show($"Clave {claveBuscada} no encontrada en la tabla hash.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }
    }
}
