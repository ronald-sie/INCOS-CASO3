namespace PROYECTO_CASO3
{
    partial class MODIFICAR_PERSONAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MODIFICAR_PERSONAL));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.estado_sub = new System.Windows.Forms.ComboBox();
            this.appat = new System.Windows.Forms.TextBox();
            this.actualizar = new System.Windows.Forms.Button();
            this.ci = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cargo = new System.Windows.Forms.ComboBox();
            this.ex = new System.Windows.Forms.ComboBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.celular = new System.Windows.Forms.TextBox();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.apmat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buscar_modicar = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.buscar_modificar_boton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.cancelar);
            this.groupBox1.Controls.Add(this.estado_sub);
            this.groupBox1.Controls.Add(this.appat);
            this.groupBox1.Controls.Add(this.actualizar);
            this.groupBox1.Controls.Add(this.ci);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cargo);
            this.groupBox1.Controls.Add(this.ex);
            this.groupBox1.Controls.Add(this.fecha);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.direccion);
            this.groupBox1.Controls.Add(this.celular);
            this.groupBox1.Controls.Add(this.sexo);
            this.groupBox1.Controls.Add(this.telefono);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.apmat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(33, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 373);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MODIFICAR DATOS DEL PERSONAL";
            // 
            // nombre
            // 
            this.nombre.Enabled = false;
            this.nombre.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(79, 32);
            this.nombre.Margin = new System.Windows.Forms.Padding(2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(119, 24);
            this.nombre.TabIndex = 48;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.Red;
            this.cancelar.Enabled = false;
            this.cancelar.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelar.Location = new System.Drawing.Point(368, 321);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(341, 36);
            this.cancelar.TabIndex = 72;
            this.cancelar.Text = "CANCELAR";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // estado_sub
            // 
            this.estado_sub.FormattingEnabled = true;
            this.estado_sub.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.estado_sub.Location = new System.Drawing.Point(155, 220);
            this.estado_sub.Margin = new System.Windows.Forms.Padding(2);
            this.estado_sub.Name = "estado_sub";
            this.estado_sub.Size = new System.Drawing.Size(293, 21);
            this.estado_sub.TabIndex = 73;
            this.estado_sub.Text = "SELECCIONE";
            // 
            // appat
            // 
            this.appat.Enabled = false;
            this.appat.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appat.Location = new System.Drawing.Point(323, 32);
            this.appat.Margin = new System.Windows.Forms.Padding(2);
            this.appat.Name = "appat";
            this.appat.Size = new System.Drawing.Size(125, 24);
            this.appat.TabIndex = 49;
            this.appat.TextChanged += new System.EventHandler(this.appat_TextChanged);
            // 
            // actualizar
            // 
            this.actualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.actualizar.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.actualizar.Location = new System.Drawing.Point(24, 321);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(325, 36);
            this.actualizar.TabIndex = 70;
            this.actualizar.Text = "ACTUALIZAR";
            this.actualizar.UseVisualStyleBackColor = false;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // ci
            // 
            this.ci.Enabled = false;
            this.ci.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ci.Location = new System.Drawing.Point(79, 78);
            this.ci.Margin = new System.Windows.Forms.Padding(2);
            this.ci.Name = "ci";
            this.ci.Size = new System.Drawing.Size(119, 24);
            this.ci.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 275);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 62;
            this.label7.Text = "Asignacion de cargo:";
            // 
            // cargo
            // 
            this.cargo.Enabled = false;
            this.cargo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargo.FormattingEnabled = true;
            this.cargo.Location = new System.Drawing.Point(155, 267);
            this.cargo.Margin = new System.Windows.Forms.Padding(2);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(293, 25);
            this.cargo.TabIndex = 55;
            this.cargo.Text = "SELECCIONE";
            // 
            // ex
            // 
            this.ex.Enabled = false;
            this.ex.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex.FormattingEnabled = true;
            this.ex.Items.AddRange(new object[] {
            "LP",
            "OR",
            "TJ",
            "SC",
            "CB",
            "PA",
            "PT",
            "CH",
            "BN"});
            this.ex.Location = new System.Drawing.Point(202, 78);
            this.ex.Margin = new System.Windows.Forms.Padding(2);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(63, 25);
            this.ex.TabIndex = 51;
            // 
            // fecha
            // 
            this.fecha.Enabled = false;
            this.fecha.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(155, 167);
            this.fecha.Margin = new System.Windows.Forms.Padding(2);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(293, 24);
            this.fecha.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 224);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 16);
            this.label11.TabIndex = 69;
            this.label11.Text = "Estado de subsidio:";
            // 
            // direccion
            // 
            this.direccion.Enabled = false;
            this.direccion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion.Location = new System.Drawing.Point(385, 78);
            this.direccion.Margin = new System.Windows.Forms.Padding(2);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(330, 24);
            this.direccion.TabIndex = 53;
            this.direccion.TextChanged += new System.EventHandler(this.direccion_TextChanged);
            // 
            // celular
            // 
            this.celular.Enabled = false;
            this.celular.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celular.Location = new System.Drawing.Point(535, 117);
            this.celular.Margin = new System.Windows.Forms.Padding(2);
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(180, 24);
            this.celular.TabIndex = 68;
            // 
            // sexo
            // 
            this.sexo.Enabled = false;
            this.sexo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO"});
            this.sexo.Location = new System.Drawing.Point(79, 116);
            this.sexo.Margin = new System.Windows.Forms.Padding(2);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(119, 25);
            this.sexo.TabIndex = 54;
            this.sexo.Text = "SELECCIONE";
            // 
            // telefono
            // 
            this.telefono.Enabled = false;
            this.telefono.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(279, 117);
            this.telefono.Margin = new System.Windows.Forms.Padding(2);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(169, 24);
            this.telefono.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(475, 124);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 66;
            this.label10.Text = "Celular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Apellidos Paterno:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(210, 124);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 65;
            this.label9.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "CI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(475, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 64;
            this.label8.Text = "Apellido Materno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // apmat
            // 
            this.apmat.Enabled = false;
            this.apmat.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apmat.Location = new System.Drawing.Point(590, 31);
            this.apmat.Margin = new System.Windows.Forms.Padding(2);
            this.apmat.Name = "apmat";
            this.apmat.Size = new System.Drawing.Size(125, 24);
            this.apmat.TabIndex = 63;
            this.apmat.TextChanged += new System.EventHandler(this.apmat_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 61;
            this.label6.Text = "Sexo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(513, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buscar_modicar);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.buscar_modificar_boton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(33, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 60);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // buscar_modicar
            // 
            this.buscar_modicar.Location = new System.Drawing.Point(203, 21);
            this.buscar_modicar.Margin = new System.Windows.Forms.Padding(2);
            this.buscar_modicar.Name = "buscar_modicar";
            this.buscar_modicar.Size = new System.Drawing.Size(131, 20);
            this.buscar_modicar.TabIndex = 79;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 26);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(177, 13);
            this.label19.TabIndex = 78;
            this.label19.Text = "Ingrese Codigo de la persona:";
            // 
            // buscar_modificar_boton
            // 
            this.buscar_modificar_boton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_modificar_boton.ForeColor = System.Drawing.Color.Black;
            this.buscar_modificar_boton.Location = new System.Drawing.Point(348, 14);
            this.buscar_modificar_boton.Margin = new System.Windows.Forms.Padding(2);
            this.buscar_modificar_boton.Name = "buscar_modificar_boton";
            this.buscar_modificar_boton.Size = new System.Drawing.Size(130, 38);
            this.buscar_modificar_boton.TabIndex = 77;
            this.buscar_modificar_boton.Text = "BUSCAR";
            this.buscar_modificar_boton.UseVisualStyleBackColor = true;
            this.buscar_modificar_boton.Click += new System.EventHandler(this.buscar_modificar_boton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(599, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 23);
            this.label12.TabIndex = 80;
            this.label12.Text = "Codigo generado:";
            // 
            // codigo
            // 
            this.codigo.Enabled = false;
            this.codigo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(603, 41);
            this.codigo.Margin = new System.Windows.Forms.Padding(2);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(122, 24);
            this.codigo.TabIndex = 79;
            // 
            // MODIFICAR_PERSONAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(793, 480);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MODIFICAR_PERSONAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODIFICAR_PERSONAL";
            this.Load += new System.EventHandler(this.MODIFICAR_PERSONAL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.ComboBox estado_sub;
        private System.Windows.Forms.TextBox appat;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.TextBox ci;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cargo;
        private System.Windows.Forms.ComboBox ex;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox celular;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox apmat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox buscar_modicar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buscar_modificar_boton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox codigo;
    }
}