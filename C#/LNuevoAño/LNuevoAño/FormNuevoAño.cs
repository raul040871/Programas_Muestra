using LBaseDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNuevoAño
{
    public partial class FormNuevoAño : Form
    {
        public FormNuevoAño()
        {
            InitializeComponent();
        }

        private void btAlta_Click(object sender, EventArgs e)
        {
            try
            {
               // new DateTime(int.Parse(m_strAño.Text), 1, 1);
                CBaseDatos BD = new CBaseDatos();
                int nSalida=BD.AltaAño(m_strAño.Text);
                if (nSalida==0)
                {
                    MessageBox.Show("Año " + m_strAño.Text + " creado correctamente", "AHCB", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    MessageBox.Show("No se ha podidio dar de alta el año correctamente", "AHCB", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Formato de año incorrecto", "AHCB", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
