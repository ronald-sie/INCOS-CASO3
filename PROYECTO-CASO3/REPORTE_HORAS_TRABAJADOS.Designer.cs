namespace PROYECTO_CASO3
{
    partial class REPORTE_HORAS_TRABAJADOS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REPORTE_HORAS_TRABAJADOS));
            this.DTPFECHA = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_PERSONA = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dataGridView2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.listar_personas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.GENERAR = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GENERAR)).BeginInit();
            this.SuspendLayout();
            // 
            // DTPFECHA
            // 
            this.DTPFECHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DTPFECHA.Location = new System.Drawing.Point(221, 452);
            this.DTPFECHA.Name = "DTPFECHA";
            this.DTPFECHA.Size = new System.Drawing.Size(347, 30);
            this.DTPFECHA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(341, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ELIJA UN MES ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ESCRIBA ID_PERSONA";
            // 
            // ID_PERSONA
            // 
            this.ID_PERSONA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID_PERSONA.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_PERSONA.ForeColor = System.Drawing.Color.White;
            this.ID_PERSONA.HintForeColor = System.Drawing.Color.White;
            this.ID_PERSONA.HintText = "";
            this.ID_PERSONA.isPassword = false;
            this.ID_PERSONA.LineFocusedColor = System.Drawing.Color.Blue;
            this.ID_PERSONA.LineIdleColor = System.Drawing.Color.Gray;
            this.ID_PERSONA.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ID_PERSONA.LineThickness = 4;
            this.ID_PERSONA.Location = new System.Drawing.Point(65, 439);
            this.ID_PERSONA.Margin = new System.Windows.Forms.Padding(4);
            this.ID_PERSONA.Name = "ID_PERSONA";
            this.ID_PERSONA.Size = new System.Drawing.Size(85, 43);
            this.ID_PERSONA.TabIndex = 3;
            this.ID_PERSONA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.DoubleBuffered = true;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView2.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(21, 106);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.Size = new System.Drawing.Size(1104, 272);
            this.dataGridView2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(602, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "REPORTE HORAS TRABAJADAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(873, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "REPORTE SUELDO A CANCELAR";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(957, 394);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // listar_personas
            // 
            this.listar_personas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.listar_personas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.listar_personas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listar_personas.BorderRadius = 0;
            this.listar_personas.ButtonText = "LISTAR EMPLEADOS";
            this.listar_personas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listar_personas.DisabledColor = System.Drawing.Color.Gray;
            this.listar_personas.Iconcolor = System.Drawing.Color.Transparent;
            this.listar_personas.Iconimage = ((System.Drawing.Image)(resources.GetObject("listar_personas.Iconimage")));
            this.listar_personas.Iconimage_right = null;
            this.listar_personas.Iconimage_right_Selected = null;
            this.listar_personas.Iconimage_Selected = null;
            this.listar_personas.IconMarginLeft = 0;
            this.listar_personas.IconMarginRight = 0;
            this.listar_personas.IconRightVisible = true;
            this.listar_personas.IconRightZoom = 0D;
            this.listar_personas.IconVisible = true;
            this.listar_personas.IconZoom = 120D;
            this.listar_personas.IsTab = false;
            this.listar_personas.Location = new System.Drawing.Point(379, 42);
            this.listar_personas.Name = "listar_personas";
            this.listar_personas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.listar_personas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.listar_personas.OnHoverTextColor = System.Drawing.Color.White;
            this.listar_personas.selected = false;
            this.listar_personas.Size = new System.Drawing.Size(198, 36);
            this.listar_personas.TabIndex = 5;
            this.listar_personas.Text = "LISTAR EMPLEADOS";
            this.listar_personas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listar_personas.Textcolor = System.Drawing.Color.White;
            this.listar_personas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listar_personas.Click += new System.EventHandler(this.listar_personas_Click);
            // 
            // GENERAR
            // 
            this.GENERAR.BackColor = System.Drawing.Color.Transparent;
            this.GENERAR.Image = ((System.Drawing.Image)(resources.GetObject("GENERAR.Image")));
            this.GENERAR.ImageActive = null;
            this.GENERAR.Location = new System.Drawing.Point(675, 394);
            this.GENERAR.Name = "GENERAR";
            this.GENERAR.Size = new System.Drawing.Size(71, 71);
            this.GENERAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GENERAR.TabIndex = 4;
            this.GENERAR.TabStop = false;
            this.GENERAR.Zoom = 10;
            this.GENERAR.Click += new System.EventHandler(this.GENERAR_Click);
            // 
            // REPORTE_HORAS_TRABAJADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1137, 533);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.listar_personas);
            this.Controls.Add(this.GENERAR);
            this.Controls.Add(this.ID_PERSONA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPFECHA);
            this.Name = "REPORTE_HORAS_TRABAJADOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE_HORAS_TRABAJADOS";
            this.Load += new System.EventHandler(this.REPORTE_HORAS_TRABAJADOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GENERAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTPFECHA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ID_PERSONA;
        private Bunifu.Framework.UI.BunifuImageButton GENERAR;
        private Bunifu.Framework.UI.BunifuFlatButton listar_personas;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}