namespace Proyecto01_ProgramacionIII
{
    partial class Frm_Consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Consultas));
            this.rb_auto = new System.Windows.Forms.RadioButton();
            this.rb_empleado = new System.Windows.Forms.RadioButton();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.lbl_placa_consulta = new System.Windows.Forms.Label();
            this.lbl_cedula_consulta = new System.Windows.Forms.Label();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.dgv_consulta = new System.Windows.Forms.DataGridView();
            this.cb_consu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_auto
            // 
            this.rb_auto.AutoSize = true;
            this.rb_auto.Location = new System.Drawing.Point(160, 28);
            this.rb_auto.Margin = new System.Windows.Forms.Padding(4);
            this.rb_auto.Name = "rb_auto";
            this.rb_auto.Size = new System.Drawing.Size(53, 20);
            this.rb_auto.TabIndex = 2;
            this.rb_auto.Text = "Auto";
            this.rb_auto.UseVisualStyleBackColor = true;
            this.rb_auto.CheckedChanged += new System.EventHandler(this.rb_auto_CheckedChanged);
            // 
            // rb_empleado
            // 
            this.rb_empleado.AutoSize = true;
            this.rb_empleado.Checked = true;
            this.rb_empleado.Location = new System.Drawing.Point(35, 28);
            this.rb_empleado.Margin = new System.Windows.Forms.Padding(4);
            this.rb_empleado.Name = "rb_empleado";
            this.rb_empleado.Size = new System.Drawing.Size(89, 20);
            this.rb_empleado.TabIndex = 3;
            this.rb_empleado.TabStop = true;
            this.rb_empleado.Text = "Empleado";
            this.rb_empleado.UseVisualStyleBackColor = true;
            this.rb_empleado.CheckedChanged += new System.EventHandler(this.rb_empleado_CheckedChanged);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("bt_cancelar.Image")));
            this.bt_cancelar.Location = new System.Drawing.Point(476, 347);
            this.bt_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(147, 49);
            this.bt_cancelar.TabIndex = 19;
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // lbl_placa_consulta
            // 
            this.lbl_placa_consulta.AutoSize = true;
            this.lbl_placa_consulta.Location = new System.Drawing.Point(31, 64);
            this.lbl_placa_consulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_placa_consulta.Name = "lbl_placa_consulta";
            this.lbl_placa_consulta.Size = new System.Drawing.Size(43, 16);
            this.lbl_placa_consulta.TabIndex = 24;
            this.lbl_placa_consulta.Text = "Placa";
            this.lbl_placa_consulta.Visible = false;
            // 
            // lbl_cedula_consulta
            // 
            this.lbl_cedula_consulta.AutoSize = true;
            this.lbl_cedula_consulta.Location = new System.Drawing.Point(31, 64);
            this.lbl_cedula_consulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cedula_consulta.Name = "lbl_cedula_consulta";
            this.lbl_cedula_consulta.Size = new System.Drawing.Size(51, 16);
            this.lbl_cedula_consulta.TabIndex = 23;
            this.lbl_cedula_consulta.Text = "Cedula";
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(31, 64);
            this.lbl_placa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(43, 16);
            this.lbl_placa.TabIndex = 22;
            this.lbl_placa.Text = "Placa";
            // 
            // dgv_consulta
            // 
            this.dgv_consulta.AllowUserToAddRows = false;
            this.dgv_consulta.AllowUserToDeleteRows = false;
            this.dgv_consulta.AllowUserToResizeColumns = false;
            this.dgv_consulta.AllowUserToResizeRows = false;
            this.dgv_consulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consulta.Location = new System.Drawing.Point(29, 113);
            this.dgv_consulta.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_consulta.Name = "dgv_consulta";
            this.dgv_consulta.ReadOnly = true;
            this.dgv_consulta.Size = new System.Drawing.Size(593, 226);
            this.dgv_consulta.TabIndex = 25;
            // 
            // cb_consu
            // 
            this.cb_consu.FormattingEnabled = true;
            this.cb_consu.Location = new System.Drawing.Point(35, 84);
            this.cb_consu.Name = "cb_consu";
            this.cb_consu.Size = new System.Drawing.Size(183, 24);
            this.cb_consu.TabIndex = 26;
            this.cb_consu.SelectedIndexChanged += new System.EventHandler(this.cb_consu_SelectedIndexChanged);
            // 
            // Frm_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 406);
            this.Controls.Add(this.cb_consu);
            this.Controls.Add(this.dgv_consulta);
            this.Controls.Add(this.lbl_placa_consulta);
            this.Controls.Add(this.lbl_cedula_consulta);
            this.Controls.Add(this.lbl_placa);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.rb_empleado);
            this.Controls.Add(this.rb_auto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Consultas_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_auto;
        private System.Windows.Forms.RadioButton rb_empleado;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Label lbl_placa_consulta;
        private System.Windows.Forms.Label lbl_cedula_consulta;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.DataGridView dgv_consulta;
        private System.Windows.Forms.ComboBox cb_consu;
    }
}