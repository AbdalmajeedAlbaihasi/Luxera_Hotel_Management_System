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

namespace HMSDesktop.User_Control
{
    public partial class ucReservation : UserControl
    {
        //members
        private readonly ReservationService _reservationService;
        private readonly ReservationApiService _reservationApiService;
        private readonly ClientService _clientService;
        private int RoomId;
        private int reservationtId;



        public ucReservation()
        {
            InitializeComponent();
            _reservationService = new ReservationService();
            _reservationApiService = new ReservationApiService();
            _clientService = new ClientService();
            this.Load += ReservationControl_Load;
        }


        //Methods
        public async Task RefreshClients()
        {
            await _FillClientsComboBox();
        }

        private async Task LoadReservations()
        {
            try
            {
                await _FillClientsComboBox();
                var reservations = await _reservationService.GetReservations();

                dataGridViewRoomList.AutoGenerateColumns = true;
                dataGridViewRoomList.DataSource = null;
                dataGridViewRoomList.DataSource = reservations;

                if (dataGridViewRoomList.Columns.Count == 0) return;


                if (dataGridViewRoomList.Columns["RoomID"] != null)
                    dataGridViewRoomList.Columns["RoomID"].Visible = false;
                if (dataGridViewRoomList.Columns["ClientId"] != null)
                    dataGridViewRoomList.Columns["ClientId"].Visible = false;
                if (dataGridViewRoomList.Columns["UserID"] != null)
                    dataGridViewRoomList.Columns["UserID"].Visible = false;


                if (dataGridViewRoomList.Columns["ReservationID"] != null)
                    dataGridViewRoomList.Columns["ReservationID"].HeaderText = "ID";
                if (dataGridViewRoomList.Columns["RoomNumber"] != null)
                    dataGridViewRoomList.Columns["RoomNumber"].HeaderText = "Room";
                if (dataGridViewRoomList.Columns["ClientName"] != null)
                    dataGridViewRoomList.Columns["ClientName"].HeaderText = "Client";
                if (dataGridViewRoomList.Columns["CreatedByUser"] != null)
                    dataGridViewRoomList.Columns["CreatedByUser"].HeaderText = "Created By";
                if (dataGridViewRoomList.Columns["CheckInDate"] != null)
                    dataGridViewRoomList.Columns["CheckInDate"].HeaderText = "Check In";
                if (dataGridViewRoomList.Columns["CheckOutDate"] != null)
                    dataGridViewRoomList.Columns["CheckOutDate"].HeaderText = "Check Out";
                if (dataGridViewRoomList.Columns["Status"] != null)
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
                    if (row.Cells["Status"]?.Value == null) continue;

                    string status = row.Cells["Status"].Value.ToString().ToLower();

                    if (status.Contains("confirmed"))
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(235, 250, 240);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(20, 100, 50);
                    }
                    else if (status.Contains("cancelled"))
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 235);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(180, 0, 0);
                    }
                    else if (status.Contains("pending"))
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 230);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(120, 90, 0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reservations: " + ex.Message);
            }
        }

        private async Task _FillClientsComboBox()
        {
            var clients = await _clientService.GetClientNames();

            if (clients != null && clients.Count > 0)
            {
                comboBoxAddClientId.DataSource = null;

                comboBoxAddClientId.DisplayMember = "ClientID";
                comboBoxAddClientId.ValueMember = "ClientID";
                comboBoxAddClientId.DataSource = clients;

                comboBoxAddClientId.SelectedIndex = -1;

                txtClientAddName.Clear();



                comboBoxUpdateClientId.DataSource = null;

                comboBoxUpdateClientId.DisplayMember = "ClientID";
                comboBoxUpdateClientId.ValueMember = "ClientID";
                comboBoxUpdateClientId.DataSource = clients.ToList();

                comboBoxUpdateClientId.SelectedIndex = -1;

                txtClientUpdateName.Clear();
            }
        }

        private async Task LoadRoomNumber()
        {
            try
            {
                var list = await _reservationService.GetRoomNumbers();

                if (list == null || list.Count == 0)
                {
                    MessageBox.Show("No Room Number Found");
                    return;
                }

                BindRoomNumber(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindRoomNumber(List<RoomNumberDTO> list)
        {
            comboBoxAddRoomNumber.DataSource = null;
            comboBoxUpdateRoomNumber.DataSource = null;

            comboBoxAddRoomNumber.DisplayMember = "RoomNumber";
            comboBoxAddRoomNumber.ValueMember = "RoomID";
            comboBoxAddRoomNumber.DataSource = list;

            comboBoxUpdateRoomNumber.DisplayMember = "RoomNumber";
            comboBoxUpdateRoomNumber.ValueMember = "RoomID";
            comboBoxUpdateRoomNumber.DataSource = list.ToList();

            comboBoxAddRoomNumber.SelectedIndex = -1;
            comboBoxUpdateRoomNumber.SelectedIndex = -1;
        }

        private void FillReservation(ReservationListDTO reservation)
        {
            reservationtId = reservation.ReservationID;

            comboBoxUpdateClientId.SelectedValue = reservation.ClientId;
            comboBoxUpdateRoomNumber.SelectedValue = reservation.RoomID;
            if (comboBoxUpdateClientId.SelectedItem is ClientNameAndIDDTO client)
            {
                txtClientUpdateName.Text = client.FirstName + " " + client.LastName;
            }

            dateTimePickerUpdateCheckIn.Value = reservation.CheckInDate < dateTimePickerUpdateCheckIn.MinDate
                ? DateTime.Today
                : reservation.CheckInDate;

            dateTimePickerUpdateCheckOut.Value = reservation.CheckOutDate < dateTimePickerUpdateCheckOut.MinDate
                ? DateTime.Today.AddDays(1)
                : reservation.CheckOutDate;

            radButUpdateStatusConfirmed.Checked = reservation.Status == "Confirmed";
            radButUpdateStatusPending.Checked = reservation.Status == "Pending";
        }

        private void ClearAddForm()
        {
            comboBoxAddClientId.SelectedIndex = -1;
            comboBoxAddRoomNumber.SelectedIndex = -1;
            dateTimePickerAddCheckIn.Value = DateTime.Now;
            dateTimePickerAddCheckOut.Value = DateTime.Now;
            radButAddStatudConfirmed.Checked = true;
        }

        private void ClearUpdateAndDeleteForm()
        {
            comboBoxUpdateClientId.SelectedIndex = -1;
            comboBoxUpdateRoomNumber.SelectedIndex = -1;
            dateTimePickerUpdateCheckIn.Value = DateTime.Now;
            dateTimePickerUpdateCheckOut.Value = DateTime.Now;
            radButUpdateStatusConfirmed.Checked = false;
            radButUpdateStatusPending.Checked = false;
        }

        private bool ValidateAddReservation()
        {
            if (comboBoxAddClientId.SelectedValue == null || comboBoxAddRoomNumber.SelectedValue == null ||
                (!radButAddStatudConfirmed.Checked && !radButAddStatusPending.Checked))
            {
                MessageBox.Show("Please fill all required fields!");
                return false;
            }


            if (dateTimePickerAddCheckOut.Value <= dateTimePickerAddCheckIn.Value)
            {
                MessageBox.Show("Check-Out must be after Check-In!");
                return false;
            }

            if (comboBoxAddClientId.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a client!");
                return false;
            }

            if (comboBoxAddRoomNumber.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a room!");
                return false;
            }
            return true;
        }

        private bool ValidateUpdateReservation()
        {
            if (comboBoxUpdateRoomNumber.SelectedValue == null)
            {
                MessageBox.Show("Please select valid room number");
                return false;
            }

            if (comboBoxUpdateClientId.SelectedValue == null)
            {
                MessageBox.Show("Please select valid client");
                return false;
            }
            return true;
        }

        private AddNewReservationDTO MapAddReservation()
        {
            if (comboBoxAddRoomNumber.SelectedValue == null)
                throw new Exception("Room not selected");

            if (!(comboBoxAddRoomNumber.SelectedValue is int roomId))
                throw new Exception("Invalid RoomID (binding issue)");


            return new AddNewReservationDTO(
                roomId,
                clientId: Convert.ToInt32(comboBoxAddClientId.SelectedValue),
                createdByUserID: UserId.userID,
                dateTimePickerAddCheckIn.Value,
                dateTimePickerAddCheckOut.Value,
                radButAddStatudConfirmed.Checked ? "Confirmed" : "Pending"
            );
        }

        private UpdateReservationDTO MapUpdateReservation(int reservationId)
        {
            return new UpdateReservationDTO(
                reservationId,
                Convert.ToInt32(comboBoxUpdateRoomNumber.SelectedValue),
                Convert.ToInt32(comboBoxUpdateClientId.SelectedValue),
                UserId.userID,
                dateTimePickerUpdateCheckIn.Value,
                dateTimePickerUpdateCheckOut.Value,
                radButUpdateStatusConfirmed.Checked ? "Confirmed" : "Pending"

            );
        }





        // Event Handlers
        private async void ReservationControl_Load(object sender, EventArgs e)
        {
            await LoadRoomNumber();
            await LoadReservations();
            comboBoxSearchingType.SelectedIndex = 0;
        }

        private async void btAddReservation_Click(object sender, EventArgs e)
        {
            if (!ValidateAddReservation())
            {
                return;
            }



            var dto = MapAddReservation();


            DialogResult result = MessageBox.Show(
                "Are you sure you want to add this reservation?",
                "Adding New Reservation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                try
                {
                    var AddNewReservation = await _reservationService.AddReservation(dto);

                    if (AddNewReservation == true)
                    {
                        MessageBox.Show("Reservation added successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearAddForm();
                        await LoadReservations();
                    }
                    else
                    {
                        MessageBox.Show(
                        "This room is already reserved for the selected dates!",
                        "Reservation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btSearchReservation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSerching.Text))
            {
                MessageBox.Show("Please enter Reservation ID");
                return;
            }

            if (!int.TryParse(txtSerching.Text, out int reservationId))
            {
                MessageBox.Show("Enter valid ID");
                return;
            }

            var reservation = await _reservationService.GetById(reservationId);

            if (reservation == null)
            {
                MessageBox.Show("Reservation not found");
                return;
            }

            FillReservation(reservation);
        }

        private async void btUpdateReservation_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateUpdateReservation())
                    return;

                var dto = MapUpdateReservation(this.reservationtId);

                if (dto == null)
                    return;

                var result = await _reservationService.UpdateReservation(dto.ReservationID, dto);

                if (result)
                {
                    MessageBox.Show("Reservation updated successfully");
                    ClearUpdateAndDeleteForm();
                    await LoadReservations();
                }
                else
                {

                    string err = !string.IsNullOrWhiteSpace(_reservationApiService.LastError)
                        ? _reservationApiService.LastError
                        : "Update failed";

                    MessageBox.Show(err, "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void btDeleteReservation_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to deactivate this reservation ID = {reservationtId} ?", "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);


                if (result == DialogResult.No)
                    return;


                bool isDeleted = await _reservationApiService.DeleteReservationAsync(reservationtId);

                if (isDeleted)
                {
                    MessageBox.Show(
                        "Reservation deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    ClearUpdateAndDeleteForm();
                    await LoadReservations();

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

        private async void tabControlReservation_Selecting(object sender, TabControlCancelEventArgs e)
        {
            await _FillClientsComboBox();
        }

        private void comboBoxClientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAddClientId.SelectedIndex == -1)
            {
                txtClientAddName.Clear();
                return;
            }

            if (comboBoxAddClientId.SelectedItem is ClientNameAndIDDTO client)
            {
                txtClientAddName.Text = client.FirstName + " " + client.LastName;
            }
        }

        private void comboBoxUpdateClientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUpdateClientId.SelectedIndex == -1)
            {
                txtClientUpdateName.Clear();
                return;
            }

            if (comboBoxUpdateClientId.SelectedItem is ClientNameAndIDDTO client)
            {
                txtClientUpdateName.Text = client.FirstName + " " + client.LastName;
            }
        }




        // Empty Event Handlers
        private void radButUpdateStatusPending_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewRoomList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPageAddClient_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAddRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageUpdateAndDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
