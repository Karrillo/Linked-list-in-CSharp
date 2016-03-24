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
    public class Cls_Mis_Autos : Imetodos<Nodo_Auto>
    {
        public Nodo_Auto primero_Auto = null;

        /// <summary>
        /// metodo identifica si existe un nodo de la lista
        /// </summary>
        /// <returns></returns>
        public Boolean existe()
        {
            if (primero_Auto == null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// metodo que inserta un nuevo nodo de la lista de autos
        /// </summary>
        /// <param name="auto"></param>
        public void insertar(Nodo_Auto auto)
        {

            Nodo_Auto temp = new Nodo_Auto(auto.Cedula, auto.Placa, auto.Marca, auto.Modelo, auto.Estilo, auto.Año);

            if (existe())
            {
                primero_Auto = temp;
                primero_Auto.siguiente = primero_Auto;
            }
            else
            {
                temp.siguiente = primero_Auto.siguiente;
                primero_Auto.siguiente = temp;
            }
        }

        /// <summary>
        /// metodo que modifica un nodo especifico de la lista
        /// </summary>
        /// <param name="auto"></param>
        public void modificar(Nodo_Auto auto)
        {
            if (!existe())
            {
                Nodo_Auto temp = primero_Auto;
                if (temp.Placa.Equals(auto.Placa) && temp.Cedula.Equals(auto.Cedula))
                {
                    temp.Marca = auto.Marca;
                    temp.Modelo = auto.Modelo;
                    temp.Estilo = auto.Estilo;
                    temp.Año = auto.Año;
                }
                else
                {
                    int tam = size();
                    for (int x = 0; x < tam; x++)
                    {
                        if (temp.Placa.Equals(auto.Placa))
                        {
                            temp.Marca = auto.Marca;
                            temp.Modelo = auto.Modelo;
                            temp.Estilo = auto.Estilo;
                            temp.Año = auto.Año;
                            break;
                        }
                        temp = temp.siguiente;
                    }
                }
                primero_Auto = temp;
            }
        }

        /// <summary>
        /// metodo que borra un nodo especifico de la lista
        /// </summary>
        /// <param name="placa"></param>
        public void borrar(string placa)
        {
            Nodo_Auto temp = primero_Auto;
            if (primero_Auto.siguiente == primero_Auto && primero_Auto.Placa.Equals(placa))
            {
                primero_Auto.siguiente = null;
                primero_Auto = null;
            }
            else
            {
                int tam = size();
                for (int x = 0; x < tam; x++)
                {
                    if (temp.siguiente.Placa.Equals(placa))
                    {
                        temp.siguiente = temp.siguiente.siguiente;
                        primero_Auto = temp;
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
            Nodo_Auto temp = primero_Auto;
            int cont = 0;
            if (!existe())
            {
                cont++;
                while (temp.siguiente != primero_Auto)
                {
                    cont++;
                    temp = temp.siguiente;
                }
            }
            return cont;
        }

        /// <summary>
        /// metodo que retorna un objeto con datos de autos especifico
        /// </summary>
        /// <param name="placa"></param>
        /// <returns></returns>
        public Nodo_Auto get_data_Auto(String placa)
        {
            if (!existe())
            {
                Nodo_Auto temp = primero_Auto;

                int tam = size();
                for (int x = 0; x < tam; x++)
                {
                    if (temp.Placa.Equals(placa))
                    {
                        return temp;
                    }
                    temp = temp.siguiente;
                }
            }
            return null;
        }

        /// <summary>
        /// metodo que retorna una lista de autos de la lista de autos
        /// </summary>
        /// <returns></returns>
        public String[] get_Autos()
        {
            Nodo_Auto temp = primero_Auto;
            string[] autos = new string[size()];
            int tam = size();
            for (int x = 0; x < tam; x++)
            {
                autos[x] = temp.Placa;
                temp = temp.siguiente;
            }
            return autos;
        }

        /// <summary>
        /// metodo que retorna un arreglo con los autos de un cliente especifico
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public String[] get_Autos_trabajo(string cedula)
        {
            Nodo_Auto temp = primero_Auto;
            int tam = size();
            string[] autos = new string[0];
            for (int x = 0; x < tam; x++)
            {
                if (temp.Cedula.Equals(cedula))
                {
                    Array.Resize<string>(ref autos, autos.Count() + 1);
                    autos[autos.Count() - 1] = temp.Placa;

                }
                temp = temp.siguiente;
            }
            return autos;
        }

        /// <summary>
        /// metodo que un int de cantidad de los autos especifico
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public int get_AutosCliente(string cedula)
        {
            Nodo_Auto temp = primero_Auto;
            int tam = size();
            int cont = 0;
            string[] cliente = new string[tam];

            for (int x = 0; x < tam; x++)
            {
                if (temp.Cedula.Equals(cedula))
                {
                    cont = cont + 1;
                }
                temp = temp.siguiente;
            }
            return cont;
        }

        /// <summary>
        /// metodo verifica si existe un empleado con la misma placa
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Boolean VerificaPlaca(String placa)
        {
            Nodo_Auto temp = primero_Auto;
            int tam = size();
            for (int x = 0; x < tam; x++)
            {
                if (temp.Placa.Equals(placa))
                {
                    return true;
                }
                temp = temp.siguiente;
            }
            return false;
        }

        /// <summary>
        /// metodo verifica si existe un empleado con la misma placa
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Boolean VerificaCedula(String ID)
        {
            Nodo_Auto temp = primero_Auto;
            int tam = size();
            for (int x = 0; x < tam; x++)
            {
                if (temp.Cedula.Equals(ID))
                {
                    return true;
                }
                temp = temp.siguiente;
            }
            return false;
        }

    }
}
