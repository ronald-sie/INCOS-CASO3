namespace PROYECTO_CASO3
{
    partial class REGISTRO_PERSONA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REGISTRO_PERSONA));
            this.estado_sub = new System.Windows.Forms.ComboBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.celular = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.apmat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cargo = new System.Windows.Forms.ComboBox();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.ex = new System.Windows.Forms.ComboBox();
            this.ci = new System.Windows.Forms.TextBox();
            this.appat = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.Red;
            this.cancelar.Enabled = false;
            this.cancelar.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelar.Location = new System.Drawing.Point(483, 321);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(226, 36);
            this.cancelar.TabIndex = 72;
            this.cancelar.Text = "CANCELAR";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.LightGreen;
            this.guardar.Enabled = false;
            this.guardar.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.ForeColor = System.Drawing.Color.Black;
            this.guardar.Location = new System.Drawing.Point(257, 321);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(209, 36);
            this.guardar.TabIndex = 71;
            this.guardar.Text = "GUARDAR";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.nuevo.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nuevo.Location = new System.Drawing.Point(24, 321);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(214, 36);
            this.nuevo.TabIndex = 70;
            this.nuevo.Text = "NUEVO";
            this.nuevo.UseVisualStyleBackColor = false;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.cancelar);
            this.groupBox1.Controls.Add(this.estado_sub);
            this.groupBox1.Controls.Add(this.guardar);
            this.groupBox1.Controls.Add(this.appat);
            this.groupBox1.Controls.Add(this.nuevo);
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
            this.groupBox1.Location = new System.Drawing.Point(37, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 373);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // REGISTRO_PERSONA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(793, 428);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "REGISTRO_PERSONA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO_PERSONA";
            this.Load += new System.EventHandler(this.REGISTRO_PERSONA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox estado_sub;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox celular;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox apmat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cargo;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.ComboBox ex;
        private System.Windows.Forms.TextBox ci;
        private System.Windows.Forms.TextBox appat;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}