namespace ClientAceTest
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
            this.tbConnectUrl = new System.Windows.Forms.TextBox();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.cmdLocal = new System.Windows.Forms.Button();
            this.cmdRemote = new System.Windows.Forms.Button();
            this.cmdDisconnect = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClientHandle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbConnectUrl
            // 
            this.tbConnectUrl.Location = new System.Drawing.Point(13, 13);
            this.tbConnectUrl.Name = "tbConnectUrl";
            this.tbConnectUrl.Size = new System.Drawing.Size(284, 20);
            this.tbConnectUrl.TabIndex = 0;
            this.tbConnectUrl.Text = "opcda://localhost/Kepware.KEPServerEX.V5";
            // 
            // cmdConnect
            // 
            this.cmdConnect.Location = new System.Drawing.Point(304, 13);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(75, 23);
            this.cmdConnect.TabIndex = 1;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // cmdLocal
            // 
            this.cmdLocal.Location = new System.Drawing.Point(13, 40);
            this.cmdLocal.Name = "cmdLocal";
            this.cmdLocal.Size = new System.Drawing.Size(75, 23);
            this.cmdLocal.TabIndex = 2;
            this.cmdLocal.Text = "Localhost";
            this.cmdLocal.UseVisualStyleBackColor = true;
            this.cmdLocal.Click += new System.EventHandler(this.cmdLocal_Click);
            // 
            // cmdRemote
            // 
            this.cmdRemote.Location = new System.Drawing.Point(95, 40);
            this.cmdRemote.Name = "cmdRemote";
            this.cmdRemote.Size = new System.Drawing.Size(75, 23);
            this.cmdRemote.TabIndex = 3;
            this.cmdRemote.Text = "Remote";
            this.cmdRemote.UseVisualStyleBackColor = true;
            this.cmdRemote.Click += new System.EventHandler(this.cmdRemote_Click);
            // 
            // cmdDisconnect
            // 
            this.cmdDisconnect.Location = new System.Drawing.Point(385, 13);
            this.cmdDisconnect.Name = "cmdDisconnect";
            this.cmdDisconnect.Size = new System.Drawing.Size(75, 23);
            this.cmdDisconnect.TabIndex = 4;
            this.cmdDisconnect.Text = "Dis-Connect";
            this.cmdDisconnect.UseVisualStyleBackColor = true;
            this.cmdDisconnect.Click += new System.EventHandler(this.cmdDisconnect_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(391, 274);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 5;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Client Handle";
            // 
            // tbClientHandle
            // 
            this.tbClientHandle.Location = new System.Drawing.Point(87, 80);
            this.tbClientHandle.Name = "tbClientHandle";
            this.tbClientHandle.Size = new System.Drawing.Size(100, 20);
            this.tbClientHandle.TabIndex = 7;
            this.tbClientHandle.Text = "99";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Connection Status";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(304, 42);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(156, 20);
            this.tbStatus.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Client Name";
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(87, 106);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(100, 20);
            this.tbClientName.TabIndex = 7;
            this.tbClientName.Text = "TestClient1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 309);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbClientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbClientHandle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdDisconnect);
            this.Controls.Add(this.cmdRemote);
            this.Controls.Add(this.cmdLocal);
            this.Controls.Add(this.cmdConnect);
            this.Controls.Add(this.tbConnectUrl);
            this.Name = "Form1";
            this.Text = "ClientAce Remote Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbConnectUrl;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.Button cmdLocal;
        private System.Windows.Forms.Button cmdRemote;
        private System.Windows.Forms.Button cmdDisconnect;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbClientHandle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbClientName;
    }
}

