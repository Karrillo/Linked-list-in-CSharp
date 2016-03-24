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
    public class Cls_Mis_Trabajos : Imetodos<Nodo_Trabajo>
    {
        public Nodo_Trabajo primero_trabajo = null;

        /// <summary>
        /// metodo identifica si existe un nodo de la lista
        /// </summary>
        /// <returns></returns>
        public Boolean existe()
        {
            if (primero_trabajo == null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// metodo que ingresa un nodo en la lista
        /// </summary>
        /// <param name="trabajo"></param>
        public void insertar(Nodo_Trabajo trabajo)
        {

            Nodo_Trabajo temp = new Nodo_Trabajo(trabajo.Cedula_cliente, trabajo.Cedula_empleado, trabajo.Placa_auto, trabajo.Fecha, trabajo.Estado, trabajo.Array_trabajo);

            if (existe())
            {
                primero_trabajo = temp;
                primero_trabajo.siguiente = primero_trabajo;
            }
            else
            {
                temp.siguiente = primero_trabajo.siguiente;
                primero_trabajo.siguiente = temp;
            }
        }

        /// <summary>
        /// metodo que modifica un nodo especifico de la lista
        /// </summary>
        /// <param name="trabajo"></param>
        public void modificar(Nodo_Trabajo trabajo)
        {
            if (!existe())
            {
                Nodo_Trabajo temp = primero_trabajo;
                if (temp.Placa_auto.Equals(trabajo.Placa_auto) && temp.Cedula_empleado.Equals(trabajo.Cedula_empleado) &&
                    temp.Estado.Equals(trabajo.Estado))
                {
                    temp.Cedula_empleado = trabajo.Cedula_empleado;
                    temp.Fecha = trabajo.Fecha;
                    temp.Array_trabajo = trabajo.Array_trabajo;
                    temp.Estado = trabajo.Estado;
                }
                else
                {
                    int tam = size();
                    for (int x = 0; x < tam; x++)
                    {
                        if (temp.Placa_auto.Equals(trabajo.Placa_auto) && temp.Cedula_empleado.Equals(trabajo.Cedula_empleado)
                    && temp.Estado.Equals(trabajo.Estado))
                        {
                            temp.Cedula_empleado = trabajo.Cedula_empleado;
                            temp.Fecha = trabajo.Fecha;
                            temp.Array_trabajo = trabajo.Array_trabajo;
                            temp.Estado = trabajo.Estado;
                            break;
                        }
                        temp = temp.siguiente;
                    }
                }
                primero_trabajo = temp;
            }
        }


        /// <summary>
        /// metodo que borra un nodo especifico de la lista
        /// </summary>
        /// <param name="datos"></param>
        public void borrar(string datos)
        {
            string texto, empleado, placa, fecha;
            texto = datos;
            string[] info = texto.Split(' ');
            empleado = info[0];
            placa = info[1];
            fecha = info[2];
            Nodo_Trabajo temp = primero_trabajo;
            if (primero_trabajo.siguiente == primero_trabajo && primero_trabajo.Placa_auto.Equals(placa) && primero_trabajo.Cedula_empleado.Equals(empleado) &&
                    primero_trabajo.Fecha.Equals(fecha))
            {
                primero_trabajo.siguiente = null;
                primero_trabajo = null;
            }
            else
            {
                int tam = size();
                for (int x = 0; x < tam; x++)
                {
                    if (primero_trabajo.Placa_auto.Equals(placa) && primero_trabajo.Cedula_empleado.Equals(empleado) &&
                        primero_trabajo.Fecha.Equals(fecha))
                    {
                        temp.siguiente = temp.siguiente.siguiente;
                        primero_trabajo = temp;
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
            Nodo_Trabajo temp = primero_trabajo;
            int cont = 0;
            if (!existe())
            {
                cont++;
                while (temp.siguiente != primero_trabajo)
                {
                    cont++;
                    temp = temp.siguiente;
                }
            }
            return cont;
        }

        /// <summary>
        /// metodo que retorna un arreglo con los trabajos de un empleado espeficico
        /// </summary>
        /// <param name="pCedula_empleado"></param>
        /// <returns></returns>
        public string[] get_mis_trabajo(string pCedula_empleado)
        {
            Nodo_Trabajo temp = primero_trabajo;
            int tam = size();
            string[] trabajos = new string[0];
            for (int x = 0; x < tam; x++)
            {
                if (temp.Cedula_empleado.Equals(pCedula_empleado) && temp.Estado != false)
                {
                    Array.Resize<string>(ref trabajos, trabajos.Count() + 1);
                    trabajos[trabajos.Count() - 1] = temp.Cedula_cliente + " " + temp.Placa_auto + " " + temp.Fecha;
                }
                temp = temp.siguiente;
            }
            return trabajos;
        }

        /// <summary>
        /// metodo que retorna un arreglo todos los trabajos pendientes de un auto especifico
        /// </summary>
        /// <param name="pPlaca"></param>
        /// <returns></returns>
        public string[] get_mis_trabajo_auto(string pPlaca)
        {
            Nodo_Trabajo temp = primero_trabajo;
            int tam = size();
            string[] trabajos = new string[0];
            for (int x = 0; x < tam; x++)
            {
                if (temp.Placa_auto.Equals(pPlaca) && temp.Estado != false)
                {
                    for (int y = 0; y < temp.Array_trabajo.Length; y++)
                    {
                        Array.Resize<string>(ref trabajos, trabajos.Count() + 1);
                        trabajos[trabajos.Count() - 1] = temp.Cedula_cliente + " " + temp.Placa_auto + " " + temp.Fecha + " " + temp.Array_trabajo[y];
                    }

                }
                temp = temp.siguiente;
            }
            return trabajos;
        }

        /// <summary>
        /// metodo que retorna los datos de un nodo de trabajo especifico
        /// </summary>
        /// <param name="pCedula_empleado"></param>
        /// <param name="pPlaca"></param>
        /// <param name="pFecha"></param>
        /// <returns></returns>
        public Nodo_Trabajo get_data_trabajo(string pCedula_empleado, string pPlaca, string pFecha)
        {
            Nodo_Trabajo temp = primero_trabajo;
            int tam = size();
            for (int x = 0; x < tam; x++)
            {
                if (temp.Cedula_empleado.Equals(pCedula_empleado) && temp.Placa_auto.Equals(pPlaca) && temp.Fecha.Equals(pFecha) && temp.Estado != false)
                {
                    return temp;
                }
                temp = temp.siguiente;
            }
            return null;
        }

        /// <summary>
        /// metodo que retorna un arreglo de los placas de los autos con trabajo 
        /// </summary>
        /// <returns></returns>
        public String[] get_clienteCarro()
        {
            Nodo_Trabajo temp = primero_trabajo;
            string[] trabajo = new string[size()];

            for (int x = 0; x < size(); x++)
            {
                trabajo[x] = temp.Placa_auto;
                temp = temp.siguiente;
            }
            return trabajo;
        }

        /// <summary>
        /// metodo que retorna un arreglo de los cedula de los clientes con trabajo
        /// </summary>
        /// <returns></returns>
        public String[] get_clienteCliente()
        {
            Nodo_Trabajo temp = primero_trabajo;
            string[] trabajo = new string[size()];

            for (int x = 0; x < size(); x++)
            {
                trabajo[x] = temp.Cedula_cliente;
                temp = temp.siguiente;
            }
            return trabajo;
        }

        /// <summary>
        /// metodo verifica si existe un empleado con la misma fecha para el empleado
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Boolean VerificaFecha(String ID, String fecha)
        {
            Nodo_Trabajo temp = primero_trabajo;
            int tam = size();
            for (int x = 0; x < tam; x++)
            {
                if (temp.Cedula_empleado.Equals(ID))
                {
                    if (temp.Fecha.Equals(fecha))
                    {
                        return true;
                    }
                }
                temp = temp.siguiente;
            }
            return false;
        }

        /// <summary>
        /// metodo verifica si existe un empleado tiene trabajo
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Boolean VerificaEmpleado(String ID)
        {
            Nodo_Trabajo temp = primero_trabajo;
            int tam = size();
            for (int x = 0; x < tam; x++)
            {
                if (temp.Cedula_empleado.Equals(ID))
                {
                    if (temp.Estado == true)
                    {
                        return true;
                    }
                }
                temp = temp.siguiente;
            }
            return false;
        }

        /// <summary>
        /// metodo verifica si existe un empleado tiene trabajo
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Boolean VerificaCliente(String ID)
        {
            Nodo_Trabajo temp = primero_trabajo;
            int tam = size();
            for (int x = 0; x < tam; x++)
            {
                if (temp.Cedula_cliente.Equals(ID))
                {
                    if (temp.Estado == true)
                    {
                        return true;
                    }
                }
                temp = temp.siguiente;
            }
            return false;
        }
        /// <summary>
        /// metodo verifica si existe un empleado tiene trabajo
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Boolean VerificaAuto(String ID)
        {
            Nodo_Trabajo temp = primero_trabajo;
            int tam = size();
            for (int x = 0; x < tam; x++)
            {
                if (temp.Placa_auto.Equals(ID))
                {
                    if (temp.Estado == true)
                    {
                        return true;
                    }
                }
                temp = temp.siguiente;
            }
            return false;
        }
    }
}
