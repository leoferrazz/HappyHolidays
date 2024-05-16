namespace HappyHolidays_Leo
{
    partial class ActHotelAddMod
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxHotels = new System.Windows.Forms.ComboBox();
            this.bindingSourceHotels = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxActivities = new System.Windows.Forms.ComboBox();
            this.bindingSourceActivities = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarGrado = new System.Windows.Forms.TrackBar();
            this.labelGradoValue = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAction = new System.Windows.Forms.Button();
            this.textBoxBuscarHotel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHotels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hotel";
            // 
            // comboBoxHotels
            // 
            this.comboBoxHotels.DataSource = this.bindingSourceHotels;
            this.comboBoxHotels.DisplayMember = "nombre";
            this.comboBoxHotels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHotels.FormattingEnabled = true;
            this.comboBoxHotels.Location = new System.Drawing.Point(119, 47);
            this.comboBoxHotels.Name = "comboBoxHotels";
            this.comboBoxHotels.Size = new System.Drawing.Size(245, 21);
            this.comboBoxHotels.TabIndex = 6;
            this.comboBoxHotels.ValueMember = "id_ciudad";
            // 
            // bindingSourceHotels
            // 
            this.bindingSourceHotels.DataSource = typeof(HappyHolidays_Leo.Models.hoteles);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Actividad";
            // 
            // comboBoxActivities
            // 
            this.comboBoxActivities.DataSource = this.bindingSourceActivities;
            this.comboBoxActivities.DisplayMember = "descripcion";
            this.comboBoxActivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActivities.FormattingEnabled = true;
            this.comboBoxActivities.Location = new System.Drawing.Point(119, 79);
            this.comboBoxActivities.Name = "comboBoxActivities";
            this.comboBoxActivities.Size = new System.Drawing.Size(245, 21);
            this.comboBoxActivities.TabIndex = 8;
            this.comboBoxActivities.ValueMember = "id_act";
            // 
            // bindingSourceActivities
            // 
            this.bindingSourceActivities.DataSource = typeof(HappyHolidays_Leo.Models.actividades);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Grado";
            // 
            // trackBarGrado
            // 
            this.trackBarGrado.Location = new System.Drawing.Point(119, 113);
            this.trackBarGrado.Maximum = 100;
            this.trackBarGrado.Name = "trackBarGrado";
            this.trackBarGrado.Size = new System.Drawing.Size(212, 45);
            this.trackBarGrado.TabIndex = 10;
            this.trackBarGrado.Scroll += new System.EventHandler(this.trackBarGrado_Scroll);
            // 
            // labelGradoValue
            // 
            this.labelGradoValue.AutoSize = true;
            this.labelGradoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradoValue.Location = new System.Drawing.Point(337, 113);
            this.labelGradoValue.Name = "labelGradoValue";
            this.labelGradoValue.Size = new System.Drawing.Size(0, 20);
            this.labelGradoValue.TabIndex = 11;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(209, 150);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(290, 150);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(75, 23);
            this.buttonAction.TabIndex = 12;
            this.buttonAction.Text = "Añadir";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // textBoxBuscarHotel
            // 
            this.textBoxBuscarHotel.Location = new System.Drawing.Point(119, 12);
            this.textBoxBuscarHotel.Name = "textBoxBuscarHotel";
            this.textBoxBuscarHotel.Size = new System.Drawing.Size(246, 20);
            this.textBoxBuscarHotel.TabIndex = 14;
            this.textBoxBuscarHotel.TextChanged += new System.EventHandler(this.textBoxBuscarHotel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Buscar Hotel";
            // 
            // ActHotelAddMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 180);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBuscarHotel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.labelGradoValue);
            this.Controls.Add(this.trackBarGrado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxActivities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxHotels);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ActHotelAddMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividad de hotel";
            this.Load += new System.EventHandler(this.ActHotelAddMod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHotels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxHotels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxActivities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarGrado;
        private System.Windows.Forms.Label labelGradoValue;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.BindingSource bindingSourceActivities;
        private System.Windows.Forms.BindingSource bindingSourceHotels;
        private System.Windows.Forms.TextBox textBoxBuscarHotel;
        private System.Windows.Forms.Label label4;
    }
}