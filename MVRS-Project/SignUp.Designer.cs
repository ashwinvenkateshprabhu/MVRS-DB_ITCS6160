namespace MVRS_Project
{
    partial class SignUp
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
            this.lblFisrtName = new System.Windows.Forms.Label();
            this.lblUsrname = new System.Windows.Forms.Label();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtUsrname = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.cmbUsrtype = new System.Windows.Forms.ComboBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtEmailId = new System.Windows.Forms.TextBox();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.lblSignupSucess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFisrtName
            // 
            this.lblFisrtName.AutoSize = true;
            this.lblFisrtName.Location = new System.Drawing.Point(47, 33);
            this.lblFisrtName.Name = "lblFisrtName";
            this.lblFisrtName.Size = new System.Drawing.Size(63, 13);
            this.lblFisrtName.TabIndex = 0;
            this.lblFisrtName.Text = "First Name :";
            // 
            // lblUsrname
            // 
            this.lblUsrname.AutoSize = true;
            this.lblUsrname.Location = new System.Drawing.Point(47, 107);
            this.lblUsrname.Name = "lblUsrname";
            this.lblUsrname.Size = new System.Drawing.Size(61, 13);
            this.lblUsrname.TabIndex = 1;
            this.lblUsrname.Text = "Username :";
            // 
            // lblPasswd
            // 
            this.lblPasswd.AutoSize = true;
            this.lblPasswd.Location = new System.Drawing.Point(47, 139);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(59, 13);
            this.lblPasswd.TabIndex = 2;
            this.lblPasswd.Text = "Password :";
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(47, 201);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(158, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtUsrname
            // 
            this.txtUsrname.Location = new System.Drawing.Point(158, 100);
            this.txtUsrname.Name = "txtUsrname";
            this.txtUsrname.Size = new System.Drawing.Size(100, 20);
            this.txtUsrname.TabIndex = 5;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(158, 136);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(100, 20);
            this.txtPasswd.TabIndex = 6;
            // 
            // cmbUsrtype
            // 
            this.cmbUsrtype.FormattingEnabled = true;
            this.cmbUsrtype.Location = new System.Drawing.Point(158, 198);
            this.cmbUsrtype.Name = "cmbUsrtype";
            this.cmbUsrtype.Size = new System.Drawing.Size(100, 21);
            this.cmbUsrtype.TabIndex = 7;
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(63, 240);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(75, 23);
            this.btnSignup.TabIndex = 8;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(158, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(158, 65);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 10;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(47, 68);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 13);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name :";
            // 
            // txtEmailId
            // 
            this.txtEmailId.Location = new System.Drawing.Point(158, 169);
            this.txtEmailId.Name = "txtEmailId";
            this.txtEmailId.Size = new System.Drawing.Size(100, 20);
            this.txtEmailId.TabIndex = 12;
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.Location = new System.Drawing.Point(47, 172);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(52, 13);
            this.lblEmailId.TabIndex = 13;
            this.lblEmailId.Text = "Email ID :";
            // 
            // lblSignupSucess
            // 
            this.lblSignupSucess.AutoSize = true;
            this.lblSignupSucess.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSignupSucess.Location = new System.Drawing.Point(98, 275);
            this.lblSignupSucess.Name = "lblSignupSucess";
            this.lblSignupSucess.Size = new System.Drawing.Size(101, 13);
            this.lblSignupSucess.TabIndex = 14;
            this.lblSignupSucess.Text = "Sign up Successful!";
            this.lblSignupSucess.Visible = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 297);
            this.Controls.Add(this.lblSignupSucess);
            this.Controls.Add(this.lblEmailId);
            this.Controls.Add(this.txtEmailId);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.cmbUsrtype);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtUsrname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblPasswd);
            this.Controls.Add(this.lblUsrname);
            this.Controls.Add(this.lblFisrtName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFisrtName;
        private System.Windows.Forms.Label lblUsrname;
        private System.Windows.Forms.Label lblPasswd;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtUsrname;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.ComboBox cmbUsrtype;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtEmailId;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.Label lblSignupSucess;
    }
}