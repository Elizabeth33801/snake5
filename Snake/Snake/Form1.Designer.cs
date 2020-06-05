namespace Snake
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
      this.components = new System.ComponentModel.Container();
      this.canvas = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.puntos = new System.Windows.Forms.Label();
      this.bucle = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
      this.SuspendLayout();
      // 
      // canvas
      // 
      this.canvas.Location = new System.Drawing.Point(2, 2);
      this.canvas.Margin = new System.Windows.Forms.Padding(6);
      this.canvas.Name = "canvas";
      this.canvas.Size = new System.Drawing.Size(1463, 703);
      this.canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.canvas.TabIndex = 0;
      this.canvas.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(506, 750);
      this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(158, 42);
      this.label1.TabIndex = 1;
      this.label1.Text = "Puntaje";
      // 
      // puntos
      // 
      this.puntos.AutoSize = true;
      this.puntos.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.puntos.Location = new System.Drawing.Point(755, 750);
      this.puntos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.puntos.Name = "puntos";
      this.puntos.Size = new System.Drawing.Size(41, 42);
      this.puntos.TabIndex = 2;
      this.puntos.Text = "0";
      // 
      // bucle
      // 
      this.bucle.Enabled = true;
      this.bucle.Tick += new System.EventHandler(this.bucle_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1467, 831);
      this.Controls.Add(this.puntos);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.canvas);
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label puntos;
        private System.Windows.Forms.Timer bucle;
    }
}

