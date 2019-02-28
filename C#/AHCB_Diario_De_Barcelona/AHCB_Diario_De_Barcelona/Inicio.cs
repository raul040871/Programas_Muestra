using LNuevoAño;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHCB_Diario_De_Barcelona
{
    public partial class FrmPrimcipal : Form
    {
        public FrmPrimcipal()
        {
            InitializeComponent();
            CargarAños();
        }

        private void CargarAños()
        {
            CBaseDatos DB = new CBaseDatos();
            DB.CargarAños(treeView1);

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNuevoAño_Click(object sender, EventArgs e)
        {
            FormNuevoAño Na = new FormNuevoAño();
            Na.ShowDialog();

        }
    }
}
