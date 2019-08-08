namespace samlight_client_csharp
{
    partial class mark_frm
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
            this.label3 = new System.Windows.Forms.Label();
            this.BUTTON_GET_LAST_MARK_TIME = new System.Windows.Forms.Button();
            this.BUTTON_RESET_SEQUENCE = new System.Windows.Forms.Button();
            this.BUTTON_ROTATE_TEST = new System.Windows.Forms.Button();
            this.BUTTON_MARK_SELECTED_ENTITIES = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.CHECK_MARK_HATCH = new System.Windows.Forms.CheckBox();
            this.CHECK_MARK_CONTOUR = new System.Windows.Forms.CheckBox();
            this.BUTTON_SET_MARK_FLAGS = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.STATIC_IS_MARKING = new System.Windows.Forms.Label();
            this.BUTTON_MARK_ALL = new System.Windows.Forms.Button();
            this.BUTTON_MARK_ENTITY = new System.Windows.Forms.Button();
            this.BUTTON_STOP = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.BUTTON_3D_MARK = new System.Windows.Forms.Button();
            this.BUTTON_GET_SLICE_TO = new System.Windows.Forms.Button();
            this.BUTTON_CHANGE_SLICE_TO = new System.Windows.Forms.Button();
            this.EDIT_SLICE_TO = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.BUTTON_GET_SLICE_FROM = new System.Windows.Forms.Button();
            this.BUTTON_CHANGE_SLICE_FROM = new System.Windows.Forms.Button();
            this.EDIT_SLICE_FROM = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox8.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // EDIT_ENTITY_NAME
            // 
            this.EDIT_ENTITY_NAME.Location = new System.Drawing.Point(123, 36);
            this.EDIT_ENTITY_NAME.Name = "EDIT_ENTITY_NAME";
            this.EDIT_ENTITY_NAME.Size = new System.Drawing.Size(113, 20);
            this.EDIT_ENTITY_NAME.TabIndex = 15;
            this.EDIT_ENTITY_NAME.Text = "test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Entity Name";
            // 
            // BUTTON_GET_LAST_MARK_TIME
            // 
            this.BUTTON_GET_LAST_MARK_TIME.Location = new System.Drawing.Point(51, 79);
            this.BUTTON_GET_LAST_MARK_TIME.Name = "BUTTON_GET_LAST_MARK_TIME";
            this.BUTTON_GET_LAST_MARK_TIME.Size = new System.Drawing.Size(163, 23);
            this.BUTTON_GET_LAST_MARK_TIME.TabIndex = 29;
            this.BUTTON_GET_LAST_MARK_TIME.Text = "Get last mark time";
            this.BUTTON_GET_LAST_MARK_TIME.UseVisualStyleBackColor = true;
            this.BUTTON_GET_LAST_MARK_TIME.Click += new System.EventHandler(this.BUTTON_GET_LAST_MARK_TIME_Click);
            // 
            // BUTTON_RESET_SEQUENCE
            // 
            this.BUTTON_RESET_SEQUENCE.Location = new System.Drawing.Point(51, 108);
            this.BUTTON_RESET_SEQUENCE.Name = "BUTTON_RESET_SEQUENCE";
            this.BUTTON_RESET_SEQUENCE.Size = new System.Drawing.Size(163, 23);
            this.BUTTON_RESET_SEQUENCE.TabIndex = 28;
            this.BUTTON_RESET_SEQUENCE.Text = "Reset Sequence";
            this.BUTTON_RESET_SEQUENCE.UseVisualStyleBackColor = true;
            this.BUTTON_RESET_SEQUENCE.Click += new System.EventHandler(this.BUTTON_RESET_SEQUENCE_Click);
            // 
            // BUTTON_ROTATE_TEST
            // 
            this.BUTTON_ROTATE_TEST.Location = new System.Drawing.Point(231, 79);
            this.BUTTON_ROTATE_TEST.Name = "BUTTON_ROTATE_TEST";
            this.BUTTON_ROTATE_TEST.Size = new System.Drawing.Size(163, 23);
            this.BUTTON_ROTATE_TEST.TabIndex = 30;
            this.BUTTON_ROTATE_TEST.Text = "Rotate and Mark 20times";
            this.BUTTON_ROTATE_TEST.UseVisualStyleBackColor = true;
            this.BUTTON_ROTATE_TEST.Click += new System.EventHandler(this.BUTTON_ROTATE_TEST_Click);
            // 
            // BUTTON_MARK_SELECTED_ENTITIES
            // 
            this.BUTTON_MARK_SELECTED_ENTITIES.Location = new System.Drawing.Point(231, 108);
            this.BUTTON_MARK_SELECTED_ENTITIES.Name = "BUTTON_MARK_SELECTED_ENTITIES";
            this.BUTTON_MARK_SELECTED_ENTITIES.Size = new System.Drawing.Size(163, 23);
            this.BUTTON_MARK_SELECTED_ENTITIES.TabIndex = 31;
            this.BUTTON_MARK_SELECTED_ENTITIES.Text = "Mark Selected Entities";
            this.BUTTON_MARK_SELECTED_ENTITIES.UseVisualStyleBackColor = true;
            this.BUTTON_MARK_SELECTED_ENTITIES.Click += new System.EventHandler(this.BUTTON_MARK_SELECTED_ENTITIES_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.CHECK_MARK_HATCH);
            this.groupBox8.Controls.Add(this.CHECK_MARK_CONTOUR);
            this.groupBox8.Controls.Add(this.BUTTON_SET_MARK_FLAGS);
            this.groupBox8.Location = new System.Drawing.Point(35, 245);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(381, 65);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Mark Flags By Name ";
            // 
            // CHECK_MARK_HATCH
            // 
            this.CHECK_MARK_HATCH.AutoSize = true;
            this.CHECK_MARK_HATCH.Location = new System.Drawing.Point(124, 28);
            this.CHECK_MARK_HATCH.Name = "CHECK_MARK_HATCH";
            this.CHECK_MARK_HATCH.Size = new System.Drawing.Size(82, 17);
            this.CHECK_MARK_HATCH.TabIndex = 24;
            this.CHECK_MARK_HATCH.Text = "Mark Hatch";
            this.CHECK_MARK_HATCH.UseVisualStyleBackColor = true;
            // 
            // CHECK_MARK_CONTOUR
            // 
            this.CHECK_MARK_CONTOUR.AutoSize = true;
            this.CHECK_MARK_CONTOUR.Location = new System.Drawing.Point(17, 28);
            this.CHECK_MARK_CONTOUR.Name = "CHECK_MARK_CONTOUR";
            this.CHECK_MARK_CONTOUR.Size = new System.Drawing.Size(90, 17);
            this.CHECK_MARK_CONTOUR.TabIndex = 23;
            this.CHECK_MARK_CONTOUR.Text = "Mark Contour";
            this.CHECK_MARK_CONTOUR.UseVisualStyleBackColor = true;
            // 
            // BUTTON_SET_MARK_FLAGS
            // 
            this.BUTTON_SET_MARK_FLAGS.Location = new System.Drawing.Point(288, 22);
            this.BUTTON_SET_MARK_FLAGS.Name = "BUTTON_SET_MARK_FLAGS";
            this.BUTTON_SET_MARK_FLAGS.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_SET_MARK_FLAGS.TabIndex = 22;
            this.BUTTON_SET_MARK_FLAGS.Text = "Set";
            this.BUTTON_SET_MARK_FLAGS.UseVisualStyleBackColor = true;
            this.BUTTON_SET_MARK_FLAGS.Click += new System.EventHandler(this.BUTTON_SET_MARK_FLAGS_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.STATIC_IS_MARKING);
            this.groupBox11.Controls.Add(this.BUTTON_MARK_ALL);
            this.groupBox11.Controls.Add(this.BUTTON_MARK_ENTITY);
            this.groupBox11.Controls.Add(this.BUTTON_STOP);
            this.groupBox11.Location = new System.Drawing.Point(35, 160);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(381, 68);
            this.groupBox11.TabIndex = 33;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "ScMarkEntityByName";
            // 
            // STATIC_IS_MARKING
            // 
            this.STATIC_IS_MARKING.AutoSize = true;
            this.STATIC_IS_MARKING.Location = new System.Drawing.Point(195, 35);
            this.STATIC_IS_MARKING.Name = "STATIC_IS_MARKING";
            this.STATIC_IS_MARKING.Size = new System.Drawing.Size(56, 13);
            this.STATIC_IS_MARKING.TabIndex = 28;
            this.STATIC_IS_MARKING.Text = "Is Marking";
            // 
            // BUTTON_MARK_ALL
            // 
            this.BUTTON_MARK_ALL.Location = new System.Drawing.Point(104, 30);
            this.BUTTON_MARK_ALL.Name = "BUTTON_MARK_ALL";
            this.BUTTON_MARK_ALL.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_MARK_ALL.TabIndex = 27;
            this.BUTTON_MARK_ALL.Text = "Mark All";
            this.BUTTON_MARK_ALL.UseVisualStyleBackColor = true;
            this.BUTTON_MARK_ALL.Click += new System.EventHandler(this.BUTTON_MARK_ALL_Click);
            // 
            // BUTTON_MARK_ENTITY
            // 
            this.BUTTON_MARK_ENTITY.Location = new System.Drawing.Point(6, 30);
            this.BUTTON_MARK_ENTITY.Name = "BUTTON_MARK_ENTITY";
            this.BUTTON_MARK_ENTITY.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_MARK_ENTITY.TabIndex = 26;
            this.BUTTON_MARK_ENTITY.Text = "Mark Entity";
            this.BUTTON_MARK_ENTITY.UseVisualStyleBackColor = true;
            this.BUTTON_MARK_ENTITY.Click += new System.EventHandler(this.BUTTON_MARK_ENTITY_Click);
            // 
            // BUTTON_STOP
            // 
            this.BUTTON_STOP.Location = new System.Drawing.Point(289, 16);
            this.BUTTON_STOP.Name = "BUTTON_STOP";
            this.BUTTON_STOP.Size = new System.Drawing.Size(63, 46);
            this.BUTTON_STOP.TabIndex = 15;
            this.BUTTON_STOP.Text = "Stop";
            this.BUTTON_STOP.UseVisualStyleBackColor = true;
            this.BUTTON_STOP.Click += new System.EventHandler(this.BUTTON_STOP_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.BUTTON_3D_MARK);
            this.groupBox13.Controls.Add(this.BUTTON_GET_SLICE_TO);
            this.groupBox13.Controls.Add(this.BUTTON_CHANGE_SLICE_TO);
            this.groupBox13.Controls.Add(this.EDIT_SLICE_TO);
            this.groupBox13.Controls.Add(this.label21);
            this.groupBox13.Controls.Add(this.BUTTON_GET_SLICE_FROM);
            this.groupBox13.Controls.Add(this.BUTTON_CHANGE_SLICE_FROM);
            this.groupBox13.Controls.Add(this.EDIT_SLICE_FROM);
            this.groupBox13.Controls.Add(this.label20);
            this.groupBox13.Location = new System.Drawing.Point(35, 333);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(381, 141);
            this.groupBox13.TabIndex = 34;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Mark SAM3D";
            // 
            // BUTTON_3D_MARK
            // 
            this.BUTTON_3D_MARK.Location = new System.Drawing.Point(162, 97);
            this.BUTTON_3D_MARK.Name = "BUTTON_3D_MARK";
            this.BUTTON_3D_MARK.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_3D_MARK.TabIndex = 24;
            this.BUTTON_3D_MARK.Text = "Mark";
            this.BUTTON_3D_MARK.UseVisualStyleBackColor = true;
            this.BUTTON_3D_MARK.Click += new System.EventHandler(this.BUTTON_3D_MARK_Click);
            // 
            // BUTTON_GET_SLICE_TO
            // 
            this.BUTTON_GET_SLICE_TO.Location = new System.Drawing.Point(211, 54);
            this.BUTTON_GET_SLICE_TO.Name = "BUTTON_GET_SLICE_TO";
            this.BUTTON_GET_SLICE_TO.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_GET_SLICE_TO.TabIndex = 20;
            this.BUTTON_GET_SLICE_TO.Text = "Get";
            this.BUTTON_GET_SLICE_TO.UseVisualStyleBackColor = true;
            this.BUTTON_GET_SLICE_TO.Click += new System.EventHandler(this.BUTTON_GET_SLICE_TO_Click);
            // 
            // BUTTON_CHANGE_SLICE_TO
            // 
            this.BUTTON_CHANGE_SLICE_TO.Location = new System.Drawing.Point(287, 55);
            this.BUTTON_CHANGE_SLICE_TO.Name = "BUTTON_CHANGE_SLICE_TO";
            this.BUTTON_CHANGE_SLICE_TO.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_SLICE_TO.TabIndex = 19;
            this.BUTTON_CHANGE_SLICE_TO.Text = "Set";
            this.BUTTON_CHANGE_SLICE_TO.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_SLICE_TO.Click += new System.EventHandler(this.BUTTON_CHANGE_SLICE_TO_Click);
            // 
            // EDIT_SLICE_TO
            // 
            this.EDIT_SLICE_TO.Location = new System.Drawing.Point(89, 56);
            this.EDIT_SLICE_TO.Name = "EDIT_SLICE_TO";
            this.EDIT_SLICE_TO.Size = new System.Drawing.Size(78, 20);
            this.EDIT_SLICE_TO.TabIndex = 18;
            this.EDIT_SLICE_TO.Text = "2";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Slice To:";
            // 
            // BUTTON_GET_SLICE_FROM
            // 
            this.BUTTON_GET_SLICE_FROM.Location = new System.Drawing.Point(211, 27);
            this.BUTTON_GET_SLICE_FROM.Name = "BUTTON_GET_SLICE_FROM";
            this.BUTTON_GET_SLICE_FROM.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_GET_SLICE_FROM.TabIndex = 16;
            this.BUTTON_GET_SLICE_FROM.Text = "Get";
            this.BUTTON_GET_SLICE_FROM.UseVisualStyleBackColor = true;
            this.BUTTON_GET_SLICE_FROM.Click += new System.EventHandler(this.BUTTON_GET_SLICE_FROM_Click);
            // 
            // BUTTON_CHANGE_SLICE_FROM
            // 
            this.BUTTON_CHANGE_SLICE_FROM.Location = new System.Drawing.Point(287, 28);
            this.BUTTON_CHANGE_SLICE_FROM.Name = "BUTTON_CHANGE_SLICE_FROM";
            this.BUTTON_CHANGE_SLICE_FROM.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_SLICE_FROM.TabIndex = 15;
            this.BUTTON_CHANGE_SLICE_FROM.Text = "Set";
            this.BUTTON_CHANGE_SLICE_FROM.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_SLICE_FROM.Click += new System.EventHandler(this.BUTTON_CHANGE_SLICE_FROM_Click);
            // 
            // EDIT_SLICE_FROM
            // 
            this.EDIT_SLICE_FROM.Location = new System.Drawing.Point(89, 30);
            this.EDIT_SLICE_FROM.Name = "EDIT_SLICE_FROM";
            this.EDIT_SLICE_FROM.Size = new System.Drawing.Size(78, 20);
            this.EDIT_SLICE_FROM.TabIndex = 14;
            this.EDIT_SLICE_FROM.Text = "1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Slice From:";
            // 
            // mark_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 511);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.BUTTON_MARK_SELECTED_ENTITIES);
            this.Controls.Add(this.BUTTON_ROTATE_TEST);
            this.Controls.Add(this.BUTTON_GET_LAST_MARK_TIME);
            this.Controls.Add(this.BUTTON_RESET_SEQUENCE);
            this.Controls.Add(this.EDIT_ENTITY_NAME);
            this.Controls.Add(this.label3);
            this.Name = "mark_frm";
            this.Text = "Mark";
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EDIT_ENTITY_NAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BUTTON_GET_LAST_MARK_TIME;
        private System.Windows.Forms.Button BUTTON_RESET_SEQUENCE;
        private System.Windows.Forms.Button BUTTON_ROTATE_TEST;
        private System.Windows.Forms.Button BUTTON_MARK_SELECTED_ENTITIES;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox CHECK_MARK_HATCH;
        private System.Windows.Forms.CheckBox CHECK_MARK_CONTOUR;
        private System.Windows.Forms.Button BUTTON_SET_MARK_FLAGS;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label STATIC_IS_MARKING;
        private System.Windows.Forms.Button BUTTON_MARK_ALL;
        private System.Windows.Forms.Button BUTTON_MARK_ENTITY;
        private System.Windows.Forms.Button BUTTON_STOP;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button BUTTON_3D_MARK;
        private System.Windows.Forms.Button BUTTON_GET_SLICE_TO;
        private System.Windows.Forms.Button BUTTON_CHANGE_SLICE_TO;
        private System.Windows.Forms.TextBox EDIT_SLICE_TO;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button BUTTON_GET_SLICE_FROM;
        private System.Windows.Forms.Button BUTTON_CHANGE_SLICE_FROM;
        private System.Windows.Forms.TextBox EDIT_SLICE_FROM;
        private System.Windows.Forms.Label label20;
    }
}