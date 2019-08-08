namespace samlight_client_csharp
{
    partial class settings_frm
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
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.BUTTON_GET_HOME_POS = new System.Windows.Forms.Button();
            this.BUTTON_SET_HOME_POS = new System.Windows.Forms.Button();
            this.EDIT_HOME_POS_Y = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.EDIT_HOME_POS_Z = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.EDIT_HOME_POS_X = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_change_path = new System.Windows.Forms.Button();
            this.EDIT_FILE_PATH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BUTTON_CHANGE_FILE_PATH = new System.Windows.Forms.Button();
            this.BUTTON_GET_FILE_PATH = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.BUTTON_GET_HOME_POS);
            this.groupBox9.Controls.Add(this.BUTTON_SET_HOME_POS);
            this.groupBox9.Controls.Add(this.EDIT_HOME_POS_Y);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.EDIT_HOME_POS_Z);
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Controls.Add(this.EDIT_HOME_POS_X);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Location = new System.Drawing.Point(29, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(607, 82);
            this.groupBox9.TabIndex = 22;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Home Position";
            // 
            // BUTTON_GET_HOME_POS
            // 
            this.BUTTON_GET_HOME_POS.Location = new System.Drawing.Point(289, 15);
            this.BUTTON_GET_HOME_POS.Name = "BUTTON_GET_HOME_POS";
            this.BUTTON_GET_HOME_POS.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_GET_HOME_POS.TabIndex = 24;
            this.BUTTON_GET_HOME_POS.Text = "Get";
            this.BUTTON_GET_HOME_POS.UseVisualStyleBackColor = true;
            this.BUTTON_GET_HOME_POS.Click += new System.EventHandler(this.BUTTON_GET_HOME_POS_Click);
            // 
            // BUTTON_SET_HOME_POS
            // 
            this.BUTTON_SET_HOME_POS.Location = new System.Drawing.Point(289, 44);
            this.BUTTON_SET_HOME_POS.Name = "BUTTON_SET_HOME_POS";
            this.BUTTON_SET_HOME_POS.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_SET_HOME_POS.TabIndex = 23;
            this.BUTTON_SET_HOME_POS.Text = "Set";
            this.BUTTON_SET_HOME_POS.UseVisualStyleBackColor = true;
            this.BUTTON_SET_HOME_POS.Click += new System.EventHandler(this.BUTTON_SET_HOME_POS_Click);
            // 
            // EDIT_HOME_POS_Y
            // 
            this.EDIT_HOME_POS_Y.Location = new System.Drawing.Point(123, 28);
            this.EDIT_HOME_POS_Y.Name = "EDIT_HOME_POS_Y";
            this.EDIT_HOME_POS_Y.Size = new System.Drawing.Size(52, 20);
            this.EDIT_HOME_POS_Y.TabIndex = 20;
            this.EDIT_HOME_POS_Y.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(100, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Y:";
            // 
            // EDIT_HOME_POS_Z
            // 
            this.EDIT_HOME_POS_Z.Location = new System.Drawing.Point(223, 28);
            this.EDIT_HOME_POS_Z.Name = "EDIT_HOME_POS_Z";
            this.EDIT_HOME_POS_Z.Size = new System.Drawing.Size(52, 20);
            this.EDIT_HOME_POS_Z.TabIndex = 18;
            this.EDIT_HOME_POS_Z.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(200, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Z:";
            // 
            // EDIT_HOME_POS_X
            // 
            this.EDIT_HOME_POS_X.Location = new System.Drawing.Point(28, 28);
            this.EDIT_HOME_POS_X.Name = "EDIT_HOME_POS_X";
            this.EDIT_HOME_POS_X.Size = new System.Drawing.Size(52, 20);
            this.EDIT_HOME_POS_X.TabIndex = 14;
            this.EDIT_HOME_POS_X.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "X:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_change_path);
            this.groupBox2.Controls.Add(this.EDIT_FILE_PATH);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(29, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 147);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Correction Table";
            // 
            // button_change_path
            // 
            this.button_change_path.Location = new System.Drawing.Point(482, 31);
            this.button_change_path.Name = "button_change_path";
            this.button_change_path.Size = new System.Drawing.Size(83, 26);
            this.button_change_path.TabIndex = 15;
            this.button_change_path.Text = "Change Path";
            this.button_change_path.UseVisualStyleBackColor = true;
            this.button_change_path.Click += new System.EventHandler(this.button_change_path_Click);
            // 
            // EDIT_FILE_PATH
            // 
            this.EDIT_FILE_PATH.Location = new System.Drawing.Point(87, 35);
            this.EDIT_FILE_PATH.Name = "EDIT_FILE_PATH";
            this.EDIT_FILE_PATH.Size = new System.Drawing.Size(373, 20);
            this.EDIT_FILE_PATH.TabIndex = 14;
            this.EDIT_FILE_PATH.Text = "D:\\corr_table\\Correction files\\cor_neutral.ucf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "File Path:";
            // 
            // BUTTON_CHANGE_FILE_PATH
            // 
            this.BUTTON_CHANGE_FILE_PATH.Location = new System.Drawing.Point(549, 236);
            this.BUTTON_CHANGE_FILE_PATH.Name = "BUTTON_CHANGE_FILE_PATH";
            this.BUTTON_CHANGE_FILE_PATH.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_FILE_PATH.TabIndex = 15;
            this.BUTTON_CHANGE_FILE_PATH.Text = "Set";
            this.BUTTON_CHANGE_FILE_PATH.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_FILE_PATH.Click += new System.EventHandler(this.BUTTON_CHANGE_FILE_PATH_Click);
            // 
            // BUTTON_GET_FILE_PATH
            // 
            this.BUTTON_GET_FILE_PATH.Location = new System.Drawing.Point(549, 207);
            this.BUTTON_GET_FILE_PATH.Name = "BUTTON_GET_FILE_PATH";
            this.BUTTON_GET_FILE_PATH.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_GET_FILE_PATH.TabIndex = 25;
            this.BUTTON_GET_FILE_PATH.Text = "Get";
            this.BUTTON_GET_FILE_PATH.UseVisualStyleBackColor = true;
            this.BUTTON_GET_FILE_PATH.Click += new System.EventHandler(this.BUTTON_GET_FILE_PATH_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // settings_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 282);
            this.Controls.Add(this.BUTTON_GET_FILE_PATH);
            this.Controls.Add(this.BUTTON_CHANGE_FILE_PATH);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox9);
            this.Name = "settings_frm";
            this.Text = "Settings";
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button BUTTON_GET_HOME_POS;
        private System.Windows.Forms.Button BUTTON_SET_HOME_POS;
        private System.Windows.Forms.TextBox EDIT_HOME_POS_Y;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox EDIT_HOME_POS_Z;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox EDIT_HOME_POS_X;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox EDIT_FILE_PATH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BUTTON_CHANGE_FILE_PATH;
        private System.Windows.Forms.Button BUTTON_GET_FILE_PATH;
        private System.Windows.Forms.Button button_change_path;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}