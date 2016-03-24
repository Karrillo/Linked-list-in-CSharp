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
    public class Cls_Empleado : Cls_Persona, Imetodos<Cls_Persona>
    {
        /// <summary>
        /// contructor 
        /// </summary>
        public Cls_Empleado()
        {
            cedula = string.Empty;
            nombre = string.Empty;
            apellido = string.Empty;
            telefono = string.Empty;
            direccion = string.Empty;
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="pCedula"></param>
        /// <param name="pNombre"></param>
        /// <param name="pApellido"></param>
        /// <param name="pTelefono"></param>
        /// <param name="pDireccion"></param>
        public Cls_Empleado(String pCedula, String pNombre, String pApellido, String pTelefono, String pDireccion)
        {
            this.cedula = pCedula;
            this.nombre = pNombre;
            this.apellido = pApellido;
            this.telefono = pTelefono;
            this.direccion = pDireccion;
        }

        public Nodo_Empleado primero_Empleado;

        /// <summary>
        /// inicializacion de primer empleado
        /// </summary>
        public void iniciar_clase()
        {
            primero_Empleado = null;
        }

        /// <summary>
        /// metodo identifica si existe un nodo de la lista
        /// </summary>
        /// <returns></returns>
        public Boolean existe()
        {
            if (primero_Empleado == null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// metodo que inserta un nuevo nodo en la lista de empleados
        /// </summary>
        /// <param name="empleado"></param>
        public void insertar(Cls_Persona empleado)
        {

            Nodo_Empleado temp = new Nodo_Empleado(empleado);

            if (existe())
            {
                primero_Empleado = temp;
                primero_Empleado.siguiente = primero_Empleado;
            }
            else
            {
                temp.siguiente = primero_Empleado.siguiente;
                primero_Empleado.siguiente = temp;
            }
        }

        /// <summary>
        /// metodo que modifica un nodo especifico de la lista
        /// </summary>
        /// <param name="empleado"></param>
        public void modificar(Cls_Persona empleado)
        {
            if (!existe())
            {
                Nodo_Empleado temp = primero_Empleado;
                if (temp.empleado.cedula.Equals(empleado.cedula))
                {
                    temp.empleado = empleado;
                }
                else
                {
                    int tam = size();
                    for (int x = 0; x < tam; x++)
                    {
                        if (temp.empleado.cedula.Equals(empleado.cedula))
                        {
                            temp.empleado = empleado;
                            break;
                        }
                        temp = temp.siguiente;
                    }
                }
                primero_Empleado = temp;
            }
        }

        /// <summary>
        /// metodo que borra un nodo especifico de la lista
        /// </summary>
        /// <param name="cedula"></param>
        public void borrar(string cedula)
        {
            Nodo_Empleado temp = primero_Empleado;
            if (primero_Empleado.siguiente == primero_Empleado && primero_Empleado.empleado.cedula.Equals(cedula))
            {
                primero_Empleado.siguiente = null;
                primero_Empleado = null;
            }
            else
            {
                int tam = size();
                for (int x = 0; x < tam; x++)
                {
                    if (temp.siguiente.empleado.cedula.Equals(cedula))
                    {

                        temp.siguiente = temp.siguiente.siguiente;
                        primero_Empleado = temp;
                        break;
                    }
                    temp = temp.siguiente;
                }
            }
        }

        /// <summary>
        /// metodo que realiza un conteo de la lista existente
        /// </summary>
        /// <returns></returns>
        public int size()
        {
            Nodo_Empleado temp = primero_Empleado;
            int cont = 0;
            if (!existe())
            {
                cont++;
                while (temp.siguiente != primero_Empleado)
                {
                    cont++;
                    temp = temp.siguiente;
                }
            }
            return cont;
        }

        /// <summary>
        /// metodo que retorna un objeto especifico de la lista de empleados
        /// </summary>
        /// <param name="pCedula"></param>
        /// <returns></returns>
        public Cls_Persona get_data_empleado(String pCedula)
        {
            if (!existe())
            {
                Nodo_Empleado temp = primero_Empleado;
                int tam = size();
                for (int x = 0; x < tam; x++)
                {
                    if (temp.empleado.cedula.Equals(pCedula))
                    {
                        return temp.empleado;
                    }
                    temp = temp.siguiente;
                }
            }
            return null;
        }

        /// <summary>
        /// metodo que retorna un arreglo con los empleados de la lista de empleados
        /// </summary>
        /// <returns></returns>
        public String[] get_empleado()
        {
            Nodo_Empleado temp = primero_Empleado;
            int tam = size();
            string[] empleado = new string[tam];

            for (int x = 0; x < tam; x++)
            {
                empleado[x] = temp.empleado.cedula;
                temp = temp.siguiente;
            }
            return empleado;
        }

        /// <summary>
        /// metodo verifica si existe un empleado con la misma cedula
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Boolean VerificaCedula(String ID)
        {
            Nodo_Empleado temp = primero_Empleado;
            int tam = size();
            for (int x = 0; x < tam; x++)
            {
                if (temp.empleado.cedula.Equals(ID))
                {
                    return true;
                }
                temp = temp.siguiente;
            }
            return false;
        }

    }
}



