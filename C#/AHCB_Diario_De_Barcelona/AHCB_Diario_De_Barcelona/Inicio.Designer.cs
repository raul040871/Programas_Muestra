namespace AHCB_Diario_De_Barcelona
{
    partial class FrmPrimcipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrimcipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btNuevoAño = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btIndexar = new System.Windows.Forms.ToolStripButton();
            this.btModificar = new System.Windows.Forms.ToolStripButton();
            this.btEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btSalir = new System.Windows.Forms.ToolStripButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNuevoAño,
            this.toolStripSeparator1,
            this.btIndexar,
            this.btModificar,
            this.btEliminar,
            this.toolStripSeparator2,
            this.btExportar,
            this.toolStripSeparator3,
            this.btSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(991, 76);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btNuevoAño
            // 
            this.btNuevoAño.AutoSize = false;
            this.btNuevoAño.Image = global::AHCB_Diario_De_Barcelona.Properties.Resources.Apptl;
            this.btNuevoAño.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btNuevoAño.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNuevoAño.Name = "btNuevoAño";
            this.btNuevoAño.Size = new System.Drawing.Size(70, 50);
            this.btNuevoAño.Text = "Nuevo Año";
            this.btNuevoAño.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btNuevoAño.Click += new System.EventHandler(this.btNuevoAño_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 76);
            // 
            // btIndexar
            // 
            this.btIndexar.AutoSize = false;
            this.btIndexar.Image = global::AHCB_Diario_De_Barcelona.Properties.Resources.Mycomp;
            this.btIndexar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btIndexar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btIndexar.Name = "btIndexar";
            this.btIndexar.Size = new System.Drawing.Size(70, 50);
            this.btIndexar.Text = "Indexar";
            this.btIndexar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btModificar
            // 
            this.btModificar.AutoSize = false;
            this.btModificar.Image = global::AHCB_Diario_De_Barcelona.Properties.Resources.Shell_43;
            this.btModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(70, 50);
            this.btModificar.Text = "Modificar";
            this.btModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btEliminar
            // 
            this.btEliminar.AutoSize = false;
            this.btEliminar.Image = global::AHCB_Diario_De_Barcelona.Properties.Resources.eliminar;
            this.btEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(70, 50);
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 76);
            // 
            // btExportar
            // 
            this.btExportar.AutoSize = false;
            this.btExportar.Image = global::AHCB_Diario_De_Barcelona.Properties.Resources.Shell_15;
            this.btExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(70, 50);
            this.btExportar.Text = "Exportar";
            this.btExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 76);
            // 
            // btSalir
            // 
            this.btSalir.AutoSize = false;
            this.btSalir.Image = global::AHCB_Diario_De_Barcelona.Properties.Resources.WinXPSetV4_Icon_17;
            this.btSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(70, 50);
            this.btSalir.Text = "Salir";
            this.btSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(16, 80);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(957, 629);
            this.treeView1.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Año.ico");
            this.imageList1.Images.SetKeyName(1, "Diario.ico");
            // 
            // FrmPrimcipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 756);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrimcipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AHCB Indexación Diario de Barcelona";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btNuevoAño;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btIndexar;
        private System.Windows.Forms.ToolStripButton btModificar;
        private System.Windows.Forms.ToolStripButton btEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btExportar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btSalir;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

