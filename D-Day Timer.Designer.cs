namespace BarCitizenKR
{
    partial class frmDdayTimer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDdayTimer));
            timer = new System.Windows.Forms.Timer(components);
            leftDate = new Label();
            leftTime = new Label();
            lblUntil = new Label();
            untilDate = new Label();
            untilTime = new Label();
            lblRemaining = new Label();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Interval = 10;
            timer.Tick += timer_Tick;
            // 
            // leftDate
            // 
            leftDate.AutoSize = true;
            leftDate.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            leftDate.ImageAlign = ContentAlignment.MiddleRight;
            leftDate.Location = new Point(79, 9);
            leftDate.Name = "leftDate";
            leftDate.Size = new Size(175, 33);
            leftDate.TabIndex = 1;
            leftDate.Text = "0000-00-00";
            leftDate.TextAlign = ContentAlignment.MiddleRight;
            leftDate.DoubleClick += frmDdayTimer_DoubleClick;
            leftDate.MouseLeave += frmDdayTimer_MouseLeave;
            leftDate.MouseHover += frmDdayTimer_MouseHover;
            // 
            // leftTime
            // 
            leftTime.AutoSize = true;
            leftTime.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            leftTime.Location = new Point(79, 42);
            leftTime.Name = "leftTime";
            leftTime.Size = new Size(196, 33);
            leftTime.TabIndex = 6;
            leftTime.Text = "00:00:00.000";
            leftTime.TextAlign = ContentAlignment.MiddleRight;
            leftTime.DoubleClick += frmDdayTimer_DoubleClick;
            leftTime.MouseLeave += frmDdayTimer_MouseLeave;
            leftTime.MouseHover += frmDdayTimer_MouseHover;
            // 
            // lblUntil
            // 
            lblUntil.Anchor = AnchorStyles.Right;
            lblUntil.ImageAlign = ContentAlignment.MiddleRight;
            lblUntil.Location = new Point(12, 75);
            lblUntil.Name = "lblUntil";
            lblUntil.Size = new Size(61, 15);
            lblUntil.TabIndex = 10;
            lblUntil.Text = "until";
            lblUntil.TextAlign = ContentAlignment.MiddleRight;
            lblUntil.DoubleClick += frmDdayTimer_DoubleClick;
            lblUntil.MouseLeave += frmDdayTimer_MouseLeave;
            lblUntil.MouseHover += frmDdayTimer_MouseHover;
            // 
            // untilDate
            // 
            untilDate.AutoSize = true;
            untilDate.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            untilDate.Location = new Point(79, 75);
            untilDate.Name = "untilDate";
            untilDate.Size = new Size(175, 33);
            untilDate.TabIndex = 1;
            untilDate.Text = "0000-00-00";
            untilDate.TextAlign = ContentAlignment.MiddleRight;
            untilDate.DoubleClick += frmDdayTimer_DoubleClick;
            untilDate.MouseLeave += frmDdayTimer_MouseLeave;
            untilDate.MouseHover += frmDdayTimer_MouseHover;
            // 
            // untilTime
            // 
            untilTime.AutoSize = true;
            untilTime.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            untilTime.Location = new Point(79, 108);
            untilTime.Name = "untilTime";
            untilTime.Size = new Size(137, 33);
            untilTime.TabIndex = 6;
            untilTime.Text = "00:00:00";
            untilTime.TextAlign = ContentAlignment.MiddleRight;
            untilTime.DoubleClick += frmDdayTimer_DoubleClick;
            untilTime.MouseLeave += frmDdayTimer_MouseLeave;
            untilTime.MouseHover += frmDdayTimer_MouseHover;
            // 
            // lblRemaining
            // 
            lblRemaining.Anchor = AnchorStyles.Right;
            lblRemaining.ImageAlign = ContentAlignment.MiddleRight;
            lblRemaining.Location = new Point(12, 9);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(61, 15);
            lblRemaining.TabIndex = 11;
            lblRemaining.Text = "remaining";
            lblRemaining.TextAlign = ContentAlignment.MiddleRight;
            lblRemaining.DoubleClick += frmDdayTimer_DoubleClick;
            lblRemaining.MouseLeave += frmDdayTimer_MouseLeave;
            lblRemaining.MouseHover += frmDdayTimer_MouseHover;
            // 
            // frmDdayTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(287, 150);
            Controls.Add(lblRemaining);
            Controls.Add(lblUntil);
            Controls.Add(untilTime);
            Controls.Add(leftTime);
            Controls.Add(untilDate);
            Controls.Add(leftDate);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDdayTimer";
            Opacity = 0.5D;
            ShowInTaskbar = false;
            Text = "Bar Citizen Korea";
            DoubleClick += frmDdayTimer_DoubleClick;
            MouseLeave += frmDdayTimer_MouseLeave;
            MouseHover += frmDdayTimer_MouseHover;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Timer timer;
        private Label leftDate;
        private Label lblDay;
        private Label label1;
        private Label leftTime;
        private Label lblUntil;
        private Label untilDate;
        private Label untilTime;
        private Label lblRemaining;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Right) // 마우스 우클릭 확인
            {
                // 우클릭 시 실행할 동작
                
            }
        }
    }
}
