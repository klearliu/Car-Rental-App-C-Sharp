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
using System.Globalization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public String CARID;
        public Form3 f3;




        public Form1(Form3 ft)
        { 
            InitializeComponent();
            f3 = ft;


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




        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void addCarTo_Click (object sender, EventArgs e)
        {
            string msg = "";

            string PlateNo, BranchID, CarPriceOriginal, CarMake, CarModel, CarYear, CarBody, CarTransmission, CarFuel, CarSeatCapacity, CarMileage, CarColour;

            PlateNo = plateNo.Text.Trim();
            BranchID = branchID.Text.Trim();
            CarPriceOriginal = carPriceOriginal.Text.Trim();
            CarMake = carMake.Text.Trim();
            CarModel = carModel.Text.Trim();
            CarYear = carYear.Text.Trim();
            CarBody = carBody.Text.Trim();
            CarTransmission = carTransmission.Text.Trim();
            CarFuel = carFuel.Text.Trim();
            CarSeatCapacity = carSeatCapacity.Text.Trim();
            CarMileage = carMileage.Text.Trim();
            CarColour = carColour.Text.Trim();

            bool success = true;

            
            if (PlateNo == "" || BranchID == "" || CarPriceOriginal == "" ||
                CarMake == "" || CarModel == "" || CarYear == "" ||
                CarBody == "" || CarTransmission == "" || CarFuel == "" ||
                CarSeatCapacity == "" || CarMileage == "" || CarColour == "" ||
                PlateNo.Length != 8 || CarYear.Length != 4)

                success = false;

            if (success == true)
            {
                // Creating message box's string
                msg = "Plate No: " + PlateNo;
                msg += "\nBranch ID: " + BranchID;
                msg += "\nOriginal Car Price: " + CarPriceOriginal;

                msg += "\n";

                msg += "Make: " + CarMake;
                msg += "\nModel: " + CarModel;
                msg += "\nYear: " + CarYear;

                msg += "\n";

                msg += "Body Type: " + CarBody;
                msg += "\nTransmission Type: " + CarTransmission;
                msg += "\nFuel Type: " + CarFuel;

                msg += "\n";

                msg += "Seat Capacity: " + CarSeatCapacity;
                msg += "\nMileage: " + CarMileage;
                msg += "\nColour: " + CarColour;
            }
           

            else
            {
                msg += "\nPLEASE FILL OUT ALL THE FIELDS";


            }

            DialogResult result = MessageBox.Show(msg, "Review", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (result == DialogResult.Yes && PlateNo == "" || BranchID == "" || CarPriceOriginal == "" ||
                CarMake == "" || CarModel == "" || CarYear == "" ||
                CarBody == "" || CarTransmission == "" || CarFuel == "" ||
                CarSeatCapacity == "" || CarMileage == "" || CarColour == "" || PlateNo.Length != 8 || CarYear.Length != 4)
            {
                MessageBox.Show("Please fill out the missing fields");
   
            }

            else if (result == DialogResult.Yes)
            {
                //MessageBox.Show("Success dumb");
                /*
            // Checking CarTypeID count
            string CarTypeIDFile = File.ReadAllText("CarIDs.txt");                //store the number that is in .txt
            File.WriteAllText("CarTypeIDs.txt", "");                              //erase everything in .txt
            int CarTypeIDFile_int = Int32.Parse(CarTypeIDFile) + 1;               //+1 of the stored number
            File.WriteAllText("CarTypeIDs.txt", CarTypeIDFile_int.ToString());    //use the stored as an insert to database
            */

                // Checking CarID count
                string CarIDFile = File.ReadAllText("CarIDs.txt");               //store the number that is in .txt
                File.WriteAllText("CarIDs.txt", "");                              //erase everything in .txt
                int CarIDFile_int = Int32.Parse(CarIDFile) + 1;                    //+1 of the stored number
                File.WriteAllText("CarIDs.txt", CarIDFile_int.ToString());       //use the stored as an insert to database

                //string commandtext;
                string commandtext2;
                try
                {
                    /* Our rates are based on car body type:

                   TYPE        DAILY       WEEKLY      MONTHLY      CHANGEBRANCHFEE     LATEFEE
                   car          15        98{14/d}     390{13/d}          200           200+{15*[days_late]}                          
                   van          17       112{16/d}     450{15/d}          220           200+{17*[days_late]} 
                   suv          18       119{17/d}     480{16/d}          230           200+{18*[days_late]} 
                   truck        25       168{24/d}     690{23/d}          300           200+{25*[days_late]} 
                   luxury       40       273{39/d}    1140{38/d}          450           200+{45*[days_late]} 
               */
                    int dailyRate = 0, weeklyRate = 0, monthlyRate = 0, changeBranchFee = 0, latefee = 200;
                    int CARTYPEID = 0, BRANCHID = 0;

                    // prices for car
                    if (carBody.Text == "car")
                    {
                        CARTYPEID = 1;
                        dailyRate = 15;
                        weeklyRate = (dailyRate - 1) * 7;
                        monthlyRate = (dailyRate - 2) * 30;
                        changeBranchFee = 200;
                    }

                    // prices for van
                    if (carBody.Text == "van")
                    {
                        CARTYPEID = 2;
                        dailyRate = 17;
                        weeklyRate = (dailyRate - 1) * 7;
                        monthlyRate = (dailyRate - 2) * 30;
                        changeBranchFee = 220;
                    }

                    // prices for suv
                    if (carBody.Text == "suv")
                    {
                        CARTYPEID = 3;
                        dailyRate = 18;
                        weeklyRate = (dailyRate - 1) * 7;
                        monthlyRate = (dailyRate - 2) * 30;
                        changeBranchFee = 230;
                    }

                    // prices for truck
                    if (carBody.Text == "truck")
                    {
                        CARTYPEID = 4;
                        dailyRate = 25;
                        weeklyRate = (dailyRate - 1) * 7;
                        monthlyRate = (dailyRate - 2) * 30;
                        changeBranchFee = 300;
                    }

                    // prices for luxury
                    if (carBody.Text == "luxury")
                    {
                        CARTYPEID = 5;
                        dailyRate = 40;
                        weeklyRate = (dailyRate - 1) * 7;
                        monthlyRate = (dailyRate - 2) * 30;
                        changeBranchFee = 220;
                    }
                    if (branchID.Text == "Edmonton")
                    {
                        BRANCHID = 1;
                    }
                    if (branchID.Text == "Vancouver")
                    {
                        BRANCHID = 2;
                    }
                    if (branchID.Text == "Calgary")
                    {
                        BRANCHID = 3;
                    }
                    if (branchID.Text == "Toronto")
                    {
                        BRANCHID = 4;
                    }
                    if (branchID.Text == "Ottawa")
                    {
                        BRANCHID = 5;
                    }
                    /*
                    // ADDING CarTypes in database
                    commandtext = "insert into CarTypes values('" + CARTYPEID + "','" + dailyRate.ToString() + "','" + weeklyRate.ToString() + "','" + monthlyRate.ToString() + "','";
                    commandtext += changeBranchFee.ToString() + "','" + latefee.ToString() + "');";
                    myCommand.CommandText = commandtext;
                    myCommand.ExecuteNonQuery();
                    */

                    // commandtext2 will output:
                    // insert into CARS values ('CarID','plateNo','carPriceOriginal','carMilage','null','carColour','carYear','carBody',
                    // 'carTransmission','carFuel','carSeatCapacity','CarTypeID');
                    /*
                    insert into CARS values ('1','123-4567','123345','15000','null','red','2020','car','automatic','gasoline','5',1);
                    */
                    commandtext2 = "insert into CARS values ('" + CarIDFile + "','" + plateNo.Text + "','" + carMake.Text + "','" + carModel.Text + "','" + carPriceOriginal.Text + "','";
                    commandtext2 += carMileage.Text + "'," + "null" + ",'" + carColour.Text + "','" + carYear.Text + "','" + carBody.Text + "','";
                    commandtext2 += carTransmission.Text + "','" + carFuel.Text + "','" + carSeatCapacity.Text + "','" + CARTYPEID + "','" + BRANCHID+ "');";

                    //MessageBox.Show(commandtext2);

                    myCommand.CommandText = commandtext2;

                    myCommand.ExecuteNonQuery();

                    //MessageBox.Show(commandtext2);
                    MessageBox.Show("Car Id: " + CarIDFile + " created\n" + "Car Added Successfully");


                }

                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Did not add car");
            }

        

            

        }

        private void branchID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void carMake_Click(object sender, EventArgs e)
        {

            carMake.SelectionStart = carMake.Text.Length;

        }

        private void plateNo_Click(object sender, EventArgs e)
        {
            plateNo.SelectionStart = 0;
        }

        private void carPriceOriginal_Click(object sender, EventArgs e)
        {
            carPriceOriginal.SelectionStart = carPriceOriginal.Text.Length;
        }

        private void carModel_Click(object sender, EventArgs e)
        {
            carModel.SelectionStart = carModel.Text.Length;
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            carYear.SelectionStart = carYear.Text.Length;
        }

        private void carMileage_Click(object sender, EventArgs e)
        {
            carMileage.SelectionStart = carMileage.Text.Length;
        }

        private void carFuel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchCarID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            searchPlateNo.SelectionStart = 0;


        }
        private void searchPlateNo_Click(object sender, EventArgs e)
        {
            searchPlateNo.SelectionStart = 0;
        }

        private void tableLayoutPanel1_Paint_3(object sender, PaintEventArgs e)
        {
            /*List<List<Control>> contrlList = new List<List<Control>>();
            for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
            {
                List<Control> rowControls = new List<Control>()
        {
            new Label()
        };
                for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                {
                    tableLayoutPanel1.Controls.Add(rowControls[col], col, row);
                    contrlList.Add(rowControls);
                }
            }
            */
        }

        private void Delete_search_Click(object sender, EventArgs e)
        {
            string msg = "";


            msg += searchPlateNo.Text;
            MessageBox.Show("Selected PlateNo: "+ msg);

            myCommand.CommandText = "select PlateNo, City, Price, Make, Model, [Year], BodyType, TransmissionType, FuelType, SeatCapacity, Mileage, Colour ";
            myCommand.CommandText += "from CARS, Branches ";
            myCommand.CommandText += "where CARS.Branch_ID = Branches.Branch_ID and PlateNo = '" + searchPlateNo.Text + "';";
            //myCommand.CommandText += "where PlateNo = '" +searchPlateNo.Text + "';";

            //MessageBox.Show(myCommand.CommandText);                                           // Error Checking

            try
            {
               

                string City_Display, Price_Display, Make_Display, Model_Display, Year_Display, BodyType_Display;
                string TransmissionType_Display, FuelType_Display, SeatCapacity_Display, Mileage_Display, Colour_Display;

                myReader = myCommand.ExecuteReader();
                myReader.Read();
                /*


                BranchID_Display = myReader["Branch_ID"].ToString();
                MessageBox.Show(BranchID_Display, "1st");
                MessageBox.Show(BranchID_Display.GetType());

                if (myReader["Branch_ID"] == "1")
                {
                    BranchID_Display = myReader["Edmonton"].ToString();
                    MessageBox.Show(BranchID_Display, "2nd");
                }

                if (myReader["Branch_ID"] == "2")
                {
                    BranchID_Display = myReader["Vancouver"].ToString();
                    MessageBox.Show(BranchID_Display);
                }
                if (myReader["Branch_ID"] == "3")
                {
                    BranchID_Display = myReader["Calgary"].ToString();
                    MessageBox.Show(BranchID_Display);
                }
                if (myReader["Branch_ID"] == "4")
                {
                    BranchID_Display = myReader["Toronto"].ToString();
                    MessageBox.Show(BranchID_Display);
                }
                if (myReader["Branch_ID"] == "5")
                {
                    BranchID_Display = myReader["Ottawa"].ToString();
                    MessageBox.Show(BranchID_Display);
                }
                */


                City_Display = myReader["City"].ToString();
                
                Price_Display = myReader["Price"].ToString();

                Make_Display = myReader["Make"].ToString();

                Model_Display = myReader["Model"].ToString();

                Year_Display = myReader["Year"].ToString();

                BodyType_Display = myReader["BodyType"].ToString();

                TransmissionType_Display = myReader["TransmissionType"].ToString();

                FuelType_Display = myReader["FuelType"].ToString();

                SeatCapacity_Display = myReader["SeatCapacity"].ToString();

                Mileage_Display = myReader["Mileage"].ToString();

                Colour_Display = myReader["Colour"].ToString();
                
                myReader.Close();

                /*
                object[] lst = {Delete_branchLocation, Delete_originalCarPrice,
                Delete_carMake, Delete_carModel, Delete_carYear, Delete_carBody,
                Delete_carTransmission, Delete_carFuel, Delete_carSeatCapacity,
                Delete_carMileage, Delete_carColour}
                

                for (int i = 0; i <= lst.Length; i++)
                   lst[i].Visible = true;
                */

                Delete_branchLocation.Visible = true;
                Delete_branchLocation.Text = City_Display;

                Delete_originalCarPrice.Visible = true;
                Delete_originalCarPrice.Text = Price_Display;

                Delete_carMake.Visible = true;
                Delete_carMake.Text = Make_Display;

                Delete_carModel.Visible = true;
                Delete_carModel.Text = Model_Display;

                Delete_carYear.Visible = true;
                Delete_carYear.Text = Year_Display;

                Delete_carBody.Visible = true;
                Delete_carBody.Text = BodyType_Display;

                Delete_carTransmission.Visible = true;
                Delete_carTransmission.Text = TransmissionType_Display;

                Delete_carFuel.Visible = true;
                Delete_carFuel.Text = FuelType_Display;

                Delete_carSeatCapacity.Visible = true;
                Delete_carSeatCapacity.Text = SeatCapacity_Display;

                Delete_carMileage.Visible = true;
                Delete_carMileage.Text = Mileage_Display;

                Delete_carColour.Visible = true;
                Delete_carColour.Text = Colour_Display;

                removeCar.Visible = true;




            }
                

            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Car not found");
                myReader.Close();
            }



                














        }

        private void removeCar_Click(object sender, EventArgs e)
        {


            myCommand.CommandText = "DELETE from CARS WHERE PlateNo = '" + searchPlateNo.Text + "';"; 
            myCommand.ExecuteReader();
            myReader.Close();

            MessageBox.Show("Successfully DELETED Car");
            Delete_branchLocation.Visible = false;

            Delete_originalCarPrice.Visible = false;

            Delete_carMake.Visible = false;

            Delete_carModel.Visible = false;

            Delete_carYear.Visible = false;

            Delete_carBody.Visible = false;

            Delete_carTransmission.Visible = false;

            Delete_carFuel.Visible = false;

            Delete_carSeatCapacity.Visible = false;

            Delete_carMileage.Visible = false;
  
            Delete_carColour.Visible = false;

            removeCar.Visible = false;

            searchPlateNo.Text = "";


        }

        private void Modify_Search_Click(object sender, EventArgs e)
        {
            string msg = "";


            msg += Modify_searchPlateNo.Text;
            MessageBox.Show("Selected PlateNo: " + msg);

            myCommand.CommandText = "select Car_ID, PlateNo, City, Price, Make, Model, [Year], BodyType, TransmissionType, FuelType, SeatCapacity, Mileage, Colour ";
            myCommand.CommandText += "from CARS, Branches ";
            myCommand.CommandText += "where CARS.Branch_ID = Branches.Branch_ID and PlateNo = '" + Modify_searchPlateNo.Text + "';";
            try
            {
               

                myReader = myCommand.ExecuteReader();
                myReader.Read();

                CARID = $"{myReader["Car_ID"].ToString().Trim()}";

                LabelcarID.Text = "Car ID: "+ CARID;
                LabelcarID.Visible = true;

                modifyPlateNo.Text = myReader["PlateNo"].ToString();

                modifyBranchID.Text = myReader["City"].ToString().Trim();

                modifycarPrice.Text = myReader["Price"].ToString();

                modifycarMake.Text = myReader["Make"].ToString();

                modifycarModel.Text = myReader["Model"].ToString();

                modifycarYear.Text = myReader["Year"].ToString();

                modifybodyType.Text = myReader["BodyType"].ToString().Trim();

                modifytransmissionType.Text = myReader["TransmissionType"].ToString().Trim();

                modifyfuelType.Text = myReader["FuelType"].ToString().Trim();

                modifyseatCapacity.Text = myReader["SeatCapacity"].ToString().Trim();

                modifyMileage.Text = myReader["Mileage"].ToString();

                modifyColour.Text = myReader["Colour"].ToString().Trim();

                myReader.Close();
      

                textPlate.Visible = true;
                modifyPlateNo.Visible = true;

                textBranch.Visible = true;
                modifyBranchID.Visible = true;

                textOriginal.Visible = true;
                modifycarPrice.Visible = true;

                textMake.Visible = true;
                modifycarMake.Visible = true;

                textModel.Visible = true;
                modifycarModel.Visible = true;

                textYear.Visible = true;
                modifycarYear.Visible = true;

                textBody.Visible = true;
                modifybodyType.Visible = true;

                textTransmission.Visible = true;
                modifytransmissionType.Visible = true;

                textFuel.Visible = true;
                modifyfuelType.Visible = true;

                textSeat.Visible = true;
                modifyseatCapacity.Visible = true;

                textMileage.Visible = true;
                modifyMileage.Visible = true;

                textColour.Visible = true;
                modifyColour.Visible = true;

                modifyButton.Visible = true;

            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Car not found");
                myReader.Close();
            }



        }


        private void Modify_searchPlateNo_Click(object sender, EventArgs e)
        {
            Modify_searchPlateNo.SelectionStart = 0;
        }

        private void modifyButton_Click(object sender, EventArgs e)

        { 

            if (modifyPlateNo.Text == "" || modifyBranchID.Text == "" || modifycarPrice.Text == "" ||
                modifycarMake.Text == "" || modifycarModel.Text == "" || modifycarYear.Text == "" ||
                modifybodyType.Text == "" || modifytransmissionType.Text == "" || modifyfuelType.Text == "" ||
                modifyseatCapacity.Text == "" || modifyMileage.Text == "" || modifyColour.Text == "" ||
                modifyPlateNo.Text.Length != 8 || modifycarYear.Text.Length != 4)

                MessageBox.Show("PLEASE FILL OUT ALL DATA");

            else
            {
                int BRANCHID = 0;

                if (modifyBranchID.Text == "Edmonton")
                {
                    BRANCHID = 1;
                }
                if (modifyBranchID.Text == "Vancouver")
                {
                    BRANCHID = 2;
                }
                if (modifyBranchID.Text == "Calgary")
                {
                    BRANCHID = 3;
                }
                if (modifyBranchID.Text == "Toronto")
                {
                    BRANCHID = 4;
                }
                if (modifyBranchID.Text == "Ottawa")
                {
                    BRANCHID = 5;
                }
                myCommand.CommandText = "UPDATE CARS SET PlateNo = '" + modifyPlateNo.Text + "'" + ", Branch_ID = '" + BRANCHID + "', Mileage = '" + modifyMileage.Text + "' , Colour = '" + modifyColour.Text + "' " + "WHERE Car_ID = '" + CARID + "';";
     
                MessageBox.Show("Car Modified Successfully");
                myReader = myCommand.ExecuteReader();
                myReader.Close();
            }
            


        }

        private void LabelcarID_Click(object sender, EventArgs e)
        {

        }

        private void goBack_Click(object sender, EventArgs e)
        {
            f3.Show();
            this.Close();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void branchfeefalc(object sender, EventArgs e)
        {
            
        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void processReturn_Click(object sender, EventArgs e)
        {


            myCommand.CommandText = "SELECT RequestedCarType, ActualCarType, CarTypes.CarTypeID, DailyRate, WeeklyRate, MonthlyRate, ChangeBranchFee, isMember, PickUpBranchID, ReturnBranchID, DATEDIFF(day, date_to, date_returned) as DateDiff FROM RentalTransactions LEFT JOIN CARS ON RentalTransactions.Car_ID = CARS.Car_ID LEFT JOIN CarTypes ON CARS.CarTypeID = CarTypes.CarTypeID WHERE Transaction_ID = '" + returnstransactionID.Text + "';";
            myReader = myCommand.ExecuteReader();
            myReader.Read();

            //MessageBox.Show(myReader["DateDiff"].ToString());
            string PickupBranch = myReader["PickUpBranchID"].ToString(), ReturnBranch = myReader["ReturnBranchID"].ToString(), isMember = myReader["isMember"].ToString(),
                requestedcarType = myReader["RequestedCarType"].ToString(), requestedcarid = "";
            int numDay = 0, numWeek = 0, numMonth = 0, modWeek = 0, modMonth = 0, rentalFee = 0, monthlyfee = Int32.Parse(myReader["MonthlyRate"].ToString()),
                weeklyfee = Int32.Parse(myReader["WeeklyRate"].ToString()), dailyfee = Int32.   Parse(myReader["DailyRate"].ToString()), totalfees = 0,
                changebranchfee = Int32.Parse(myReader["ChangeBranchFee"].ToString()), Latefee = 200, DateDifference = Int32.Parse(myReader["DateDiff"].ToString());
            MessageBox.Show("datedifference",DateDifference.ToString());

           
            if (myReader["RequestedCarType"].ToString() == myReader["ActualCarType"].ToString())
            {
                if (DateDifference == 0)
                {
                    latefeeLabel.Text = "0";


                }
                else
                {
                    latefeeLabel.Text = Latefee.ToString();
                }

                if (PickupBranch != ReturnBranch && isMember == "N")
                {
                    changebranchLabel.Text = changebranchfee.ToString();
                }

                else
                {
                    changebranchLabel.Text = "0";
                }

                if (DateDifference >= 30)
                {
                    numMonth = DateDifference / 30;
                    modMonth = DateDifference % 30;
                    DateDifference = modMonth;

                }


                if (DateDifference >= 7)
                {
                    numWeek = DateDifference / 7;
                    modWeek = DateDifference % 7;

                    DateDifference = modWeek;
                }
                if (DateDifference < 7)
                {
                    numDay = DateDifference;
                }


                rentalFee = (numMonth * monthlyfee) + (numWeek * weeklyfee) + (numDay * dailyfee);



                rentalfeeLabel.Text = rentalFee.ToString();

                if (PickupBranch != ReturnBranch && isMember == "N")
                {
                    myReader.Close();
                    totalfees = (rentalFee + Latefee + changebranchfee);
                    totalfeeLabel.Text = totalfees.ToString();
                    myCommand.CommandText = "UPDATE RentalTransactions SET TotalFees = '" + totalfees + "' WHERE Transaction_ID = '" + returnstransactionID.Text + "';";
                    myCommand.ExecuteNonQuery();
                    myReader.Close();
                }
                else
                {
                    myReader.Close();
                    totalfees = (rentalFee + Latefee);
                    totalfeeLabel.Text = totalfees.ToString();
                    myCommand.CommandText = "UPDATE RentalTransactions SET TotalFees = '" + totalfees + "' WHERE Transaction_ID = '" + returnstransactionID.Text + "';";
                    myCommand.ExecuteNonQuery();
                    myReader.Close();
                }


            myCommand.CommandText = "SELECT Cust_ID FROM RentalTransactions WHERE YEAR(date_from) = '2022' and date_returned is not null and Cust_ID = '" + returnscustID.Text + "' GROUP BY Cust_ID HAVING Count(*) >= 3;";
            myReader = myCommand.ExecuteReader();

            myReader.Read();
            try
            {
                int countcustID = Int32.Parse(myReader["Cust_ID"].ToString());

                myReader.Close();


                myCommand.CommandText = "UPDATE Customers SET MembershipStatus = 'Y' WHERE Cust_ID = '" + countcustID + "';";
                myCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry no membership today :(");
            }
                rentalfeeLabel.Visible = true;
            changebranchLabel.Visible = true;
            latefeeLabel.Visible = true;
            totalfeeLabel.Visible = true;

            myReader.Close();
            }

            
            else
            {
                if (requestedcarType.Trim() == "car")
                {
                    requestedcarid = "1";
                }
                if (requestedcarType.Trim() == "van")
                {
                    requestedcarid = "2";
                }
                if (requestedcarType.Trim() == "suv")
                {
                    requestedcarid = "3";
                }
                if (requestedcarType.Trim() == "truck")
                {
                    requestedcarid = "4";
                }
                if (requestedcarType.Trim() == "luxury")
                {
                    requestedcarid = "5";
                }
                MessageBox.Show(requestedcarType);
                MessageBox.Show(requestedcarid);
                myReader.Close();
                myCommand.CommandText = "SELECT * FROM CarTypes WHERE CarTypeID = '" + requestedcarid + "';";
                myReader = myCommand.ExecuteReader();
                myReader.Read();

                int changeddailyFee = Int32.Parse(myReader["DailyRate"].ToString()) ,changedweeklyFee = Int32.Parse(myReader["WeeklyRate"].ToString()), changedmonthlyFee = Int32.Parse(myReader["MonthlyRate"].ToString()),
                    changebranchfee2 = Int32.Parse(myReader["ChangeBranchFee"].ToString());

                if (DateDifference == 0)
                {
                    latefeeLabel.Text = "0";


                }
                else
                {
                    latefeeLabel.Text = Latefee.ToString();
                }

                if (PickupBranch != ReturnBranch && isMember == "N")
                {
                    changebranchLabel.Text = changebranchfee2.ToString();
                }
                else
                {
                    changebranchLabel.Text = "0";
                }

                if (DateDifference >= 30)
                {
                    numMonth = DateDifference / 30;
                    modMonth = DateDifference % 30;
                    DateDifference = modMonth;
                    //MessageBox.Show(numMonth.ToString());
                    //MessageBox.Show(modMonth.ToString());
                    //MessageBox.Show(DateDifference.ToString());
                }


                if (DateDifference >= 7)
                {
                    numWeek = DateDifference / 7;
                    modWeek = DateDifference % 7;
                    DateDifference = modWeek;
                }
                if (DateDifference < 7)
                {
                    numDay = DateDifference;
                }

                rentalFee = (numMonth * changedmonthlyFee) + (numWeek * changedweeklyFee) + (numDay * changeddailyFee);



                rentalfeeLabel.Text = rentalFee.ToString();

                if (PickupBranch != ReturnBranch && isMember == "N")
                {
                    myReader.Close();
                    totalfees = (rentalFee + Latefee + changebranchfee2);
                    totalfeeLabel.Text = totalfees.ToString();
                    myCommand.CommandText = "UPDATE RentalTransactions SET TotalFees = '" + totalfees + "' WHERE Transaction_ID = '" + returnstransactionID.Text + "';";
                    myCommand.ExecuteNonQuery();
                    myReader.Close();

                    
               
                    
                }
                else
                {
                    myReader.Close();
                    totalfees = (rentalFee + Latefee);
                    totalfeeLabel.Text = totalfees.ToString();
                    myCommand.CommandText = "UPDATE RentalTransactions SET TotalFees = '" + totalfees + "' WHERE Transaction_ID = '" + returnstransactionID.Text + "';";
                    myCommand.ExecuteNonQuery();
                    myReader.Close();

                }
                myCommand.CommandText = "SELECT Cust_ID FROM RentalTransactions WHERE YEAR(date_from) = '2022' and date_returned is not null and Cust_ID = '" + returnscustID.Text + "' GROUP BY Cust_ID HAVING Count(*) >= 3;";
                myReader = myCommand.ExecuteReader();

                myReader.Read();
                try
                {
                    int countcustID = Int32.Parse(myReader["Cust_ID"].ToString());

                    myReader.Close();


                    myCommand.CommandText = "UPDATE Customers SET MembershipStatus = 'Y' WHERE Cust_ID = '" + countcustID + "';";
                    myCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sorry no membership today :(");
                }
                rentalfeeLabel.Visible = true;
                changebranchLabel.Visible = true;
                latefeeLabel.Visible = true;
                totalfeeLabel.Visible = true;



                myReader.Close();

               

            }
                
           


            /*
            CultureInfo provider = CultureInfo.InvariantCulture;
            MessageBox.Show(dateto);
            MessageBox.Show(datereturned);

            DateTime DateTo = DateTime.ParseExact(dateto, "dd-MM-yyyy", provider);
            DateTime DateReturned = DateTime.ParseExact(datereturned, "yyyy-MM-dd", provider);

            MessageBox.Show(DateTo.ToString());
            MessageBox.Show(DateReturned.ToString());
            




            if (DateTo == DateReturned)
            {
                myCommand.CommandText = "UPDATE RentalTransactions SET LateFee = 'N' WHERE RentalTransactions.Cust_ID = '" + returnscustID.Text + "';";
                
            }
            if(DateTo > DateReturned)
            {
                myCommand.CommandText = "UPDATE RentalTransactions SET LateFee = 'N' WHERE RentalTransactions.Cust_ID = '" + returnscustID.Text + "';";
            }
            */

        }

        private void searchReturns_Click(object sender, EventArgs e)
        {
            try
            {

                if (custNameReturns.Text != "")
                {
                    try
                    {

                        string[] customerFirst = custNameReturns.Text.Split(" ");


                        myCommand.CommandText = "SELECT * FROM Customers LEFT JOIN RentalTransactions ON Customers.Cust_ID = RentalTransactions.Cust_ID   WHERE FirstName = '" + customerFirst[0] + "' and  LastName = '" + customerFirst[1] + "' and Customers.Cust_ID = RentalTransactions.Cust_ID;";
                        MessageBox.Show(myCommand.CommandText);

                        myReader = myCommand.ExecuteReader();
                        myReader.Read();

                        returnscustID.Text = myReader["Cust_ID"].ToString();
                        returnstransactionID.Text = myReader["Transaction_ID"].ToString();
                        returnsemployeeID.Text = myReader["Emp_ID"].ToString();
                        bodytypeReturns.Text = myReader["ActualCarType"].ToString();
                        pickupbranchReturns.Text = myReader["PickupBranchID"].ToString();
                        priceReturns.Text = myReader["Price"].ToString();
                        pickupdateReturns.Text = myReader["date_from"].ToString();
                        estimateddateReturns.Text = myReader["date_to"].ToString();


                        myReader.Close();
                        returnscustID.Visible = true ;
                        returnstransactionID.Visible = true;
                        returnsemployeeID.Visible = true;
                        bodytypeReturns.Visible = true;
                        pickupbranchReturns.Visible = true;
                        priceReturns.Visible = true;
                        pickupdateReturns.Visible = true;
                        estimateddateReturns.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Need First and Last Name");
                       
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Not a valid name");
                myReader.Close();
            }




        }

        private void updateReturns_Click(object sender, EventArgs e)
        {
            string branchid = "";

            if (returnbranchCombo.Text == "Edmonton")
            {
                branchid = "1";
            }
            if (returnbranchCombo.Text == "Vancouver")
            {
                branchid = "2";
            }
            if (returnbranchCombo.Text == "Calgary")
            {
                branchid = "3";
            }
            if (returnbranchCombo.Text == "Toronto")
            {
                branchid = "4";
            }
            if (returnbranchCombo.Text == "Ottawa")
            {
                branchid = "5";
            }
            myCommand.CommandText = "UPDATE RentalTransactions SET ReturnBranchID = '" + branchid + "', date_returned = '" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' WHERE Transaction_ID = '"+ returnstransactionID.Text +"';";
            MessageBox.Show(myCommand.CommandText);
            myReader = myCommand.ExecuteReader();
            myReader.Close();
        }

        private void returnbranchReturns_Click(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void submitReports_Click(object sender, EventArgs e)
        {

        }

        private void searchReport_Click(object sender, EventArgs e)
        {
            reportBox1.Visible = true;
            reportBox2.Visible = true;
            reportBox3.Visible = true;

            if (reportCombo.SelectedIndex == 0)
            {
                reportBox1.Items.Add("1");
                reportBox1.Items.Add("2");
                reportBox1.Items.Add("3");
                reportBox1.Items.Add("4");

                reportBox2.Items.Add("Car");
                reportBox2.Items.Add("Van");
                reportBox2.Items.Add("SUV");
                reportBox2.Items.Add("Truck");
                reportBox2.Items.Add("Luxury");


                reportBox3.Items.Add("2021");
                reportBox3.Items.Add("2022");
            }
            else if (reportCombo.SelectedIndex == 1)
            {
                MessageBox.Show("HELLO");

            }
            else if (reportCombo.SelectedIndex == 2)
            {
                MessageBox.Show("HELLO");
            }
            else if (reportCombo.SelectedIndex == 3)
            {
                MessageBox.Show("HELLO");
            }
        }








        //myCommand.CommandText = ""


    }
}
