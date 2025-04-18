namespace GUARDERIA
{
    partial class Form5
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
            this.txtdieta = new System.Windows.Forms.TextBox();
            this.txtcuidado = new System.Windows.Forms.TextBox();
            this.txtmedicamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsangre = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtalergias = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.txttratamiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdieta
            // 
            this.txtdieta.Location = new System.Drawing.Point(573, 574);
            this.txtdieta.Multiline = true;
            this.txtdieta.Name = "txtdieta";
            this.txtdieta.Size = new System.Drawing.Size(233, 85);
            this.txtdieta.TabIndex = 92;
            // 
            // txtcuidado
            // 
            this.txtcuidado.Location = new System.Drawing.Point(573, 377);
            this.txtcuidado.Multiline = true;
            this.txtcuidado.Name = "txtcuidado";
            this.txtcuidado.Size = new System.Drawing.Size(233, 85);
            this.txtcuidado.TabIndex = 91;
            // 
            // txtmedicamento
            // 
            this.txtmedicamento.Location = new System.Drawing.Point(573, 286);
            this.txtmedicamento.Multiline = true;
            this.txtmedicamento.Name = "txtmedicamento";
            this.txtmedicamento.Size = new System.Drawing.Size(233, 85);
            this.txtmedicamento.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 31);
            this.label4.TabIndex = 84;
            this.label4.Text = "Expediente";
            // 
            // txtsangre
            // 
            this.txtsangre.Location = new System.Drawing.Point(570, 696);
            this.txtsangre.Name = "txtsangre";
            this.txtsangre.Size = new System.Drawing.Size(147, 22);
            this.txtsangre.TabIndex = 83;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(570, 665);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(89, 22);
            this.txtedad.TabIndex = 82;
            // 
            // txtalergias
            // 
            this.txtalergias.Location = new System.Drawing.Point(573, 195);
            this.txtalergias.Multiline = true;
            this.txtalergias.Name = "txtalergias";
            this.txtalergias.Size = new System.Drawing.Size(233, 85);
            this.txtalergias.TabIndex = 81;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(573, 164);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(147, 22);
            this.txtcodigo.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(286, 598);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 17);
            this.label7.TabIndex = 79;
            this.label7.Text = "Dieta que necesita";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(286, 692);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 78;
            this.label6.Text = "Tipo de sangre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(286, 664);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 77;
            this.label8.Text = "Edad del nino";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(286, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 17);
            this.label11.TabIndex = 76;
            this.label11.Text = "Cuidados que necesite el nino";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(289, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(262, 17);
            this.label13.TabIndex = 75;
            this.label13.Text = "Medicamentos que necesite el nino";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(289, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 17);
            this.label14.TabIndex = 74;
            this.label14.Text = "Alergias";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(289, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 17);
            this.label15.TabIndex = 73;
            this.label15.Text = "Codigo de expediente";
            // 
            // DataView
            // 
            this.DataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DataView.Location = new System.Drawing.Point(12, 741);
            this.DataView.Name = "DataView";
            this.DataView.RowHeadersWidth = 51;
            this.DataView.RowTemplate.Height = 24;
            this.DataView.Size = new System.Drawing.Size(1118, 150);
            this.DataView.TabIndex = 98;
            // 
            // txttratamiento
            // 
            this.txttratamiento.Location = new System.Drawing.Point(570, 468);
            this.txttratamiento.Multiline = true;
            this.txttratamiento.Name = "txttratamiento";
            this.txttratamiento.Size = new System.Drawing.Size(233, 85);
            this.txttratamiento.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "Manera de suministrar medicamento";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.BackgroundImage = global::GUARDERIA.Properties.Resources.entretenimiento_y_ocio_fondo_inconsútil_contorno_del_s_de_los_niños_anaranjado_84281293;
            this.button1.Location = new System.Drawing.Point(3, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1335, 162);
            this.button1.TabIndex = 105;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnmenu
            // 
            this.btnmenu.BackgroundImage = global::GUARDERIA.Properties.Resources.png_transparent_computer_icons_house_house_angle_logo_home_icon1;
            this.btnmenu.Location = new System.Drawing.Point(642, 64);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(64, 59);
            this.btnmenu.TabIndex = 89;
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = global::GUARDERIA.Properties.Resources.x3;
            this.btneliminar.Location = new System.Drawing.Point(572, 64);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(64, 59);
            this.btneliminar.TabIndex = 88;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImage = global::GUARDERIA.Properties.Resources._3176238;
            this.btnbuscar.Location = new System.Drawing.Point(502, 64);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(64, 59);
            this.btnbuscar.TabIndex = 87;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackgroundImage = global::GUARDERIA.Properties.Resources._269074;
            this.btnmodificar.Location = new System.Drawing.Point(432, 64);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(64, 59);
            this.btnmodificar.TabIndex = 86;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::GUARDERIA.Properties.Resources.Save_37110;
            this.btnGuardar.Location = new System.Drawing.Point(362, 62);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 61);
            this.btnGuardar.TabIndex = 85;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1221, 843);
            this.Controls.Add(this.txttratamiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.txtdieta);
            this.Controls.Add(this.txtcuidado);
            this.Controls.Add(this.txtmedicamento);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsangre);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtalergias);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Expediente";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtdieta;
        private System.Windows.Forms.TextBox txtcuidado;
        private System.Windows.Forms.TextBox txtmedicamento;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsangre;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtalergias;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.TextBox txttratamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}