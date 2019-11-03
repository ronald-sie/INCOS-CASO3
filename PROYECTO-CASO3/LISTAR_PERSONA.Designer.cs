namespace PROYECTO_CASO3
{
    partial class LISTAR_PERSONA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LISTAR_PERSONA));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.listar_personas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.movermenu = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 60;
            this.bunifuElipse1.TargetControl = this;
            // 
            // listar_personas
            // 
            this.listar_personas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.listar_personas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.listar_personas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listar_personas.BorderRadius = 0;
            this.listar_personas.ButtonText = "                       LISTAR EMPLEADOS";
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
            this.listar_personas.Location = new System.Drawing.Point(379, 26);
            this.listar_personas.Name = "listar_personas";
            this.listar_personas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.listar_personas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.listar_personas.OnHoverTextColor = System.Drawing.Color.White;
            this.listar_personas.selected = false;
            this.listar_personas.Size = new System.Drawing.Size(372, 60);
            this.listar_personas.TabIndex = 0;
            this.listar_personas.Text = "                       LISTAR EMPLEADOS";
            this.listar_personas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listar_personas.Textcolor = System.Drawing.Color.White;
            this.listar_personas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listar_personas.Click += new System.EventHandler(this.listar_personas_Click);
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
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.DoubleBuffered = true;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView2.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(0, 117);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.Size = new System.Drawing.Size(1170, 363);
            this.dataGridView2.TabIndex = 1;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Brown;
            this.bunifuTileButton1.color = System.Drawing.Color.Brown;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Red;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 5;
            this.bunifuTileButton1.ImageZoom = 35;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "CERRAR";
            this.bunifuTileButton1.Location = new System.Drawing.Point(1036, 15);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(98, 82);
            this.bunifuTileButton1.TabIndex = 2;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // movermenu
            // 
            this.movermenu.Fixed = true;
            this.movermenu.Horizontal = true;
            this.movermenu.TargetControl = this;
            this.movermenu.Vertical = true;
            // 
            // LISTAR_PERSONA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 480);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.listar_personas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LISTAR_PERSONA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTAR_PERSONA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView2;
        private Bunifu.Framework.UI.BunifuFlatButton listar_personas;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuDragControl movermenu;
    }
}