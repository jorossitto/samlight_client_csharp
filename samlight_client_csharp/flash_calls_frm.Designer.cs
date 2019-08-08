namespace samlight_client_csharp
{
    partial class flash_calls_frm
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
            this.EDIT_ENTITY_NAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CHECK_WAIT_FOR_EXTERNAL_TRIGGER = new System.Windows.Forms.CheckBox();
            this.BUTTON_SELECT = new System.Windows.Forms.Button();
            this.EDIT_JOB_NUMBER = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BUTTON_MARK = new System.Windows.Forms.Button();
            this.BUTTON_STOP_MARK = new System.Windows.Forms.Button();
            this.BUTTON_DOWNLOAD = new System.Windows.Forms.Button();
            this.BUTTON_UPLOAD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EDIT_ENTITY_NAME
            // 
            this.EDIT_ENTITY_NAME.Location = new System.Drawing.Point(202, 31);
            this.EDIT_ENTITY_NAME.Name = "EDIT_ENTITY_NAME";
            this.EDIT_ENTITY_NAME.Size = new System.Drawing.Size(113, 20);
            this.EDIT_ENTITY_NAME.TabIndex = 42;
            this.EDIT_ENTITY_NAME.Text = "test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Entity Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CHECK_WAIT_FOR_EXTERNAL_TRIGGER);
            this.groupBox1.Controls.Add(this.BUTTON_SELECT);
            this.groupBox1.Controls.Add(this.EDIT_JOB_NUMBER);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BUTTON_MARK);
            this.groupBox1.Controls.Add(this.BUTTON_STOP_MARK);
            this.groupBox1.Controls.Add(this.BUTTON_DOWNLOAD);
            this.groupBox1.Controls.Add(this.BUTTON_UPLOAD);
            this.groupBox1.Location = new System.Drawing.Point(34, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 195);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // CHECK_WAIT_FOR_EXTERNAL_TRIGGER
            // 
            this.CHECK_WAIT_FOR_EXTERNAL_TRIGGER.AutoSize = true;
            this.CHECK_WAIT_FOR_EXTERNAL_TRIGGER.Location = new System.Drawing.Point(177, 144);
            this.CHECK_WAIT_FOR_EXTERNAL_TRIGGER.Name = "CHECK_WAIT_FOR_EXTERNAL_TRIGGER";
            this.CHECK_WAIT_FOR_EXTERNAL_TRIGGER.Size = new System.Drawing.Size(135, 17);
            this.CHECK_WAIT_FOR_EXTERNAL_TRIGGER.TabIndex = 46;
            this.CHECK_WAIT_FOR_EXTERNAL_TRIGGER.Text = "Wait for external trigger";
            this.CHECK_WAIT_FOR_EXTERNAL_TRIGGER.UseVisualStyleBackColor = true;
            this.CHECK_WAIT_FOR_EXTERNAL_TRIGGER.CheckedChanged += new System.EventHandler(this.CHECK_WAIT_FOR_EXTERNAL_TRIGGER_CheckedChanged);
            // 
            // BUTTON_SELECT
            // 
            this.BUTTON_SELECT.Location = new System.Drawing.Point(36, 142);
            this.BUTTON_SELECT.Name = "BUTTON_SELECT";
            this.BUTTON_SELECT.Size = new System.Drawing.Size(97, 23);
            this.BUTTON_SELECT.TabIndex = 45;
            this.BUTTON_SELECT.Text = "Select";
            this.BUTTON_SELECT.UseVisualStyleBackColor = true;
            this.BUTTON_SELECT.Click += new System.EventHandler(this.BUTTON_SELECT_Click);
            // 
            // EDIT_JOB_NUMBER
            // 
            this.EDIT_JOB_NUMBER.Location = new System.Drawing.Point(177, 35);
            this.EDIT_JOB_NUMBER.Name = "EDIT_JOB_NUMBER";
            this.EDIT_JOB_NUMBER.Size = new System.Drawing.Size(47, 20);
            this.EDIT_JOB_NUMBER.TabIndex = 44;
            this.EDIT_JOB_NUMBER.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Job Number:";
            // 
            // BUTTON_MARK
            // 
            this.BUTTON_MARK.Location = new System.Drawing.Point(36, 106);
            this.BUTTON_MARK.Name = "BUTTON_MARK";
            this.BUTTON_MARK.Size = new System.Drawing.Size(97, 23);
            this.BUTTON_MARK.TabIndex = 30;
            this.BUTTON_MARK.Text = "Mark";
            this.BUTTON_MARK.UseVisualStyleBackColor = true;
            this.BUTTON_MARK.Click += new System.EventHandler(this.BUTTON_MARK_Click);
            // 
            // BUTTON_STOP_MARK
            // 
            this.BUTTON_STOP_MARK.Location = new System.Drawing.Point(177, 103);
            this.BUTTON_STOP_MARK.Name = "BUTTON_STOP_MARK";
            this.BUTTON_STOP_MARK.Size = new System.Drawing.Size(146, 23);
            this.BUTTON_STOP_MARK.TabIndex = 31;
            this.BUTTON_STOP_MARK.Text = "Stop Mark";
            this.BUTTON_STOP_MARK.UseVisualStyleBackColor = true;
            this.BUTTON_STOP_MARK.Click += new System.EventHandler(this.BUTTON_STOP_MARK_Click);
            // 
            // BUTTON_DOWNLOAD
            // 
            this.BUTTON_DOWNLOAD.Location = new System.Drawing.Point(36, 70);
            this.BUTTON_DOWNLOAD.Name = "BUTTON_DOWNLOAD";
            this.BUTTON_DOWNLOAD.Size = new System.Drawing.Size(97, 23);
            this.BUTTON_DOWNLOAD.TabIndex = 16;
            this.BUTTON_DOWNLOAD.Text = "Store To Flash";
            this.BUTTON_DOWNLOAD.UseVisualStyleBackColor = true;
            this.BUTTON_DOWNLOAD.Click += new System.EventHandler(this.BUTTON_DOWNLOAD_Click);
            // 
            // BUTTON_UPLOAD
            // 
            this.BUTTON_UPLOAD.Location = new System.Drawing.Point(177, 70);
            this.BUTTON_UPLOAD.Name = "BUTTON_UPLOAD";
            this.BUTTON_UPLOAD.Size = new System.Drawing.Size(146, 23);
            this.BUTTON_UPLOAD.TabIndex = 15;
            this.BUTTON_UPLOAD.Text = "Load From Flash";
            this.BUTTON_UPLOAD.UseVisualStyleBackColor = true;
            this.BUTTON_UPLOAD.Click += new System.EventHandler(this.BUTTON_UPLOAD_Click);
            // 
            // flash_calls_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 308);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EDIT_ENTITY_NAME);
            this.Controls.Add(this.label1);
            this.Name = "flash_calls_frm";
            this.Text = "Flash Calls";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EDIT_ENTITY_NAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BUTTON_SELECT;
        private System.Windows.Forms.TextBox EDIT_JOB_NUMBER;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BUTTON_MARK;
        private System.Windows.Forms.Button BUTTON_STOP_MARK;
        private System.Windows.Forms.Button BUTTON_DOWNLOAD;
        private System.Windows.Forms.Button BUTTON_UPLOAD;
        private System.Windows.Forms.CheckBox CHECK_WAIT_FOR_EXTERNAL_TRIGGER;
    }
}