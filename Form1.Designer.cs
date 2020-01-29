namespace WinSaleTroubleShooter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.resetPrinter = new System.Windows.Forms.Button();
            this.btnTeamV = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnScannerP = new System.Windows.Forms.Button();
            this.btnCOMPort = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnNetwork = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIP = new System.Windows.Forms.Button();
            this.btnUpdates = new System.Windows.Forms.Button();
            this.btnSurvey = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // resetPrinter
            // 
            this.resetPrinter.Image = ((System.Drawing.Image)(resources.GetObject("resetPrinter.Image")));
            this.resetPrinter.Location = new System.Drawing.Point(13, 13);
            this.resetPrinter.Name = "resetPrinter";
            this.resetPrinter.Size = new System.Drawing.Size(101, 75);
            this.resetPrinter.TabIndex = 0;
            this.resetPrinter.Text = "Reset Printers";
            this.resetPrinter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.resetPrinter.UseVisualStyleBackColor = true;
            this.resetPrinter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTeamV
            // 
            this.btnTeamV.Image = ((System.Drawing.Image)(resources.GetObject("btnTeamV.Image")));
            this.btnTeamV.Location = new System.Drawing.Point(120, 13);
            this.btnTeamV.Name = "btnTeamV";
            this.btnTeamV.Size = new System.Drawing.Size(101, 75);
            this.btnTeamV.TabIndex = 1;
            this.btnTeamV.Text = "Request Support";
            this.btnTeamV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTeamV.UseVisualStyleBackColor = true;
            this.btnTeamV.Click += new System.EventHandler(this.btnTeamV_Click);
            // 
            // btnManual
            // 
            this.btnManual.Image = ((System.Drawing.Image)(resources.GetObject("btnManual.Image")));
            this.btnManual.Location = new System.Drawing.Point(13, 93);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(101, 75);
            this.btnManual.TabIndex = 2;
            this.btnManual.Text = "Reboot PC";
            this.btnManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnScannerP
            // 
            this.btnScannerP.Image = ((System.Drawing.Image)(resources.GetObject("btnScannerP.Image")));
            this.btnScannerP.Location = new System.Drawing.Point(120, 94);
            this.btnScannerP.Name = "btnScannerP";
            this.btnScannerP.Size = new System.Drawing.Size(101, 75);
            this.btnScannerP.TabIndex = 3;
            this.btnScannerP.Text = "Schedule an Automated Task";
            this.btnScannerP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnScannerP.UseVisualStyleBackColor = true;
            this.btnScannerP.Click += new System.EventHandler(this.btnScannerP_Click);
            // 
            // btnCOMPort
            // 
            this.btnCOMPort.Image = ((System.Drawing.Image)(resources.GetObject("btnCOMPort.Image")));
            this.btnCOMPort.Location = new System.Drawing.Point(12, 174);
            this.btnCOMPort.Name = "btnCOMPort";
            this.btnCOMPort.Size = new System.Drawing.Size(101, 75);
            this.btnCOMPort.TabIndex = 4;
            this.btnCOMPort.Text = "Device Manager";
            this.btnCOMPort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCOMPort.UseVisualStyleBackColor = true;
            this.btnCOMPort.Click += new System.EventHandler(this.btnCOMPort_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btnInventory
            // 
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.Location = new System.Drawing.Point(120, 174);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(101, 75);
            this.btnInventory.TabIndex = 8;
            this.btnInventory.Text = "Restore PC";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click_2);
            // 
            // btnNetwork
            // 
            this.btnNetwork.Image = ((System.Drawing.Image)(resources.GetObject("btnNetwork.Image")));
            this.btnNetwork.Location = new System.Drawing.Point(227, 13);
            this.btnNetwork.Name = "btnNetwork";
            this.btnNetwork.Size = new System.Drawing.Size(101, 75);
            this.btnNetwork.TabIndex = 9;
            this.btnNetwork.Text = "Network Reset";
            this.btnNetwork.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNetwork.UseVisualStyleBackColor = true;
            this.btnNetwork.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(227, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 75);
            this.button1.TabIndex = 10;
            this.button1.Text = "Drive Clean Up";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnIP
            // 
            this.btnIP.Image = ((System.Drawing.Image)(resources.GetObject("btnIP.Image")));
            this.btnIP.Location = new System.Drawing.Point(227, 174);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(101, 75);
            this.btnIP.TabIndex = 11;
            this.btnIP.Text = "Check IP address";
            this.btnIP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIP.UseVisualStyleBackColor = true;
            this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // btnUpdates
            // 
            this.btnUpdates.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdates.Image")));
            this.btnUpdates.Location = new System.Drawing.Point(12, 255);
            this.btnUpdates.Name = "btnUpdates";
            this.btnUpdates.Size = new System.Drawing.Size(101, 75);
            this.btnUpdates.TabIndex = 12;
            this.btnUpdates.Text = "Install Windows Updates";
            this.btnUpdates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdates.UseVisualStyleBackColor = true;
            this.btnUpdates.Click += new System.EventHandler(this.btnUpdates_Click);
            // 
            // btnSurvey
            // 
            this.btnSurvey.Image = ((System.Drawing.Image)(resources.GetObject("btnSurvey.Image")));
            this.btnSurvey.Location = new System.Drawing.Point(119, 255);
            this.btnSurvey.Name = "btnSurvey";
            this.btnSurvey.Size = new System.Drawing.Size(101, 75);
            this.btnSurvey.TabIndex = 13;
            this.btnSurvey.Text = "Customer Survey";
            this.btnSurvey.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSurvey.UseVisualStyleBackColor = true;
            this.btnSurvey.Click += new System.EventHandler(this.btnSurvey_Click);
            // 
            // btnContact
            // 
            this.btnContact.Image = ((System.Drawing.Image)(resources.GetObject("btnContact.Image")));
            this.btnContact.Location = new System.Drawing.Point(226, 255);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(101, 75);
            this.btnContact.TabIndex = 14;
            this.btnContact.Text = "e-mail Developer";
            this.btnContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 358);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnSurvey);
            this.Controls.Add(this.btnUpdates);
            this.Controls.Add(this.btnIP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNetwork);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnCOMPort);
            this.Controls.Add(this.btnScannerP);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnTeamV);
            this.Controls.Add(this.resetPrinter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Windows TroubleShooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resetPrinter;
        private System.Windows.Forms.Button btnTeamV;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnScannerP;
        private System.Windows.Forms.Button btnCOMPort;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnNetwork;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIP;
        private System.Windows.Forms.Button btnUpdates;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnSurvey;
    }
}

