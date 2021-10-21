
namespace WinFormsAppDemo1
{
    partial class lblUserName
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
            this.lblUserName1 = new System.Windows.Forms.Label();
            this.lblPassword1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.btnSignin = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName1
            // 
            this.lblUserName1.AutoSize = true;
            this.lblUserName1.Location = new System.Drawing.Point(161, 71);
            this.lblUserName1.Name = "lblUserName1";
            this.lblUserName1.Size = new System.Drawing.Size(99, 25);
            this.lblUserName1.TabIndex = 0;
            this.lblUserName1.Text = "User Name";
            // 
            // lblPassword1
            // 
            this.lblPassword1.AutoSize = true;
            this.lblPassword1.Location = new System.Drawing.Point(161, 145);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(87, 25);
            this.lblPassword1.TabIndex = 1;
            this.lblPassword1.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(324, 65);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(215, 31);
            this.txtUserName.TabIndex = 2;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(324, 139);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(215, 31);
            this.txtpwd.TabIndex = 3;
            // 
            // btnSignin
            // 
            this.btnSignin.Location = new System.Drawing.Point(364, 228);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(112, 34);
            this.btnSignin.TabIndex = 4;
            this.btnSignin.Text = "Sign in";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(386, 304);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 25);
            this.lblMsg.TabIndex = 5;
            // 
            // lblUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblPassword1);
            this.Controls.Add(this.lblUserName1);
            this.Name = "lblUserName";
            this.Text = "User Name";
            this.Load += new System.EventHandler(this.lblUserName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName1;
        private System.Windows.Forms.Label lblPassword1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Label lblMsg;
    }
}

