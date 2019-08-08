namespace samlight_client_csharp
{
    partial class entity_info_frm
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BUTTON_GET_OUTLINE = new System.Windows.Forms.Button();
            this.EDIT_OUTLINE_MAX_Z = new System.Windows.Forms.TextBox();
            this.EDIT_OUTLINE_MAX_Y = new System.Windows.Forms.TextBox();
            this.EDIT_OUTLINE_MAX_X = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.EDIT_OUTLINE_MIN_Z = new System.Windows.Forms.TextBox();
            this.EDIT_OUTLINE_MIN_Y = new System.Windows.Forms.TextBox();
            this.EDIT_OUTLINE_MIN_X = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EDIT_ENTITY_NAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.BUTTON_GET_MARK_BEAT_OFFSET = new System.Windows.Forms.Button();
            this.BUTTON_CHANGE_MARK_BEAT_OFFSET = new System.Windows.Forms.Button();
            this.EDIT_MARK_BEAT_OFFSET = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.BUTTON_GET_MARK_BEAT_COUNT = new System.Windows.Forms.Button();
            this.BUTTON_CHANGE_MARK_BEAT_COUNT = new System.Windows.Forms.Button();
            this.EDIT_MARK_BEAT_COUNT = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.BUTTON_GET_MARK_LOOP_COUNT = new System.Windows.Forms.Button();
            this.BUTTON_CHANGE_MARK_LOOP_COUNT = new System.Windows.Forms.Button();
            this.EDIT_MARK_LOOP_COUNT = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox7.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.BUTTON_GET_OUTLINE);
            this.groupBox7.Controls.Add(this.EDIT_OUTLINE_MAX_Z);
            this.groupBox7.Controls.Add(this.EDIT_OUTLINE_MAX_Y);
            this.groupBox7.Controls.Add(this.EDIT_OUTLINE_MAX_X);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.EDIT_OUTLINE_MIN_Z);
            this.groupBox7.Controls.Add(this.EDIT_OUTLINE_MIN_Y);
            this.groupBox7.Controls.Add(this.EDIT_OUTLINE_MIN_X);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Location = new System.Drawing.Point(23, 234);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(367, 109);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Outline By Name";
            // 
            // BUTTON_GET_OUTLINE
            // 
            this.BUTTON_GET_OUTLINE.Location = new System.Drawing.Point(256, 48);
            this.BUTTON_GET_OUTLINE.Name = "BUTTON_GET_OUTLINE";
            this.BUTTON_GET_OUTLINE.Size = new System.Drawing.Size(93, 23);
            this.BUTTON_GET_OUTLINE.TabIndex = 24;
            this.BUTTON_GET_OUTLINE.Text = "Get Outline";
            this.BUTTON_GET_OUTLINE.UseVisualStyleBackColor = true;
            this.BUTTON_GET_OUTLINE.Click += new System.EventHandler(this.BUTTON_GET_OUTLINE_Click);
            // 
            // EDIT_OUTLINE_MAX_Z
            // 
            this.EDIT_OUTLINE_MAX_Z.Location = new System.Drawing.Point(176, 76);
            this.EDIT_OUTLINE_MAX_Z.Name = "EDIT_OUTLINE_MAX_Z";
            this.EDIT_OUTLINE_MAX_Z.ReadOnly = true;
            this.EDIT_OUTLINE_MAX_Z.Size = new System.Drawing.Size(47, 20);
            this.EDIT_OUTLINE_MAX_Z.TabIndex = 18;
            this.EDIT_OUTLINE_MAX_Z.Text = "0";
            // 
            // EDIT_OUTLINE_MAX_Y
            // 
            this.EDIT_OUTLINE_MAX_Y.Location = new System.Drawing.Point(175, 51);
            this.EDIT_OUTLINE_MAX_Y.Name = "EDIT_OUTLINE_MAX_Y";
            this.EDIT_OUTLINE_MAX_Y.ReadOnly = true;
            this.EDIT_OUTLINE_MAX_Y.Size = new System.Drawing.Size(48, 20);
            this.EDIT_OUTLINE_MAX_Y.TabIndex = 17;
            this.EDIT_OUTLINE_MAX_Y.Text = "0";
            // 
            // EDIT_OUTLINE_MAX_X
            // 
            this.EDIT_OUTLINE_MAX_X.Location = new System.Drawing.Point(174, 27);
            this.EDIT_OUTLINE_MAX_X.Name = "EDIT_OUTLINE_MAX_X";
            this.EDIT_OUTLINE_MAX_X.ReadOnly = true;
            this.EDIT_OUTLINE_MAX_X.Size = new System.Drawing.Size(49, 20);
            this.EDIT_OUTLINE_MAX_X.TabIndex = 16;
            this.EDIT_OUTLINE_MAX_X.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(125, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "max_y:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(125, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "max_z:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(125, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "max_x:";
            // 
            // EDIT_OUTLINE_MIN_Z
            // 
            this.EDIT_OUTLINE_MIN_Z.Location = new System.Drawing.Point(59, 76);
            this.EDIT_OUTLINE_MIN_Z.Name = "EDIT_OUTLINE_MIN_Z";
            this.EDIT_OUTLINE_MIN_Z.ReadOnly = true;
            this.EDIT_OUTLINE_MIN_Z.Size = new System.Drawing.Size(47, 20);
            this.EDIT_OUTLINE_MIN_Z.TabIndex = 12;
            this.EDIT_OUTLINE_MIN_Z.Text = "0";
            // 
            // EDIT_OUTLINE_MIN_Y
            // 
            this.EDIT_OUTLINE_MIN_Y.Location = new System.Drawing.Point(58, 51);
            this.EDIT_OUTLINE_MIN_Y.Name = "EDIT_OUTLINE_MIN_Y";
            this.EDIT_OUTLINE_MIN_Y.ReadOnly = true;
            this.EDIT_OUTLINE_MIN_Y.Size = new System.Drawing.Size(48, 20);
            this.EDIT_OUTLINE_MIN_Y.TabIndex = 11;
            this.EDIT_OUTLINE_MIN_Y.Text = "0";
            // 
            // EDIT_OUTLINE_MIN_X
            // 
            this.EDIT_OUTLINE_MIN_X.Location = new System.Drawing.Point(57, 27);
            this.EDIT_OUTLINE_MIN_X.Name = "EDIT_OUTLINE_MIN_X";
            this.EDIT_OUTLINE_MIN_X.ReadOnly = true;
            this.EDIT_OUTLINE_MIN_X.Size = new System.Drawing.Size(49, 20);
            this.EDIT_OUTLINE_MIN_X.TabIndex = 10;
            this.EDIT_OUTLINE_MIN_X.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "min_y:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "min_z:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "min_x:";
            // 
            // EDIT_ENTITY_NAME
            // 
            this.EDIT_ENTITY_NAME.Location = new System.Drawing.Point(199, 37);
            this.EDIT_ENTITY_NAME.Name = "EDIT_ENTITY_NAME";
            this.EDIT_ENTITY_NAME.Size = new System.Drawing.Size(113, 20);
            this.EDIT_ENTITY_NAME.TabIndex = 22;
            this.EDIT_ENTITY_NAME.Text = "test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Entity Name";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.BUTTON_GET_MARK_BEAT_OFFSET);
            this.groupBox13.Controls.Add(this.BUTTON_CHANGE_MARK_BEAT_OFFSET);
            this.groupBox13.Controls.Add(this.EDIT_MARK_BEAT_OFFSET);
            this.groupBox13.Controls.Add(this.label22);
            this.groupBox13.Controls.Add(this.BUTTON_GET_MARK_BEAT_COUNT);
            this.groupBox13.Controls.Add(this.BUTTON_CHANGE_MARK_BEAT_COUNT);
            this.groupBox13.Controls.Add(this.EDIT_MARK_BEAT_COUNT);
            this.groupBox13.Controls.Add(this.label21);
            this.groupBox13.Controls.Add(this.BUTTON_GET_MARK_LOOP_COUNT);
            this.groupBox13.Controls.Add(this.BUTTON_CHANGE_MARK_LOOP_COUNT);
            this.groupBox13.Controls.Add(this.EDIT_MARK_LOOP_COUNT);
            this.groupBox13.Controls.Add(this.label20);
            this.groupBox13.Location = new System.Drawing.Point(12, 74);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(381, 141);
            this.groupBox13.TabIndex = 33;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Entity Info";
            // 
            // BUTTON_GET_MARK_BEAT_OFFSET
            // 
            this.BUTTON_GET_MARK_BEAT_OFFSET.Location = new System.Drawing.Point(217, 88);
            this.BUTTON_GET_MARK_BEAT_OFFSET.Name = "BUTTON_GET_MARK_BEAT_OFFSET";
            this.BUTTON_GET_MARK_BEAT_OFFSET.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_GET_MARK_BEAT_OFFSET.TabIndex = 24;
            this.BUTTON_GET_MARK_BEAT_OFFSET.Text = "Get";
            this.BUTTON_GET_MARK_BEAT_OFFSET.UseVisualStyleBackColor = true;
            this.BUTTON_GET_MARK_BEAT_OFFSET.Click += new System.EventHandler(this.BUTTON_GET_MARK_BEAT_OFFSET_Click);
            // 
            // BUTTON_CHANGE_MARK_BEAT_OFFSET
            // 
            this.BUTTON_CHANGE_MARK_BEAT_OFFSET.Location = new System.Drawing.Point(293, 89);
            this.BUTTON_CHANGE_MARK_BEAT_OFFSET.Name = "BUTTON_CHANGE_MARK_BEAT_OFFSET";
            this.BUTTON_CHANGE_MARK_BEAT_OFFSET.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_MARK_BEAT_OFFSET.TabIndex = 23;
            this.BUTTON_CHANGE_MARK_BEAT_OFFSET.Text = "Set";
            this.BUTTON_CHANGE_MARK_BEAT_OFFSET.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_MARK_BEAT_OFFSET.Click += new System.EventHandler(this.BUTTON_CHANGE_MARK_BEAT_OFFSET_Click);
            // 
            // EDIT_MARK_BEAT_OFFSET
            // 
            this.EDIT_MARK_BEAT_OFFSET.Location = new System.Drawing.Point(129, 90);
            this.EDIT_MARK_BEAT_OFFSET.Name = "EDIT_MARK_BEAT_OFFSET";
            this.EDIT_MARK_BEAT_OFFSET.Size = new System.Drawing.Size(73, 20);
            this.EDIT_MARK_BEAT_OFFSET.TabIndex = 22;
            this.EDIT_MARK_BEAT_OFFSET.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 96);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "Mark Beat Offset:";
            // 
            // BUTTON_GET_MARK_BEAT_COUNT
            // 
            this.BUTTON_GET_MARK_BEAT_COUNT.Location = new System.Drawing.Point(217, 58);
            this.BUTTON_GET_MARK_BEAT_COUNT.Name = "BUTTON_GET_MARK_BEAT_COUNT";
            this.BUTTON_GET_MARK_BEAT_COUNT.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_GET_MARK_BEAT_COUNT.TabIndex = 20;
            this.BUTTON_GET_MARK_BEAT_COUNT.Text = "Get";
            this.BUTTON_GET_MARK_BEAT_COUNT.UseVisualStyleBackColor = true;
            this.BUTTON_GET_MARK_BEAT_COUNT.Click += new System.EventHandler(this.BUTTON_GET_MARK_BEAT_COUNT_Click);
            // 
            // BUTTON_CHANGE_MARK_BEAT_COUNT
            // 
            this.BUTTON_CHANGE_MARK_BEAT_COUNT.Location = new System.Drawing.Point(293, 59);
            this.BUTTON_CHANGE_MARK_BEAT_COUNT.Name = "BUTTON_CHANGE_MARK_BEAT_COUNT";
            this.BUTTON_CHANGE_MARK_BEAT_COUNT.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_MARK_BEAT_COUNT.TabIndex = 19;
            this.BUTTON_CHANGE_MARK_BEAT_COUNT.Text = "Set";
            this.BUTTON_CHANGE_MARK_BEAT_COUNT.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_MARK_BEAT_COUNT.Click += new System.EventHandler(this.BUTTON_CHANGE_MARK_BEAT_COUNT_Click);
            // 
            // EDIT_MARK_BEAT_COUNT
            // 
            this.EDIT_MARK_BEAT_COUNT.Location = new System.Drawing.Point(129, 60);
            this.EDIT_MARK_BEAT_COUNT.Name = "EDIT_MARK_BEAT_COUNT";
            this.EDIT_MARK_BEAT_COUNT.Size = new System.Drawing.Size(73, 20);
            this.EDIT_MARK_BEAT_COUNT.TabIndex = 18;
            this.EDIT_MARK_BEAT_COUNT.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 66);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Mark Beat Count:";
            // 
            // BUTTON_GET_MARK_LOOP_COUNT
            // 
            this.BUTTON_GET_MARK_LOOP_COUNT.Location = new System.Drawing.Point(217, 27);
            this.BUTTON_GET_MARK_LOOP_COUNT.Name = "BUTTON_GET_MARK_LOOP_COUNT";
            this.BUTTON_GET_MARK_LOOP_COUNT.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_GET_MARK_LOOP_COUNT.TabIndex = 16;
            this.BUTTON_GET_MARK_LOOP_COUNT.Text = "Get";
            this.BUTTON_GET_MARK_LOOP_COUNT.UseVisualStyleBackColor = true;
            this.BUTTON_GET_MARK_LOOP_COUNT.Click += new System.EventHandler(this.BUTTON_GET_MARK_LOOP_COUNT_Click);
            // 
            // BUTTON_CHANGE_MARK_LOOP_COUNT
            // 
            this.BUTTON_CHANGE_MARK_LOOP_COUNT.Location = new System.Drawing.Point(293, 28);
            this.BUTTON_CHANGE_MARK_LOOP_COUNT.Name = "BUTTON_CHANGE_MARK_LOOP_COUNT";
            this.BUTTON_CHANGE_MARK_LOOP_COUNT.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_MARK_LOOP_COUNT.TabIndex = 15;
            this.BUTTON_CHANGE_MARK_LOOP_COUNT.Text = "Set";
            this.BUTTON_CHANGE_MARK_LOOP_COUNT.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_MARK_LOOP_COUNT.Click += new System.EventHandler(this.BUTTON_CHANGE_MARK_LOOP_COUNT_Click);
            // 
            // EDIT_MARK_LOOP_COUNT
            // 
            this.EDIT_MARK_LOOP_COUNT.Location = new System.Drawing.Point(129, 30);
            this.EDIT_MARK_LOOP_COUNT.Name = "EDIT_MARK_LOOP_COUNT";
            this.EDIT_MARK_LOOP_COUNT.Size = new System.Drawing.Size(73, 20);
            this.EDIT_MARK_LOOP_COUNT.TabIndex = 14;
            this.EDIT_MARK_LOOP_COUNT.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Mark Loop Count:";
            // 
            // entity_info_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 399);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.EDIT_ENTITY_NAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox7);
            this.Name = "entity_info_frm";
            this.Text = "Entity Info";
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button BUTTON_GET_OUTLINE;
        private System.Windows.Forms.TextBox EDIT_OUTLINE_MAX_Z;
        private System.Windows.Forms.TextBox EDIT_OUTLINE_MAX_Y;
        private System.Windows.Forms.TextBox EDIT_OUTLINE_MAX_X;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox EDIT_OUTLINE_MIN_Z;
        private System.Windows.Forms.TextBox EDIT_OUTLINE_MIN_Y;
        private System.Windows.Forms.TextBox EDIT_OUTLINE_MIN_X;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EDIT_ENTITY_NAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button BUTTON_GET_MARK_BEAT_OFFSET;
        private System.Windows.Forms.Button BUTTON_CHANGE_MARK_BEAT_OFFSET;
        private System.Windows.Forms.TextBox EDIT_MARK_BEAT_OFFSET;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button BUTTON_GET_MARK_BEAT_COUNT;
        private System.Windows.Forms.Button BUTTON_CHANGE_MARK_BEAT_COUNT;
        private System.Windows.Forms.TextBox EDIT_MARK_BEAT_COUNT;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button BUTTON_GET_MARK_LOOP_COUNT;
        private System.Windows.Forms.Button BUTTON_CHANGE_MARK_LOOP_COUNT;
        private System.Windows.Forms.TextBox EDIT_MARK_LOOP_COUNT;
        private System.Windows.Forms.Label label20;
    }
}