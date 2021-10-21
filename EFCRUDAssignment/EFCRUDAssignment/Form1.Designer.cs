
namespace EFCRUDAssignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmpno = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtHireDate = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.btnEditEmp = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpno
            // 
            this.lblEmpno.AutoSize = true;
            this.lblEmpno.Location = new System.Drawing.Point(96, 26);
            this.lblEmpno.Name = "lblEmpno";
            this.lblEmpno.Size = new System.Drawing.Size(69, 25);
            this.lblEmpno.TabIndex = 0;
            this.lblEmpno.Text = "Empno";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(96, 95);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(95, 25);
            this.lblEmpName.TabIndex = 1;
            this.lblEmpName.Text = "EmpName";
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(96, 156);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(81, 25);
            this.lblHireDate.TabIndex = 2;
            this.lblHireDate.Text = "HireDate";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(96, 221);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(59, 25);
            this.lblSalary.TabIndex = 3;
            this.lblSalary.Text = "Salary";
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Location = new System.Drawing.Point(231, 23);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(150, 31);
            this.txtEmpNo.TabIndex = 4;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(231, 89);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(150, 31);
            this.txtEmpName.TabIndex = 5;
            // 
            // txtHireDate
            // 
            this.txtHireDate.Location = new System.Drawing.Point(231, 150);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(150, 31);
            this.txtHireDate.TabIndex = 6;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(231, 215);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(150, 31);
            this.txtSalary.TabIndex = 7;
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.Location = new System.Drawing.Point(609, 301);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(112, 34);
            this.btnSearchEmp.TabIndex = 8;
            this.btnSearchEmp.Text = "Search Emp";
            this.btnSearchEmp.UseVisualStyleBackColor = true;
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.Location = new System.Drawing.Point(418, 301);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Size = new System.Drawing.Size(112, 34);
            this.btnEditEmp.TabIndex = 9;
            this.btnEditEmp.Text = "Edit Emp";
            this.btnEditEmp.UseVisualStyleBackColor = true;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(231, 301);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(112, 34);
            this.btnAddEmp.TabIndex = 10;
            this.btnAddEmp.Text = "Add Emp";
            this.btnAddEmp.UseVisualStyleBackColor = true;
          //  this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(43, 301);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 34);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(43, 351);
            this.dgData.Name = "dgData";
            this.dgData.RowHeadersWidth = 62;
            this.dgData.RowTemplate.Height = 33;
            this.dgData.Size = new System.Drawing.Size(719, 87);
            this.dgData.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.btnEditEmp);
            this.Controls.Add(this.btnSearchEmp);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtHireDate);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpNo);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lblEmpno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpno;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtEmpNo;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtHireDate;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.Button btnEditEmp;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgData;
    }
}

