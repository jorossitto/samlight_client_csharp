namespace samlight_client_csharp
{
    partial class pens_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EDIT_LASER_SPEED = new System.Windows.Forms.TextBox();
            this.BUTTON_GET_LASER_SPEED = new System.Windows.Forms.Button();
            this.BUTTON_CHANGE_LASER_SPEED = new System.Windows.Forms.Button();
            this.BUTTON_GET_LASER_POWER = new System.Windows.Forms.Button();
            this.BUTTON_CHANGE_LASER_POWER = new System.Windows.Forms.Button();
            this.EDIT_LASER_POWER = new System.Windows.Forms.TextBox();
            this.COMBO_PEN = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EDIT_OVERRIDE_POWER = new System.Windows.Forms.TextBox();
            this.BUTTON_CHANGE_OVERRIDE_POWER = new System.Windows.Forms.Button();
            this.BUTTON_GET_OVERRIDE_POWER = new System.Windows.Forms.Button();
            this.BUTTON_CHANGE_OVERRIDE_SPEED = new System.Windows.Forms.Button();
            this.BUTTON_GET_OVERRIDE_SPEED = new System.Windows.Forms.Button();
            this.EDIT_OVERRIDE_SPEED = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BUTTON_CHANGE_OVERRIDE_FREQ = new System.Windows.Forms.Button();
            this.BUTTON_GET_OVERRIDE_FREQ = new System.Windows.Forms.Button();
            this.EDIT_OVERRIDE_FREQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox14.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label2);
            this.groupBox14.Controls.Add(this.label1);
            this.groupBox14.Controls.Add(this.EDIT_LASER_SPEED);
            this.groupBox14.Controls.Add(this.BUTTON_GET_LASER_SPEED);
            this.groupBox14.Controls.Add(this.BUTTON_CHANGE_LASER_SPEED);
            this.groupBox14.Controls.Add(this.BUTTON_GET_LASER_POWER);
            this.groupBox14.Controls.Add(this.BUTTON_CHANGE_LASER_POWER);
            this.groupBox14.Controls.Add(this.EDIT_LASER_POWER);
            this.groupBox14.Location = new System.Drawing.Point(27, 109);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(356, 132);
            this.groupBox14.TabIndex = 36;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Laser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Speed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Power:";
            // 
            // EDIT_LASER_SPEED
            // 
            this.EDIT_LASER_SPEED.Location = new System.Drawing.Point(97, 78);
            this.EDIT_LASER_SPEED.Name = "EDIT_LASER_SPEED";
            this.EDIT_LASER_SPEED.Size = new System.Drawing.Size(85, 20);
            this.EDIT_LASER_SPEED.TabIndex = 29;
            this.EDIT_LASER_SPEED.Text = "0";
            // 
            // BUTTON_GET_LASER_SPEED
            // 
            this.BUTTON_GET_LASER_SPEED.Location = new System.Drawing.Point(205, 74);
            this.BUTTON_GET_LASER_SPEED.Name = "BUTTON_GET_LASER_SPEED";
            this.BUTTON_GET_LASER_SPEED.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_GET_LASER_SPEED.TabIndex = 30;
            this.BUTTON_GET_LASER_SPEED.Text = "Get";
            this.BUTTON_GET_LASER_SPEED.UseVisualStyleBackColor = true;
            this.BUTTON_GET_LASER_SPEED.Click += new System.EventHandler(this.BUTTON_GET_LASER_SPEED_Click);
            // 
            // BUTTON_CHANGE_LASER_SPEED
            // 
            this.BUTTON_CHANGE_LASER_SPEED.Location = new System.Drawing.Point(270, 75);
            this.BUTTON_CHANGE_LASER_SPEED.Name = "BUTTON_CHANGE_LASER_SPEED";
            this.BUTTON_CHANGE_LASER_SPEED.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_LASER_SPEED.TabIndex = 31;
            this.BUTTON_CHANGE_LASER_SPEED.Text = "Set";
            this.BUTTON_CHANGE_LASER_SPEED.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_LASER_SPEED.Click += new System.EventHandler(this.BUTTON_CHANGE_LASER_SPEED_Click);
            // 
            // BUTTON_GET_LASER_POWER
            // 
            this.BUTTON_GET_LASER_POWER.Location = new System.Drawing.Point(204, 40);
            this.BUTTON_GET_LASER_POWER.Name = "BUTTON_GET_LASER_POWER";
            this.BUTTON_GET_LASER_POWER.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_GET_LASER_POWER.TabIndex = 16;
            this.BUTTON_GET_LASER_POWER.Text = "Get";
            this.BUTTON_GET_LASER_POWER.UseVisualStyleBackColor = true;
            this.BUTTON_GET_LASER_POWER.Click += new System.EventHandler(this.BUTTON_GET_LASER_POWER_Click);
            // 
            // BUTTON_CHANGE_LASER_POWER
            // 
            this.BUTTON_CHANGE_LASER_POWER.Location = new System.Drawing.Point(269, 40);
            this.BUTTON_CHANGE_LASER_POWER.Name = "BUTTON_CHANGE_LASER_POWER";
            this.BUTTON_CHANGE_LASER_POWER.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_LASER_POWER.TabIndex = 15;
            this.BUTTON_CHANGE_LASER_POWER.Text = "Set";
            this.BUTTON_CHANGE_LASER_POWER.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_LASER_POWER.Click += new System.EventHandler(this.BUTTON_CHANGE_LASER_POWER_Click);
            // 
            // EDIT_LASER_POWER
            // 
            this.EDIT_LASER_POWER.Location = new System.Drawing.Point(97, 42);
            this.EDIT_LASER_POWER.Name = "EDIT_LASER_POWER";
            this.EDIT_LASER_POWER.Size = new System.Drawing.Size(85, 20);
            this.EDIT_LASER_POWER.TabIndex = 14;
            this.EDIT_LASER_POWER.Text = "0";
            // 
            // COMBO_PEN
            // 
            this.COMBO_PEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_PEN.FormattingEnabled = true;
            this.COMBO_PEN.Location = new System.Drawing.Point(170, 54);
            this.COMBO_PEN.Name = "COMBO_PEN";
            this.COMBO_PEN.Size = new System.Drawing.Size(96, 21);
            this.COMBO_PEN.TabIndex = 39;
            this.COMBO_PEN.SelectedIndexChanged += new System.EventHandler(this.COMBO_PEN_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Pen:";
            // 
            // EDIT_OVERRIDE_POWER
            // 
            this.EDIT_OVERRIDE_POWER.Location = new System.Drawing.Point(90, 42);
            this.EDIT_OVERRIDE_POWER.Name = "EDIT_OVERRIDE_POWER";
            this.EDIT_OVERRIDE_POWER.Size = new System.Drawing.Size(85, 20);
            this.EDIT_OVERRIDE_POWER.TabIndex = 14;
            this.EDIT_OVERRIDE_POWER.Text = "0";
            // 
            // BUTTON_CHANGE_OVERRIDE_POWER
            // 
            this.BUTTON_CHANGE_OVERRIDE_POWER.Location = new System.Drawing.Point(263, 47);
            this.BUTTON_CHANGE_OVERRIDE_POWER.Name = "BUTTON_CHANGE_OVERRIDE_POWER";
            this.BUTTON_CHANGE_OVERRIDE_POWER.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_OVERRIDE_POWER.TabIndex = 15;
            this.BUTTON_CHANGE_OVERRIDE_POWER.Text = "Set";
            this.BUTTON_CHANGE_OVERRIDE_POWER.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_OVERRIDE_POWER.Click += new System.EventHandler(this.BUTTON_CHANGE_OVERRIDE_POWER_Click);
            // 
            // BUTTON_GET_OVERRIDE_POWER
            // 
            this.BUTTON_GET_OVERRIDE_POWER.Location = new System.Drawing.Point(198, 47);
            this.BUTTON_GET_OVERRIDE_POWER.Name = "BUTTON_GET_OVERRIDE_POWER";
            this.BUTTON_GET_OVERRIDE_POWER.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_GET_OVERRIDE_POWER.TabIndex = 16;
            this.BUTTON_GET_OVERRIDE_POWER.Text = "Get";
            this.BUTTON_GET_OVERRIDE_POWER.UseVisualStyleBackColor = true;
            this.BUTTON_GET_OVERRIDE_POWER.Click += new System.EventHandler(this.BUTTON_GET_OVERRIDE_POWER_Click);
            // 
            // BUTTON_CHANGE_OVERRIDE_SPEED
            // 
            this.BUTTON_CHANGE_OVERRIDE_SPEED.Location = new System.Drawing.Point(264, 82);
            this.BUTTON_CHANGE_OVERRIDE_SPEED.Name = "BUTTON_CHANGE_OVERRIDE_SPEED";
            this.BUTTON_CHANGE_OVERRIDE_SPEED.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_OVERRIDE_SPEED.TabIndex = 31;
            this.BUTTON_CHANGE_OVERRIDE_SPEED.Text = "Set";
            this.BUTTON_CHANGE_OVERRIDE_SPEED.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_OVERRIDE_SPEED.Click += new System.EventHandler(this.BUTTON_CHANGE_OVERRIDE_SPEED_Click);
            // 
            // BUTTON_GET_OVERRIDE_SPEED
            // 
            this.BUTTON_GET_OVERRIDE_SPEED.Location = new System.Drawing.Point(199, 81);
            this.BUTTON_GET_OVERRIDE_SPEED.Name = "BUTTON_GET_OVERRIDE_SPEED";
            this.BUTTON_GET_OVERRIDE_SPEED.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_GET_OVERRIDE_SPEED.TabIndex = 30;
            this.BUTTON_GET_OVERRIDE_SPEED.Text = "Get";
            this.BUTTON_GET_OVERRIDE_SPEED.UseVisualStyleBackColor = true;
            this.BUTTON_GET_OVERRIDE_SPEED.Click += new System.EventHandler(this.BUTTON_GET_OVERRIDE_SPEED_Click);
            // 
            // EDIT_OVERRIDE_SPEED
            // 
            this.EDIT_OVERRIDE_SPEED.Location = new System.Drawing.Point(90, 78);
            this.EDIT_OVERRIDE_SPEED.Name = "EDIT_OVERRIDE_SPEED";
            this.EDIT_OVERRIDE_SPEED.Size = new System.Drawing.Size(85, 20);
            this.EDIT_OVERRIDE_SPEED.TabIndex = 29;
            this.EDIT_OVERRIDE_SPEED.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Power:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Speed:";
            // 
            // BUTTON_CHANGE_OVERRIDE_FREQ
            // 
            this.BUTTON_CHANGE_OVERRIDE_FREQ.Location = new System.Drawing.Point(264, 120);
            this.BUTTON_CHANGE_OVERRIDE_FREQ.Name = "BUTTON_CHANGE_OVERRIDE_FREQ";
            this.BUTTON_CHANGE_OVERRIDE_FREQ.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_OVERRIDE_FREQ.TabIndex = 37;
            this.BUTTON_CHANGE_OVERRIDE_FREQ.Text = "Set";
            this.BUTTON_CHANGE_OVERRIDE_FREQ.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_OVERRIDE_FREQ.Click += new System.EventHandler(this.BUTTON_CHANGE_OVERRIDE_FREQ_Click);
            // 
            // BUTTON_GET_OVERRIDE_FREQ
            // 
            this.BUTTON_GET_OVERRIDE_FREQ.Location = new System.Drawing.Point(199, 119);
            this.BUTTON_GET_OVERRIDE_FREQ.Name = "BUTTON_GET_OVERRIDE_FREQ";
            this.BUTTON_GET_OVERRIDE_FREQ.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_GET_OVERRIDE_FREQ.TabIndex = 36;
            this.BUTTON_GET_OVERRIDE_FREQ.Text = "Get";
            this.BUTTON_GET_OVERRIDE_FREQ.UseVisualStyleBackColor = true;
            this.BUTTON_GET_OVERRIDE_FREQ.Click += new System.EventHandler(this.BUTTON_GET_OVERRIDE_FREQ_Click);
            // 
            // EDIT_OVERRIDE_FREQ
            // 
            this.EDIT_OVERRIDE_FREQ.Location = new System.Drawing.Point(90, 116);
            this.EDIT_OVERRIDE_FREQ.Name = "EDIT_OVERRIDE_FREQ";
            this.EDIT_OVERRIDE_FREQ.Size = new System.Drawing.Size(85, 20);
            this.EDIT_OVERRIDE_FREQ.TabIndex = 35;
            this.EDIT_OVERRIDE_FREQ.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Freq:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.EDIT_OVERRIDE_FREQ);
            this.groupBox1.Controls.Add(this.BUTTON_GET_OVERRIDE_FREQ);
            this.groupBox1.Controls.Add(this.BUTTON_CHANGE_OVERRIDE_FREQ);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.EDIT_OVERRIDE_SPEED);
            this.groupBox1.Controls.Add(this.BUTTON_GET_OVERRIDE_SPEED);
            this.groupBox1.Controls.Add(this.BUTTON_CHANGE_OVERRIDE_SPEED);
            this.groupBox1.Controls.Add(this.BUTTON_GET_OVERRIDE_POWER);
            this.groupBox1.Controls.Add(this.BUTTON_CHANGE_OVERRIDE_POWER);
            this.groupBox1.Controls.Add(this.EDIT_OVERRIDE_POWER);
            this.groupBox1.Location = new System.Drawing.Point(34, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 168);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Override [%]";
            // 
            // pens_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 500);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.COMBO_PEN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox14);
            this.Name = "pens_frm";
            this.Text = "Pens";
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EDIT_LASER_SPEED;
        private System.Windows.Forms.Button BUTTON_GET_LASER_SPEED;
        private System.Windows.Forms.Button BUTTON_CHANGE_LASER_SPEED;
        private System.Windows.Forms.Button BUTTON_GET_LASER_POWER;
        private System.Windows.Forms.Button BUTTON_CHANGE_LASER_POWER;
        private System.Windows.Forms.TextBox EDIT_LASER_POWER;
        private System.Windows.Forms.ComboBox COMBO_PEN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EDIT_OVERRIDE_POWER;
        private System.Windows.Forms.Button BUTTON_CHANGE_OVERRIDE_POWER;
        private System.Windows.Forms.Button BUTTON_GET_OVERRIDE_POWER;
        private System.Windows.Forms.Button BUTTON_CHANGE_OVERRIDE_SPEED;
        private System.Windows.Forms.Button BUTTON_GET_OVERRIDE_SPEED;
        private System.Windows.Forms.TextBox EDIT_OVERRIDE_SPEED;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BUTTON_CHANGE_OVERRIDE_FREQ;
        private System.Windows.Forms.Button BUTTON_GET_OVERRIDE_FREQ;
        private System.Windows.Forms.TextBox EDIT_OVERRIDE_FREQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}