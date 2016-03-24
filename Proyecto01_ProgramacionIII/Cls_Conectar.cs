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
    public class Cls_Conectar
    {
        //instancias de clases
        public Cls_Cliente cliente;
        public Cls_Empleado empleado;
        public Cls_Mis_Autos auto;
        public Cls_Mis_Trabajos trabajo;

        /// <summary>
        /// una clase de tipo persona
        /// </summary>
        public class Persona_data
        {
            public Cls_Persona persona { get; set; }
            public int tipo { get; set; }
        }

        /// <summary>
        /// inicializacion de las instancias 
        /// </summary>
        public void iniciar_clases_conector()
        {
            cliente = new Cls_Cliente();
            empleado = new Cls_Empleado();
            auto = new Cls_Mis_Autos();
            trabajo = new Cls_Mis_Trabajos();
        }

        /// <summary>
        /// metodo el cual retorna un arreglo con personas de clientes y empleados
        /// sin repetir en el arreglo 
        /// </summary>
        /// <returns></returns>
        public string[] get_persona()
        {
            string[] array_personas;
            string[] array_cliente;
            string[] array_empleado;

            Boolean estado;
            //llena arreglos de cliente y empleado
            array_cliente = cliente.get_cliente();
            array_empleado = empleado.get_empleado();
            //llena array de personas con clientes
            array_personas = array_cliente;

            for (int x = 0; x < empleado.size(); x++)
            {
                estado = false;

                for (int y = 0; y < cliente.size(); y++)
                {
                    if (array_empleado[x].Equals(array_cliente[y]))
                    {
                        estado = true;
                    }
                }

                if (estado == false)
                {   
                    Array.Resize<string>(ref array_personas, array_personas.Count() + 1);
                    array_personas[array_personas.Count() - 1] = array_empleado[x];
                }
            }
            return array_personas;
        }

        /// <summary>
        /// metodo retorna un objeto de la clase tipo persona de la lista cliente y empleado especifico
        /// </summary>
        /// <param name="pCedula"></param>
        /// <returns></returns>
        public Persona_data get_data_persona(string pCedula)
        {
            Persona_data Cls_persona = new Persona_data();
            Persona_data Cls_empleado = new Persona_data();

            Cls_persona.persona = cliente.get_data_cliente(pCedula);
            //Clientes
            if (Cls_persona.persona != null)
            {
                Cls_persona.tipo = 1;
            }

            Cls_empleado.persona = empleado.get_data_empleado(pCedula);
            //Empleados
            if (Cls_empleado.persona != null)
            {
                Cls_persona.tipo = Cls_persona.tipo + 2;
                if (Cls_persona.persona == null)
                {
                    Cls_persona.persona = empleado.get_data_empleado(pCedula);
                }
            }
            return Cls_persona;
        }



    }

}

