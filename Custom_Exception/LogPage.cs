using Custom_Exception.Business;
using Custom_Exception.Model.Entities.Concrete;
using Custom_Exception.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Exception
{
    public partial class LogPage : Form
    {
        public LogPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        LogPageService logService = new LogPageService();
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (lblCaptcha.Text == txtCaptcha.Text)
            {

                logService.CreateUser(txtFirstName.Text,
                                      txtLastName.Text,
                                      txtUserName.Text,
                                      int.Parse(txtAge.Text));
                Utilities.Utility.Clear(grpSignUp);
            }
            else
                MessageBox.Show("Something went wrong...");

        }

    }
}
