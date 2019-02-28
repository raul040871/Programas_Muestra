using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LBaseDatos
{
    public class CBaseDatos
    {
       
       
        OdbcConnection conexion = new OdbcConnection("Driver={SQL Server};Server=PC_CASA\\SQLEXPRESS2017;UID=DiarioBarcelona;PWD=diariobarcelona;Database=DdB;");
        private OdbcDataReader lectorDatos;
        OdbcCommand cmdComando;
        //DiarioBarcelona_SQL--->ODBC

        public  CBaseDatos()
        {

        }
        public int CargarAños(TreeView treeView1)
        {
            
            String strComando,strAño;
            int nSalida = 0;
            TreeNode NodoRaiz = new TreeNode();
            NodoRaiz.Name = "NodoRaiz";
            NodoRaiz.Text = "Años";
            treeView1.Nodes.Add(NodoRaiz);
            try
            {
                strComando = "select distict Año  from Años ";
                conexion.Open();
                cmdComando = new OdbcCommand(strComando, conexion);
                lectorDatos = cmdComando.ExecuteReader();

                if (lectorDatos.Read())
                {
                    strAño = lectorDatos.GetValue(lectorDatos.GetOrdinal("Año")).ToString();
                    TreeNode NodoAño = new TreeNode(strAño);
                    NodoAño.ImageIndex = 0;
                    NodoAño.SelectedImageIndex = 0;
                    NodoRaiz.Nodes.Add(NodoAño);
                }
                conexion.Close();
                return (nSalida);
            }
            catch (OdbcException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                nSalida = 1;
                return (nSalida);
            }
            finally
            {
                conexion.Close();
            }
        }

        public int AltaAño(string strAño)
        {
            int nSalida = 0;
            String strComando,strAñoInsertar;
            String Comillas = "\"";
            strAñoInsertar = Comillas + strAño + Comillas;
            try
            {
                strComando = "create table " +  strAñoInsertar  + " (Numero int, fecha char(8), Edicion char(20),Pagina char(4), [Ruta] char(300))";

                conexion.Open();
                cmdComando = new OdbcCommand(strComando, conexion);
                cmdComando.ExecuteNonQuery();

                strComando = "insert into Años(Año) values('" + strAño + "')";

                cmdComando = new OdbcCommand(strComando, conexion);
                cmdComando.ExecuteNonQuery();
                conexion.Close();
                

            }
            catch (OdbcException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }


            return nSalida;
        }
    }
}
