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
    /// <typeparam name="T"></typeparam>
    public interface Imetodos<T>
    {
        /// <summary>
        /// verifica si la lista tiene o no nodos
        /// </summary>
        /// <returns></returns>
        Boolean existe();
        /// <summary>
        /// inserta un nodo a la lista
        /// </summary>
        /// <param name="ob"></param>
        void insertar(T ob);
        /// <summary>
        /// modifica un nodo de lista 
        /// </summary>
        /// <param name="ob"></param>
        void modificar(T ob);
        /// <summary>
        /// borra un nodo a la lista
        /// </summary>
        /// <param name="ID"></param>
        void borrar(string ID);
    }
}
