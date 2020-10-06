using CommonClassLibrary;
using CustomUIClassLibrary;
using FleInitialInspectionManagement.Controller;
using FleInitialInspectionManagement.Property;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FleCenterOfProcessAndSetting.Views.Processes.Initialinspection
{
    public partial class frmInitialinspectionSettingDetailManage : Form
    {
        public frmInitialinspectionSettingDetailManage()
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

        FleInitialInspectionSettingDetailController _fleInitialInspectionSettingDetailController = new FleInitialInspectionSettingDetailController();

        private void frmInitialinspectionSettingDetailManage_Load(object sender, System.EventArgs e)
        {

            if (CommonClassLibraryGlobal.FORM_ACTION_MODE == "Add")
            {
                FleInitialInspectionSettingDetailProperty item = _fleInitialInspectionSettingDetailController.SearchMaxStep(new FleInitialInspectionSettingDetailProperty { PURCHASE_NO = frmProductSpecSetting.PURCHASE_NO });
                STEP_NO.Text = item.STEP_NUMBER;
            }
            else
            {
                STEP_NO.Text = frmInitialinspectionSettingDetail.STEP_NO;
                List<FleInitialInspectionSettingDetailProperty> listItem = _fleInitialInspectionSettingDetailController.SearchByPurchase(new FleInitialInspectionSettingDetailProperty { PURCHASE_NO = frmProductSpecSetting.PURCHASE_NO });

                if (listItem.Count > 1)
                {
                    CommonClassLibraryGlobal.showError("Spec มีมากกว่า 1 แถว กรุณาติดต่อโปรแกรมเมอร์");
                    this.Dispose();
                }

                setOldValue(listItem[0]);

                //foreach (FleInitialInspectionSettingDetailProperty item in listItem)
                //{
                //    SRS.CheckNeed = bool.Parse(item.SRS_NEED);
                //    if (bool.Parse(item.SRS_NEED))
                //    {

                //    }
                //}

            }

            PURCHASE_NO.Text = frmProductSpecSetting.PURCHASE_NO;
            FFT_CODE.Text = frmProductSpecSetting.FFT_CODE;
            PRODUCT_TITLE.Text = frmProductSpecSetting.PRODUCT_TITLE;


            btnSave.Focus();
        }

        private void setOldValue(FleInitialInspectionSettingDetailProperty data)
        {
            foreach (Control toolBox in this.Controls)
            {
                if (toolBox is SettingSpec_Need_NoneSpec_MinMax)
                {

                    SettingSpec_Need_NoneSpec_MinMax tool = (SettingSpec_Need_NoneSpec_MinMax)toolBox;


                    PropertyInfo prop = null;

                    prop = data.GetType().GetProperty(toolBox.Name + "_NEED", BindingFlags.Public | BindingFlags.Instance);

                    if (null != prop && prop.CanWrite)
                    {

                        prop.SetValue(data, tool.CheckNeed == true ? "1" : "0", null);
                    }
                    else
                    {
                        CommonClassLibraryGlobal.showError("ไม่สามารถเก็บค่าตัวแปรได้ '" + toolBox.Name + "' กรุณาติดต่อโปรแกรมเมอร์");
                        return;
                    }

                    prop = data.GetType().GetProperty(toolBox.Name + "_NONE_SPEC", BindingFlags.Public | BindingFlags.Instance);
                    if (null != prop && prop.CanWrite)
                    {
                        prop.SetValue(data, tool.CheckNonSpec == true ? "1" : "0", null);
                    }
                    else
                    {
                        CommonClassLibraryGlobal.showError("ไม่สามารถเก็บค่าตัวแปรได้ '" + toolBox.Name + "' กรุณาติดต่อโปรแกรมเมอร์");
                        return;
                    }

                    prop = data.GetType().GetProperty(toolBox.Name + "_MIN", BindingFlags.Public | BindingFlags.Instance);
                    if (null != prop && prop.CanWrite)
                    {
                        prop.SetValue(data, tool.SpecMin, null);
                    }
                    else
                    {
                        CommonClassLibraryGlobal.showError("ไม่สามารถเก็บค่าตัวแปรได้ '" + toolBox.Name + "' กรุณาติดต่อโปรแกรมเมอร์");
                        return;
                    }

                    prop = data.GetType().GetProperty(toolBox.Name + "_MAX", BindingFlags.Public | BindingFlags.Instance);
                    if (null != prop && prop.CanWrite)
                    {
                        prop.SetValue(data, tool.SpecMax, null);
                    }
                    else
                    {
                        CommonClassLibraryGlobal.showError("ไม่สามารถเก็บค่าตัวแปรได้ '" + toolBox.Name + "' กรุณาติดต่อโปรแกรมเมอร์");
                        return;
                    }

                }

                if (toolBox is SettingSpec_Need_NoneSpec)
                {

                    SettingSpec_Need_NoneSpec tool = (SettingSpec_Need_NoneSpec)toolBox;


                    PropertyInfo prop = null;

                    prop = data.GetType().GetProperty(toolBox.Name + "_NEED", BindingFlags.Public | BindingFlags.Instance);

                    if (null != prop && prop.CanWrite)
                    {

                        prop.GetValue(data, null).ToString();
                        //  tool.CheckNeed = bool.Parse(prop.GetValue(data, null).ToString());

                        //prop.SetValue(data.GetType().GetProperty(toolBox.Name + "_NEED", BindingFlags.Public | BindingFlags.Instance));

                        //prop.SetValue(data, tool.CheckNeed == true ? "1" : "0", null);
                    }
                    else
                    {
                        CommonClassLibraryGlobal.showError("ไม่สามารถเก็บค่าตัวแปรได้ '" + toolBox.Name + "' กรุณาติดต่อโปรแกรมเมอร์");
                        return;
                    }

                    prop = data.GetType().GetProperty(toolBox.Name + "_NONE_SPEC", BindingFlags.Public | BindingFlags.Instance);
                    if (null != prop && prop.CanWrite)
                    {
                        prop.SetValue(data, tool.CheckNonSpec == true ? "1" : "0", null);
                    }
                    else
                    {
                        CommonClassLibraryGlobal.showError("ไม่สามารถเก็บค่าตัวแปรได้ '" + toolBox.Name + "' กรุณาติดต่อโปรแกรมเมอร์");
                        return;
                    }

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("ยืนยันการบันทึกข้อมูล ?", "message", buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            FleInitialInspectionSettingDetailProperty data = new FleInitialInspectionSettingDetailProperty();

            //======================================== Target =========================================================================
            if (rbTargetVoltage.Checked == false && rbTargetPower.Checked == false)
            {
                CommonClassLibraryGlobal.showError("กรุณาเลือก Target");
                return;
            }

            if (!double.TryParse(txtTargetValue.Text, out CommonClassLibraryGlobal.chkDouble))
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก Target Value เป็นตัวเลขเท่านั้น");
                txtTargetValue.Text = "";
                txtTargetValue.Focus();
                return;
            }

            if (rbTargetVoltage.Checked == true && (double.Parse(txtTargetValue.Text) > Properties.Settings.Default.MAX_VOLTAGE))
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก Target Value ให้น้อยกว่าหรือเท่ากับ " + Properties.Settings.Default.MAX_VOLTAGE);
                txtTargetValue.Text = "";
                txtTargetValue.Focus();
                return;
            }

            data.PURCHASE_NO = frmProductSpecSetting.PURCHASE_NO;
            data.STEP_NUMBER = STEP_NO.Text;
            data.TARGET_NAME = rbTargetVoltage.Checked == true ? "Voltage" : "Power";
            data.TARGET_VALUE = txtTargetValue.Text;

            //var listToolBox = new List<string>()
            //        {
            //            "SRS",
            //            "LD_CERRENT",
            //            "ALARM_REF_FUSE",
            //            "ALARM_LDI_MAX"
            //        };

            //foreach (string toolBox in listToolBox)
            //{

            //    Type type = Type.GetType(SettingSpec_Need_NoneSpec_MinMax);
            //    object instance = Activator.CreateInstance(type);

            //    if (!SettingSpec_Need_NoneSpec_MinMax.checkData(type)
            //    {
            //        return;
            //    }
            //}



            foreach (Control toolBox in this.Controls)
            {
                if (toolBox is SettingSpec_Need_NoneSpec_MinMax)
                {

                    SettingSpec_Need_NoneSpec_MinMax tool = (SettingSpec_Need_NoneSpec_MinMax)toolBox;

                    if (!SettingSpec_Need_NoneSpec_MinMax.checkData(tool))
                    {
                        return;
                    }
                    else
                    {
                        PropertyInfo prop = null;

                        prop = data.GetType().GetProperty(toolBox.Name + "_NEED", BindingFlags.Public | BindingFlags.Instance);
                        if (null != prop && prop.CanWrite)
                        {
                            prop.SetValue(data, tool.CheckNeed == true ? "1" : "0", null);
                        }
                        else
                        {
                            CommonClassLibraryGlobal.showError("ไม่สามารถเก็บค่าตัวแปรได้ '" + toolBox.Name + "' กรุณาติดต่อโปรแกรมเมอร์");
                            return;
                        }

                        prop = data.GetType().GetProperty(toolBox.Name + "_NONE_SPEC", BindingFlags.Public | BindingFlags.Instance);
                        if (null != prop && prop.CanWrite)
                        {
                            prop.SetValue(data, tool.CheckNonSpec == true ? "1" : "0", null);
                        }
                        else
                        {
                            CommonClassLibraryGlobal.showError("ไม่สามารถเก็บค่าตัวแปรได้ '" + toolBox.Name + "' กรุณาติดต่อโปรแกรมเมอร์");
                            return;
                        }

                        prop = data.GetType().GetProperty(toolBox.Name + "_MIN", BindingFlags.Public | BindingFlags.Instance);
                        if (null != prop && prop.CanWrite)
                        {
                            prop.SetValue(data, tool.SpecMin, null);
                        }
                        else
                        {
                            CommonClassLibraryGlobal.showError("ไม่สามารถเก็บค่าตัวแปรได้ '" + toolBox.Name + "' กรุณาติดต่อโปรแกรมเมอร์");
                            return;
                        }

                        prop = data.GetType().GetProperty(toolBox.Name + "_MAX", BindingFlags.Public | BindingFlags.Instance);
                        if (null != prop && prop.CanWrite)
                        {
                            prop.SetValue(data, tool.SpecMax, null);
                        }
                        else
                        {
                            CommonClassLibraryGlobal.showError("ไม่สามารถเก็บค่าตัวแปรได้ '" + toolBox.Name + "' กรุณาติดต่อโปรแกรมเมอร์");
                            return;
                        }

                    }
                }

                if (toolBox is SettingSpec_Need_NoneSpec)
                {

                    SettingSpec_Need_NoneSpec tool = (SettingSpec_Need_NoneSpec)toolBox;

                    if (!SettingSpec_Need_NoneSpec.checkData((SettingSpec_Need_NoneSpec)toolBox))
                    {
                        return;
                    }
                    else
                    {
                        PropertyInfo prop = null;

                        prop = data.GetType().GetProperty(toolBox.Name + "_NEED", BindingFlags.Public | BindingFlags.Instance);
                        if (null != prop && prop.CanWrite)
                        {
                            prop.SetValue(data, tool.CheckNeed == true ? "1" : "0", null);
                        }
                        else
                        {
                            CommonClassLibraryGlobal.showError("ไม่สามารถเก็บค่าตัวแปรได้ '" + toolBox.Name + "' กรุณาติดต่อโปรแกรมเมอร์");
                            return;
                        }

                        prop = data.GetType().GetProperty(toolBox.Name + "_NONE_SPEC", BindingFlags.Public | BindingFlags.Instance);
                        if (null != prop && prop.CanWrite)
                        {
                            prop.SetValue(data, tool.CheckNonSpec == true ? "1" : "0", null);
                        }
                        else
                        {
                            CommonClassLibraryGlobal.showError("ไม่สามารถเก็บค่าตัวแปรได้ '" + toolBox.Name + "' กรุณาติดต่อโปรแกรมเมอร์");
                            return;
                        }
                    }
                }
            }

            if (_fleInitialInspectionSettingDetailController.Insert(data))

            {
                CommonClassLibraryGlobal.showSaveDatabaseSuccess();
            }
            else
            {
                CommonClassLibraryGlobal.showSaveDatabaseError();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("ยืนยันการล้างข้อมูล ?", "message", buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            rbTargetVoltage.Checked = false;
            rbTargetPower.Checked = false;
            txtTargetValue.Text = "";

            foreach (Control toolBox in this.Controls)
            {
                if (toolBox is SettingSpec_Need_NoneSpec_MinMax)
                {
                    SettingSpec_Need_NoneSpec_MinMax tool = (SettingSpec_Need_NoneSpec_MinMax)toolBox;
                    tool.clearToDefault();
                }

                if (toolBox is SettingSpec_Need_NoneSpec)
                {
                    SettingSpec_Need_NoneSpec tool = (SettingSpec_Need_NoneSpec)toolBox;
                    tool.clearToDefault();
                }
            }

        }

        private void rbTargetVoltage_CheckedChanged(object sender, EventArgs e)
        {
            txtTargetValue.Text = "";
        }

        private void rbTargetPower_CheckedChanged(object sender, EventArgs e)
        {
            txtTargetValue.Text = "";
        }

        private void picTooltip_Click(object sender, EventArgs e)
        {

        }
    }
}
