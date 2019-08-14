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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EDIT_TEXT_STRING = new System.Windows.Forms.TextBox();
            this.BUTTON_CHANGE_TEXT_BY_NAME = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EDIT_ENTITY_NAME = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HeatCodeEdit = new System.Windows.Forms.TextBox();
            this.HeatCodeText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axScSamlightClientCtrl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(11, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ethernet";
            this.groupBox1.Visible = false;
            // 
            // BUTTON_TEST
            // 
            this.BUTTON_TEST.Location = new System.Drawing.Point(143, 109);
            this.BUTTON_TEST.Name = "BUTTON_TEST";
            this.BUTTON_TEST.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_TEST.TabIndex = 25;
            this.BUTTON_TEST.Text = "Test";
            this.BUTTON_TEST.UseVisualStyleBackColor = true;
            this.BUTTON_TEST.Visible = false;
            this.BUTTON_TEST.Click += new System.EventHandler(this.BUTTON_TEST_Click);
            // 
            // EDIT_PORT_SAMLIGHT
            // 
            this.EDIT_PORT_SAMLIGHT.Location = new System.Drawing.Point(247, 343);
            this.EDIT_PORT_SAMLIGHT.Name = "EDIT_PORT_SAMLIGHT";
            this.EDIT_PORT_SAMLIGHT.Size = new System.Drawing.Size(67, 20);
            this.EDIT_PORT_SAMLIGHT.TabIndex = 13;
            this.EDIT_PORT_SAMLIGHT.Text = "1024";
            this.EDIT_PORT_SAMLIGHT.Visible = false;
            // 
            // EDIT_IP_SAMLIGHT
            // 
            this.EDIT_IP_SAMLIGHT.Location = new System.Drawing.Point(84, 343);
            this.EDIT_IP_SAMLIGHT.Name = "EDIT_IP_SAMLIGHT";
            this.EDIT_IP_SAMLIGHT.Size = new System.Drawing.Size(85, 20);
            this.EDIT_IP_SAMLIGHT.TabIndex = 12;
            this.EDIT_IP_SAMLIGHT.Text = "127.0.0.1";
            this.EDIT_IP_SAMLIGHT.Visible = false;
            // 
            // BUTTON_DISCONNECT_ETHERNET
            // 
            this.BUTTON_DISCONNECT_ETHERNET.Location = new System.Drawing.Point(280, 377);
            this.BUTTON_DISCONNECT_ETHERNET.Name = "BUTTON_DISCONNECT_ETHERNET";
            this.BUTTON_DISCONNECT_ETHERNET.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_DISCONNECT_ETHERNET.TabIndex = 9;
            this.BUTTON_DISCONNECT_ETHERNET.Text = "Disconnect";
            this.BUTTON_DISCONNECT_ETHERNET.UseVisualStyleBackColor = true;
            this.BUTTON_DISCONNECT_ETHERNET.Visible = false;
            this.BUTTON_DISCONNECT_ETHERNET.Click += new System.EventHandler(this.BUTTON_DISCONNECT_ETHERNET_Click);
            // 
            // BUTTON_CONNECT_ETHERNET
            // 
            this.BUTTON_CONNECT_ETHERNET.Location = new System.Drawing.Point(36, 377);
            this.BUTTON_CONNECT_ETHERNET.Name = "BUTTON_CONNECT_ETHERNET";
            this.BUTTON_CONNECT_ETHERNET.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_CONNECT_ETHERNET.TabIndex = 8;
            this.BUTTON_CONNECT_ETHERNET.Text = "Connect";
            this.BUTTON_CONNECT_ETHERNET.UseVisualStyleBackColor = true;
            this.BUTTON_CONNECT_ETHERNET.Visible = false;
            this.BUTTON_CONNECT_ETHERNET.Click += new System.EventHandler(this.BUTTON_CONNECT_ETHERNET_Click);
            // 
            // EDIT_STATUS_CONNECTED
            // 
            this.EDIT_STATUS_CONNECTED.Location = new System.Drawing.Point(146, 379);
            this.EDIT_STATUS_CONNECTED.Name = "EDIT_STATUS_CONNECTED";
            this.EDIT_STATUS_CONNECTED.ReadOnly = true;
            this.EDIT_STATUS_CONNECTED.Size = new System.Drawing.Size(91, 20);
            this.EDIT_STATUS_CONNECTED.TabIndex = 5;
            this.EDIT_STATUS_CONNECTED.Visible = false;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EDIT_TEXT_STRING);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 62);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Number";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // EDIT_TEXT_STRING
            // 
            this.EDIT_TEXT_STRING.Location = new System.Drawing.Point(127, 32);
            this.EDIT_TEXT_STRING.Name = "EDIT_TEXT_STRING";
            this.EDIT_TEXT_STRING.Size = new System.Drawing.Size(113, 20);
            this.EDIT_TEXT_STRING.TabIndex = 14;
            this.EDIT_TEXT_STRING.Text = "MyText";
            this.EDIT_TEXT_STRING.TextChanged += new System.EventHandler(this.EDIT_TEXT_STRING_TextChanged);
            this.EDIT_TEXT_STRING.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EDIT_TEXT_STRING_KeyPress);
            // 
            // BUTTON_CHANGE_TEXT_BY_NAME
            // 
            this.BUTTON_CHANGE_TEXT_BY_NAME.Location = new System.Drawing.Point(154, 148);
            this.BUTTON_CHANGE_TEXT_BY_NAME.Name = "BUTTON_CHANGE_TEXT_BY_NAME";
            this.BUTTON_CHANGE_TEXT_BY_NAME.Size = new System.Drawing.Size(59, 23);
            this.BUTTON_CHANGE_TEXT_BY_NAME.TabIndex = 15;
            this.BUTTON_CHANGE_TEXT_BY_NAME.Text = "Set";
            this.BUTTON_CHANGE_TEXT_BY_NAME.UseVisualStyleBackColor = true;
            this.BUTTON_CHANGE_TEXT_BY_NAME.Click += new System.EventHandler(this.BUTTON_CHANGE_TEXT_BY_NAME_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Serial Number";
            this.label3.Visible = false;
            // 
            // EDIT_ENTITY_NAME
            // 
            this.EDIT_ENTITY_NAME.Enabled = false;
            this.EDIT_ENTITY_NAME.Location = new System.Drawing.Point(129, 457);
            this.EDIT_ENTITY_NAME.Name = "EDIT_ENTITY_NAME";
            this.EDIT_ENTITY_NAME.Size = new System.Drawing.Size(113, 20);
            this.EDIT_ENTITY_NAME.TabIndex = 26;
            this.EDIT_ENTITY_NAME.Text = "serial number";
            this.EDIT_ENTITY_NAME.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HeatCodeEdit);
            this.groupBox3.Location = new System.Drawing.Point(12, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 62);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Heat Code";
            this.groupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // HeatCodeEdit
            // 
            this.HeatCodeEdit.Location = new System.Drawing.Point(127, 32);
            this.HeatCodeEdit.Name = "HeatCodeEdit";
            this.HeatCodeEdit.Size = new System.Drawing.Size(113, 20);
            this.HeatCodeEdit.TabIndex = 14;
            this.HeatCodeEdit.Text = "MyText";
            this.HeatCodeEdit.TextChanged += new System.EventHandler(this.HeatCodeEdit_TextChanged);
            // 
            // HeatCodeText
            // 
            this.HeatCodeText.Enabled = false;
            this.HeatCodeText.Location = new System.Drawing.Point(129, 482);
            this.HeatCodeText.Name = "HeatCodeText";
            this.HeatCodeText.Size = new System.Drawing.Size(113, 20);
            this.HeatCodeText.TabIndex = 29;
            this.HeatCodeText.Text = "heat code";
            this.HeatCodeText.Visible = false;
            this.HeatCodeText.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Heat Code";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // samlight_client_csharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 626);
            this.Controls.Add(this.BUTTON_CHANGE_TEXT_BY_NAME);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.HeatCodeText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EDIT_ENTITY_NAME);
            this.Controls.Add(this.label3);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox EDIT_TEXT_STRING;
        private System.Windows.Forms.Button BUTTON_CHANGE_TEXT_BY_NAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EDIT_ENTITY_NAME;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox HeatCodeEdit;
        private System.Windows.Forms.TextBox HeatCodeText;
        private System.Windows.Forms.Label label5;
    }
}

