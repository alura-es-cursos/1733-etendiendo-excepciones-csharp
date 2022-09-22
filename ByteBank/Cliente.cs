using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.DatosCliente
{
    public class Cliente
    {
        //public string nombre;
        //public string dni;
        //public string profesion;

        public Cliente (string _nombre)
        {
            Nombre = _nombre;
        }

        public string Nombre
        {
            get;set;
        }
        public string Dni
        {
            get; set;
        }
        public string Profesion
        {
            get; set;
        }

    }
}
