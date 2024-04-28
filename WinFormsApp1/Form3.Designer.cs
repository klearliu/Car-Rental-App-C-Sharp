namespace WinFormsApp1
{
    partial class Form3
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
            this.employeebrowseCar = new System.Windows.Forms.Button();
            this.employeeLogin = new System.Windows.Forms.Button();
            this.empIDText = new System.Windows.Forms.MaskedTextBox();
            this.logIn = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeebrowseCar
            // 
            this.employeebrowseCar.Location = new System.Drawing.Point(337, 177);
            this.employeebrowseCar.Name = "employeebrowseCar";
            this.employeebrowseCar.Size = new System.Drawing.Size(75, 23);
            this.employeebrowseCar.TabIndex = 0;
            this.employeebrowseCar.Text = "Browse Car";
            this.employeebrowseCar.UseVisualStyleBackColor = true;
            this.employeebrowseCar.Click += new System.EventHandler(this.employeebrowseCar_Click);
            // 
            // employeeLogin
            // 
            this.employeeLogin.Location = new System.Drawing.Point(319, 243);
            this.employeeLogin.Name = "employeeLogin";
            this.employeeLogin.Size = new System.Drawing.Size(114, 23);
            this.employeeLogin.TabIndex = 1;
            this.employeeLogin.Text = "Employee Login";
            this.employeeLogin.UseVisualStyleBackColor = true;
            this.employeeLogin.Visible = false;
            this.employeeLogin.Click += new System.EventHandler(this.employeeLogin_Click);
            // 
            // empIDText
            // 
            this.empIDText.Location = new System.Drawing.Point(12, 12);
            this.empIDText.Name = "empIDText";
            this.empIDText.Size = new System.Drawing.Size(100, 23);
            this.empIDText.TabIndex = 2;
            // 
            // logIn
            // 
            this.logIn.Location = new System.Drawing.Point(118, 12);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(75, 23);
            this.logIn.TabIndex = 3;
            this.logIn.Text = "Log In";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(713, 415);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(75, 23);
            this.logOut.TabIndex = 4;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.logIn);
            this.Controls.Add(this.empIDText);
            this.Controls.Add(this.employeeLogin);
            this.Controls.Add(this.employeebrowseCar);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button employeebrowseCar;
        private Button employeeLogin;
        private MaskedTextBox empIDText;
        private Button logIn;
        private Button logOut;
    }
}