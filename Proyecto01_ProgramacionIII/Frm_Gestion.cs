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
    public partial class Frm_Gestion : Form
    {
        int tipo = 0;
        Cls_Conectar.Persona_data datos;
        Nodo_Trabajo datos_trabajo;

        string[] datos_cliente_trabajo;
        string[] datos_fecha_trabajo;

        public Frm_Gestion()
        {
            InitializeComponent();
        }

        private void check_empleado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void check_cliente_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// al iniciar formulario llama metodo de valicion de componentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_MIngresado_Load(object sender, EventArgs e)
        {
            Cargar_Auto();
            Cargar_Persona();
            Cargar_empleado();
        }

        /// <summary>
        /// establecer los archivos en los componentes al seleccionar otro items en el combo box de cliente/empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_cedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            //carga los datos segun la cedula de persona enviada
            datos = Mdi_Principal.conector.get_data_persona(cb_cedula.Text);
            //limpia los componentes
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_telefono.Clear();
            txt_direccion.Clear();
            //llena datos segun el cliente 
            txt_nombre.Text = datos.persona.nombre;
            txt_apellido.Text = datos.persona.apellido;
            txt_telefono.Text = datos.persona.telefono;
            txt_direccion.Text = datos.persona.direccion;
            //Cliente
            if (datos.tipo == 1)
            {
                check_cliente.Checked = true;
                check_empleado.Checked = false;
            }
            //Empleado
            else if (datos.tipo == 2)
            {
                check_cliente.Checked = false;
                check_empleado.Checked = true;
            }
            //Cliente y Empleado
            else
            {
                check_cliente.Checked = true;
                check_empleado.Checked = true;
            }

        }

        /// <summary>
        /// cerrar el formulario desde clientes/empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// evento de click de modificar el cual envia datos para modificar cliente/empleado especifico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_modificar_Click(object sender, EventArgs e)
        {
            //ingresa los datos de los componentes en objeto
            datos.persona.nombre = txt_nombre.Text;
            datos.persona.apellido = txt_apellido.Text;
            datos.persona.telefono = txt_telefono.Text;
            datos.persona.direccion = txt_direccion.Text;
            //Cliente
            if ((check_cliente.Checked == true) & (check_empleado.Checked == false))
            {
                tipo = 1;
                if (tipo.Equals(datos.tipo))
                {
                    Mdi_Principal.conector.cliente.modificar(datos.persona);
                }
                else
                {
                    Mdi_Principal.conector.cliente.insertar(datos.persona);
                    Mdi_Principal.conector.empleado.borrar(cb_cedula.Text);
                }

                MessageBox.Show("Datos Modificados Correctamente", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //Empleado
            else if ((check_cliente.Checked == false) & (check_empleado.Checked == true))
            {
                tipo = 2;
                if (tipo.Equals(datos.tipo))
                {
                    Mdi_Principal.conector.empleado.modificar(datos.persona);
                }
                else
                {
                    Mdi_Principal.conector.empleado.insertar(datos.persona);
                    Mdi_Principal.conector.cliente.borrar(cb_cedula.Text);
                }

                MessageBox.Show("Datos Modificados Correctamente", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Cliente/Empleado
            else
            {
                tipo = 3;
                if (tipo.Equals(datos.tipo))
                {
                    Mdi_Principal.conector.cliente.modificar(datos.persona);
                    Mdi_Principal.conector.empleado.modificar(datos.persona);
                }
                else
                {
                    if (datos.tipo == 1)
                    {
                        Mdi_Principal.conector.empleado.insertar(datos.persona);
                        Mdi_Principal.conector.cliente.modificar(datos.persona);
                    }
                    else
                    {
                        Mdi_Principal.conector.cliente.insertar(datos.persona);
                        Mdi_Principal.conector.empleado.modificar(datos.persona);
                    }
                }
                MessageBox.Show("Datos Modificados Correctamente", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Carga los datos en Cliente/Empleado o los bloquea si no encuentra datos
        /// </summary>
        public void Cargar_Persona()
        {
            cb_cedula.Items.Clear();
            cb_cedula.Items.AddRange(Mdi_Principal.conector.get_persona());

            if (cb_cedula.Items.Count != 0)
            {
                cb_cedula.SelectedIndex = 0;
            }
            else
            {
                cb_cedula.Text = "No hay datos en el sistema";
                cb_cedula.Enabled = false;
                txt_nombre.Enabled = false;
                txt_apellido.Enabled = false;
                txt_telefono.Enabled = false;
                txt_direccion.Enabled = false;
                check_cliente.Enabled = false;
                check_empleado.Enabled = false;
                bt_modificar.Enabled = false;
                bt_borrarC.Enabled = false;
                cb_cedula.SelectedIndex = -1;
                txt_nombre.Clear();
                txt_apellido.Clear();
                txt_telefono.Clear();
                txt_direccion.Clear();
                check_cliente.Checked = false;
                check_empleado.Checked = false;
            }
        }

        /// <summary>
        /// Carga los datos en auto o los bloquea si no encuentra datos
        /// </summary>
        public void Cargar_Auto()
        {
            cb_placa.Items.Clear();
            cb_placa.Items.AddRange(Mdi_Principal.conector.auto.get_Autos());
            if (cb_placa.Items.Count > 0)
            {
                cb_placa.SelectedIndex = 0;
                cb_placa_trabajo.Enabled = true;
            }
            else
            {
                cb_placa_trabajo.Text = "No hay Datos";
                cb_placa_trabajo.Enabled = false;
                cb_clienteA.Text = "No hay Datos";
                cb_placa.Text = "No hay Autos";
                cb_clienteA.Enabled = false;
                cb_placa.Enabled = false;
                txt_modelo.Enabled = false;
                cb_estilo.Enabled = false;
                cb_año.Enabled = false;
                cb_marca.Enabled = false;
                btn_borrarA.Enabled = false;
                bt_modificarA.Enabled = false;
                txt_modelo.Clear();
                cb_estilo.SelectedIndex = -1;
                cb_año.SelectedIndex = -1;
                cb_marca.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// evento click el cual modifica auto de la lista especifico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_modificarA_Click(object sender, EventArgs e)
        {

            if (txt_modelo.Text != string.Empty)
            {
                Nodo_Auto Datos_autos = new Nodo_Auto();
                //carga los datos al objeto
                Datos_autos.Placa = cb_placa.Text;
                Datos_autos.Marca = cb_marca.Text;
                Datos_autos.Estilo = cb_estilo.Text;
                Datos_autos.Año = cb_año.Text;
                Datos_autos.Modelo = txt_modelo.Text;
                Datos_autos.Cedula = cb_clienteA.Text;
                //envia el objeto a modificar el nodo de la lista de autos 
                Mdi_Principal.conector.auto.modificar(Datos_autos);
                MessageBox.Show("Datos Modificados Correctamente", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingresar modelo del auto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_modelo.Focus();
            }

        }

        /// <summary>
        /// carga los datos segun lo seleccionado en el comboBox de cliente para mostrarlos en tab autos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_placa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nodo_Auto dato = Mdi_Principal.conector.auto.get_data_Auto(cb_placa.Text);
            //muestra los datos en los componentes
            cb_clienteA.Items.Clear();
            cb_clienteA.Text = dato.Cedula;
            cb_marca.Text = dato.Marca;
            cb_estilo.Text = dato.Estilo;
            cb_año.Text = dato.Año;
            txt_modelo.Text = dato.Modelo;
        }

        /// <summary>
        /// cierra el formulacio desde modificacion de autos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salirA_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// borrar datos de clientes/empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_borrarC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente quiere borrar este dato", "Informativo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //Cliente
                if ((check_cliente.Checked == true) & (check_empleado.Checked == false))
                {
                    //verifica si el cliente tiene un auto con trabajos pendientes
                    if (Mdi_Principal.conector.trabajo.VerificaCliente(cb_cedula.Text) == false)
                    {
                        //elimina el cliente de la lista
                        Mdi_Principal.conector.cliente.borrar(cb_cedula.Text);

                        MessageBox.Show("Cliente eliminado del sistema", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //verifica si el cliente borrado posee un auto si lo tiene lo elimina
                        if (Mdi_Principal.conector.auto.VerificaCedula(cb_cedula.Text) == true)
                        {
                            Mdi_Principal.conector.auto.borrar(Mdi_Principal.conector.auto.get_data_Auto(cb_cedula.Text).Placa);
                            Cargar_Auto();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente tiene un auto un trabajo pendiente", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

                //Empleados
                else if ((check_cliente.Checked == false) & (check_empleado.Checked == true))
                {
                    //verifica si el empleado tiene trabajos pendientes
                    if (Mdi_Principal.conector.trabajo.VerificaEmpleado(cb_cedula.Text) == false)
                    {
                        Mdi_Principal.conector.empleado.borrar(cb_cedula.Text);
                        MessageBox.Show("Empleado eliminado del sistema", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar_empleado();
                    }
                    else
                    {
                        MessageBox.Show("Este empleado no se puede eliminar porque tiene trabajos pendientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //Cliente/Empleados
                else
                {
                    if (Mdi_Principal.conector.trabajo.VerificaCliente(cb_cedula.Text) == false)
                    {
                        if (Mdi_Principal.conector.trabajo.VerificaEmpleado(cb_cedula.Text) == false)
                        {
                            Mdi_Principal.conector.cliente.borrar(cb_cedula.Text);
                            Mdi_Principal.conector.empleado.borrar(cb_cedula.Text);
                            if (Mdi_Principal.conector.auto.VerificaCedula(cb_cedula.Text) == true)
                            {
                                Mdi_Principal.conector.auto.borrar(Mdi_Principal.conector.auto.get_data_Auto(cb_cedula.Text).Placa);
                                Cargar_Auto();
                            }
                            MessageBox.Show("Datos de cliente y empleado fueron eliminados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Este empleado no se puede eliminar porque tiene trabajos pendientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente tiene un auto con un trabajo pendiente", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                //Validar
                Cargar_Persona();
            }

        }

        /// <summary>
        /// borrar datos de la lista de autos segun especifique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_borrarA_Click(object sender, EventArgs e)
        {
            if (Mdi_Principal.conector.auto.get_AutosCliente(cb_clienteA.Text) > 1)
            {
                if (Mdi_Principal.conector.trabajo.VerificaAuto(cb_placa.Text) == false)
                {
                    if (MessageBox.Show("Realmente quiere borrar este dato", "Informativo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Mdi_Principal.conector.auto.borrar(cb_placa.Text);
                        MessageBox.Show("Auto eliminado correctamente", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Cargar_Auto();
                }
                else
                {
                    MessageBox.Show("Auto no se puede eliminar porque tiene un trabajo pendiente", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar este auto porque el cliente solo posee uno en el sistema", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// cierra un formulario desde trabajo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_STrabajos_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// evento click el cual modifica trabajos de la lista especifico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_modificarT_Click(object sender, EventArgs e)
        {
            if (cbl_trabajos.CheckedItems.Count == 0)
            {
                MessageBox.Show("No Hay Trabajos Seleccionados al auto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_empleado_trabajo.Focus();

            }
            else
            {
                String[] lista_trabajos = new String[cbl_trabajos.CheckedItems.Count];
                //carga los datos de trabajos del auto a un arreglo
                int x = 0;
                foreach (var lista in cbl_trabajos.CheckedItems)
                {
                    lista_trabajos[x] = lista.ToString();
                    x = x + 1;
                }
                //carga datos de los componentes al objeto
                datos_trabajo.Cedula_cliente = txt_cliente_trabajo.Text;
                datos_trabajo.Cedula_empleado = cb_empleado_trabajo.Text;
                datos_trabajo.Placa_auto = cb_placa_trabajo.Text;
                datos_trabajo.Estado = true;
                datos_trabajo.Array_trabajo = lista_trabajos;
                if (datos_trabajo.Fecha.Equals(mc_trabajo.SelectionEnd.ToShortDateString()))
                {
                    Mdi_Principal.conector.trabajo.modificar(datos_trabajo);
                    MessageBox.Show("Trabajo Modificado", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_empleado();
                }
                else
                {
                    
                    if (Mdi_Principal.conector.trabajo.VerificaFecha(cb_empleado_trabajo.Text, mc_trabajo.SelectionEnd.ToShortDateString()) == false)
                    {
                        datos_trabajo.Fecha = mc_trabajo.SelectionEnd.ToShortDateString();
                        Mdi_Principal.conector.trabajo.modificar(datos_trabajo);
                        MessageBox.Show("Trabajo Modificado", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar_empleado();
                    }
                    else
                    {
                        MessageBox.Show("Ese empleado tiene ya un trabajo asignado en el dia seleccionado", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }

        /// <summary>
        /// validar tab de trabajos de un auto
        /// </summary>
        public void Cargar_empleado()
        {
            if (Mdi_Principal.conector.trabajo.size() > 0)
            {
                button1.Enabled = true;
                bt_modificarT.Enabled = true;
                cb_empleado_trabajo.Enabled = true;

                cb_placa_trabajo.Items.Clear();
                cb_placa_trabajo.Text = "";
                foreach (int i in cbl_trabajos.CheckedIndices)
                {
                    cbl_trabajos.SetItemCheckState(i, CheckState.Unchecked);
                }
                mc_trabajo.SelectionEnd = DateTime.Today;
                cb_empleado_trabajo.Items.Clear();
                cb_empleado_trabajo.Text = "";

                cb_empleado_trabajo.Items.AddRange(Mdi_Principal.conector.empleado.get_empleado());
                if (cb_empleado_trabajo.Items.Count > 0)
                {
                    cb_empleado_trabajo.SelectedIndex = 0;
                }
            }
            else
            {
                button1.Enabled = false;
                bt_modificarT.Enabled = false;
                cb_empleado_trabajo.Enabled = false;
                cb_empleado_trabajo.Text = "No hay trabajos";
            }

        }

        /// <summary>
        /// bloquea el comboBox para no editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_clienteA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_placa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_marca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_estilo_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_año_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_placa_trabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_cliente_trabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_empleado_trabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_clienteA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///  comboBox segun items carga datos de los trabajos el cual tiene el empleado como cliente/fecha/trabajos pendientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_empleado_trabajo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            txt_cliente_trabajo.Text = "";
            cb_placa_trabajo.Items.Clear();
            string[] datos = Mdi_Principal.conector.trabajo.get_mis_trabajo(cb_empleado_trabajo.Text);
            datos_cliente_trabajo = new string[datos.Length];
            datos_fecha_trabajo = new string[datos.Length];
            for (int x = 0; x < datos.Length; x++)
            {
                string texto;
                texto = datos[x];
                string[] info = texto.Split(' ');
                datos_cliente_trabajo[x] = info[0];
                cb_placa_trabajo.Items.Add(info[1]);
                datos_fecha_trabajo[x] = info[2];
            }
            if (cb_placa_trabajo.Items.Count > 0)
            {
                cb_placa_trabajo.SelectedIndex = 0;
            }
            else
            {
            }
        }

        /// <summary>
        /// comboBox segun items resetea componentes desde cero para volver a cargar nuevos datos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_placa_trabajo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            datos_trabajo = Mdi_Principal.conector.trabajo.get_data_trabajo(cb_empleado_trabajo.Text, cb_placa_trabajo.Text, datos_fecha_trabajo[cb_placa_trabajo.SelectedIndex]);
            txt_cliente_trabajo.Text = datos_trabajo.Cedula_cliente;
            string[] datos = datos_trabajo.Array_trabajo;
            int cont = 0;
            foreach (int i in cbl_trabajos.CheckedIndices)
            {
                cbl_trabajos.SetItemCheckState(i, CheckState.Unchecked);
            }

            for (int y = 0; y < cbl_trabajos.Items.Count; y++)
            {

                for (int x = 0; x < datos.Length; x++)
                {
                    if ((String)cbl_trabajos.Items[y] == (datos[x]))
                    {
                        cbl_trabajos.SetItemChecked(cont, true);

                    }
                }
                cont = cont + 1;
            }
            mc_trabajo.SetDate(DateTime.Parse(datos_trabajo.Fecha));
        }

        /// <summary>
        /// evento click el cual borra un trabajo de la lista de trabajos especifico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_cliente_trabajo.Text != "")
            {
                if (MessageBox.Show("Realmente quiere borrar este dato", "Informativo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Mdi_Principal.conector.trabajo.borrar(cb_empleado_trabajo.Text + " " + cb_placa_trabajo.Text + " " + mc_trabajo.SelectionEnd.ToShortDateString());
                    MessageBox.Show("Trabajo eliminado correctamente", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_empleado();
                }
            }
            else
            {
                MessageBox.Show("No hay trabajos que eliminar", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



    }
}
