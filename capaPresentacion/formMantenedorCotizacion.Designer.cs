﻿namespace capaPresentacion
{
    partial class formMantenedorCotizacion
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBoxMostrar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtIdMostrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.groupBoxRegistrar = new System.Windows.Forms.GroupBox();
            this.txtBoxTotalCotizacion = new System.Windows.Forms.TextBox();
            this.dateTPFechaCotizacion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDescripcionCotizacion = new System.Windows.Forms.TextBox();
            this.txtOrdenDeCompraC = new System.Windows.Forms.TextBox();
            this.txtNombreCotizacion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBoxMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.groupBoxRegistrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::capaPresentacion.Properties.Resources.Mass_logo_con_fondo;
            this.pictureBox2.Location = new System.Drawing.Point(444, -2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::capaPresentacion.Properties.Resources.partes;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::capaPresentacion.Properties.Resources.partes;
            this.pictureBox3.Location = new System.Drawing.Point(0, 486);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(795, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // groupBoxMostrar
            // 
            this.groupBoxMostrar.Controls.Add(this.btnEliminar);
            this.groupBoxMostrar.Controls.Add(this.txtIdMostrar);
            this.groupBoxMostrar.Controls.Add(this.label1);
            this.groupBoxMostrar.Controls.Add(this.dgvMostrar);
            this.groupBoxMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMostrar.Location = new System.Drawing.Point(9, 260);
            this.groupBoxMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxMostrar.Name = "groupBoxMostrar";
            this.groupBoxMostrar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxMostrar.Size = new System.Drawing.Size(630, 213);
            this.groupBoxMostrar.TabIndex = 14;
            this.groupBoxMostrar.TabStop = false;
            this.groupBoxMostrar.Text = "Mostrar/Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(268, 171);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 37);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtIdMostrar
            // 
            this.txtIdMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtIdMostrar.Location = new System.Drawing.Point(151, 179);
            this.txtIdMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdMostrar.Name = "txtIdMostrar";
            this.txtIdMostrar.Size = new System.Drawing.Size(102, 23);
            this.txtIdMostrar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(8, 22);
            this.dgvMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.RowHeadersWidth = 51;
            this.dgvMostrar.RowTemplate.Height = 24;
            this.dgvMostrar.Size = new System.Drawing.Size(611, 143);
            this.dgvMostrar.TabIndex = 0;
            this.dgvMostrar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrar_CellDoubleClick);
            // 
            // groupBoxRegistrar
            // 
            this.groupBoxRegistrar.Controls.Add(this.txtBoxTotalCotizacion);
            this.groupBoxRegistrar.Controls.Add(this.dateTPFechaCotizacion);
            this.groupBoxRegistrar.Controls.Add(this.label2);
            this.groupBoxRegistrar.Controls.Add(this.txtBoxDescripcionCotizacion);
            this.groupBoxRegistrar.Controls.Add(this.txtOrdenDeCompraC);
            this.groupBoxRegistrar.Controls.Add(this.txtNombreCotizacion);
            this.groupBoxRegistrar.Controls.Add(this.btnAgregar);
            this.groupBoxRegistrar.Controls.Add(this.label7);
            this.groupBoxRegistrar.Controls.Add(this.label6);
            this.groupBoxRegistrar.Controls.Add(this.label5);
            this.groupBoxRegistrar.Controls.Add(this.label4);
            this.groupBoxRegistrar.Controls.Add(this.label3);
            this.groupBoxRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegistrar.Location = new System.Drawing.Point(9, 83);
            this.groupBoxRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRegistrar.Name = "groupBoxRegistrar";
            this.groupBoxRegistrar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRegistrar.Size = new System.Drawing.Size(630, 172);
            this.groupBoxRegistrar.TabIndex = 13;
            this.groupBoxRegistrar.TabStop = false;
            this.groupBoxRegistrar.Text = "Registrar";
            // 
            // txtBoxTotalCotizacion
            // 
            this.txtBoxTotalCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotalCotizacion.Location = new System.Drawing.Point(162, 111);
            this.txtBoxTotalCotizacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxTotalCotizacion.Name = "txtBoxTotalCotizacion";
            this.txtBoxTotalCotizacion.Size = new System.Drawing.Size(200, 23);
            this.txtBoxTotalCotizacion.TabIndex = 14;
            // 
            // dateTPFechaCotizacion
            // 
            this.dateTPFechaCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTPFechaCotizacion.Location = new System.Drawing.Point(162, 84);
            this.dateTPFechaCotizacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTPFechaCotizacion.Name = "dateTPFechaCotizacion";
            this.dateTPFechaCotizacion.Size = new System.Drawing.Size(200, 23);
            this.dateTPFechaCotizacion.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha:";
            // 
            // txtBoxDescripcionCotizacion
            // 
            this.txtBoxDescripcionCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescripcionCotizacion.Location = new System.Drawing.Point(162, 139);
            this.txtBoxDescripcionCotizacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxDescripcionCotizacion.Name = "txtBoxDescripcionCotizacion";
            this.txtBoxDescripcionCotizacion.Size = new System.Drawing.Size(200, 23);
            this.txtBoxDescripcionCotizacion.TabIndex = 9;
            // 
            // txtOrdenDeCompraC
            // 
            this.txtOrdenDeCompraC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdenDeCompraC.Location = new System.Drawing.Point(162, 52);
            this.txtOrdenDeCompraC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrdenDeCompraC.Name = "txtOrdenDeCompraC";
            this.txtOrdenDeCompraC.Size = new System.Drawing.Size(200, 23);
            this.txtOrdenDeCompraC.TabIndex = 8;
            // 
            // txtNombreCotizacion
            // 
            this.txtNombreCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCotizacion.Location = new System.Drawing.Point(162, 23);
            this.txtNombreCotizacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreCotizacion.Name = "txtNombreCotizacion";
            this.txtNombreCotizacion.Size = new System.Drawing.Size(200, 23);
            this.txtNombreCotizacion.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(391, 39);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(210, 104);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Descripcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Orden de compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::capaPresentacion.Properties.Resources.partes;
            this.label8.Location = new System.Drawing.Point(29, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(406, 31);
            this.label8.TabIndex = 18;
            this.label8.Text = "MANTENEDOR COTIZACION";
            // 
            // formMantenedorCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(651, 534);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBoxMostrar);
            this.Controls.Add(this.groupBoxRegistrar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formMantenedorCotizacion";
            this.Text = "COTIZACIONES";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBoxMostrar.ResumeLayout(false);
            this.groupBoxMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.groupBoxRegistrar.ResumeLayout(false);
            this.groupBoxRegistrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBoxMostrar;
        private System.Windows.Forms.TextBox txtIdMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.GroupBox groupBoxRegistrar;
        private System.Windows.Forms.DateTimePicker dateTPFechaCotizacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxDescripcionCotizacion;
        private System.Windows.Forms.TextBox txtOrdenDeCompraC;
        private System.Windows.Forms.TextBox txtNombreCotizacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBoxTotalCotizacion;
    }
}