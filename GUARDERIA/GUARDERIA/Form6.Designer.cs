namespace GUARDERIA
{
    partial class Form6
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
            this.label12 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtcapacidad = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.btnmenu = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(221, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 31);
            this.label12.TabIndex = 67;
            this.label12.Text = "Datos del salon";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(302, 236);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(233, 84);
            this.txtdescripcion.TabIndex = 63;
            // 
            // txtcapacidad
            // 
            this.txtcapacidad.Location = new System.Drawing.Point(302, 207);
            this.txtcapacidad.Name = "txtcapacidad";
            this.txtcapacidad.Size = new System.Drawing.Size(233, 22);
            this.txtcapacidad.TabIndex = 62;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(302, 176);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(147, 22);
            this.txtcodigo.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Descripcion del salon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Capacidad del salon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Codigo del salon";
            // 
            // DataView
            // 
            this.DataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(82, 346);
            this.DataView.Name = "DataView";
            this.DataView.RowHeadersWidth = 51;
            this.DataView.RowTemplate.Height = 24;
            this.DataView.Size = new System.Drawing.Size(503, 150);
            this.DataView.TabIndex = 99;
            // 
            // btnmenu
            // 
            this.btnmenu.BackgroundImage = global::GUARDERIA.Properties.Resources.png_transparent_computer_icons_house_house_angle_logo_home_icon1;
            this.btnmenu.Location = new System.Drawing.Point(395, 81);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(64, 59);
            this.btnmenu.TabIndex = 94;
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = global::GUARDERIA.Properties.Resources.x31;
            this.btneliminar.Location = new System.Drawing.Point(325, 79);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(64, 59);
            this.btneliminar.TabIndex = 93;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImage = global::GUARDERIA.Properties.Resources._31762385;
            this.btnbuscar.Location = new System.Drawing.Point(255, 79);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(64, 59);
            this.btnbuscar.TabIndex = 92;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackgroundImage = global::GUARDERIA.Properties.Resources._2690744;
            this.btnmodificar.Location = new System.Drawing.Point(185, 79);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(64, 59);
            this.btnmodificar.TabIndex = 91;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::GUARDERIA.Properties.Resources.Save_371104;
            this.btnGuardar.Location = new System.Drawing.Point(115, 79);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 61);
            this.btnGuardar.TabIndex = 90;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.BackgroundImage = global::GUARDERIA.Properties.Resources.form1fondo2;
            this.button1.Location = new System.Drawing.Point(-12, -12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(675, 162);
            this.button1.TabIndex = 104;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(637, 508);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcapacidad);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form6";
            this.Text = "Salon";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtcapacidad;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Button button1;
    }
}