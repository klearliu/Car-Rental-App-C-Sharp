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
    public partial class Form2 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public Form3 f3;

     
        public Form2(Form3 ft, string empID)
        {
            InitializeComponent();
             f3 = ft;
             empShowID.Text = empID;
   
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void customerSearch_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = ("SELECT FirstName, LastName, MembershipStatus FROM Customers WHERE Cust_ID = '" + customerIDText.Text + "';");
                MessageBox.Show(myCommand.CommandText);


                myReader = myCommand.ExecuteReader();
                myReader.Read();
                MessageBox.Show(myReader["FirstName"].ToString());
                customerName.Text = myReader["FirstName"].ToString().Trim() + " " + myReader["LastName"].ToString().Trim();
                membershipStatus.Text = myReader["MembershipStatus"].ToString();

                customerName.Visible = true;
                membershipStatus.Visible = true;

                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message, "Invalid Search");
                myReader.Close();
            }



        }


        private void filterSearch_Click(object sender, EventArgs e)
        {
            string branchLocation, bodyType, dateFrom, dateTo;

            //ListView carView = new ListView();
            

            branchLocation = branchLocationLabel.Text;
            bodyType = bodyTypeLabel.Text;

            int BRANCHID = 0;

            if (branchLocationLabel.Text == "Edmonton")
            {
                BRANCHID = 1;
            }
            if (branchLocationLabel.Text == "Vancouver")
            {
                BRANCHID = 2;
            }
            if (branchLocationLabel.Text == "Calgary")
            {
                BRANCHID = 3;
            }
            if (branchLocationLabel.Text == "Toronto")
            {
                BRANCHID = 4;
            }
            if (branchLocationLabel.Text == "Ottawa")
            {
                BRANCHID = 5;
            }
            dateFrom = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");     
            dateTo = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");

            string temp = (dateTimePicker2.Value - dateTimePicker1.Value).Days.ToString();
            if (temp[0] == '-' || temp[0] == '0')
            {
                MessageBox.Show("Incorrect Dates");
            }
            else
            {


                //myCommand.CommandText = "SELECT * FROM CARS, RentalTransactions WHERE  Branch_ID = '" + BRANCHID + "' and BodyType = '" + bodyType + "' and CARS.Car_ID not in (SELECT RentalTransactions.Car_ID FROM RentalTransactions WHERE '" + dateFrom + "' not between date_from and date_to and '" + dateTo + "' not between date_from and date_to);";
                //myCommand.CommandText = "SELECT * FROM CARS, RentalTransactions WHERE  Branch_ID = '" + BRANCHID + "' and BodyType = '" + bodyType + "' and date_from not between CAST('" + dateFrom + "' as date) and CAST('" + dateTo + "' as date) and date_to not between CAST('" + dateFrom + "' as date) and CAST('" + dateTo + "' as date);";
                myCommand.CommandText = "SELECT * FROM CARS LEFT JOIN RentalTransactions ON CARS.Car_ID = RentalTransactions.Car_ID WHERE Branch_ID = '" + BRANCHID + "' and BodyType = '" + bodyType + "' and (date_from is null or ((CAST( '" + dateFrom+ "' as date) < date_from and CAST( '"+ dateTo + "' as date) < date_from) or (CAST('" + dateFrom + "' as date) > date_to and CAST( '"+ dateTo +"' as date) > date_to))); ";
                //myCommand.CommandText = "SELECT date_from, date_to FROM RentalTransactions WHERE '" + dateFrom + "' between date_from and date_to;";


                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                //carView.Clear();

                carView.Items.Clear();
                while (myReader.Read())
                {
                    ListViewItem item = new ListViewItem(myReader["Make"].ToString());
                    

                    item.SubItems.Add(myReader["Model"].ToString());
                    item.SubItems.Add(myReader["Year"].ToString());
                    item.SubItems.Add(myReader["Mileage"].ToString());
                    item.SubItems.Add(myReader["Rating"].ToString());
                    item.SubItems.Add(myReader["Colour"].ToString().ToLower());
                    item.SubItems.Add(myReader["TransmissionType"].ToString());
                    item.SubItems.Add(myReader["FuelType"].ToString());
                    item.SubItems.Add(myReader["SeatCapacity"].ToString());
                    item.SubItems.Add(myReader["Price"].ToString());
                    item.SubItems.Add(myReader["Car_ID"].ToString());
                    item.SubItems.Add(myReader["BodyType"].ToString());
                    carView.Items.Add(item);



                }
                myReader.Close();


                if (carView.Items.Count == 0 && membershipStatus.Text == "Y")
                {
                    if (bodyType == "car")
                    {
                        myCommand.CommandText = "SELECT * FROM CARS LEFT JOIN RentalTransactions ON CARS.Car_ID = RentalTransactions.Car_ID WHERE Branch_ID = '" + BRANCHID + "' and BodyType = 'van' and (date_from is null or ((CAST( '" + dateFrom + "' as date) < date_from and CAST( '" + dateTo + "' as date) < date_from) or (CAST('" + dateFrom + "' as date) > date_to and CAST( '" + dateTo + "' as date) > date_to))); ";
                        myReader = myCommand.ExecuteReader();
                        carView.Items.Clear();
                        while (myReader.Read())
                        {
                            ListViewItem item = new ListViewItem(myReader["Make"].ToString());


                            item.SubItems.Add(myReader["Model"].ToString());
                            item.SubItems.Add(myReader["Year"].ToString());
                            item.SubItems.Add(myReader["Mileage"].ToString());
                            item.SubItems.Add(myReader["Rating"].ToString());
                            item.SubItems.Add(myReader["Colour"].ToString().ToLower());
                            item.SubItems.Add(myReader["TransmissionType"].ToString());
                            item.SubItems.Add(myReader["FuelType"].ToString());
                            item.SubItems.Add(myReader["SeatCapacity"].ToString());
                            item.SubItems.Add(myReader["Price"].ToString());
                            item.SubItems.Add(myReader["Car_ID"].ToString());
                            item.SubItems.Add(myReader["BodyType"].ToString());
                            carView.Items.Add(item);



                        }
                        myReader.Close();

                        if (carView.Items.Count == 0)
                        {
                            MessageBox.Show("Please choose another date range or a different bodytype", "car");
                        }

                    }
                    if (bodyType == "van")
                    {
                        myCommand.CommandText = "SELECT * FROM CARS LEFT JOIN RentalTransactions ON CARS.Car_ID = RentalTransactions.Car_ID WHERE Branch_ID = '" + BRANCHID + "' and BodyType = 'suv' and (date_from is null or ((CAST( '" + dateFrom + "' as date) < date_from and CAST( '" + dateTo + "' as date) < date_from) or (CAST('" + dateFrom + "' as date) > date_to and CAST( '" + dateTo + "' as date) > date_to))); ";
                        myReader = myCommand.ExecuteReader();
                        carView.Items.Clear();
                        while (myReader.Read())
                        {
                            ListViewItem item = new ListViewItem(myReader["Make"].ToString());


                            item.SubItems.Add(myReader["Model"].ToString());
                            item.SubItems.Add(myReader["Year"].ToString());
                            item.SubItems.Add(myReader["Mileage"].ToString());
                            item.SubItems.Add(myReader["Rating"].ToString());
                            item.SubItems.Add(myReader["Colour"].ToString().ToLower());
                            item.SubItems.Add(myReader["TransmissionType"].ToString());
                            item.SubItems.Add(myReader["FuelType"].ToString());
                            item.SubItems.Add(myReader["SeatCapacity"].ToString());
                            item.SubItems.Add(myReader["Price"].ToString());
                            item.SubItems.Add(myReader["Car_ID"].ToString());
                            item.SubItems.Add(myReader["BodyType"].ToString());
                            carView.Items.Add(item);



                        }
                        myReader.Close();
                        if (carView.Items.Count == 0)
                        {
                            MessageBox.Show("Please choose another date range or a different bodytype", "van");
                        }

                    }
                    if (bodyType == "suv")
                    {
                        myCommand.CommandText = "SELECT * FROM CARS LEFT JOIN RentalTransactions ON CARS.Car_ID = RentalTransactions.Car_ID WHERE Branch_ID = '" + BRANCHID + "' and BodyType = 'truck' and (date_from is null or ((CAST( '" + dateFrom + "' as date) < date_from and CAST( '" + dateTo + "' as date) < date_from) or (CAST('" + dateFrom + "' as date) > date_to and CAST( '" + dateTo + "' as date) > date_to))); ";
                        myReader = myCommand.ExecuteReader();
                        carView.Items.Clear();
                        while (myReader.Read())
                        {
                            ListViewItem item = new ListViewItem(myReader["Make"].ToString());


                            item.SubItems.Add(myReader["Model"].ToString());
                            item.SubItems.Add(myReader["Year"].ToString());
                            item.SubItems.Add(myReader["Mileage"].ToString());
                            item.SubItems.Add(myReader["Rating"].ToString());
                            item.SubItems.Add(myReader["Colour"].ToString().ToLower());
                            item.SubItems.Add(myReader["TransmissionType"].ToString());
                            item.SubItems.Add(myReader["FuelType"].ToString());
                            item.SubItems.Add(myReader["SeatCapacity"].ToString());
                            item.SubItems.Add(myReader["Price"].ToString());
                            item.SubItems.Add(myReader["Car_ID"].ToString());
                            item.SubItems.Add(myReader["BodyType"].ToString());
                            carView.Items.Add(item);



                        }
                        myReader.Close();
                        if (carView.Items.Count == 0)
                        {
                            MessageBox.Show("Please choose another date range or a different bodytype", "suv");
                        }
                    }
                    if (bodyType == "truck")
                    {
                        myCommand.CommandText = "SELECT * FROM CARS LEFT JOIN RentalTransactions ON CARS.Car_ID = RentalTransactions.Car_ID WHERE Branch_ID = '" + BRANCHID + "' and BodyType = 'luxury' and (date_from is null or ((CAST( '" + dateFrom + "' as date) < date_from and CAST( '" + dateTo + "' as date) < date_from) or (CAST('" + dateFrom + "' as date) > date_to and CAST( '" + dateTo + "' as date) > date_to))); ";
                        myReader = myCommand.ExecuteReader();
                        carView.Items.Clear();
                        while (myReader.Read())
                        {
                            ListViewItem item = new ListViewItem(myReader["Make"].ToString());


                            item.SubItems.Add(myReader["Model"].ToString());
                            item.SubItems.Add(myReader["Year"].ToString());
                            item.SubItems.Add(myReader["Mileage"].ToString());
                            item.SubItems.Add(myReader["Rating"].ToString());
                            item.SubItems.Add(myReader["Colour"].ToString().ToLower());
                            item.SubItems.Add(myReader["TransmissionType"].ToString());
                            item.SubItems.Add(myReader["FuelType"].ToString());
                            item.SubItems.Add(myReader["SeatCapacity"].ToString());
                            item.SubItems.Add(myReader["Price"].ToString());
                            item.SubItems.Add(myReader["Car_ID"].ToString());
                            item.SubItems.Add(myReader["BodyType"].ToString());
                            carView.Items.Add(item);



                        }
                        myReader.Close();
                        if (carView.Items.Count == 0)
                        {
                            MessageBox.Show("Please choose another date range or a different bodytype","truck");
                        }
                    }
                    if (bodyType == "luxury")
                    {
                        if (carView.Items.Count == 0)
                        {
                            MessageBox.Show("Please choose another date range or a different bodytype","luxury");
                        }
                    }

                }
                
            }
        }

        private void browseCarBack_Click(object sender, EventArgs e)
        {

            f3.Show();
            this.Close();
        }

 
  

        private void customerIDText_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            customerIDText.SelectionStart = customerIDText.Text.Length;
        
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (customerIDText.Text.Trim() != "")
            {
                try
                {
                    myCommand.CommandText = "SELECT * FROM RentalTransactions WHERE RentalTransactions.Cust_ID = '" + customerIDText.Text + "';";
                    myReader = myCommand.ExecuteReader();

                    myReader.Read();
                   


                }
                catch (Exception e3)
                {
                    MessageBox.Show("This customer already has a car rented");
                    myReader.Close();
                }


            }
            if (customerIDText.Text.Trim() == "" || bodyTypeLabel.Text == "" || branchLocationLabel.Text == "")
            {
                MessageBox.Show("Please fill out all fields");

            }


            else
            {

                try
                {
                    string carMake = carView.SelectedItems[0].Text, carModel = carView.SelectedItems[0].SubItems[1].Text,
                                    carYear = carView.SelectedItems[0].SubItems[2].Text, carMileage = carView.SelectedItems[0].SubItems[3].Text,
                                    carRating = carView.SelectedItems[0].SubItems[4].Text, carColour = carView.SelectedItems[0].SubItems[5].Text,
                                    carTransmission = carView.SelectedItems[0].SubItems[6].Text, carFuel = carView.SelectedItems[0].SubItems[7].Text,
                                    carSeat = carView.SelectedItems[0].SubItems[8].Text, carPrice = carView.SelectedItems[0].SubItems[9].Text, requestedcarBody = bodyTypeLabel.Text,
                                    actualcarBody = carView.SelectedItems[0].SubItems[11].Text, BranchCity = branchLocationLabel.Text, dateFrom = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"),
                                    dateTo = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"), empID = empShowID.Text, custID = customerIDText.Text, carID = carView.SelectedItems[0].SubItems[10].Text,
                                    isMember = membershipStatus.Text;

                    Form4 f4 = new Form4(this, carMake, carModel, carYear, carMileage, carRating, carColour, carTransmission, carFuel, carSeat, carPrice, requestedcarBody, actualcarBody, BranchCity, dateFrom, dateTo, empID, custID, carID, isMember);
                    f4.Show();
                    this.Hide();

                }

                catch (Exception e3)
                {
                    MessageBox.Show(e3.Message, "No Selection Made");
                }
            }



          
        }

        private void membershipStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
