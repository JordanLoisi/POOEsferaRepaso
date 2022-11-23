
namespace POOEsferaRepaso.Windows
{
    partial class FrmPrincal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevotoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.EditartoolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.BorrartoolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RestaurartoolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.GuardartoolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.SalirtoolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.EsferadataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColumnRadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTrazos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVolumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cantidadlabel = new System.Windows.Forms.Label();
            this.FiltrartoolStripButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ordenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rojoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decenteRiberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EsferadataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevotoolStripButton1,
            this.EditartoolStripButton2,
            this.BorrartoolStripButton3,
            this.toolStripSeparator1,
            this.FiltrartoolStripButton4,
            this.RestaurartoolStripButton5,
            this.toolStripSeparator2,
            this.GuardartoolStripButton6,
            this.SalirtoolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(663, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevotoolStripButton1
            // 
            this.NuevotoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("NuevotoolStripButton1.Image")));
            this.NuevotoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevotoolStripButton1.Name = "NuevotoolStripButton1";
            this.NuevotoolStripButton1.Size = new System.Drawing.Size(46, 35);
            this.NuevotoolStripButton1.Text = "Nuevo";
            this.NuevotoolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevotoolStripButton1.Click += new System.EventHandler(this.NuevotoolStripButton1_Click);
            // 
            // EditartoolStripButton2
            // 
            this.EditartoolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("EditartoolStripButton2.Image")));
            this.EditartoolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditartoolStripButton2.Name = "EditartoolStripButton2";
            this.EditartoolStripButton2.Size = new System.Drawing.Size(41, 35);
            this.EditartoolStripButton2.Text = "Editar";
            this.EditartoolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditartoolStripButton2.Click += new System.EventHandler(this.EditartoolStripButton2_Click);
            // 
            // BorrartoolStripButton3
            // 
            this.BorrartoolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("BorrartoolStripButton3.Image")));
            this.BorrartoolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrartoolStripButton3.Name = "BorrartoolStripButton3";
            this.BorrartoolStripButton3.Size = new System.Drawing.Size(43, 35);
            this.BorrartoolStripButton3.Text = "Borrar";
            this.BorrartoolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrartoolStripButton3.Click += new System.EventHandler(this.BorrartoolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // RestaurartoolStripButton5
            // 
            this.RestaurartoolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("RestaurartoolStripButton5.Image")));
            this.RestaurartoolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RestaurartoolStripButton5.Name = "RestaurartoolStripButton5";
            this.RestaurartoolStripButton5.Size = new System.Drawing.Size(60, 35);
            this.RestaurartoolStripButton5.Text = "Restaurar";
            this.RestaurartoolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RestaurartoolStripButton5.Click += new System.EventHandler(this.RestaurartoolStripButton5_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // GuardartoolStripButton6
            // 
            this.GuardartoolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("GuardartoolStripButton6.Image")));
            this.GuardartoolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardartoolStripButton6.Name = "GuardartoolStripButton6";
            this.GuardartoolStripButton6.Size = new System.Drawing.Size(53, 35);
            this.GuardartoolStripButton6.Text = "Guardar";
            this.GuardartoolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardartoolStripButton6.Click += new System.EventHandler(this.GuardartoolStripButton6_Click);
            // 
            // SalirtoolStripButton7
            // 
            this.SalirtoolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("SalirtoolStripButton7.Image")));
            this.SalirtoolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirtoolStripButton7.Name = "SalirtoolStripButton7";
            this.SalirtoolStripButton7.Size = new System.Drawing.Size(33, 35);
            this.SalirtoolStripButton7.Text = "Salir";
            this.SalirtoolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirtoolStripButton7.Click += new System.EventHandler(this.SalirtoolStripButton7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 38);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.EsferadataGridView2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cantidadlabel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(663, 412);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 2;
            // 
            // EsferadataGridView2
            // 
            this.EsferadataGridView2.AllowUserToAddRows = false;
            this.EsferadataGridView2.AllowUserToDeleteRows = false;
            this.EsferadataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EsferadataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRadio,
            this.ColumnColor,
            this.ColumnTrazos,
            this.ColumnArea,
            this.ColumnVolumen});
            this.EsferadataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EsferadataGridView2.Location = new System.Drawing.Point(0, 0);
            this.EsferadataGridView2.MultiSelect = false;
            this.EsferadataGridView2.Name = "EsferadataGridView2";
            this.EsferadataGridView2.ReadOnly = true;
            this.EsferadataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EsferadataGridView2.Size = new System.Drawing.Size(663, 306);
            this.EsferadataGridView2.TabIndex = 0;
            // 
            // ColumnRadio
            // 
            this.ColumnRadio.HeaderText = "Radio";
            this.ColumnRadio.Name = "ColumnRadio";
            this.ColumnRadio.ReadOnly = true;
            // 
            // ColumnColor
            // 
            this.ColumnColor.HeaderText = "Color";
            this.ColumnColor.Name = "ColumnColor";
            this.ColumnColor.ReadOnly = true;
            // 
            // ColumnTrazos
            // 
            this.ColumnTrazos.HeaderText = "Trazos";
            this.ColumnTrazos.Name = "ColumnTrazos";
            this.ColumnTrazos.ReadOnly = true;
            // 
            // ColumnArea
            // 
            this.ColumnArea.HeaderText = "Area";
            this.ColumnArea.Name = "ColumnArea";
            this.ColumnArea.ReadOnly = true;
            // 
            // ColumnVolumen
            // 
            this.ColumnVolumen.HeaderText = "Volumen";
            this.ColumnVolumen.Name = "ColumnVolumen";
            this.ColumnVolumen.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "cantidad";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(663, 102);
            this.dataGridView2.TabIndex = 0;
            // 
            // cantidadlabel
            // 
            this.cantidadlabel.AutoSize = true;
            this.cantidadlabel.Location = new System.Drawing.Point(130, 47);
            this.cantidadlabel.Name = "cantidadlabel";
            this.cantidadlabel.Size = new System.Drawing.Size(13, 13);
            this.cantidadlabel.TabIndex = 2;
            this.cantidadlabel.Text = "0";
            // 
            // FiltrartoolStripButton4
            // 
            this.FiltrartoolStripButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenarToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.FiltrartoolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("FiltrartoolStripButton4.Image")));
            this.FiltrartoolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrartoolStripButton4.Name = "FiltrartoolStripButton4";
            this.FiltrartoolStripButton4.Size = new System.Drawing.Size(50, 35);
            this.FiltrartoolStripButton4.Text = "Filtrar";
            this.FiltrartoolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FiltrartoolStripButton4.Click += new System.EventHandler(this.FiltrartoolStripButton4_Click);
            // 
            // ordenarToolStripMenuItem
            // 
            this.ordenarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acendenteToolStripMenuItem,
            this.decenteRiberToolStripMenuItem});
            this.ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            this.ordenarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordenarToolStripMenuItem.Text = "Ordenar";
            
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rojoToolStripMenuItem,
            this.azulToolStripMenuItem,
            this.verdeToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // rojoToolStripMenuItem
            // 
            this.rojoToolStripMenuItem.Name = "rojoToolStripMenuItem";
            this.rojoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rojoToolStripMenuItem.Text = "Rojo";
            // 
            // azulToolStripMenuItem
            // 
            this.azulToolStripMenuItem.Name = "azulToolStripMenuItem";
            this.azulToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.azulToolStripMenuItem.Text = "Azul";
            // 
            // verdeToolStripMenuItem
            // 
            this.verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            this.verdeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verdeToolStripMenuItem.Text = "verde";
            // 
            // acendenteToolStripMenuItem
            // 
            this.acendenteToolStripMenuItem.Name = "acendenteToolStripMenuItem";
            this.acendenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acendenteToolStripMenuItem.Text = "Acendente";
            this.acendenteToolStripMenuItem.Click += new System.EventHandler(this.acendenteToolStripMenuItem_Click);
            // 
            // decenteRiberToolStripMenuItem
            // 
            this.decenteRiberToolStripMenuItem.Name = "decenteRiberToolStripMenuItem";
            this.decenteRiberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.decenteRiberToolStripMenuItem.Text = "Decente riber";
            this.decenteRiberToolStripMenuItem.Click += new System.EventHandler(this.decenteRiberToolStripMenuItem_Click);
            // 
            // FrmPrincal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPrincal";
            this.Text = "FrmPrincal";
            this.Load += new System.EventHandler(this.FrmPrincal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EsferadataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevotoolStripButton1;
        private System.Windows.Forms.ToolStripButton EditartoolStripButton2;
        private System.Windows.Forms.ToolStripButton BorrartoolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RestaurartoolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton GuardartoolStripButton6;
        private System.Windows.Forms.ToolStripButton SalirtoolStripButton7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView EsferadataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRadio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTrazos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVolumen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label cantidadlabel;
        private System.Windows.Forms.ToolStripDropDownButton FiltrartoolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem ordenarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rojoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decenteRiberToolStripMenuItem;
    }
}