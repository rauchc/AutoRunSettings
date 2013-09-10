namespace AutoRunSettings
{
    partial class frmAutoRunSettings
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbAutorun = new System.Windows.Forms.GroupBox();
            this.chkRamDisk = new System.Windows.Forms.CheckBox();
            this.chkOpticalMedia = new System.Windows.Forms.CheckBox();
            this.chkNetwork = new System.Windows.Forms.CheckBox();
            this.chkUSB = new System.Windows.Forms.CheckBox();
            this.chkUnknown = new System.Windows.Forms.CheckBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.grbAutorun.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAutorun
            // 
            this.grbAutorun.Controls.Add(this.chkRamDisk);
            this.grbAutorun.Controls.Add(this.chkOpticalMedia);
            this.grbAutorun.Controls.Add(this.chkNetwork);
            this.grbAutorun.Controls.Add(this.chkUSB);
            this.grbAutorun.Controls.Add(this.chkUnknown);
            this.grbAutorun.Location = new System.Drawing.Point(12, 12);
            this.grbAutorun.Name = "grbAutorun";
            this.grbAutorun.Size = new System.Drawing.Size(321, 103);
            this.grbAutorun.TabIndex = 0;
            this.grbAutorun.TabStop = false;
            this.grbAutorun.Text = "Deactivate AutoRun for:";
            // 
            // chkRamDisk
            // 
            this.chkRamDisk.AutoSize = true;
            this.chkRamDisk.Location = new System.Drawing.Point(215, 74);
            this.chkRamDisk.Name = "chkRamDisk";
            this.chkRamDisk.Size = new System.Drawing.Size(77, 17);
            this.chkRamDisk.TabIndex = 4;
            this.chkRamDisk.Text = "RAM disks";
            this.chkRamDisk.UseVisualStyleBackColor = true;
            // 
            // chkOpticalMedia
            // 
            this.chkOpticalMedia.AutoSize = true;
            this.chkOpticalMedia.Location = new System.Drawing.Point(21, 74);
            this.chkOpticalMedia.Name = "chkOpticalMedia";
            this.chkOpticalMedia.Size = new System.Drawing.Size(139, 17);
            this.chkOpticalMedia.TabIndex = 3;
            this.chkOpticalMedia.Text = "CD/DVD/BluRay drives";
            this.chkOpticalMedia.UseVisualStyleBackColor = true;
            // 
            // chkNetwork
            // 
            this.chkNetwork.AutoSize = true;
            this.chkNetwork.Location = new System.Drawing.Point(215, 34);
            this.chkNetwork.Name = "chkNetwork";
            this.chkNetwork.Size = new System.Drawing.Size(97, 17);
            this.chkNetwork.TabIndex = 2;
            this.chkNetwork.Text = "Network drives";
            this.chkNetwork.UseVisualStyleBackColor = true;
            // 
            // chkUSB
            // 
            this.chkUSB.AutoSize = true;
            this.chkUSB.Location = new System.Drawing.Point(130, 34);
            this.chkUSB.Name = "chkUSB";
            this.chkUSB.Size = new System.Drawing.Size(79, 17);
            this.chkUSB.TabIndex = 1;
            this.chkUSB.Text = "USB drives";
            this.chkUSB.UseVisualStyleBackColor = true;
            // 
            // chkUnknown
            // 
            this.chkUnknown.AutoSize = true;
            this.chkUnknown.Location = new System.Drawing.Point(21, 34);
            this.chkUnknown.Name = "chkUnknown";
            this.chkUnknown.Size = new System.Drawing.Size(103, 17);
            this.chkUnknown.TabIndex = 0;
            this.chkUnknown.Text = "Unknown drives";
            this.chkUnknown.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Image = global::AutoRunSettings.Properties.Resources.system_log_out;
            this.btnQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.Location = new System.Drawing.Point(339, 80);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 28);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnReload
            // 
            this.btnReload.Image = global::AutoRunSettings.Properties.Resources.edit_redo;
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(339, 46);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(100, 28);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::AutoRunSettings.Properties.Resources.document_save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(339, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 120);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(446, 22);
            this.status.SizingGrip = false;
            this.status.TabIndex = 4;
            this.status.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(69, 17);
            this.statusLabel.Text = "Placeholder";
            // 
            // frmAutoRunSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 142);
            this.Controls.Add(this.status);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbAutorun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAutoRunSettings";
            this.Text = "AutoRun settings";
            this.Load += new System.EventHandler(this.frmAutoRunSettings_Load);
            this.grbAutorun.ResumeLayout(false);
            this.grbAutorun.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAutorun;
        private System.Windows.Forms.CheckBox chkRamDisk;
        private System.Windows.Forms.CheckBox chkOpticalMedia;
        private System.Windows.Forms.CheckBox chkNetwork;
        private System.Windows.Forms.CheckBox chkUSB;
        private System.Windows.Forms.CheckBox chkUnknown;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}

