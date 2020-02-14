namespace Gmapsapp
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gmap1 = new GMap.NET.WindowsForms.GMapControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gmap1
            // 
            this.gmap1.Bearing = 0F;
            this.gmap1.CanDragMap = true;
            this.gmap1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap1.GrayScaleMode = false;
            this.gmap1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap1.LevelsKeepInMemory = 5;
            this.gmap1.Location = new System.Drawing.Point(0, -45);
            this.gmap1.MarkersEnabled = true;
            this.gmap1.MaxZoom = 2;
            this.gmap1.MinZoom = 2;
            this.gmap1.MouseWheelZoomEnabled = true;
            this.gmap1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap1.Name = "gmap1";
            this.gmap1.NegativeMode = false;
            this.gmap1.PolygonsEnabled = true;
            this.gmap1.RetryLoadTile = 0;
            this.gmap1.RoutesEnabled = true;
            this.gmap1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap1.ShowTileGridLines = false;
            this.gmap1.Size = new System.Drawing.Size(1157, 574);
            this.gmap1.TabIndex = 0;
            this.gmap1.Zoom = 0D;
            this.gmap1.Load += new System.EventHandler(this.gMapLoad);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(702, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(428, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gmap1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1160, 529);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
