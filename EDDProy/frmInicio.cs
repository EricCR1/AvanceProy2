﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales.froms;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Recursividad;
using EDDemo.Recursividad.forms;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        private Pilas pila;
        public frmInicio()
        {
            InitializeComponent();
            ListBox tempListBox = new ListBox(); // Crear un ListBox temporal
            pila = new Pilas(tempListBox);
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas mPilas = new frmPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void estructurasNoLibealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFila frmFila = new frmFila();
            frmFila.MdiParent = this;
            frmFila.Show();
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void simplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLista frmLista = new frmLista();
            frmLista.MdiParent = this;
            frmLista.Show();
        }

        private void doblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListasDobles miDoble = new frmListasDobles();
            miDoble.MdiParent = this;
            miDoble.Show();
        }

        private void ciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListasCirculares frmListasCirculares = new frmListasCirculares();
            frmListasCirculares.MdiParent = this;   
            frmListasCirculares.Show();
        }

        private void factorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactorial frmFactorial = new frmFactorial();
            frmFactorial.MdiParent = this;
            frmFactorial.Show();
        }

        private void exponencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExponencial frmexponencial = new frmExponencial ();
            frmexponencial.MdiParent = this;
            frmexponencial.Show();
        }

        private void sumaDeArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArreglo frmarreglo = new frmArreglo();
            frmarreglo.MdiParent = this;
            frmarreglo.Show();
        }

        private void secuenciaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFibonacci Frmfibonacci = new frmFibonacci();
            Frmfibonacci.MdiParent = this;
            Frmfibonacci.Show();
        }

        private void recursividadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaBinaria frmBusquedaBinaria = new frmBusquedaBinaria();
            frmBusquedaBinaria.MdiParent = this;    
            frmBusquedaBinaria.Show();
        }
    }
}
