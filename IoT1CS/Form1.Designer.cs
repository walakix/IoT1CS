namespace IoT1CS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numUDPort = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBroker = new System.Windows.Forms.ComboBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisConnect = new System.Windows.Forms.Button();
            this.tbConnectedTopic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbStateTopic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbState = new System.Windows.Forms.PictureBox();
            this.pbConnected = new System.Windows.Forms.PictureBox();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbID1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnUnSubscribe = new System.Windows.Forms.Button();
            this.tbPublishText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPublish = new System.Windows.Forms.Button();
            this.lbLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnected)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MQTT Broker:";
            // 
            // numUDPort
            // 
            this.numUDPort.Location = new System.Drawing.Point(193, 25);
            this.numUDPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numUDPort.Name = "numUDPort";
            this.numUDPort.Size = new System.Drawing.Size(71, 20);
            this.numUDPort.TabIndex = 3;
            this.numUDPort.Value = new decimal(new int[] {
            1883,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // cbBroker
            // 
            this.cbBroker.FormattingEnabled = true;
            this.cbBroker.Items.AddRange(new object[] {
            "broker.hivemq.com",
            "141.147.47.82",
            "192.168.201.200"});
            this.cbBroker.Location = new System.Drawing.Point(3, 24);
            this.cbBroker.Name = "cbBroker";
            this.cbBroker.Size = new System.Drawing.Size(184, 21);
            this.cbBroker.TabIndex = 5;
            this.cbBroker.Text = "broker.hivemq.com";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(271, 25);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(81, 20);
            this.tbID.TabIndex = 6;
            this.tbID.Text = "IoT1CS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID:";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(358, 25);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(88, 20);
            this.tbUser.TabIndex = 8;
            this.tbUser.Text = "walaki";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "User:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(452, 25);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(87, 20);
            this.tbPassword.TabIndex = 10;
            this.tbPassword.Text = "Password123";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password:";
            // 
            // chkSSL
            // 
            this.chkSSL.AutoSize = true;
            this.chkSSL.Location = new System.Drawing.Point(545, 26);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(46, 17);
            this.chkSSL.TabIndex = 12;
            this.chkSSL.Text = "SSL";
            this.chkSSL.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(597, 20);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisConnect
            // 
            this.btnDisConnect.Enabled = false;
            this.btnDisConnect.Location = new System.Drawing.Point(678, 20);
            this.btnDisConnect.Name = "btnDisConnect";
            this.btnDisConnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisConnect.TabIndex = 14;
            this.btnDisConnect.Text = "DisConnect";
            this.btnDisConnect.UseVisualStyleBackColor = true;
            this.btnDisConnect.Click += new System.EventHandler(this.btnDisConnect_Click);
            // 
            // tbConnectedTopic
            // 
            this.tbConnectedTopic.Location = new System.Drawing.Point(3, 64);
            this.tbConnectedTopic.Name = "tbConnectedTopic";
            this.tbConnectedTopic.Size = new System.Drawing.Size(184, 20);
            this.tbConnectedTopic.TabIndex = 15;
            this.tbConnectedTopic.Text = "walaki/IoT1/connected";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "ConnectedTopic:";
            // 
            // tbStateTopic
            // 
            this.tbStateTopic.Location = new System.Drawing.Point(271, 64);
            this.tbStateTopic.Name = "tbStateTopic";
            this.tbStateTopic.Size = new System.Drawing.Size(159, 20);
            this.tbStateTopic.TabIndex = 17;
            this.tbStateTopic.Text = "walaki/IoT1/ledstate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "StateTopic:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(678, 61);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbState
            // 
            this.pbState.Enabled = false;
            this.pbState.Image = global::IoT1CS.Properties.Resources.led_grey;
            this.pbState.Location = new System.Drawing.Point(455, 52);
            this.pbState.Name = "pbState";
            this.pbState.Size = new System.Drawing.Size(32, 32);
            this.pbState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbState.TabIndex = 20;
            this.pbState.TabStop = false;
            this.pbState.Click += new System.EventHandler(this.pbState_Click);
            // 
            // pbConnected
            // 
            this.pbConnected.Enabled = false;
            this.pbConnected.Image = global::IoT1CS.Properties.Resources.led_grey;
            this.pbConnected.Location = new System.Drawing.Point(214, 52);
            this.pbConnected.Name = "pbConnected";
            this.pbConnected.Size = new System.Drawing.Size(32, 32);
            this.pbConnected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConnected.TabIndex = 19;
            this.pbConnected.TabStop = false;
            // 
            // tbTopic
            // 
            this.tbTopic.Location = new System.Drawing.Point(3, 103);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.Size = new System.Drawing.Size(184, 20);
            this.tbTopic.TabIndex = 23;
            this.tbTopic.Text = "walaki/IoT1/ledstate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Topic:";
            // 
            // tbID1
            // 
            this.tbID1.Location = new System.Drawing.Point(193, 103);
            this.tbID1.Name = "tbID1";
            this.tbID1.Size = new System.Drawing.Size(100, 20);
            this.tbID1.TabIndex = 25;
            this.tbID1.Text = "IoT1CS1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(190, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "ID:";
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(299, 101);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(75, 23);
            this.btnSubscribe.TabIndex = 27;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // btnUnSubscribe
            // 
            this.btnUnSubscribe.Enabled = false;
            this.btnUnSubscribe.Location = new System.Drawing.Point(371, 101);
            this.btnUnSubscribe.Name = "btnUnSubscribe";
            this.btnUnSubscribe.Size = new System.Drawing.Size(78, 23);
            this.btnUnSubscribe.TabIndex = 28;
            this.btnUnSubscribe.Text = "UnSubscribe";
            this.btnUnSubscribe.UseVisualStyleBackColor = true;
            this.btnUnSubscribe.Click += new System.EventHandler(this.btnUnSubscribe_Click);
            // 
            // tbPublishText
            // 
            this.tbPublishText.Enabled = false;
            this.tbPublishText.Location = new System.Drawing.Point(455, 103);
            this.tbPublishText.Name = "tbPublishText";
            this.tbPublishText.Size = new System.Drawing.Size(100, 20);
            this.tbPublishText.TabIndex = 29;
            this.tbPublishText.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(452, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Publish Text:";
            // 
            // btnPublish
            // 
            this.btnPublish.Enabled = false;
            this.btnPublish.Location = new System.Drawing.Point(561, 100);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(75, 23);
            this.btnPublish.TabIndex = 31;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(3, 129);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(750, 316);
            this.lbLog.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPublishText);
            this.Controls.Add(this.btnUnSubscribe);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbID1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTopic);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbState);
            this.Controls.Add(this.pbConnected);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbStateTopic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbConnectedTopic);
            this.Controls.Add(this.btnDisConnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.chkSSL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.cbBroker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numUDPort);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "IoT1CS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUDPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBroker;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkSSL;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisConnect;
        private System.Windows.Forms.TextBox tbConnectedTopic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbStateTopic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbConnected;
        private System.Windows.Forms.PictureBox pbState;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbTopic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbID1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Button btnUnSubscribe;
        private System.Windows.Forms.TextBox tbPublishText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.ListBox lbLog;
    }
}

