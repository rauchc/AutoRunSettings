using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.Principal;


namespace AutoRunSettings
{
    public partial class frmAutoRunSettings : Form
    {
        const Int32 UnknownDrive    = 0x01;
        const Int32 USBDrive        = 0x04;
        const Int32 NetworkDrive    = 0x10;
        const Int32 OpticalDrive    = 0x20;
        const Int32 RAMDrive        = 0x40;

        const string autorunKey = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer";

        public frmAutoRunSettings()
        {
            InitializeComponent();
            statusLabel.Text = "";
        }

        private void frmAutoRunSettings_Load(object sender, EventArgs e)
        {
            bool isAdmin = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) ? true : false;
            if (!isAdmin)
            {
                MessageBox.Show(Application.ProductName + " has to be run as Administrator!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                if (readSetting())
                {
                    statusLabel.Text = "Successfully read settings.";
                }
                else
                {
                    statusLabel.Text = "Failed to read settings.";
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (readSetting())
            {
                statusLabel.Text = "Successfully read settings.";
            }
            else
            {
                statusLabel.Text = "Failed to read settings.";
            }
        }

        private bool readSetting()
        {
            Int32 _setting;
            bool _success = false;
            try
            {
                _setting = (Int32)Registry.GetValue(autorunKey, "NoDriveTypeAutoRun", 0x0);

                if (_setting - RAMDrive > 0)
                {
                    _setting -= RAMDrive;
                    chkRamDisk.Checked = true;
                }

                if (_setting - OpticalDrive > 0)
                {
                    _setting -= OpticalDrive;
                    chkOpticalMedia.Checked = true;
                }

                if (_setting - NetworkDrive > 0)
                {
                    _setting -= NetworkDrive;
                    chkNetwork.Checked = true;
                }

                if (_setting - USBDrive > 0)
                {
                    _setting -= USBDrive;
                    chkUSB.Checked = true;
                }

                if (_setting == UnknownDrive)
                {
                    chkUnknown.Checked = true;
                }
                _success = true;
            }
            catch (Exception)
            {
                _success = false;
            }
            return _success;
        }

        private bool writeSetting(Int32 _setting)
        {
            bool _success;
            try
            {
                Registry.SetValue(autorunKey, "NoDriveTypeAutoRun", _setting);
                _success = true;
            }
            catch (Exception)
            {
                _success = false;
            }
            return _success;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Int32 _newSetting = 0x0;
            
            if (chkUnknown.Checked)
                _newSetting += UnknownDrive;

            if (chkUSB.Checked)
                _newSetting += USBDrive;

            if (chkNetwork.Checked)
                _newSetting += NetworkDrive;

            if (chkOpticalMedia.Checked)
                _newSetting += OpticalDrive;

            if (chkRamDisk.Checked)
                _newSetting += RAMDrive;

            if (writeSetting(_newSetting))
            {
                statusLabel.Text = "Successfully wrote settings. Reboot to apply changes.";
            }
            else
            {
                statusLabel.Text = "Failed to write settings.";
            }
            
        }
    }
}
