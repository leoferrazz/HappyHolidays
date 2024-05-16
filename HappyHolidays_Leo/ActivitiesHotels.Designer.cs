namespace HappyHolidays_Leo
{
    partial class ActivitiesHotels
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
            this.dataGridViewActHotels = new System.Windows.Forms.DataGridView();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buttonBack = new System.Windows.Forms.Button();
            this.actividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonActHotelAsignar = new System.Windows.Forms.Button();
            this.idciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceActHotels = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActHotels)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActHotels)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewActHotels
            // 
            this.dataGridViewActHotels.AllowUserToAddRows = false;
            this.dataGridViewActHotels.AllowUserToDeleteRows = false;
            this.dataGridViewActHotels.AllowUserToResizeColumns = false;
            this.dataGridViewActHotels.AllowUserToResizeRows = false;
            this.dataGridViewActHotels.AutoGenerateColumns = false;
            this.dataGridViewActHotels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActHotels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idciudadDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.idactDataGridViewTextBoxColumn,
            this.gradoDataGridViewTextBoxColumn});
            this.dataGridViewActHotels.DataSource = this.bindingSourceActHotels;
            this.dataGridViewActHotels.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewActHotels.MultiSelect = false;
            this.dataGridViewActHotels.Name = "dataGridViewActHotels";
            this.dataGridViewActHotels.ReadOnly = true;
            this.dataGridViewActHotels.RowHeadersVisible = false;
            this.dataGridViewActHotels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActHotels.Size = new System.Drawing.Size(731, 353);
            this.dataGridViewActHotels.TabIndex = 9;
            this.dataGridViewActHotels.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewHotelChains_CellFormatting);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(668, 397);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 11;
            this.buttonDel.Text = "Borrar";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Location = new System.Drawing.Point(587, 397);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(75, 23);
            this.buttonMod.TabIndex = 10;
            this.buttonMod.Text = "Modificar";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actividadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 397);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // actividadToolStripMenuItem
            // 
            this.actividadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearActividadToolStripMenuItem,
            this.modificarActividadToolStripMenuItem,
            this.borrarActividadToolStripMenuItem});
            this.actividadToolStripMenuItem.Name = "actividadToolStripMenuItem";
            this.actividadToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.actividadToolStripMenuItem.Text = "Actividad";
            // 
            // crearActividadToolStripMenuItem
            // 
            this.crearActividadToolStripMenuItem.Name = "crearActividadToolStripMenuItem";
            this.crearActividadToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.crearActividadToolStripMenuItem.Text = "Crear Actividad";
            this.crearActividadToolStripMenuItem.Click += new System.EventHandler(this.crearActividadToolStripMenuItem_Click);
            // 
            // modificarActividadToolStripMenuItem
            // 
            this.modificarActividadToolStripMenuItem.Name = "modificarActividadToolStripMenuItem";
            this.modificarActividadToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.modificarActividadToolStripMenuItem.Text = "Modificar Actividad";
            this.modificarActividadToolStripMenuItem.Click += new System.EventHandler(this.modificarActividadToolStripMenuItem_Click);
            // 
            // borrarActividadToolStripMenuItem
            // 
            this.borrarActividadToolStripMenuItem.Name = "borrarActividadToolStripMenuItem";
            this.borrarActividadToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.borrarActividadToolStripMenuItem.Text = "Borrar Actividad";
            this.borrarActividadToolStripMenuItem.Click += new System.EventHandler(this.borrarActividadToolStripMenuItem_Click);
            // 
            // buttonActHotelAsignar
            // 
            this.buttonActHotelAsignar.Location = new System.Drawing.Point(446, 397);
            this.buttonActHotelAsignar.Name = "buttonActHotelAsignar";
            this.buttonActHotelAsignar.Size = new System.Drawing.Size(135, 23);
            this.buttonActHotelAsignar.TabIndex = 14;
            this.buttonActHotelAsignar.Text = "Asignar actividad a hotel";
            this.buttonActHotelAsignar.UseVisualStyleBackColor = true;
            this.buttonActHotelAsignar.Click += new System.EventHandler(this.buttonActHotelAsignar_Click);
            // 
            // idciudadDataGridViewTextBoxColumn
            // 
            this.idciudadDataGridViewTextBoxColumn.DataPropertyName = "id_ciudad";
            this.idciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.idciudadDataGridViewTextBoxColumn.Name = "idciudadDataGridViewTextBoxColumn";
            this.idciudadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idactDataGridViewTextBoxColumn
            // 
            this.idactDataGridViewTextBoxColumn.DataPropertyName = "id_act";
            this.idactDataGridViewTextBoxColumn.HeaderText = "Actividad";
            this.idactDataGridViewTextBoxColumn.Name = "idactDataGridViewTextBoxColumn";
            this.idactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradoDataGridViewTextBoxColumn
            // 
            this.gradoDataGridViewTextBoxColumn.DataPropertyName = "grado";
            this.gradoDataGridViewTextBoxColumn.HeaderText = "Grado";
            this.gradoDataGridViewTextBoxColumn.Name = "gradoDataGridViewTextBoxColumn";
            this.gradoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceActHotels
            // 
            this.bindingSourceActHotels.DataSource = typeof(HappyHolidays_Leo.Models.act_hotel);
            // 
            // ActivitiesHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 432);
            this.Controls.Add(this.buttonActHotelAsignar);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.dataGridViewActHotels);
            this.Name = "ActivitiesHotels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividades de hoteles";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActivitiesHotels_FormClosed);
            this.Load += new System.EventHandler(this.ActivitiesHotels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActHotels)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActHotels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewActHotels;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource bindingSourceActHotels;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn idciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem actividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarActividadToolStripMenuItem;
        private System.Windows.Forms.Button buttonActHotelAsignar;
    }
}