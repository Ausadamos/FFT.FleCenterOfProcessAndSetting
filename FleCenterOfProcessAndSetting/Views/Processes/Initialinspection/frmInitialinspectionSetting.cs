using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FleCenterOfProcessAndSetting.Views.Processes.Initialinspection
{
    public partial class frmInitialinspectionSetting : Form
    {
        public frmInitialinspectionSetting()
        {
            InitializeComponent();
        }

        public static string PURCHASE_NO = "";

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

        private void btnStepSpec_Click(object sender, EventArgs e)
        {
            frmInitialinspectionSettingDetail frmInitialinspectionSettingDetail = new frmInitialinspectionSettingDetail();
            frmInitialinspectionSettingDetail.ShowDialog();
        }

        private void btnCommonSpec_Click(object sender, EventArgs e)
        {
            frmInitialinspectionSettingManage frmInitialinspectionSettingManage = new frmInitialinspectionSettingManage();
            frmInitialinspectionSettingManage.ShowDialog();
        }
    }

}
