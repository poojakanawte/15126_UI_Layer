using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCRUDAssignment.Models;
using System.Windows.Forms;

namespace EFCRUDAssignment
{


   /* private void Form1_Load(object sender, EventArgs e)
    {
        TrainingContext db1 = new TrainingContext();
        dgData.DataSource = db1.Emps;
        dgData.DataBind();
    }
   */
    public partial class Form1 : Form
    {
        TrainingContext db1 = new TrainingContext();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            txtEmpNo.Clear();
            txtEmpName.Clear();
            txtHireDate.Clear();
            txtSalary.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TrainingContext db1 = new TrainingContext();
            dgData.DataSource = db1.Emps;
          //  dgData.DataBind();
           
        }
       /* private void GetData()
        {
            TrainingContext db1 = new TrainingContext();
            dgData.DataSource = db1.Emps;
           // dgData.DataBind();
        }
       */
       /* private void btnAddEmp_Click(object sender, EventArgs e)
        {
            TrainingContext db1 = new TrainingContext();
            Emps emp = new Emps();
            emp.EmpName = txtEmpName.Text;
            emp.Empno = txtEmpNo.Text;
            db1.Emps.InsertOnSubmit(emp);
            db1.SubmitChanges();
        }
       */
        /*private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        */
    }
}
