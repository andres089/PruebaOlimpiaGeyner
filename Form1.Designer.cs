namespace WindowsLiderEntrega
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTiempoTotal = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_De = new System.Windows.Forms.Label();
            this.lbl_TotalAplicaciones = new System.Windows.Forms.Label();
            this.lbl_Contador = new System.Windows.Forms.Label();
            this.pgb_Progreso = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 25);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTiempoTotal
            // 
            this.lblTiempoTotal.AutoSize = true;
            this.lblTiempoTotal.Location = new System.Drawing.Point(234, 30);
            this.lblTiempoTotal.Name = "lblTiempoTotal";
            this.lblTiempoTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTiempoTotal.TabIndex = 1;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(128, 30);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(69, 13);
            this.lblTiempo.TabIndex = 2;
            this.lblTiempo.Text = "Tiempo Total";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 186);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lbl_De
            // 
            this.lbl_De.AutoSize = true;
            this.lbl_De.Location = new System.Drawing.Point(354, 51);
            this.lbl_De.Name = "lbl_De";
            this.lbl_De.Size = new System.Drawing.Size(21, 13);
            this.lbl_De.TabIndex = 14;
            this.lbl_De.Text = "De";
            // 
            // lbl_TotalAplicaciones
            // 
            this.lbl_TotalAplicaciones.AutoSize = true;
            this.lbl_TotalAplicaciones.Location = new System.Drawing.Point(426, 51);
            this.lbl_TotalAplicaciones.Name = "lbl_TotalAplicaciones";
            this.lbl_TotalAplicaciones.Size = new System.Drawing.Size(13, 13);
            this.lbl_TotalAplicaciones.TabIndex = 15;
            this.lbl_TotalAplicaciones.Text = "0";
            // 
            // lbl_Contador
            // 
            this.lbl_Contador.AutoSize = true;
            this.lbl_Contador.Location = new System.Drawing.Point(295, 51);
            this.lbl_Contador.Name = "lbl_Contador";
            this.lbl_Contador.Size = new System.Drawing.Size(13, 13);
            this.lbl_Contador.TabIndex = 13;
            this.lbl_Contador.Text = "0";
            // 
            // pgb_Progreso
            // 
            this.pgb_Progreso.Location = new System.Drawing.Point(275, 25);
            this.pgb_Progreso.Name = "pgb_Progreso";
            this.pgb_Progreso.Size = new System.Drawing.Size(194, 23);
            this.pgb_Progreso.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 321);
            this.Controls.Add(this.lbl_De);
            this.Controls.Add(this.lbl_TotalAplicaciones);
            this.Controls.Add(this.lbl_Contador);
            this.Controls.Add(this.pgb_Progreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblTiempoTotal);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Prueba Lider";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTiempoTotal;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_De;
        private System.Windows.Forms.Label lbl_TotalAplicaciones;
        private System.Windows.Forms.Label lbl_Contador;
        private System.Windows.Forms.ProgressBar pgb_Progreso;
    }
}

