﻿namespace Web
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.pbxRecargar = new System.Windows.Forms.PictureBox();
            this.pbxNext = new System.Windows.Forms.PictureBox();
            this.pbxHome = new System.Windows.Forms.PictureBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 59);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(776, 379);
            this.webBrowser1.TabIndex = 1;
            // 
            // pbxBack
            // 
            this.pbxBack.Image = ((System.Drawing.Image)(resources.GetObject("pbxBack.Image")));
            this.pbxBack.Location = new System.Drawing.Point(12, 12);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(46, 29);
            this.pbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBack.TabIndex = 2;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // pbxRecargar
            // 
            this.pbxRecargar.Image = ((System.Drawing.Image)(resources.GetObject("pbxRecargar.Image")));
            this.pbxRecargar.Location = new System.Drawing.Point(116, 12);
            this.pbxRecargar.Name = "pbxRecargar";
            this.pbxRecargar.Size = new System.Drawing.Size(46, 29);
            this.pbxRecargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRecargar.TabIndex = 3;
            this.pbxRecargar.TabStop = false;
            this.pbxRecargar.Click += new System.EventHandler(this.pbxRecargar_Click);
            // 
            // pbxNext
            // 
            this.pbxNext.Image = ((System.Drawing.Image)(resources.GetObject("pbxNext.Image")));
            this.pbxNext.Location = new System.Drawing.Point(64, 12);
            this.pbxNext.Name = "pbxNext";
            this.pbxNext.Size = new System.Drawing.Size(46, 29);
            this.pbxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxNext.TabIndex = 4;
            this.pbxNext.TabStop = false;
            this.pbxNext.Click += new System.EventHandler(this.pbxNext_Click);
            // 
            // pbxHome
            // 
            this.pbxHome.Image = ((System.Drawing.Image)(resources.GetObject("pbxHome.Image")));
            this.pbxHome.Location = new System.Drawing.Point(168, 12);
            this.pbxHome.Name = "pbxHome";
            this.pbxHome.Size = new System.Drawing.Size(46, 29);
            this.pbxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHome.TabIndex = 6;
            this.pbxHome.TabStop = false;
            this.pbxHome.Click += new System.EventHandler(this.pbxHome_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(220, 19);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(511, 22);
            this.txtBuscador.TabIndex = 7;
            this.txtBuscador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscador_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(737, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 25);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Go";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.pbxHome);
            this.Controls.Add(this.pbxNext);
            this.Controls.Add(this.pbxRecargar);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.PictureBox pbxRecargar;
        private System.Windows.Forms.PictureBox pbxNext;
        private System.Windows.Forms.PictureBox pbxHome;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button btnBuscar;
    }
}

