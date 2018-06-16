using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {

        public int IdCliente { get; set; }
        public string Nombre { get; set; }

        public Cliente(int v1, string v2)
        {
            IdCliente = v1;
            Nombre= v2;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
