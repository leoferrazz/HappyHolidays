namespace HappyHolidays_Leo
{
    partial class HotelChains
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
            this.dataGridViewHotelChains = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.cifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirfisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceHotelChains = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotelChains)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHotelChains)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHotelChains
            // 
            this.dataGridViewHotelChains.AllowUserToAddRows = false;
            this.dataGridViewHotelChains.AllowUserToDeleteRows = false;
            this.dataGridViewHotelChains.AllowUserToResizeColumns = false;
            this.dataGridViewHotelChains.AllowUserToResizeRows = false;
            this.dataGridViewHotelChains.AutoGenerateColumns = false;
            this.dataGridViewHotelChains.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHotelChains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHotelChains.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cifDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.dirfisDataGridViewTextBoxColumn});
            this.dataGridViewHotelChains.DataSource = this.bindingSourceHotelChains;
            this.dataGridViewHotelChains.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewHotelChains.MultiSelect = false;
            this.dataGridViewHotelChains.Name = "dataGridViewHotelChains";
            this.dataGridViewHotelChains.ReadOnly = true;
            this.dataGridViewHotelChains.RowHeadersVisible = false;
            this.dataGridViewHotelChains.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHotelChains.Size = new System.Drawing.Size(731, 353);
            this.dataGridViewHotelChains.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.añadirToolStripMenuItem.Text = "Añadir";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.añadirToolStripMenuItem_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(668, 397);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 5;
            this.buttonDel.Text = "Borrar";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Location = new System.Drawing.Point(587, 397);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(75, 23);
            this.buttonMod.TabIndex = 4;
            this.buttonMod.Text = "Modificar";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 397);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // cifDataGridViewTextBoxColumn
            // 
            this.cifDataGridViewTextBoxColumn.DataPropertyName = "cif";
            this.cifDataGridViewTextBoxColumn.HeaderText = "cif";
            this.cifDataGridViewTextBoxColumn.Name = "cifDataGridViewTextBoxColumn";
            this.cifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dirfisDataGridViewTextBoxColumn
            // 
            this.dirfisDataGridViewTextBoxColumn.DataPropertyName = "dir_fis";
            this.dirfisDataGridViewTextBoxColumn.HeaderText = "dir_fis";
            this.dirfisDataGridViewTextBoxColumn.Name = "dirfisDataGridViewTextBoxColumn";
            this.dirfisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceHotelChains
            // 
            this.bindingSourceHotelChains.DataSource = typeof(HappyHolidays_Leo.Models.cadenas);
            // 
            // HotelChains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 432);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.dataGridViewHotelChains);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HotelChains";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadenas Hoteleras";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HotelChains_FormClosed);
            this.Load += new System.EventHandler(this.HotelChains_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotelChains)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHotelChains)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHotelChains;
        private System.Windows.Forms.BindingSource bindingSourceHotelChains;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirfisDataGridViewTextBoxColumn;
    }
}