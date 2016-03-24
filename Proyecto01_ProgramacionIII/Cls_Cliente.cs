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
    public class Cls_Cliente : Cls_Persona, Imetodos<Cls_Persona>
    {

        /// <summary>
        /// constructor de clientes
        /// </summary>
        public Cls_Cliente()
        {
            cedula = string.Empty;
            nombre = string.Empty;
            apellido = string.Empty;
            telefono = string.Empty;
            direccion = string.Empty;
        }

        /// <summary>
        /// contructor de clientes
        /// </summary>
        /// <param name="pCedula"></param>
        /// <param name="pNombre"></param>
        /// <param name="pApellido"></param>
        /// <param name="pTelefono"></param>
        /// <param name="pDireccion"></param>
        public Cls_Cliente(String pCedula, String pNombre, String pApellido, String pTelefono, String pDireccion)
        {
            cedula = pCedula;
            nombre = pNombre;
            apellido = pApellido;
            telefono = pTelefono;
            direccion = pDireccion;
        }

        
        public Nodo_Cliente primero_cliente;

        /// <summary>
        /// inicializar primer cliente
        /// </summary>
        public void iniciar_clase()
        {
            primero_cliente = null;
        }

        /// <summary>
        /// metodo identifica si existe un nodo de la lista
        /// </summary>
        /// <returns></returns>
        public Boolean existe()
        {
            if (primero_cliente == null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// insertar un nodo en la lista de cliente
        /// </summary>
        /// <param name="cliente"></param>
        public void insertar(Cls_Persona cliente)
        {

            Nodo_Cliente temp = new Nodo_Cliente(cliente);

            if (existe())
            {
                primero_cliente = temp;
                primero_cliente.siguiente = primero_cliente;
            }
            else
            {
                temp.siguiente = primero_cliente.siguiente;
                primero_cliente.siguiente = temp;
            }
        }

        /// <summary>
        /// metodo que modifica un nodo especifico de la lista
        /// </summary>
        /// <param name="cliente"></param>
        public void modificar(Cls_Persona cliente)
        {
            if (!existe())
            {
                Nodo_Cliente temp = primero_cliente;
                if (temp.cliente.cedula.Equals(cliente.cedula))
                {
                    temp.cliente = cliente;
                }
                else
                {
                    int tam = size();
                    for (int x = 0; x < tam; x++)
                    {
                        if (temp.cliente.cedula.Equals(cliente.cedula))
                        {
                            temp.cliente = cliente;
                            break;
                        }
                        temp = temp.siguiente;
                    }
                }
                primero_cliente = temp;
            }
        }

        /// <summary>
        /// metodo que borra un nodo especifico de la lista
        /// </summary>
        /// <param name="cedula"></param>
        public void borrar(string cedula)
        {
            Nodo_Cliente temp = primero_cliente;
            if (primero_cliente.siguiente == primero_cliente && primero_cliente.cliente.cedula.Equals(cedula))
            {
                primero_cliente.siguiente = null;
                primero_cliente = null;
            }
            else
            {
                int tam = size();
                for (int x = 0; x < tam; x++)
                {
                    if (temp.siguiente.cliente.cedula.Equals(cedula))
                    {

                        temp.siguiente = temp.siguiente.siguiente;
                        primero_cliente = temp;
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
            Nodo_Cliente temp = primero_cliente;
            int cont = 0;
            if (!existe())
            {
                cont++;
                while (temp.siguiente != primero_cliente)
                {
                    cont++;
                    temp = temp.siguiente;
                }
            }
            return cont;
        }

        /// <summary>
        /// metodo que retorna un objeto de una lista especifica
        /// </summary>
        /// <param name="pCedula"></param>
        /// <returns></returns>
        public Cls_Persona get_data_cliente(String pCedula)
        {
            if (!existe())
            {
                Nodo_Cliente temp = primero_cliente;
                int tam = size();
                for (int x = 0; x < tam; x++)
                {
                    if (temp.cliente.cedula.Equals(pCedula))
                    {
                        return temp.cliente;
                    }
                    temp = temp.siguiente;
                }
            }
            return null;
        }

        /// <summary>
        /// retorna un arreglo con los clientes de la lista de clientes
        /// </summary>
        /// <returns></returns>
        public String[] get_cliente()
        {
            Nodo_Cliente temp = primero_cliente;
            string[] cliente = new string[size()];

            for (int x = 0; x < size(); x++)
            {
                cliente[x] = temp.cliente.cedula;
                temp = temp.siguiente;
            }
            return cliente;
        }

        /// <summary>
        /// metodo verifica si existe un cliente con la misma cedula
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Boolean VerificaCedula(String ID)
        {
            Nodo_Cliente temp = primero_cliente;
            int tam = size();
            for (int x = 0; x < tam; x++)
            {
                if (temp.cliente.cedula.Equals(ID))
                {
                    return true;
                }
                temp = temp.siguiente;
            }
            return false;
        }


    }
}
