namespace JS3000_plus_windows_app
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtIpAddress = new TextBox();
            txtPort = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtMachineNumber = new TextBox();
            label4 = new Label();
            btnConnect = new Button();
            btnReadTime = new Button();
            btnDisconnect = new Button();
            lblStatus = new Label();
            chkUseUdp = new CheckBox();
            txtLicense = new TextBox();
            label5 = new Label();
            txtTimeOut = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 73);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Ip Address: ";
            // 
            // txtIpAddress
            // 
            txtIpAddress.Location = new Point(188, 65);
            txtIpAddress.Name = "txtIpAddress";
            txtIpAddress.Size = new Size(233, 23);
            txtIpAddress.TabIndex = 1;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(188, 102);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(233, 23);
            txtPort.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 110);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Port: ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(188, 176);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(233, 23);
            txtPassword.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 184);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Password: ";
            // 
            // txtMachineNumber
            // 
            txtMachineNumber.Location = new Point(188, 139);
            txtMachineNumber.Name = "txtMachineNumber";
            txtMachineNumber.Size = new Size(233, 23);
            txtMachineNumber.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 147);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 4;
            label4.Text = "Machine Number: ";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(28, 360);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(159, 52);
            btnConnect.TabIndex = 8;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnReadTime
            // 
            btnReadTime.Location = new Point(193, 360);
            btnReadTime.Name = "btnReadTime";
            btnReadTime.Size = new Size(159, 52);
            btnReadTime.TabIndex = 9;
            btnReadTime.Text = "Read Time";
            btnReadTime.UseVisualStyleBackColor = true;
            btnReadTime.Click += btnReadTime_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(358, 360);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(159, 52);
            btnDisconnect.TabIndex = 10;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(238, 24);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status";
            // 
            // chkUseUdp
            // 
            chkUseUdp.AutoSize = true;
            chkUseUdp.Location = new Point(189, 307);
            chkUseUdp.Name = "chkUseUdp";
            chkUseUdp.Size = new Size(71, 19);
            chkUseUdp.TabIndex = 12;
            chkUseUdp.Text = "Use UDP";
            chkUseUdp.UseVisualStyleBackColor = true;
            // 
            // txtLicense
            // 
            txtLicense.Location = new Point(189, 220);
            txtLicense.Name = "txtLicense";
            txtLicense.Size = new Size(233, 23);
            txtLicense.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 228);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 13;
            label5.Text = "License: ";
            // 
            // txtTimeOut
            // 
            txtTimeOut.Location = new Point(188, 267);
            txtTimeOut.Name = "txtTimeOut";
            txtTimeOut.Size = new Size(233, 23);
            txtTimeOut.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(119, 275);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 15;
            label6.Text = "Time Out: ";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(543, 462);
            Controls.Add(txtTimeOut);
            Controls.Add(label6);
            Controls.Add(txtLicense);
            Controls.Add(label5);
            Controls.Add(chkUseUdp);
            Controls.Add(lblStatus);
            Controls.Add(btnDisconnect);
            Controls.Add(btnReadTime);
            Controls.Add(btnConnect);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtMachineNumber);
            Controls.Add(label4);
            Controls.Add(txtPort);
            Controls.Add(label2);
            Controls.Add(txtIpAddress);
            Controls.Add(label1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIpAddress;
        private TextBox txtPort;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtMachineNumber;
        private Label label4;
        private Button btnConnect;
        private Button btnReadTime;
        private Button btnDisconnect;
        private Label lblStatus;
        private CheckBox chkUseUdp;
        private TextBox txtLicense;
        private Label label5;
        private TextBox txtTimeOut;
        private Label label6;
    }
}
