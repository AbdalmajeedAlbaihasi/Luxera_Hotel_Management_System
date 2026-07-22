using HMSDataAccessLayer;
using HMSDesktop.Services;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HMSDesktop.User_Control
{
    public partial class ucRoom : UserControl
    {
        private readonly RoomService _roomService;
        private int RoomId;
        public ucRoom()
        {
            InitializeComponent();
            _roomService = new RoomService();
            this.Load += RoomControl_Load;
        }



        //Methods
        private async Task LoadRoomType()
        {
            try
            {
                var list = await _roomService.GetRoomTypes();

                if (list == null || list.Count == 0)
                {
                    MessageBox.Show("No Room Types Found");
                    return;
                }

                BindRoomType(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task LoadRooms()
        {
            try
            {
                var rooms = await _roomService.GetRooms();

                dataGridViewRoomList.DataSource = null;
                dataGridViewRoomList.DataSource = rooms;

                dataGridViewRoomList.Columns["RoomID"].HeaderText = "ID";
                dataGridViewRoomList.Columns["RoomNumber"].HeaderText = "Room Number";
                dataGridViewRoomList.Columns["RoomTypeID"].Visible = false;
                dataGridViewRoomList.Columns["RoomTypeName"].HeaderText = "Room Type";
                dataGridViewRoomList.Columns["Price"].HeaderText = "Price";
                dataGridViewRoomList.Columns["Capacity"].HeaderText = "Capacity";
                dataGridViewRoomList.Columns["Status"].HeaderText = "Status";

                dataGridViewRoomList.EnableHeadersVisualStyles = false;
                dataGridViewRoomList.BorderStyle = BorderStyle.FixedSingle;
                dataGridViewRoomList.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                dataGridViewRoomList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewRoomList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewRoomList.ReadOnly = true;
                dataGridViewRoomList.RowTemplate.Height = 32;
                dataGridViewRoomList.RowHeadersVisible = false;

                dataGridViewRoomList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 80, 120);
                dataGridViewRoomList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewRoomList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dataGridViewRoomList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewRoomList.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
                dataGridViewRoomList.ColumnHeadersHeight = 38;
                dataGridViewRoomList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                dataGridViewRoomList.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dataGridViewRoomList.DefaultCellStyle.Padding = new Padding(4, 0, 4, 0);
                dataGridViewRoomList.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
                dataGridViewRoomList.DefaultCellStyle.SelectionForeColor = Color.White;

                dataGridViewRoomList.RowsDefaultCellStyle.BackColor = Color.White;
                dataGridViewRoomList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 252);

                dataGridViewRoomList.GridColor = Color.FromArgb(200, 210, 220);

                foreach (DataGridViewRow row in dataGridViewRoomList.Rows)
                {
                    if (row.Cells["Status"].Value != null)
                    {
                        string status = row.Cells["Status"].Value.ToString().ToLower();

                        if (status.Contains("available"))
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(235, 250, 240);
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(20, 100, 50);
                        }
                        else if (status.Contains("occupied"))
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 235);
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(180, 0, 0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void RoomControl_Load(object sender, EventArgs e)
        {

            await LoadRoomType();
            await LoadRooms();
            comboBoxSearchingType.SelectedIndex = 0;
        }

        private void ClearAddForm()
        {
            txtAddRoomNumber.Clear();
            txtAddPrice.Clear();
            txtAddCapacity.Clear();
            comboBoxAddRoomType.SelectedIndex = -1;
            radButAddStatudAvailable.Checked = true;
        }

        private void ClearUpdateForm()
        {
            txtUpdateRoomNumber.Clear();
            txtUpdatePrice.Clear();
            txtUpdateCapacity.Clear();
            comboBoxUpdateRoomType.SelectedIndex = -1;
            radButUpdateStatudAvailable.Checked = true;
        }

        private void BindRoomType(List<RoomTypeListDTO> list)
        {
            comboBoxAddRoomType.DataSource = null;
            comboBoxUpdateRoomType.DataSource = null;

            comboBoxAddRoomType.DisplayMember = "TypeName";
            comboBoxAddRoomType.ValueMember = "RoomTypeID";
            comboBoxAddRoomType.DataSource = list;

            comboBoxUpdateRoomType.DisplayMember = "TypeName";
            comboBoxUpdateRoomType.ValueMember = "RoomTypeID";
            comboBoxUpdateRoomType.DataSource = list.ToList();

            comboBoxAddRoomType.SelectedIndex = -1;
            comboBoxUpdateRoomType.SelectedIndex = -1;
        }

        private void FillRoom(RoomListDTO room)
        {
            if (room == null)
                return;

            RoomId = room.RoomID;

            txtUpdateRoomNumber.Text = room.RoomNumber;

            txtUpdatePrice.Text = room.Price.ToString("G");


            try
            {
                if (comboBoxUpdateRoomType.DataSource is List<RoomTypeListDTO> types)
                {
                    var match = types.FirstOrDefault(t =>
                        string.Equals((t?.TypeName ?? string.Empty).Trim(), (room.RoomTypeName ?? string.Empty).Trim(), StringComparison.OrdinalIgnoreCase));
                    if (match != null)
                    {
                        comboBoxUpdateRoomType.SelectedValue = match.RoomTypeID;
                    }
                    else
                    {

                        int index = comboBoxUpdateRoomType.FindStringExact(room.RoomTypeName?.Trim() ?? string.Empty);
                        if (index >= 0) comboBoxUpdateRoomType.SelectedIndex = index;
                        else comboBoxUpdateRoomType.SelectedIndex = -1;
                    }
                }
                else
                {

                    int index = comboBoxUpdateRoomType.FindStringExact(room.RoomTypeName?.Trim() ?? string.Empty);
                    if (index >= 0) comboBoxUpdateRoomType.SelectedIndex = index;
                    else comboBoxUpdateRoomType.SelectedIndex = -1;
                }
            }
            catch
            {
                comboBoxUpdateRoomType.SelectedIndex = -1;
            }


            txtUpdateCapacity.Text = room.Capacity.ToString();


            if (string.Equals(room.Status, "Available", StringComparison.OrdinalIgnoreCase))
                radButUpdateStatudAvailable.Checked = true;
            else if (string.Equals(room.Status, "Occupied", StringComparison.OrdinalIgnoreCase))
                radButUpdateStatusOccupied.Checked = true;
            else
                radButUpdateStatusMaintenance.Checked = true;
        }

        private bool ValidateAddRoom()
        {
            if (string.IsNullOrWhiteSpace(txtAddRoomNumber.Text) ||
                comboBoxAddRoomType.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtAddCapacity.Text) ||
                string.IsNullOrWhiteSpace(txtAddPrice.Text))
            {
                MessageBox.Show("Please fill all required fields!");
                return false;
            }

            if (!decimal.TryParse(txtAddPrice.Text, out _))
            {
                MessageBox.Show("Enter valid price");
                return false;
            }

            return true;
        }

        private bool ValidateUpdateRoom()
        {
            if (RoomId <= 0)
            {
                MessageBox.Show("Select valid room first");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUpdateRoomNumber.Text) ||
                comboBoxUpdateRoomType.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtUpdateCapacity.Text) ||
                string.IsNullOrWhiteSpace(txtUpdatePrice.Text))
            {
                MessageBox.Show("Please fill all required fields for update!");
                return false;
            }

            if (!decimal.TryParse(txtUpdatePrice.Text, out _))
            {
                MessageBox.Show("Enter valid price");
                return false;
            }

            return true;
        }

        private AddNewRoomDTO MapAddRoom()
        {
            int roomTypeId = comboBoxAddRoomType.SelectedValue != null ? Convert.ToInt32(comboBoxAddRoomType.SelectedValue) : 0;
            int capacity = !string.IsNullOrWhiteSpace(txtAddCapacity.Text) ? Convert.ToInt32(txtAddCapacity.Text) : 1;
            decimal price = 0;
            decimal.TryParse(txtAddPrice.Text, out price);

            return new AddNewRoomDTO(
                txtAddRoomNumber.Text.Trim(),
                roomTypeId,
                radButAddStatudAvailable.Checked ? "Available" :
                    radButAddStatusOccupied.Checked ? "Occupied" : "Maintenance",
                capacity,
                price
            );
        }

        private UpdateRoomDTO MapUpdateRoom(int id)
        {
            int roomTypeId = comboBoxUpdateRoomType.SelectedValue != null ? Convert.ToInt32(comboBoxUpdateRoomType.SelectedValue) : 0;
            int capacity = !string.IsNullOrWhiteSpace(txtUpdateCapacity.Text) ? Convert.ToInt32(txtUpdateCapacity.Text) : 1;
            decimal price = 0;
            decimal.TryParse(txtUpdatePrice.Text, out price);

            return new UpdateRoomDTO(
                id,
                txtUpdateRoomNumber.Text.Trim(),
                roomTypeId,
                radButUpdateStatudAvailable.Checked ? "Available" :
                    radButUpdateStatusOccupied.Checked ? "Occupied" : "Maintenance",
                capacity,
                price
            );
        }








        // Event Handlers
        private async void btAddRoom_Click(object sender, EventArgs e)
        {
            if (!ValidateAddRoom())
            {
                return;
            }



            var dtoAdd = MapAddRoom();


            DialogResult result = MessageBox.Show(
                "Are you sure you want to add this room?",
                "Adding New Room",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                try
                {
                    var AddNewRoom = await _roomService.AddRoom(dtoAdd);


                    if (AddNewRoom == true)
                    {
                        MessageBox.Show("Room added successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearAddForm();
                        await LoadRooms();

                    }
                    else
                    {
                        MessageBox.Show("Something went wrong while adding room!", "Error",
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


        private async void btUpdateRoom_Click(object sender, EventArgs e)
        {
            if (!ValidateUpdateRoom())
            {
                return;
            }



            var dtoUpdate = MapUpdateRoom(RoomId);


            DialogResult result = MessageBox.Show(
                "Are you sure you want to update this room?",
                "Updating Room",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                try
                {
                    var UpdateRoom = await _roomService.UpdateRoom(dtoUpdate);

                    if (UpdateRoom == true)
                    {
                        MessageBox.Show("Room updated successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearUpdateForm();
                        await LoadRooms();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong while updating room!", "Error",
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


        private async void btDeleteRoom_Click(object sender, EventArgs e)
        {
            if (RoomId <= 0)
            {
                MessageBox.Show("Select room first");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Delete Room ID = {RoomId} ?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            var isDeleted = await _roomService.DeleteRoom(RoomId);

            if (isDeleted)
            {
                MessageBox.Show("Deleted successfully");
                await LoadRooms();
                ClearUpdateForm();
            }
            else
            {
                MessageBox.Show("Delete failed");
            }
        }


        private async void btSearchRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtSerching.Text, out int id))
                {
                    MessageBox.Show("Enter valid Room ID");
                    return;
                }

                var room = await _roomService.GetById(id);

                if (room == null)
                {
                    MessageBox.Show("Room not found");
                    return;
                }

                FillRoom(room);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }


        private void txtAddPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
                e.Handled = true;
        }


        private void txtUpdatePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
                e.Handled = true;
        }


        private void txtSerching_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
                e.Handled = true;
        }







        //Empty event handlers
        private void tabPageClientList_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAddClient_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxUpdateCapacity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageUpdateAndDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
