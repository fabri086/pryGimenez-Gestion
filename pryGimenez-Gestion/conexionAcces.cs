using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGimenez_Gestion
{
    internal class conexionAcces
    {
        OleDbConnection conexionDB;
        OleDbCommand comandoDB;
        OleDbDataReader leerDB;

        OleDbDataAdapter adaptadorDB;
        DataSet obj; //dato de memoria

        string rutadelarchivo; //sirve para la ruta del archivo Acces
        public string estadodeconexión;

        public void clsUsuario()
        {
            try
            {
                rutadelarchivo = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Escritorio\\pryGimenez-Gestion\\REQUERIMIENTOS\\BDusuarios.accdb"; //@"E:\Escritorio\pryGimenez-Gestion\pryGimenez-Gestion";

                conexionDB = new OleDbConnection();
                conexionDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Escritorio\\pryGimenez-Gestion\\REQUERIMIENTOS\\Negocio.mdb" + rutadelarchivo;
                conexionDB.Open();

                obj = new DataSet();

                estadodeconexión = "Conectar";
            }
            catch (Exception error)
            {
                estadodeconexión = error.Message;
            }
        }

        public void RegistroLogInicioSesion()
        {

            try
            {
                comandoDB = new OleDbCommand();

                comandoDB.Connection = conexionDB;
                comandoDB.CommandType = CommandType.Text;

            }
            catch (Exception error)
            {

            }



        }

    }

}
