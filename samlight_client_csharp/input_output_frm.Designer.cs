namespace samlight_client_csharp
{
    partial class input_output_frm
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
            this.COMBO_BIT = new System.Windows.Forms.ComboBox();
            this.CHECK_OPTO_OUT = new System.Windows.Forms.CheckBox();
            this.BUTTON_READ_OPTO_IN = new System.Windows.Forms.Button();
            this.BUTTON_READ_OPTO_OUT = new System.Windows.Forms.Button();
            this.BUTTON_CHANGE_OPTO_OUT = new System.Windows.Forms.Button();
            this.CHECK_OPTO_IN = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Bit:";
            // 
            // COMBO_BIT
            // 
            this.COMBO_BIT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_BIT.FormattingEnabled = true;
            this.COMBO_BIT.Location = new System.Drawing.Point(124, 21);
            this.COMBO_BIT.Name = "COMBO_BIT";
            this.COMBO_BIT.Size = new System.Drawing.Size(49, 21);
            this.COMBO_BIT.TabIndex = 43;
            this.COMBO_BIT.SelectedIndexChanged += new System.EventHandler(this.COMBO_BIT_SelectedIndexChanged);
            // 
            // CHECK_OPTO_OUT
            // 
            this.CHECK_OPTO_OUT.AutoSize = true;
            this.CHECK_OPTO_OUT.Location = new System.Drawing.Point(32, 91);
            this.CHECK_OPTO_OUT.Name = "CHECK_OPTO_OUT";
            this.CHECK_OPTO_OUT.Size = new System.Drawing.Size(76, 17);
            this.CHECK_OPTO_OUT.TabIndex = 49;
            this.CHECK_OPTO_OUT.Text = "OPTO Out";
            this.CHECK_OPTO_OUT.UseVisualStyleBackColor = true;
            // 
            // BUTTON_READ_OPTO_IN
            // 
            this.BUTTON_READ_OPTO_IN.Location = new System.Drawing.Point(179, 120);
            this.BUTTON_READ_OPTO_IN.Name = "BUTTON_READ_OPTO_IN";
            this.BUTTON_READ_OPTO_IN.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_READ_OPTO_IN.TabIndex = 47;
            this.BUTTON_READ_OPTO_IN.Text = "Read";
            this.BUTTON_READ_OPTO_IN.UseVisualStyleBackColor = true;
            this.BUTTON_READ_OPTO_IN.Click += new System.EventHandler(this.BUTTON_READ_OPTO_IN_Click);
            // 
            // BUTTON_READ_OPTO_OUT
            // 
            this.BUTTON_READ_OPTO_OUT.Location = new System.Drawing.Point(179, 87);
            this.BUTTON_READ_OPTO_OUT.Name = "BUTTON_READ_OPTO_OUT";
            this.BUTTON_READ_OPTO_OUT.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_READ_OPTO_OUT.TabIndex = 46;
            this.BUTTON_READ_OPTO_OUT.Text = "Read";
            this.BUTTON_READ_OPTO_OUT.UseVisualStyleBackColor = true;
            this.BUTTON_READ_OPTO_OUT.Click += new System.EventHandler(this.BUTTON_READ_OPTO_OUT_Click);
            // 
            // BUTTON_CHANGE_OPTO_OUT
            // 
            this.BUTTON_CHANGE_OPTO_OUT.Location = new System.Drawing.Point(114, 87);
            this.BUTTON_CHANGE_OPTO_OUT.Name = "BUTTON_CHANGE_OPTO_OUT";
            this.BUTTON_CHANGE_OPTO_OUT.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_OPTO_OUT.TabIndex = 45;
            this.BUTTON_CHANGE_OPTO_OUT.Text = "Set";
            this.BUTTON_CHANGE_OPTO_OUT.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_OPTO_OUT.Click += new System.EventHandler(this.BUTTON_CHANGE_OPTO_OUT_Click);
            // 
            // CHECK_OPTO_IN
            // 
            this.CHECK_OPTO_IN.AutoSize = true;
            this.CHECK_OPTO_IN.Location = new System.Drawing.Point(32, 126);
            this.CHECK_OPTO_IN.Name = "CHECK_OPTO_IN";
            this.CHECK_OPTO_IN.Size = new System.Drawing.Size(68, 17);
            this.CHECK_OPTO_IN.TabIndex = 50;
            this.CHECK_OPTO_IN.Text = "OPTO In";
            this.CHECK_OPTO_IN.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CHECK_OPTO_IN);
            this.groupBox1.Controls.Add(this.CHECK_OPTO_OUT);
            this.groupBox1.Controls.Add(this.BUTTON_READ_OPTO_IN);
            this.groupBox1.Controls.Add(this.BUTTON_READ_OPTO_OUT);
            this.groupBox1.Controls.Add(this.BUTTON_CHANGE_OPTO_OUT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.COMBO_BIT);
            this.groupBox1.Location = new System.Drawing.Point(34, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 194);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // input_output_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 237);
            this.Controls.Add(this.groupBox1);
            this.Name = "input_output_frm";
            this.Text = "Input Output";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox COMBO_BIT;
        private System.Windows.Forms.CheckBox CHECK_OPTO_OUT;
        private System.Windows.Forms.Button BUTTON_READ_OPTO_IN;
        private System.Windows.Forms.Button BUTTON_READ_OPTO_OUT;
        private System.Windows.Forms.Button BUTTON_CHANGE_OPTO_OUT;
        private System.Windows.Forms.CheckBox CHECK_OPTO_IN;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}