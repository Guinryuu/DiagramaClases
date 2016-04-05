using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaClases
{
    class D_producto
    {
        public int ID_producto { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }       
        public string Imagen { get; private set; }
        public decimal P_compra { get; private set; }
        public decimal P_venta { get; private set; }
        public static int Disponibilidad { get; private set; }
        public DateTime F_vencimiento { get; private set; }
        public int FK_ID_categoria { get; private set; }

        public static int Validad_disponibilidad(int disponibilidad_ingreso)
        {
            return disponibilidad_ingreso;
        }

        public static DateTime Validad_vencimiento(DateTime vencimiento_ingreso)
        {
            return vencimiento_ingreso;
        }
    }
}
