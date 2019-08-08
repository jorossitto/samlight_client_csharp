namespace samlight_client_csharp
{
    partial class motion_frm
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
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.BUTTON_MOVE_ABSOLUTE = new System.Windows.Forms.Button();
            this.EDIT_SPEED = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.BUTTON_MOVE_RELATIVE = new System.Windows.Forms.Button();
            this.EDIT_DISTANCE = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.BUTTON_HOME = new System.Windows.Forms.Button();
            this.BUTTON_STOP = new System.Windows.Forms.Button();
            this.EDIT_AXIS = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.BUTTON_MOVE_ABSOLUTE);
            this.groupBox13.Controls.Add(this.EDIT_SPEED);
            this.groupBox13.Controls.Add(this.label22);
            this.groupBox13.Controls.Add(this.BUTTON_MOVE_RELATIVE);
            this.groupBox13.Controls.Add(this.EDIT_DISTANCE);
            this.groupBox13.Controls.Add(this.label21);
            this.groupBox13.Controls.Add(this.BUTTON_HOME);
            this.groupBox13.Controls.Add(this.BUTTON_STOP);
            this.groupBox13.Controls.Add(this.EDIT_AXIS);
            this.groupBox13.Controls.Add(this.label20);
            this.groupBox13.Location = new System.Drawing.Point(31, 29);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(381, 239);
            this.groupBox13.TabIndex = 34;
            this.groupBox13.TabStop = false;
            // 
            // BUTTON_MOVE_ABSOLUTE
            // 
            this.BUTTON_MOVE_ABSOLUTE.Location = new System.Drawing.Point(240, 124);
            this.BUTTON_MOVE_ABSOLUTE.Name = "BUTTON_MOVE_ABSOLUTE";
            this.BUTTON_MOVE_ABSOLUTE.Size = new System.Drawing.Size(100, 23);
            this.BUTTON_MOVE_ABSOLUTE.TabIndex = 24;
            this.BUTTON_MOVE_ABSOLUTE.Text = "Move Absolute";
            this.BUTTON_MOVE_ABSOLUTE.UseVisualStyleBackColor = true;
            this.BUTTON_MOVE_ABSOLUTE.Click += new System.EventHandler(this.BUTTON_MOVE_ABSOLUTE_Click);
            // 
            // EDIT_SPEED
            // 
            this.EDIT_SPEED.Location = new System.Drawing.Point(115, 146);
            this.EDIT_SPEED.Name = "EDIT_SPEED";
            this.EDIT_SPEED.Size = new System.Drawing.Size(85, 20);
            this.EDIT_SPEED.TabIndex = 22;
            this.EDIT_SPEED.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(39, 152);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "Speed:";
            // 
            // BUTTON_MOVE_RELATIVE
            // 
            this.BUTTON_MOVE_RELATIVE.Location = new System.Drawing.Point(240, 95);
            this.BUTTON_MOVE_RELATIVE.Name = "BUTTON_MOVE_RELATIVE";
            this.BUTTON_MOVE_RELATIVE.Size = new System.Drawing.Size(100, 23);
            this.BUTTON_MOVE_RELATIVE.TabIndex = 20;
            this.BUTTON_MOVE_RELATIVE.Text = "Move Relative";
            this.BUTTON_MOVE_RELATIVE.UseVisualStyleBackColor = true;
            this.BUTTON_MOVE_RELATIVE.Click += new System.EventHandler(this.BUTTON_MOVE_RELATIVE_Click);
            // 
            // EDIT_DISTANCE
            // 
            this.EDIT_DISTANCE.Location = new System.Drawing.Point(115, 112);
            this.EDIT_DISTANCE.Name = "EDIT_DISTANCE";
            this.EDIT_DISTANCE.Size = new System.Drawing.Size(85, 20);
            this.EDIT_DISTANCE.TabIndex = 18;
            this.EDIT_DISTANCE.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(39, 118);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Distance:";
            // 
            // BUTTON_HOME
            // 
            this.BUTTON_HOME.Location = new System.Drawing.Point(115, 31);
            this.BUTTON_HOME.Name = "BUTTON_HOME";
            this.BUTTON_HOME.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_HOME.TabIndex = 16;
            this.BUTTON_HOME.Text = "Home";
            this.BUTTON_HOME.UseVisualStyleBackColor = true;
            this.BUTTON_HOME.Click += new System.EventHandler(this.BUTTON_HOME_Click);
            // 
            // BUTTON_STOP
            // 
            this.BUTTON_STOP.Location = new System.Drawing.Point(115, 185);
            this.BUTTON_STOP.Name = "BUTTON_STOP";
            this.BUTTON_STOP.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_STOP.TabIndex = 15;
            this.BUTTON_STOP.Text = "Stop";
            this.BUTTON_STOP.UseVisualStyleBackColor = true;
            this.BUTTON_STOP.Click += new System.EventHandler(this.BUTTON_STOP_Click);
            // 
            // EDIT_AXIS
            // 
            this.EDIT_AXIS.Location = new System.Drawing.Point(115, 78);
            this.EDIT_AXIS.Name = "EDIT_AXIS";
            this.EDIT_AXIS.Size = new System.Drawing.Size(85, 20);
            this.EDIT_AXIS.TabIndex = 14;
            this.EDIT_AXIS.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(39, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Axis:";
            // 
            // motion_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 307);
            this.Controls.Add(this.groupBox13);
            this.Name = "motion_frm";
            this.Text = "Motion";
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button BUTTON_MOVE_ABSOLUTE;
        private System.Windows.Forms.TextBox EDIT_SPEED;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button BUTTON_MOVE_RELATIVE;
        private System.Windows.Forms.TextBox EDIT_DISTANCE;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button BUTTON_HOME;
        private System.Windows.Forms.Button BUTTON_STOP;
        private System.Windows.Forms.TextBox EDIT_AXIS;
        private System.Windows.Forms.Label label20;
    }
}