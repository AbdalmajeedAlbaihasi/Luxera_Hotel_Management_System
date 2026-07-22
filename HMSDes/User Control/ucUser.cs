using HMSDataAccessLayer;
using HMSDataAccessLayer;
using HMSDesktop.ApplicationServices;
using HMSDesktop.Properties;
using HMSDesktop.Services;
using System.Collections.Generic;
using System.Text.Json;


namespace HMSDesktop.User_Contrul
{
    public partial class ucUser : System.Windows.Forms.UserControl
    {
        public ucUser()
        {
            InitializeComponent();
            _nationalitiesApiservice = new NationalitiesApiService();
            _userservice = new UserService();
            AddImage = new OpenFileDialog();
            UpdateImage = new OpenFileDialog();

        }

        // Services and fields
        private readonly UserService _userservice;
        private readonly NationalitiesApiService _nationalitiesApiservice;
        OpenFileDialog AddImage;
        OpenFileDialog UpdateImage;
        public int UserId { get; set; }
        private bool _isLoaded = false;



        // Helper methods
        private async Task LoadUsers()
        {
            try
            {
                var users = await _userservice.GetUsersAsync();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = users;

                dataGridView1.Columns["NationalityID"].Visible = false;
                dataGridView1.Columns["BirthDate"].Visible = false;
                dataGridView1.Columns["CreatedAt"].Visible = false;

                dataGridView1.Columns["UserName"].HeaderText = "Username";
                dataGridView1.Columns["FName"].HeaderText = "First Name";
                dataGridView1.Columns["LName"].HeaderText = "Last Name";
                dataGridView1.Columns["RoleName"].HeaderText = "Role";
                dataGridView1.Columns["NationalityName"].HeaderText = "Nationality";
                dataGridView1.Columns["IsActive"].HeaderText = "Status";
                dataGridView1.Columns["PhoneNumber"].HeaderText = "Phone";

                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.BorderStyle = BorderStyle.FixedSingle;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.ReadOnly = true;
                dataGridView1.RowTemplate.Height = 32;
                dataGridView1.RowHeadersVisible = false;

                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 80, 120);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
                dataGridView1.ColumnHeadersHeight = 38;
                dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dataGridView1.DefaultCellStyle.Padding = new Padding(4, 0, 4, 0);
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 252);

                dataGridView1.GridColor = Color.FromArgb(200, 210, 220);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["IsActive"].Value != null)
                    {
                        bool isActive = Convert.ToBoolean(row.Cells["IsActive"].Value);

                        if (!isActive)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 235);
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(180, 0, 0);
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(235, 250, 240);
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(20, 100, 50);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private async Task LoadNationalities()
        {
            var list = await _nationalitiesApiservice.GetAllNationalities();
            BindNationalities(list);
            comboBoxAddNationality.SelectedValue = 191;
            comboBoxUpdateNationality.SelectedValue = 191;

        }


