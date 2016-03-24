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
    public partial class Frm_Ingresado : Form
    {

        public Frm_Ingresado()
        {
            InitializeComponent();
        }

        private void bt_ingresar_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Si lleno todos los datos ingresesa los datos en un objeto donde lo ingresa al la lista de clientes o empleados segun el check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_ingresar_Click_1(object sender, EventArgs e)
        {
            //objeto para mandar a insertar los datos
            Cls_Persona Datos_persona = new Cls_Persona();

            if (txt_nombre.Text != String.Empty)
            {
                Datos_persona.nombre = txt_nombre.Text;
                if (txt_apellido.Text != String.Empty)
                {
                    Datos_persona.apellido = txt_apellido.Text;
                    if (txt_direccion.Text != String.Empty)
                    {
                        Datos_persona.direccion = txt_telefono.Text;
                        if (txt_telefono.Text != String.Empty)
                        {
                            Datos_persona.telefono = txt_telefono.Text;
                            if (txt_cedula.Text != String.Empty)
                            {
                                Datos_persona.cedula = txt_cedula.Text;
                                if (txt_nombre.Text != String.Empty && txt_apellido.Text != String.Empty && txt_cedula.Text != String.Empty &&
                                    txt_telefono.Text != String.Empty && txt_direccion.Text != String.Empty)
                                    if (check_cliente.Checked == true && check_empleado.Checked == false)
                                    {    //verifica si la cedula ha sido ingresada
                                        if (Mdi_Principal.conector.cliente.VerificaCedula(txt_cedula.Text) == false)
                                        {
                                            //envia un objeto a inserta un nodo en clientes
                                            Mdi_Principal.conector.cliente.insertar(Datos_persona);
                                            MessageBox.Show("Cliente Guardado", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Limpiar_Persona();
                                            load_checkboxs();
                                        }
                                        else
                                        {
                                            MessageBox.Show("La cedula ingresa ya existe en cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txt_cedula.Focus();
                                            txt_cedula.Text = "";
                                        }

                                    }
                                    else if (check_empleado.Checked == true && check_cliente.Checked == false)
                                    {
                                        if (Mdi_Principal.conector.empleado.VerificaCedula(txt_cedula.Text) == false)
                                        {
                                            //envia un objeto a inserta un nodo en empleado
                                            Mdi_Principal.conector.empleado.insertar(Datos_persona);
                                            MessageBox.Show("Empleado Guardado", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Limpiar_Persona();
                                            load_checkboxs();
                                        }
                                        else {
                                            MessageBox.Show("La cedula ingresa ya existe en empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txt_cedula.Focus();
                                            txt_cedula.Text = "";
                                        }
                                        
                                    }
                                    else if (check_empleado.Checked == true && check_cliente.Checked == true)
                                    {
                                        if (Mdi_Principal.conector.empleado.VerificaCedula(txt_cedula.Text) == false & Mdi_Principal.conector.cliente.VerificaCedula(txt_cedula.Text) == false)
                                        {
                                            //envia un objeto a inserta un nodo en clientes/empleado
                                            Mdi_Principal.conector.cliente.insertar(Datos_persona);
                                            Mdi_Principal.conector.empleado.insertar(Datos_persona);
                                            MessageBox.Show("Cliente y Empleado Guardado", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Limpiar_Persona();
                                            load_checkboxs();
                                        }
                                        else if (Mdi_Principal.conector.cliente.VerificaCedula(txt_cedula.Text) == true)
                                        {
                                            MessageBox.Show("La cedula ingresa ya existe en cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txt_cedula.Focus();
                                            txt_cedula.Text = "";   
                                        }
                                        else {
                                            MessageBox.Show("La cedula ingresa ya existe en empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txt_cedula.Focus();
                                            txt_cedula.Text = "";   
                                        }
                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("Selecciones alguna casilla", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                            }
                            else
                            {
                                MessageBox.Show("Ingresar cedula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txt_cedula.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingresar telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_telefono.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingresar direccion", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_direccion.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ingresar apellidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_apellido.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingresar nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
            }

            

        }

        /// <summary>
        /// cerra el formulario desde el ingreso de cliente/empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Si lleno todos los datos ingresesa los datos en un objeto donde lo ingresa al la lista de de autos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Iauto_Click(object sender, EventArgs e)
        {
            if (Mdi_Principal.conector.cliente.get_cliente().Length > 0)
            {
                //objeto para mandar a insertar los datos
                Nodo_Auto Datos_autos = new Nodo_Auto();

                if (cb_marca.Items.Count != 0)
                {
                    Datos_autos.Marca = cb_marca.Text;
                    if (txt_modelo.Text != String.Empty)
                    {
                        Datos_autos.Modelo = txt_modelo.Text;
                        if (cb_estilo.Items.Count != 0)
                        {
                            Datos_autos.Estilo = cb_estilo.Text;
                            if (cb_año.Items.Count != 0)
                            {
                                Datos_autos.Año = cb_año.Text;
                                if (txt_placa.Text != String.Empty)
                                {
                                    Datos_autos.Placa = txt_placa.Text;
                                    Datos_autos.Cedula = cb_cliente_auto.Text;
                                    if (cb_marca.Items.Count != 0 && txt_modelo.Text != String.Empty && cb_estilo.Items.Count != 0 && cb_año.Items.Count != 0
                                        && txt_placa.Text != String.Empty)
                                    {      //verifica si ya la placa ha sido ingresada
                                        if (Mdi_Principal.conector.auto.VerificaPlaca(txt_placa.Text) == false)
                                        {
                                            //envia un objeto a inserta un nodo en autos
                                            Mdi_Principal.conector.auto.insertar(Datos_autos);
                                            MessageBox.Show("Auto Guardado", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            load_checkboxs();
                                        }
                                        else {
                                            MessageBox.Show("Esa placa ya ha sido ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txt_placa.Focus();
                                            txt_placa.Text = "";
                                        }     
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingresar placa del auto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txt_placa.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingresar año del auto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cb_año.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingresar estolo del auto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cb_estilo.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingresar modelo del auto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_modelo.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ingresar marca del auto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_marca.Focus();
                }
            }
            else
            {
                MessageBox.Show("Porfavor ingrese un cliente primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        /// <summary>
        /// cerrar el formulario desde insertar autos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Ingresesa los datos a un objeto donde lo ingresa al la lista de de trabajos del auto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (cb_cliente_trabajo.Items.Count != 0 && cb_placa.Items.Count != 0 && cb_empleado_trabajo.Items.Count != 0)
            {
                if (cbl_trabajos.CheckedItems.Count == 0)
                {
                    MessageBox.Show("No Hay Trabajos Seleccionados al auto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Nodo_Trabajo Datos_trabajo = new Nodo_Trabajo();

                    String[] lista_trabajos = new String[cbl_trabajos.CheckedItems.Count];
                    //corre todo la lista de trabajos para guuardar los que fueron seleccionados
                    int x = 0;
                    foreach (var lista in cbl_trabajos.CheckedItems)
                    {
                        lista_trabajos[x] = lista.ToString();
                        x = x + 1;
                    }
                    //guarda los datos de los componentes en el objeto
                    Datos_trabajo.Cedula_cliente = cb_cliente_trabajo.Text;
                    Datos_trabajo.Cedula_empleado = cb_empleado_trabajo.Text;
                    Datos_trabajo.Placa_auto = cb_placa.Text;
                    Datos_trabajo.Fecha = mc_trabajo.SelectionEnd.ToShortDateString();
                    Datos_trabajo.Estado = true;
                    Datos_trabajo.Array_trabajo = lista_trabajos;
                    if (Mdi_Principal.conector.trabajo.VerificaFecha(cb_empleado_trabajo.Text, mc_trabajo.SelectionEnd.ToShortDateString()) == false)
                    {
                        //envia el objeto a insertar un nodo en el trabajo
                        Mdi_Principal.conector.trabajo.insertar(Datos_trabajo);
                        MessageBox.Show("Trabajo Guardado", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //limpiar la lista de trabajos
                        foreach (int i in cbl_trabajos.CheckedIndices)
                        {
                            cbl_trabajos.SetItemCheckState(i, CheckState.Unchecked);
                        }

                    }
                    else {
                        MessageBox.Show("El empleado ya tiene un trabajo asignado ese dia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("Falta Datos a ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// cerrar el formulario desde trabajos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// limpiar el tab de cliente/empleado
        /// </summary>
        private void Limpiar_Persona()
        {
            txt_nombre.Clear();
            txt_cedula.Clear();
            txt_direccion.Clear();
            txt_telefono.Clear();
            txt_apellido.Clear();
            txt_nombre.Focus();
        }

        /// <summary>
        /// establecer el tab del ingreso de autos
        /// </summary>
        private void Limpiar_Auto()
        {
            cb_marca.SelectedIndex = 0;
            cb_estilo.SelectedIndex = 0;
            cb_año.SelectedIndex = 0;
            txt_modelo.Clear();
            txt_placa.Clear();
            cb_cliente_trabajo.Items.Clear();
            cb_cliente_auto.Items.Clear();
            cb_cliente_trabajo.Enabled = true;
            cb_cliente_auto.Enabled = true;
            cb_marca.Enabled = true;
            txt_modelo.Enabled = true;
            cb_estilo.Enabled = true;
            cb_año.Enabled = true;
            txt_placa.Enabled = true;
        }

        /// <summary>
        /// ingreso al formulario, usando el metodo load_checkbox()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Ingresado_Load(object sender, EventArgs e)
        {
            load_checkboxs();
        }

        /// <summary>
        /// segun el cliente en el comboBox de trabajos carga los datos de los autos de ese cliente
        /// sino encuentra bloquea el comboBox de placa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_cliente_trabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Mdi_Principal.conector.auto.size() > 0)
            {
                cb_placa.Items.Clear();
                cb_placa.Text = "";
                cb_placa.Items.AddRange(Mdi_Principal.conector.auto.get_Autos_trabajo(cb_cliente_trabajo.Text));
                if (cb_placa.Items.Count > 0)
                {
                    cb_placa.Enabled = true;
                    cb_placa.SelectedIndex = 0;
                }
                else
                {
                    cb_placa.Enabled = false;
                    cb_placa.Text = "Ingrese un auto";
                }
            }

        }

        private void checkCliente_CheckedChanged(object sender, EventArgs e) { }

        /// <summary>
        /// habilita o bloquea componentes del tab de ingresos d cliente/empleado,autos y trabajos segun si encuentra datos en las listas
        /// </summary>
        public void load_checkboxs()
        {
            //validar cliente en autos y trabajo
            if (Mdi_Principal.conector.cliente.size() > 0)
            {
                Limpiar_Auto();
                cb_cliente_trabajo.Items.AddRange(Mdi_Principal.conector.cliente.get_cliente());
                cb_cliente_auto.Items.AddRange(Mdi_Principal.conector.cliente.get_cliente());
                if (cb_cliente_trabajo.Items.Count > 0 & cb_cliente_auto.Items.Count > 0)
                {
                    cb_cliente_trabajo.SelectedIndex = 0;
                    cb_cliente_auto.SelectedIndex = 0;
                }
            }
            else
            {
                cb_cliente_trabajo.Text = "Ingrese un cliente";
                cb_cliente_trabajo.Enabled = false;
                cb_cliente_auto.Text = "Ingrese un cliente";
                cb_cliente_auto.Enabled = false;
                cb_marca.Enabled = false;
                txt_modelo.Enabled = false;
                cb_estilo.Enabled = false;
                cb_año.Enabled = false;
                txt_placa.Enabled = false;
            }

            //validar empleado en trabajo
            if (Mdi_Principal.conector.empleado.size() > 0)
            {
                cb_empleado_trabajo.Enabled = true;
                cb_empleado_trabajo.Items.Clear();
                cb_empleado_trabajo.Items.AddRange(Mdi_Principal.conector.empleado.get_empleado());
                if (cb_empleado_trabajo.Items.Count > 0)
                {
                    cb_empleado_trabajo.SelectedIndex = 0;
                }
            }
            else
            {
                cb_empleado_trabajo.Enabled = false;
                cb_empleado_trabajo.Text = "Ingrese un cliente";
            }

            //validar autos en trabajo
            if (Mdi_Principal.conector.auto.size() > 0)
            {
                cb_placa.Enabled = true;
                cb_placa.Items.Clear();
                cb_placa.Items.AddRange(Mdi_Principal.conector.auto.get_Autos());
                if (cb_placa.Items.Count > 0)
                {
                    cb_placa.SelectedIndex = 0;
                }
            }
            else
            {
                cb_placa.Enabled = false;
                cb_placa.Text = "Ingrese un auto";
            }

        }

        private void cb_placa_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cb_empleado_trabajo_SelectedIndexChanged(object sender, EventArgs e) { }

        /// <summary>
        /// bloquea el ComboBox para no editar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_cliente_trabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_placa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_empleado_trabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_cliente_auto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_marca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_estilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_año_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tab_trabajo_Click(object sender, EventArgs e)
        {

        }
    }
}
