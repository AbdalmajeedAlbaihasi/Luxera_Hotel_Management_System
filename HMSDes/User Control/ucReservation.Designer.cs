namespace HMSDesktop.User_Control
{
    partial class ucReservation
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
            txtClientAddName = new TextBox();
            comboBoxAddClientId = new ComboBox();
            label7 = new Label();
            btAddReservation = new Button();
            dateTimePickerAddCheckOut = new DateTimePicker();
            dateTimePickerAddCheckIn = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            btAddRoom = new Button();
            btAddClient = new Button();
            btAddUser = new Button();
            c = new GroupBox();
            radButAddStatusPending = new RadioButton();
            radButAddStatudConfirmed = new RadioButton();
            comboBoxAddRoomNumber = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            tabPageClientList = new TabPage();
            label12 = new Label();
            dataGridViewRoomList = new DataGridView();
            tabPageUpdateAndDelete = new TabPage();
            txtClientUpdateName = new TextBox();
            comboBoxUpdateClientId = new ComboBox();
            label9 = new Label();
            groupBoxUpdateStatus = new GroupBox();
            radButUpdateStatusPending = new RadioButton();
            radButUpdateStatusConfirmed = new RadioButton();
            btSearchReservation = new Button();
            btDeleteReservation = new Button();
            btUpdateReservation = new Button();
            dateTimePickerUpdateCheckOut = new DateTimePicker();
            dateTimePickerUpdateCheckIn = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            comboBoxUpdateRoomNumber = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            btSearchRoom = new Button();
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
            c.SuspendLayout();
            tabPageClientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoomList).BeginInit();
            tabPageUpdateAndDelete.SuspendLayout();
            groupBoxUpdateStatus.SuspendLayout();
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
            tabControlClient.Size = new Size(891, 457);
            tabControlClient.TabIndex = 0;
            // 
            // tabPageAddClient
            // 
            tabPageAddClient.Controls.Add(txtClientAddName);
            tabPageAddClient.Controls.Add(comboBoxAddClientId);
            tabPageAddClient.Controls.Add(label7);
            tabPageAddClient.Controls.Add(btAddReservation);
            tabPageAddClient.Controls.Add(dateTimePickerAddCheckOut);
            tabPageAddClient.Controls.Add(dateTimePickerAddCheckIn);
            tabPageAddClient.Controls.Add(label4);
            tabPageAddClient.Controls.Add(label3);
            tabPageAddClient.Controls.Add(btAddRoom);
            tabPageAddClient.Controls.Add(btAddClient);
            tabPageAddClient.Controls.Add(btAddUser);
            tabPageAddClient.Controls.Add(c);
            tabPageAddClient.Controls.Add(comboBoxAddRoomNumber);
            tabPageAddClient.Controls.Add(label11);
            tabPageAddClient.Controls.Add(label10);
            tabPageAddClient.Controls.Add(label8);
            tabPageAddClient.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageAddClient.Location = new Point(4, 26);
            tabPageAddClient.Name = "tabPageAddClient";
            tabPageAddClient.Padding = new Padding(3);
            tabPageAddClient.Size = new Size(883, 427);
            tabPageAddClient.TabIndex = 0;
            tabPageAddClient.Text = "Add Reservation";
            tabPageAddClient.UseVisualStyleBackColor = true;
            tabPageAddClient.Click += tabPageAddClient_Click;
            // 
            // txtClientAddName
            // 
            txtClientAddName.BackColor = Color.WhiteSmoke;
            txtClientAddName.Location = new Point(363, 90);
            txtClientAddName.Name = "txtClientAddName";
            txtClientAddName.ReadOnly = true;
            txtClientAddName.Size = new Size(242, 23);
            txtClientAddName.TabIndex = 20;
            // 
            // comboBoxAddClientId
            // 
            comboBoxAddClientId.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAddClientId.Font = new Font("Microsoft Sans Serif", 9.75F);
            comboBoxAddClientId.FormattingEnabled = true;
            comboBoxAddClientId.Location = new Point(258, 90);
            comboBoxAddClientId.Name = "comboBoxAddClientId";
            comboBoxAddClientId.Size = new Size(85, 24);
            comboBoxAddClientId.TabIndex = 19;
            comboBoxAddClientId.SelectedIndexChanged += comboBoxClientId_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label7.Location = new Point(156, 93);
            label7.Name = "label7";
            label7.Size = new Size(76, 19);
            label7.TabIndex = 18;
            label7.Text = "Client Id:";
            // 
            // btAddReservation
            // 
            btAddReservation.Anchor = AnchorStyles.None;
            btAddReservation.BackColor = Color.SkyBlue;
            btAddReservation.Cursor = Cursors.Hand;
            btAddReservation.FlatStyle = FlatStyle.Flat;
            btAddReservation.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAddReservation.ForeColor = SystemColors.ControlText;
            btAddReservation.Location = new Point(329, 309);
            btAddReservation.Name = "btAddReservation";
            btAddReservation.Size = new Size(197, 41);
            btAddReservation.TabIndex = 5;
            btAddReservation.Text = "Add";
            btAddReservation.UseVisualStyleBackColor = false;
            btAddReservation.Click += btAddReservation_Click;
            // 
            // dateTimePickerAddCheckOut
            // 
            dateTimePickerAddCheckOut.Location = new Point(611, 176);
            dateTimePickerAddCheckOut.Name = "dateTimePickerAddCheckOut";
            dateTimePickerAddCheckOut.Size = new Size(200, 23);
            dateTimePickerAddCheckOut.TabIndex = 3;
            // 
            // dateTimePickerAddCheckIn
            // 
            dateTimePickerAddCheckIn.Location = new Point(258, 174);
            dateTimePickerAddCheckIn.Name = "dateTimePickerAddCheckIn";
            dateTimePickerAddCheckIn.Size = new Size(200, 23);
            dateTimePickerAddCheckIn.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(510, 178);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 17;
            label4.Text = "Check Out:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(156, 178);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 0;
            label3.Text = "Check In:";
            // 
            // btAddRoom
            // 
            btAddRoom.Anchor = AnchorStyles.None;
            btAddRoom.BackColor = Color.SkyBlue;
            btAddRoom.Cursor = Cursors.Hand;
            btAddRoom.FlatStyle = FlatStyle.Flat;
            btAddRoom.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAddRoom.ForeColor = SystemColors.ControlText;
            btAddRoom.Location = new Point(689, 507);
            btAddRoom.Name = "btAddRoom";
            btAddRoom.Size = new Size(197, 41);
            btAddRoom.TabIndex = 14;
            btAddRoom.Text = "Add";
            btAddRoom.UseVisualStyleBackColor = false;
            // 
            // btAddClient
            // 
            btAddClient.Anchor = AnchorStyles.None;
            btAddClient.BackColor = Color.SkyBlue;
            btAddClient.Cursor = Cursors.Hand;
            btAddClient.FlatStyle = FlatStyle.Flat;
            btAddClient.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAddClient.ForeColor = SystemColors.ControlText;
            btAddClient.Location = new Point(1020, 661);
            btAddClient.Name = "btAddClient";
            btAddClient.Size = new Size(197, 41);
            btAddClient.TabIndex = 13;
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
            btAddUser.Location = new Point(1361, 902);
            btAddUser.Name = "btAddUser";
            btAddUser.Size = new Size(197, 41);
            btAddUser.TabIndex = 12;
            btAddUser.Text = "Add";
            btAddUser.UseVisualStyleBackColor = false;
            // 
            // c
            // 
            c.Controls.Add(radButAddStatusPending);
            c.Controls.Add(radButAddStatudConfirmed);
            c.Font = new Font("Microsoft Sans Serif", 9.75F);
            c.Location = new Point(258, 209);
            c.Name = "c";
            c.Size = new Size(200, 40);
            c.TabIndex = 4;
            c.TabStop = false;
            // 
            // radButAddStatusPending
            // 
            radButAddStatusPending.AutoSize = true;
            radButAddStatusPending.Location = new Point(105, 15);
            radButAddStatusPending.Name = "radButAddStatusPending";
            radButAddStatusPending.Size = new Size(75, 20);
            radButAddStatusPending.TabIndex = 1;
            radButAddStatusPending.TabStop = true;
            radButAddStatusPending.Text = "Pending";
            radButAddStatusPending.UseVisualStyleBackColor = true;
            // 
            // radButAddStatudConfirmed
            // 
            radButAddStatudConfirmed.AutoSize = true;
            radButAddStatudConfirmed.Location = new Point(8, 15);
            radButAddStatudConfirmed.Name = "radButAddStatudConfirmed";
            radButAddStatudConfirmed.Size = new Size(86, 20);
            radButAddStatudConfirmed.TabIndex = 0;
            radButAddStatudConfirmed.TabStop = true;
            radButAddStatudConfirmed.Text = "Confirmed";
            radButAddStatudConfirmed.UseVisualStyleBackColor = true;
            // 
            // comboBoxAddRoomNumber
            // 
            comboBoxAddRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAddRoomNumber.Font = new Font("Microsoft Sans Serif", 9.75F);
            comboBoxAddRoomNumber.FormattingEnabled = true;
            comboBoxAddRoomNumber.Location = new Point(258, 133);
            comboBoxAddRoomNumber.Name = "comboBoxAddRoomNumber";
            comboBoxAddRoomNumber.Size = new Size(85, 24);
            comboBoxAddRoomNumber.TabIndex = 1;
            comboBoxAddRoomNumber.SelectedIndexChanged += comboBoxAddRoomNumber_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(275, 19);
            label11.Name = "label11";
            label11.Size = new Size(329, 34);
            label11.TabIndex = 0;
            label11.Text = "Add New Reservation";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label10.Location = new Point(156, 133);
            label10.Name = "label10";
            label10.Size = new Size(87, 19);
            label10.TabIndex = 0;
            label10.Text = "Room NO:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label8.Location = new Point(156, 221);
            label8.Name = "label8";
            label8.Size = new Size(56, 19);
            label8.TabIndex = 0;
            label8.Text = "Status:";
            // 
            // tabPageClientList
            // 
            tabPageClientList.Controls.Add(label12);
            tabPageClientList.Controls.Add(dataGridViewRoomList);
            tabPageClientList.Location = new Point(4, 26);
            tabPageClientList.Name = "tabPageClientList";
            tabPageClientList.Padding = new Padding(3);
            tabPageClientList.Size = new Size(883, 427);
            tabPageClientList.TabIndex = 1;
            tabPageClientList.Text = "Reservations list";
            tabPageClientList.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(306, 15);
            label12.Name = "label12";
            label12.Size = new Size(267, 34);
            label12.TabIndex = 0;
            label12.Text = "Reservations List";
            // 
            // dataGridViewRoomList
            // 
            dataGridViewRoomList.AllowUserToAddRows = false;
            dataGridViewRoomList.AllowUserToDeleteRows = false;
            dataGridViewRoomList.BackgroundColor = Color.White;
            dataGridViewRoomList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoomList.Location = new Point(29, 70);
            dataGridViewRoomList.Name = "dataGridViewRoomList";
            dataGridViewRoomList.ReadOnly = true;
            dataGridViewRoomList.Size = new Size(848, 319);
            dataGridViewRoomList.TabIndex = 1;
            dataGridViewRoomList.CellContentClick += dataGridViewRoomList_CellContentClick;
            // 
            // tabPageUpdateAndDelete
            // 
            tabPageUpdateAndDelete.Controls.Add(txtClientUpdateName);
            tabPageUpdateAndDelete.Controls.Add(comboBoxUpdateClientId);
            tabPageUpdateAndDelete.Controls.Add(label9);
            tabPageUpdateAndDelete.Controls.Add(groupBoxUpdateStatus);
            tabPageUpdateAndDelete.Controls.Add(btSearchReservation);
            tabPageUpdateAndDelete.Controls.Add(btDeleteReservation);
            tabPageUpdateAndDelete.Controls.Add(btUpdateReservation);
            tabPageUpdateAndDelete.Controls.Add(dateTimePickerUpdateCheckOut);
            tabPageUpdateAndDelete.Controls.Add(dateTimePickerUpdateCheckIn);
            tabPageUpdateAndDelete.Controls.Add(label1);
            tabPageUpdateAndDelete.Controls.Add(label2);
            tabPageUpdateAndDelete.Controls.Add(comboBoxUpdateRoomNumber);
            tabPageUpdateAndDelete.Controls.Add(label5);
            tabPageUpdateAndDelete.Controls.Add(label6);
            tabPageUpdateAndDelete.Controls.Add(btSearchRoom);
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
            tabPageUpdateAndDelete.Size = new Size(883, 427);
            tabPageUpdateAndDelete.TabIndex = 0;
            tabPageUpdateAndDelete.Text = "Update&Delete";
            tabPageUpdateAndDelete.UseVisualStyleBackColor = true;
            tabPageUpdateAndDelete.Click += tabPageUpdateAndDelete_Click;
            // 
            // txtClientUpdateName
            // 
            txtClientUpdateName.BackColor = Color.WhiteSmoke;
            txtClientUpdateName.Location = new Point(329, 163);
            txtClientUpdateName.Name = "txtClientUpdateName";
            txtClientUpdateName.ReadOnly = true;
            txtClientUpdateName.Size = new Size(358, 22);
            txtClientUpdateName.TabIndex = 58;
            // 
            // comboBoxUpdateClientId
            // 
            comboBoxUpdateClientId.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUpdateClientId.Font = new Font("Microsoft Sans Serif", 9.75F);
            comboBoxUpdateClientId.FormattingEnabled = true;
            comboBoxUpdateClientId.Location = new Point(229, 161);
            comboBoxUpdateClientId.Name = "comboBoxUpdateClientId";
            comboBoxUpdateClientId.Size = new Size(85, 24);
            comboBoxUpdateClientId.TabIndex = 57;
            comboBoxUpdateClientId.SelectedIndexChanged += comboBoxUpdateClientId_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label9.Location = new Point(130, 161);
            label9.Name = "label9";
            label9.Size = new Size(76, 19);
            label9.TabIndex = 56;
            label9.Text = "Client Id:";
            // 
            // groupBoxUpdateStatus
            // 
            groupBoxUpdateStatus.Controls.Add(radButUpdateStatusPending);
            groupBoxUpdateStatus.Controls.Add(radButUpdateStatusConfirmed);
            groupBoxUpdateStatus.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBoxUpdateStatus.Location = new Point(229, 267);
            groupBoxUpdateStatus.Name = "groupBoxUpdateStatus";
            groupBoxUpdateStatus.Size = new Size(200, 40);
            groupBoxUpdateStatus.TabIndex = 7;
            groupBoxUpdateStatus.TabStop = false;
            // 
            // radButUpdateStatusPending
            // 
            radButUpdateStatusPending.AutoSize = true;
            radButUpdateStatusPending.Location = new Point(105, 15);
            radButUpdateStatusPending.Name = "radButUpdateStatusPending";
            radButUpdateStatusPending.Size = new Size(75, 20);
            radButUpdateStatusPending.TabIndex = 1;
            radButUpdateStatusPending.TabStop = true;
            radButUpdateStatusPending.Text = "Pending";
            radButUpdateStatusPending.UseVisualStyleBackColor = true;
            // 
            // radButUpdateStatusConfirmed
            // 
            radButUpdateStatusConfirmed.AutoSize = true;
            radButUpdateStatusConfirmed.Location = new Point(8, 15);
            radButUpdateStatusConfirmed.Name = "radButUpdateStatusConfirmed";
            radButUpdateStatusConfirmed.Size = new Size(86, 20);
            radButUpdateStatusConfirmed.TabIndex = 0;
            radButUpdateStatusConfirmed.TabStop = true;
            radButUpdateStatusConfirmed.Text = "Confirmed";
            radButUpdateStatusConfirmed.UseVisualStyleBackColor = true;
            // 
            // btSearchReservation
            // 
            btSearchReservation.Anchor = AnchorStyles.None;
            btSearchReservation.BackColor = Color.SkyBlue;
            btSearchReservation.Cursor = Cursors.Hand;
            btSearchReservation.FlatStyle = FlatStyle.Flat;
            btSearchReservation.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSearchReservation.ForeColor = SystemColors.ControlText;
            btSearchReservation.Location = new Point(591, 83);
            btSearchReservation.Name = "btSearchReservation";
            btSearchReservation.Size = new Size(117, 33);
            btSearchReservation.TabIndex = 3;
            btSearchReservation.Text = "Search";
            btSearchReservation.UseVisualStyleBackColor = false;
            btSearchReservation.Click += btSearchReservation_Click;
            // 
            // btDeleteReservation
            // 
            btDeleteReservation.Anchor = AnchorStyles.None;
            btDeleteReservation.BackColor = Color.Red;
            btDeleteReservation.Cursor = Cursors.Hand;
            btDeleteReservation.FlatStyle = FlatStyle.Flat;
            btDeleteReservation.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDeleteReservation.ForeColor = SystemColors.ControlText;
            btDeleteReservation.Location = new Point(471, 357);
            btDeleteReservation.Name = "btDeleteReservation";
            btDeleteReservation.Size = new Size(117, 33);
            btDeleteReservation.TabIndex = 9;
            btDeleteReservation.Text = "Delete";
            btDeleteReservation.UseVisualStyleBackColor = false;
            btDeleteReservation.Click += btDeleteReservation_Click;
            // 
            // btUpdateReservation
            // 
            btUpdateReservation.Anchor = AnchorStyles.None;
            btUpdateReservation.BackColor = Color.SkyBlue;
            btUpdateReservation.Cursor = Cursors.Hand;
            btUpdateReservation.FlatStyle = FlatStyle.Flat;
            btUpdateReservation.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btUpdateReservation.ForeColor = SystemColors.ControlText;
            btUpdateReservation.Location = new Point(312, 357);
            btUpdateReservation.Name = "btUpdateReservation";
            btUpdateReservation.Size = new Size(117, 33);
            btUpdateReservation.TabIndex = 8;
            btUpdateReservation.Text = "Update";
            btUpdateReservation.UseVisualStyleBackColor = false;
            btUpdateReservation.Click += btUpdateReservation_Click;
            // 
            // dateTimePickerUpdateCheckOut
            // 
            dateTimePickerUpdateCheckOut.Location = new Point(591, 239);
            dateTimePickerUpdateCheckOut.Name = "dateTimePickerUpdateCheckOut";
            dateTimePickerUpdateCheckOut.Size = new Size(200, 22);
            dateTimePickerUpdateCheckOut.TabIndex = 6;
            // 
            // dateTimePickerUpdateCheckIn
            // 
            dateTimePickerUpdateCheckIn.Location = new Point(229, 241);
            dateTimePickerUpdateCheckIn.Name = "dateTimePickerUpdateCheckIn";
            dateTimePickerUpdateCheckIn.Size = new Size(200, 22);
            dateTimePickerUpdateCheckIn.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(493, 243);
            label1.Name = "label1";
            label1.Size = new Size(95, 19);
            label1.TabIndex = 0;
            label1.Text = "Check Out:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(130, 241);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 0;
            label2.Text = "Check In:";
            // 
            // comboBoxUpdateRoomNumber
            // 
            comboBoxUpdateRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUpdateRoomNumber.Font = new Font("Microsoft Sans Serif", 9.75F);
            comboBoxUpdateRoomNumber.FormattingEnabled = true;
            comboBoxUpdateRoomNumber.Location = new Point(229, 203);
            comboBoxUpdateRoomNumber.Name = "comboBoxUpdateRoomNumber";
            comboBoxUpdateRoomNumber.Size = new Size(85, 24);
            comboBoxUpdateRoomNumber.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(130, 203);
            label5.Name = "label5";
            label5.Size = new Size(87, 19);
            label5.TabIndex = 0;
            label5.Text = "Room NO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.Location = new Point(130, 282);
            label6.Name = "label6";
            label6.Size = new Size(56, 19);
            label6.TabIndex = 0;
            label6.Text = "Status:";
            // 
            // btSearchRoom
            // 
            btSearchRoom.Anchor = AnchorStyles.None;
            btSearchRoom.BackColor = Color.SkyBlue;
            btSearchRoom.Cursor = Cursors.Hand;
            btSearchRoom.FlatStyle = FlatStyle.Flat;
            btSearchRoom.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSearchRoom.ForeColor = SystemColors.ControlText;
            btSearchRoom.Location = new Point(932, 311);
            btSearchRoom.Name = "btSearchRoom";
            btSearchRoom.Size = new Size(117, 33);
            btSearchRoom.TabIndex = 55;
            btSearchRoom.Text = "Search";
            btSearchRoom.UseVisualStyleBackColor = false;
            // 
            // btDeleteRoom
            // 
            btDeleteRoom.Anchor = AnchorStyles.None;
            btDeleteRoom.BackColor = Color.Red;
            btDeleteRoom.Cursor = Cursors.Hand;
            btDeleteRoom.FlatStyle = FlatStyle.Flat;
            btDeleteRoom.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDeleteRoom.ForeColor = SystemColors.ControlText;
            btDeleteRoom.Location = new Point(820, 541);
            btDeleteRoom.Name = "btDeleteRoom";
            btDeleteRoom.Size = new Size(117, 33);
            btDeleteRoom.TabIndex = 44;
            btDeleteRoom.Text = "Delete";
            btDeleteRoom.UseVisualStyleBackColor = false;
            // 
            // btUpdateRoom
            // 
            btUpdateRoom.Anchor = AnchorStyles.None;
            btUpdateRoom.BackColor = Color.SkyBlue;
            btUpdateRoom.Cursor = Cursors.Hand;
            btUpdateRoom.FlatStyle = FlatStyle.Flat;
            btUpdateRoom.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btUpdateRoom.ForeColor = SystemColors.ControlText;
            btUpdateRoom.Location = new Point(642, 541);
            btUpdateRoom.Name = "btUpdateRoom";
            btUpdateRoom.Size = new Size(117, 33);
            btUpdateRoom.TabIndex = 43;
            btUpdateRoom.Text = "Update";
            btUpdateRoom.UseVisualStyleBackColor = false;
            // 
            // btDeleteClient
            // 
            btDeleteClient.Anchor = AnchorStyles.None;
            btDeleteClient.BackColor = Color.SkyBlue;
            btDeleteClient.Cursor = Cursors.Hand;
            btDeleteClient.FlatStyle = FlatStyle.Flat;
            btDeleteClient.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDeleteClient.ForeColor = SystemColors.ControlText;
            btDeleteClient.Location = new Point(1126, 708);
            btDeleteClient.Name = "btDeleteClient";
            btDeleteClient.Size = new Size(117, 33);
            btDeleteClient.TabIndex = 42;
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
            btUpdateClient.Location = new Point(967, 708);
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
            btSearch.Location = new Point(1286, 490);
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
            btDelete.Location = new Point(1478, 925);
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
            btUpdate.Location = new Point(1318, 925);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(117, 41);
            btUpdate.TabIndex = 13;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = false;
            // 
            // txtSerching
            // 
            txtSerching.Location = new Point(388, 90);
            txtSerching.Name = "txtSerching";
            txtSerching.Size = new Size(176, 22);
            txtSerching.TabIndex = 2;
            // 
            // comboBoxSearchingType
            // 
            comboBoxSearchingType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchingType.FormattingEnabled = true;
            comboBoxSearchingType.Items.AddRange(new object[] { "Id" });
            comboBoxSearchingType.Location = new Point(261, 90);
            comboBoxSearchingType.Name = "comboBoxSearchingType";
            comboBoxSearchingType.Size = new Size(109, 25);
            comboBoxSearchingType.TabIndex = 1;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label24.Location = new Point(164, 93);
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
            label13.Location = new Point(217, 14);
            label13.Name = "label13";
            label13.Size = new Size(469, 34);
            label13.TabIndex = 0;
            label13.Text = "Update and Delete Reservation";
            // 
            // ucReservation
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(tabControlClient);
            Name = "ucReservation";
            Size = new Size(915, 502);
            Load += ReservationControl_Load;
            tabControlClient.ResumeLayout(false);
            tabPageAddClient.ResumeLayout(false);
            tabPageAddClient.PerformLayout();
            c.ResumeLayout(false);
            c.PerformLayout();
            tabPageClientList.ResumeLayout(false);
            tabPageClientList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoomList).EndInit();
            tabPageUpdateAndDelete.ResumeLayout(false);
            tabPageUpdateAndDelete.PerformLayout();
            groupBoxUpdateStatus.ResumeLayout(false);
            groupBoxUpdateStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlClient;
        private TabPage tabPageAddClient;
        private Label label4;
        private Label label3;
        private Button btAddRoom;
        private Button btAddClient;
        private Button btAddUser;
        private GroupBox c;
        private RadioButton radButAddStatusPending;
        private RadioButton radButAddStatudConfirmed;
        private ComboBox comboBoxAddRoomNumber;
        private Label label11;
        private Label label10;
        private Label label8;
        private TabPage tabPageClientList;
        private Label label12;
        private DataGridView dataGridViewRoomList;
        private TabPage tabPageUpdateAndDelete;
        private Button btSearchRoom;
        private Button btDeleteRoom;
        private Button btUpdateRoom;
        private Button btDeleteClient;
        private Button btUpdateClient;
        private Button btSearch;
        private Button btDelete;
        private Button btUpdate;
        private TextBox txtSerching;
        private ComboBox comboBoxSearchingType;
        private Label label24;
        private Label label13;
        private DateTimePicker dateTimePickerAddCheckOut;
        private DateTimePicker dateTimePickerAddCheckIn;
        private DateTimePicker dateTimePickerUpdateCheckOut;
        private DateTimePicker dateTimePickerUpdateCheckIn;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxUpdateRoomNumber;
        private Label label5;
        private Label label6;
        private Button btAddReservation;
        private Button btDeleteReservation;
        private Button btUpdateReservation;
        private Button btSearchReservation;
        private GroupBox groupBoxUpdateStatus;
        private RadioButton radButUpdateStatusPending;
        private RadioButton radButUpdateStatusConfirmed;
        private ComboBox comboBoxAddClientId;
        private Label label7;
        private TextBox txtClientAddName;
        private TextBox txtClientUpdateName;
        private ComboBox comboBoxUpdateClientId;
        private Label label9;
    }
}
