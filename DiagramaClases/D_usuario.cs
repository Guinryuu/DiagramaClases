using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaClases
{
    class D_usuario
    {
        public int ID_usuario { get; private set; }
        public string Apellido { get; private set; }
        public string Nombre { get; private set; }
        public int DNI { get; private set; }
        public string Direccion { get; private set; }
        public string Celular { get; private set; }
        public string Uusuario { get; private set; }
        public string Clave { get; private set; }
        public int Estado { get; private set; }
        
        public static int Validad_DNI(int dni_ingreso)
        {
            return dni_ingreso;
        }

        public static string Validad_Celular(string celular_ingreso)
        {
            return celular_ingreso;
        }
    }
}
