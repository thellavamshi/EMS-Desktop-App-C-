namespace Windows_Application_Practice
{
    partial class AdminRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.intCompanyCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminSignUp = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.confirmpassword = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // intCompanyCode
            // 
            this.intCompanyCode.Location = new System.Drawing.Point(372, 313);
            this.intCompanyCode.Name = "intCompanyCode";
            this.intCompanyCode.Size = new System.Drawing.Size(164, 26);
            this.intCompanyCode.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Company Code";
            // 
            // adminSignUp
            // 
            this.adminSignUp.Location = new System.Drawing.Point(524, 397);
            this.adminSignUp.Name = "adminSignUp";
            this.adminSignUp.Size = new System.Drawing.Size(139, 53);
            this.adminSignUp.TabIndex = 41;
            this.adminSignUp.Text = "Submit";
            this.adminSignUp.UseVisualStyleBackColor = true;
            this.adminSignUp.Click += new System.EventHandler(this.adminSignUp_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(829, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(164, 26);
            this.txtEmail.TabIndex = 40;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(746, 163);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(48, 20);
            this.email.TabIndex = 39;
            this.email.Text = "Email";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(370, 189);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(164, 26);
            this.txtLastName.TabIndex = 38;
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(244, 195);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(86, 20);
            this.lastname.TabIndex = 37;
            this.lastname.Text = "Last Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(830, 211);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(164, 26);
            this.txtPassword.TabIndex = 36;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(830, 268);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(164, 26);
            this.txtConfirmPassword.TabIndex = 35;
            // 
            // confirmpassword
            // 
            this.confirmpassword.AutoSize = true;
            this.confirmpassword.Location = new System.Drawing.Point(671, 268);
            this.confirmpassword.Name = "confirmpassword";
            this.confirmpassword.Size = new System.Drawing.Size(133, 20);
            this.confirmpassword.TabIndex = 34;
            this.confirmpassword.Text = "ConfirmPassword";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(244, 246);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(63, 20);
            this.gender.TabIndex = 33;
            this.gender.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 29);
            this.label6.TabIndex = 32;
            this.label6.Text = "Welcome to Admin Registration";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(372, 255);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(164, 26);
            this.txtGender.TabIndex = 31;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(372, 144);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(162, 26);
            this.txtFirstName.TabIndex = 30;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(704, 217);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(78, 20);
            this.password.TabIndex = 29;
            this.password.Text = "Password";
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(244, 144);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(86, 20);
            this.firstname.TabIndex = 28;
            this.firstname.Text = "First Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(708, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 53);
            this.button2.TabIndex = 45;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 596);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.intCompanyCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminSignUp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.confirmpassword);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.password);
            this.Controls.Add(this.firstname);
            this.Name = "AdminRegistration";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox intCompanyCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button adminSignUp;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label confirmpassword;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Button button2;
    }
}