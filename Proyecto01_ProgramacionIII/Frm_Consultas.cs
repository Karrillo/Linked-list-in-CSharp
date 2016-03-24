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
    public partial class Frm_Consultas : Form
    {
        string[] datos_consulta;

        public Frm_Consultas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// si el radio boton de empleado esta seleccionado habilita el label de clientes y desabilita el 
        /// label de placa y llama el metodo load_checkbox()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_empleado_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_empleado.Checked == true)
            {
                lbl_cedula_consulta.Visible = true;
                lbl_placa_consulta.Visible = false;
            }
            if (rb_empleado.Checked == true)
            {
                cb_consu.Items.Clear();
                cb_consu.Items.AddRange(Mdi_Principal.conector.empleado.get_empleado());
                if (cb_consu.Items.Count > 0)
                {
                    cb_consu.SelectedIndex = 0;
                }
            }
            else
            {
                cb_consu.Items.Clear();
                cb_consu.Items.AddRange(Mdi_Principal.conector.auto.get_Autos());
                if (cb_consu.Items.Count > 0)
                {
                    cb_consu.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// si el radio boton de empleado esta seleccionado habilita el label de placa y desabilita 
        /// el label de cliente y llama el metodo load_checkbox()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_auto_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_auto.Checked == true)
            {
                lbl_placa_consulta.Visible = true;
                lbl_cedula_consulta.Visible = false;
            }
            if (rb_empleado.Checked == true)
            {
                cb_consu.Items.Clear();
                cb_consu.Items.AddRange(Mdi_Principal.conector.empleado.get_empleado());
                if (cb_consu.Items.Count > 0)
                {
                    cb_consu.SelectedIndex = 0;
                }
            }
            else
            {
                cb_consu.Items.Clear();
                cb_consu.Items.AddRange(Mdi_Principal.conector.auto.get_Autos());
                if (cb_consu.Items.Count > 0)
                {
                    cb_consu.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// llama al metodo load_checkbox()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Consultas_Load(object sender, EventArgs e)
        {
            if (rb_empleado.Checked == true)
            {
                cb_consu.Items.Clear();
                cb_consu.Items.AddRange(Mdi_Principal.conector.empleado.get_empleado());
                if (cb_consu.Items.Count > 0)
                {
                    cb_consu.SelectedIndex = 0;
                }
            }
            else
            {
                cb_consu.Items.Clear();
                cb_consu.Items.AddRange(Mdi_Principal.conector.auto.get_Autos());
                if (cb_consu.Items.Count > 0)
                {
                    cb_consu.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// llama al metodo load_checkbox() si seleccion el combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_consulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_checkbox();
        }

        /// <summary>
        /// verifica si el radio boton de empleado esta checked para habilitar o desabilitar 
        /// componentes y cargarlos con datos
        /// </summary>
        public void load_checkbox()
        {
            //si empleados es true carga datos en el combo box y cargara sus datos en el DataGridView con cliente/placa/fecha
            if (rb_empleado.Checked == true)
            {
                datos_consulta = Mdi_Principal.conector.trabajo.get_mis_trabajo(cb_consu.Text);
                string texto;
                //crea columnas en el DataGridView
                dgv_consulta.Columns.Clear();
                dgv_consulta.ColumnCount = 3;
                dgv_consulta.Columns[0].Name = "Cliente";
                dgv_consulta.Columns[1].Name = "Placa";
                dgv_consulta.Columns[2].Name = "Fecha";
                dgv_consulta.Columns[0].ReadOnly = true;
                dgv_consulta.Columns[1].ReadOnly = true;
                dgv_consulta.Columns[2].ReadOnly = true;
                for (int x = 0; x < datos_consulta.Length; x++)
                {
                    texto = datos_consulta[x];
                    string[] info = texto.Split(' ');
                    dgv_consulta.Rows.Add(info);
                }
            }
            //si empleados es false carga datos en el combo box y cargara sus datos en el DataGridView con cliente/placa/fecha/trabajos
            else
            {
                datos_consulta = Mdi_Principal.conector.trabajo.get_mis_trabajo_auto(cb_consu.Text);
                string texto;
                //crea columnas en el DataGridView
                dgv_consulta.Columns.Clear();
                dgv_consulta.ColumnCount = 4;
                dgv_consulta.Columns[0].Name = "Cliente";
                dgv_consulta.Columns[1].Name = "Placa";
                dgv_consulta.Columns[2].Name = "Fecha";
                dgv_consulta.Columns[3].Name = "Trabajo";
                dgv_consulta.Columns[0].ReadOnly = true;
                dgv_consulta.Columns[1].ReadOnly = true;
                dgv_consulta.Columns[2].ReadOnly = true;
                dgv_consulta.Columns[3].ReadOnly = true;
                for (int x = 0; x < datos_consulta.Length; x++)
                {
                    texto = datos_consulta[x];
                    string[] info = texto.Split(' ');
                    dgv_consulta.Rows.Add(info);
                }
            }
        }

        /// <summary>
        /// cerrar formulario de consultas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// llama al metodo load_checkbox() si seleccion el combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_consulta_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            load_checkbox();
        }

        /// <summary>
        /// llama al metodo load_checkbox() si seleccion el combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_consu_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_checkbox();
        }

        private void Frm_Consultas_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
