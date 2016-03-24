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
    public class Nodo_Empleado
    {
        public Cls_Persona empleado;
        public Nodo_Empleado siguiente = null;

        /// <summary>
        /// contructor de empleado
        /// </summary>
        /// <param name="empleado"></param>
        public Nodo_Empleado(Cls_Persona empleado)
        {
            this.empleado = empleado;
        }
    }
}
