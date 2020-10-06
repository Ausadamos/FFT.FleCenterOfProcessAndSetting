using System;
using System.Drawing;
using System.Windows.Forms;

namespace FleCenterOfProcessAndSetting.Views.Processes.Initialinspection
{
    public partial class specUI : UserControl
    {
        Color colorLaouy = Color.White;

        public specUI()
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
        public string SpecMax
        {
            get { return txtMax.Text; }
            set { txtMax.Text = value; }
        }
        public string SpecMin
        {
            get { return txtMin.Text; }
            set { txtMin.Text = value; }
        }

        public Color LayoutColor
        {
            get
            {
                return colorLaouy;
            }
            set
            {
                colorLaouy = value;
                SetColor(colorLaouy);
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
            setMinMaxDefault();

            if (rdoNeed.Checked == true)
            {
                pnlNoneSpec.Visible = true;
                pnlMinMax.Visible = true;
            }

        }

        private void rdoNoNeed_CheckedChanged(object sender, EventArgs e)
        {
            setMinMaxDefault();

            if (rdoNoNeed.Checked == true)
            {
                pnlNoneSpec.Visible = false;
                pnlMinMax.Visible = false;
            }

        }

        private void chkNoneSpec_CheckedChanged(object sender, EventArgs e)
        {
            setMinMaxDefault();

            if (chkNoneSpec.Checked == true)
            {
                pnlMinMax.Visible = false;
            }
            else
            {
                pnlMinMax.Visible = true;
            }


        }

        private void setMinMaxDefault()
        {
            txtMin.Text = "";
            txtMax.Text = "";
        }
    }
}
