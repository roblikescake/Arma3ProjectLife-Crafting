namespace Arma3ProjectLife_Crafting.ui
{
    partial class CraftingMenu
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
            this.panelChoooseCar = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonVehicleTypeCar = new System.Windows.Forms.Button();
            this.panelVehicleType = new System.Windows.Forms.Panel();
            this.buttonVehicleTypeOther = new System.Windows.Forms.Button();
            this.buttonVehicleTypeTrailer = new System.Windows.Forms.Button();
            this.buttonVehicleTypeTruck = new System.Windows.Forms.Button();
            this.buttonVehicleTypeSUV = new System.Windows.Forms.Button();
            this.buttonChooseVehicleType = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBoxVehicleList = new System.Windows.Forms.ComboBox();
            this.staticLabelChooseVehicle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelVehicleType.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChoooseCar
            // 
            this.panelChoooseCar.Location = new System.Drawing.Point(4, 4);
            this.panelChoooseCar.Name = "panelChoooseCar";
            this.panelChoooseCar.Size = new System.Drawing.Size(350, 1000);
            this.panelChoooseCar.TabIndex = 0;
            // 
            // buttonVehicleTypeCar
            // 
            this.buttonVehicleTypeCar.BackColor = System.Drawing.Color.Gray;
            this.buttonVehicleTypeCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVehicleTypeCar.FlatAppearance.BorderSize = 0;
            this.buttonVehicleTypeCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVehicleTypeCar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVehicleTypeCar.ForeColor = System.Drawing.Color.Black;
            this.buttonVehicleTypeCar.Location = new System.Drawing.Point(0, 75);
            this.buttonVehicleTypeCar.Name = "buttonVehicleTypeCar";
            this.buttonVehicleTypeCar.Padding = new System.Windows.Forms.Padding(1);
            this.buttonVehicleTypeCar.Size = new System.Drawing.Size(350, 75);
            this.buttonVehicleTypeCar.TabIndex = 2;
            this.buttonVehicleTypeCar.Text = "Car";
            this.buttonVehicleTypeCar.UseVisualStyleBackColor = false;
            this.buttonVehicleTypeCar.Click += new System.EventHandler(this.buttonVehicleTypeCar_Click);
            // 
            // panelVehicleType
            // 
            this.panelVehicleType.Controls.Add(this.buttonVehicleTypeOther);
            this.panelVehicleType.Controls.Add(this.buttonVehicleTypeTrailer);
            this.panelVehicleType.Controls.Add(this.buttonVehicleTypeTruck);
            this.panelVehicleType.Controls.Add(this.buttonVehicleTypeSUV);
            this.panelVehicleType.Controls.Add(this.buttonVehicleTypeCar);
            this.panelVehicleType.Controls.Add(this.buttonChooseVehicleType);
            this.panelVehicleType.Location = new System.Drawing.Point(4, 4);
            this.panelVehicleType.MaximumSize = new System.Drawing.Size(350, 450);
            this.panelVehicleType.MinimumSize = new System.Drawing.Size(350, 75);
            this.panelVehicleType.Name = "panelVehicleType";
            this.panelVehicleType.Size = new System.Drawing.Size(350, 75);
            this.panelVehicleType.TabIndex = 1;
            // 
            // buttonVehicleTypeOther
            // 
            this.buttonVehicleTypeOther.BackColor = System.Drawing.Color.Gray;
            this.buttonVehicleTypeOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVehicleTypeOther.FlatAppearance.BorderSize = 0;
            this.buttonVehicleTypeOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVehicleTypeOther.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVehicleTypeOther.ForeColor = System.Drawing.Color.Black;
            this.buttonVehicleTypeOther.Location = new System.Drawing.Point(0, 375);
            this.buttonVehicleTypeOther.Name = "buttonVehicleTypeOther";
            this.buttonVehicleTypeOther.Padding = new System.Windows.Forms.Padding(1);
            this.buttonVehicleTypeOther.Size = new System.Drawing.Size(350, 75);
            this.buttonVehicleTypeOther.TabIndex = 6;
            this.buttonVehicleTypeOther.Text = "Other";
            this.buttonVehicleTypeOther.UseVisualStyleBackColor = false;
            this.buttonVehicleTypeOther.Click += new System.EventHandler(this.buttonVehicleTypeOther_Click);
            // 
            // buttonVehicleTypeTrailer
            // 
            this.buttonVehicleTypeTrailer.BackColor = System.Drawing.Color.Gray;
            this.buttonVehicleTypeTrailer.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVehicleTypeTrailer.FlatAppearance.BorderSize = 0;
            this.buttonVehicleTypeTrailer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVehicleTypeTrailer.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVehicleTypeTrailer.ForeColor = System.Drawing.Color.Black;
            this.buttonVehicleTypeTrailer.Location = new System.Drawing.Point(0, 300);
            this.buttonVehicleTypeTrailer.Name = "buttonVehicleTypeTrailer";
            this.buttonVehicleTypeTrailer.Padding = new System.Windows.Forms.Padding(1);
            this.buttonVehicleTypeTrailer.Size = new System.Drawing.Size(350, 75);
            this.buttonVehicleTypeTrailer.TabIndex = 5;
            this.buttonVehicleTypeTrailer.Text = "Trailer";
            this.buttonVehicleTypeTrailer.UseVisualStyleBackColor = false;
            this.buttonVehicleTypeTrailer.Click += new System.EventHandler(this.buttonVehicleTypeTrailer_Click);
            // 
            // buttonVehicleTypeTruck
            // 
            this.buttonVehicleTypeTruck.BackColor = System.Drawing.Color.Gray;
            this.buttonVehicleTypeTruck.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVehicleTypeTruck.FlatAppearance.BorderSize = 0;
            this.buttonVehicleTypeTruck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVehicleTypeTruck.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVehicleTypeTruck.ForeColor = System.Drawing.Color.Black;
            this.buttonVehicleTypeTruck.Location = new System.Drawing.Point(0, 225);
            this.buttonVehicleTypeTruck.Name = "buttonVehicleTypeTruck";
            this.buttonVehicleTypeTruck.Padding = new System.Windows.Forms.Padding(1);
            this.buttonVehicleTypeTruck.Size = new System.Drawing.Size(350, 75);
            this.buttonVehicleTypeTruck.TabIndex = 4;
            this.buttonVehicleTypeTruck.Text = "Truck";
            this.buttonVehicleTypeTruck.UseVisualStyleBackColor = false;
            this.buttonVehicleTypeTruck.Click += new System.EventHandler(this.buttonVehicleTypeTruck_Click);
            // 
            // buttonVehicleTypeSUV
            // 
            this.buttonVehicleTypeSUV.BackColor = System.Drawing.Color.Gray;
            this.buttonVehicleTypeSUV.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVehicleTypeSUV.FlatAppearance.BorderSize = 0;
            this.buttonVehicleTypeSUV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVehicleTypeSUV.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVehicleTypeSUV.ForeColor = System.Drawing.Color.Black;
            this.buttonVehicleTypeSUV.Location = new System.Drawing.Point(0, 150);
            this.buttonVehicleTypeSUV.Name = "buttonVehicleTypeSUV";
            this.buttonVehicleTypeSUV.Padding = new System.Windows.Forms.Padding(1);
            this.buttonVehicleTypeSUV.Size = new System.Drawing.Size(350, 75);
            this.buttonVehicleTypeSUV.TabIndex = 3;
            this.buttonVehicleTypeSUV.Text = "SUV";
            this.buttonVehicleTypeSUV.UseVisualStyleBackColor = false;
            this.buttonVehicleTypeSUV.Click += new System.EventHandler(this.buttonVehicleTypeSUV_Click);
            // 
            // buttonChooseVehicleType
            // 
            this.buttonChooseVehicleType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonChooseVehicleType.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChooseVehicleType.FlatAppearance.BorderSize = 0;
            this.buttonChooseVehicleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseVehicleType.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseVehicleType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonChooseVehicleType.Image = global::Arma3ProjectLife_Crafting.Properties.Resources.Expand_Arrow_20px;
            this.buttonChooseVehicleType.Location = new System.Drawing.Point(0, 0);
            this.buttonChooseVehicleType.Name = "buttonChooseVehicleType";
            this.buttonChooseVehicleType.Size = new System.Drawing.Size(350, 75);
            this.buttonChooseVehicleType.TabIndex = 1;
            this.buttonChooseVehicleType.Text = "Vehicle Type";
            this.buttonChooseVehicleType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChooseVehicleType.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonChooseVehicleType.UseVisualStyleBackColor = false;
            this.buttonChooseVehicleType.Click += new System.EventHandler(this.buttonChooseVehicleType_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBoxVehicleList
            // 
            this.comboBoxVehicleList.BackColor = System.Drawing.Color.Gray;
            this.comboBoxVehicleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVehicleList.FormattingEnabled = true;
            this.comboBoxVehicleList.Location = new System.Drawing.Point(360, 33);
            this.comboBoxVehicleList.MaximumSize = new System.Drawing.Size(350, 0);
            this.comboBoxVehicleList.MinimumSize = new System.Drawing.Size(350, 0);
            this.comboBoxVehicleList.Name = "comboBoxVehicleList";
            this.comboBoxVehicleList.Size = new System.Drawing.Size(350, 29);
            this.comboBoxVehicleList.TabIndex = 3;
            this.comboBoxVehicleList.Visible = false;
            // 
            // staticLabelChooseVehicle
            // 
            this.staticLabelChooseVehicle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticLabelChooseVehicle.Location = new System.Drawing.Point(360, 4);
            this.staticLabelChooseVehicle.Name = "staticLabelChooseVehicle";
            this.staticLabelChooseVehicle.Size = new System.Drawing.Size(350, 29);
            this.staticLabelChooseVehicle.TabIndex = 4;
            this.staticLabelChooseVehicle.Text = "Choose a Vehicle:";
            this.staticLabelChooseVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.staticLabelChooseVehicle.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(360, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 283);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // CraftingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 1100);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.staticLabelChooseVehicle);
            this.Controls.Add(this.comboBoxVehicleList);
            this.Controls.Add(this.panelVehicleType);
            this.Controls.Add(this.panelChoooseCar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CraftingMenu";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Arma 3 Project Life - Crafting Menu";
            this.Load += new System.EventHandler(this.CraftingMenu_Load);
            this.panelVehicleType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelChoooseCar;
        private System.Windows.Forms.Button buttonVehicleTypeCar;
        private System.Windows.Forms.Button buttonChooseVehicleType;
        private System.Windows.Forms.Panel panelVehicleType;
        private System.Windows.Forms.Button buttonVehicleTypeTrailer;
        private System.Windows.Forms.Button buttonVehicleTypeTruck;
        private System.Windows.Forms.Button buttonVehicleTypeSUV;
        private System.Windows.Forms.Button buttonVehicleTypeOther;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBoxVehicleList;
        private System.Windows.Forms.Label staticLabelChooseVehicle;
        private System.Windows.Forms.Label label1;
    }
}