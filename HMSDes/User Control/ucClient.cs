using HMSDataAccessLayer;
using HMSDesktop.ApplicationServices;
using HMSDesktop.Properties;
using HMSDesktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSDesktop.User_Control
{
    public partial class ucClient : UserControl
    {
        public ucClient()
        {
            InitializeComponent();
            _nationalitiesApiservice = new NationalitiesApiService();
            _clientService = new ClientService();
            _userControl = new UserControl();

            this.Load += ClientControl_Load;
        }

        //Members
        private readonly ClientService _clientService;
        private readonly NationalitiesApiService _nationalitiesApiservice;
        private readonly UserControl _userControl;
        public int UserID = UserId.userID;
        public int ClientId;




        //Methods
        private async Task LoadClients()
        {
            try
            {
                var clients = await _clientService.GetClients();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = clients;

                if (dataGridView1.Columns["NationalityID"] != null)
                {
                    dataGridView1.Columns["NationalityID"].Visible = false;
                }


                if (dataGridView1.Columns["CreatedByUserID"] != null)
                {
                    dataGridView1.Columns["CreatedByUserID"].Visible = false;
                }

                //dataGridView1.Columns["NationalityID"].Visible = false;
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

        private void BindNationalities(List<NationalityListDTO> list)
        {
            comboBoxAddNationality.DataSource = list;
            comboBoxAddNationality.DisplayMember = "NationalityName";
            comboBoxAddNationality.ValueMember = "NationalityID";

            comboBoxUpdateNationality.DataSource = list.ToList();
            comboBoxUpdateNationality.DisplayMember = "NationalityName";
            comboBoxUpdateNationality.ValueMember = "NationalityID";
        }

        private bool ValidateAddClient()
        {
            if (string.IsNullOrWhiteSpace(txtAddFName.Text) ||
                string.IsNullOrWhiteSpace(txtAddLName.Text) ||
                string.IsNullOrWhiteSpace(comboBoxAddNationality.Text) ||
                string.IsNullOrWhiteSpace(txtAddPhoneNumber.Text))
            {
                MessageBox.Show("Please fill all required fields!");
                return false;
            }

            if (!radButAddGenderMale.Checked && !radButAddGenderFamale.Checked)
            {
                MessageBox.Show("Select Gender");
                return false;
            }


            return true;
        }

        private bool ValidateUpdateClient()
        {
            if (comboBoxUpdateNationality.SelectedValue == null)
            {
                MessageBox.Show("Please select valid nationality");
                return false;
            }

            return true;
        }

        private async Task<ClientListDTO> GetClientFromSearchAsync()
        {
            if (comboBoxSearchingType.SelectedItem == null)
            {
                MessageBox.Show("Select search type");
                return null;
            }

            ClientListDTO Client = null;




            string searchType = comboBoxSearchingType.SelectedItem.ToString();



            if (searchType == "Id")
            {
                if (!int.TryParse(txtSerching.Text, out int id))
                {
                    MessageBox.Show("Enter valid ID");
                    return null;
                }
                Client = await _clientService.GetById(id);
            }


            if (Client == null)
            {
                MessageBox.Show("Client not found", "Not Found",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return Client;
        }

        private void FillClient(ClientListDTO Client)
        {
            ClientId = Client.ClientID;

            txtUpdateFName.Text = Client.FirstName;
            txtUpdateLName.Text = Client.LastName;
            comboBoxUpdateNationality.SelectedValue = Client.NationalityID;

            txtUpdatePhoneNumber.Text = Client.PhoneNumber;

            dateTimeUpdateBirthDate.Value = Client.BirthDate;

            radButUpdateGenderMale.Checked = Client.Gender == "Male";
            radButUpdateGenderFamale.Checked = Client.Gender == "Female";

        }

        private AddNewClientDTO MapAddClient()
        {
            return new AddNewClientDTO(
                UserID,
                txtAddFName.Text,
                txtAddLName.Text,
                dateTimeAddBirthDate.Value,
                Convert.ToInt32(comboBoxAddNationality.SelectedValue),
                txtAddPhoneNumber.Text,
                radButAddGenderMale.Checked ? "Male" : "Female"
            );
        }

        private UpdateClientDTO MapUpdateClient(int ClientId)
        {
            return new UpdateClientDTO(
                ClientId,
                UserID,
                txtUpdateFName.Text,
                txtUpdateLName.Text,
                dateTimeUpdateBirthDate.Value,
                Convert.ToInt32(comboBoxUpdateNationality.SelectedValue),
                txtUpdatePhoneNumber.Text,
                radButUpdateGenderMale.Checked ? "Male" : "Female"
            );
        }

        private void ClearAddForm()
        {
            ;
            txtAddFName.Clear();
            txtAddLName.Clear();
            txtAddPhoneNumber.Clear();

            comboBoxAddNationality.SelectedIndex = -1;

            radButAddGenderMale.Checked = true;
            dateTimeAddBirthDate.Value = DateTime.Now;
        }

        private void ClearUpdateAndDeleteForm()
        {
            ;
            txtUpdateFName.Clear();
            txtUpdateLName.Clear();
            txtUpdatePhoneNumber.Clear();

            comboBoxUpdateNationality.SelectedIndex = -1;

            radButUpdateGenderMale.Checked = true;
            dateTimeUpdateBirthDate.Value = DateTime.Now;
        }






        //Events
        private async void ClientControl_Load(object sender, EventArgs e)
        {
            await LoadNationalities();
            await LoadClients();
            comboBoxSearchingType.SelectedIndex = 0;
        }


        private async void btAddClient_Click(object sender, EventArgs e)
        {
            if (!ValidateAddClient())
            {
                return;
            }

            string Gender = radButAddGenderMale.Checked ? "Male" : "Female";
            DateTime birthDate = dateTimeAddBirthDate.Value;

            var dto = MapAddClient();


            DialogResult result = MessageBox.Show(
                "Are you sure you want to add this client?",
                "Adding New Client",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                try
                {
                    var AddNewPerson = await _clientService.AddClient(dto);

                    if (AddNewPerson == true)
                    {
                        MessageBox.Show("Client added successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearAddForm();

                    }
                    else
                    {
                        MessageBox.Show("Something went wrong while adding client!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var client = await GetClientFromSearchAsync();

            if (client == null)
                return;

            FillClient(client);
        }


        private async void btUpdateClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateUpdateClient())
                    return;

                var dto = MapUpdateClient(this.ClientId);

                if (dto == null)
                    return;

                var result = await _clientService.UpdateClient(dto.ClientID, dto);

                if (result)
                {
                    MessageBox.Show("Client updated successfully");
                    ClearUpdateAndDeleteForm();
                }
                else
                {
                    string err = !string.IsNullOrWhiteSpace(_clientService.LastError)
                        ? _clientService.LastError
                        : "Update failed";

                    MessageBox.Show(err, "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private async void btDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to deactivate this client ID = {ClientId} ?", "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);


                if (result == DialogResult.No)
                    return;


                bool isDeleted = await _clientService.DeleteClient(ClientId);

                if (isDeleted)
                {
                    MessageBox.Show(
                        "Client deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    ClearUpdateAndDeleteForm();
                }
                else
                {
                    MessageBox.Show(
                        "Delete failed.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
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


        private async void tabControlClient_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPageClientList)
            {
                await LoadClients();
            }
        }


        private void txtAddPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


        private void txtUpdatePhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


        private void txtSerching_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }






        // Empty event handlers 
        private void tabPageAddClient_Click(object sender, EventArgs e)
        {

        }

        private void tabPageUpdateAndDelete_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
