namespace UvDemo
{
    partial class frmMain
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpMeasurements = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tpSpectrometerSettings = new System.Windows.Forms.TabPage();
            this.btnSaveSpecSettings = new FontAwesome.Sharp.IconButton();
            this.pgSpectrometerSettings = new System.Windows.Forms.PropertyGrid();
            this.tpCameraSettings = new System.Windows.Forms.TabPage();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowHelpDocs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenLogsFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenSpectrometerSettings = new FontAwesome.Sharp.IconButton();
            this.tlpMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpMeasurements.SuspendLayout();
            this.tpSpectrometerSettings.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tcMain, 0, 0);
            this.tlpMain.Controls.Add(this.pnlFooter, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 24);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpMain.Size = new System.Drawing.Size(1110, 688);
            this.tlpMain.TabIndex = 1;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpMeasurements);
            this.tcMain.Controls.Add(this.tpSpectrometerSettings);
            this.tcMain.Controls.Add(this.tpCameraSettings);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMain.Location = new System.Drawing.Point(3, 3);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1104, 620);
            this.tcMain.TabIndex = 0;
            // 
            // tpMeasurements
            // 
            this.tpMeasurements.Controls.Add(this.button1);
            this.tpMeasurements.Location = new System.Drawing.Point(4, 29);
            this.tpMeasurements.Name = "tpMeasurements";
            this.tpMeasurements.Padding = new System.Windows.Forms.Padding(3);
            this.tpMeasurements.Size = new System.Drawing.Size(1096, 626);
            this.tpMeasurements.TabIndex = 0;
            this.tpMeasurements.Text = "Measurements";
            this.tpMeasurements.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tpSpectrometerSettings
            // 
            this.tpSpectrometerSettings.Controls.Add(this.btnOpenSpectrometerSettings);
            this.tpSpectrometerSettings.Controls.Add(this.btnSaveSpecSettings);
            this.tpSpectrometerSettings.Controls.Add(this.pgSpectrometerSettings);
            this.tpSpectrometerSettings.Location = new System.Drawing.Point(4, 29);
            this.tpSpectrometerSettings.Name = "tpSpectrometerSettings";
            this.tpSpectrometerSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSpectrometerSettings.Size = new System.Drawing.Size(1096, 587);
            this.tpSpectrometerSettings.TabIndex = 1;
            this.tpSpectrometerSettings.Text = "Spectrometer Settings";
            this.tpSpectrometerSettings.UseVisualStyleBackColor = true;
            // 
            // btnSaveSpecSettings
            // 
            this.btnSaveSpecSettings.BackColor = System.Drawing.Color.LightGreen;
            this.btnSaveSpecSettings.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSaveSpecSettings.IconColor = System.Drawing.Color.Black;
            this.btnSaveSpecSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveSpecSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSpecSettings.Location = new System.Drawing.Point(391, 495);
            this.btnSaveSpecSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveSpecSettings.Name = "btnSaveSpecSettings";
            this.btnSaveSpecSettings.Size = new System.Drawing.Size(241, 55);
            this.btnSaveSpecSettings.TabIndex = 2;
            this.btnSaveSpecSettings.Text = "Save SpectrometerSettings";
            this.btnSaveSpecSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveSpecSettings.UseVisualStyleBackColor = false;
            this.btnSaveSpecSettings.Click += new System.EventHandler(this.btnSaveSpecSettings_Click);
            // 
            // pgSpectrometerSettings
            // 
            this.pgSpectrometerSettings.Location = new System.Drawing.Point(12, 13);
            this.pgSpectrometerSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pgSpectrometerSettings.Name = "pgSpectrometerSettings";
            this.pgSpectrometerSettings.Size = new System.Drawing.Size(617, 469);
            this.pgSpectrometerSettings.TabIndex = 0;
            // 
            // tpCameraSettings
            // 
            this.tpCameraSettings.Location = new System.Drawing.Point(4, 29);
            this.tpCameraSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpCameraSettings.Name = "tpCameraSettings";
            this.tpCameraSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpCameraSettings.Size = new System.Drawing.Size(1096, 626);
            this.tpCameraSettings.TabIndex = 2;
            this.tpCameraSettings.Text = "Camera Settings";
            this.tpCameraSettings.UseVisualStyleBackColor = true;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblStatus);
            this.pnlFooter.Controls.Add(this.txtStatus);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.Location = new System.Drawing.Point(4, 631);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1102, 52);
            this.pnlFooter.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 16);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 20);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Location = new System.Drawing.Point(72, 18);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(1018, 20);
            this.txtStatus.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiExit.Size = new System.Drawing.Size(134, 22);
            this.tsmiExit.Text = "E&xit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowHelpDocs,
            this.tsmiOpenLogsFolder});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tsmiShowHelpDocs
            // 
            this.tsmiShowHelpDocs.Name = "tsmiShowHelpDocs";
            this.tsmiShowHelpDocs.Size = new System.Drawing.Size(167, 22);
            this.tsmiShowHelpDocs.Text = "Show Help Docs";
            this.tsmiShowHelpDocs.Click += new System.EventHandler(this.tsmiShowHelpDocs_Click);
            // 
            // tsmiOpenLogsFolder
            // 
            this.tsmiOpenLogsFolder.Name = "tsmiOpenLogsFolder";
            this.tsmiOpenLogsFolder.Size = new System.Drawing.Size(167, 22);
            this.tsmiOpenLogsFolder.Text = "Open Logs Folder";
            this.tsmiOpenLogsFolder.Click += new System.EventHandler(this.tsmiOpenLogsFolder_Click);
            // 
            // btnOpenSpectrometerSettings
            // 
            this.btnOpenSpectrometerSettings.BackColor = System.Drawing.Color.Khaki;
            this.btnOpenSpectrometerSettings.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.btnOpenSpectrometerSettings.IconColor = System.Drawing.Color.Black;
            this.btnOpenSpectrometerSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenSpectrometerSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenSpectrometerSettings.Location = new System.Drawing.Point(9, 496);
            this.btnOpenSpectrometerSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenSpectrometerSettings.Name = "btnOpenSpectrometerSettings";
            this.btnOpenSpectrometerSettings.Size = new System.Drawing.Size(241, 55);
            this.btnOpenSpectrometerSettings.TabIndex = 3;
            this.btnOpenSpectrometerSettings.Text = "Open SpectrometerSettings";
            this.btnOpenSpectrometerSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenSpectrometerSettings.UseVisualStyleBackColor = false;
            this.btnOpenSpectrometerSettings.Click += new System.EventHandler(this.btnOpenSpectrometerSettings_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 712);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tlpMain.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpMeasurements.ResumeLayout(false);
            this.tpSpectrometerSettings.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpMeasurements;
        private System.Windows.Forms.TabPage tpSpectrometerSettings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.PropertyGrid pgSpectrometerSettings;
        private System.Windows.Forms.TabPage tpCameraSettings;
        private FontAwesome.Sharp.IconButton btnSaveSpecSettings;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowHelpDocs;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenLogsFolder;
        private FontAwesome.Sharp.IconButton btnOpenSpectrometerSettings;
    }
}

