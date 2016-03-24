using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto01_ProgramacionIII
{
    public partial class ayuda : Form
    {
        public ayuda()
        {
            InitializeComponent();
        }

        /// <summary>
        /// cerra el formulario de ayuda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// cargar con un label con informacion del proyecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ayuda_Load(object sender, EventArgs e)
        {
            Lb_informe.Text = "Taller Macanico © Version 1.0 \n\n Este Software esta diseñado para el control de los \n talleres mecanicos, manejando el control de los \n clientes, empleados, autos y sus respectivos trabajos \n para un mejor administracion \n\n" +
                "Creado y diseñado por: \n Jose Miguel Rojas \n Jose Carrillo Mendez \n\n Dudas o Consultas: \n TallerMecanicoU@hotmail.com \n 800-000-852-0251";
        }

        private void ayuda_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
