namespace FleCenterOfProcessAndSetting.Views.Product
{
    partial class frmProcess
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
            this.btnInitialInspection = new System.Windows.Forms.Button();
            this.btnCurrentMonitorTuning = new System.Windows.Forms.Button();
            this.btnOutputMonitorTuning = new System.Windows.Forms.Button();
            this.btnVlTuning = new System.Windows.Forms.Button();
            this.btnInspection = new System.Windows.Forms.Button();
            this.btnBurnIn = new System.Windows.Forms.Button();
            this.btnOutputStability = new System.Windows.Forms.Button();
            this.btnDigitalSignalModulation = new System.Windows.Forms.Button();
            this.btnAnalogSignalModulation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManimise)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(962, 70);
            this.label5.TabIndex = 688;
            this.label5.Text = "Processes";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblProgramName_MouseMove);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::FleCenterOfProcessAndSetting.Properties.Resources.power_white;
            this.picClose.Location = new System.Drawing.Point(930, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(20, 20);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 689;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picManimise
            // 
            this.picManimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picManimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picManimise.Image = global::FleCenterOfProcessAndSetting.Properties.Resources.minus_white;
            this.picManimise.Location = new System.Drawing.Point(898, 12);
            this.picManimise.Name = "picManimise";
            this.picManimise.Size = new System.Drawing.Size(20, 20);
            this.picManimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManimise.TabIndex = 690;
            this.picManimise.TabStop = false;
            this.picManimise.Click += new System.EventHandler(this.picManimise_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnInitialInspection);
            this.flowLayoutPanel1.Controls.Add(this.btnCurrentMonitorTuning);
            this.flowLayoutPanel1.Controls.Add(this.btnOutputMonitorTuning);
            this.flowLayoutPanel1.Controls.Add(this.btnVlTuning);
            this.flowLayoutPanel1.Controls.Add(this.btnInspection);
            this.flowLayoutPanel1.Controls.Add(this.btnBurnIn);
            this.flowLayoutPanel1.Controls.Add(this.btnOutputStability);
            this.flowLayoutPanel1.Controls.Add(this.btnDigitalSignalModulation);
            this.flowLayoutPanel1.Controls.Add(this.btnAnalogSignalModulation);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(60, 93);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(833, 366);
            this.flowLayoutPanel1.TabIndex = 694;
            // 
            // btnInitialInspection
            // 
            this.btnInitialInspection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.btnInitialInspection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInitialInspection.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInitialInspection.FlatAppearance.BorderSize = 0;
            this.btnInitialInspection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitialInspection.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitialInspection.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInitialInspection.Location = new System.Drawing.Point(35, 35);
            this.btnInitialInspection.Margin = new System.Windows.Forms.Padding(20);
            this.btnInitialInspection.Name = "btnInitialInspection";
            this.btnInitialInspection.Size = new System.Drawing.Size(223, 73);
            this.btnInitialInspection.TabIndex = 483;
            this.btnInitialInspection.Text = "Initial Inspection";
            this.btnInitialInspection.UseVisualStyleBackColor = false;
            this.btnInitialInspection.Click += new System.EventHandler(this.btnInitialInspection_Click);
            // 
            // btnCurrentMonitorTuning
            // 
            this.btnCurrentMonitorTuning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.btnCurrentMonitorTuning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurrentMonitorTuning.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCurrentMonitorTuning.FlatAppearance.BorderSize = 0;
            this.btnCurrentMonitorTuning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentMonitorTuning.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentMonitorTuning.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCurrentMonitorTuning.Location = new System.Drawing.Point(298, 35);
            this.btnCurrentMonitorTuning.Margin = new System.Windows.Forms.Padding(20);
            this.btnCurrentMonitorTuning.Name = "btnCurrentMonitorTuning";
            this.btnCurrentMonitorTuning.Size = new System.Drawing.Size(223, 73);
            this.btnCurrentMonitorTuning.TabIndex = 485;
            this.btnCurrentMonitorTuning.Text = "Current Monitor Tuning (ข้าวปุ้น)";
            this.btnCurrentMonitorTuning.UseVisualStyleBackColor = false;
            // 
            // btnOutputMonitorTuning
            // 
            this.btnOutputMonitorTuning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.btnOutputMonitorTuning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutputMonitorTuning.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOutputMonitorTuning.FlatAppearance.BorderSize = 0;
            this.btnOutputMonitorTuning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutputMonitorTuning.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputMonitorTuning.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOutputMonitorTuning.Location = new System.Drawing.Point(561, 35);
            this.btnOutputMonitorTuning.Margin = new System.Windows.Forms.Padding(20);
            this.btnOutputMonitorTuning.Name = "btnOutputMonitorTuning";
            this.btnOutputMonitorTuning.Size = new System.Drawing.Size(223, 73);
            this.btnOutputMonitorTuning.TabIndex = 484;
            this.btnOutputMonitorTuning.Text = "Output Monitor Tuning พี่ปอ";
            this.btnOutputMonitorTuning.UseVisualStyleBackColor = false;
            // 
            // btnVlTuning
            // 
            this.btnVlTuning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(235)))), ((int)(((byte)(198)))));
            this.btnVlTuning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVlTuning.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVlTuning.FlatAppearance.BorderSize = 0;
            this.btnVlTuning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVlTuning.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVlTuning.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVlTuning.Location = new System.Drawing.Point(35, 148);
            this.btnVlTuning.Margin = new System.Windows.Forms.Padding(20);
            this.btnVlTuning.Name = "btnVlTuning";
            this.btnVlTuning.Size = new System.Drawing.Size(223, 73);
            this.btnVlTuning.TabIndex = 489;
            this.btnVlTuning.Text = "VL tuning พี่ปอ";
            this.btnVlTuning.UseVisualStyleBackColor = false;
            // 
            // btnInspection
            // 
            this.btnInspection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(235)))), ((int)(((byte)(198)))));
            this.btnInspection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInspection.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInspection.FlatAppearance.BorderSize = 0;
            this.btnInspection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInspection.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInspection.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInspection.Location = new System.Drawing.Point(298, 148);
            this.btnInspection.Margin = new System.Windows.Forms.Padding(20);
            this.btnInspection.Name = "btnInspection";
            this.btnInspection.Size = new System.Drawing.Size(223, 73);
            this.btnInspection.TabIndex = 488;
            this.btnInspection.Text = "Inspection";
            this.btnInspection.UseVisualStyleBackColor = false;
            // 
            // btnBurnIn
            // 
            this.btnBurnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(235)))), ((int)(((byte)(198)))));
            this.btnBurnIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBurnIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBurnIn.FlatAppearance.BorderSize = 0;
            this.btnBurnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBurnIn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurnIn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBurnIn.Location = new System.Drawing.Point(561, 148);
            this.btnBurnIn.Margin = new System.Windows.Forms.Padding(20);
            this.btnBurnIn.Name = "btnBurnIn";
            this.btnBurnIn.Size = new System.Drawing.Size(223, 73);
            this.btnBurnIn.TabIndex = 490;
            this.btnBurnIn.Text = "Burn In";
            this.btnBurnIn.UseVisualStyleBackColor = false;
            // 
            // btnOutputStability
            // 
            this.btnOutputStability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnOutputStability.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutputStability.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOutputStability.FlatAppearance.BorderSize = 0;
            this.btnOutputStability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutputStability.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputStability.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOutputStability.Location = new System.Drawing.Point(35, 261);
            this.btnOutputStability.Margin = new System.Windows.Forms.Padding(20);
            this.btnOutputStability.Name = "btnOutputStability";
            this.btnOutputStability.Size = new System.Drawing.Size(223, 73);
            this.btnOutputStability.TabIndex = 491;
            this.btnOutputStability.Text = "Output Stability";
            this.btnOutputStability.UseVisualStyleBackColor = false;
            // 
            // btnDigitalSignalModulation
            // 
            this.btnDigitalSignalModulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDigitalSignalModulation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDigitalSignalModulation.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDigitalSignalModulation.FlatAppearance.BorderSize = 0;
            this.btnDigitalSignalModulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDigitalSignalModulation.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigitalSignalModulation.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDigitalSignalModulation.Location = new System.Drawing.Point(298, 261);
            this.btnDigitalSignalModulation.Margin = new System.Windows.Forms.Padding(20);
            this.btnDigitalSignalModulation.Name = "btnDigitalSignalModulation";
            this.btnDigitalSignalModulation.Size = new System.Drawing.Size(223, 73);
            this.btnDigitalSignalModulation.TabIndex = 492;
            this.btnDigitalSignalModulation.Text = "Digital Signal Modulation\r\n";
            this.btnDigitalSignalModulation.UseVisualStyleBackColor = false;
            // 
            // btnAnalogSignalModulation
            // 
            this.btnAnalogSignalModulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAnalogSignalModulation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalogSignalModulation.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAnalogSignalModulation.FlatAppearance.BorderSize = 0;
            this.btnAnalogSignalModulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalogSignalModulation.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalogSignalModulation.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAnalogSignalModulation.Location = new System.Drawing.Point(561, 261);
            this.btnAnalogSignalModulation.Margin = new System.Windows.Forms.Padding(20);
            this.btnAnalogSignalModulation.Name = "btnAnalogSignalModulation";
            this.btnAnalogSignalModulation.Size = new System.Drawing.Size(223, 73);
            this.btnAnalogSignalModulation.TabIndex = 493;
            this.btnAnalogSignalModulation.Text = "Analog Signal Modulation\r\n";
            this.btnAnalogSignalModulation.UseVisualStyleBackColor = false;
            // 
            // frmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(962, 518);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picManimise);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProcess";
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManimise)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picManimise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal System.Windows.Forms.Button btnInitialInspection;
        internal System.Windows.Forms.Button btnCurrentMonitorTuning;
        internal System.Windows.Forms.Button btnOutputMonitorTuning;
        internal System.Windows.Forms.Button btnVlTuning;
        internal System.Windows.Forms.Button btnInspection;
        internal System.Windows.Forms.Button btnBurnIn;
        internal System.Windows.Forms.Button btnOutputStability;
        internal System.Windows.Forms.Button btnDigitalSignalModulation;
        internal System.Windows.Forms.Button btnAnalogSignalModulation;
    }
}