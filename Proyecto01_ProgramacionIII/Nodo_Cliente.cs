using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01_ProgramacionIII
{
    /// <summary>
    /// Autor: Jose Miguel Rojas
    /// Jose Carrillo Mendez
    /// Fecha: 2016/03/02
    /// </summary>
    public class Nodo_Cliente
    {
        public Cls_Persona cliente;
        public Nodo_Cliente siguiente = null;

        /// <summary>
        /// contructor de cliente
        /// </summary>
        /// <param name="cliente"></param>
        public Nodo_Cliente(Cls_Persona cliente)
        {
            this.cliente = cliente;
        }
    }
}
