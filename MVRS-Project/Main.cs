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
    public partial class Main : Form
    {
        SignUp signup;
        string conString;
        public Main()
        {
            InitializeComponent();
            signup = new SignUp();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            signup.ShowDialog();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection mysql = new MySqlConnection(conString);
            mysql.Open();

            string query = "SELECT * FROM user where username like @username and password like @password;";
            
            MySqlCommand myCommand = new MySqlCommand(query, mysql);
            myCommand.Parameters.AddWithValue("@userName", txtUsrname.Text);
            myCommand.Parameters.AddWithValue("@password", txtPassword.Text);

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(myCommand);
            da.Fill(ds);

            bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));
            if (loginSuccessful)
                tblessCtrl.SelectTab("tabPage2");
            else
                lblInvalidLogin.Show();

            mysql.Close();

            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            tblessCtrl.SelectTab("tabPage1");
            txtUsrname.Clear();
            txtPassword.Clear();
            lblInvalidLogin.Hide();
        }

        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection mysql = new MySqlConnection(conString);
            string cmd = "SELECT * FROM vehicle";
            MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(cmd, mysql);
            DataSet ds = new DataSet();
            mysqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
