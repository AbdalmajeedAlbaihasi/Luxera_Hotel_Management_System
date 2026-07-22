namespace HMSDesktop.User_Control
{
    partial class ucRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlClient = new TabControl();
            tabPageAddClient = new TabPage();
            txtAddCapacity = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtAddPrice = new TextBox();
            btAddRoom = new Button();
            btAddClient = new Button();
            btAddUser = new Button();
            groupBoxAddGender = new GroupBox();
            radButAddStatusMaintenance = new RadioButton();
            radButAddStatusOccupied = new RadioButton();
            radButAddStatudAvailable = new RadioButton();
            comboBoxAddRoomType = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label6 = new Label();
            txtAddRoomNumber = new TextBox();
            tabPageClientList = new TabPage();
            label12 = new Label();
            dataGridViewRoomList = new DataGridView();
            tabPageUpdateAndDelete = new TabPage();
            txtUpdateCapacity = new TextBox();
            btSearchRoom = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUpdatePrice = new TextBox();
            groupBox1 = new GroupBox();
            radButUpdateStatusMaintenance = new RadioButton();
            radButUpdateStatusOccupied = new RadioButton();
            radButUpdateStatudAvailable = new RadioButton();
            comboBoxUpdateRoomType = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            label9 = new Label();
            txtUpdateRoomNumber = new TextBox();
            btDeleteRoom = new Button();
            btUpdateRoom = new Button();
            btDeleteClient = new Button();
            btUpdateClient = new Button();
            btSearch = new Button();
            btDelete = new Button();
            btUpdate = new Button();
            txtSerching = new TextBox();
            comboBoxSearchingType = new ComboBox();
            label24 = new Label();
            label13 = new Label();
            tabControlClient.SuspendLayout();
            tabPageAddClient.SuspendLayout();
            groupBoxAddGender.SuspendLayout();
            tabPageClientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoomList).BeginInit();
            tabPageUpdateAndDelete.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlClient
            // 
            tabControlClient.Anchor = AnchorStyles.None;
            tabControlClient.Controls.Add(tabPageAddClient);
            tabControlClient.Controls.Add(tabPageClientList);
            tabControlClient.Controls.Add(tabPageUpdateAndDelete);
            tabControlClient.Font = new Font("Century Gothic", 9F);
            tabControlClient.Location = new Point(5, 12);
            tabControlClient.Multiline = true;
            tabControlClient.Name = "tabControlClient";
            tabControlClient.SelectedIndex = 0;
            tabControlClient.Size = new Size(899, 487);
            tabControlClient.TabIndex = 0;
            // 
            // tabPageAddClient
            // 
            tabPageAddClient.Controls.Add(txtAddCapacity);
            tabPageAddClient.Controls.Add(label4);
            tabPageAddClient.Controls.Add(label3);
            tabPageAddClient.Controls.Add(txtAddPrice);
            tabPageAddClient.Controls.Add(btAddRoom);
            tabPageAddClient.Controls.Add(btAddClient);
            tabPageAddClient.Controls.Add(btAddUser);
            tabPageAddClient.Controls.Add(groupBoxAddGender);
            tabPageAddClient.Controls.Add(comboBoxAddRoomType);
            tabPageAddClient.Controls.Add(label11);
            tabPageAddClient.Controls.Add(label10);
            tabPageAddClient.Controls.Add(label8);
            tabPageAddClient.Controls.Add(label6);
            tabPageAddClient.Controls.Add(txtAddRoomNumber);
            tabPageAddClient.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageAddClient.Location = new Point(4, 26);
            tabPageAddClient.Name = "tabPageAddClient";
            tabPageAddClient.Padding = new Padding(3);
            tabPageAddClient.Size = new Size(891, 457);
            tabPageAddClient.TabIndex = 0;
            tabPageAddClient.Text = "Add Room";
            tabPageAddClient.UseVisualStyleBackColor = true;
            tabPageAddClient.Click += tabPageAddClient_Click;
            // 
            // txtAddCapacity
            // 
            txtAddCapacity.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtAddCapacity.Location = new Point(598, 155);
            txtAddCapacity.Name = "txtAddCapacity";
            txtAddCapacity.Size = new Size(85, 22);
            txtAddCapacity.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(501, 155);
            label4.Name = "label4";
            label4.Size = new Size(85, 19);
            label4.TabIndex = 0;
            label4.Text = "Capacity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(501, 109);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 0;
            label3.Text = "Price:";
            // 
            // txtAddPrice
            // 
            txtAddPrice.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtAddPrice.Location = new Point(598, 109);
            txtAddPrice.Name = "txtAddPrice";
            txtAddPrice.Size = new Size(85, 22);
            txtAddPrice.TabIndex = 4;
            // 
            // btAddRoom
            // 
            btAddRoom.Anchor = AnchorStyles.None;
            btAddRoom.BackColor = Color.SkyBlue;
            btAddRoom.Cursor = Cursors.Hand;
            btAddRoom.FlatStyle = FlatStyle.Flat;
            btAddRoom.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAddRoom.ForeColor = SystemColors.ControlText;
            btAddRoom.Location = new Point(352, 308);
            btAddRoom.Name = "btAddRoom";
            btAddRoom.Size = new Size(197, 41);
            btAddRoom.TabIndex = 6;
            btAddRoom.Text = "Add";
            btAddRoom.UseVisualStyleBackColor = false;
            btAddRoom.Click += btAddRoom_Click;
            // 
            // btAddClient
            // 
            btAddClient.Anchor = AnchorStyles.None;
            btAddClient.BackColor = Color.SkyBlue;
            btAddClient.Cursor = Cursors.Hand;
            btAddClient.FlatStyle = FlatStyle.Flat;
            btAddClient.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAddClient.ForeColor = SystemColors.ControlText;
            btAddClient.Location = new Point(679, 497);
            btAddClient.Name = "btAddClient";
            btAddClient.Size = new Size(197, 41);
            btAddClient.TabIndex = 1;
            btAddClient.Text = "Add";
            btAddClient.UseVisualStyleBackColor = false;
            // 
            // btAddUser
            // 
            btAddUser.Anchor = AnchorStyles.None;
            btAddUser.BackColor = Color.SkyBlue;
            btAddUser.Cursor = Cursors.Hand;
            btAddUser.FlatStyle = FlatStyle.Flat;
            btAddUser.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAddUser.ForeColor = SystemColors.ControlText;
            btAddUser.Location = new Point(1020, 738);
            btAddUser.Name = "btAddUser";
            btAddUser.Size = new Size(197, 41);
            btAddUser.TabIndex = 12;
            btAddUser.Text = "Add";
            btAddUser.UseVisualStyleBackColor = false;
            // 
            // groupBoxAddGender
            // 
            groupBoxAddGender.Controls.Add(radButAddStatusMaintenance);
            groupBoxAddGender.Controls.Add(radButAddStatusOccupied);
            groupBoxAddGender.Controls.Add(radButAddStatudAvailable);
            groupBoxAddGender.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBoxAddGender.Location = new Point(271, 194);
            groupBoxAddGender.Name = "groupBoxAddGender";
            groupBoxAddGender.Size = new Size(315, 40);
            groupBoxAddGender.TabIndex = 3;
            groupBoxAddGender.TabStop = false;
            // 
            // radButAddStatusMaintenance
            // 
            radButAddStatusMaintenance.AutoSize = true;
            radButAddStatusMaintenance.Location = new Point(195, 15);
            radButAddStatusMaintenance.Name = "radButAddStatusMaintenance";
            radButAddStatusMaintenance.Size = new Size(102, 20);
            radButAddStatusMaintenance.TabIndex = 2;
            radButAddStatusMaintenance.TabStop = true;
            radButAddStatusMaintenance.Text = "Maintenance";
            radButAddStatusMaintenance.UseVisualStyleBackColor = true;
            // 
            // radButAddStatusOccupied
            // 
            radButAddStatusOccupied.AutoSize = true;
            radButAddStatusOccupied.Location = new Point(93, 15);
            radButAddStatusOccupied.Name = "radButAddStatusOccupied";
            radButAddStatusOccupied.Size = new Size(83, 20);
            radButAddStatusOccupied.TabIndex = 1;
            radButAddStatusOccupied.TabStop = true;
            radButAddStatusOccupied.Text = "Occupied";
            radButAddStatusOccupied.UseVisualStyleBackColor = true;
            // 
            // radButAddStatudAvailable
            // 
            radButAddStatudAvailable.AutoSize = true;
            radButAddStatudAvailable.Location = new Point(8, 15);
            radButAddStatudAvailable.Name = "radButAddStatudAvailable";
            radButAddStatudAvailable.Size = new Size(82, 20);
            radButAddStatudAvailable.TabIndex = 0;
            radButAddStatudAvailable.TabStop = true;
            radButAddStatudAvailable.Text = "Available";
            radButAddStatudAvailable.UseVisualStyleBackColor = true;
            // 
            // comboBoxAddRoomType
            // 
            comboBoxAddRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAddRoomType.Font = new Font("Microsoft Sans Serif", 9.75F);
            comboBoxAddRoomType.FormattingEnabled = true;
            comboBoxAddRoomType.Location = new Point(271, 150);
            comboBoxAddRoomType.Name = "comboBoxAddRoomType";
            comboBoxAddRoomType.Size = new Size(85, 24);
            comboBoxAddRoomType.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(312, 17);
            label11.Name = "label11";
            label11.Size = new Size(237, 34);
            label11.TabIndex = 0;
            label11.Text = "Add New Room";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label10.Location = new Point(137, 155);
            label10.Name = "label10";
            label10.Size = new Size(96, 19);
            label10.TabIndex = 0;
            label10.Text = "Room type:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label8.Location = new Point(137, 203);
            label8.Name = "label8";
            label8.Size = new Size(56, 19);
            label8.TabIndex = 0;
            label8.Text = "Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.Location = new Point(137, 109);
            label6.Name = "label6";
            label6.Size = new Size(124, 19);
            label6.TabIndex = 0;
            label6.Text = "Room number:";
            // 
            // txtAddRoomNumber
            // 
            txtAddRoomNumber.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtAddRoomNumber.Location = new Point(271, 109);
            txtAddRoomNumber.Name = "txtAddRoomNumber";
            txtAddRoomNumber.Size = new Size(85, 22);
            txtAddRoomNumber.TabIndex = 1;
            // 
            // tabPageClientList
            // 
            tabPageClientList.Controls.Add(label12);
            tabPageClientList.Controls.Add(dataGridViewRoomList);
            tabPageClientList.Location = new Point(4, 26);
            tabPageClientList.Name = "tabPageClientList";
            tabPageClientList.Padding = new Padding(3);
            tabPageClientList.Size = new Size(891, 457);
            tabPageClientList.TabIndex = 1;
            tabPageClientList.Text = "Rooms list";
            tabPageClientList.UseVisualStyleBackColor = true;
            tabPageClientList.Click += tabPageClientList_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(333, 14);
            label12.Name = "label12";
            label12.Size = new Size(175, 34);
            label12.TabIndex = 0;
            label12.Text = "Rooms List";
            // 
            // dataGridViewRoomList
            // 
            dataGridViewRoomList.AllowUserToAddRows = false;
            dataGridViewRoomList.AllowUserToDeleteRows = false;
            dataGridViewRoomList.BackgroundColor = Color.White;
            dataGridViewRoomList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoomList.Location = new Point(23, 71);
            dataGridViewRoomList.Name = "dataGridViewRoomList";
            dataGridViewRoomList.ReadOnly = true;
            dataGridViewRoomList.Size = new Size(848, 319);
            dataGridViewRoomList.TabIndex = 1;
            // 
            // tabPageUpdateAndDelete
            // 
            tabPageUpdateAndDelete.Controls.Add(txtUpdateCapacity);
            tabPageUpdateAndDelete.Controls.Add(btSearchRoom);
            tabPageUpdateAndDelete.Controls.Add(label1);
            tabPageUpdateAndDelete.Controls.Add(label2);
            tabPageUpdateAndDelete.Controls.Add(txtUpdatePrice);
            tabPageUpdateAndDelete.Controls.Add(groupBox1);
            tabPageUpdateAndDelete.Controls.Add(comboBoxUpdateRoomType);
            tabPageUpdateAndDelete.Controls.Add(label5);
            tabPageUpdateAndDelete.Controls.Add(label7);
            tabPageUpdateAndDelete.Controls.Add(label9);
            tabPageUpdateAndDelete.Controls.Add(txtUpdateRoomNumber);
            tabPageUpdateAndDelete.Controls.Add(btDeleteRoom);
            tabPageUpdateAndDelete.Controls.Add(btUpdateRoom);
            tabPageUpdateAndDelete.Controls.Add(btDeleteClient);
            tabPageUpdateAndDelete.Controls.Add(btUpdateClient);
            tabPageUpdateAndDelete.Controls.Add(btSearch);
            tabPageUpdateAndDelete.Controls.Add(btDelete);
            tabPageUpdateAndDelete.Controls.Add(btUpdate);
            tabPageUpdateAndDelete.Controls.Add(txtSerching);
            tabPageUpdateAndDelete.Controls.Add(comboBoxSearchingType);
            tabPageUpdateAndDelete.Controls.Add(label24);
            tabPageUpdateAndDelete.Controls.Add(label13);
            tabPageUpdateAndDelete.Location = new Point(4, 26);
            tabPageUpdateAndDelete.Name = "tabPageUpdateAndDelete";
            tabPageUpdateAndDelete.Size = new Size(891, 457);
            tabPageUpdateAndDelete.TabIndex = 0;
            tabPageUpdateAndDelete.Text = "Update&Delete";
            tabPageUpdateAndDelete.UseVisualStyleBackColor = true;
            tabPageUpdateAndDelete.Click += tabPageUpdateAndDelete_Click;
            // 
            // txtUpdateCapacity
            // 
            txtUpdateCapacity.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtUpdateCapacity.Location = new Point(606, 208);
            txtUpdateCapacity.Name = "txtUpdateCapacity";
            txtUpdateCapacity.Size = new Size(85, 22);
            txtUpdateCapacity.TabIndex = 8;
            // 
            // btSearchRoom
            // 
            btSearchRoom.Anchor = AnchorStyles.None;
            btSearchRoom.BackColor = Color.SkyBlue;
            btSearchRoom.Cursor = Cursors.Hand;
            btSearchRoom.FlatStyle = FlatStyle.Flat;
            btSearchRoom.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSearchRoom.ForeColor = SystemColors.ControlText;
            btSearchRoom.Location = new Point(586, 99);
            btSearchRoom.Name = "btSearchRoom";
            btSearchRoom.Size = new Size(117, 33);
            btSearchRoom.TabIndex = 3;
            btSearchRoom.Text = "Search";
            btSearchRoom.UseVisualStyleBackColor = false;
            btSearchRoom.Click += btSearchRoom_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(509, 208);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 0;
            label1.Text = "Capacity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(509, 162);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 0;
            label2.Text = "Price:";
            // 
            // txtUpdatePrice
            // 
            txtUpdatePrice.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtUpdatePrice.Location = new Point(606, 162);
            txtUpdatePrice.Name = "txtUpdatePrice";
            txtUpdatePrice.Size = new Size(85, 22);
            txtUpdatePrice.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radButUpdateStatusMaintenance);
            groupBox1.Controls.Add(radButUpdateStatusOccupied);
            groupBox1.Controls.Add(radButUpdateStatudAvailable);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBox1.Location = new Point(279, 247);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 40);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // radButUpdateStatusMaintenance
            // 
            radButUpdateStatusMaintenance.AutoSize = true;
            radButUpdateStatusMaintenance.Location = new Point(195, 15);
            radButUpdateStatusMaintenance.Name = "radButUpdateStatusMaintenance";
            radButUpdateStatusMaintenance.Size = new Size(102, 20);
            radButUpdateStatusMaintenance.TabIndex = 2;
            radButUpdateStatusMaintenance.TabStop = true;
            radButUpdateStatusMaintenance.Text = "Maintenance";
            radButUpdateStatusMaintenance.UseVisualStyleBackColor = true;
            // 
            // radButUpdateStatusOccupied
            // 
            radButUpdateStatusOccupied.AutoSize = true;
            radButUpdateStatusOccupied.Location = new Point(98, 15);
            radButUpdateStatusOccupied.Name = "radButUpdateStatusOccupied";
            radButUpdateStatusOccupied.Size = new Size(83, 20);
            radButUpdateStatusOccupied.TabIndex = 1;
            radButUpdateStatusOccupied.TabStop = true;
            radButUpdateStatusOccupied.Text = "Occupied";
            radButUpdateStatusOccupied.UseVisualStyleBackColor = true;
            // 
            // radButUpdateStatudAvailable
            // 
            radButUpdateStatudAvailable.AutoSize = true;
            radButUpdateStatudAvailable.Location = new Point(8, 15);
            radButUpdateStatudAvailable.Name = "radButUpdateStatudAvailable";
            radButUpdateStatudAvailable.Size = new Size(82, 20);
            radButUpdateStatudAvailable.TabIndex = 0;
            radButUpdateStatudAvailable.TabStop = true;
            radButUpdateStatudAvailable.Text = "Available";
            radButUpdateStatudAvailable.UseVisualStyleBackColor = true;
            // 
            // comboBoxUpdateRoomType
            // 
            comboBoxUpdateRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUpdateRoomType.Font = new Font("Microsoft Sans Serif", 9.75F);
            comboBoxUpdateRoomType.FormattingEnabled = true;
            comboBoxUpdateRoomType.Location = new Point(279, 203);
            comboBoxUpdateRoomType.Name = "comboBoxUpdateRoomType";
            comboBoxUpdateRoomType.Size = new Size(90, 24);
            comboBoxUpdateRoomType.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(145, 208);
            label5.Name = "label5";
            label5.Size = new Size(96, 19);
            label5.TabIndex = 0;
            label5.Text = "Room type:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label7.Location = new Point(145, 256);
            label7.Name = "label7";
            label7.Size = new Size(56, 19);
            label7.TabIndex = 0;
            label7.Text = "Status:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label9.Location = new Point(145, 162);
            label9.Name = "label9";
            label9.Size = new Size(124, 19);
            label9.TabIndex = 0;
            label9.Text = "Room number:";
            // 
            // txtUpdateRoomNumber
            // 
            txtUpdateRoomNumber.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtUpdateRoomNumber.Location = new Point(279, 162);
            txtUpdateRoomNumber.Name = "txtUpdateRoomNumber";
            txtUpdateRoomNumber.Size = new Size(85, 22);
            txtUpdateRoomNumber.TabIndex = 4;
            // 
            // btDeleteRoom
            // 
            btDeleteRoom.Anchor = AnchorStyles.None;
            btDeleteRoom.BackColor = Color.Red;
            btDeleteRoom.Cursor = Cursors.Hand;
            btDeleteRoom.FlatStyle = FlatStyle.Flat;
            btDeleteRoom.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDeleteRoom.ForeColor = SystemColors.ControlText;
            btDeleteRoom.Location = new Point(475, 362);
            btDeleteRoom.Name = "btDeleteRoom";
            btDeleteRoom.Size = new Size(117, 33);
            btDeleteRoom.TabIndex = 10;
            btDeleteRoom.Text = "Delete";
            btDeleteRoom.UseVisualStyleBackColor = false;
            btDeleteRoom.Click += btDeleteRoom_Click;
            // 
            // btUpdateRoom
            // 
            btUpdateRoom.Anchor = AnchorStyles.None;
            btUpdateRoom.BackColor = Color.SkyBlue;
            btUpdateRoom.Cursor = Cursors.Hand;
            btUpdateRoom.FlatStyle = FlatStyle.Flat;
            btUpdateRoom.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btUpdateRoom.ForeColor = SystemColors.ControlText;
            btUpdateRoom.Location = new Point(297, 362);
            btUpdateRoom.Name = "btUpdateRoom";
            btUpdateRoom.Size = new Size(117, 33);
            btUpdateRoom.TabIndex = 9;
            btUpdateRoom.Text = "Update";
            btUpdateRoom.UseVisualStyleBackColor = false;
            btUpdateRoom.Click += btUpdateRoom_Click;
            // 
            // btDeleteClient
            // 
            btDeleteClient.Anchor = AnchorStyles.None;
            btDeleteClient.BackColor = Color.SkyBlue;
            btDeleteClient.Cursor = Cursors.Hand;
            btDeleteClient.FlatStyle = FlatStyle.Flat;
            btDeleteClient.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDeleteClient.ForeColor = SystemColors.ControlText;
            btDeleteClient.Location = new Point(781, 529);
            btDeleteClient.Name = "btDeleteClient";
            btDeleteClient.Size = new Size(117, 33);
            btDeleteClient.TabIndex = 11;
            btDeleteClient.Text = "Delete";
            btDeleteClient.UseVisualStyleBackColor = false;
            // 
            // btUpdateClient
            // 
            btUpdateClient.Anchor = AnchorStyles.None;
            btUpdateClient.BackColor = Color.SkyBlue;
            btUpdateClient.Cursor = Cursors.Hand;
            btUpdateClient.FlatStyle = FlatStyle.Flat;
            btUpdateClient.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btUpdateClient.ForeColor = SystemColors.ControlText;
            btUpdateClient.Location = new Point(622, 529);
            btUpdateClient.Name = "btUpdateClient";
            btUpdateClient.Size = new Size(117, 33);
            btUpdateClient.TabIndex = 41;
            btUpdateClient.Text = "Update";
            btUpdateClient.UseVisualStyleBackColor = false;
            // 
            // btSearch
            // 
            btSearch.Anchor = AnchorStyles.None;
            btSearch.BackColor = Color.SkyBlue;
            btSearch.Cursor = Cursors.Hand;
            btSearch.FlatStyle = FlatStyle.Flat;
            btSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSearch.ForeColor = SystemColors.ControlText;
            btSearch.Location = new Point(941, 311);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(117, 33);
            btSearch.TabIndex = 3;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = false;
            // 
            // btDelete
            // 
            btDelete.Anchor = AnchorStyles.None;
            btDelete.BackColor = Color.Red;
            btDelete.Cursor = Cursors.Hand;
            btDelete.FlatStyle = FlatStyle.Flat;
            btDelete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDelete.ForeColor = SystemColors.ControlText;
            btDelete.Location = new Point(1133, 746);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(117, 41);
            btDelete.TabIndex = 14;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = false;
            // 
            // btUpdate
            // 
            btUpdate.Anchor = AnchorStyles.None;
            btUpdate.BackColor = Color.SkyBlue;
            btUpdate.Cursor = Cursors.Hand;
            btUpdate.FlatStyle = FlatStyle.Flat;
            btUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btUpdate.ForeColor = SystemColors.ControlText;
            btUpdate.Location = new Point(973, 746);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(117, 41);
            btUpdate.TabIndex = 13;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = false;
            // 
            // txtSerching
            // 
            txtSerching.Location = new Point(386, 104);
            txtSerching.Name = "txtSerching";
            txtSerching.Size = new Size(176, 22);
            txtSerching.TabIndex = 2;
            // 
            // comboBoxSearchingType
            // 
            comboBoxSearchingType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchingType.FormattingEnabled = true;
            comboBoxSearchingType.Items.AddRange(new object[] { "Id" });
            comboBoxSearchingType.Location = new Point(259, 104);
            comboBoxSearchingType.Name = "comboBoxSearchingType";
            comboBoxSearchingType.Size = new Size(109, 25);
            comboBoxSearchingType.TabIndex = 1;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label24.Location = new Point(162, 107);
            label24.Name = "label24";
            label24.Size = new Size(91, 19);
            label24.TabIndex = 0;
            label24.Text = "Search by:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(243, 11);
            label13.Name = "label13";
            label13.Size = new Size(377, 34);
            label13.TabIndex = 0;
            label13.Text = "Update and Delete Room";
            // 
            // ucRoom
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(tabControlClient);
            Name = "ucRoom";
            Size = new Size(915, 502);
            Load += RoomControl_Load;
            tabControlClient.ResumeLayout(false);
            tabPageAddClient.ResumeLayout(false);
            tabPageAddClient.PerformLayout();
            groupBoxAddGender.ResumeLayout(false);
            groupBoxAddGender.PerformLayout();
            tabPageClientList.ResumeLayout(false);
            tabPageClientList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoomList).EndInit();
            tabPageUpdateAndDelete.ResumeLayout(false);
            tabPageUpdateAndDelete.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlClient;
        private TabPage tabPageAddClient;
        private Button btAddClient;
        private Button btAddUser;
        private GroupBox groupBoxAddGender;
        private RadioButton radButAddStatusOccupied;
        private RadioButton radButAddStatudAvailable;
        private ComboBox comboBoxAddRoomType;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label6;
        private TextBox txtAddRoomNumber;
        private TabPage tabPageClientList;
        private Label label12;
        private DataGridView dataGridViewRoomList;
        private TabPage tabPageUpdateAndDelete;
        private Button btDeleteClient;
        private Button btUpdateClient;
        private Button btSearch;
        private Button btDelete;
        private Button btUpdate;
        private TextBox txtSerching;
        private ComboBox comboBoxSearchingType;
        private Label label24;
        private Label label13;
        private Button btAddRoom;
        private Button btDeleteRoom;
        private Button btUpdateRoom;
        private Label label3;
        private TextBox txtAddPrice;
        private Label label4;
        private RadioButton radButAddStatusMaintenance;
        private Label label1;
        private Label label2;
        private TextBox txtUpdatePrice;
        private GroupBox groupBox1;
        private RadioButton radButUpdateStatusMaintenance;
        private RadioButton radButUpdateStatusOccupied;
        private RadioButton radButUpdateStatudAvailable;
        private ComboBox comboBoxUpdateRoomType;
        private Label label5;
        private Label label7;
        private Label label9;
        private TextBox txtUpdateRoomNumber;
        private Button btSearchRoom;
        private TextBox txtAddCapacity;
        private TextBox txtUpdateCapacity;
    }
}
