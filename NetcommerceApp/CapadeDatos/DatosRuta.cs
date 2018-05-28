using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapadeNegocios;
using System.Data.SqlClient;

namespace CapadeDatos
{
    class DatosRuta
    {
        public List<clsRuta> listarRutas()
        {
            SqlCommand cmd = new SqlCommand("select * from tbl_DetalleRuta", con);

            List<clsRuta> listaRuta = new List<clsRuta>();

            con.Open();
            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                clsRuta ruta = new clsRuta();
                ruta.Nombreruta = lector.GetString(0);
                ruta.Clienteruta = lector.GetString(1);
                ruta.Provinciaruta = lector.GetString(2);
                ruta.Cantonruta = lector.GetString(3);
                ruta.Referenciaruta = lector.GetString(4);

                listarRutas.Add(ruta);
            }

            const.Close();
            return listaRutas;
        }
    }
}
