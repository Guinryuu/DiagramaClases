using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaClases
{
    class D_venta
    {
        public int ID_venta { get; private set; }
        public int Num_documento { get; private set; }
        public string Tipo_documento { get; private set; }
        public decimal Total { get; private set; }
        public DateTime F_venta { get; private set; }
        public int FK_ID_cliente { get; private set; }

        public static DateTime Validad_f_venta(DateTime f_venta_ingreso)
        {
            return f_venta_ingreso;
        }
    }
}
