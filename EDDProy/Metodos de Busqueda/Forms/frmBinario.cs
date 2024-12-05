﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Metodos_de_Busqueda.Clases;

namespace EDDemo.Metodos_de_Busqueda.Forms
{
    public partial class frmBinario : Form
    {
        private int[] arreglo;
        public frmBinario()
        {
            InitializeComponent();
        }

        private void frmBinario_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Crear un arreglo aleatorio
            int cantidad = (int)numericUpDown1.Value;
            Random random = new Random();
            arreglo = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                arreglo[i] = random.Next(1, 100); // Números entre 1 y 100
            }

            // Ordenar el arreglo (requisito para la búsqueda binaria)
            Array.Sort(arreglo);

            // Mostrar el arreglo ordenado
            label2.Text = $"Arreglo ordenado: {string.Join(", ", arreglo)}";
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (arreglo == null || arreglo.Length == 0)
            {
                MessageBox.Show("Primero debes crear un arreglo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBox1.Text, out int valorBuscado))
            {
                MessageBox.Show("Introduce un número válido para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear instancia de Binaria y realizar la búsqueda
            Binaria busqueda = new Binaria();
            int posicion = busqueda.Buscar(arreglo, valorBuscado);

            // Limpiar el Label de pasos previos
            label3.Text = "";

            // Mostrar los pasos en el Label
            foreach (var paso in busqueda.Pasos)
            {
                label3.Text += paso + "\n";
            }

            // Mostrar el resultado
            if (posicion >= 0)
            {
                label4.Text = $"Valor encontrado en la posición {posicion}";
            }
            else
            {
                label4.Text = "Valor no encontrado en el arreglo";
            }
        }
    }
}