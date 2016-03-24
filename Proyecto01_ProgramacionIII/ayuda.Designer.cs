namespace Proyecto01_ProgramacionIII
{
    partial class ayuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ayuda));
            this.bt_cerrar = new System.Windows.Forms.Button();
            this.Lb_informe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_cerrar
            // 
            this.bt_cerrar.Location = new System.Drawing.Point(167, 262);
            this.bt_cerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(100, 28);
            this.bt_cerrar.TabIndex = 1;
            this.bt_cerrar.Text = "Cerrar";
            this.bt_cerrar.UseVisualStyleBackColor = true;
            this.bt_cerrar.Click += new System.EventHandler(this.bt_cerrar_Click);
            // 
            // Lb_informe
            // 
            this.Lb_informe.AutoSize = true;
            this.Lb_informe.Location = new System.Drawing.Point(43, 11);
            this.Lb_informe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_informe.Name = "Lb_informe";
            this.Lb_informe.Size = new System.Drawing.Size(45, 16);
            this.Lb_informe.TabIndex = 2;
            this.Lb_informe.Text = "label1";
            this.Lb_informe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 305);
            this.Controls.Add(this.Lb_informe);
            this.Controls.Add(this.bt_cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ayuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayuda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ayuda_FormClosing);
            this.Load += new System.EventHandler(this.ayuda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cerrar;
        private System.Windows.Forms.Label Lb_informe;
    }
}