using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public Form3()
        {
            InitializeComponent();   

            String connectionString = "Server = DESKTOP-B451VB4; Database = Project291; Trusted_Connection = yes;";

            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
  
        }

        private void employeebrowseCar_Click(object sender, EventArgs e)
        {
            string empID;
            empID = empIDText.Text;
            Form2 f2 = new Form2(this, empID);
            f2.Show();
            this.Hide();
        }

        private void employeeLogin_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(this);
            f1.Show();
            this.Hide();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            string empID;

            empID = empIDText.Text;
            try
            {
                myCommand.CommandText = "SELECT Emp_ID FROM Employees WHERE EXISTS (SELECT Emp_ID FROM Employees WHERE Emp_ID = '" + empID + "');";
                //MessageBox.Show(myCommand.CommandText);

                
                myReader = myCommand.ExecuteReader();

                myReader.Read();

                myReader["Emp_ID"].ToString();

                employeeLogin.Visible = true;
               
                myReader.Close();
                
               
            }
            catch(Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Invalid Employee Login");
              
                myReader.Close();
                
            }



        }

        private void logOut_Click(object sender, EventArgs e)
        {
            employeeLogin.Visible = false;
            empIDText.Clear();
        }
    }
}
