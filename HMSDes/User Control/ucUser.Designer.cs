namespace HMSDesktop.User_Contrul
{
    partial class ucUser
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
            tabControlUser = new TabControl();
            tabPageAddUser = new TabPage();
            labelAddImage = new Label();
            btAddUser = new Button();
            pictureBoxAddImage = new PictureBox();
            groupBoxAddRoleName = new GroupBox();
            radButAddRoleNameManager = new RadioButton();
            radButAddRoleNameAdmin = new RadioButton();
            groupBoxAddGender = new GroupBox();
            radButAddGenderFamale = new RadioButton();
            radButAddGenderMale = new RadioButton();
            comboBoxAddNationality = new ComboBox();
            dateTimeAddBirthDate = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtAddPhoneNumber = new TextBox();
            label5 = new Label();
            txtAddUserName = new TextBox();
            label4 = new Label();
            txtAddPassword = new TextBox();
            label3 = new Label();
            txtAddFName = new TextBox();
            label2 = new Label();
            txtAddLName = new TextBox();
            label1 = new Label();
            groupBoxAddIsActive = new GroupBox();
            radButAddIsActiveNo = new RadioButton();
            radButAddIsActiveYes = new RadioButton();
            tabPageUserList = new TabPage();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            tabPageUpdateAndDelete = new TabPage();
            labelUpdateImage = new Label();
            btSearch = new Button();
            btDelete = new Button();
            btUpdate = new Button();
            txtSerching = new TextBox();
            comboBoxSearchingType = new ComboBox();
            label24 = new Label();
            pictureBoxUpdateImage = new PictureBox();
            groupBoxUpdateRoleName = new GroupBox();
            radButUpdateRoleNameManager = new RadioButton();
            radButUpdateRoleNameAdmin = new RadioButton();
            groupBoxUpdateGender = new GroupBox();
            radButUpdateGenderFamale = new RadioButton();
            radButUpdateGenderMale = new RadioButton();
            comboBoxUpdateNationality = new ComboBox();
            dateTimeUpdateBirthDate = new DateTimePicker();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            txtUpdatePhoneNumber = new TextBox();
            label19 = new Label();
            txtUpdateUserName = new TextBox();
            label20 = new Label();
            txtUpdatePassword = new TextBox();
            label21 = new Label();
            txtUpdateFName = new TextBox();
            label22 = new Label();
            txtUpdateLName = new TextBox();
            label23 = new Label();
            groupBoxUpdateIsActive = new GroupBox();
            radButUpdateIsActiveNo = new RadioButton();
            radButUpdateIsActiveYes = new RadioButton();
            tabControlUser.SuspendLayout();
            tabPageAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddImage).BeginInit();
            groupBoxAddRoleName.SuspendLayout();
            groupBoxAddGender.SuspendLayout();
            groupBoxAddIsActive.SuspendLayout();
            tabPageUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageUpdateAndDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUpdateImage).BeginInit();
            groupBoxUpdateRoleName.SuspendLayout();
            groupBoxUpdateGender.SuspendLayout();
            groupBoxUpdateIsActive.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlUser
            // 
            tabControlUser.Anchor = AnchorStyles.None;
            tabControlUser.Controls.Add(tabPageAddUser);
            tabControlUser.Controls.Add(tabPageUserList);
            tabControlUser.Controls.Add(tabPageUpdateAndDelete);
            tabControlUser.Location = new Point(5, 12);
            tabControlUser.Multiline = true;
            tabControlUser.Name = "tabControlUser";
            tabControlUser.SelectedIndex = 0;
            tabControlUser.Size = new Size(899, 487);
            tabControlUser.TabIndex = 0;
            tabControlUser.Selecting += tabControlUser_Selecting;
            // 
            // tabPageAddUser
            // 
            tabPageAddUser.Controls.Add(labelAddImage);
            tabPageAddUser.Controls.Add(btAddUser);
            tabPageAddUser.Controls.Add(pictureBoxAddImage);
            tabPageAddUser.Controls.Add(groupBoxAddRoleName);
            tabPageAddUser.Controls.Add(groupBoxAddGender);
            tabPageAddUser.Controls.Add(comboBoxAddNationality);
            tabPageAddUser.Controls.Add(dateTimeAddBirthDate);
            tabPageAddUser.Controls.Add(label11);
            tabPageAddUser.Controls.Add(label10);
            tabPageAddUser.Controls.Add(label9);
            tabPageAddUser.Controls.Add(label8);
            tabPageAddUser.Controls.Add(label7);
            tabPageAddUser.Controls.Add(label6);
            tabPageAddUser.Controls.Add(txtAddPhoneNumber);
            tabPageAddUser.Controls.Add(label5);
            tabPageAddUser.Controls.Add(txtAddUserName);
            tabPageAddUser.Controls.Add(label4);
            tabPageAddUser.Controls.Add(txtAddPassword);
            tabPageAddUser.Controls.Add(label3);
            tabPageAddUser.Controls.Add(txtAddFName);
            tabPageAddUser.Controls.Add(label2);
            tabPageAddUser.Controls.Add(txtAddLName);
            tabPageAddUser.Controls.Add(label1);
            tabPageAddUser.Controls.Add(groupBoxAddIsActive);
            tabPageAddUser.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageAddUser.Location = new Point(4, 26);
            tabPageAddUser.Name = "tabPageAddUser";
            tabPageAddUser.Padding = new Padding(3);
            tabPageAddUser.Size = new Size(891, 457);
            tabPageAddUser.TabIndex = 0;
            tabPageAddUser.Text = "Add User";
            tabPageAddUser.UseVisualStyleBackColor = true;
            tabPageAddUser.Click += tabPageAddUser_Click;
            // 
            // labelAddImage
            // 
            labelAddImage.AutoSize = true;
            labelAddImage.ForeColor = Color.MediumBlue;
            labelAddImage.Location = new Point(753, 260);
            labelAddImage.Name = "labelAddImage";
            labelAddImage.Size = new Size(67, 16);
            labelAddImage.TabIndex = 11;
            labelAddImage.Text = "Set Image";
            labelAddImage.Click += labelAddImage_Click;
            // 
            // btAddUser
            // 
            btAddUser.Anchor = AnchorStyles.None;
            btAddUser.BackColor = Color.SkyBlue;
            btAddUser.Cursor = Cursors.Hand;
            btAddUser.FlatStyle = FlatStyle.Flat;
            btAddUser.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAddUser.ForeColor = SystemColors.ControlText;
            btAddUser.Location = new Point(330, 360);
            btAddUser.Name = "btAddUser";
            btAddUser.Size = new Size(197, 41);
            btAddUser.TabIndex = 12;
            btAddUser.Text = "Add";
            btAddUser.UseVisualStyleBackColor = false;
            btAddUser.Click += btAddUser_Click;
            // 
            // pictureBoxAddImage
            // 
            pictureBoxAddImage.Image = Properties.Resources.user;
            pictureBoxAddImage.Location = new Point(714, 87);
            pictureBoxAddImage.Name = "pictureBoxAddImage";
            pictureBoxAddImage.Size = new Size(140, 170);
            pictureBoxAddImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAddImage.TabIndex = 24;
            pictureBoxAddImage.TabStop = false;
            // 
            // groupBoxAddRoleName
            // 
            groupBoxAddRoleName.Controls.Add(radButAddRoleNameManager);
            groupBoxAddRoleName.Controls.Add(radButAddRoleNameAdmin);
            groupBoxAddRoleName.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBoxAddRoleName.Location = new Point(488, 243);
            groupBoxAddRoleName.Name = "groupBoxAddRoleName";
            groupBoxAddRoleName.Size = new Size(186, 40);
            groupBoxAddRoleName.TabIndex = 10;
            groupBoxAddRoleName.TabStop = false;
            // 
            // radButAddRoleNameManager
            // 
            radButAddRoleNameManager.AutoSize = true;
            radButAddRoleNameManager.Location = new Point(93, 15);
            radButAddRoleNameManager.Name = "radButAddRoleNameManager";
            radButAddRoleNameManager.Size = new Size(79, 20);
            radButAddRoleNameManager.TabIndex = 1;
            radButAddRoleNameManager.TabStop = true;
            radButAddRoleNameManager.Text = "Manager";
            radButAddRoleNameManager.UseVisualStyleBackColor = true;
            // 
            // radButAddRoleNameAdmin
            // 
            radButAddRoleNameAdmin.AutoSize = true;
            radButAddRoleNameAdmin.Location = new Point(8, 15);
            radButAddRoleNameAdmin.Name = "radButAddRoleNameAdmin";
            radButAddRoleNameAdmin.Size = new Size(63, 20);
            radButAddRoleNameAdmin.TabIndex = 0;
            radButAddRoleNameAdmin.TabStop = true;
            radButAddRoleNameAdmin.Text = "Admin";
            radButAddRoleNameAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddGender
            // 
            groupBoxAddGender.Controls.Add(radButAddGenderFamale);
            groupBoxAddGender.Controls.Add(radButAddGenderMale);
            groupBoxAddGender.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBoxAddGender.Location = new Point(488, 197);
            groupBoxAddGender.Name = "groupBoxAddGender";
            groupBoxAddGender.Size = new Size(186, 40);
            groupBoxAddGender.TabIndex = 9;
            groupBoxAddGender.TabStop = false;
            // 
            // radButAddGenderFamale
            // 
            radButAddGenderFamale.AutoSize = true;
            radButAddGenderFamale.Location = new Point(93, 15);
            radButAddGenderFamale.Name = "radButAddGenderFamale";
            radButAddGenderFamale.Size = new Size(71, 20);
            radButAddGenderFamale.TabIndex = 1;
            radButAddGenderFamale.TabStop = true;
            radButAddGenderFamale.Text = "Famale";
            radButAddGenderFamale.UseVisualStyleBackColor = true;
            // 
            // radButAddGenderMale
            // 
            radButAddGenderMale.AutoSize = true;
            radButAddGenderMale.Location = new Point(8, 15);
            radButAddGenderMale.Name = "radButAddGenderMale";
            radButAddGenderMale.Size = new Size(55, 20);
            radButAddGenderMale.TabIndex = 0;
            radButAddGenderMale.TabStop = true;
            radButAddGenderMale.Text = "Male";
            radButAddGenderMale.UseVisualStyleBackColor = true;
            // 
            // comboBoxAddNationality
            // 
            comboBoxAddNationality.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAddNationality.Font = new Font("Microsoft Sans Serif", 9.75F);
            comboBoxAddNationality.FormattingEnabled = true;
            comboBoxAddNationality.Location = new Point(488, 170);
            comboBoxAddNationality.Name = "comboBoxAddNationality";
            comboBoxAddNationality.Size = new Size(139, 24);
            comboBoxAddNationality.TabIndex = 8;
            // 
            // dateTimeAddBirthDate
            // 
            dateTimeAddBirthDate.Font = new Font("Microsoft Sans Serif", 9.75F);
            dateTimeAddBirthDate.Location = new Point(136, 210);
            dateTimeAddBirthDate.Name = "dateTimeAddBirthDate";
            dateTimeAddBirthDate.Size = new Size(176, 22);
            dateTimeAddBirthDate.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(302, 14);
            label11.Name = "label11";
            label11.Size = new Size(225, 34);
            label11.TabIndex = 0;
            label11.Text = "Add New User";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label10.Location = new Point(354, 170);
            label10.Name = "label10";
            label10.Size = new Size(96, 19);
            label10.TabIndex = 0;
            label10.Text = "Nationality:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label9.Location = new Point(354, 251);
            label9.Name = "label9";
            label9.Size = new Size(97, 19);
            label9.TabIndex = 0;
            label9.Text = "Role name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label8.Location = new Point(354, 210);
            label8.Name = "label8";
            label8.Size = new Size(72, 19);
            label8.TabIndex = 0;
            label8.Text = "Gender:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label7.Location = new Point(29, 251);
            label7.Name = "label7";
            label7.Size = new Size(75, 19);
            label7.TabIndex = 0;
            label7.Text = "Is active:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.Location = new Point(354, 133);
            label6.Name = "label6";
            label6.Size = new Size(128, 19);
            label6.TabIndex = 0;
            label6.Text = "Phone number:";
            // 
            // txtAddPhoneNumber
            // 
            txtAddPhoneNumber.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtAddPhoneNumber.Location = new Point(488, 130);
            txtAddPhoneNumber.Name = "txtAddPhoneNumber";
            txtAddPhoneNumber.Size = new Size(186, 22);
            txtAddPhoneNumber.TabIndex = 7;
            txtAddPhoneNumber.KeyPress += txtAddPhoneNumber_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(29, 210);
            label5.Name = "label5";
            label5.Size = new Size(76, 19);
            label5.TabIndex = 0;
            label5.Text = "Birthday:";
            // 
            // txtAddUserName
            // 
            txtAddUserName.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtAddUserName.Location = new Point(136, 130);
            txtAddUserName.Name = "txtAddUserName";
            txtAddUserName.Size = new Size(176, 22);
            txtAddUserName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(29, 133);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 0;
            label4.Text = "User name:";
            // 
            // txtAddPassword
            // 
            txtAddPassword.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtAddPassword.Location = new Point(136, 170);
            txtAddPassword.Name = "txtAddPassword";
            txtAddPassword.Size = new Size(176, 22);
            txtAddPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(29, 170);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 0;
            label3.Text = "Password:";
            // 
            // txtAddFName
            // 
            txtAddFName.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtAddFName.Location = new Point(136, 88);
            txtAddFName.Name = "txtAddFName";
            txtAddFName.Size = new Size(176, 22);
            txtAddFName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(354, 88);
            label2.Name = "label2";
            label2.Size = new Size(92, 19);
            label2.TabIndex = 0;
            label2.Text = "Last name:";
            // 
            // txtAddLName
            // 
            txtAddLName.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtAddLName.Location = new Point(488, 87);
            txtAddLName.Name = "txtAddLName";
            txtAddLName.Size = new Size(186, 22);
            txtAddLName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(29, 93);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 0;
            label1.Text = "Frist name:";
            // 
            // groupBoxAddIsActive
            // 
            groupBoxAddIsActive.Controls.Add(radButAddIsActiveNo);
            groupBoxAddIsActive.Controls.Add(radButAddIsActiveYes);
            groupBoxAddIsActive.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBoxAddIsActive.Location = new Point(136, 241);
            groupBoxAddIsActive.Name = "groupBoxAddIsActive";
            groupBoxAddIsActive.Size = new Size(176, 42);
            groupBoxAddIsActive.TabIndex = 5;
            groupBoxAddIsActive.TabStop = false;
            // 
            // radButAddIsActiveNo
            // 
            radButAddIsActiveNo.AutoSize = true;
            radButAddIsActiveNo.Location = new Point(102, 13);
            radButAddIsActiveNo.Name = "radButAddIsActiveNo";
            radButAddIsActiveNo.Size = new Size(43, 20);
            radButAddIsActiveNo.TabIndex = 1;
            radButAddIsActiveNo.TabStop = true;
            radButAddIsActiveNo.Text = "No";
            radButAddIsActiveNo.UseVisualStyleBackColor = true;
            // 
            // radButAddIsActiveYes
            // 
            radButAddIsActiveYes.AutoSize = true;
            radButAddIsActiveYes.Location = new Point(6, 13);
            radButAddIsActiveYes.Name = "radButAddIsActiveYes";
            radButAddIsActiveYes.Size = new Size(49, 20);
            radButAddIsActiveYes.TabIndex = 0;
            radButAddIsActiveYes.TabStop = true;
            radButAddIsActiveYes.Text = "Yes";
            radButAddIsActiveYes.UseVisualStyleBackColor = true;
            // 
            // tabPageUserList
            // 
            tabPageUserList.Controls.Add(label12);
            tabPageUserList.Controls.Add(dataGridView1);
            tabPageUserList.Location = new Point(4, 24);
            tabPageUserList.Name = "tabPageUserList";
            tabPageUserList.Padding = new Padding(3);
            tabPageUserList.Size = new Size(891, 459);
            tabPageUserList.TabIndex = 1;
            tabPageUserList.Text = "Users list";
            tabPageUserList.UseVisualStyleBackColor = true;
            tabPageUserList.Click += tabPageUserList_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(322, 21);
            label12.Name = "label12";
            label12.Size = new Size(163, 34);
            label12.TabIndex = 0;
            label12.Text = "Users List";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(848, 319);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPageUpdateAndDelete
            // 
            tabPageUpdateAndDelete.Controls.Add(labelUpdateImage);
            tabPageUpdateAndDelete.Controls.Add(btSearch);
            tabPageUpdateAndDelete.Controls.Add(btDelete);
            tabPageUpdateAndDelete.Controls.Add(btUpdate);
            tabPageUpdateAndDelete.Controls.Add(txtSerching);
            tabPageUpdateAndDelete.Controls.Add(comboBoxSearchingType);
            tabPageUpdateAndDelete.Controls.Add(label24);
            tabPageUpdateAndDelete.Controls.Add(pictureBoxUpdateImage);
            tabPageUpdateAndDelete.Controls.Add(groupBoxUpdateRoleName);
            tabPageUpdateAndDelete.Controls.Add(groupBoxUpdateGender);
            tabPageUpdateAndDelete.Controls.Add(comboBoxUpdateNationality);
            tabPageUpdateAndDelete.Controls.Add(dateTimeUpdateBirthDate);
            tabPageUpdateAndDelete.Controls.Add(label13);
            tabPageUpdateAndDelete.Controls.Add(label14);
            tabPageUpdateAndDelete.Controls.Add(label15);
            tabPageUpdateAndDelete.Controls.Add(label16);
            tabPageUpdateAndDelete.Controls.Add(label17);
            tabPageUpdateAndDelete.Controls.Add(label18);
            tabPageUpdateAndDelete.Controls.Add(txtUpdatePhoneNumber);
            tabPageUpdateAndDelete.Controls.Add(label19);
            tabPageUpdateAndDelete.Controls.Add(txtUpdateUserName);
            tabPageUpdateAndDelete.Controls.Add(label20);
            tabPageUpdateAndDelete.Controls.Add(txtUpdatePassword);
            tabPageUpdateAndDelete.Controls.Add(label21);
            tabPageUpdateAndDelete.Controls.Add(txtUpdateFName);
            tabPageUpdateAndDelete.Controls.Add(label22);
            tabPageUpdateAndDelete.Controls.Add(txtUpdateLName);
            tabPageUpdateAndDelete.Controls.Add(label23);
            tabPageUpdateAndDelete.Controls.Add(groupBoxUpdateIsActive);
            tabPageUpdateAndDelete.Location = new Point(4, 26);
            tabPageUpdateAndDelete.Name = "tabPageUpdateAndDelete";
            tabPageUpdateAndDelete.Size = new Size(891, 457);
            tabPageUpdateAndDelete.TabIndex = 0;
            tabPageUpdateAndDelete.Text = "Update&Delete";
            tabPageUpdateAndDelete.UseVisualStyleBackColor = true;
            // 
            // labelUpdateImage
            // 
            labelUpdateImage.AutoSize = true;
            labelUpdateImage.ForeColor = Color.MediumBlue;
            labelUpdateImage.Location = new Point(756, 323);
            labelUpdateImage.Name = "labelUpdateImage";
            labelUpdateImage.Size = new Size(69, 17);
            labelUpdateImage.TabIndex = 14;
            labelUpdateImage.Text = "Set Image";
            labelUpdateImage.Click += labelUpdateImage_Click;
            // 
            // btSearch
            // 
            btSearch.Anchor = AnchorStyles.None;
            btSearch.BackColor = Color.SkyBlue;
            btSearch.Cursor = Cursors.Hand;
            btSearch.FlatStyle = FlatStyle.Flat;
            btSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSearch.ForeColor = SystemColors.ControlText;
            btSearch.Location = new Point(546, 75);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(117, 33);
            btSearch.TabIndex = 3;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // btDelete
            // 
            btDelete.Anchor = AnchorStyles.None;
            btDelete.BackColor = Color.Red;
            btDelete.Cursor = Cursors.Hand;
            btDelete.FlatStyle = FlatStyle.Flat;
            btDelete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDelete.ForeColor = SystemColors.ControlText;
            btDelete.Location = new Point(443, 376);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(117, 33);
            btDelete.TabIndex = 16;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = false;
            btDelete.Click += btDelete_Click;
            // 
            // btUpdate
            // 
            btUpdate.Anchor = AnchorStyles.None;
            btUpdate.BackColor = Color.SkyBlue;
            btUpdate.Cursor = Cursors.Hand;
            btUpdate.FlatStyle = FlatStyle.Flat;
            btUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btUpdate.ForeColor = SystemColors.ControlText;
            btUpdate.Location = new Point(283, 376);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(117, 33);
            btUpdate.TabIndex = 15;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = false;
            btUpdate.Click += btUpdate_Click;
            // 
            // txtSerching
            // 
            txtSerching.Location = new Point(345, 86);
            txtSerching.Name = "txtSerching";
            txtSerching.Size = new Size(176, 22);
            txtSerching.TabIndex = 2;
            txtSerching.KeyPress += txtSerching_KeyPress;
            // 
            // comboBoxSearchingType
            // 
            comboBoxSearchingType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchingType.FormattingEnabled = true;
            comboBoxSearchingType.Items.AddRange(new object[] { "Id", "User name" });
            comboBoxSearchingType.Location = new Point(218, 86);
            comboBoxSearchingType.Name = "comboBoxSearchingType";
            comboBoxSearchingType.Size = new Size(109, 25);
            comboBoxSearchingType.TabIndex = 1;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label24.Location = new Point(121, 89);
            label24.Name = "label24";
            label24.Size = new Size(91, 19);
            label24.TabIndex = 0;
            label24.Text = "Search by:";
            // 
            // pictureBoxUpdateImage
            // 
            pictureBoxUpdateImage.Image = Properties.Resources.user;
            pictureBoxUpdateImage.Location = new Point(726, 148);
            pictureBoxUpdateImage.Name = "pictureBoxUpdateImage";
            pictureBoxUpdateImage.Size = new Size(140, 170);
            pictureBoxUpdateImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUpdateImage.TabIndex = 46;
            pictureBoxUpdateImage.TabStop = false;
            // 
            // groupBoxUpdateRoleName
            // 
            groupBoxUpdateRoleName.Controls.Add(radButUpdateRoleNameManager);
            groupBoxUpdateRoleName.Controls.Add(radButUpdateRoleNameAdmin);
            groupBoxUpdateRoleName.Location = new Point(500, 304);
            groupBoxUpdateRoleName.Name = "groupBoxUpdateRoleName";
            groupBoxUpdateRoleName.Size = new Size(186, 40);
            groupBoxUpdateRoleName.TabIndex = 13;
            groupBoxUpdateRoleName.TabStop = false;
            // 
            // radButUpdateRoleNameManager
            // 
            radButUpdateRoleNameManager.AutoSize = true;
            radButUpdateRoleNameManager.Location = new Point(93, 15);
            radButUpdateRoleNameManager.Name = "radButUpdateRoleNameManager";
            radButUpdateRoleNameManager.Size = new Size(80, 21);
            radButUpdateRoleNameManager.TabIndex = 1;
            radButUpdateRoleNameManager.TabStop = true;
            radButUpdateRoleNameManager.Text = "Manager";
            radButUpdateRoleNameManager.UseVisualStyleBackColor = true;
            // 
            // radButUpdateRoleNameAdmin
            // 
            radButUpdateRoleNameAdmin.AutoSize = true;
            radButUpdateRoleNameAdmin.Location = new Point(8, 15);
            radButUpdateRoleNameAdmin.Name = "radButUpdateRoleNameAdmin";
            radButUpdateRoleNameAdmin.Size = new Size(64, 21);
            radButUpdateRoleNameAdmin.TabIndex = 0;
            radButUpdateRoleNameAdmin.TabStop = true;
            radButUpdateRoleNameAdmin.Text = "Admin";
            radButUpdateRoleNameAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBoxUpdateGender
            // 
            groupBoxUpdateGender.Controls.Add(radButUpdateGenderFamale);
            groupBoxUpdateGender.Controls.Add(radButUpdateGenderMale);
            groupBoxUpdateGender.Location = new Point(500, 258);
            groupBoxUpdateGender.Name = "groupBoxUpdateGender";
            groupBoxUpdateGender.Size = new Size(186, 40);
            groupBoxUpdateGender.TabIndex = 11;
            groupBoxUpdateGender.TabStop = false;
            // 
            // radButUpdateGenderFamale
            // 
            radButUpdateGenderFamale.AutoSize = true;
            radButUpdateGenderFamale.Location = new Point(93, 15);
            radButUpdateGenderFamale.Name = "radButUpdateGenderFamale";
            radButUpdateGenderFamale.Size = new Size(70, 21);
            radButUpdateGenderFamale.TabIndex = 1;
            radButUpdateGenderFamale.TabStop = true;
            radButUpdateGenderFamale.Text = "Famale";
            radButUpdateGenderFamale.UseVisualStyleBackColor = true;
            // 
            // radButUpdateGenderMale
            // 
            radButUpdateGenderMale.AutoSize = true;
            radButUpdateGenderMale.Location = new Point(8, 15);
            radButUpdateGenderMale.Name = "radButUpdateGenderMale";
            radButUpdateGenderMale.Size = new Size(56, 21);
            radButUpdateGenderMale.TabIndex = 0;
            radButUpdateGenderMale.TabStop = true;
            radButUpdateGenderMale.Text = "Male";
            radButUpdateGenderMale.UseVisualStyleBackColor = true;
            // 
            // comboBoxUpdateNationality
            // 
            comboBoxUpdateNationality.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUpdateNationality.FormattingEnabled = true;
            comboBoxUpdateNationality.Location = new Point(500, 231);
            comboBoxUpdateNationality.Name = "comboBoxUpdateNationality";
            comboBoxUpdateNationality.Size = new Size(139, 25);
            comboBoxUpdateNationality.TabIndex = 9;
            // 
            // dateTimeUpdateBirthDate
            // 
            dateTimeUpdateBirthDate.Location = new Point(148, 271);
            dateTimeUpdateBirthDate.Name = "dateTimeUpdateBirthDate";
            dateTimeUpdateBirthDate.Size = new Size(179, 22);
            dateTimeUpdateBirthDate.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(255, 14);
            label13.Name = "label13";
            label13.Size = new Size(365, 34);
            label13.TabIndex = 40;
            label13.Text = "Update and Delete User";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label14.Location = new Point(366, 231);
            label14.Name = "label14";
            label14.Size = new Size(96, 19);
            label14.TabIndex = 0;
            label14.Text = "Nationality:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label15.Location = new Point(366, 312);
            label15.Name = "label15";
            label15.Size = new Size(97, 19);
            label15.TabIndex = 0;
            label15.Text = "Role name:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label16.Location = new Point(366, 271);
            label16.Name = "label16";
            label16.Size = new Size(72, 19);
            label16.TabIndex = 0;
            label16.Text = "Gender:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label17.Location = new Point(41, 312);
            label17.Name = "label17";
            label17.Size = new Size(75, 19);
            label17.TabIndex = 0;
            label17.Text = "Is active:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label18.Location = new Point(366, 194);
            label18.Name = "label18";
            label18.Size = new Size(128, 19);
            label18.TabIndex = 0;
            label18.Text = "Phone number:";
            // 
            // txtUpdatePhoneNumber
            // 
            txtUpdatePhoneNumber.Location = new Point(500, 191);
            txtUpdatePhoneNumber.Name = "txtUpdatePhoneNumber";
            txtUpdatePhoneNumber.Size = new Size(186, 22);
            txtUpdatePhoneNumber.TabIndex = 7;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label19.Location = new Point(41, 271);
            label19.Name = "label19";
            label19.Size = new Size(76, 19);
            label19.TabIndex = 0;
            label19.Text = "Birthday:";
            // 
            // txtUpdateUserName
            // 
            txtUpdateUserName.Location = new Point(148, 191);
            txtUpdateUserName.Name = "txtUpdateUserName";
            txtUpdateUserName.Size = new Size(176, 22);
            txtUpdateUserName.TabIndex = 6;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label20.Location = new Point(41, 194);
            label20.Name = "label20";
            label20.Size = new Size(95, 19);
            label20.TabIndex = 0;
            label20.Text = "User name:";
            // 
            // txtUpdatePassword
            // 
            txtUpdatePassword.Location = new Point(148, 231);
            txtUpdatePassword.Name = "txtUpdatePassword";
            txtUpdatePassword.Size = new Size(176, 22);
            txtUpdatePassword.TabIndex = 8;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label21.Location = new Point(41, 231);
            label21.Name = "label21";
            label21.Size = new Size(84, 19);
            label21.TabIndex = 0;
            label21.Text = "Password:";
            // 
            // txtUpdateFName
            // 
            txtUpdateFName.Location = new Point(148, 149);
            txtUpdateFName.Name = "txtUpdateFName";
            txtUpdateFName.Size = new Size(176, 22);
            txtUpdateFName.TabIndex = 4;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label22.Location = new Point(366, 149);
            label22.Name = "label22";
            label22.Size = new Size(92, 19);
            label22.TabIndex = 0;
            label22.Text = "Last name:";
            // 
            // txtUpdateLName
            // 
            txtUpdateLName.Location = new Point(500, 148);
            txtUpdateLName.Name = "txtUpdateLName";
            txtUpdateLName.Size = new Size(186, 22);
            txtUpdateLName.TabIndex = 5;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label23.Location = new Point(41, 154);
            label23.Name = "label23";
            label23.Size = new Size(91, 19);
            label23.TabIndex = 0;
            label23.Text = "Frist name:";
            // 
            // groupBoxUpdateIsActive
            // 
            groupBoxUpdateIsActive.Controls.Add(radButUpdateIsActiveNo);
            groupBoxUpdateIsActive.Controls.Add(radButUpdateIsActiveYes);
            groupBoxUpdateIsActive.Location = new Point(148, 302);
            groupBoxUpdateIsActive.Name = "groupBoxUpdateIsActive";
            groupBoxUpdateIsActive.Size = new Size(176, 42);
            groupBoxUpdateIsActive.TabIndex = 12;
            groupBoxUpdateIsActive.TabStop = false;
            // 
            // radButUpdateIsActiveNo
            // 
            radButUpdateIsActiveNo.AutoSize = true;
            radButUpdateIsActiveNo.Location = new Point(102, 13);
            radButUpdateIsActiveNo.Name = "radButUpdateIsActiveNo";
            radButUpdateIsActiveNo.Size = new Size(43, 21);
            radButUpdateIsActiveNo.TabIndex = 1;
            radButUpdateIsActiveNo.TabStop = true;
            radButUpdateIsActiveNo.Text = "No";
            radButUpdateIsActiveNo.UseVisualStyleBackColor = true;
            radButUpdateIsActiveNo.CheckedChanged += radButUpdateIsActiveNo_CheckedChanged;
            // 
            // radButUpdateIsActiveYes
            // 
            radButUpdateIsActiveYes.AutoSize = true;
            radButUpdateIsActiveYes.Location = new Point(6, 13);
            radButUpdateIsActiveYes.Name = "radButUpdateIsActiveYes";
            radButUpdateIsActiveYes.Size = new Size(46, 21);
            radButUpdateIsActiveYes.TabIndex = 0;
            radButUpdateIsActiveYes.TabStop = true;
            radButUpdateIsActiveYes.Text = "Yes";
            radButUpdateIsActiveYes.UseVisualStyleBackColor = true;
            // 
            // ucUser
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(tabControlUser);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ucUser";
            Size = new Size(915, 502);
            Load += UserControl_Load;
            tabControlUser.ResumeLayout(false);
            tabPageAddUser.ResumeLayout(false);
            tabPageAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddImage).EndInit();
            groupBoxAddRoleName.ResumeLayout(false);
            groupBoxAddRoleName.PerformLayout();
            groupBoxAddGender.ResumeLayout(false);
            groupBoxAddGender.PerformLayout();
            groupBoxAddIsActive.ResumeLayout(false);
            groupBoxAddIsActive.PerformLayout();
            tabPageUserList.ResumeLayout(false);
            tabPageUserList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPageUpdateAndDelete.ResumeLayout(false);
            tabPageUpdateAndDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUpdateImage).EndInit();
            groupBoxUpdateRoleName.ResumeLayout(false);
            groupBoxUpdateRoleName.PerformLayout();
            groupBoxUpdateGender.ResumeLayout(false);
            groupBoxUpdateGender.PerformLayout();
            groupBoxUpdateIsActive.ResumeLayout(false);
            groupBoxUpdateIsActive.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlUser;
        private TabPage tabPageAddUser;
        private TabPage tabPageUserList;
        private TextBox txtAddPhoneNumber;
        private Label label5;
        private TextBox txtAddUserName;
        private Label label4;
        private TextBox txtAddPassword;
        private Label label3;
        private TextBox txtAddFName;
        private Label label2;
        private TextBox txtAddLName;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label10;
        private Label label9;
        private DateTimePicker dateTimeAddBirthDate;
        private Label label11;
        private ComboBox comboBoxAddNationality;
        private RadioButton radButAddIsActiveNo;
        private RadioButton radButAddIsActiveYes;
        private RadioButton radButAddGenderFamale;
        private RadioButton radButAddGenderMale;
        private GroupBox groupBoxAddGender;
        private GroupBox groupBoxAddIsActive;
        private GroupBox groupBoxAddRoleName;
        private RadioButton radButAddRoleNameManager;
        private RadioButton radButAddRoleNameAdmin;
        private PictureBox pictureBoxAddImage;
        private Label label12;
        private DataGridView dataGridView1;
        private TabPage tabPageUpdateAndDelete;
        private Button btDelete;
        private Button btUpdate;
        private TextBox txtSerching;
        private ComboBox comboBoxSearchingType;
        private Label label24;
        private PictureBox pictureBoxUpdateImage;
        private GroupBox groupBoxUpdateRoleName;
        private RadioButton radButUpdateRoleNameManager;
        private RadioButton radButUpdateRoleNameAdmin;
        private GroupBox groupBoxUpdateGender;
        private RadioButton radButUpdateGenderFamale;
        private RadioButton radButUpdateGenderMale;
        private ComboBox comboBoxUpdateNationality;
        private DateTimePicker dateTimeUpdateBirthDate;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox txtUpdatePhoneNumber;
        private Label label19;
        private TextBox txtUpdateUserName;
        private Label label20;
        private TextBox txtUpdatePassword;
        private Label label21;
        private TextBox txtUpdateFName;
        private Label label22;
        private TextBox txtUpdateLName;
        private Label label23;
        private GroupBox groupBoxUpdateIsActive;
        private RadioButton radButUpdateIsActiveNo;
        private RadioButton radButUpdateIsActiveYes;
        private Button btAddUser;
        private Button btSearch;
        private Label labelAddImage;
        private Label labelUpdateImage;
    }
}
