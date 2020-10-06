namespace FleCenterOfProcessAndSetting.Views.Processes.Initialinspection
{
    partial class frmInitialinspectionSetting
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
            this.label5 = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picManimise = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCommonSpec = new System.Windows.Forms.Button();
            this.btnStepSpec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManimise)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(845, 70);
            this.label5.TabIndex = 18;
            this.label5.Text = "Initial Inspection Setting";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblProgramName_MouseMove);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::FleCenterOfProcessAndSetting.Properties.Resources.power_white;
            this.picClose.Location = new System.Drawing.Point(813, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(20, 20);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 683;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picManimise
            // 
            this.picManimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picManimise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.picManimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picManimise.Image = global::FleCenterOfProcessAndSetting.Properties.Resources.minus_white;
            this.picManimise.Location = new System.Drawing.Point(781, 12);
            this.picManimise.Name = "picManimise";
            this.picManimise.Size = new System.Drawing.Size(20, 20);
            this.picManimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManimise.TabIndex = 684;
            this.picManimise.TabStop = false;
            this.picManimise.Click += new System.EventHandler(this.picManimise_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCommonSpec);
            this.flowLayoutPanel1.Controls.Add(this.btnStepSpec);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(143, 125);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(559, 165);
            this.flowLayoutPanel1.TabIndex = 695;
            // 
            // btnCommonSpec
            // 
            this.btnCommonSpec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.btnCommonSpec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCommonSpec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCommonSpec.FlatAppearance.BorderSize = 0;
            this.btnCommonSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommonSpec.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommonSpec.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCommonSpec.Location = new System.Drawing.Point(35, 35);
            this.btnCommonSpec.Margin = new System.Windows.Forms.Padding(20);
            this.btnCommonSpec.Name = "btnCommonSpec";
            this.btnCommonSpec.Size = new System.Drawing.Size(223, 73);
            this.btnCommonSpec.TabIndex = 483;
            this.btnCommonSpec.Text = "Common Spec";
            this.btnCommonSpec.UseVisualStyleBackColor = false;
            this.btnCommonSpec.Click += new System.EventHandler(this.btnCommonSpec_Click);
            // 
            // btnStepSpec
            // 
            this.btnStepSpec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(235)))), ((int)(((byte)(198)))));
            this.btnStepSpec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStepSpec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStepSpec.FlatAppearance.BorderSize = 0;
            this.btnStepSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStepSpec.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStepSpec.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnStepSpec.Location = new System.Drawing.Point(298, 35);
            this.btnStepSpec.Margin = new System.Windows.Forms.Padding(20);
            this.btnStepSpec.Name = "btnStepSpec";
            this.btnStepSpec.Size = new System.Drawing.Size(223, 73);
            this.btnStepSpec.TabIndex = 489;
            this.btnStepSpec.Text = "Step Spec";
            this.btnStepSpec.UseVisualStyleBackColor = false;
            this.btnStepSpec.Click += new System.EventHandler(this.btnStepSpec_Click);
            // 
            // frmInitialinspectionSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(845, 349);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picManimise);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInitialinspectionSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InitialinspectionSetting";
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManimise)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picManimise;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal System.Windows.Forms.Button btnCommonSpec;
        internal System.Windows.Forms.Button btnStepSpec;
    }
}