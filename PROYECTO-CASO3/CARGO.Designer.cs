namespace PROYECTO_CASO3
{
    partial class CARGO
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CARGO));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre_cargo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.descripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sueldo_fijo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nuevo = new Bunifu.Framework.UI.BunifuTileButton();
            this.guardar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelar = new Bunifu.Framework.UI.BunifuImageButton();
            this.movermenu = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sueldo_fijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardar)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 180);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 45;
            this.label8.Text = "Sueldo fijo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nombre del cargo:";
            // 
            // nombre_cargo
            // 
            this.nombre_cargo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nombre_cargo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nombre_cargo.ForeColor = System.Drawing.Color.White;
            this.nombre_cargo.HintForeColor = System.Drawing.Color.Empty;
            this.nombre_cargo.HintText = "";
            this.nombre_cargo.isPassword = false;
            this.nombre_cargo.LineFocusedColor = System.Drawing.Color.Blue;
            this.nombre_cargo.LineIdleColor = System.Drawing.Color.Gray;
            this.nombre_cargo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.nombre_cargo.LineThickness = 3;
            this.nombre_cargo.Location = new System.Drawing.Point(207, 77);
            this.nombre_cargo.Margin = new System.Windows.Forms.Padding(4);
            this.nombre_cargo.Name = "nombre_cargo";
            this.nombre_cargo.Size = new System.Drawing.Size(375, 33);
            this.nombre_cargo.TabIndex = 46;
            this.nombre_cargo.Text = "ingrese nombre del cargo";
            this.nombre_cargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nombre_cargo.OnValueChanged += new System.EventHandler(this.nombre_cargo_OnValueChanged);
            // 
            // descripcion
            // 
            this.descripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.descripcion.ForeColor = System.Drawing.Color.White;
            this.descripcion.HintForeColor = System.Drawing.Color.Empty;
            this.descripcion.HintText = "";
            this.descripcion.isPassword = false;
            this.descripcion.LineFocusedColor = System.Drawing.Color.Blue;
            this.descripcion.LineIdleColor = System.Drawing.Color.Gray;
            this.descripcion.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.descripcion.LineThickness = 3;
            this.descripcion.Location = new System.Drawing.Point(207, 124);
            this.descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(375, 33);
            this.descripcion.TabIndex = 47;
            this.descripcion.Text = "ingrese una descripcion";
            this.descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sueldo_fijo
            // 
            this.sueldo_fijo.Location = new System.Drawing.Point(207, 185);
            this.sueldo_fijo.Name = "sueldo_fijo";
            this.sueldo_fijo.Size = new System.Drawing.Size(375, 20);
            this.sueldo_fijo.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(283, 299);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 52;
            this.label4.Text = "GUARDAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(458, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 53;
            this.label5.Text = "CANCELAR";
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.Color.Teal;
            this.nuevo.color = System.Drawing.Color.Teal;
            this.nuevo.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevo.ForeColor = System.Drawing.Color.White;
            this.nuevo.Image = ((System.Drawing.Image)(resources.GetObject("nuevo.Image")));
            this.nuevo.ImagePosition = 4;
            this.nuevo.ImageZoom = 20;
            this.nuevo.LabelPosition = 36;
            this.nuevo.LabelText = "NUEVO";
            this.nuevo.Location = new System.Drawing.Point(56, 225);
            this.nuevo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(155, 67);
            this.nuevo.TabIndex = 51;
            this.nuevo.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.SeaGreen;
            this.guardar.Image = ((System.Drawing.Image)(resources.GetObject("guardar.Image")));
            this.guardar.ImageActive = null;
            this.guardar.Location = new System.Drawing.Point(294, 225);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(77, 67);
            this.guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guardar.TabIndex = 49;
            this.guardar.TabStop = false;
            this.guardar.Zoom = 20;
            this.guardar.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(103)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(103)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(616, 54);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PROYECTO_CASO3.Properties.Resources.eliminar_boton_cuadrado;
            this.pictureBox2.Location = new System.Drawing.Point(553, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "CARGO";
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.Red;
            this.cancelar.Image = ((System.Drawing.Image)(resources.GetObject("cancelar.Image")));
            this.cancelar.ImageActive = null;
            this.cancelar.Location = new System.Drawing.Point(472, 225);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(77, 67);
            this.cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cancelar.TabIndex = 54;
            this.cancelar.TabStop = false;
            this.cancelar.Zoom = 20;
            this.cancelar.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // movermenu
            // 
            this.movermenu.Fixed = true;
            this.movermenu.Horizontal = true;
            this.movermenu.TargetControl = this.bunifuGradientPanel1;
            this.movermenu.Vertical = true;
            // 
            // CARGO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(616, 339);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.sueldo_fijo);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.nombre_cargo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CARGO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARGO";
            ((System.ComponentModel.ISupportInitialize)(this.sueldo_fijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardar)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuTileButton nuevo;
        private Bunifu.Framework.UI.BunifuImageButton guardar;
        private System.Windows.Forms.NumericUpDown sueldo_fijo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox descripcion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nombre_cargo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton cancelar;
        private Bunifu.Framework.UI.BunifuDragControl movermenu;
    }
}