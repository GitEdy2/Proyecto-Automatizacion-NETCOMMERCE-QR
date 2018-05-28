using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeNegocios
{
    class clsTrabajo
    {
        private string descripcion1tipotrabajo;
        private string descripcion2tipotrabajo;
        private string detallefibra;
        private int metrosfibra;
        private string detallepostes;
        private int numeropostes;
        private string detalleretenidas;
        private int numeroretenidas;


        public string Descripcion1tipotrabajo { get => descripcion1tipotrabajo; set => descripcion1tipotrabajo = value; }

        public string Descripcion2tipotrabajo { get => descripcion2tipotrabajo; set => descripcion2tipotrabajo = value; }

        public string Detallefibra { get => detallefibra; set => detallefibra = value; }

        public int Metrosfibra { get => metrosfibra; set => metrosfibra = value; }

        public string Detallepostes { get => detallepostes; set => detallepostes = value; }

        public int Numeropostes { get => numeropostes; set => numeropostes = value; }

        public string Detalleretenidas { get => detalleretenidas; set => detalleretenidas = value; }

        public int Numeroretenidas { get => numeroretenidas; set => numeroretenidas = value; }
    }
}
