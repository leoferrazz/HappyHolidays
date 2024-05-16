namespace HappyHolidays_Leo
{
    partial class ControlPanel
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
            this.buttonCadenas = new System.Windows.Forms.Button();
            this.buttonHotels = new System.Windows.Forms.Button();
            this.buttonActHotels = new System.Windows.Forms.Button();
            this.labelPanel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCadenas
            // 
            this.buttonCadenas.Location = new System.Drawing.Point(100, 94);
            this.buttonCadenas.Name = "buttonCadenas";
            this.buttonCadenas.Size = new System.Drawing.Size(160, 46);
            this.buttonCadenas.TabIndex = 0;
            this.buttonCadenas.Text = "Cadenas hoteleras";
            this.buttonCadenas.UseVisualStyleBackColor = true;
            this.buttonCadenas.Click += new System.EventHandler(this.buttonCadenas_Click);
            // 
            // buttonHotels
            // 
            this.buttonHotels.Location = new System.Drawing.Point(100, 155);
            this.buttonHotels.Name = "buttonHotels";
            this.buttonHotels.Size = new System.Drawing.Size(160, 46);
            this.buttonHotels.TabIndex = 1;
            this.buttonHotels.Text = "Hoteles";
            this.buttonHotels.UseVisualStyleBackColor = true;
            this.buttonHotels.Click += new System.EventHandler(this.buttonHotels_Click);
            // 
            // buttonActHotels
            // 
            this.buttonActHotels.Location = new System.Drawing.Point(100, 219);
            this.buttonActHotels.Name = "buttonActHotels";
            this.buttonActHotels.Size = new System.Drawing.Size(160, 46);
            this.buttonActHotels.TabIndex = 2;
            this.buttonActHotels.Text = "Actividades de hoteles";
            this.buttonActHotels.UseVisualStyleBackColor = true;
            this.buttonActHotels.Click += new System.EventHandler(this.buttonActHotels_Click);
            // 
            // labelPanel
            // 
            this.labelPanel.AutoSize = true;
            this.labelPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanel.Location = new System.Drawing.Point(82, 39);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(193, 29);
            this.labelPanel.TabIndex = 3;
            this.labelPanel.Text = "Panel de Control";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 308);
            this.Controls.Add(this.labelPanel);
            this.Controls.Add(this.buttonActHotels);
            this.Controls.Add(this.buttonHotels);
            this.Controls.Add(this.buttonCadenas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOHO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCadenas;
        private System.Windows.Forms.Button buttonHotels;
        private System.Windows.Forms.Button buttonActHotels;
        private System.Windows.Forms.Label labelPanel;
    }
}

