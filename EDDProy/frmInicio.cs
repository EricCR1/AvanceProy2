using System;
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
using EDDemo.Metodos_De_Ordenamiento.Forms;
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

        private void torresDeHannoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTorresHannoi frmTorresHannoi = new frmTorresHannoi();
            frmTorresHannoi.MdiParent = this;
            frmTorresHannoi.Show(); 
        }

        private void métodoDeOrdenaminetoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void burbujaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBurbuja frmburbuja = new frmBurbuja();
            frmburbuja.MdiParent = this;
            frmburbuja.Show();
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuickSort FrmQuickSort = new frmQuickSort();
            FrmQuickSort.MdiParent = this;
            FrmQuickSort.Show();
        }

        private void shellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShellSort FrmShellSort = new frmShellSort();
            FrmShellSort.MdiParent = this;
            FrmShellSort.Show();
        }

        private void radixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadix frmRadix = new frmRadix();
            frmRadix.MdiParent = this;
            frmRadix.Show();
        }

        private void intercalaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIntercalacion frmIntercalacion = new frmIntercalacion();
            frmIntercalacion.MdiParent = this;
            frmIntercalacion.Show();
        }

        private void mezclaDirectaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMezclaDirecta frmMezclaDirecta = new frmMezclaDirecta();
            frmMezclaDirecta.MdiParent = this;
            frmMezclaDirecta.Show();
        }

        private void mezclaNaturalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMezclaNatural frmMezclaNatural = new frmMezclaNatural();
            frmMezclaNatural.MdiParent = this;
            frmMezclaNatural.Show();
        }
    }
}
