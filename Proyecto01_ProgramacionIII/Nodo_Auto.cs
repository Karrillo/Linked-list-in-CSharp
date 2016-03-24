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
    public class Nodo_Auto
    {
        private string cedula;
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        private string placa;
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private string estilo;
        public string Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }

        private string año;
        public string Año
        {
            get { return año; }
            set { año = value; }
        }

        public Nodo_Auto siguiente = null;

        /// <summary>
        /// contructor de auto
        /// </summary>
        /// <param name="pcedula"></param>
        /// <param name="pPlaca"></param>
        /// <param name="pMarca"></param>
        /// <param name="pModelo"></param>
        /// <param name="pEstilo"></param>
        /// <param name="pAño"></param>
        public Nodo_Auto(String pcedula, String pPlaca, String pMarca, String pModelo, String pEstilo, String pAño)
        {
            this.cedula = pcedula;
            this.placa = pPlaca;
            this.marca = pMarca;
            this.modelo = pModelo;
            this.estilo = pEstilo;
            this.año = pAño;
        }

        public Nodo_Auto()
        {
            // TODO: Complete member initialization
        }




    }
}
