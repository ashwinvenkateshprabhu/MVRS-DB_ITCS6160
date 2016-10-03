using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.Configuration;

namespace MVRS_Project
{
    public partial class SignUp : Form
    {
        string conString;
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection mysql = new MySqlConnection(conString);
            string query = "INSERT INTO user (userName, password, firstName, lastName, emailId,  userType)";
            query += " VALUES (@userName, @password, @firstName, @lastName, @emailId, @userType)";
            mysql.Open();
            MySqlCommand myCommand = new MySqlCommand(query, mysql);
            myCommand.Parameters.AddWithValue("@userName", txtUsrname.Text);
            myCommand.Parameters.AddWithValue("@password", txtPasswd.Text);
            myCommand.Parameters.AddWithValue("@firstName", txtFirstName.Text);
            myCommand.Parameters.AddWithValue("@lastName", txtLastName.Text);
            myCommand.Parameters.AddWithValue("@emailId", txtEmailId.Text);
            myCommand.Parameters.AddWithValue("@userType", cmbUsrtype.Text);

            // ... other parameters
            if (1 == myCommand.ExecuteNonQuery())
                lblSignupSucess.Show();

            mysql.Close();
        }
    }
}
