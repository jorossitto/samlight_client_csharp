namespace samlight_client_csharp
{
    partial class bitmap_frm
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
            this.BUTTON_GET_BITMAP_DITHERSTEP = new System.Windows.Forms.Button();
            this.BUTTON_CHANGE_BITMAP_DITHERSTEP = new System.Windows.Forms.Button();
            this.EDIT_BITMAP_DITHERSTEP = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.BUTTON_GET_BITMAP_BRIGHTNESS = new System.Windows.Forms.Button();
            this.BUTTON_CHANGE_BITMAP_BRIGHTNESS = new System.Windows.Forms.Button();
            this.EDIT_BITMAP_BRIGHTNESS = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.BUTTON_GET_BITMAP_INTENSITY = new System.Windows.Forms.Button();
            this.BUTTON_CHANGE_BITMAP_INTENSITY = new System.Windows.Forms.Button();
            this.EDIT_BITMAP_INTENSITY = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.EDIT_ENTITY_NAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BUTTON_REIMPORT = new System.Windows.Forms.Button();
            this.EDIT_FILE_NAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CHECK_SCANNER_BITMAP_AND_BIDIRECTIONAL = new System.Windows.Forms.CheckBox();
            this.button_change_path = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.BUTTON_GET_BITMAP_DITHERSTEP);
            this.groupBox13.Controls.Add(this.BUTTON_CHANGE_BITMAP_DITHERSTEP);
            this.groupBox13.Controls.Add(this.EDIT_BITMAP_DITHERSTEP);
            this.groupBox13.Controls.Add(this.label22);
            this.groupBox13.Controls.Add(this.BUTTON_GET_BITMAP_BRIGHTNESS);
            this.groupBox13.Controls.Add(this.BUTTON_CHANGE_BITMAP_BRIGHTNESS);
            this.groupBox13.Controls.Add(this.EDIT_BITMAP_BRIGHTNESS);
            this.groupBox13.Controls.Add(this.label21);
            this.groupBox13.Controls.Add(this.BUTTON_GET_BITMAP_INTENSITY);
            this.groupBox13.Controls.Add(this.BUTTON_CHANGE_BITMAP_INTENSITY);
            this.groupBox13.Controls.Add(this.EDIT_BITMAP_INTENSITY);
            this.groupBox13.Controls.Add(this.label20);
            this.groupBox13.Location = new System.Drawing.Point(35, 89);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(381, 151);
            this.groupBox13.TabIndex = 33;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "ScChangeBitmapByName";
            // 
            // BUTTON_GET_BITMAP_DITHERSTEP
            // 
            this.BUTTON_GET_BITMAP_DITHERSTEP.Location = new System.Drawing.Point(217, 96);
            this.BUTTON_GET_BITMAP_DITHERSTEP.Name = "BUTTON_GET_BITMAP_DITHERSTEP";
            this.BUTTON_GET_BITMAP_DITHERSTEP.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_GET_BITMAP_DITHERSTEP.TabIndex = 24;
            this.BUTTON_GET_BITMAP_DITHERSTEP.Text = "Get";
            this.BUTTON_GET_BITMAP_DITHERSTEP.UseVisualStyleBackColor = true;
            this.BUTTON_GET_BITMAP_DITHERSTEP.Click += new System.EventHandler(this.BUTTON_GET_BITMAP_DITHERSTEP_Click);
            // 
            // BUTTON_CHANGE_BITMAP_DITHERSTEP
            // 
            this.BUTTON_CHANGE_BITMAP_DITHERSTEP.Location = new System.Drawing.Point(293, 97);
            this.BUTTON_CHANGE_BITMAP_DITHERSTEP.Name = "BUTTON_CHANGE_BITMAP_DITHERSTEP";
            this.BUTTON_CHANGE_BITMAP_DITHERSTEP.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_BITMAP_DITHERSTEP.TabIndex = 23;
            this.BUTTON_CHANGE_BITMAP_DITHERSTEP.Text = "Set";
            this.BUTTON_CHANGE_BITMAP_DITHERSTEP.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_BITMAP_DITHERSTEP.Click += new System.EventHandler(this.BUTTON_CHANGE_BITMAP_DITHERSTEP_Click);
            // 
            // EDIT_BITMAP_DITHERSTEP
            // 
            this.EDIT_BITMAP_DITHERSTEP.Location = new System.Drawing.Point(89, 98);
            this.EDIT_BITMAP_DITHERSTEP.Name = "EDIT_BITMAP_DITHERSTEP";
            this.EDIT_BITMAP_DITHERSTEP.Size = new System.Drawing.Size(113, 20);
            this.EDIT_BITMAP_DITHERSTEP.TabIndex = 22;
            this.EDIT_BITMAP_DITHERSTEP.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 104);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "Ditherstep:";
            // 
            // BUTTON_GET_BITMAP_BRIGHTNESS
            // 
            this.BUTTON_GET_BITMAP_BRIGHTNESS.Location = new System.Drawing.Point(217, 62);
            this.BUTTON_GET_BITMAP_BRIGHTNESS.Name = "BUTTON_GET_BITMAP_BRIGHTNESS";
            this.BUTTON_GET_BITMAP_BRIGHTNESS.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_GET_BITMAP_BRIGHTNESS.TabIndex = 20;
            this.BUTTON_GET_BITMAP_BRIGHTNESS.Text = "Get";
            this.BUTTON_GET_BITMAP_BRIGHTNESS.UseVisualStyleBackColor = true;
            this.BUTTON_GET_BITMAP_BRIGHTNESS.Click += new System.EventHandler(this.BUTTON_GET_BITMAP_BRIGHTNESS_Click);
            // 
            // BUTTON_CHANGE_BITMAP_BRIGHTNESS
            // 
            this.BUTTON_CHANGE_BITMAP_BRIGHTNESS.Location = new System.Drawing.Point(293, 63);
            this.BUTTON_CHANGE_BITMAP_BRIGHTNESS.Name = "BUTTON_CHANGE_BITMAP_BRIGHTNESS";
            this.BUTTON_CHANGE_BITMAP_BRIGHTNESS.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_BITMAP_BRIGHTNESS.TabIndex = 19;
            this.BUTTON_CHANGE_BITMAP_BRIGHTNESS.Text = "Set";
            this.BUTTON_CHANGE_BITMAP_BRIGHTNESS.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_BITMAP_BRIGHTNESS.Click += new System.EventHandler(this.BUTTON_CHANGE_BITMAP_BRIGHTNESS_Click);
            // 
            // EDIT_BITMAP_BRIGHTNESS
            // 
            this.EDIT_BITMAP_BRIGHTNESS.Location = new System.Drawing.Point(89, 64);
            this.EDIT_BITMAP_BRIGHTNESS.Name = "EDIT_BITMAP_BRIGHTNESS";
            this.EDIT_BITMAP_BRIGHTNESS.Size = new System.Drawing.Size(113, 20);
            this.EDIT_BITMAP_BRIGHTNESS.TabIndex = 18;
            this.EDIT_BITMAP_BRIGHTNESS.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Brightness:";
            // 
            // BUTTON_GET_BITMAP_INTENSITY
            // 
            this.BUTTON_GET_BITMAP_INTENSITY.Location = new System.Drawing.Point(217, 27);
            this.BUTTON_GET_BITMAP_INTENSITY.Name = "BUTTON_GET_BITMAP_INTENSITY";
            this.BUTTON_GET_BITMAP_INTENSITY.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_GET_BITMAP_INTENSITY.TabIndex = 16;
            this.BUTTON_GET_BITMAP_INTENSITY.Text = "Get";
            this.BUTTON_GET_BITMAP_INTENSITY.UseVisualStyleBackColor = true;
            this.BUTTON_GET_BITMAP_INTENSITY.Click += new System.EventHandler(this.BUTTON_GET_BITMAP_INTENSITY_Click);
            // 
            // BUTTON_CHANGE_BITMAP_INTENSITY
            // 
            this.BUTTON_CHANGE_BITMAP_INTENSITY.Location = new System.Drawing.Point(293, 28);
            this.BUTTON_CHANGE_BITMAP_INTENSITY.Name = "BUTTON_CHANGE_BITMAP_INTENSITY";
            this.BUTTON_CHANGE_BITMAP_INTENSITY.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_BITMAP_INTENSITY.TabIndex = 15;
            this.BUTTON_CHANGE_BITMAP_INTENSITY.Text = "Set";
            this.BUTTON_CHANGE_BITMAP_INTENSITY.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_BITMAP_INTENSITY.Click += new System.EventHandler(this.BUTTON_CHANGE_BITMAP_INTENSITY_Click);
            // 
            // EDIT_BITMAP_INTENSITY
            // 
            this.EDIT_BITMAP_INTENSITY.Location = new System.Drawing.Point(89, 30);
            this.EDIT_BITMAP_INTENSITY.Name = "EDIT_BITMAP_INTENSITY";
            this.EDIT_BITMAP_INTENSITY.Size = new System.Drawing.Size(113, 20);
            this.EDIT_BITMAP_INTENSITY.TabIndex = 14;
            this.EDIT_BITMAP_INTENSITY.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Intensity:";
            // 
            // EDIT_ENTITY_NAME
            // 
            this.EDIT_ENTITY_NAME.Location = new System.Drawing.Point(225, 43);
            this.EDIT_ENTITY_NAME.Name = "EDIT_ENTITY_NAME";
            this.EDIT_ENTITY_NAME.Size = new System.Drawing.Size(113, 20);
            this.EDIT_ENTITY_NAME.TabIndex = 35;
            this.EDIT_ENTITY_NAME.Text = "test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Entity Name";
            // 
            // BUTTON_REIMPORT
            // 
            this.BUTTON_REIMPORT.Location = new System.Drawing.Point(95, 349);
            this.BUTTON_REIMPORT.Name = "BUTTON_REIMPORT";
            this.BUTTON_REIMPORT.Size = new System.Drawing.Size(69, 23);
            this.BUTTON_REIMPORT.TabIndex = 38;
            this.BUTTON_REIMPORT.Text = "Reimport";
            this.BUTTON_REIMPORT.UseVisualStyleBackColor = true;
            this.BUTTON_REIMPORT.Click += new System.EventHandler(this.BUTTON_REIMPORT_Click);
            // 
            // EDIT_FILE_NAME
            // 
            this.EDIT_FILE_NAME.Location = new System.Drawing.Point(95, 318);
            this.EDIT_FILE_NAME.Name = "EDIT_FILE_NAME";
            this.EDIT_FILE_NAME.Size = new System.Drawing.Size(234, 20);
            this.EDIT_FILE_NAME.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "File Name:";
            // 
            // CHECK_SCANNER_BITMAP_AND_BIDIRECTIONAL
            // 
            this.CHECK_SCANNER_BITMAP_AND_BIDIRECTIONAL.AutoSize = true;
            this.CHECK_SCANNER_BITMAP_AND_BIDIRECTIONAL.Location = new System.Drawing.Point(68, 270);
            this.CHECK_SCANNER_BITMAP_AND_BIDIRECTIONAL.Name = "CHECK_SCANNER_BITMAP_AND_BIDIRECTIONAL";
            this.CHECK_SCANNER_BITMAP_AND_BIDIRECTIONAL.Size = new System.Drawing.Size(182, 17);
            this.CHECK_SCANNER_BITMAP_AND_BIDIRECTIONAL.TabIndex = 39;
            this.CHECK_SCANNER_BITMAP_AND_BIDIRECTIONAL.Text = "Scanner Bitmap and Bidirectional";
            this.CHECK_SCANNER_BITMAP_AND_BIDIRECTIONAL.UseVisualStyleBackColor = true;
            this.CHECK_SCANNER_BITMAP_AND_BIDIRECTIONAL.CheckedChanged += new System.EventHandler(this.CHECK_SCANNER_BITMAP_AND_BIDIRECTIONAL_CheckedChanged);
            // 
            // button_change_path
            // 
            this.button_change_path.Location = new System.Drawing.Point(341, 318);
            this.button_change_path.Name = "button_change_path";
            this.button_change_path.Size = new System.Drawing.Size(84, 23);
            this.button_change_path.TabIndex = 40;
            this.button_change_path.Text = "Browse";
            this.button_change_path.UseVisualStyleBackColor = true;
            this.button_change_path.Click += new System.EventHandler(this.button_change_path_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bitmap_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 394);
            this.Controls.Add(this.button_change_path);
            this.Controls.Add(this.CHECK_SCANNER_BITMAP_AND_BIDIRECTIONAL);
            this.Controls.Add(this.BUTTON_REIMPORT);
            this.Controls.Add(this.EDIT_FILE_NAME);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EDIT_ENTITY_NAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox13);
            this.Name = "bitmap_frm";
            this.Text = "Bitmap";
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button BUTTON_GET_BITMAP_DITHERSTEP;
        private System.Windows.Forms.Button BUTTON_CHANGE_BITMAP_DITHERSTEP;
        private System.Windows.Forms.TextBox EDIT_BITMAP_DITHERSTEP;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button BUTTON_GET_BITMAP_BRIGHTNESS;
        private System.Windows.Forms.Button BUTTON_CHANGE_BITMAP_BRIGHTNESS;
        private System.Windows.Forms.TextBox EDIT_BITMAP_BRIGHTNESS;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button BUTTON_GET_BITMAP_INTENSITY;
        private System.Windows.Forms.Button BUTTON_CHANGE_BITMAP_INTENSITY;
        private System.Windows.Forms.TextBox EDIT_BITMAP_INTENSITY;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox EDIT_ENTITY_NAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BUTTON_REIMPORT;
        private System.Windows.Forms.TextBox EDIT_FILE_NAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CHECK_SCANNER_BITMAP_AND_BIDIRECTIONAL;
        private System.Windows.Forms.Button button_change_path;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}