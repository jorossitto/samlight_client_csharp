namespace samlight_client_csharp
{
    partial class load_and_save_frm
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BUTTON_IMPORT = new System.Windows.Forms.Button();
            this.BUTTON_SAVE_JOB = new System.Windows.Forms.Button();
            this.BUTTON_LOAD_JOB = new System.Windows.Forms.Button();
            this.CHECK_MATERIALS = new System.Windows.Forms.CheckBox();
            this.CHECK_OVERWRITE_ENTITIES = new System.Windows.Forms.CheckBox();
            this.CHECK_ENTITIES = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EDIT_JOB_FILE_NAME = new System.Windows.Forms.TextBox();
            this.BUTTON_NEW_JOB = new System.Windows.Forms.Button();
            this.button_change_path = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button_change_path);
            this.groupBox6.Controls.Add(this.BUTTON_IMPORT);
            this.groupBox6.Controls.Add(this.BUTTON_SAVE_JOB);
            this.groupBox6.Controls.Add(this.BUTTON_LOAD_JOB);
            this.groupBox6.Controls.Add(this.CHECK_MATERIALS);
            this.groupBox6.Controls.Add(this.CHECK_OVERWRITE_ENTITIES);
            this.groupBox6.Controls.Add(this.CHECK_ENTITIES);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.EDIT_JOB_FILE_NAME);
            this.groupBox6.Controls.Add(this.BUTTON_NEW_JOB);
            this.groupBox6.Location = new System.Drawing.Point(29, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(604, 177);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Load Job";
            // 
            // BUTTON_IMPORT
            // 
            this.BUTTON_IMPORT.Location = new System.Drawing.Point(181, 133);
            this.BUTTON_IMPORT.Name = "BUTTON_IMPORT";
            this.BUTTON_IMPORT.Size = new System.Drawing.Size(93, 23);
            this.BUTTON_IMPORT.TabIndex = 25;
            this.BUTTON_IMPORT.Text = "Import";
            this.BUTTON_IMPORT.UseVisualStyleBackColor = true;
            this.BUTTON_IMPORT.Click += new System.EventHandler(this.BUTTON_IMPORT_Click);
            // 
            // BUTTON_SAVE_JOB
            // 
            this.BUTTON_SAVE_JOB.Location = new System.Drawing.Point(21, 133);
            this.BUTTON_SAVE_JOB.Name = "BUTTON_SAVE_JOB";
            this.BUTTON_SAVE_JOB.Size = new System.Drawing.Size(84, 23);
            this.BUTTON_SAVE_JOB.TabIndex = 24;
            this.BUTTON_SAVE_JOB.Text = "Save Job";
            this.BUTTON_SAVE_JOB.UseVisualStyleBackColor = true;
            this.BUTTON_SAVE_JOB.Click += new System.EventHandler(this.BUTTON_SAVE_JOB_Click);
            // 
            // BUTTON_LOAD_JOB
            // 
            this.BUTTON_LOAD_JOB.Location = new System.Drawing.Point(181, 90);
            this.BUTTON_LOAD_JOB.Name = "BUTTON_LOAD_JOB";
            this.BUTTON_LOAD_JOB.Size = new System.Drawing.Size(93, 23);
            this.BUTTON_LOAD_JOB.TabIndex = 23;
            this.BUTTON_LOAD_JOB.Text = "Load Job";
            this.BUTTON_LOAD_JOB.UseVisualStyleBackColor = true;
            this.BUTTON_LOAD_JOB.Click += new System.EventHandler(this.BUTTON_LOAD_JOB_Click);
            // 
            // CHECK_MATERIALS
            // 
            this.CHECK_MATERIALS.AutoSize = true;
            this.CHECK_MATERIALS.Location = new System.Drawing.Point(254, 19);
            this.CHECK_MATERIALS.Name = "CHECK_MATERIALS";
            this.CHECK_MATERIALS.Size = new System.Drawing.Size(50, 17);
            this.CHECK_MATERIALS.TabIndex = 22;
            this.CHECK_MATERIALS.Text = "Pens";
            this.CHECK_MATERIALS.UseVisualStyleBackColor = true;
            // 
            // CHECK_OVERWRITE_ENTITIES
            // 
            this.CHECK_OVERWRITE_ENTITIES.AutoSize = true;
            this.CHECK_OVERWRITE_ENTITIES.Location = new System.Drawing.Point(124, 19);
            this.CHECK_OVERWRITE_ENTITIES.Name = "CHECK_OVERWRITE_ENTITIES";
            this.CHECK_OVERWRITE_ENTITIES.Size = new System.Drawing.Size(108, 17);
            this.CHECK_OVERWRITE_ENTITIES.TabIndex = 21;
            this.CHECK_OVERWRITE_ENTITIES.Text = "Overwrite Entities";
            this.CHECK_OVERWRITE_ENTITIES.UseVisualStyleBackColor = true;
            // 
            // CHECK_ENTITIES
            // 
            this.CHECK_ENTITIES.AutoSize = true;
            this.CHECK_ENTITIES.Location = new System.Drawing.Point(28, 19);
            this.CHECK_ENTITIES.Name = "CHECK_ENTITIES";
            this.CHECK_ENTITIES.Size = new System.Drawing.Size(60, 17);
            this.CHECK_ENTITIES.TabIndex = 20;
            this.CHECK_ENTITIES.Text = "Entities";
            this.CHECK_ENTITIES.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "FileName: ";
            // 
            // EDIT_JOB_FILE_NAME
            // 
            this.EDIT_JOB_FILE_NAME.Location = new System.Drawing.Point(113, 52);
            this.EDIT_JOB_FILE_NAME.Name = "EDIT_JOB_FILE_NAME";
            this.EDIT_JOB_FILE_NAME.Size = new System.Drawing.Size(363, 20);
            this.EDIT_JOB_FILE_NAME.TabIndex = 17;
            this.EDIT_JOB_FILE_NAME.Text = "c:\\test.sjf";
            // 
            // BUTTON_NEW_JOB
            // 
            this.BUTTON_NEW_JOB.Location = new System.Drawing.Point(21, 90);
            this.BUTTON_NEW_JOB.Name = "BUTTON_NEW_JOB";
            this.BUTTON_NEW_JOB.Size = new System.Drawing.Size(84, 23);
            this.BUTTON_NEW_JOB.TabIndex = 16;
            this.BUTTON_NEW_JOB.Text = "New Job";
            this.BUTTON_NEW_JOB.UseVisualStyleBackColor = true;
            this.BUTTON_NEW_JOB.Click += new System.EventHandler(this.BUTTON_NEW_JOB_Click);
            // 
            // button_change_path
            // 
            this.button_change_path.Location = new System.Drawing.Point(497, 52);
            this.button_change_path.Name = "button_change_path";
            this.button_change_path.Size = new System.Drawing.Size(87, 23);
            this.button_change_path.TabIndex = 26;
            this.button_change_path.Text = "Change Path";
            this.button_change_path.UseVisualStyleBackColor = true;
            this.button_change_path.Click += new System.EventHandler(this.button_change_path_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // load_and_save_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 248);
            this.Controls.Add(this.groupBox6);
            this.Name = "load_and_save_frm";
            this.Text = "Load and Save";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BUTTON_LOAD_JOB;
        private System.Windows.Forms.CheckBox CHECK_MATERIALS;
        private System.Windows.Forms.CheckBox CHECK_OVERWRITE_ENTITIES;
        private System.Windows.Forms.CheckBox CHECK_ENTITIES;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EDIT_JOB_FILE_NAME;
        private System.Windows.Forms.Button BUTTON_NEW_JOB;
        private System.Windows.Forms.Button BUTTON_IMPORT;
        private System.Windows.Forms.Button BUTTON_SAVE_JOB;
        private System.Windows.Forms.Button button_change_path;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}