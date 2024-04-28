namespace WinFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dateFrom = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.customerIDText = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carView = new System.Windows.Forms.ListView();
            this.Make = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.dateTo = new System.Windows.Forms.Label();
            this.BranchLocation = new System.Windows.Forms.Label();
            this.bodyTypetext = new System.Windows.Forms.Label();
            this.filterSearch = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.customerSearch = new System.Windows.Forms.Button();
            this.browseCarBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.membershipStatus = new System.Windows.Forms.Label();
            this.branchLocationLabel = new System.Windows.Forms.ComboBox();
            this.bodyTypeLabel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.empShowID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateFrom
            // 
            this.dateFrom.AutoSize = true;
            this.dateFrom.Location = new System.Drawing.Point(39, 228);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(68, 15);
            this.dateFrom.TabIndex = 0;
            this.dateFrom.Text = "Date From: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(110, 261);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer ID:";
            // 
            // customerIDText
            // 
            this.customerIDText.Location = new System.Drawing.Point(102, 16);
            this.customerIDText.Mask = "00000";
            this.customerIDText.Name = "customerIDText";
            this.customerIDText.PromptChar = ' ';
            this.customerIDText.Size = new System.Drawing.Size(100, 23);
            this.customerIDText.TabIndex = 6;
            this.customerIDText.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.customerIDText_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "MemberShip Status:";
            // 
            // carView
            // 
            this.carView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Make,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader8,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader2,
            this.columnHeader10,
            this.columnHeader11});
            this.carView.FullRowSelect = true;
            this.carView.Location = new System.Drawing.Point(343, 64);
            this.carView.Name = "carView";
            this.carView.Size = new System.Drawing.Size(850, 432);
            this.carView.TabIndex = 8;
            this.carView.UseCompatibleStateImageBehavior = false;
            this.carView.View = System.Windows.Forms.View.Details;
            this.carView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Make
            // 
            this.Make.Text = "Make";
            this.Make.Width = 65;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Model";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Year";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 45;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mileage";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rating";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Colour";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Transmission Type";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fuel Type";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 62;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Seat Capacity";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "CarID";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Body Type";
            this.columnHeader11.Width = 70;
            // 
            // dateTo
            // 
            this.dateTo.AutoSize = true;
            this.dateTo.Location = new System.Drawing.Point(52, 267);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(52, 15);
            this.dateTo.TabIndex = 9;
            this.dateTo.Text = "Date To: ";
            // 
            // BranchLocation
            // 
            this.BranchLocation.AutoSize = true;
            this.BranchLocation.Location = new System.Drawing.Point(11, 357);
            this.BranchLocation.Name = "BranchLocation";
            this.BranchLocation.Size = new System.Drawing.Size(96, 15);
            this.BranchLocation.TabIndex = 10;
            this.BranchLocation.Text = "Branch Location:";
            // 
            // bodyTypetext
            // 
            this.bodyTypetext.AutoSize = true;
            this.bodyTypetext.Location = new System.Drawing.Point(39, 319);
            this.bodyTypetext.Name = "bodyTypetext";
            this.bodyTypetext.Size = new System.Drawing.Size(70, 15);
            this.bodyTypetext.TabIndex = 11;
            this.bodyTypetext.Text = "Body Type:  ";
            // 
            // filterSearch
            // 
            this.filterSearch.Location = new System.Drawing.Point(235, 429);
            this.filterSearch.Name = "filterSearch";
            this.filterSearch.Size = new System.Drawing.Size(75, 23);
            this.filterSearch.TabIndex = 12;
            this.filterSearch.Text = "Search";
            this.filterSearch.UseVisualStyleBackColor = true;
            this.filterSearch.Click += new System.EventHandler(this.filterSearch_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(1118, 519);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 13;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // customerSearch
            // 
            this.customerSearch.Location = new System.Drawing.Point(208, 15);
            this.customerSearch.Name = "customerSearch";
            this.customerSearch.Size = new System.Drawing.Size(75, 23);
            this.customerSearch.TabIndex = 15;
            this.customerSearch.Text = "Search";
            this.customerSearch.UseVisualStyleBackColor = true;
            this.customerSearch.Click += new System.EventHandler(this.customerSearch_Click);
            // 
            // browseCarBack
            // 
            this.browseCarBack.Location = new System.Drawing.Point(8, 12);
            this.browseCarBack.Name = "browseCarBack";
            this.browseCarBack.Size = new System.Drawing.Size(75, 23);
            this.browseCarBack.TabIndex = 16;
            this.browseCarBack.Text = "Go Back";
            this.browseCarBack.UseVisualStyleBackColor = true;
            this.browseCarBack.Click += new System.EventHandler(this.browseCarBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name: ";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(123, 60);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(38, 15);
            this.customerName.TabIndex = 18;
            this.customerName.Text = "label4";
            this.customerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customerName.Visible = false;
            // 
            // membershipStatus
            // 
            this.membershipStatus.AutoSize = true;
            this.membershipStatus.Location = new System.Drawing.Point(123, 89);
            this.membershipStatus.Name = "membershipStatus";
            this.membershipStatus.Size = new System.Drawing.Size(38, 15);
            this.membershipStatus.TabIndex = 19;
            this.membershipStatus.Text = "label5";
            this.membershipStatus.Visible = false;
            this.membershipStatus.Click += new System.EventHandler(this.membershipStatus_Click);
            // 
            // branchLocationLabel
            // 
            this.branchLocationLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchLocationLabel.FormattingEnabled = true;
            this.branchLocationLabel.Items.AddRange(new object[] {
            "Edmonton",
            "Vancouver",
            "Calgary",
            "Toronto",
            "Ottawa"});
            this.branchLocationLabel.Location = new System.Drawing.Point(110, 354);
            this.branchLocationLabel.Name = "branchLocationLabel";
            this.branchLocationLabel.Size = new System.Drawing.Size(200, 23);
            this.branchLocationLabel.TabIndex = 20;
            // 
            // bodyTypeLabel
            // 
            this.bodyTypeLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bodyTypeLabel.FormattingEnabled = true;
            this.bodyTypeLabel.Items.AddRange(new object[] {
            "car",
            "van",
            "suv",
            "truck",
            "luxury"});
            this.bodyTypeLabel.Location = new System.Drawing.Point(110, 316);
            this.bodyTypeLabel.Name = "bodyTypeLabel";
            this.bodyTypeLabel.Size = new System.Drawing.Size(200, 23);
            this.bodyTypeLabel.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Filter: ";
            // 
            // empShowID
            // 
            this.empShowID.AutoSize = true;
            this.empShowID.Location = new System.Drawing.Point(1103, 16);
            this.empShowID.Name = "empShowID";
            this.empShowID.Size = new System.Drawing.Size(44, 15);
            this.empShowID.TabIndex = 24;
            this.empShowID.Text = "label41";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.membershipStatus);
            this.panel1.Controls.Add(this.customerName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.customerSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.customerIDText);
            this.panel1.Location = new System.Drawing.Point(8, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 128);
            this.panel1.TabIndex = 25;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 566);
            this.Controls.Add(this.empShowID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bodyTypeLabel);
            this.Controls.Add(this.branchLocationLabel);
            this.Controls.Add(this.browseCarBack);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.filterSearch);
            this.Controls.Add(this.bodyTypetext);
            this.Controls.Add(this.BranchLocation);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.carView);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label dateFrom;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private MaskedTextBox customerIDText;
        private Label label3;
        private BindingSource bindingSource1;
        private ListView carView;
        private Label dateTo;
        private Label BranchLocation;
        private Label bodyTypetext;
        private Button filterSearch;
        private Button button2;
        private Button customerSearch;
        private ColumnHeader Make;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader9;
        private Button browseCarBack;
        private Label label1;
        private Label customerName;
        private Label membershipStatus;
        private ComboBox branchLocationLabel;
        private ComboBox bodyTypeLabel;
        private Label label5;
        private ColumnHeader columnHeader8;
        private Button selectButton;
        private Label empShowID;
        private ColumnHeader columnHeader10;
        private Panel panel1;
        private ColumnHeader columnHeader11;
    }
}