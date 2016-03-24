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
    public class Nodo_Trabajo
    {
        private String cedula_cliente;
        public String Cedula_cliente
        {
            get { return cedula_cliente; }
            set { cedula_cliente = value; }
        }

        private String cedula_empleado;
        public String Cedula_empleado
        {
            get { return cedula_empleado; }
            set { cedula_empleado = value; }
        }

        private String placa_auto;
        public String Placa_auto
        {
            get { return placa_auto; }
            set { placa_auto = value; }
        }

        private String fecha;
        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private Boolean estado;
        public Boolean Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string[] array_trabajo;
        public string[] Array_trabajo
        {
            get { return array_trabajo; }
            set { array_trabajo = value; }
        }

        public Nodo_Trabajo siguiente = null;

        /// <summary>
        /// contructor para trabajos
        /// </summary>
        /// <param name="pCedula_cliente"></param>
        /// <param name="pCedula_empleado"></param>
        /// <param name="pPlaca_auto"></param>
        /// <param name="pFecha"></param>
        /// <param name="pEstado"></param>
        /// <param name="pArray_trabajo"></param>
        public Nodo_Trabajo(string pCedula_cliente, string pCedula_empleado, string pPlaca_auto, string pFecha, Boolean pEstado, string[] pArray_trabajo)
        {
            this.cedula_cliente = pCedula_cliente;
            this.cedula_empleado = pCedula_empleado;
            this.placa_auto = pPlaca_auto;
            this.fecha = pFecha;
            this.estado = pEstado;
            this.array_trabajo = pArray_trabajo;
        }
        public Nodo_Trabajo()
        {
            // TODO: Complete member initialization
        }
    }
}
