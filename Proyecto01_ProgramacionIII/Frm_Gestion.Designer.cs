namespace Proyecto01_ProgramacionIII
{
    partial class Frm_Gestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Gestion));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_ingresado = new System.Windows.Forms.TabPage();
            this.bt_borrarC = new System.Windows.Forms.Button();
            this.cb_cedula = new System.Windows.Forms.ComboBox();
            this.check_empleado = new System.Windows.Forms.CheckBox();
            this.check_cliente = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_salir = new System.Windows.Forms.Button();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_auto = new System.Windows.Forms.TabPage();
            this.btn_borrarA = new System.Windows.Forms.Button();
            this.lb_clienteA = new System.Windows.Forms.Label();
            this.cb_clienteA = new System.Windows.Forms.ComboBox();
            this.cb_placa = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cb_año = new System.Windows.Forms.ComboBox();
            this.btn_salirA = new System.Windows.Forms.Button();
            this.bt_modificarA = new System.Windows.Forms.Button();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.cb_estilo = new System.Windows.Forms.ComboBox();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tab_trabajos = new System.Windows.Forms.TabPage();
            this.txt_cliente_trabajo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_STrabajos = new System.Windows.Forms.Button();
            this.bt_modificarT = new System.Windows.Forms.Button();
            this.mc_trabajo = new System.Windows.Forms.MonthCalendar();
            this.cbl_trabajos = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_empleado_trabajo = new System.Windows.Forms.ComboBox();
            this.cb_placa_trabajo = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tab_ingresado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab_auto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tab_trabajos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_ingresado);
            this.tabControl1.Controls.Add(this.tab_auto);
            this.tabControl1.Controls.Add(this.tab_trabajos);
            this.tabControl1.Location = new System.Drawing.Point(12, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 344);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_ingresado
            // 
            this.tab_ingresado.Controls.Add(this.bt_borrarC);
            this.tab_ingresado.Controls.Add(this.cb_cedula);
            this.tab_ingresado.Controls.Add(this.check_empleado);
            this.tab_ingresado.Controls.Add(this.check_cliente);
            this.tab_ingresado.Controls.Add(this.pictureBox1);
            this.tab_ingresado.Controls.Add(this.bt_salir);
            this.tab_ingresado.Controls.Add(this.bt_modificar);
            this.tab_ingresado.Controls.Add(this.txt_apellido);
            this.tab_ingresado.Controls.Add(this.txt_telefono);
            this.tab_ingresado.Controls.Add(this.txt_direccion);
            this.tab_ingresado.Controls.Add(this.txt_nombre);
            this.tab_ingresado.Controls.Add(this.label5);
            this.tab_ingresado.Controls.Add(this.label4);
            this.tab_ingresado.Controls.Add(this.label3);
            this.tab_ingresado.Controls.Add(this.label2);
            this.tab_ingresado.Controls.Add(this.label1);
            this.tab_ingresado.Location = new System.Drawing.Point(4, 22);
            this.tab_ingresado.Name = "tab_ingresado";
            this.tab_ingresado.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ingresado.Size = new System.Drawing.Size(552, 318);
            this.tab_ingresado.TabIndex = 0;
            this.tab_ingresado.Text = "Empleado/Cliente";
            this.tab_ingresado.UseVisualStyleBackColor = true;
            // 
            // bt_borrarC
            // 
            this.bt_borrarC.Image = ((System.Drawing.Image)(resources.GetObject("bt_borrarC.Image")));
            this.bt_borrarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_borrarC.Location = new System.Drawing.Point(5, 290);
            this.bt_borrarC.Name = "bt_borrarC";
            this.bt_borrarC.Size = new System.Drawing.Size(64, 25);
            this.bt_borrarC.TabIndex = 65;
            this.bt_borrarC.Text = "Borrar";
            this.bt_borrarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_borrarC.UseVisualStyleBackColor = true;
            this.bt_borrarC.Click += new System.EventHandler(this.bt_borrarC_Click);
            // 
            // cb_cedula
            // 
            this.cb_cedula.FormattingEnabled = true;
            this.cb_cedula.Location = new System.Drawing.Point(66, 49);
            this.cb_cedula.Name = "cb_cedula";
            this.cb_cedula.Size = new System.Drawing.Size(225, 21);
            this.cb_cedula.TabIndex = 64;
            this.cb_cedula.SelectedIndexChanged += new System.EventHandler(this.cb_cedula_SelectedIndexChanged);
            this.cb_cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_cedula_KeyPress);
            // 
            // check_empleado
            // 
            this.check_empleado.AutoSize = true;
            this.check_empleado.Location = new System.Drawing.Point(92, 10);
            this.check_empleado.Name = "check_empleado";
            this.check_empleado.Size = new System.Drawing.Size(73, 17);
            this.check_empleado.TabIndex = 63;
            this.check_empleado.Text = "Empleado";
            this.check_empleado.UseVisualStyleBackColor = true;
            this.check_empleado.CheckedChanged += new System.EventHandler(this.check_empleado_CheckedChanged);
            // 
            // check_cliente
            // 
            this.check_cliente.AutoSize = true;
            this.check_cliente.Location = new System.Drawing.Point(10, 10);
            this.check_cliente.Name = "check_cliente";
            this.check_cliente.Size = new System.Drawing.Size(58, 17);
            this.check_cliente.TabIndex = 62;
            this.check_cliente.Text = "Cliente";
            this.check_cliente.UseVisualStyleBackColor = true;
            this.check_cliente.CheckedChanged += new System.EventHandler(this.check_cliente_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(324, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // bt_salir
            // 
            this.bt_salir.Image = ((System.Drawing.Image)(resources.GetObject("bt_salir.Image")));
            this.bt_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_salir.Location = new System.Drawing.Point(440, 268);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(110, 40);
            this.bt_salir.TabIndex = 60;
            this.bt_salir.Text = "Salir";
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // bt_modificar
            // 
            this.bt_modificar.Image = ((System.Drawing.Image)(resources.GetObject("bt_modificar.Image")));
            this.bt_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_modificar.Location = new System.Drawing.Point(324, 268);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(110, 40);
            this.bt_modificar.TabIndex = 59;
            this.bt_modificar.Text = "Guardar";
            this.bt_modificar.UseVisualStyleBackColor = true;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(66, 123);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(225, 20);
            this.txt_apellido.TabIndex = 58;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(66, 162);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(225, 20);
            this.txt_telefono.TabIndex = 57;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(66, 205);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(303, 57);
            this.txt_direccion.TabIndex = 56;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(66, 84);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(225, 20);
            this.txt_nombre.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nombre:";
            // 
            // tab_auto
            // 
            this.tab_auto.Controls.Add(this.btn_borrarA);
            this.tab_auto.Controls.Add(this.lb_clienteA);
            this.tab_auto.Controls.Add(this.cb_clienteA);
            this.tab_auto.Controls.Add(this.cb_placa);
            this.tab_auto.Controls.Add(this.pictureBox2);
            this.tab_auto.Controls.Add(this.cb_año);
            this.tab_auto.Controls.Add(this.btn_salirA);
            this.tab_auto.Controls.Add(this.bt_modificarA);
            this.tab_auto.Controls.Add(this.txt_modelo);
            this.tab_auto.Controls.Add(this.cb_estilo);
            this.tab_auto.Controls.Add(this.cb_marca);
            this.tab_auto.Controls.Add(this.label6);
            this.tab_auto.Controls.Add(this.label7);
            this.tab_auto.Controls.Add(this.label8);
            this.tab_auto.Controls.Add(this.label9);
            this.tab_auto.Controls.Add(this.label10);
            this.tab_auto.Location = new System.Drawing.Point(4, 22);
            this.tab_auto.Name = "tab_auto";
            this.tab_auto.Padding = new System.Windows.Forms.Padding(3);
            this.tab_auto.Size = new System.Drawing.Size(552, 318);
            this.tab_auto.TabIndex = 1;
            this.tab_auto.Text = "Auto";
            this.tab_auto.UseVisualStyleBackColor = true;
            // 
            // btn_borrarA
            // 
            this.btn_borrarA.Image = ((System.Drawing.Image)(resources.GetObject("btn_borrarA.Image")));
            this.btn_borrarA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_borrarA.Location = new System.Drawing.Point(6, 290);
            this.btn_borrarA.Name = "btn_borrarA";
            this.btn_borrarA.Size = new System.Drawing.Size(57, 24);
            this.btn_borrarA.TabIndex = 66;
            this.btn_borrarA.Text = "Borrar";
            this.btn_borrarA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_borrarA.UseVisualStyleBackColor = true;
            this.btn_borrarA.Click += new System.EventHandler(this.btn_borrarA_Click);
            // 
            // lb_clienteA
            // 
            this.lb_clienteA.AutoSize = true;
            this.lb_clienteA.Location = new System.Drawing.Point(18, 27);
            this.lb_clienteA.Name = "lb_clienteA";
            this.lb_clienteA.Size = new System.Drawing.Size(42, 13);
            this.lb_clienteA.TabIndex = 60;
            this.lb_clienteA.Text = "Cliente:";
            // 
            // cb_clienteA
            // 
            this.cb_clienteA.FormattingEnabled = true;
            this.cb_clienteA.Items.AddRange(new object[] {
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990"});
            this.cb_clienteA.Location = new System.Drawing.Point(73, 19);
            this.cb_clienteA.Name = "cb_clienteA";
            this.cb_clienteA.Size = new System.Drawing.Size(126, 21);
            this.cb_clienteA.TabIndex = 59;
            this.cb_clienteA.SelectedIndexChanged += new System.EventHandler(this.cb_clienteA_SelectedIndexChanged);
            this.cb_clienteA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_clienteA_KeyPress);
            // 
            // cb_placa
            // 
            this.cb_placa.FormattingEnabled = true;
            this.cb_placa.Location = new System.Drawing.Point(73, 58);
            this.cb_placa.Name = "cb_placa";
            this.cb_placa.Size = new System.Drawing.Size(126, 21);
            this.cb_placa.TabIndex = 58;
            this.cb_placa.SelectedIndexChanged += new System.EventHandler(this.cb_placa_SelectedIndexChanged);
            this.cb_placa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_placa_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(260, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 210);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // cb_año
            // 
            this.cb_año.FormattingEnabled = true;
            this.cb_año.Items.AddRange(new object[] {
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990"});
            this.cb_año.Location = new System.Drawing.Point(73, 208);
            this.cb_año.Name = "cb_año";
            this.cb_año.Size = new System.Drawing.Size(126, 21);
            this.cb_año.TabIndex = 56;
            this.cb_año.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_año_KeyPress);
            // 
            // btn_salirA
            // 
            this.btn_salirA.Image = ((System.Drawing.Image)(resources.GetObject("btn_salirA.Image")));
            this.btn_salirA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salirA.Location = new System.Drawing.Point(425, 260);
            this.btn_salirA.Name = "btn_salirA";
            this.btn_salirA.Size = new System.Drawing.Size(110, 40);
            this.btn_salirA.TabIndex = 55;
            this.btn_salirA.Text = "Cerrar";
            this.btn_salirA.UseVisualStyleBackColor = true;
            this.btn_salirA.Click += new System.EventHandler(this.btn_salirA_Click);
            // 
            // bt_modificarA
            // 
            this.bt_modificarA.Image = ((System.Drawing.Image)(resources.GetObject("bt_modificarA.Image")));
            this.bt_modificarA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_modificarA.Location = new System.Drawing.Point(309, 260);
            this.bt_modificarA.Name = "bt_modificarA";
            this.bt_modificarA.Size = new System.Drawing.Size(110, 40);
            this.bt_modificarA.TabIndex = 54;
            this.bt_modificarA.Text = "Guardar";
            this.bt_modificarA.UseVisualStyleBackColor = true;
            this.bt_modificarA.Click += new System.EventHandler(this.bt_modificarA_Click);
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(73, 132);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(126, 20);
            this.txt_modelo.TabIndex = 52;
            // 
            // cb_estilo
            // 
            this.cb_estilo.FormattingEnabled = true;
            this.cb_estilo.Items.AddRange(new object[] {
            "Sedan",
            "Station Wagon",
            "Hatchback",
            "Pick - up 4x2",
            "Pick - up 4x4",
            "Panel",
            "Microbus",
            "Todo Terreno 4x2",
            "Todo Terreno 4x4",
            "Comercial"});
            this.cb_estilo.Location = new System.Drawing.Point(73, 168);
            this.cb_estilo.Name = "cb_estilo";
            this.cb_estilo.Size = new System.Drawing.Size(126, 21);
            this.cb_estilo.TabIndex = 51;
            this.cb_estilo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cb_estilo_KeyUp);
            // 
            // cb_marca
            // 
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Items.AddRange(new object[] {
            "Acura",
            "Aston Martin ",
            "Audi",
            "BMW",
            "Cadillac",
            "Chevrolet",
            "Citroen",
            "Ferrari",
            "Fiat",
            "Ford",
            "Honda",
            "Hyundai",
            "Isuzu",
            "Jaguar",
            "Jeep",
            "Kia",
            "Lamborghini",
            "Lexus",
            "Lotus",
            "Mazda",
            "Mercedes-Benz",
            "Mini",
            "Mitsubishi",
            "Nissan",
            "Peugeot",
            "Porsche",
            "Subaru",
            "Suzuki",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.cb_marca.Location = new System.Drawing.Point(73, 95);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(126, 21);
            this.cb_marca.TabIndex = 50;
            this.cb_marca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_marca_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Año:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Placa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Estilo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Modelo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Marca:";
            // 
            // tab_trabajos
            // 
            this.tab_trabajos.Controls.Add(this.txt_cliente_trabajo);
            this.tab_trabajos.Controls.Add(this.button1);
            this.tab_trabajos.Controls.Add(this.bt_STrabajos);
            this.tab_trabajos.Controls.Add(this.bt_modificarT);
            this.tab_trabajos.Controls.Add(this.mc_trabajo);
            this.tab_trabajos.Controls.Add(this.cbl_trabajos);
            this.tab_trabajos.Controls.Add(this.label11);
            this.tab_trabajos.Controls.Add(this.label12);
            this.tab_trabajos.Controls.Add(this.label13);
            this.tab_trabajos.Controls.Add(this.cb_empleado_trabajo);
            this.tab_trabajos.Controls.Add(this.cb_placa_trabajo);
            this.tab_trabajos.Location = new System.Drawing.Point(4, 22);
            this.tab_trabajos.Name = "tab_trabajos";
            this.tab_trabajos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_trabajos.Size = new System.Drawing.Size(552, 318);
            this.tab_trabajos.TabIndex = 2;
            this.tab_trabajos.Text = "Trabajos";
            this.tab_trabajos.UseVisualStyleBackColor = true;
            // 
            // txt_cliente_trabajo
            // 
            this.txt_cliente_trabajo.Location = new System.Drawing.Point(195, 32);
            this.txt_cliente_trabajo.Name = "txt_cliente_trabajo";
            this.txt_cliente_trabajo.ReadOnly = true;
            this.txt_cliente_trabajo.Size = new System.Drawing.Size(163, 20);
            this.txt_cliente_trabajo.TabIndex = 68;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(8, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 24);
            this.button1.TabIndex = 67;
            this.button1.Text = "Borrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_STrabajos
            // 
            this.bt_STrabajos.Image = ((System.Drawing.Image)(resources.GetObject("bt_STrabajos.Image")));
            this.bt_STrabajos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_STrabajos.Location = new System.Drawing.Point(438, 263);
            this.bt_STrabajos.Name = "bt_STrabajos";
            this.bt_STrabajos.Size = new System.Drawing.Size(110, 40);
            this.bt_STrabajos.TabIndex = 39;
            this.bt_STrabajos.Text = "Cerrar";
            this.bt_STrabajos.UseVisualStyleBackColor = true;
            this.bt_STrabajos.Click += new System.EventHandler(this.bt_STrabajos_Click);
            // 
            // bt_modificarT
            // 
            this.bt_modificarT.Image = ((System.Drawing.Image)(resources.GetObject("bt_modificarT.Image")));
            this.bt_modificarT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_modificarT.Location = new System.Drawing.Point(322, 263);
            this.bt_modificarT.Name = "bt_modificarT";
            this.bt_modificarT.Size = new System.Drawing.Size(110, 40);
            this.bt_modificarT.TabIndex = 38;
            this.bt_modificarT.Text = "Guardar";
            this.bt_modificarT.UseVisualStyleBackColor = true;
            this.bt_modificarT.Click += new System.EventHandler(this.bt_modificarT_Click);
            // 
            // mc_trabajo
            // 
            this.mc_trabajo.Location = new System.Drawing.Point(294, 65);
            this.mc_trabajo.Name = "mc_trabajo";
            this.mc_trabajo.TabIndex = 37;
            // 
            // cbl_trabajos
            // 
            this.cbl_trabajos.FormattingEnabled = true;
            this.cbl_trabajos.Items.AddRange(new object[] {
            "Cambio de llanta",
            "Cambio de aceite",
            "Reparacion de frenos",
            "Cambio de parabrisas",
            "Cambio de liquido de frenos",
            "Bateria",
            "Sistema de suspencion",
            "Sistema de escape",
            "Filtros",
            "Direccion Hibraulica",
            "Aire acondicionado"});
            this.cbl_trabajos.Location = new System.Drawing.Point(8, 59);
            this.cbl_trabajos.Name = "cbl_trabajos";
            this.cbl_trabajos.Size = new System.Drawing.Size(249, 214);
            this.cbl_trabajos.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(374, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Empleado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(192, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Cliente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Placa";
            // 
            // cb_empleado_trabajo
            // 
            this.cb_empleado_trabajo.FormattingEnabled = true;
            this.cb_empleado_trabajo.Location = new System.Drawing.Point(377, 32);
            this.cb_empleado_trabajo.Name = "cb_empleado_trabajo";
            this.cb_empleado_trabajo.Size = new System.Drawing.Size(171, 21);
            this.cb_empleado_trabajo.TabIndex = 32;
            this.cb_empleado_trabajo.SelectedIndexChanged += new System.EventHandler(this.cb_empleado_trabajo_SelectedIndexChanged_1);
            this.cb_empleado_trabajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_empleado_trabajo_KeyPress);
            // 
            // cb_placa_trabajo
            // 
            this.cb_placa_trabajo.FormattingEnabled = true;
            this.cb_placa_trabajo.Location = new System.Drawing.Point(8, 32);
            this.cb_placa_trabajo.Name = "cb_placa_trabajo";
            this.cb_placa_trabajo.Size = new System.Drawing.Size(171, 21);
            this.cb_placa_trabajo.TabIndex = 30;
            this.cb_placa_trabajo.SelectedIndexChanged += new System.EventHandler(this.cb_placa_trabajo_SelectedIndexChanged_1);
            this.cb_placa_trabajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_placa_trabajo_KeyPress);
            // 
            // Frm_Gestion
            // 
            this.AcceptButton = this.bt_modificar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Gestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.Frm_MIngresado_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_ingresado.ResumeLayout(false);
            this.tab_ingresado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab_auto.ResumeLayout(false);
            this.tab_auto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tab_trabajos.ResumeLayout(false);
            this.tab_trabajos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_ingresado;
        private System.Windows.Forms.TabPage tab_auto;
        private System.Windows.Forms.TabPage tab_trabajos;
        private System.Windows.Forms.ComboBox cb_cedula;
        private System.Windows.Forms.CheckBox check_empleado;
        private System.Windows.Forms.CheckBox check_cliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Button bt_modificar;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_placa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cb_año;
        private System.Windows.Forms.Button btn_salirA;
        private System.Windows.Forms.Button bt_modificarA;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.ComboBox cb_estilo;
        private System.Windows.Forms.ComboBox cb_marca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_STrabajos;
        private System.Windows.Forms.Button bt_modificarT;
        private System.Windows.Forms.MonthCalendar mc_trabajo;
        private System.Windows.Forms.CheckedListBox cbl_trabajos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_empleado_trabajo;
        private System.Windows.Forms.ComboBox cb_placa_trabajo;
        private System.Windows.Forms.Label lb_clienteA;
        private System.Windows.Forms.ComboBox cb_clienteA;
        private System.Windows.Forms.Button bt_borrarC;
        private System.Windows.Forms.Button btn_borrarA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_cliente_trabajo;

    }
}