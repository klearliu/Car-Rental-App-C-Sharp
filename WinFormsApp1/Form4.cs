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
    public partial class Form4 : Form
    {
        public Form2 f2;
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public String requestedBodyType;
        public String actualBodyType;
        public String isamember;
        public String DateFrom;
        public String DateTo;
        public int tid = 0;

    
        public Form4(Form2 fs, string carMake, string carModel, string carYear, string carMileage, string carRating, string carColour, string carTransmission,string carFuel, string carSeat, string carPrice, string requestedcarBody, string actualcarBody, string BranchCity, string dateFrom, string dateTo, string empID, string custID, string carID, string isMember)
        {
            InitializeComponent();
            int BranchID = 0;
            f2 = fs;
            carMakeLabel.Text = carMake;
            carMakeLabel.Visible = true;
            carModelLabel.Text = carModel;
            carModelLabel.Visible = true;
            carYearLabel.Text = carYear;
            carYearLabel.Visible = true;
            carMileageLabel.Text = carMileage;
            carMileageLabel.Visible = true;
            carRatingLabel.Text = carRating;
            carRatingLabel.Visible = true;
            carColourLabel.Text = carColour;
            carColourLabel.Visible = true;
            carTransmissionLabel.Text = carTransmission;
            carTransmissionLabel.Visible = true;
            carFuelLabel.Text = carFuel;
            carFuelLabel.Visible = true;
            carSeatLabel.Text = carSeat;
            carSeatLabel.Visible = true;
            carPriceLabel.Text = carPrice;
            carPriceLabel.Visible = true;
            isamember = isMember;
            requestedBodyType = requestedcarBody;
            proccessbodyType.Text =  actualcarBody;
            proccessbodyType.Visible = true;
            DateFrom = dateFrom;
            DateTo = dateTo;
            empshowID.Text = empID;
            carIDLabel.Text = carID;
            custIDtext.Text = custID;
            branchLocationLabel.Text = BranchCity;
            
           
            
            String connectionString = "Server = DESKTOP-1EG884N; Database = Project291; Trusted_Connection = yes;";

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

        private void Form4_Load(object sender, EventArgs e)
        {
                   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Close();
        }

        private void processTransaction_Click(object sender, EventArgs e)
        {
            int BranchID = 0;

            if (branchLocationLabel.Text == "Edmonton")
            {
                BranchID = 1;
            }
            if (branchLocationLabel.Text == "Vancouver")
            {
                BranchID = 2;
            }
            if (branchLocationLabel.Text == "Calgary")
            {
                BranchID = 3;
            }
            if (branchLocationLabel.Text == "Toronto")
            {
                BranchID = 4;
            }
            if (branchLocationLabel.Text == "Ottawa")
            {
                BranchID = 5;
            }
            MessageBox.Show(BranchID.ToString());
            string count;
            int countVAL;
            myCommand.CommandText = "SELECT MAX(Transaction_ID) as MaxTransactionID FROM RentalTransactions;";
            MessageBox.Show(myCommand.CommandText);

            myReader = myCommand.ExecuteReader();
            myReader.Read();

            MessageBox.Show(myReader["MaxTransactionID"].ToString());
            count = myReader["MaxTransactionID"].ToString();
            countVAL = Int32.Parse(count);
            tid = countVAL + 1;
            MessageBox.Show(tid.ToString());

            myReader.Close();


            myCommand.CommandText = "insert into RentalTransactions values('" + tid.ToString() + "' , '" + requestedBodyType + "' , '" + proccessbodyType.Text + "' , '" + BranchID + "' , null, '" + carPriceLabel.Text + "' , null, null, '" + DateFrom + "' ,  '" + DateTo + "', null, '" + isamember + "' , '" + empshowID.Text + "' , '" + custIDtext.Text + "', '" + carIDLabel.Text + "');";
            MessageBox.Show(myCommand.CommandText);

            myCommand.ExecuteNonQuery();

            

            
        }
    }
}
