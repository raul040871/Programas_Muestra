using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHCB_Diario_De_Barcelona
{
    class CBaseDatos
    {
        static String strConexion = "DiarioBarcelona_SQL";
        OdbcConnection conexion = new OdbcConnection(strConexion);
        OdbcCommand cmdComando;
        //DiarioBarcelona_SQL--->ODBC

        public int CargarAños(TreeView treeView1)
        {
            int nSalida = 0;



            return (nSalida);
        }

       


    }
}
