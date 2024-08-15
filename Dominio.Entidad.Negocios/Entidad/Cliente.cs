using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidad.Negocios.Entidad
{
    public class Cliente
    {
        public int idCliente { get; set; }

        public string nomCliente { get; set; }
        public string nomEmpresa { get; set; }
        public string telefono { get; set; }

        public string email { get; set; }
    }
}
