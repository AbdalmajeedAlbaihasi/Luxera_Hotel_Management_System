namespace HMSDesktop
{
    partial class fmLogIn
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmLogIn));
            butLogin = new Button();
            txtUserName = new TextBox();
            toolTip1 = new ToolTip(components);
            panelDown = new Panel();
            labelAllRights = new Label();
            groupBoxlogin = new GroupBox();
            pboxShow = new PictureBox();
            labelForget = new Label();
            lablePassword = new Label();
            txtBoxPassword = new TextBox();
            lableUserName = new Label();
            pboxHide = new PictureBox();
            panelLine = new Panel();
            pictureBox1 = new PictureBox();
            pboxminimize = new PictureBox();
            pboxClose = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            panelDown.SuspendLayout();
            groupBoxlogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxminimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxClose).BeginInit();
            SuspendLayout();
            // 
            // butLogin
            // 
            butLogin.Anchor = AnchorStyles.None;
            butLogin.BackColor = Color.SkyBlue;
            butLogin.FlatAppearance.BorderSize = 0;
            butLogin.FlatStyle = FlatStyle.Flat;
            butLogin.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butLogin.ForeColor = Color.Black;
            butLogin.Location = new Point(157, 303);
            butLogin.Name = "butLogin";
            butLogin.Size = new Size(267, 35);
            butLogin.TabIndex = 3;
            butLogin.Text = "Login";
            butLogin.UseVisualStyleBackColor = false;
            butLogin.Click += butLogin_Click;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.None;
            txtUserName.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(157, 140);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(267, 23);
            txtUserName.TabIndex = 1;
            // 
            // panelDown
            // 
            panelDown.Anchor = AnchorStyles.None;
            panelDown.Controls.Add(labelAllRights);
            panelDown.Location = new Point(0, 618);
            panelDown.Name = "panelDown";
            panelDown.Size = new Size(1366, 102);
            panelDown.TabIndex = 0;
            panelDown.Paint += panelDown_Paint;
            // 
            // labelAllRights
            // 
            labelAllRights.Anchor = AnchorStyles.Bottom;
            labelAllRights.AutoSize = true;
            labelAllRights.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAllRights.Location = new Point(437, 52);
            labelAllRights.Name = "labelAllRights";
            labelAllRights.Size = new Size(532, 20);
            labelAllRights.TabIndex = 0;
            labelAllRights.Text = "© 2026 All Rights Reserved. Unauthorized use or duplication is prohibited.";
            // 
            // groupBoxlogin
            // 
            groupBoxlogin.Anchor = AnchorStyles.None;
            groupBoxlogin.Controls.Add(pboxShow);
            groupBoxlogin.Controls.Add(labelForget);
            groupBoxlogin.Controls.Add(lablePassword);
            groupBoxlogin.Controls.Add(txtBoxPassword);
            groupBoxlogin.Controls.Add(lableUserName);
            groupBoxlogin.Controls.Add(txtUserName);
            groupBoxlogin.Controls.Add(butLogin);
            groupBoxlogin.Controls.Add(pboxHide);
            groupBoxlogin.Font = new Font("Century", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxlogin.Location = new Point(113, 147);
            groupBoxlogin.Name = "groupBoxlogin";
            groupBoxlogin.Size = new Size(593, 403);
            groupBoxlogin.TabIndex = 0;
            groupBoxlogin.TabStop = false;
            groupBoxlogin.Text = "Please log in to continue";
            groupBoxlogin.Enter += groupBoxlogin_Enter;
            // 
            // pboxShow
            // 
            pboxShow.Anchor = AnchorStyles.None;
            pboxShow.BorderStyle = BorderStyle.FixedSingle;
            pboxShow.Cursor = Cursors.Hand;
            pboxShow.Image = Properties.Resources.open_eye;
            pboxShow.Location = new Point(400, 221);
            pboxShow.Name = "pboxShow";
            pboxShow.Size = new Size(24, 23);
            pboxShow.SizeMode = PictureBoxSizeMode.Zoom;
            pboxShow.TabIndex = 6;
            pboxShow.TabStop = false;
            pboxShow.Click += pboxShow_Click;
            pboxShow.MouseHover += pboxShow_MouseHover;
            // 
            // labelForget
            // 
            labelForget.Anchor = AnchorStyles.None;
            labelForget.AutoSize = true;
            labelForget.Cursor = Cursors.Hand;
            labelForget.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelForget.ForeColor = Color.MediumBlue;
            labelForget.Location = new Point(271, 247);
            labelForget.Name = "labelForget";
            labelForget.Size = new Size(153, 16);
            labelForget.TabIndex = 5;
            labelForget.Text = "Forgot your password?";
            labelForget.Click += labelForget_Click;
            // 
            // lablePassword
            // 
            lablePassword.Anchor = AnchorStyles.None;
            lablePassword.AutoSize = true;
            lablePassword.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lablePassword.Location = new Point(154, 191);
            lablePassword.Name = "lablePassword";
            lablePassword.Size = new Size(71, 16);
            lablePassword.TabIndex = 4;
            lablePassword.Text = "Password:";
            lablePassword.Click += lablePassword_Click;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Anchor = AnchorStyles.None;
            txtBoxPassword.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxPassword.Location = new Point(157, 221);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(245, 23);
            txtBoxPassword.TabIndex = 2;
            txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // lableUserName
            // 
            lableUserName.Anchor = AnchorStyles.None;
            lableUserName.AutoSize = true;
            lableUserName.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lableUserName.Location = new Point(154, 110);
            lableUserName.Name = "lableUserName";
            lableUserName.Size = new Size(79, 16);
            lableUserName.TabIndex = 2;
            lableUserName.Text = "User name:";
            lableUserName.Click += lableUserName_Click;
            // 
            // pboxHide
            // 
            pboxHide.Anchor = AnchorStyles.None;
            pboxHide.BorderStyle = BorderStyle.FixedSingle;
            pboxHide.Cursor = Cursors.Hand;
            pboxHide.Image = Properties.Resources.close_eye;
            pboxHide.Location = new Point(400, 221);
            pboxHide.Name = "pboxHide";
            pboxHide.Size = new Size(24, 23);
            pboxHide.SizeMode = PictureBoxSizeMode.Zoom;
            pboxHide.TabIndex = 7;
            pboxHide.TabStop = false;
            pboxHide.Click += pboxHide_Click;
            pboxHide.MouseHover += pboxHide_MouseHover;
            // 
            // panelLine
            // 
            panelLine.Anchor = AnchorStyles.None;
            panelLine.BackColor = Color.Black;
            panelLine.Location = new Point(755, 200);
            panelLine.Name = "panelLine";
            panelLine.Size = new Size(3, 381);
            panelLine.TabIndex = 0;
            panelLine.Paint += panelLine_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.Hotel_Building_PNG_Pic;
            pictureBox1.Location = new Point(743, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(502, 459);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pboxminimize
            // 
            pboxminimize.Cursor = Cursors.Hand;
            pboxminimize.Image = Properties.Resources.minimize_icon;
            pboxminimize.Location = new Point(53, -4);
            pboxminimize.Name = "pboxminimize";
            pboxminimize.Size = new Size(26, 39);
            pboxminimize.SizeMode = PictureBoxSizeMode.Zoom;
            pboxminimize.TabIndex = 4;
            pboxminimize.TabStop = false;
            pboxminimize.Click += pboxminimize_Click;
            pboxminimize.MouseHover += pboxminimize_MouseHover;
            // 
            // pboxClose
            // 
            pboxClose.Cursor = Cursors.Hand;
            pboxClose.Image = Properties.Resources.close_icone;
            pboxClose.Location = new Point(12, -4);
            pboxClose.Name = "pboxClose";
            pboxClose.Size = new Size(26, 39);
            pboxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pboxClose.TabIndex = 3;
            pboxClose.TabStop = false;
            pboxClose.Click += pboxClose_Click;
            pboxClose.MouseHover += pboxClose_MouseHover;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Bodoni MT Condensed", 24F, FontStyle.Bold);
            label5.Location = new Point(926, 474);
            label5.Name = "label5";
            label5.Size = new Size(212, 38);
            label5.TabIndex = 6;
            label5.Text = "Hotel Management";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Bodoni MT Condensed", 24F, FontStyle.Bold);
            label6.Location = new Point(987, 512);
            label6.Name = "label6";
            label6.Size = new Size(92, 38);
            label6.TabIndex = 7;
            label6.Text = "System";
            // 
            // fmLogIn
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1366, 720);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panelLine);
            Controls.Add(groupBoxlogin);
            Controls.Add(panelDown);
            Controls.Add(pboxminimize);
            Controls.Add(pboxClose);
            Controls.Add(pictureBox1);
            Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fmLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel_Management_System-LogIn";
            WindowState = FormWindowState.Maximized;
            Load += fmLogIn_Load;
            panelDown.ResumeLayout(false);
            panelDown.PerformLayout();
            groupBoxlogin.ResumeLayout(false);
            groupBoxlogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxminimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox pboxClose;
        private System.Windows.Forms.PictureBox pboxminimize;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Label labelAllRights;
        private System.Windows.Forms.GroupBox groupBoxlogin;
        private System.Windows.Forms.Label lableUserName;
        private System.Windows.Forms.Label labelForget;
        private System.Windows.Forms.Label lablePassword;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.PictureBox pboxShow;
        private System.Windows.Forms.PictureBox pboxHide;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

