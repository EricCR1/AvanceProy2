using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using EDDemo.Recursividad.Clases;

namespace EDDemo.Recursividad.forms
{
    public partial class frmBusquedaBinaria : Form
    {
        private int[] _numeros; // Almacena los números generados
        private BusquedaBinaria busquedaBinaria;

        public frmBusquedaBinaria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la cantidad de números del NumericUpDown
                int cantidad = (int)numericUpDown1.Value;

                if (cantidad <= 0)
                {
                    MessageBox.Show("La cantidad de números debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Generar números aleatorios y ordenarlos
                Random random = new Random();
                int[] numeros = new int[cantidad];
                for (int i = 0; i < cantidad; i++)
                {
                    numeros[i] = random.Next(1, 101); // Números aleatorios entre 1 y 100
                }
                Array.Sort(numeros); // Ordenar los números para la búsqueda binaria

                // Mostrar los números en el Label
                label3.Text = string.Join(", ", numeros);

                // Guardar los números en una variable global para usar en la búsqueda
                _numeros = numeros;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que hay números generados
                if (_numeros == null || _numeros.Length == 0)
                {
                    MessageBox.Show("Primero genere la lista de números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el número a buscar desde la TextBox
                if (!int.TryParse(textBox1.Text, out int numero))
                {
                    MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Inicializar el contador de cortes
                int cantidadCortes = 0;


                // Iniciar el cronómetro
                Stopwatch stopwatch = Stopwatch.StartNew();

                // Realizar la búsqueda binaria
                int posicion = BusquedaBinaria.Buscar(_numeros, numero, 0, _numeros.Length - 1, ref cantidadCortes);

                // Detener el cronómetro
                stopwatch.Stop();

                // Mostrar los resultados
                if (posicion != -1)
                {
                    MessageBox.Show("Número encontrado en posición: " +  posicion+1);
                }
                else
                {
                    MessageBox.Show("Número no encontrado.");
                }

                // Mostrar la cantidad de cortes en el Label
                label5.Text = $" {cantidadCortes}";
                label8.Text = "";
                label8.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
