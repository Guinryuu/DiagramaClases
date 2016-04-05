using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaClases
{
    class D_detalle
    {
        public int ID_detalle { get; private set; }
        public int Cantidad { get; private set; }
        public decimal IGV { get; private set; }
        public decimal Importe { get; private set; }
        public int FK_ID_venta { get; private set; }
        public int FK_ID_producto { get; private set; }
        
        public static int Actualizar_Disponibilidad(int disponibilidad_ingreso)
        {
            return disponibilidad_ingreso;
        }

        public static decimal Actualizar_total(decimal total_ingreso)
        {
            return total_ingreso;
        }

    }
}
