namespace samlight_client_csharp
{
    partial class text_frm
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EDIT_TEXT_WEIGHT = new System.Windows.Forms.TextBox();
            this.BUTTON_CHANGE_TEXT_WEIGHT = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.EDIT_TEXT_ORIENTATION = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BUTTON_CHANGE_TEXT_ORIENTATION = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BUTTON_CHANGE_TEXT_ALIGNMENT_GET = new System.Windows.Forms.Button();
            this.BUTTON_CHANGE_TEXT_ALIGNMENT_SET = new System.Windows.Forms.Button();
            this.RADIO_RIGHT = new System.Windows.Forms.RadioButton();
            this.RADIO_LEFT = new System.Windows.Forms.RadioButton();
            this.RADIO_CENTER = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BUTTON_CHANGE_TEXT_BY_NAME = new System.Windows.Forms.Button();
            this.EDIT_TEXT_STRING = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EDIT_ENTITY_NAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.EDIT_TEXT_WEIGHT);
            this.groupBox5.Controls.Add(this.BUTTON_CHANGE_TEXT_WEIGHT);
            this.groupBox5.Location = new System.Drawing.Point(44, 240);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(367, 55);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ScSetTextWeight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Weight";
            // 
            // EDIT_TEXT_WEIGHT
            // 
            this.EDIT_TEXT_WEIGHT.Location = new System.Drawing.Point(127, 20);
            this.EDIT_TEXT_WEIGHT.Name = "EDIT_TEXT_WEIGHT";
            this.EDIT_TEXT_WEIGHT.Size = new System.Drawing.Size(113, 20);
            this.EDIT_TEXT_WEIGHT.TabIndex = 17;
            this.EDIT_TEXT_WEIGHT.Text = "700";
            // 
            // BUTTON_CHANGE_TEXT_WEIGHT
            // 
            this.BUTTON_CHANGE_TEXT_WEIGHT.Location = new System.Drawing.Point(288, 22);
            this.BUTTON_CHANGE_TEXT_WEIGHT.Name = "BUTTON_CHANGE_TEXT_WEIGHT";
            this.BUTTON_CHANGE_TEXT_WEIGHT.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_TEXT_WEIGHT.TabIndex = 16;
            this.BUTTON_CHANGE_TEXT_WEIGHT.Text = "Set";
            this.BUTTON_CHANGE_TEXT_WEIGHT.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_TEXT_WEIGHT.Click += new System.EventHandler(this.BUTTON_CHANGE_TEXT_WEIGHT_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.EDIT_TEXT_ORIENTATION);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.BUTTON_CHANGE_TEXT_ORIENTATION);
            this.groupBox4.Location = new System.Drawing.Point(44, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(367, 50);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ScChangeTextOrientation";
            // 
            // EDIT_TEXT_ORIENTATION
            // 
            this.EDIT_TEXT_ORIENTATION.Location = new System.Drawing.Point(127, 19);
            this.EDIT_TEXT_ORIENTATION.Name = "EDIT_TEXT_ORIENTATION";
            this.EDIT_TEXT_ORIENTATION.Size = new System.Drawing.Size(113, 20);
            this.EDIT_TEXT_ORIENTATION.TabIndex = 19;
            this.EDIT_TEXT_ORIENTATION.Text = "1.57075";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Radius (PI)";
            // 
            // BUTTON_CHANGE_TEXT_ORIENTATION
            // 
            this.BUTTON_CHANGE_TEXT_ORIENTATION.Location = new System.Drawing.Point(288, 19);
            this.BUTTON_CHANGE_TEXT_ORIENTATION.Name = "BUTTON_CHANGE_TEXT_ORIENTATION";
            this.BUTTON_CHANGE_TEXT_ORIENTATION.Size = new System.Drawing.Size(60, 23);
            this.BUTTON_CHANGE_TEXT_ORIENTATION.TabIndex = 16;
            this.BUTTON_CHANGE_TEXT_ORIENTATION.Text = "Set";
            this.BUTTON_CHANGE_TEXT_ORIENTATION.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_TEXT_ORIENTATION.Click += new System.EventHandler(this.BUTTON_CHANGE_TEXT_ORIENTATION_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BUTTON_CHANGE_TEXT_ALIGNMENT_GET);
            this.groupBox3.Controls.Add(this.BUTTON_CHANGE_TEXT_ALIGNMENT_SET);
            this.groupBox3.Controls.Add(this.RADIO_RIGHT);
            this.groupBox3.Controls.Add(this.RADIO_LEFT);
            this.groupBox3.Controls.Add(this.RADIO_CENTER);
            this.groupBox3.Location = new System.Drawing.Point(44, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 52);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ScChangeTextAlignment";
            // 
            // BUTTON_CHANGE_TEXT_ALIGNMENT_GET
            // 
            this.BUTTON_CHANGE_TEXT_ALIGNMENT_GET.Location = new System.Drawing.Point(215, 22);
            this.BUTTON_CHANGE_TEXT_ALIGNMENT_GET.Name = "BUTTON_CHANGE_TEXT_ALIGNMENT_GET";
            this.BUTTON_CHANGE_TEXT_ALIGNMENT_GET.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_TEXT_ALIGNMENT_GET.TabIndex = 17;
            this.BUTTON_CHANGE_TEXT_ALIGNMENT_GET.Text = "Get";
            this.BUTTON_CHANGE_TEXT_ALIGNMENT_GET.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_TEXT_ALIGNMENT_GET.Click += new System.EventHandler(this.BUTTON_CHANGE_TEXT_ALIGNMENT_GET_Click);
            // 
            // BUTTON_CHANGE_TEXT_ALIGNMENT_SET
            // 
            this.BUTTON_CHANGE_TEXT_ALIGNMENT_SET.Location = new System.Drawing.Point(288, 22);
            this.BUTTON_CHANGE_TEXT_ALIGNMENT_SET.Name = "BUTTON_CHANGE_TEXT_ALIGNMENT_SET";
            this.BUTTON_CHANGE_TEXT_ALIGNMENT_SET.Size = new System.Drawing.Size(60, 23);
            this.BUTTON_CHANGE_TEXT_ALIGNMENT_SET.TabIndex = 16;
            this.BUTTON_CHANGE_TEXT_ALIGNMENT_SET.Text = "Set";
            this.BUTTON_CHANGE_TEXT_ALIGNMENT_SET.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_TEXT_ALIGNMENT_SET.Click += new System.EventHandler(this.BUTTON_CHANGE_TEXT_ALIGNMENT_SET_Click);
            // 
            // RADIO_RIGHT
            // 
            this.RADIO_RIGHT.AutoSize = true;
            this.RADIO_RIGHT.Location = new System.Drawing.Point(154, 28);
            this.RADIO_RIGHT.Name = "RADIO_RIGHT";
            this.RADIO_RIGHT.Size = new System.Drawing.Size(50, 17);
            this.RADIO_RIGHT.TabIndex = 2;
            this.RADIO_RIGHT.TabStop = true;
            this.RADIO_RIGHT.Text = "Right";
            this.RADIO_RIGHT.UseVisualStyleBackColor = true;
            this.RADIO_RIGHT.CheckedChanged += new System.EventHandler(this.RADIO_RIGHT_CheckedChanged);
            // 
            // RADIO_LEFT
            // 
            this.RADIO_LEFT.AutoSize = true;
            this.RADIO_LEFT.Location = new System.Drawing.Point(85, 28);
            this.RADIO_LEFT.Name = "RADIO_LEFT";
            this.RADIO_LEFT.Size = new System.Drawing.Size(43, 17);
            this.RADIO_LEFT.TabIndex = 1;
            this.RADIO_LEFT.TabStop = true;
            this.RADIO_LEFT.Text = "Left";
            this.RADIO_LEFT.UseVisualStyleBackColor = true;
            this.RADIO_LEFT.CheckedChanged += new System.EventHandler(this.RADIO_LEFT_CheckedChanged);
            // 
            // RADIO_CENTER
            // 
            this.RADIO_CENTER.AutoSize = true;
            this.RADIO_CENTER.Location = new System.Drawing.Point(14, 28);
            this.RADIO_CENTER.Name = "RADIO_CENTER";
            this.RADIO_CENTER.Size = new System.Drawing.Size(56, 17);
            this.RADIO_CENTER.TabIndex = 0;
            this.RADIO_CENTER.TabStop = true;
            this.RADIO_CENTER.Text = "Center";
            this.RADIO_CENTER.UseVisualStyleBackColor = true;
            this.RADIO_CENTER.CheckedChanged += new System.EventHandler(this.RADIO_CENTER_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BUTTON_CHANGE_TEXT_BY_NAME);
            this.groupBox2.Controls.Add(this.EDIT_TEXT_STRING);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(44, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 62);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ScChangeTextByName";
            // 
            // BUTTON_CHANGE_TEXT_BY_NAME
            // 
            this.BUTTON_CHANGE_TEXT_BY_NAME.Location = new System.Drawing.Point(288, 30);
            this.BUTTON_CHANGE_TEXT_BY_NAME.Name = "BUTTON_CHANGE_TEXT_BY_NAME";
            this.BUTTON_CHANGE_TEXT_BY_NAME.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_TEXT_BY_NAME.TabIndex = 15;
            this.BUTTON_CHANGE_TEXT_BY_NAME.Text = "Set";
            this.BUTTON_CHANGE_TEXT_BY_NAME.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_TEXT_BY_NAME.Click += new System.EventHandler(this.BUTTON_CHANGE_TEXT_BY_NAME_Click);
            // 
            // EDIT_TEXT_STRING
            // 
            this.EDIT_TEXT_STRING.Location = new System.Drawing.Point(127, 32);
            this.EDIT_TEXT_STRING.Name = "EDIT_TEXT_STRING";
            this.EDIT_TEXT_STRING.Size = new System.Drawing.Size(113, 20);
            this.EDIT_TEXT_STRING.TabIndex = 14;
            this.EDIT_TEXT_STRING.Text = "MyText";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Text String";
            // 
            // EDIT_ENTITY_NAME
            // 
            this.EDIT_ENTITY_NAME.Location = new System.Drawing.Point(171, 32);
            this.EDIT_ENTITY_NAME.Name = "EDIT_ENTITY_NAME";
            this.EDIT_ENTITY_NAME.Size = new System.Drawing.Size(113, 20);
            this.EDIT_ENTITY_NAME.TabIndex = 19;
            this.EDIT_ENTITY_NAME.Text = "test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Entity Name";
            // 
            // text_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 337);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.EDIT_ENTITY_NAME);
            this.Controls.Add(this.label3);
            this.Name = "text_frm";
            this.Text = "Text";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EDIT_TEXT_WEIGHT;
        private System.Windows.Forms.Button BUTTON_CHANGE_TEXT_WEIGHT;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox EDIT_TEXT_ORIENTATION;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BUTTON_CHANGE_TEXT_ORIENTATION;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BUTTON_CHANGE_TEXT_ALIGNMENT_GET;
        private System.Windows.Forms.Button BUTTON_CHANGE_TEXT_ALIGNMENT_SET;
        private System.Windows.Forms.RadioButton RADIO_RIGHT;
        private System.Windows.Forms.RadioButton RADIO_LEFT;
        private System.Windows.Forms.RadioButton RADIO_CENTER;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BUTTON_CHANGE_TEXT_BY_NAME;
        private System.Windows.Forms.TextBox EDIT_TEXT_STRING;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EDIT_ENTITY_NAME;
        private System.Windows.Forms.Label label3;
    }
}