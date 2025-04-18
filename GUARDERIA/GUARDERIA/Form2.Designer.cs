namespace GUARDERIA
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtespecialidad = new System.Windows.Forms.TextBox();
            this.txtrfc = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtcurp = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.txtpuesto = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txthorario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnmenu = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(504, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Especialidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(504, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "RFC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(504, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Salario Semanal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(504, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "CURP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(504, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Puesto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(504, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Telefono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(504, 481);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Direccion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(504, 515);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Horario del empleado";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(694, 201);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(147, 22);
            this.txtcodigo.TabIndex = 10;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(694, 232);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(233, 22);
            this.txtnombre.TabIndex = 11;
            // 
            // txtespecialidad
            // 
            this.txtespecialidad.Location = new System.Drawing.Point(694, 261);
            this.txtespecialidad.Name = "txtespecialidad";
            this.txtespecialidad.Size = new System.Drawing.Size(147, 22);
            this.txtespecialidad.TabIndex = 12;
            // 
            // txtrfc
            // 
            this.txtrfc.Location = new System.Drawing.Point(694, 289);
            this.txtrfc.Name = "txtrfc";
            this.txtrfc.Size = new System.Drawing.Size(147, 22);
            this.txtrfc.TabIndex = 13;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(694, 322);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(89, 22);
            this.txtedad.TabIndex = 14;
            // 
            // txtcurp
            // 
            this.txtcurp.Location = new System.Drawing.Point(694, 354);
            this.txtcurp.Name = "txtcurp";
            this.txtcurp.Size = new System.Drawing.Size(187, 22);
            this.txtcurp.TabIndex = 15;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(694, 384);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(147, 22);
            this.txtsalario.TabIndex = 16;
            // 
            // txtpuesto
            // 
            this.txtpuesto.Location = new System.Drawing.Point(694, 415);
            this.txtpuesto.Name = "txtpuesto";
            this.txtpuesto.Size = new System.Drawing.Size(147, 22);
            this.txtpuesto.TabIndex = 17;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(694, 449);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(147, 22);
            this.txttelefono.TabIndex = 18;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(694, 475);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(357, 22);
            this.txtdireccion.TabIndex = 19;
            // 
            // txthorario
            // 
            this.txthorario.Location = new System.Drawing.Point(694, 509);
            this.txthorario.Name = "txthorario";
            this.txthorario.Size = new System.Drawing.Size(147, 22);
            this.txthorario.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(568, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(273, 31);
            this.label12.TabIndex = 21;
            this.label12.Text = "Datos del empleado";
            // 
            // btnmenu
            // 
            this.btnmenu.BackgroundImage = global::GUARDERIA.Properties.Resources.png_transparent_computer_icons_house_house_angle_logo_home_icon2;
            this.btnmenu.Location = new System.Drawing.Point(777, 96);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(64, 59);
            this.btnmenu.TabIndex = 94;
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = global::GUARDERIA.Properties.Resources.x31;
            this.btneliminar.Location = new System.Drawing.Point(707, 94);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(64, 59);
            this.btneliminar.TabIndex = 93;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImage = global::GUARDERIA.Properties.Resources._31762381;
            this.btnbuscar.Location = new System.Drawing.Point(637, 94);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(64, 59);
            this.btnbuscar.TabIndex = 92;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackgroundImage = global::GUARDERIA.Properties.Resources._2690741;
            this.btnmodificar.Location = new System.Drawing.Point(567, 96);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(64, 59);
            this.btnmodificar.TabIndex = 91;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::GUARDERIA.Properties.Resources.Save_371101;
            this.btnGuardar.Location = new System.Drawing.Point(497, 94);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 61);
            this.btnGuardar.TabIndex = 90;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // DataView
            // 
            this.DataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(25, 539);
            this.DataView.Name = "DataView";
            this.DataView.RowHeadersWidth = 51;
            this.DataView.RowTemplate.Height = 24;
            this.DataView.Size = new System.Drawing.Size(1371, 150);
            this.DataView.TabIndex = 95;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.BackgroundImage = global::GUARDERIA.Properties.Resources.form1fondo2;
            this.button1.Location = new System.Drawing.Point(-4, -7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1417, 188);
            this.button1.TabIndex = 105;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUARDERIA.Properties.Resources.fondoliso;
            this.ClientSize = new System.Drawing.Size(1408, 710);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txthorario);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtpuesto);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txtcurp);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtrfc);
            this.Controls.Add(this.txtespecialidad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtespecialidad;
        private System.Windows.Forms.TextBox txtrfc;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtcurp;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.TextBox txtpuesto;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txthorario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView DataView;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button button1;
    }
}