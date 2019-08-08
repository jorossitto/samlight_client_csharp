namespace samlight_client_csharp
{
    partial class screen_shots_frm
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
            this.label6 = new System.Windows.Forms.Label();
            this.COMBO_SIZE = new System.Windows.Forms.ComboBox();
            this.BUTTON_SAVE_SCREEN_SHOT = new System.Windows.Forms.Button();
            this.BUTTON_CHANGE_VARIABLE_SIZE = new System.Windows.Forms.Button();
            this.EDIT_VARIABLE_SIZE = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.EDIT_FILE_NAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_line_size = new System.Windows.Forms.ComboBox();
            this.EDIT_FILE_NAME_DPI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BUTTON_SAVE_SCREEN_SHOTS_DPI = new System.Windows.Forms.Button();
            this.textBox_size_dpi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_set_dpi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Size:";
            // 
            // COMBO_SIZE
            // 
            this.COMBO_SIZE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_SIZE.FormattingEnabled = true;
            this.COMBO_SIZE.Location = new System.Drawing.Point(68, 47);
            this.COMBO_SIZE.Name = "COMBO_SIZE";
            this.COMBO_SIZE.Size = new System.Drawing.Size(96, 21);
            this.COMBO_SIZE.TabIndex = 41;
            this.COMBO_SIZE.SelectedIndexChanged += new System.EventHandler(this.COMBO_SIZE_SelectedIndexChanged);
            // 
            // BUTTON_SAVE_SCREEN_SHOT
            // 
            this.BUTTON_SAVE_SCREEN_SHOT.Location = new System.Drawing.Point(107, 130);
            this.BUTTON_SAVE_SCREEN_SHOT.Name = "BUTTON_SAVE_SCREEN_SHOT";
            this.BUTTON_SAVE_SCREEN_SHOT.Size = new System.Drawing.Size(118, 23);
            this.BUTTON_SAVE_SCREEN_SHOT.TabIndex = 47;
            this.BUTTON_SAVE_SCREEN_SHOT.Text = "Save Screen shot";
            this.BUTTON_SAVE_SCREEN_SHOT.UseVisualStyleBackColor = true;
            this.BUTTON_SAVE_SCREEN_SHOT.Click += new System.EventHandler(this.BUTTON_SAVE_SCREEN_SHOT_Click);
            // 
            // BUTTON_CHANGE_VARIABLE_SIZE
            // 
            this.BUTTON_CHANGE_VARIABLE_SIZE.Location = new System.Drawing.Point(364, 42);
            this.BUTTON_CHANGE_VARIABLE_SIZE.Name = "BUTTON_CHANGE_VARIABLE_SIZE";
            this.BUTTON_CHANGE_VARIABLE_SIZE.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_VARIABLE_SIZE.TabIndex = 46;
            this.BUTTON_CHANGE_VARIABLE_SIZE.Text = "Set";
            this.BUTTON_CHANGE_VARIABLE_SIZE.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_VARIABLE_SIZE.Click += new System.EventHandler(this.BUTTON_CHANGE_VARIABLE_SIZE_Click);
            // 
            // EDIT_VARIABLE_SIZE
            // 
            this.EDIT_VARIABLE_SIZE.Location = new System.Drawing.Point(288, 44);
            this.EDIT_VARIABLE_SIZE.Name = "EDIT_VARIABLE_SIZE";
            this.EDIT_VARIABLE_SIZE.Size = new System.Drawing.Size(70, 20);
            this.EDIT_VARIABLE_SIZE.TabIndex = 44;
            this.EDIT_VARIABLE_SIZE.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(199, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "Variable Size:";
            // 
            // EDIT_FILE_NAME
            // 
            this.EDIT_FILE_NAME.Location = new System.Drawing.Point(107, 95);
            this.EDIT_FILE_NAME.Name = "EDIT_FILE_NAME";
            this.EDIT_FILE_NAME.Size = new System.Drawing.Size(517, 20);
            this.EDIT_FILE_NAME.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "File Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EDIT_FILE_NAME);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BUTTON_SAVE_SCREEN_SHOT);
            this.groupBox1.Controls.Add(this.BUTTON_CHANGE_VARIABLE_SIZE);
            this.groupBox1.Controls.Add(this.EDIT_VARIABLE_SIZE);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.COMBO_SIZE);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 200);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VariableSize";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_set_dpi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox_line_size);
            this.groupBox2.Controls.Add(this.EDIT_FILE_NAME_DPI);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BUTTON_SAVE_SCREEN_SHOTS_DPI);
            this.groupBox2.Controls.Add(this.textBox_size_dpi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(15, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 185);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AdjustableDPI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Lines Size:";
            // 
            // comboBox_line_size
            // 
            this.comboBox_line_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_line_size.FormattingEnabled = true;
            this.comboBox_line_size.Location = new System.Drawing.Point(68, 42);
            this.comboBox_line_size.Name = "comboBox_line_size";
            this.comboBox_line_size.Size = new System.Drawing.Size(96, 21);
            this.comboBox_line_size.TabIndex = 50;
            this.comboBox_line_size.SelectedIndexChanged += new System.EventHandler(this.comboBox_line_size_SelectedIndexChanged);
            // 
            // EDIT_FILE_NAME_DPI
            // 
            this.EDIT_FILE_NAME_DPI.Location = new System.Drawing.Point(107, 90);
            this.EDIT_FILE_NAME_DPI.Name = "EDIT_FILE_NAME_DPI";
            this.EDIT_FILE_NAME_DPI.Size = new System.Drawing.Size(517, 20);
            this.EDIT_FILE_NAME_DPI.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "File Name:";
            // 
            // BUTTON_SAVE_SCREEN_SHOTS_DPI
            // 
            this.BUTTON_SAVE_SCREEN_SHOTS_DPI.Location = new System.Drawing.Point(107, 125);
            this.BUTTON_SAVE_SCREEN_SHOTS_DPI.Name = "BUTTON_SAVE_SCREEN_SHOTS_DPI";
            this.BUTTON_SAVE_SCREEN_SHOTS_DPI.Size = new System.Drawing.Size(118, 23);
            this.BUTTON_SAVE_SCREEN_SHOTS_DPI.TabIndex = 47;
            this.BUTTON_SAVE_SCREEN_SHOTS_DPI.Text = "Save Screen shot";
            this.BUTTON_SAVE_SCREEN_SHOTS_DPI.UseVisualStyleBackColor = true;
            this.BUTTON_SAVE_SCREEN_SHOTS_DPI.Click += new System.EventHandler(this.BUTTON_SAVE_SCREEN_SHOTS_DPI_Click);
            // 
            // textBox_size_dpi
            // 
            this.textBox_size_dpi.Location = new System.Drawing.Point(288, 39);
            this.textBox_size_dpi.Name = "textBox_size_dpi";
            this.textBox_size_dpi.Size = new System.Drawing.Size(70, 20);
            this.textBox_size_dpi.TabIndex = 44;
            this.textBox_size_dpi.Text = "200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "DPI:";
            // 
            // button_set_dpi
            // 
            this.button_set_dpi.Location = new System.Drawing.Point(364, 39);
            this.button_set_dpi.Name = "button_set_dpi";
            this.button_set_dpi.Size = new System.Drawing.Size(59, 23);
            this.button_set_dpi.TabIndex = 52;
            this.button_set_dpi.Text = "Set";
            this.button_set_dpi.UseVisualStyleBackColor = true;
            this.button_set_dpi.Click += new System.EventHandler(this.button_set_dpi_Click);
            // 
            // screen_shots_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 449);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "screen_shots_frm";
            this.Text = "ScreenShots";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox COMBO_SIZE;
        private System.Windows.Forms.Button BUTTON_SAVE_SCREEN_SHOT;
        private System.Windows.Forms.Button BUTTON_CHANGE_VARIABLE_SIZE;
        private System.Windows.Forms.TextBox EDIT_VARIABLE_SIZE;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox EDIT_FILE_NAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox EDIT_FILE_NAME_DPI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BUTTON_SAVE_SCREEN_SHOTS_DPI;
        private System.Windows.Forms.TextBox textBox_size_dpi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_line_size;
        private System.Windows.Forms.Button button_set_dpi;
    }
}