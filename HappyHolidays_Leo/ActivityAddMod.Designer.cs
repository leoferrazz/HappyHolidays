namespace HappyHolidays_Leo
{
    partial class ActivityAddMod
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
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAction = new System.Windows.Forms.Button();
            this.comboBoxActivities = new System.Windows.Forms.ComboBox();
            this.bindingSourceActivities = new System.Windows.Forms.BindingSource(this.components);
            this.labelAct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(108, 50);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(293, 20);
            this.textBoxDesc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descripción";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(245, 89);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(326, 89);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(75, 23);
            this.buttonAction.TabIndex = 8;
            this.buttonAction.Text = "Añadir";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // comboBoxActivities
            // 
            this.comboBoxActivities.DataSource = this.bindingSourceActivities;
            this.comboBoxActivities.DisplayMember = "descripcion";
            this.comboBoxActivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActivities.FormattingEnabled = true;
            this.comboBoxActivities.Location = new System.Drawing.Point(108, 23);
            this.comboBoxActivities.Name = "comboBoxActivities";
            this.comboBoxActivities.Size = new System.Drawing.Size(122, 21);
            this.comboBoxActivities.TabIndex = 10;
            this.comboBoxActivities.ValueMember = "id_act";
            this.comboBoxActivities.Visible = false;
            this.comboBoxActivities.SelectedIndexChanged += new System.EventHandler(this.comboBoxActivities_SelectedIndexChanged);
            // 
            // bindingSourceActivities
            // 
            this.bindingSourceActivities.DataSource = typeof(HappyHolidays_Leo.Models.actividades);
            // 
            // labelAct
            // 
            this.labelAct.AutoSize = true;
            this.labelAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAct.Location = new System.Drawing.Point(6, 21);
            this.labelAct.Name = "labelAct";
            this.labelAct.Size = new System.Drawing.Size(90, 20);
            this.labelAct.TabIndex = 11;
            this.labelAct.Text = "Actividades";
            this.labelAct.Visible = false;
            // 
            // ActivityAddMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 118);
            this.Controls.Add(this.labelAct);
            this.Controls.Add(this.comboBoxActivities);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ActivityAddMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividad";
            this.Load += new System.EventHandler(this.ActivityAddMod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.ComboBox comboBoxActivities;
        private System.Windows.Forms.Label labelAct;
        private System.Windows.Forms.BindingSource bindingSourceActivities;
    }
}