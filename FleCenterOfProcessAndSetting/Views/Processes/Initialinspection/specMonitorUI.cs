using System;
using System.Drawing;
using System.Windows.Forms;

namespace FleCenterOfProcessAndSetting.Views.Processes.Initialinspection
{
    public partial class specMonitorUI : UserControl
    {
        Color colorLayout = Color.White;

        public specMonitorUI()
        {
            InitializeComponent();
        }

        public string HeaderLabel
        {
            get { return lblHeader.Text; }
            set { lblHeader.Text = value; }
        }

        public bool CheckNeed
        {
            get { return rdoNeed.Checked; }
            set { rdoNeed.Checked = value; }
        }
        public bool CheckNoNeed
        {
            get { return rdoNoNeed.Checked; }
            set { rdoNoNeed.Checked = value; }
        }
        public bool CheckNonSpec
        {
            get { return chkNoneSpec.Checked; }
            set { chkNoneSpec.Checked = value; }
        }

        public Color LayoutColor
        {
            get
            {
                return colorLayout;
            }
            set
            {
                colorLayout = value;
                SetColor(colorLayout);
            }

        }
        private void SetColor(Color colorLayout)
        {
            this.lblHeader.ForeColor = colorLayout;
            this.panel2.BackColor = colorLayout;
            this.panel3.BackColor = colorLayout;
            this.panel4.BackColor = colorLayout;
            this.panel5.BackColor = colorLayout;
            this.panel11.BackColor = colorLayout;
        }

        private void rdoNeed_CheckedChanged(object sender, EventArgs e)
        {

            if (rdoNeed.Checked == true)
            {
                pnlNoneSpec.Visible = true;
            }

        }

        private void rdoNoNeed_CheckedChanged(object sender, EventArgs e)
        {


            if (rdoNoNeed.Checked == true)
            {
                pnlNoneSpec.Visible = false;
            }

        }
    }
}
