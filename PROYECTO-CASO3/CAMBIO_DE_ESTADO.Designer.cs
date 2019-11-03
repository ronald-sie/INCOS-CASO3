namespace PROYECTO_CASO3
{
    partial class CAMBIO_DE_ESTADO
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
            this.eliminar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cambio_estado = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(420, 29);
            this.eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.eliminar.Multiline = true;
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(177, 36);
            this.eliminar.TabIndex = 19;
            this.eliminar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.eliminar_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 99);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(538, 258);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cambio_estado
            // 
            this.cambio_estado.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambio_estado.Location = new System.Drawing.Point(326, 390);
            this.cambio_estado.Margin = new System.Windows.Forms.Padding(2);
            this.cambio_estado.Name = "cambio_estado";
            this.cambio_estado.Size = new System.Drawing.Size(271, 41);
            this.cambio_estado.TabIndex = 17;
            this.cambio_estado.Text = "CAMBIO DE ESTADO";
            this.cambio_estado.UseVisualStyleBackColor = true;
            this.cambio_estado.Click += new System.EventHandler(this.cambio_estado_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(360, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ingrese Codigo de la persona o nombre de persona:";
            // 
            // CAMBIO_DE_ESTADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 458);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cambio_estado);
            this.Controls.Add(this.label9);
            this.Name = "CAMBIO_DE_ESTADO";
            this.Text = "CAMBIO_DE_ESTADO";
            this.Load += new System.EventHandler(this.CAMBIO_DE_ESTADO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cambio_estado;
        private System.Windows.Forms.Label label9;
    }
}