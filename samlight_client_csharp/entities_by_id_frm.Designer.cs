namespace samlight_client_csharp
{
    partial class entities_by_id_frm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_access_by_id = new System.Windows.Forms.Label();
            this.button_change_path = new System.Windows.Forms.Button();
            this.button_access_by_id = new System.Windows.Forms.Button();
            this.EDIT_FILE_PATH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_top_level_entity = new System.Windows.Forms.CheckBox();
            this.BUTTON_GET_ENTITY_TYPE = new System.Windows.Forms.Button();
            this.BUTTON_GET_ENTITY_NAME = new System.Windows.Forms.Button();
            this.BUTTON_SET_ENTITY_NAME = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.EDIT_ENTITY_TYPE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EDIT_ENTITY_NAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EDIT_ID = new System.Windows.Forms.TextBox();
            this.BUTTON_GET_MARK_BEAT_COUNT = new System.Windows.Forms.Button();
            this.BUTTON_CHANGE_MARK_BEAT_COUNT = new System.Windows.Forms.Button();
            this.EDIT_MARK_BEAT_COUNT = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox13.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.groupBox2);
            this.groupBox13.Controls.Add(this.checkBox_top_level_entity);
            this.groupBox13.Controls.Add(this.BUTTON_GET_ENTITY_TYPE);
            this.groupBox13.Controls.Add(this.BUTTON_GET_ENTITY_NAME);
            this.groupBox13.Controls.Add(this.BUTTON_SET_ENTITY_NAME);
            this.groupBox13.Controls.Add(this.label4);
            this.groupBox13.Controls.Add(this.EDIT_ENTITY_TYPE);
            this.groupBox13.Controls.Add(this.label2);
            this.groupBox13.Controls.Add(this.EDIT_ENTITY_NAME);
            this.groupBox13.Controls.Add(this.label1);
            this.groupBox13.Controls.Add(this.label3);
            this.groupBox13.Controls.Add(this.EDIT_ID);
            this.groupBox13.Controls.Add(this.BUTTON_GET_MARK_BEAT_COUNT);
            this.groupBox13.Controls.Add(this.BUTTON_CHANGE_MARK_BEAT_COUNT);
            this.groupBox13.Controls.Add(this.EDIT_MARK_BEAT_COUNT);
            this.groupBox13.Location = new System.Drawing.Point(23, 32);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(616, 388);
            this.groupBox13.TabIndex = 34;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "AccesByID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_access_by_id);
            this.groupBox2.Controls.Add(this.button_change_path);
            this.groupBox2.Controls.Add(this.button_access_by_id);
            this.groupBox2.Controls.Add(this.EDIT_FILE_PATH);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(18, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 152);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // label_access_by_id
            // 
            this.label_access_by_id.AutoSize = true;
            this.label_access_by_id.Location = new System.Drawing.Point(7, 31);
            this.label_access_by_id.Name = "label_access_by_id";
            this.label_access_by_id.Size = new System.Drawing.Size(35, 13);
            this.label_access_by_id.TabIndex = 46;
            this.label_access_by_id.Text = "label6";
            // 
            // button_change_path
            // 
            this.button_change_path.Location = new System.Drawing.Point(475, 61);
            this.button_change_path.Name = "button_change_path";
            this.button_change_path.Size = new System.Drawing.Size(83, 26);
            this.button_change_path.TabIndex = 15;
            this.button_change_path.Text = "Select File";
            this.button_change_path.UseVisualStyleBackColor = true;
            this.button_change_path.Click += new System.EventHandler(this.button_change_path_Click);
            // 
            // button_access_by_id
            // 
            this.button_access_by_id.Location = new System.Drawing.Point(440, 109);
            this.button_access_by_id.Name = "button_access_by_id";
            this.button_access_by_id.Size = new System.Drawing.Size(118, 29);
            this.button_access_by_id.TabIndex = 45;
            this.button_access_by_id.Text = "Save Job Tree";
            this.button_access_by_id.UseVisualStyleBackColor = true;
            this.button_access_by_id.Click += new System.EventHandler(this.button_access_by_id_Click);
            // 
            // EDIT_FILE_PATH
            // 
            this.EDIT_FILE_PATH.Location = new System.Drawing.Point(80, 65);
            this.EDIT_FILE_PATH.Name = "EDIT_FILE_PATH";
            this.EDIT_FILE_PATH.Size = new System.Drawing.Size(373, 20);
            this.EDIT_FILE_PATH.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "File Path:";
            // 
            // checkBox_top_level_entity
            // 
            this.checkBox_top_level_entity.AutoSize = true;
            this.checkBox_top_level_entity.Location = new System.Drawing.Point(245, 43);
            this.checkBox_top_level_entity.Name = "checkBox_top_level_entity";
            this.checkBox_top_level_entity.Size = new System.Drawing.Size(127, 17);
            this.checkBox_top_level_entity.TabIndex = 44;
            this.checkBox_top_level_entity.Text = "Top Level Entity Only";
            this.checkBox_top_level_entity.UseVisualStyleBackColor = true;
            this.checkBox_top_level_entity.Visible = false;
            this.checkBox_top_level_entity.CheckedChanged += new System.EventHandler(this.checkBox_top_level_entity_CheckedChanged);
            // 
            // BUTTON_GET_ENTITY_TYPE
            // 
            this.BUTTON_GET_ENTITY_TYPE.Location = new System.Drawing.Point(245, 93);
            this.BUTTON_GET_ENTITY_TYPE.Name = "BUTTON_GET_ENTITY_TYPE";
            this.BUTTON_GET_ENTITY_TYPE.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_GET_ENTITY_TYPE.TabIndex = 43;
            this.BUTTON_GET_ENTITY_TYPE.Text = "Get";
            this.BUTTON_GET_ENTITY_TYPE.UseVisualStyleBackColor = true;
            this.BUTTON_GET_ENTITY_TYPE.Click += new System.EventHandler(this.BUTTON_GET_ENTITY_TYPE_Click);
            // 
            // BUTTON_GET_ENTITY_NAME
            // 
            this.BUTTON_GET_ENTITY_NAME.Location = new System.Drawing.Point(245, 129);
            this.BUTTON_GET_ENTITY_NAME.Name = "BUTTON_GET_ENTITY_NAME";
            this.BUTTON_GET_ENTITY_NAME.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_GET_ENTITY_NAME.TabIndex = 42;
            this.BUTTON_GET_ENTITY_NAME.Text = "Get";
            this.BUTTON_GET_ENTITY_NAME.UseVisualStyleBackColor = true;
            this.BUTTON_GET_ENTITY_NAME.Click += new System.EventHandler(this.BUTTON_GET_ENTITY_NAME_Click);
            // 
            // BUTTON_SET_ENTITY_NAME
            // 
            this.BUTTON_SET_ENTITY_NAME.Location = new System.Drawing.Point(319, 128);
            this.BUTTON_SET_ENTITY_NAME.Name = "BUTTON_SET_ENTITY_NAME";
            this.BUTTON_SET_ENTITY_NAME.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_SET_ENTITY_NAME.TabIndex = 41;
            this.BUTTON_SET_ENTITY_NAME.Text = "Set";
            this.BUTTON_SET_ENTITY_NAME.UseVisualStyleBackColor = true;
            this.BUTTON_SET_ENTITY_NAME.Click += new System.EventHandler(this.BUTTON_SET_ENTITY_NAME_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Entity Type:";
            // 
            // EDIT_ENTITY_TYPE
            // 
            this.EDIT_ENTITY_TYPE.Location = new System.Drawing.Point(129, 95);
            this.EDIT_ENTITY_TYPE.Name = "EDIT_ENTITY_TYPE";
            this.EDIT_ENTITY_TYPE.Size = new System.Drawing.Size(93, 20);
            this.EDIT_ENTITY_TYPE.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Entity Name:";
            // 
            // EDIT_ENTITY_NAME
            // 
            this.EDIT_ENTITY_NAME.Location = new System.Drawing.Point(129, 130);
            this.EDIT_ENTITY_NAME.Name = "EDIT_ENTITY_NAME";
            this.EDIT_ENTITY_NAME.Size = new System.Drawing.Size(93, 20);
            this.EDIT_ENTITY_NAME.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mark Beat Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "ID:";
            // 
            // EDIT_ID
            // 
            this.EDIT_ID.Location = new System.Drawing.Point(129, 44);
            this.EDIT_ID.Name = "EDIT_ID";
            this.EDIT_ID.Size = new System.Drawing.Size(93, 20);
            this.EDIT_ID.TabIndex = 18;
            this.EDIT_ID.Text = "0";
            // 
            // BUTTON_GET_MARK_BEAT_COUNT
            // 
            this.BUTTON_GET_MARK_BEAT_COUNT.Location = new System.Drawing.Point(245, 167);
            this.BUTTON_GET_MARK_BEAT_COUNT.Name = "BUTTON_GET_MARK_BEAT_COUNT";
            this.BUTTON_GET_MARK_BEAT_COUNT.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_GET_MARK_BEAT_COUNT.TabIndex = 16;
            this.BUTTON_GET_MARK_BEAT_COUNT.Text = "Get";
            this.BUTTON_GET_MARK_BEAT_COUNT.UseVisualStyleBackColor = true;
            this.BUTTON_GET_MARK_BEAT_COUNT.Click += new System.EventHandler(this.BUTTON_GET_MARK_BEAT_COUNT_Click);
            // 
            // BUTTON_CHANGE_MARK_BEAT_COUNT
            // 
            this.BUTTON_CHANGE_MARK_BEAT_COUNT.Location = new System.Drawing.Point(319, 166);
            this.BUTTON_CHANGE_MARK_BEAT_COUNT.Name = "BUTTON_CHANGE_MARK_BEAT_COUNT";
            this.BUTTON_CHANGE_MARK_BEAT_COUNT.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_MARK_BEAT_COUNT.TabIndex = 15;
            this.BUTTON_CHANGE_MARK_BEAT_COUNT.Text = "Set";
            this.BUTTON_CHANGE_MARK_BEAT_COUNT.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_MARK_BEAT_COUNT.Click += new System.EventHandler(this.BUTTON_CHANGE_MARK_BEAT_COUNT_Click);
            // 
            // EDIT_MARK_BEAT_COUNT
            // 
            this.EDIT_MARK_BEAT_COUNT.Location = new System.Drawing.Point(129, 169);
            this.EDIT_MARK_BEAT_COUNT.Name = "EDIT_MARK_BEAT_COUNT";
            this.EDIT_MARK_BEAT_COUNT.Size = new System.Drawing.Size(93, 20);
            this.EDIT_MARK_BEAT_COUNT.TabIndex = 14;
            this.EDIT_MARK_BEAT_COUNT.Text = "0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // entities_by_id_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.groupBox13);
            this.Name = "entities_by_id_frm";
            this.Text = "Entities by ID";
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox EDIT_ID;
        private System.Windows.Forms.Button BUTTON_GET_MARK_BEAT_COUNT;
        private System.Windows.Forms.Button BUTTON_CHANGE_MARK_BEAT_COUNT;
        private System.Windows.Forms.TextBox EDIT_MARK_BEAT_COUNT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EDIT_ENTITY_TYPE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EDIT_ENTITY_NAME;
        private System.Windows.Forms.Button BUTTON_GET_ENTITY_TYPE;
        private System.Windows.Forms.Button BUTTON_GET_ENTITY_NAME;
        private System.Windows.Forms.Button BUTTON_SET_ENTITY_NAME;
        private System.Windows.Forms.CheckBox checkBox_top_level_entity;
        private System.Windows.Forms.Button button_access_by_id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_change_path;
        private System.Windows.Forms.TextBox EDIT_FILE_PATH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_access_by_id;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}