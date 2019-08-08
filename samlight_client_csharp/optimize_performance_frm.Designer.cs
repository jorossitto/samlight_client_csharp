namespace samlight_client_csharp
{
    partial class optimize_performance_frm
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
            this.BUTTON_OPTIMIZE_PERFORMANCE = new System.Windows.Forms.Button();
            this.LABEL_OPTIMIZE_PERFORMANCE = new System.Windows.Forms.Label();
            this.EDIT_JOB_PATH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BUTTON_OPTIMIZE_PERFORMANCE
            // 
            this.BUTTON_OPTIMIZE_PERFORMANCE.Location = new System.Drawing.Point(77, 269);
            this.BUTTON_OPTIMIZE_PERFORMANCE.Name = "BUTTON_OPTIMIZE_PERFORMANCE";
            this.BUTTON_OPTIMIZE_PERFORMANCE.Size = new System.Drawing.Size(193, 23);
            this.BUTTON_OPTIMIZE_PERFORMANCE.TabIndex = 21;
            this.BUTTON_OPTIMIZE_PERFORMANCE.Text = "Change Properties of 20 Barcodes";
            this.BUTTON_OPTIMIZE_PERFORMANCE.UseVisualStyleBackColor = true;
            this.BUTTON_OPTIMIZE_PERFORMANCE.Click += new System.EventHandler(this.BUTTON_OPTIMIZE_PERFORMANCE_Click);
            // 
            // LABEL_OPTIMIZE_PERFORMANCE
            // 
            this.LABEL_OPTIMIZE_PERFORMANCE.AutoSize = true;
            this.LABEL_OPTIMIZE_PERFORMANCE.Location = new System.Drawing.Point(53, 37);
            this.LABEL_OPTIMIZE_PERFORMANCE.Name = "LABEL_OPTIMIZE_PERFORMANCE";
            this.LABEL_OPTIMIZE_PERFORMANCE.Size = new System.Drawing.Size(0, 13);
            this.LABEL_OPTIMIZE_PERFORMANCE.TabIndex = 22;
            // 
            // EDIT_JOB_PATH
            // 
            this.EDIT_JOB_PATH.Location = new System.Drawing.Point(77, 231);
            this.EDIT_JOB_PATH.Name = "EDIT_JOB_PATH";
            this.EDIT_JOB_PATH.Size = new System.Drawing.Size(575, 20);
            this.EDIT_JOB_PATH.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Job Path:";
            // 
            // optimize_performance_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 317);
            this.Controls.Add(this.EDIT_JOB_PATH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LABEL_OPTIMIZE_PERFORMANCE);
            this.Controls.Add(this.BUTTON_OPTIMIZE_PERFORMANCE);
            this.Name = "optimize_performance_frm";
            this.Text = "Optimize Performance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BUTTON_OPTIMIZE_PERFORMANCE;
        private System.Windows.Forms.Label LABEL_OPTIMIZE_PERFORMANCE;
        private System.Windows.Forms.TextBox EDIT_JOB_PATH;
        private System.Windows.Forms.Label label1;
    }
}