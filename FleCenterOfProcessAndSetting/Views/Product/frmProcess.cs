﻿using FleCenterOfProcessAndSetting.Views.Processes.Initialinspection;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FleCenterOfProcessAndSetting.Views.Product
{
    public partial class frmProcess : Form
    {

        public frmProcess()
        {
            InitializeComponent();
        }

        #region move form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void lblProgramName_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picManimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        #endregion

        private void btnInitialInspection_Click(object sender, EventArgs e)
        {
            frmInitialinspectionSetting frmInitialinspectionSetting = new frmInitialinspectionSetting();
            frmInitialinspectionSetting.ShowDialog();
        }
    }
}
