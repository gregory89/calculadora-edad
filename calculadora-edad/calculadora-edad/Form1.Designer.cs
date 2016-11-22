namespace calculadora_edad
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
            this.dtefecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfechaN = new System.Windows.Forms.TextBox();
            this.txthoras = new System.Windows.Forms.TextBox();
            this.txtminuto = new System.Windows.Forms.TextBox();
            this.txtsegundos = new System.Windows.Forms.TextBox();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtefecha
            // 
            this.dtefecha.Location = new System.Drawing.Point(180, 37);
            this.dtefecha.Name = "dtefecha";
            this.dtefecha.Size = new System.Drawing.Size(200, 20);
            this.dtefecha.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "FECHA N";
            // 
            // txtfechaN
            // 
            this.txtfechaN.Location = new System.Drawing.Point(229, 262);
            this.txtfechaN.Name = "txtfechaN";
            this.txtfechaN.Size = new System.Drawing.Size(100, 20);
            this.txtfechaN.TabIndex = 29;
            // 
            // txthoras
            // 
            this.txthoras.Location = new System.Drawing.Point(341, 92);
            this.txthoras.Name = "txthoras";
            this.txthoras.Size = new System.Drawing.Size(100, 20);
            this.txthoras.TabIndex = 28;
            // 
            // txtminuto
            // 
            this.txtminuto.Location = new System.Drawing.Point(146, 136);
            this.txtminuto.Name = "txtminuto";
            this.txtminuto.Size = new System.Drawing.Size(100, 20);
            this.txtminuto.TabIndex = 27;
            // 
            // txtsegundos
            // 
            this.txtsegundos.Location = new System.Drawing.Point(341, 140);
            this.txtsegundos.Name = "txtsegundos";
            this.txtsegundos.Size = new System.Drawing.Size(100, 20);
            this.txtsegundos.TabIndex = 26;
            // 
            // txtmes
            // 
            this.txtmes.Location = new System.Drawing.Point(146, 186);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(100, 20);
            this.txtmes.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "EDAD";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(341, 186);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 23;
            // 
            // txtdias
            // 
            this.txtdias.Location = new System.Drawing.Point(146, 88);
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(100, 20);
            this.txtdias.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "MESES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "SEGUNDOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "MINUTOS ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "HORAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "DIAS";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(341, 359);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 16;
            this.btncalcular.Text = "button1";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 419);
            this.Controls.Add(this.dtefecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtfechaN);
            this.Controls.Add(this.txthoras);
            this.Controls.Add(this.txtminuto);
            this.Controls.Add(this.txtsegundos);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtdias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtefecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtfechaN;
        private System.Windows.Forms.TextBox txthoras;
        private System.Windows.Forms.TextBox txtminuto;
        private System.Windows.Forms.TextBox txtsegundos;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtdias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncalcular;
    }
}

