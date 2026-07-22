using HMSBusinessLayer;
using HMSDesktop.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSDesktop.User_Control
{
    public partial class ucRoomTimeline : UserControl
    {

        private readonly ReservationService _reservationService = new ReservationService();

        public ucRoomTimeline()
        {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, dataGridViewTimeline, new object[] { true });

            _ApplyGridSettings();
        }




        //Method 
        public async Task LoadTimelineData(DateTime startDate, int numberOfDays = 7)
        {
            DateTime endDate = startDate.AddDays(numberOfDays - 1);

            _SetupColumns(startDate, endDate);

            var timelineData = await _reservationService.GetHotelTimeline(startDate, endDate);

            if (timelineData == null || timelineData.Count == 0)
            {
                MessageBox.Show("No timeline data found", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _PopulateGrid(timelineData);
        }

        private void _ApplyGridSettings()
        {
            dataGridViewTimeline.AllowUserToAddRows = false;
            dataGridViewTimeline.ReadOnly = true;
            dataGridViewTimeline.RowHeadersVisible = false;
            dataGridViewTimeline.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTimeline.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewTimeline.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTimeline.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void _SetupColumns(DateTime start, DateTime end)
        {
            dataGridViewTimeline.Columns.Clear();

            dataGridViewTimeline.Columns.Add("RoomNumber", "Room");
            dataGridViewTimeline.Columns.Add("RoomType", "Type");

            for (DateTime date = start.Date; date <= end.Date; date = date.AddDays(1))
            {
                string colName = date.ToString("yyyy-MM-dd");
                int colIndex = dataGridViewTimeline.Columns.Add(colName, date.ToString("dd/MM\nddd"));
                dataGridViewTimeline.Columns[colIndex].Tag = date;
            }
        }

        private void _PopulateGrid(List<clsReservationsBusiness.RoomTimelineRow> data)
        {
            dataGridViewTimeline.Rows.Clear();

            foreach (var room in data)
            {
                int rowIndex = dataGridViewTimeline.Rows.Add();
                var row = dataGridViewTimeline.Rows[rowIndex];

                row.Cells["RoomNumber"].Value = room.RoomNumber;
                row.Cells["RoomType"].Value = room.RoomType;

                foreach (var day in room.Days)
                {
                    string colName = day.Key.ToString("yyyy-MM-dd");
                    if (dataGridViewTimeline.Columns.Contains(colName))
                    {
                        var cell = row.Cells[colName];
                        _FormatCell(cell, day.Value);
                    }
                }
            }
        }

        private void _FormatCell(DataGridViewCell cell, clsReservationsBusiness.DayStatusInfo dayInfo)
        {
            switch (dayInfo.Status)
            {
                case "Reserved":
                    cell.Style.BackColor = Color.FromArgb(255, 128, 128);
                    cell.Style.ForeColor = Color.White;
                    cell.Value = dayInfo.GuestName;
                    cell.ToolTipText = $"Guest: {dayInfo.GuestName}\nID: {dayInfo.ReservationID}";
                    break;

                case "Maintenance":
                    cell.Style.BackColor = Color.Gray;
                    cell.Style.ForeColor = Color.White;
                    cell.Value = "Maintain";
                    break;

                case "Available":
                default:
                    cell.Style.BackColor = Color.FromArgb(192, 255, 192);
                    cell.Value = "";
                    break;
            }
        }





        // Event Handlers
        private async void ucRoomTimeline_Load(object sender, EventArgs e)
        {
            await LoadTimelineData(DateTime.Today, 7);
        }

        private void dataGridViewTimeline_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewTimeline.Columns[e.ColumnIndex].Tag is DateTime selectedDate)
            {
                string roomNumber = dataGridViewTimeline.Rows[e.RowIndex].Cells["RoomNumber"].Value?.ToString() ?? "";
            }
        }




        //Empty Event Handlers 
        private void dataGridViewTimeline_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}