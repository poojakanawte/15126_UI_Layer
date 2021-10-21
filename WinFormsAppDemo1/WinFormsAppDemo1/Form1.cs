using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppDemo1
{
    public partial class lblUserName : Form
    {
        public lblUserName()
        {
            InitializeComponent();
        }

        private void lblUserName_Load(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
           
                //username -admin and password -123
                //txtUserName.Text ----username
                //txtpwd.Text ----password //lblMsg.Text= "valid user";
                //lblMsg.Text= "Invalid username or password";
            if (txtUserName.Text == "admin" && txtpwd.Text == "123")
            {
                lblMsg.Text = "Valid User";
            }
            else
            {
                lblMsg.Text = "Invalid UserName or Password";
            }


        }
    }
}
