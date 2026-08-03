namespace HMSDesktop.User_Control
{
    partial class ucClient
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
            btAddClient = new Button();
            btAddUser = new Button();
            groupBoxAddGender = new GroupBox();
            radButAddGenderFamale = new RadioButton();
            radButAddGenderMale = new RadioButton();
            comboBoxAddNationality = new ComboBox();
            dateTimeAddBirthDate = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label6 = new Label();
            txtAddPhoneNumber = new TextBox();
            label5 = new Label();
            txtAddFName = new TextBox();
            label2 = new Label();
            txtAddLName = new TextBox();
            label1 = new Label();
            tabPageClientList = new TabPage();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            tabPageUpdateAndDelete = new TabPage();
            btDeleteClient = new Button();
            btUpdateClient = new Button();
            btSearch = new Button();
            btDelete = new Button();
            btUpdate = new Button();
            txtSerching = new TextBox();
            comboBoxSearchingType = new ComboBox();
            label24 = new Label();
            groupBoxUpdateGender = new GroupBox();
            radButUpdateGenderFamale = new RadioButton();
            radButUpdateGenderMale = new RadioButton();
            comboBoxUpdateNationality = new ComboBox();
            dateTimeUpdateBirthDate = new DateTimePicker();
            label13 = new Label();
            label14 = new Label();
            label16 = new Label();
            label18 = new Label();
            txtUpdatePhoneNumber = new TextBox();
            label19 = new Label();
            txtUpdateFName = new TextBox();
            label22 = new Label();
            txtUpdateLName = new TextBox();
            label23 = new Label();
            tabControlClient.SuspendLayout();
            tabPageAddClient.SuspendLayout();
            groupBoxAddGender.SuspendLayout();
            tabPageClientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageUpdateAndDelete.SuspendLayout();
            groupBoxUpdateGender.SuspendLayout();
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
            tabControlClient.RightToLeft = RightToLeft.No;
            tabControlClient.SelectedIndex = 0;
            tabControlClient.Size = new Size(891, 457);
            tabControlClient.TabIndex = 0;
            tabControlClient.Selecting += tabControlClient_Selecting;
            // 
            // tabPageAddClient
            // 
            tabPageAddClient.Controls.Add(btAddClient);
            tabPageAddClient.Controls.Add(btAddUser);
            tabPageAddClient.Controls.Add(groupBoxAddGender);
            tabPageAddClient.Controls.Add(comboBoxAddNationality);
            tabPageAddClient.Controls.Add(dateTimeAddBirthDate);
            tabPageAddClient.Controls.Add(label11);
            tabPageAddClient.Controls.Add(label10);
            tabPageAddClient.Controls.Add(label8);
            tabPageAddClient.Controls.Add(label6);
            tabPageAddClient.Controls.Add(txtAddPhoneNumber);
            tabPageAddClient.Controls.Add(label5);
            tabPageAddClient.Controls.Add(txtAddFName);
            tabPageAddClient.Controls.Add(label2);
            tabPageAddClient.Controls.Add(txtAddLName);
            tabPageAddClient.Controls.Add(label1);
            tabPageAddClient.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageAddClient.Location = new Point(4, 26);
            tabPageAddClient.Name = "tabPageAddClient";
            tabPageAddClient.Padding = new Padding(3);
            tabPageAddClient.RightToLeft = RightToLeft.No;
            tabPageAddClient.Size = new Size(883, 427);
            tabPageAddClient.TabIndex = 0;
            tabPageAddClient.Text = "Add Client";
            tabPageAddClient.UseVisualStyleBackColor = true;
            tabPageAddClient.Click += tabPageAddClient_Click;
            // 
            // btAddClient
            // 
            btAddClient.Anchor = AnchorStyles.None;
            btAddClient.BackColor = Color.SkyBlue;
            btAddClient.Cursor = Cursors.Hand;
            btAddClient.FlatStyle = FlatStyle.Flat;
            btAddClient.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAddClient.ForeColor = SystemColors.ControlText;
            btAddClient.Location = new Point(334, 301);
            btAddClient.Name = "btAddClient";
            btAddClient.Size = new Size(197, 41);
            btAddClient.TabIndex = 7;
            btAddClient.Text = "Add";
            btAddClient.UseVisualStyleBackColor = false;
            btAddClient.Click += btAddClient_Click;
            // 
            // btAddUser
            // 
            btAddUser.Anchor = AnchorStyles.None;
            btAddUser.BackColor = Color.SkyBlue;
            btAddUser.Cursor = Cursors.Hand;
            btAddUser.FlatStyle = FlatStyle.Flat;
            btAddUser.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAddUser.ForeColor = SystemColors.ControlText;
            btAddUser.Location = new Point(671, 544);
            btAddUser.Name = "btAddUser";
            btAddUser.Size = new Size(197, 41);
            btAddUser.TabIndex = 12;
            btAddUser.Text = "Add";
            btAddUser.UseVisualStyleBackColor = false;
            // 
            // groupBoxAddGender
            // 
            groupBoxAddGender.Controls.Add(radButAddGenderFamale);
            groupBoxAddGender.Controls.Add(radButAddGenderMale);
            groupBoxAddGender.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBoxAddGender.Location = new Point(570, 173);
            groupBoxAddGender.Name = "groupBoxAddGender";
            groupBoxAddGender.Size = new Size(186, 40);
            groupBoxAddGender.TabIndex = 6;
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
            comboBoxAddNationality.Location = new Point(218, 144);
            comboBoxAddNationality.Name = "comboBoxAddNationality";
            comboBoxAddNationality.Size = new Size(139, 24);
            comboBoxAddNationality.TabIndex = 3;
            // 
            // dateTimeAddBirthDate
            // 
            dateTimeAddBirthDate.Font = new Font("Microsoft Sans Serif", 9.75F);
            dateTimeAddBirthDate.Location = new Point(218, 191);
            dateTimeAddBirthDate.Name = "dateTimeAddBirthDate";
            dateTimeAddBirthDate.Size = new Size(139, 22);
            dateTimeAddBirthDate.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(310, 15);
            label11.Name = "label11";
            label11.Size = new Size(245, 34);
            label11.TabIndex = 0;
            label11.Text = "Add New Client";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label10.Location = new Point(109, 146);
            label10.Name = "label10";
            label10.Size = new Size(96, 19);
            label10.TabIndex = 0;
            label10.Text = "Nationality:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label8.Location = new Point(439, 181);
            label8.Name = "label8";
            label8.Size = new Size(72, 19);
            label8.TabIndex = 0;
            label8.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.Location = new Point(439, 144);
            label6.Name = "label6";
            label6.Size = new Size(128, 19);
            label6.TabIndex = 0;
            label6.Text = "Phone number:";
            // 
            // txtAddPhoneNumber
            // 
            txtAddPhoneNumber.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtAddPhoneNumber.Location = new Point(570, 138);
            txtAddPhoneNumber.Name = "txtAddPhoneNumber";
            txtAddPhoneNumber.Size = new Size(186, 22);
            txtAddPhoneNumber.TabIndex = 4;
            txtAddPhoneNumber.KeyPress += txtAddPhoneNumber_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(114, 191);
            label5.Name = "label5";
            label5.Size = new Size(76, 19);
            label5.TabIndex = 0;
            label5.Text = "Birthday:";
            label5.Click += label5_Click;
            // 
            // txtAddFName
            // 
            txtAddFName.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtAddFName.Location = new Point(218, 96);
            txtAddFName.Name = "txtAddFName";
            txtAddFName.Size = new Size(176, 22);
            txtAddFName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(439, 99);
            label2.Name = "label2";
            label2.Size = new Size(92, 19);
            label2.TabIndex = 0;
            label2.Text = "Last name:";
            // 
            // txtAddLName
            // 
            txtAddLName.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtAddLName.Location = new Point(570, 95);
            txtAddLName.Name = "txtAddLName";
            txtAddLName.Size = new Size(186, 22);
            txtAddLName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(114, 99);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 0;
            label1.Text = "Frist name:";
            // 
            // tabPageClientList
            // 
            tabPageClientList.Controls.Add(label12);
            tabPageClientList.Controls.Add(dataGridView1);
            tabPageClientList.Location = new Point(4, 26);
            tabPageClientList.Name = "tabPageClientList";
            tabPageClientList.Padding = new Padding(3);
            tabPageClientList.Size = new Size(883, 427);
            tabPageClientList.TabIndex = 1;
            tabPageClientList.Text = "Clients list";
            tabPageClientList.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(328, 21);
            label12.Name = "label12";
            label12.Size = new Size(183, 34);
            label12.TabIndex = 0;
            label12.Text = "Clients List";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridView1.Size = new Size(848, 319);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPageUpdateAndDelete
            // 
            tabPageUpdateAndDelete.Controls.Add(btDeleteClient);
            tabPageUpdateAndDelete.Controls.Add(btUpdateClient);
            tabPageUpdateAndDelete.Controls.Add(btSearch);
            tabPageUpdateAndDelete.Controls.Add(btDelete);
            tabPageUpdateAndDelete.Controls.Add(btUpdate);
            tabPageUpdateAndDelete.Controls.Add(txtSerching);
            tabPageUpdateAndDelete.Controls.Add(comboBoxSearchingType);
            tabPageUpdateAndDelete.Controls.Add(label24);
            tabPageUpdateAndDelete.Controls.Add(groupBoxUpdateGender);
            tabPageUpdateAndDelete.Controls.Add(comboBoxUpdateNationality);
            tabPageUpdateAndDelete.Controls.Add(dateTimeUpdateBirthDate);
            tabPageUpdateAndDelete.Controls.Add(label13);
            tabPageUpdateAndDelete.Controls.Add(label14);
            tabPageUpdateAndDelete.Controls.Add(label16);
            tabPageUpdateAndDelete.Controls.Add(label18);
            tabPageUpdateAndDelete.Controls.Add(txtUpdatePhoneNumber);
            tabPageUpdateAndDelete.Controls.Add(label19);
            tabPageUpdateAndDelete.Controls.Add(txtUpdateFName);
            tabPageUpdateAndDelete.Controls.Add(label22);
            tabPageUpdateAndDelete.Controls.Add(txtUpdateLName);
            tabPageUpdateAndDelete.Controls.Add(label23);
            tabPageUpdateAndDelete.Location = new Point(4, 26);
            tabPageUpdateAndDelete.Name = "tabPageUpdateAndDelete";
            tabPageUpdateAndDelete.RightToLeft = RightToLeft.No;
            tabPageUpdateAndDelete.Size = new Size(883, 427);
            tabPageUpdateAndDelete.TabIndex = 0;
            tabPageUpdateAndDelete.Text = "Update&Delete";
            tabPageUpdateAndDelete.UseVisualStyleBackColor = true;
            tabPageUpdateAndDelete.Click += tabPageUpdateAndDelete_Click;
            // 
            // btDeleteClient
            // 
            btDeleteClient.Anchor = AnchorStyles.None;
            btDeleteClient.BackColor = Color.Red;
            btDeleteClient.Cursor = Cursors.Hand;
            btDeleteClient.FlatStyle = FlatStyle.Flat;
            btDeleteClient.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDeleteClient.ForeColor = SystemColors.ControlText;
            btDeleteClient.Location = new Point(443, 331);
            btDeleteClient.Name = "btDeleteClient";
            btDeleteClient.Size = new Size(117, 33);
            btDeleteClient.TabIndex = 11;
            btDeleteClient.Text = "Delete";
            btDeleteClient.UseVisualStyleBackColor = false;
            btDeleteClient.Click += btDeleteClient_Click;
            // 
            // btUpdateClient
            // 
            btUpdateClient.Anchor = AnchorStyles.None;
            btUpdateClient.BackColor = Color.SkyBlue;
            btUpdateClient.Cursor = Cursors.Hand;
            btUpdateClient.FlatStyle = FlatStyle.Flat;
            btUpdateClient.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btUpdateClient.ForeColor = SystemColors.ControlText;
            btUpdateClient.Location = new Point(284, 331);
            btUpdateClient.Name = "btUpdateClient";
            btUpdateClient.Size = new Size(117, 33);
            btUpdateClient.TabIndex = 10;
            btUpdateClient.Text = "Update";
            btUpdateClient.UseVisualStyleBackColor = false;
            btUpdateClient.Click += btUpdateClient_Click;
            // 
            // btSearch
            // 
            btSearch.Anchor = AnchorStyles.None;
            btSearch.BackColor = Color.SkyBlue;
            btSearch.Cursor = Cursors.Hand;
            btSearch.FlatStyle = FlatStyle.Flat;
            btSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSearch.ForeColor = SystemColors.ControlText;
            btSearch.Location = new Point(584, 95);
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
            btDelete.Location = new Point(788, 567);
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
            btUpdate.Location = new Point(628, 567);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(117, 41);
            btUpdate.TabIndex = 13;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = false;
            // 
            // txtSerching
            // 
            txtSerching.Location = new Point(384, 99);
            txtSerching.Name = "txtSerching";
            txtSerching.Size = new Size(176, 22);
            txtSerching.TabIndex = 2;
            txtSerching.KeyPress += txtSerching_KeyPress;
            // 
            // comboBoxSearchingType
            // 
            comboBoxSearchingType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchingType.FormattingEnabled = true;
            comboBoxSearchingType.Items.AddRange(new object[] { "Id" });
            comboBoxSearchingType.Location = new Point(257, 99);
            comboBoxSearchingType.Name = "comboBoxSearchingType";
            comboBoxSearchingType.Size = new Size(109, 25);
            comboBoxSearchingType.TabIndex = 1;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label24.Location = new Point(160, 102);
            label24.Name = "label24";
            label24.Size = new Size(91, 19);
            label24.TabIndex = 0;
            label24.Text = "Search by:";
            // 
            // groupBoxUpdateGender
            // 
            groupBoxUpdateGender.Controls.Add(radButUpdateGenderFamale);
            groupBoxUpdateGender.Controls.Add(radButUpdateGenderMale);
            groupBoxUpdateGender.Location = new Point(538, 241);
            groupBoxUpdateGender.Name = "groupBoxUpdateGender";
            groupBoxUpdateGender.Size = new Size(186, 40);
            groupBoxUpdateGender.TabIndex = 9;
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
            comboBoxUpdateNationality.Location = new Point(187, 209);
            comboBoxUpdateNationality.Name = "comboBoxUpdateNationality";
            comboBoxUpdateNationality.Size = new Size(139, 25);
            comboBoxUpdateNationality.TabIndex = 5;
            // 
            // dateTimeUpdateBirthDate
            // 
            dateTimeUpdateBirthDate.Location = new Point(187, 251);
            dateTimeUpdateBirthDate.Name = "dateTimeUpdateBirthDate";
            dateTimeUpdateBirthDate.Size = new Size(176, 22);
            dateTimeUpdateBirthDate.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(242, 16);
            label13.Name = "label13";
            label13.Size = new Size(385, 34);
            label13.TabIndex = 0;
            label13.Text = "Update and Delete Client";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label14.Location = new Point(80, 208);
            label14.Name = "label14";
            label14.Size = new Size(96, 19);
            label14.TabIndex = 0;
            label14.Text = "Nationality:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label16.Location = new Point(405, 253);
            label16.Name = "label16";
            label16.Size = new Size(72, 19);
            label16.TabIndex = 0;
            label16.Text = "Gender:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label18.Location = new Point(405, 207);
            label18.Name = "label18";
            label18.Size = new Size(128, 19);
            label18.TabIndex = 0;
            label18.Text = "Phone number:";
            // 
            // txtUpdatePhoneNumber
            // 
            txtUpdatePhoneNumber.Location = new Point(539, 204);
            txtUpdatePhoneNumber.Name = "txtUpdatePhoneNumber";
            txtUpdatePhoneNumber.Size = new Size(186, 22);
            txtUpdatePhoneNumber.TabIndex = 8;
            txtUpdatePhoneNumber.KeyPress += txtUpdatePhoneNumber_KeyPress;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label19.Location = new Point(80, 251);
            label19.Name = "label19";
            label19.Size = new Size(76, 19);
            label19.TabIndex = 0;
            label19.Text = "Birthday:";
            // 
            // txtUpdateFName
            // 
            txtUpdateFName.Location = new Point(187, 162);
            txtUpdateFName.Name = "txtUpdateFName";
            txtUpdateFName.Size = new Size(176, 22);
            txtUpdateFName.TabIndex = 4;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label22.Location = new Point(405, 162);
            label22.Name = "label22";
            label22.Size = new Size(92, 19);
            label22.TabIndex = 0;
            label22.Text = "Last name:";
            // 
            // txtUpdateLName
            // 
            txtUpdateLName.Location = new Point(539, 161);
            txtUpdateLName.Name = "txtUpdateLName";
            txtUpdateLName.Size = new Size(186, 22);
            txtUpdateLName.TabIndex = 7;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label23.Location = new Point(80, 167);
            label23.Name = "label23";
            label23.Size = new Size(91, 19);
            label23.TabIndex = 0;
            label23.Text = "Frist name:";
            // 
            // ucClient
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(tabControlClient);
            Name = "ucClient";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(915, 502);
            Load += ClientControl_Load;
            tabControlClient.ResumeLayout(false);
            tabPageAddClient.ResumeLayout(false);
            tabPageAddClient.PerformLayout();
            groupBoxAddGender.ResumeLayout(false);
            groupBoxAddGender.PerformLayout();
            tabPageClientList.ResumeLayout(false);
            tabPageClientList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPageUpdateAndDelete.ResumeLayout(false);
            tabPageUpdateAndDelete.PerformLayout();
            groupBoxUpdateGender.ResumeLayout(false);
            groupBoxUpdateGender.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlClient;
        private TabPage tabPageAddClient;
        private Button btAddUser;
        private GroupBox groupBoxAddGender;
        private RadioButton radButAddGenderFamale;
        private RadioButton radButAddGenderMale;
        private ComboBox comboBoxAddNationality;
        private DateTimePicker dateTimeAddBirthDate;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label6;
        private TextBox txtAddPhoneNumber;
        private Label label5;
        private TextBox txtAddFName;
        private Label label2;
        private TextBox txtAddLName;
        private Label label1;
        private TabPage tabPageClientList;
        private Label label12;
        private DataGridView dataGridView1;
        private TabPage tabPageUpdateAndDelete;
        private Button btSearch;
        private Button btDelete;
        private Button btUpdate;
        private TextBox txtSerching;
        private ComboBox comboBoxSearchingType;
        private Label label24;
        private GroupBox groupBoxUpdateGender;
        private RadioButton radButUpdateGenderFamale;
        private RadioButton radButUpdateGenderMale;
        private ComboBox comboBoxUpdateNationality;
        private DateTimePicker dateTimeUpdateBirthDate;
        private Label label13;
        private Label label14;
        private Label label16;
        private Label label18;
        private TextBox txtUpdatePhoneNumber;
        private Label label19;
        private TextBox txtUpdateFName;
        private Label label22;
        private TextBox txtUpdateLName;
        private Label label23;
        private Button btAddClient;
        private Button btUpdateClient;
        private Button btDeleteClient;
    }
}
