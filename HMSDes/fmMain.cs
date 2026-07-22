using HMSDesktop;
using HMSDesktop.Services;
using Microsoft.VisualBasic.ApplicationServices;
using System.Globalization;

namespace HMSDes
{
    public partial class fmMain : Form
    {
        //Members
        private string _roleName;
        public string Name { get; set; }



        //Constructor
        public fmMain(string roleName)
        {
            InitializeComponent();
            _roleName = roleName;
        }





        //Methods
        private void SetActiveButton(Button btn)
        {
            panel9.Top = btn.Top;
            panel9.Height = btn.Height;
            btn.Focus();
        }

        private void ApplyRolePermissions()
        {
            if (_roleName == "Admin")
            {
                btUser.Enabled = false;
                ucClient.Show();
                ucUser.Hide();
                SetActiveButton(btClient);
            }
            else if (_roleName == "Manager")
            {
                btUser.Enabled = true;
                ucUser.Show();
                ucClient.Hide();
                SetActiveButton(btUser);
            }

        }







        //Event Handlers
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString(
                "dd-MMM-yyyy HH:mm:ss",
                new CultureInfo("en-US"));
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            ApplyRolePermissions();
            timer1.Start();
            lbName.Text = Name;
            ucRoom.Hide();
            ucReservation.Hide();
            ucRoomTimeline.Hide();

        }

        private void btUser_Click(object sender, EventArgs e)
        {
            SetActiveButton(btUser);
            ucUser.Show();
            ucClient.Hide();
            ucRoom.Hide();
            ucReservation.Hide();
            ucRoomTimeline.Hide();
        }

        private void btClient_Click(object sender, EventArgs e)
        {
            SetActiveButton(btClient);
            ucUser.Hide();
            ucClient.Show();
            ucRoom.Hide();
            ucReservation.Hide();
            ucRoomTimeline.Hide();
        }

        private void btRoom_Click(object sender, EventArgs e)
        {
            SetActiveButton(btRoom);
            ucUser.Hide();
            ucClient.Hide();
            ucRoom.Show();
            ucReservation.Hide();
            ucRoomTimeline.Hide();
        }

        private async void btReservation_Click(object sender, EventArgs e)
        {
            SetActiveButton(btReservation);
            ucUser.Hide();
            ucClient.Hide();
            ucRoom.Hide();
            ucRoomTimeline.Hide();
            ucReservation.Show();
            await ucReservation.RefreshClients();

        }

        private async void btTimeline_Click(object sender, EventArgs e)
        {
            SetActiveButton(btTimeline);
            ucUser.Hide();
            ucClient.Hide();
            ucRoom.Hide();
            ucReservation.Hide();
            ucRoomTimeline.Show();
            ucRoomTimeline.BringToFront();
            await ucRoomTimeline.LoadTimelineData(DateTime.Now, 7);

        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            SetActiveButton(btLogOut);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                timer1.Stop();
                this.Close();
                fmLogIn loginForm = new fmLogIn();
                loginForm.Show();
            }
        }









        //Empty Event Handlers
        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void reservationControl1_Load(object sender, EventArgs e)
        {

        }

        private void ucRoomTimeline_Load(object sender, EventArgs e)
        {

        }
    }
}
