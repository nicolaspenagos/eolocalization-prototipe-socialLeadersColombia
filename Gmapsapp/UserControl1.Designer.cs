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
            this.gmap1.Location = new System.Drawing.Point(0, 0);
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
            this.gmap1.Size = new System.Drawing.Size(1336, 762);
            this.gmap1.TabIndex = 0;
            this.gmap1.Zoom = 0D;
            this.gmap1.Load += new System.EventHandler(this.gMapLoad);
            this.gmap1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gmap1_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(894, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "MOSTRAR RED DE LIDERESAS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gmap1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1336, 762);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap1;
        private System.Windows.Forms.Button button1;
    }
}