        private async Task<OneUserListDTO> GetUserFromSearchAsync()
        {
            if (comboBoxSearchingType.SelectedItem == null)
            {
                MessageBox.Show("Select search type");
                return null;
            }

            string searchType = comboBoxSearchingType.SelectedItem.ToString();
            OneUserListDTO user = null;

            if (searchType == "Id")
            {
                if (!int.TryParse(txtSerching.Text, out int id))
                {
                    MessageBox.Show("Enter valid ID");
                    return null;
                }

                user = await _userservice.GetByIdAsync(id);
            }
            else if (searchType == "User name")
            {
                if (string.IsNullOrWhiteSpace(txtSerching.Text))
                {
                    MessageBox.Show("Enter username");
                    return null;
                }

                user = await _userservice.GetByUsernameAsync(txtSerching.Text);
            }

            if (user == null)
            {
                MessageBox.Show("User not found", "Not Found",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return user;
        }


        private void BindNationalities(List<NationalityListDTO> list)
        {
            comboBoxAddNationality.DataSource = list;
            comboBoxAddNationality.DisplayMember = "NationalityName";
            comboBoxAddNationality.ValueMember = "NationalityID";

            comboBoxUpdateNationality.DataSource = list.ToList();
            comboBoxUpdateNationality.DisplayMember = "NationalityName";
            comboBoxUpdateNationality.ValueMember = "NationalityID";
        }


        private bool ValidateAddUser()
        {
            if (string.IsNullOrWhiteSpace(txtAddUserName.Text) ||
                string.IsNullOrWhiteSpace(txtAddPassword.Text) ||
                string.IsNullOrWhiteSpace(txtAddFName.Text) ||
                string.IsNullOrWhiteSpace(txtAddLName.Text) ||
                string.IsNullOrWhiteSpace(txtAddPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(comboBoxAddNationality.Text))
            {
                MessageBox.Show("Please fill all required fields!");
                return false;
            }

            if (!radButAddGenderMale.Checked && !radButAddGenderFamale.Checked)
            {
                MessageBox.Show("Select Gender");
                return false;
            }

            if (!radButAddRoleNameAdmin.Checked && !radButAddRoleNameManager.Checked)
            {
                MessageBox.Show("Select Role");
                return false;
            }

            if (!radButAddIsActiveYes.Checked && !radButAddIsActiveNo.Checked)
            {
                MessageBox.Show("Please select the reservation status (Active or Inactive).");
                return false;
            }

            return true;
        }


        private bool ValidateUpdateUser()
        {
            if (comboBoxUpdateNationality.SelectedValue == null)
            {
                MessageBox.Show("Please select valid nationality");
                return false;
            }

            return true;
        }


        private void FillUser(OneUserListDTO user)
        {
            UserId = user.UserID;

            txtUpdateUserName.Text = user.UserName;
            txtUpdatePassword.Text = user.Password;
            txtUpdateFName.Text = user.FName;
            txtUpdateLName.Text = user.LName;
            txtUpdatePhoneNumber.Text = user.PhoneNumber;

            comboBoxUpdateNationality.SelectedValue = user.NationalityID;

            DateTime birthDate = user.BirthDate;

            if (birthDate > dateTimeUpdateBirthDate.MaxDate)
            {
                birthDate = dateTimeUpdateBirthDate.MaxDate;
            }

            if (birthDate < dateTimeUpdateBirthDate.MinDate)
            {
                birthDate = dateTimeUpdateBirthDate.MinDate;
            }

            dateTimeUpdateBirthDate.Value = birthDate;
            ;

            string gender = user.Gender?.Trim();

            radButUpdateGenderMale.Checked = gender == "Male";
            radButUpdateGenderFamale.Checked = gender == "Female";

            radButUpdateRoleNameAdmin.Checked = user.RoleName == "Admin";
            radButUpdateRoleNameManager.Checked = user.RoleName == "Manager";

            radButUpdateIsActiveYes.Checked = user.IsActive;

            pictureBoxUpdateImage.Image =
                (!string.IsNullOrEmpty(user.ImagePath) && File.Exists(user.ImagePath))
                ? Image.FromFile(user.ImagePath)
                : Resources.user;
            pictureBoxUpdateImage.Tag = user.ImagePath;
        }


        private void ClearAddForm()
        {
            txtAddUserName.Clear();
            txtAddPassword.Clear();
            txtAddFName.Clear();
            txtAddLName.Clear();
            txtAddPhoneNumber.Clear();



            radButAddGenderMale.Checked = false;
            radButAddGenderFamale.Checked = false;
            radButAddRoleNameAdmin.Checked = false;
            radButAddRoleNameManager.Checked = false;
            radButAddIsActiveYes.Checked = false;
            radButAddIsActiveNo.Checked = false;
            dateTimeAddBirthDate.Value = DateTime.Today.AddYears(-18);
            pictureBoxAddImage.Image = Resources.user;
        }


        private void ClearUpdateForm()
        {
            txtUpdateUserName.Clear();
            txtUpdatePassword.Clear();
            txtUpdateFName.Clear();
            txtUpdateLName.Clear();
            txtUpdatePhoneNumber.Clear();



            radButUpdateGenderMale.Checked = false;
            radButUpdateGenderFamale.Checked = false;
            radButUpdateRoleNameAdmin.Checked = false;
            radButUpdateRoleNameManager.Checked = false;
            radButUpdateIsActiveYes.Checked = false;
            radButUpdateIsActiveNo.Checked = false;
            dateTimeUpdateBirthDate.Value = DateTime.Today.AddYears(-18);
            pictureBoxUpdateImage.Image = Resources.user;
        }


        private AddNewUserDTO MapAddUser()
        {
            return new AddNewUserDTO(
                txtAddUserName.Text.Trim(),
                txtAddPassword.Text.Trim(),
                radButAddIsActiveYes.Checked,
                txtAddFName.Text.Trim(),
                txtAddLName.Text.Trim(),
                dateTimeAddBirthDate.Value,
                txtAddPhoneNumber.Text.Trim(),
                Convert.ToInt32(comboBoxAddNationality.SelectedValue),
                radButAddGenderMale.Checked ? "Male" : "Female",
                radButAddRoleNameAdmin.Checked ? "Admin" : "Manager",
                string.IsNullOrWhiteSpace(AddImage.FileName) ? "" : AddImage.FileName  

            );
        }


        private UpdateUserDTO MapUpdateUser(int userId)
        {
            return new UpdateUserDTO(
                userId,
                txtUpdateUserName.Text.Trim(),
                txtUpdatePassword.Text.Trim(),
                radButUpdateIsActiveYes.Checked,
                txtUpdateFName.Text.Trim(),
                txtUpdateLName.Text.Trim(),
                dateTimeUpdateBirthDate.Value,
                txtUpdatePhoneNumber.Text.Trim(),
                Convert.ToInt32(comboBoxUpdateNationality.SelectedValue),
                radButUpdateGenderMale.Checked ? "Male" : "Female",
                radButUpdateRoleNameAdmin.Checked ? "Admin" : "Manager",
                string.IsNullOrWhiteSpace(UpdateImage.FileName) ? (pictureBoxUpdateImage.Tag?.ToString() ?? "") : UpdateImage.FileName
            );
        }






        // Event handlers
        private async void UserControl_Load(object sender, EventArgs e)
        {
            if (_isLoaded) return;
            _isLoaded = true;

            await LoadNationalities();
            await LoadUsers();
            comboBoxSearchingType.SelectedIndex = 0;
            dateTimeAddBirthDate.MaxDate = DateTime.Today.AddYears(-18);
            dateTimeUpdateBirthDate.MaxDate = DateTime.Today.AddYears(-18);
            dateTimeAddBirthDate.Format = DateTimePickerFormat.Custom;
            dateTimeAddBirthDate.CustomFormat = "dd MMM yyyy";
            dateTimeUpdateBirthDate.Format = DateTimePickerFormat.Custom;
            dateTimeUpdateBirthDate.CustomFormat = "dd MMM yyyy";
        }


        private async void btAddUser_Click(object sender, EventArgs e)
        {
            if (!ValidateAddUser())
            {
                return;
            }

            bool Isactive = radButAddIsActiveYes.Checked;
            string Gender = radButAddGenderMale.Checked ? "Male" : "Female";
            string RoleName = radButAddRoleNameAdmin.Checked ? "Admin" : "Manager";
            DateTime birthDate = dateTimeAddBirthDate.Value;
            string ImagePath = AddImage.FileName;

            var dto = MapAddUser();


            DialogResult result = MessageBox.Show(
                "Are you sure you want to add this user?",
                "Adding New User",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                try
                {
                    var AddNewUser = await _userservice.AddUserAsync(dto);

                    if (AddNewUser == true)
                    {
                        MessageBox.Show("User added successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearAddForm();

                    }
                    else
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private async void btSearch_Click(object sender, EventArgs e)
        {
            var user = await GetUserFromSearchAsync();

            if (user == null)
                return;

            FillUser(user);
        }


        private async void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateUpdateUser())
                    return;

                var dto = MapUpdateUser(this.UserId);
                if (dto == null)
                    return;

                var result = await _userservice.UpdateUserAsync(dto.UserID, dto);

                if (result)
                {
                    MessageBox.Show(
                        "User updated successfully",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    ClearUpdateForm();
                }
                else
                {
                    string error = _userservice.LastError;

                    if (string.IsNullOrWhiteSpace(error))
                    {
                        MessageBox.Show(
                            "Update failed",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    string lowerError = error.ToLower();

                    if (lowerError.Contains("username already exists"))
                    {
                        MessageBox.Show(
                            "This username is already taken. Please choose another username.",
                            "Duplicate Username",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(
                            error,
                            "Update Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private async void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to deactivate this user ID = {UserId} ?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;

                bool isDeleted = await _userservice.DeleteUserAsync(UserId);

                if (isDeleted)
                {
                    MessageBox.Show(
                        "User deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    ClearUpdateForm();
                }
                else
                {
                    string error = _userservice.LastError;

                    if (!string.IsNullOrWhiteSpace(error) &&
                        error.ToLower().Contains("linked"))
                    {
                        MessageBox.Show(
                            "Cannot delete user because they are linked with reservations.",
                            "Delete Blocked",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            string.IsNullOrWhiteSpace(error) ? "Delete failed." : error,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private async void tabControlUser_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPageUserList)
            {
                await LoadUsers();
            }
        }


        private void labelAddImage_Click(object sender, EventArgs e)
        {
            AddImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (AddImage.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAddImage.Image = Image.FromFile(AddImage.FileName);
            }
        }


        private void labelUpdateImage_Click(object sender, EventArgs e)
        {
            UpdateImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (UpdateImage.ShowDialog() == DialogResult.OK)
            {
                pictureBoxUpdateImage.Image = Image.FromFile(UpdateImage.FileName);
            }
        }


        private void txtAddPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


        private void txtSerching_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxSearchingType.SelectedItem != null && comboBoxSearchingType.SelectedItem.ToString() == "Id")
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }







        // Empty event handlers
        private void radButUpdateIsActiveNo_CheckedChanged(object sender, EventArgs e)
        {
        }


        private void tabPageAddUser_Click(object sender, EventArgs e)
        {

        }


        private void tabPageUserList_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
