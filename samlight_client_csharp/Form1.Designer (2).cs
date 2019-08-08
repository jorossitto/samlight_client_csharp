namespace samlight_client_csharp
{
    partial class samlight_client_csharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(samlight_client_csharp));
            this.axScSamlightClientCtrl1 = new AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BUTTON_TEST = new System.Windows.Forms.Button();
            this.EDIT_PORT_SAMLIGHT = new System.Windows.Forms.TextBox();
            this.EDIT_IP_SAMLIGHT = new System.Windows.Forms.TextBox();
            this.BUTTON_DISCONNECT_ETHERNET = new System.Windows.Forms.Button();
            this.BUTTON_CONNECT_ETHERNET = new System.Windows.Forms.Button();
            this.EDIT_STATUS_CONNECTED = new System.Windows.Forms.TextBox();
            this.BUTTON_CLOSE = new System.Windows.Forms.Button();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.BUTTON_ENTITY_INFO = new System.Windows.Forms.Button();
            this.BUTTON_FLASH_CALLS = new System.Windows.Forms.Button();
            this.BUTTON_MOVE_ENTITIES = new System.Windows.Forms.Button();
            this.BUTTON_HATCH = new System.Windows.Forms.Button();
            this.BUTTON_BITMAP = new System.Windows.Forms.Button();
            this.BUTTON_MARK = new System.Windows.Forms.Button();
            this.BUTTON_LOAD_AND_SAVE = new System.Windows.Forms.Button();
            this.BUTTON_TEXT = new System.Windows.Forms.Button();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.BUTTON_MOTION = new System.Windows.Forms.Button();
            this.BUTTON_SCREEN_SHOTS = new System.Windows.Forms.Button();
            this.BUTTON_ENTITIES_BY_ID = new System.Windows.Forms.Button();
            this.BUTTON_INPUT_OUTPUT = new System.Windows.Forms.Button();
            this.BUTTON_SETTINGS = new System.Windows.Forms.Button();
            this.BUTTON_PENS = new System.Windows.Forms.Button();
            this.BUTTON_OPTIMIZE_PERFORMANCE = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axScSamlightClientCtrl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.SuspendLayout();
            // 
            // axScSamlightClientCtrl1
            // 
            this.axScSamlightClientCtrl1.Enabled = true;
            this.axScSamlightClientCtrl1.Location = new System.Drawing.Point(53, 530);
            this.axScSamlightClientCtrl1.Name = "axScSamlightClientCtrl1";
            this.axScSamlightClientCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axScSamlightClientCtrl1.OcxState")));
            this.axScSamlightClientCtrl1.Size = new System.Drawing.Size(64, 27);
            this.axScSamlightClientCtrl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BUTTON_TEST);
            this.groupBox1.Location = new System.Drawing.Point(159, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ethernet";
            // 
            // BUTTON_TEST
            // 
            this.BUTTON_TEST.Location = new System.Drawing.Point(143, 109);
            this.BUTTON_TEST.Name = "BUTTON_TEST";
            this.BUTTON_TEST.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_TEST.TabIndex = 25;
            this.BUTTON_TEST.Text = "Test";
            this.BUTTON_TEST.UseVisualStyleBackColor = true;
            this.BUTTON_TEST.Click += new System.EventHandler(this.BUTTON_TEST_Click);
            // 
            // EDIT_PORT_SAMLIGHT
            // 
            this.EDIT_PORT_SAMLIGHT.Location = new System.Drawing.Point(395, 65);
            this.EDIT_PORT_SAMLIGHT.Name = "EDIT_PORT_SAMLIGHT";
            this.EDIT_PORT_SAMLIGHT.Size = new System.Drawing.Size(67, 20);
            this.EDIT_PORT_SAMLIGHT.TabIndex = 13;
            this.EDIT_PORT_SAMLIGHT.Text = "1024";
            // 
            // EDIT_IP_SAMLIGHT
            // 
            this.EDIT_IP_SAMLIGHT.Location = new System.Drawing.Point(232, 65);
            this.EDIT_IP_SAMLIGHT.Name = "EDIT_IP_SAMLIGHT";
            this.EDIT_IP_SAMLIGHT.Size = new System.Drawing.Size(85, 20);
            this.EDIT_IP_SAMLIGHT.TabIndex = 12;
            this.EDIT_IP_SAMLIGHT.Text = "127.0.0.1";
            // 
            // BUTTON_DISCONNECT_ETHERNET
            // 
            this.BUTTON_DISCONNECT_ETHERNET.Location = new System.Drawing.Point(428, 99);
            this.BUTTON_DISCONNECT_ETHERNET.Name = "BUTTON_DISCONNECT_ETHERNET";
            this.BUTTON_DISCONNECT_ETHERNET.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_DISCONNECT_ETHERNET.TabIndex = 9;
            this.BUTTON_DISCONNECT_ETHERNET.Text = "Disconnect";
            this.BUTTON_DISCONNECT_ETHERNET.UseVisualStyleBackColor = true;
            this.BUTTON_DISCONNECT_ETHERNET.Click += new System.EventHandler(this.BUTTON_DISCONNECT_ETHERNET_Click);
            // 
            // BUTTON_CONNECT_ETHERNET
            // 
            this.BUTTON_CONNECT_ETHERNET.Location = new System.Drawing.Point(184, 99);
            this.BUTTON_CONNECT_ETHERNET.Name = "BUTTON_CONNECT_ETHERNET";
            this.BUTTON_CONNECT_ETHERNET.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_CONNECT_ETHERNET.TabIndex = 8;
            this.BUTTON_CONNECT_ETHERNET.Text = "Connect";
            this.BUTTON_CONNECT_ETHERNET.UseVisualStyleBackColor = true;
            this.BUTTON_CONNECT_ETHERNET.Click += new System.EventHandler(this.BUTTON_CONNECT_ETHERNET_Click);
            // 
            // EDIT_STATUS_CONNECTED
            // 
            this.EDIT_STATUS_CONNECTED.Location = new System.Drawing.Point(294, 101);
            this.EDIT_STATUS_CONNECTED.Name = "EDIT_STATUS_CONNECTED";
            this.EDIT_STATUS_CONNECTED.ReadOnly = true;
            this.EDIT_STATUS_CONNECTED.Size = new System.Drawing.Size(91, 20);
            this.EDIT_STATUS_CONNECTED.TabIndex = 5;
            // 
            // BUTTON_CLOSE
            // 
            this.BUTTON_CLOSE.Location = new System.Drawing.Point(545, 530);
            this.BUTTON_CLOSE.Name = "BUTTON_CLOSE";
            this.BUTTON_CLOSE.Size = new System.Drawing.Size(93, 23);
            this.BUTTON_CLOSE.TabIndex = 24;
            this.BUTTON_CLOSE.Text = "Close";
            this.BUTTON_CLOSE.UseVisualStyleBackColor = true;
            this.BUTTON_CLOSE.Click += new System.EventHandler(this.BUTTON_CLOSE_Click);
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.BUTTON_ENTITY_INFO);
            this.groupBox18.Controls.Add(this.BUTTON_FLASH_CALLS);
            this.groupBox18.Controls.Add(this.BUTTON_MOVE_ENTITIES);
            this.groupBox18.Controls.Add(this.BUTTON_HATCH);
            this.groupBox18.Controls.Add(this.BUTTON_BITMAP);
            this.groupBox18.Controls.Add(this.BUTTON_MARK);
            this.groupBox18.Controls.Add(this.BUTTON_LOAD_AND_SAVE);
            this.groupBox18.Controls.Add(this.BUTTON_TEXT);
            this.groupBox18.Location = new System.Drawing.Point(53, 201);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(252, 277);
            this.groupBox18.TabIndex = 35;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Change Entities";
            // 
            // BUTTON_ENTITY_INFO
            // 
            this.BUTTON_ENTITY_INFO.Location = new System.Drawing.Point(137, 209);
            this.BUTTON_ENTITY_INFO.Name = "BUTTON_ENTITY_INFO";
            this.BUTTON_ENTITY_INFO.Size = new System.Drawing.Size(89, 34);
            this.BUTTON_ENTITY_INFO.TabIndex = 33;
            this.BUTTON_ENTITY_INFO.Text = "Entity Info";
            this.BUTTON_ENTITY_INFO.UseVisualStyleBackColor = true;
            this.BUTTON_ENTITY_INFO.Click += new System.EventHandler(this.BUTTON_ENTITY_INFO_Click);
            // 
            // BUTTON_FLASH_CALLS
            // 
            this.BUTTON_FLASH_CALLS.Location = new System.Drawing.Point(137, 157);
            this.BUTTON_FLASH_CALLS.Name = "BUTTON_FLASH_CALLS";
            this.BUTTON_FLASH_CALLS.Size = new System.Drawing.Size(89, 34);
            this.BUTTON_FLASH_CALLS.TabIndex = 32;
            this.BUTTON_FLASH_CALLS.Text = "Flash Calls";
            this.BUTTON_FLASH_CALLS.UseVisualStyleBackColor = true;
            this.BUTTON_FLASH_CALLS.Click += new System.EventHandler(this.BUTTON_FLASH_CALLS_Click);
            // 
            // BUTTON_MOVE_ENTITIES
            // 
            this.BUTTON_MOVE_ENTITIES.Location = new System.Drawing.Point(137, 104);
            this.BUTTON_MOVE_ENTITIES.Name = "BUTTON_MOVE_ENTITIES";
            this.BUTTON_MOVE_ENTITIES.Size = new System.Drawing.Size(89, 34);
            this.BUTTON_MOVE_ENTITIES.TabIndex = 31;
            this.BUTTON_MOVE_ENTITIES.Text = "Transform";
            this.BUTTON_MOVE_ENTITIES.UseVisualStyleBackColor = true;
            this.BUTTON_MOVE_ENTITIES.Click += new System.EventHandler(this.BUTTON_MOVE_ENTITIES_Click);
            // 
            // BUTTON_HATCH
            // 
            this.BUTTON_HATCH.Location = new System.Drawing.Point(137, 51);
            this.BUTTON_HATCH.Name = "BUTTON_HATCH";
            this.BUTTON_HATCH.Size = new System.Drawing.Size(89, 34);
            this.BUTTON_HATCH.TabIndex = 30;
            this.BUTTON_HATCH.Text = "Hatch";
            this.BUTTON_HATCH.UseVisualStyleBackColor = true;
            this.BUTTON_HATCH.Click += new System.EventHandler(this.BUTTON_HATCH_Click);
            // 
            // BUTTON_BITMAP
            // 
            this.BUTTON_BITMAP.Location = new System.Drawing.Point(20, 208);
            this.BUTTON_BITMAP.Name = "BUTTON_BITMAP";
            this.BUTTON_BITMAP.Size = new System.Drawing.Size(88, 34);
            this.BUTTON_BITMAP.TabIndex = 29;
            this.BUTTON_BITMAP.Text = "Bitmap";
            this.BUTTON_BITMAP.UseVisualStyleBackColor = true;
            this.BUTTON_BITMAP.Click += new System.EventHandler(this.BUTTON_BITMAP_Click);
            // 
            // BUTTON_MARK
            // 
            this.BUTTON_MARK.Location = new System.Drawing.Point(20, 156);
            this.BUTTON_MARK.Name = "BUTTON_MARK";
            this.BUTTON_MARK.Size = new System.Drawing.Size(88, 34);
            this.BUTTON_MARK.TabIndex = 28;
            this.BUTTON_MARK.Text = "Mark";
            this.BUTTON_MARK.UseVisualStyleBackColor = true;
            this.BUTTON_MARK.Click += new System.EventHandler(this.BUTTON_MARK_Click);
            // 
            // BUTTON_LOAD_AND_SAVE
            // 
            this.BUTTON_LOAD_AND_SAVE.Location = new System.Drawing.Point(20, 103);
            this.BUTTON_LOAD_AND_SAVE.Name = "BUTTON_LOAD_AND_SAVE";
            this.BUTTON_LOAD_AND_SAVE.Size = new System.Drawing.Size(88, 34);
            this.BUTTON_LOAD_AND_SAVE.TabIndex = 27;
            this.BUTTON_LOAD_AND_SAVE.Text = "Load and Save";
            this.BUTTON_LOAD_AND_SAVE.UseVisualStyleBackColor = true;
            this.BUTTON_LOAD_AND_SAVE.Click += new System.EventHandler(this.BUTTON_LOAD_AND_SAVE_Click);
            // 
            // BUTTON_TEXT
            // 
            this.BUTTON_TEXT.Location = new System.Drawing.Point(20, 50);
            this.BUTTON_TEXT.Name = "BUTTON_TEXT";
            this.BUTTON_TEXT.Size = new System.Drawing.Size(88, 34);
            this.BUTTON_TEXT.TabIndex = 26;
            this.BUTTON_TEXT.Text = "Text";
            this.BUTTON_TEXT.UseVisualStyleBackColor = true;
            this.BUTTON_TEXT.Click += new System.EventHandler(this.BUTTON_TEXT_Click);
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.BUTTON_MOTION);
            this.groupBox19.Controls.Add(this.BUTTON_SCREEN_SHOTS);
            this.groupBox19.Controls.Add(this.BUTTON_ENTITIES_BY_ID);
            this.groupBox19.Controls.Add(this.BUTTON_INPUT_OUTPUT);
            this.groupBox19.Controls.Add(this.BUTTON_SETTINGS);
            this.groupBox19.Controls.Add(this.BUTTON_PENS);
            this.groupBox19.Controls.Add(this.BUTTON_OPTIMIZE_PERFORMANCE);
            this.groupBox19.Location = new System.Drawing.Point(386, 201);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(252, 277);
            this.groupBox19.TabIndex = 36;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "General";
            // 
            // BUTTON_MOTION
            // 
            this.BUTTON_MOTION.Location = new System.Drawing.Point(141, 158);
            this.BUTTON_MOTION.Name = "BUTTON_MOTION";
            this.BUTTON_MOTION.Size = new System.Drawing.Size(89, 34);
            this.BUTTON_MOTION.TabIndex = 45;
            this.BUTTON_MOTION.Text = "Motion";
            this.BUTTON_MOTION.UseVisualStyleBackColor = true;
            this.BUTTON_MOTION.Click += new System.EventHandler(this.BUTTON_MOTION_Click);
            // 
            // BUTTON_SCREEN_SHOTS
            // 
            this.BUTTON_SCREEN_SHOTS.Location = new System.Drawing.Point(141, 105);
            this.BUTTON_SCREEN_SHOTS.Name = "BUTTON_SCREEN_SHOTS";
            this.BUTTON_SCREEN_SHOTS.Size = new System.Drawing.Size(89, 34);
            this.BUTTON_SCREEN_SHOTS.TabIndex = 44;
            this.BUTTON_SCREEN_SHOTS.Text = "ScreenShots";
            this.BUTTON_SCREEN_SHOTS.UseVisualStyleBackColor = true;
            this.BUTTON_SCREEN_SHOTS.Click += new System.EventHandler(this.BUTTON_SCREEN_SHOTS_Click);
            // 
            // BUTTON_ENTITIES_BY_ID
            // 
            this.BUTTON_ENTITIES_BY_ID.Location = new System.Drawing.Point(141, 52);
            this.BUTTON_ENTITIES_BY_ID.Name = "BUTTON_ENTITIES_BY_ID";
            this.BUTTON_ENTITIES_BY_ID.Size = new System.Drawing.Size(89, 34);
            this.BUTTON_ENTITIES_BY_ID.TabIndex = 43;
            this.BUTTON_ENTITIES_BY_ID.Text = "Entities by ID";
            this.BUTTON_ENTITIES_BY_ID.UseVisualStyleBackColor = true;
            this.BUTTON_ENTITIES_BY_ID.Click += new System.EventHandler(this.BUTTON_ENTITIES_BY_ID_Click);
            // 
            // BUTTON_INPUT_OUTPUT
            // 
            this.BUTTON_INPUT_OUTPUT.Location = new System.Drawing.Point(24, 157);
            this.BUTTON_INPUT_OUTPUT.Name = "BUTTON_INPUT_OUTPUT";
            this.BUTTON_INPUT_OUTPUT.Size = new System.Drawing.Size(88, 34);
            this.BUTTON_INPUT_OUTPUT.TabIndex = 42;
            this.BUTTON_INPUT_OUTPUT.Text = "Input Output";
            this.BUTTON_INPUT_OUTPUT.UseVisualStyleBackColor = true;
            this.BUTTON_INPUT_OUTPUT.Click += new System.EventHandler(this.BUTTON_INPUT_OUTPUT_Click);
            // 
            // BUTTON_SETTINGS
            // 
            this.BUTTON_SETTINGS.Location = new System.Drawing.Point(24, 104);
            this.BUTTON_SETTINGS.Name = "BUTTON_SETTINGS";
            this.BUTTON_SETTINGS.Size = new System.Drawing.Size(88, 34);
            this.BUTTON_SETTINGS.TabIndex = 41;
            this.BUTTON_SETTINGS.Text = "Settings";
            this.BUTTON_SETTINGS.UseVisualStyleBackColor = true;
            this.BUTTON_SETTINGS.Click += new System.EventHandler(this.BUTTON_SETTINGS_Click);
            // 
            // BUTTON_PENS
            // 
            this.BUTTON_PENS.Location = new System.Drawing.Point(24, 51);
            this.BUTTON_PENS.Name = "BUTTON_PENS";
            this.BUTTON_PENS.Size = new System.Drawing.Size(88, 34);
            this.BUTTON_PENS.TabIndex = 40;
            this.BUTTON_PENS.Text = "Pens";
            this.BUTTON_PENS.UseVisualStyleBackColor = true;
            this.BUTTON_PENS.Click += new System.EventHandler(this.BUTTON_PENS_Click);
            // 
            // BUTTON_OPTIMIZE_PERFORMANCE
            // 
            this.BUTTON_OPTIMIZE_PERFORMANCE.Location = new System.Drawing.Point(24, 211);
            this.BUTTON_OPTIMIZE_PERFORMANCE.Name = "BUTTON_OPTIMIZE_PERFORMANCE";
            this.BUTTON_OPTIMIZE_PERFORMANCE.Size = new System.Drawing.Size(206, 34);
            this.BUTTON_OPTIMIZE_PERFORMANCE.TabIndex = 39;
            this.BUTTON_OPTIMIZE_PERFORMANCE.Text = "Optimize Performance";
            this.BUTTON_OPTIMIZE_PERFORMANCE.UseVisualStyleBackColor = true;
            this.BUTTON_OPTIMIZE_PERFORMANCE.Click += new System.EventHandler(this.BUTTON_OPTIMIZE_PERFORMANCE_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(127, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(113, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "700";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(288, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Set";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 20);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "1.57075";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(288, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Set";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Mark Entity";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(289, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 49);
            this.button3.TabIndex = 15;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(154, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Right";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(85, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Left";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(14, 28);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(56, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Center";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Mark All";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "MyText";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(124, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Mark Hatch";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(17, 28);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(90, 17);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "Mark Contour";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Is Marking";
            // 
            // samlight_client_csharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 626);
            this.Controls.Add(this.groupBox19);
            this.Controls.Add(this.groupBox18);
            this.Controls.Add(this.EDIT_PORT_SAMLIGHT);
            this.Controls.Add(this.EDIT_IP_SAMLIGHT);
            this.Controls.Add(this.BUTTON_DISCONNECT_ETHERNET);
            this.Controls.Add(this.BUTTON_CONNECT_ETHERNET);
            this.Controls.Add(this.EDIT_STATUS_CONNECTED);
            this.Controls.Add(this.BUTTON_CLOSE);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.axScSamlightClientCtrl1);
            this.Name = "samlight_client_csharp";
            this.Text = "samlight_client_csharp";
            this.Load += new System.EventHandler(this.samlight_client_csharp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axScSamlightClientCtrl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl axScSamlightClientCtrl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox EDIT_STATUS_CONNECTED;
        private System.Windows.Forms.TextBox EDIT_PORT_SAMLIGHT;
        private System.Windows.Forms.TextBox EDIT_IP_SAMLIGHT;
        private System.Windows.Forms.Button BUTTON_DISCONNECT_ETHERNET;
        private System.Windows.Forms.Button BUTTON_CONNECT_ETHERNET;
        private System.Windows.Forms.Button BUTTON_CLOSE;
        private System.Windows.Forms.Button BUTTON_TEST;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Button BUTTON_ENTITY_INFO;
        private System.Windows.Forms.Button BUTTON_FLASH_CALLS;
        private System.Windows.Forms.Button BUTTON_MOVE_ENTITIES;
        private System.Windows.Forms.Button BUTTON_HATCH;
        private System.Windows.Forms.Button BUTTON_BITMAP;
        private System.Windows.Forms.Button BUTTON_MARK;
        private System.Windows.Forms.Button BUTTON_LOAD_AND_SAVE;
        private System.Windows.Forms.Button BUTTON_TEXT;
        private System.Windows.Forms.Button BUTTON_OPTIMIZE_PERFORMANCE;
        private System.Windows.Forms.Button BUTTON_MOTION;
        private System.Windows.Forms.Button BUTTON_SCREEN_SHOTS;
        private System.Windows.Forms.Button BUTTON_ENTITIES_BY_ID;
        private System.Windows.Forms.Button BUTTON_INPUT_OUTPUT;
        private System.Windows.Forms.Button BUTTON_SETTINGS;
        private System.Windows.Forms.Button BUTTON_PENS;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
    }
}

