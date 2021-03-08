namespace Calculadora
{
    partial class Form1
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
            this.lbl_Numero1 = new System.Windows.Forms.Label();
            this.lbl_Numero2 = new System.Windows.Forms.Label();
            this.lbl_Numero3 = new System.Windows.Forms.Label();
            this.txt_Numero1 = new System.Windows.Forms.TextBox();
            this.txt_Numero2 = new System.Windows.Forms.TextBox();
            this.txt_Numero3 = new System.Windows.Forms.TextBox();
            this.gbx_Operaciones = new System.Windows.Forms.GroupBox();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.rbt_Division = new System.Windows.Forms.RadioButton();
            this.rbt_Multiplicacion = new System.Windows.Forms.RadioButton();
            this.rbt_Resta = new System.Windows.Forms.RadioButton();
            this.rbt_Suma = new System.Windows.Forms.RadioButton();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.gbx_Operaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Numero1
            // 
            this.lbl_Numero1.AutoSize = true;
            this.lbl_Numero1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Numero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero1.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Numero1.Location = new System.Drawing.Point(8, 15);
            this.lbl_Numero1.Name = "lbl_Numero1";
            this.lbl_Numero1.Size = new System.Drawing.Size(101, 20);
            this.lbl_Numero1.TabIndex = 0;
            this.lbl_Numero1.Text = "NUMERO 1";
            // 
            // lbl_Numero2
            // 
            this.lbl_Numero2.AutoSize = true;
            this.lbl_Numero2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Numero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero2.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Numero2.Location = new System.Drawing.Point(8, 51);
            this.lbl_Numero2.Name = "lbl_Numero2";
            this.lbl_Numero2.Size = new System.Drawing.Size(101, 20);
            this.lbl_Numero2.TabIndex = 1;
            this.lbl_Numero2.Text = "NUMERO 2";
            this.lbl_Numero2.Click += new System.EventHandler(this.lbl_Numero2_Click);
            // 
            // lbl_Numero3
            // 
            this.lbl_Numero3.AutoSize = true;
            this.lbl_Numero3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Numero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero3.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Numero3.Location = new System.Drawing.Point(8, 91);
            this.lbl_Numero3.Name = "lbl_Numero3";
            this.lbl_Numero3.Size = new System.Drawing.Size(117, 20);
            this.lbl_Numero3.TabIndex = 2;
            this.lbl_Numero3.Text = "RESULTADO";
            // 
            // txt_Numero1
            // 
            this.txt_Numero1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Numero1.Location = new System.Drawing.Point(143, 17);
            this.txt_Numero1.Name = "txt_Numero1";
            this.txt_Numero1.Size = new System.Drawing.Size(100, 20);
            this.txt_Numero1.TabIndex = 3;
            // 
            // txt_Numero2
            // 
            this.txt_Numero2.Location = new System.Drawing.Point(143, 51);
            this.txt_Numero2.Name = "txt_Numero2";
            this.txt_Numero2.Size = new System.Drawing.Size(100, 20);
            this.txt_Numero2.TabIndex = 4;
            // 
            // txt_Numero3
            // 
            this.txt_Numero3.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Numero3.Location = new System.Drawing.Point(143, 91);
            this.txt_Numero3.Name = "txt_Numero3";
            this.txt_Numero3.Size = new System.Drawing.Size(100, 20);
            this.txt_Numero3.TabIndex = 5;
            // 
            // gbx_Operaciones
            // 
            this.gbx_Operaciones.BackColor = System.Drawing.Color.Transparent;
            this.gbx_Operaciones.Controls.Add(this.btn_Borrar);
            this.gbx_Operaciones.Controls.Add(this.btn_Calcular);
            this.gbx_Operaciones.Controls.Add(this.rbt_Division);
            this.gbx_Operaciones.Controls.Add(this.rbt_Multiplicacion);
            this.gbx_Operaciones.Controls.Add(this.rbt_Resta);
            this.gbx_Operaciones.Controls.Add(this.rbt_Suma);
            this.gbx_Operaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Operaciones.ForeColor = System.Drawing.SystemColors.Control;
            this.gbx_Operaciones.Location = new System.Drawing.Point(12, 129);
            this.gbx_Operaciones.Name = "gbx_Operaciones";
            this.gbx_Operaciones.Size = new System.Drawing.Size(231, 130);
            this.gbx_Operaciones.TabIndex = 6;
            this.gbx_Operaciones.TabStop = false;
            this.gbx_Operaciones.Text = "Operaciones";
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Borrar.Location = new System.Drawing.Point(139, 75);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(86, 40);
            this.btn_Borrar.TabIndex = 5;
            this.btn_Borrar.Text = "BORRAR";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Calcular.Location = new System.Drawing.Point(139, 19);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(86, 40);
            this.btn_Calcular.TabIndex = 4;
            this.btn_Calcular.Text = "CALCULAR";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // rbt_Division
            // 
            this.rbt_Division.AutoSize = true;
            this.rbt_Division.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Division.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.rbt_Division.Location = new System.Drawing.Point(10, 88);
            this.rbt_Division.Name = "rbt_Division";
            this.rbt_Division.Size = new System.Drawing.Size(84, 27);
            this.rbt_Division.TabIndex = 3;
            this.rbt_Division.TabStop = true;
            this.rbt_Division.Text = "Division";
            this.rbt_Division.UseVisualStyleBackColor = true;
            this.rbt_Division.CheckedChanged += new System.EventHandler(this.rbt_Division_CheckedChanged);
            // 
            // rbt_Multiplicacion
            // 
            this.rbt_Multiplicacion.AutoSize = true;
            this.rbt_Multiplicacion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Multiplicacion.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.rbt_Multiplicacion.Location = new System.Drawing.Point(10, 65);
            this.rbt_Multiplicacion.Name = "rbt_Multiplicacion";
            this.rbt_Multiplicacion.Size = new System.Drawing.Size(128, 27);
            this.rbt_Multiplicacion.TabIndex = 2;
            this.rbt_Multiplicacion.TabStop = true;
            this.rbt_Multiplicacion.Text = "Multiplicacion";
            this.rbt_Multiplicacion.UseVisualStyleBackColor = true;
            this.rbt_Multiplicacion.CheckedChanged += new System.EventHandler(this.rbt_Multiplicacion_CheckedChanged);
            // 
            // rbt_Resta
            // 
            this.rbt_Resta.AutoSize = true;
            this.rbt_Resta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Resta.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.rbt_Resta.Location = new System.Drawing.Point(10, 42);
            this.rbt_Resta.Name = "rbt_Resta";
            this.rbt_Resta.Size = new System.Drawing.Size(72, 27);
            this.rbt_Resta.TabIndex = 1;
            this.rbt_Resta.TabStop = true;
            this.rbt_Resta.Text = "Resta";
            this.rbt_Resta.UseVisualStyleBackColor = true;
            this.rbt_Resta.CheckedChanged += new System.EventHandler(this.rbt_Resta_CheckedChanged);
            // 
            // rbt_Suma
            // 
            this.rbt_Suma.AutoSize = true;
            this.rbt_Suma.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Suma.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.rbt_Suma.Location = new System.Drawing.Point(10, 19);
            this.rbt_Suma.Name = "rbt_Suma";
            this.rbt_Suma.Size = new System.Drawing.Size(68, 27);
            this.rbt_Suma.TabIndex = 0;
            this.rbt_Suma.TabStop = true;
            this.rbt_Suma.Text = "Suma";
            this.rbt_Suma.UseVisualStyleBackColor = true;
            this.rbt_Suma.CheckedChanged += new System.EventHandler(this.rbt_Suma_CheckedChanged);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(85, 265);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 7;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculadora.Properties.Resources._2020_01_08_15_13_08;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(255, 300);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.gbx_Operaciones);
            this.Controls.Add(this.txt_Numero3);
            this.Controls.Add(this.txt_Numero2);
            this.Controls.Add(this.txt_Numero1);
            this.Controls.Add(this.lbl_Numero3);
            this.Controls.Add(this.lbl_Numero2);
            this.Controls.Add(this.lbl_Numero1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.gbx_Operaciones.ResumeLayout(false);
            this.gbx_Operaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Numero1;
        private System.Windows.Forms.Label lbl_Numero2;
        private System.Windows.Forms.Label lbl_Numero3;
        private System.Windows.Forms.TextBox txt_Numero1;
        private System.Windows.Forms.TextBox txt_Numero2;
        private System.Windows.Forms.TextBox txt_Numero3;
        private System.Windows.Forms.GroupBox gbx_Operaciones;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.RadioButton rbt_Division;
        private System.Windows.Forms.RadioButton rbt_Multiplicacion;
        private System.Windows.Forms.RadioButton rbt_Resta;
        private System.Windows.Forms.RadioButton rbt_Suma;
        private System.Windows.Forms.Button btn_Salir;
    }
}

