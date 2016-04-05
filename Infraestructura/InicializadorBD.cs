using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class InicializadorBD : CreateDatabaseIfNotExists<VentasContexto>
    {
        protected override void Seed(VentasContexto context)
        {

        }
    }
}
