using CommonClassLibrary;
using FleInitialInspectionManagement.Controller;
using FleInitialInspectionManagement.Property;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FleCenterOfProcessAndSetting.Views.Processes.Initialinspection
{
    public partial class frmInitialinspectionSettingDetail : Form
    {
        public frmInitialinspectionSettingDetail()
        {
            InitializeComponent();
        }

        public static string STEP_ID = "";
        public static string STEP_NO = "";

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


        FleInitialInspectionSettingDetailController _fleInitialInspectionSettingDetailController = new FleInitialInspectionSettingDetailController();

        private void frmInitialinspectionSettingDetail_Load(object sender, EventArgs e)
        {
            getDetail();
        }
        private string getDetail()
        {

            dataGridView1.Rows.Clear();
            List<FleInitialInspectionSettingDetailProperty> dataListItem = _fleInitialInspectionSettingDetailController.SearchByPurchase(new FleInitialInspectionSettingDetailProperty { PURCHASE_NO = frmProductSpecSetting.PURCHASE_NO });

            foreach (FleInitialInspectionSettingDetailProperty item in dataListItem)
            {
                dataGridView1.Rows.Add(item.STEP_NUMBER, item.TARGET_NAME, item.TARGET_VALUE, "Edit", "Delete");
            }

            return "success";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CommonClassLibraryGlobal.FORM_ACTION_MODE = "Add";
            STEP_ID = "";
            STEP_NO = "";
            frmInitialinspectionSettingDetailManage _frmInitialinspectionSettingDetailManage = new frmInitialinspectionSettingDetailManage();
            _frmInitialinspectionSettingDetailManage.ShowDialog();
            getDetail();
            _frmInitialinspectionSettingDetailManage.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (e.RowIndex >= 0))
            {

                switch (e.ColumnIndex)
                {
                    case 3:

                        CommonClassLibraryGlobal.FORM_ACTION_MODE = "Edit";
                        STEP_ID = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                        STEP_NO = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                        frmInitialinspectionSettingDetailManage _frmInitialinspectionSettingDetailManage = new frmInitialinspectionSettingDetailManage();

                        _frmInitialinspectionSettingDetailManage.ShowDialog();
                        getDetail();
                        _frmInitialinspectionSettingDetailManage.Close();
                        break;

                    case 4:
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Are your sure ?", "Message", buttons, MessageBoxIcon.Warning);

                        if (result == DialogResult.No)
                        {
                            return;
                        }
                        else
                        {

                            if (_fleInitialInspectionSettingDetailController.DeleteById(new FleInitialInspectionSettingDetailProperty { ID = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString() }))
                            {
                                CommonClassLibraryGlobal.showSuccess("ลบข้อมูลสำเร็จ");
                                getDetail();
                            }
                            else
                            {
                                CommonClassLibraryGlobal.showSuccess("ลบข้อมูลไม่สำเร็จ กรุณาลองใหม่อีกครั้ง");

                            }

                        }

                        break;


                }


            }
        }
    }
}
