namespace HMSDes
{
    partial class fmMain
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
            panel1 = new Panel();
            btTimeline = new Button();
            panel9 = new Panel();
            btLogOut = new Button();
            btReservation = new Button();
            btRoom = new Button();
            btClient = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            btUser = new Button();
            panel2 = new Panel();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            dateTimePicker1 = new DateTimePicker();
            panel8 = new Panel();
            panel3 = new Panel();
            ucRoom = new HMSDesktop.User_Control.ucRoom();
            ucClient = new HMSDesktop.User_Control.ucClient();
            ucReservation = new HMSDesktop.User_Control.ucReservation();
            ucUser = new HMSDesktop.User_Contrul.ucUser();
            ucRoomTimeline = new HMSDesktop.User_Control.ucRoomTimeline();
            lbTime = new Label();
            lbName = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btTimeline);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(btLogOut);
            panel1.Controls.Add(btReservation);
            panel1.Controls.Add(btRoom);
            panel1.Controls.Add(btClient);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btUser);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 700);
            panel1.TabIndex = 0;
            // 
            // btTimeline
            // 
            btTimeline.BackColor = Color.SkyBlue;
            btTimeline.BackgroundImageLayout = ImageLayout.None;
            btTimeline.Cursor = Cursors.Hand;
            btTimeline.FlatAppearance.BorderColor = Color.Black;
            btTimeline.FlatStyle = FlatStyle.Flat;
            btTimeline.Font = new Font("Century", 14.25F, FontStyle.Bold);
            btTimeline.ForeColor = Color.Black;
            btTimeline.Image = HMSDesktop.Properties.Resources.Users1;
            btTimeline.ImageAlign = ContentAlignment.MiddleLeft;
            btTimeline.Location = new Point(28, 516);
            btTimeline.Name = "btTimeline";
            btTimeline.Size = new Size(203, 45);
            btTimeline.TabIndex = 9;
            btTimeline.Text = "Timeline";
            btTimeline.UseVisualStyleBackColor = false;
            btTimeline.Click += btTimeline_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.SkyBlue;
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Location = new Point(14, 210);
            panel9.Name = "panel9";
            panel9.Size = new Size(8, 45);
            panel9.TabIndex = 1;
            // 
            // btLogOut
            // 
            btLogOut.BackColor = Color.SkyBlue;
            btLogOut.BackgroundImageLayout = ImageLayout.None;
            btLogOut.Cursor = Cursors.Hand;
            btLogOut.FlatAppearance.BorderColor = Color.Black;
            btLogOut.FlatStyle = FlatStyle.Flat;
            btLogOut.Font = new Font("Century", 14.25F, FontStyle.Bold);
            btLogOut.ForeColor = Color.Black;
            btLogOut.Image = HMSDesktop.Properties.Resources.logout;
            btLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btLogOut.Location = new Point(28, 594);
            btLogOut.Name = "btLogOut";
            btLogOut.Size = new Size(203, 45);
            btLogOut.TabIndex = 5;
            btLogOut.Text = "Log Out";
            btLogOut.UseVisualStyleBackColor = false;
            btLogOut.Click += btLogOut_Click;
            // 
            // btReservation
            // 
            btReservation.BackColor = Color.SkyBlue;
            btReservation.BackgroundImageLayout = ImageLayout.None;
            btReservation.Cursor = Cursors.Hand;
            btReservation.FlatAppearance.BorderColor = Color.Black;
            btReservation.FlatStyle = FlatStyle.Flat;
            btReservation.Font = new Font("Century", 14.25F, FontStyle.Bold);
            btReservation.ForeColor = Color.Black;
            btReservation.Image = HMSDesktop.Properties.Resources.Reservation;
            btReservation.ImageAlign = ContentAlignment.MiddleLeft;
            btReservation.Location = new Point(28, 438);
            btReservation.Name = "btReservation";
            btReservation.Size = new Size(203, 45);
            btReservation.TabIndex = 4;
            btReservation.Text = "Reservation";
            btReservation.UseVisualStyleBackColor = false;
            btReservation.Click += btReservation_Click;
            // 
            // btRoom
            // 
            btRoom.BackColor = Color.SkyBlue;
            btRoom.BackgroundImageLayout = ImageLayout.None;
            btRoom.Cursor = Cursors.Hand;
            btRoom.FlatAppearance.BorderColor = Color.Black;
            btRoom.FlatStyle = FlatStyle.Flat;
            btRoom.Font = new Font("Century", 14.25F, FontStyle.Bold);
            btRoom.ForeColor = Color.Black;
            btRoom.Image = HMSDesktop.Properties.Resources.Room;
            btRoom.ImageAlign = ContentAlignment.MiddleLeft;
            btRoom.Location = new Point(28, 363);
            btRoom.Name = "btRoom";
            btRoom.Size = new Size(203, 45);
            btRoom.TabIndex = 3;
            btRoom.Text = "Rooms";
            btRoom.UseVisualStyleBackColor = false;
            btRoom.Click += btRoom_Click;
            // 
            // btClient
            // 
            btClient.BackColor = Color.SkyBlue;
            btClient.BackgroundImageLayout = ImageLayout.None;
            btClient.Cursor = Cursors.Hand;
            btClient.FlatAppearance.BorderColor = Color.Black;
            btClient.FlatStyle = FlatStyle.Flat;
            btClient.Font = new Font("Century", 14.25F, FontStyle.Bold);
            btClient.ForeColor = Color.Black;
            btClient.Image = HMSDesktop.Properties.Resources.Client;
            btClient.ImageAlign = ContentAlignment.MiddleLeft;
            btClient.Location = new Point(28, 285);
            btClient.Name = "btClient";
            btClient.Size = new Size(203, 45);
            btClient.TabIndex = 2;
            btClient.Text = "Clients";
            btClient.UseVisualStyleBackColor = false;
            btClient.Click += btClient_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bodoni MT", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 146);
            label5.Name = "label5";
            label5.Size = new Size(179, 36);
            label5.TabIndex = 8;
            label5.Text = "Luxera Hotel";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = HMSDesktop.Properties.Resources._5172;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btUser
            // 
            btUser.BackColor = Color.SkyBlue;
            btUser.BackgroundImageLayout = ImageLayout.None;
            btUser.Cursor = Cursors.Hand;
            btUser.FlatAppearance.BorderColor = Color.Black;
            btUser.FlatStyle = FlatStyle.Flat;
            btUser.Font = new Font("Century", 14.25F, FontStyle.Bold);
            btUser.ForeColor = Color.Black;
            btUser.Image = HMSDesktop.Properties.Resources.Users1;
            btUser.ImageAlign = ContentAlignment.MiddleLeft;
            btUser.Location = new Point(28, 210);
            btUser.Name = "btUser";
            btUser.Size = new Size(203, 45);
            btUser.TabIndex = 1;
            btUser.Text = "Users";
            btUser.UseVisualStyleBackColor = false;
            btUser.Click += btUser_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(247, 670);
            panel2.Name = "panel2";
            panel2.Size = new Size(1053, 30);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 10);
            label1.Name = "label1";
            label1.Size = new Size(532, 20);
            label1.TabIndex = 3;
            label1.Text = "© 2026 All Rights Reserved. Unauthorized use or duplication is prohibited.";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 26);
            dateTimePicker1.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(panel3);
            panel8.Controls.Add(lbTime);
            panel8.Controls.Add(lbName);
            panel8.Controls.Add(dateTimePicker1);
            panel8.Controls.Add(label2);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1300, 700);
            panel8.TabIndex = 3;
            panel8.Paint += panel8_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(ucRoom);
            panel3.Controls.Add(ucClient);
            panel3.Controls.Add(ucReservation);
            panel3.Controls.Add(ucUser);
            panel3.Controls.Add(ucRoomTimeline);
            panel3.Location = new Point(247, 160);
            panel3.Name = "panel3";
            panel3.Size = new Size(1084, 504);
            panel3.TabIndex = 15;
            // 
            // ucRoom
            // 
            ucRoom.Anchor = AnchorStyles.None;
            ucRoom.BackColor = Color.White;
            ucRoom.Location = new Point(48, 24);
            ucRoom.Name = "ucRoom";
            ucRoom.Size = new Size(963, 531);
            ucRoom.TabIndex = 12;
            // 
            // ucClient
            // 
            ucClient.Anchor = AnchorStyles.None;
            ucClient.BackColor = Color.White;
            ucClient.Location = new Point(48, 24);
            ucClient.Name = "ucClient";
            ucClient.RightToLeft = RightToLeft.Yes;
            ucClient.Size = new Size(963, 531);
            ucClient.TabIndex = 11;
            // 
            // ucReservation
            // 
            ucReservation.Anchor = AnchorStyles.None;
            ucReservation.BackColor = Color.White;
            ucReservation.Location = new Point(45, 24);
            ucReservation.Name = "ucReservation";
            ucReservation.Size = new Size(963, 528);
            ucReservation.TabIndex = 13;
            // 
            // ucUser
            // 
            ucUser.Anchor = AnchorStyles.None;
            ucUser.BackColor = Color.White;
            ucUser.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucUser.Location = new Point(48, 24);
            ucUser.Name = "ucUser";
            ucUser.Size = new Size(963, 531);
            ucUser.TabIndex = 10;
            ucUser.UserId = 0;
            // 
            // ucRoomTimeline
            // 
            ucRoomTimeline.BackColor = Color.White;
            ucRoomTimeline.Location = new Point(45, 24);
            ucRoomTimeline.Name = "ucRoomTimeline";
            ucRoomTimeline.Size = new Size(963, 723);
            ucRoomTimeline.TabIndex = 14;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Century", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTime.ForeColor = SystemColors.ControlText;
            lbTime.Location = new Point(280, 106);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(22, 25);
            lbTime.TabIndex = 9;
            lbTime.Text = "?";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Century", 26.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbName.ForeColor = Color.Black;
            lbName.Location = new Point(470, 50);
            lbName.Name = "lbName";
            lbName.Size = new Size(34, 41);
            lbName.TabIndex = 0;
            lbName.Text = "?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(268, 47);
            label2.Name = "label2";
            label2.Size = new Size(188, 41);
            label2.TabIndex = 0;
            label2.Text = "Welcome:";
            // 
            // fmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1300, 700);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel8);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "fmMain";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel_Management_System-Main";
            WindowState = FormWindowState.Maximized;
            Load += fmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btUser;
        private Button btLogOut;
        private Button btReservation;
        private Button btRoom;
        private Button btClient;
        private System.Windows.Forms.Timer timer1;
        private Panel panel9;
        private DateTimePicker dateTimePicker1;
        private Panel panel8;
        private Label label5;
        private PictureBox pictureBox1;
        private Label lbName;
        private Label label2;
        private Label lbTime;
        private Button btTimeline;
        private HMSDesktop.User_Control.ucReservation ucReservation;
        private HMSDesktop.User_Control.ucRoom ucRoom;
        private HMSDesktop.User_Control.ucClient ucClient;
        private HMSDesktop.User_Contrul.ucUser ucUser;
        private HMSDesktop.User_Control.ucRoomTimeline ucRoomTimeline;
        private Panel panel3;
    }
}
