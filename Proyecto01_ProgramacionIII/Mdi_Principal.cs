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
    public partial class Mdi_Principal : Form
    {

        //instancia de conector
        public static Cls_Conectar conector;

        /// <summary>
        /// inicializacion de la instancia a conectar
        /// </summary>
        public void iniciar_conectar()
        {
            conector = new Cls_Conectar();
            conector.iniciar_clases_conector();
        }

        public Mdi_Principal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// llama al formulario de ingresar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Ingresado ingresa = new Frm_Ingresado();
            ingresa.Show();
            ingresa.MdiParent = this;
        }


        /// <summary>
        /// llama el formulario de gestion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Gestion gestion = new Frm_Gestion();
            gestion.Show();
            gestion.MdiParent = this;
        }

        /// <summary>
        /// llama al formulario de consultas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Consultas consultas = new Frm_Consultas();
            consultas.Show();
            consultas.MdiParent = this;

        }

        /// <summary>
        /// sale de la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// inicializa la instancia de la clase de conectar que inicializa las clases de clientes/empleado,auto y trabajo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Principal_Load(object sender, EventArgs e)
        {
            iniciar_conectar();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayuda acerca = new ayuda();
            acerca.MdiParent = this;
            acerca.Show();
        }
        public static void habilitar()
        {
            
        }
    }
}
