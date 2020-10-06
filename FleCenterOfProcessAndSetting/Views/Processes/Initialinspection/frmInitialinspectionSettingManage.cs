using System;
using System.Windows.Forms;

namespace FleCenterOfProcessAndSetting.Views.Processes.Initialinspection
{
    public partial class frmInitialinspectionSettingManage : Form
    {
        public frmInitialinspectionSettingManage()
        {
            InitializeComponent();
        }

        public string PURCHASE_NO;

        private void InitialinspectionSettingManage_Load(object sender, EventArgs e)
        {
            PURCHASE_NO = frmInitialinspectionSetting.PURCHASE_NO;
        }
    }
}
