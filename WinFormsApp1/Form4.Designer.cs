namespace WinFormsApp1
{
    partial class Form4
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.processTransaction = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.empshowID = new System.Windows.Forms.Label();
            this.test1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.carMakeLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.carModelLabel = new System.Windows.Forms.Label();
            this.carYearLabel = new System.Windows.Forms.Label();
            this.carMileageLabel = new System.Windows.Forms.Label();
            this.carRatingLabel = new System.Windows.Forms.Label();
            this.carColourLabel = new System.Windows.Forms.Label();
            this.carTransmissionLabel = new System.Windows.Forms.Label();
            this.carFuelLabel = new System.Windows.Forms.Label();
            this.carSeatLabel = new System.Windows.Forms.Label();
            this.carPriceLabel = new System.Windows.Forms.Label();
            this.carIDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.custIDtext = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.branchLocationLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.proccessbodyType = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(505, 141);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(283, 306);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // processTransaction
            // 
            this.processTransaction.Location = new System.Drawing.Point(713, 424);
            this.processTransaction.Name = "processTransaction";
            this.processTransaction.Size = new System.Drawing.Size(75, 23);
            this.processTransaction.TabIndex = 1;
            this.processTransaction.Text = "Process";
            this.processTransaction.UseVisualStyleBackColor = true;
            this.processTransaction.Click += new System.EventHandler(this.processTransaction_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // empshowID
            // 
            this.empshowID.AutoSize = true;
            this.empshowID.Location = new System.Drawing.Point(750, 16);
            this.empshowID.Name = "empshowID";
            this.empshowID.Size = new System.Drawing.Size(38, 15);
            this.empshowID.TabIndex = 3;
            this.empshowID.Text = "label1";
            // 
            // test1
            // 
            this.test1.AutoSize = true;
            this.test1.Location = new System.Drawing.Point(23, 141);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(36, 15);
            this.test1.TabIndex = 4;
            this.test1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mileage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rating";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Colour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Transmission";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fuel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Seat Capacity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Price";
            // 
            // carMakeLabel
            // 
            this.carMakeLabel.AutoSize = true;
            this.carMakeLabel.Location = new System.Drawing.Point(124, 141);
            this.carMakeLabel.Name = "carMakeLabel";
            this.carMakeLabel.Size = new System.Drawing.Size(44, 15);
            this.carMakeLabel.TabIndex = 14;
            this.carMakeLabel.Text = "label11";
            this.carMakeLabel.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(23, 93);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 15);
            this.label21.TabIndex = 24;
            this.label21.Text = "Car Details:";
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Location = new System.Drawing.Point(124, 187);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(44, 15);
            this.carModelLabel.TabIndex = 25;
            this.carModelLabel.Text = "label12";
            this.carModelLabel.Visible = false;
            // 
            // carYearLabel
            // 
            this.carYearLabel.AutoSize = true;
            this.carYearLabel.Location = new System.Drawing.Point(124, 240);
            this.carYearLabel.Name = "carYearLabel";
            this.carYearLabel.Size = new System.Drawing.Size(44, 15);
            this.carYearLabel.TabIndex = 26;
            this.carYearLabel.Text = "label13";
            this.carYearLabel.Visible = false;
            // 
            // carMileageLabel
            // 
            this.carMileageLabel.AutoSize = true;
            this.carMileageLabel.Location = new System.Drawing.Point(124, 294);
            this.carMileageLabel.Name = "carMileageLabel";
            this.carMileageLabel.Size = new System.Drawing.Size(44, 15);
            this.carMileageLabel.TabIndex = 27;
            this.carMileageLabel.Text = "label14";
            this.carMileageLabel.Visible = false;
            // 
            // carRatingLabel
            // 
            this.carRatingLabel.AutoSize = true;
            this.carRatingLabel.Location = new System.Drawing.Point(124, 357);
            this.carRatingLabel.Name = "carRatingLabel";
            this.carRatingLabel.Size = new System.Drawing.Size(44, 15);
            this.carRatingLabel.TabIndex = 28;
            this.carRatingLabel.Text = "label15";
            this.carRatingLabel.Visible = false;
            // 
            // carColourLabel
            // 
            this.carColourLabel.AutoSize = true;
            this.carColourLabel.Location = new System.Drawing.Point(398, 141);
            this.carColourLabel.Name = "carColourLabel";
            this.carColourLabel.Size = new System.Drawing.Size(44, 15);
            this.carColourLabel.TabIndex = 29;
            this.carColourLabel.Text = "label16";
            this.carColourLabel.Visible = false;
            // 
            // carTransmissionLabel
            // 
            this.carTransmissionLabel.AutoSize = true;
            this.carTransmissionLabel.Location = new System.Drawing.Point(398, 187);
            this.carTransmissionLabel.Name = "carTransmissionLabel";
            this.carTransmissionLabel.Size = new System.Drawing.Size(44, 15);
            this.carTransmissionLabel.TabIndex = 30;
            this.carTransmissionLabel.Text = "label17";
            this.carTransmissionLabel.Visible = false;
            // 
            // carFuelLabel
            // 
            this.carFuelLabel.AutoSize = true;
            this.carFuelLabel.Location = new System.Drawing.Point(398, 240);
            this.carFuelLabel.Name = "carFuelLabel";
            this.carFuelLabel.Size = new System.Drawing.Size(44, 15);
            this.carFuelLabel.TabIndex = 31;
            this.carFuelLabel.Text = "label18";
            this.carFuelLabel.Visible = false;
            // 
            // carSeatLabel
            // 
            this.carSeatLabel.AutoSize = true;
            this.carSeatLabel.Location = new System.Drawing.Point(398, 294);
            this.carSeatLabel.Name = "carSeatLabel";
            this.carSeatLabel.Size = new System.Drawing.Size(44, 15);
            this.carSeatLabel.TabIndex = 32;
            this.carSeatLabel.Text = "label19";
            this.carSeatLabel.Visible = false;
            // 
            // carPriceLabel
            // 
            this.carPriceLabel.AutoSize = true;
            this.carPriceLabel.Location = new System.Drawing.Point(398, 357);
            this.carPriceLabel.Name = "carPriceLabel";
            this.carPriceLabel.Size = new System.Drawing.Size(44, 15);
            this.carPriceLabel.TabIndex = 33;
            this.carPriceLabel.Text = "label20";
            this.carPriceLabel.Visible = false;
            // 
            // carIDLabel
            // 
            this.carIDLabel.AutoSize = true;
            this.carIDLabel.Location = new System.Drawing.Point(124, 93);
            this.carIDLabel.Name = "carIDLabel";
            this.carIDLabel.Size = new System.Drawing.Size(38, 15);
            this.carIDLabel.TabIndex = 34;
            this.carIDLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Customer ID:";
            // 
            // custIDtext
            // 
            this.custIDtext.AutoSize = true;
            this.custIDtext.Location = new System.Drawing.Point(212, 20);
            this.custIDtext.Name = "custIDtext";
            this.custIDtext.Size = new System.Drawing.Size(44, 15);
            this.custIDtext.TabIndex = 36;
            this.custIDtext.Text = "label11";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 15);
            this.label11.TabIndex = 37;
            this.label11.Text = "Branch Location: ";
            // 
            // branchLocationLabel
            // 
            this.branchLocationLabel.AutoSize = true;
            this.branchLocationLabel.Location = new System.Drawing.Point(398, 20);
            this.branchLocationLabel.Name = "branchLocationLabel";
            this.branchLocationLabel.Size = new System.Drawing.Size(44, 15);
            this.branchLocationLabel.TabIndex = 38;
            this.branchLocationLabel.Text = "label12";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(293, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 39;
            this.label12.Text = "Body Type";
            // 
            // proccessbodyType
            // 
            this.proccessbodyType.AutoSize = true;
            this.proccessbodyType.Location = new System.Drawing.Point(398, 93);
            this.proccessbodyType.Name = "proccessbodyType";
            this.proccessbodyType.Size = new System.Drawing.Size(44, 15);
            this.proccessbodyType.TabIndex = 40;
            this.proccessbodyType.Text = "label13";
            this.proccessbodyType.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(626, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 15);
            this.label13.TabIndex = 41;
            this.label13.Text = "label13";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.proccessbodyType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.branchLocationLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.custIDtext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carIDLabel);
            this.Controls.Add(this.carPriceLabel);
            this.Controls.Add(this.carSeatLabel);
            this.Controls.Add(this.carFuelLabel);
            this.Controls.Add(this.carTransmissionLabel);
            this.Controls.Add(this.carColourLabel);
            this.Controls.Add(this.carRatingLabel);
            this.Controls.Add(this.carMileageLabel);
            this.Controls.Add(this.carYearLabel);
            this.Controls.Add(this.carModelLabel);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.carMakeLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.test1);
            this.Controls.Add(this.empshowID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.processTransaction);
            this.Controls.Add(this.listView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private Button processTransaction;
        private Button button2;
        private Label empshowID;
        private Label test1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label carMakeLabel;
        private Label label21;
        private Label carModelLabel;
        private Label carYearLabel;
        private Label carMileageLabel;
        private Label carRatingLabel;
        private Label carColourLabel;
        private Label carTransmissionLabel;
        private Label carFuelLabel;
        private Label carSeatLabel;
        private Label carPriceLabel;
        private Label carIDLabel;
        private Label label1;
        private Label custIDtext;
        private Label label11;
        private Label branchLocationLabel;
        private Label label12;
        private Label proccessbodyType;
        private Label label13;
    }
}