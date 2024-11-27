
namespace EDDemo
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recursividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factorialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exponencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaDeArregloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secuenciaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaBinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasNoLibealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torresDeHannoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recursividadToolStripMenuItem,
            this.estructurasLinealesToolStripMenuItem,
            this.estructurasNoLibealesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(774, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // recursividadToolStripMenuItem
            // 
            this.recursividadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.factorialesToolStripMenuItem,
            this.exponencialToolStripMenuItem,
            this.sumaDeArregloToolStripMenuItem,
            this.secuenciaDeToolStripMenuItem,
            this.busquedaBinariaToolStripMenuItem,
            this.torresDeHannoiToolStripMenuItem});
            this.recursividadToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recursividadToolStripMenuItem.Name = "recursividadToolStripMenuItem";
            this.recursividadToolStripMenuItem.Size = new System.Drawing.Size(120, 25);
            this.recursividadToolStripMenuItem.Text = "Recursividad";
            this.recursividadToolStripMenuItem.Click += new System.EventHandler(this.recursividadToolStripMenuItem_Click);
            // 
            // factorialesToolStripMenuItem
            // 
            this.factorialesToolStripMenuItem.Name = "factorialesToolStripMenuItem";
            this.factorialesToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.factorialesToolStripMenuItem.Text = "Factoriales";
            this.factorialesToolStripMenuItem.Click += new System.EventHandler(this.factorialesToolStripMenuItem_Click);
            // 
            // exponencialToolStripMenuItem
            // 
            this.exponencialToolStripMenuItem.Name = "exponencialToolStripMenuItem";
            this.exponencialToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.exponencialToolStripMenuItem.Text = "Exponencial";
            this.exponencialToolStripMenuItem.Click += new System.EventHandler(this.exponencialToolStripMenuItem_Click);
            // 
            // sumaDeArregloToolStripMenuItem
            // 
            this.sumaDeArregloToolStripMenuItem.Name = "sumaDeArregloToolStripMenuItem";
            this.sumaDeArregloToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.sumaDeArregloToolStripMenuItem.Text = "Suma de Arreglo";
            this.sumaDeArregloToolStripMenuItem.Click += new System.EventHandler(this.sumaDeArregloToolStripMenuItem_Click);
            // 
            // secuenciaDeToolStripMenuItem
            // 
            this.secuenciaDeToolStripMenuItem.Name = "secuenciaDeToolStripMenuItem";
            this.secuenciaDeToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.secuenciaDeToolStripMenuItem.Text = "Secuencia de Fibonacci";
            this.secuenciaDeToolStripMenuItem.Click += new System.EventHandler(this.secuenciaDeToolStripMenuItem_Click);
            // 
            // busquedaBinariaToolStripMenuItem
            // 
            this.busquedaBinariaToolStripMenuItem.Name = "busquedaBinariaToolStripMenuItem";
            this.busquedaBinariaToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.busquedaBinariaToolStripMenuItem.Text = "Busqueda Binaria";
            this.busquedaBinariaToolStripMenuItem.Click += new System.EventHandler(this.busquedaBinariaToolStripMenuItem_Click);
            // 
            // estructurasLinealesToolStripMenuItem
            // 
            this.estructurasLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilasToolStripMenuItem,
            this.colasToolStripMenuItem,
            this.listasToolStripMenuItem});
            this.estructurasLinealesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estructurasLinealesToolStripMenuItem.Name = "estructurasLinealesToolStripMenuItem";
            this.estructurasLinealesToolStripMenuItem.Size = new System.Drawing.Size(169, 25);
            this.estructurasLinealesToolStripMenuItem.Text = "Estructuras lineales";
            this.estructurasLinealesToolStripMenuItem.Click += new System.EventHandler(this.estructurasLinealesToolStripMenuItem_Click);
            // 
            // pilasToolStripMenuItem
            // 
            this.pilasToolStripMenuItem.Name = "pilasToolStripMenuItem";
            this.pilasToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.pilasToolStripMenuItem.Text = "Pilas";
            this.pilasToolStripMenuItem.Click += new System.EventHandler(this.pilasToolStripMenuItem_Click);
            // 
            // colasToolStripMenuItem
            // 
            this.colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            this.colasToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.colasToolStripMenuItem.Text = "Colas";
            this.colasToolStripMenuItem.Click += new System.EventHandler(this.colasToolStripMenuItem_Click);
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simplesToolStripMenuItem,
            this.doblesToolStripMenuItem,
            this.ciToolStripMenuItem});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.listasToolStripMenuItem.Text = "Listas";
            this.listasToolStripMenuItem.Click += new System.EventHandler(this.listasToolStripMenuItem_Click);
            // 
            // simplesToolStripMenuItem
            // 
            this.simplesToolStripMenuItem.Name = "simplesToolStripMenuItem";
            this.simplesToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.simplesToolStripMenuItem.Text = "Simples";
            this.simplesToolStripMenuItem.Click += new System.EventHandler(this.simplesToolStripMenuItem_Click);
            // 
            // doblesToolStripMenuItem
            // 
            this.doblesToolStripMenuItem.Name = "doblesToolStripMenuItem";
            this.doblesToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.doblesToolStripMenuItem.Text = "Dobles";
            this.doblesToolStripMenuItem.Click += new System.EventHandler(this.doblesToolStripMenuItem_Click);
            // 
            // ciToolStripMenuItem
            // 
            this.ciToolStripMenuItem.Name = "ciToolStripMenuItem";
            this.ciToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.ciToolStripMenuItem.Text = "Circulares";
            this.ciToolStripMenuItem.Click += new System.EventHandler(this.ciToolStripMenuItem_Click);
            // 
            // estructurasNoLibealesToolStripMenuItem
            // 
            this.estructurasNoLibealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolesToolStripMenuItem});
            this.estructurasNoLibealesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estructurasNoLibealesToolStripMenuItem.Name = "estructurasNoLibealesToolStripMenuItem";
            this.estructurasNoLibealesToolStripMenuItem.Size = new System.Drawing.Size(193, 25);
            this.estructurasNoLibealesToolStripMenuItem.Text = "Estructuras no lineales";
            this.estructurasNoLibealesToolStripMenuItem.Click += new System.EventHandler(this.estructurasNoLibealesToolStripMenuItem_Click);
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            this.arbolesToolStripMenuItem.Click += new System.EventHandler(this.arbolesToolStripMenuItem_Click);
            // 
            // torresDeHannoiToolStripMenuItem
            // 
            this.torresDeHannoiToolStripMenuItem.Name = "torresDeHannoiToolStripMenuItem";
            this.torresDeHannoiToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.torresDeHannoiToolStripMenuItem.Text = "Torres de Hannoi";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 478);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estructurasLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasNoLibealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factorialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exponencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaDeArregloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secuenciaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaBinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torresDeHannoiToolStripMenuItem;
    }
}

