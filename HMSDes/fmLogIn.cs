using HMSDes;
using HMSDesktop.Services;
using HMSDataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSDesktop
{

    public partial class fmLogIn : Form
    {
        //Member
        private readonly UserApiService service;


        //Constructor
        public fmLogIn()
        {
            InitializeComponent();
            service = new UserApiService();
        }



        //Methods
        private void ClearFields()
        {
            txtUserName.Clear();
            txtBoxPassword.Clear();
        }




        //Event Handlers
        private async void butLogin_Click(object sender, EventArgs e)
        {
            LoginDTO dto = new LoginDTO(txtUserName.Text, txtBoxPassword.Text);

            var user = await service.LoginAsync(dto);

            if (user != null)
            {
                if (user.IsActive)
                {
                    UserId.userID = user.UserID;
                    fmMain fmMain = new fmMain(user.RoleName);
                    fmMain.Name = user.FName + " " + user.LName;
                    ClearFields();
                    fmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Your account is inactive. Please contact the administrator.",
                        "Account Inactive",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }

            }
            else
            {
                MessageBox.Show(
                    "Username or password is incorrect. Please try again.",
                    "Authentication Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void pboxminimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pboxminimize, "Minimize");
        }

        private void pboxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pboxClose, "Close");
        }

        private void pboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pboxminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pboxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pboxShow, "Show Password");
        }

        private void pboxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pboxHide, "Hide Password");
        }

        private void pboxShow_Click(object sender, EventArgs e)
        {
            pboxShow.Hide();
            txtBoxPassword.UseSystemPasswordChar = false;
            pboxHide.Show();
        }

        private void pboxHide_Click(object sender, EventArgs e)
        {
            pboxHide.Hide();
            txtBoxPassword.UseSystemPasswordChar = true;
            pboxShow.Show();
        }

        private void labelForget_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "To reset your password, please contact the system administrator via WhatsApp.\n\n" +
            "Administrator Number:\n+90 552 594 42 81",
            "Forgot Password",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(
                    new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "https://wa.me/905525944281",
                        UseShellExecute = true
                    });
            }
        }





        //Empty Event Handlers
        private void groupBoxlogin_Enter(object sender, EventArgs e)
        {

        }

        private void lableUserName_Click(object sender, EventArgs e)
        {

        }

        private void lablePassword_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelLine_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDown_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fmLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
