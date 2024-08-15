using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidad.Negocios.Entidad
{
    public class Servicio
    {
        public int idServicio { get; set; }
        public string nomServicio { get; set; }
        public string fechaServicio { get; set; }
        public int idCliente { get; set; }
        public decimal precio { get; set; }

    }
}
