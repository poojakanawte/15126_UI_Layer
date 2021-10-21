using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFAssignment.Models;
using System.Windows.Forms;

namespace EFAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            TrainingContext db1 = new TrainingContext();



            var q = from p in db1.Userdata



                    where p.Username == txtUserName.Text



                    && p.Password == txtPassword.Text



                    select p;



            if (q.Any())



            {



                Console.WriteLine(lblMsg.Text = "Valid User");



            }



            else



            {



                Console.WriteLine(lblMsg.Text = "InValid User");



            }




        }
        }
}
