using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public abstract class COMPONENTP
    {
        public string Nombre { get; set; }
        public decimal Valor { get; set; }

        public COMPONENTP(string Nombre, decimal Valor)
        {
            this.Nombre = Nombre;
            this.Valor = Valor;
        }
    }
}