namespace EventManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpBoxNewEvent = new GroupBox();
            label1 = new Label();
            btnCreateEvent = new Button();
            label3 = new Label();
            label2 = new Label();
            txtFeePerParticipant = new TextBox();
            txtCostPerParticipant = new TextBox();
            txtEventTitle = new TextBox();
            grpBoxEventEconomy = new GroupBox();
            lblSurplusDeficit = new Label();
            lblTotalFees = new Label();
            lblTotalCost = new Label();
            lblNumOfParticipants = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            grpBoxAddParticipant = new GroupBox();
            cmbCountry = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            btnAdd = new Button();
            label10 = new Label();
            label9 = new Label();
            txtCity = new TextBox();
            txtZipCode = new TextBox();
            txtLastName = new TextBox();
            txtStreet = new TextBox();
            txtFirstName = new TextBox();
            label8 = new Label();
            grpBoxParticipants = new GroupBox();
            label15 = new Label();
            btnDelete = new Button();
            btnChange = new Button();
            label14 = new Label();
            lstAllParticipants = new ListBox();
            grpBoxNewEvent.SuspendLayout();
            grpBoxEventEconomy.SuspendLayout();
            grpBoxAddParticipant.SuspendLayout();
            grpBoxParticipants.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxNewEvent
            // 
            grpBoxNewEvent.Controls.Add(label1);
            grpBoxNewEvent.Controls.Add(btnCreateEvent);
            grpBoxNewEvent.Controls.Add(label3);
            grpBoxNewEvent.Controls.Add(label2);
            grpBoxNewEvent.Controls.Add(txtFeePerParticipant);
            grpBoxNewEvent.Controls.Add(txtCostPerParticipant);
            grpBoxNewEvent.Controls.Add(txtEventTitle);
            grpBoxNewEvent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBoxNewEvent.ForeColor = Color.Teal;
            grpBoxNewEvent.Location = new Point(12, 23);
            grpBoxNewEvent.Name = "grpBoxNewEvent";
            grpBoxNewEvent.RightToLeft = RightToLeft.No;
            grpBoxNewEvent.Size = new Size(482, 193);
            grpBoxNewEvent.TabIndex = 0;
            grpBoxNewEvent.TabStop = false;
            grpBoxNewEvent.Text = "New Event";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 7;
            label1.Text = "New title";
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.Location = new Point(130, 149);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(154, 38);
            btnCreateEvent.TabIndex = 6;
            btnCreateEvent.Text = "Create Event";
            btnCreateEvent.UseVisualStyleBackColor = true;
            btnCreateEvent.Click += btnCreateEvent_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(15, 107);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 5;
            label3.Text = "Fee per participant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(15, 66);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 4;
            label2.Text = "Cost per participant";
            // 
            // txtFeePerParticipant
            // 
            txtFeePerParticipant.Location = new Point(232, 104);
            txtFeePerParticipant.Name = "txtFeePerParticipant";
            txtFeePerParticipant.Size = new Size(100, 23);
            txtFeePerParticipant.TabIndex = 3;
            // 
            // txtCostPerParticipant
            // 
            txtCostPerParticipant.Location = new Point(232, 63);
            txtCostPerParticipant.Name = "txtCostPerParticipant";
            txtCostPerParticipant.Size = new Size(100, 23);
            txtCostPerParticipant.TabIndex = 2;
            // 
            // txtEventTitle
            // 
            txtEventTitle.Location = new Point(232, 22);
            txtEventTitle.Name = "txtEventTitle";
            txtEventTitle.Size = new Size(237, 23);
            txtEventTitle.TabIndex = 1;
            // 
            // grpBoxEventEconomy
            // 
            grpBoxEventEconomy.Controls.Add(lblSurplusDeficit);
            grpBoxEventEconomy.Controls.Add(lblTotalFees);
            grpBoxEventEconomy.Controls.Add(lblTotalCost);
            grpBoxEventEconomy.Controls.Add(lblNumOfParticipants);
            grpBoxEventEconomy.Controls.Add(label7);
            grpBoxEventEconomy.Controls.Add(label6);
            grpBoxEventEconomy.Controls.Add(label5);
            grpBoxEventEconomy.Controls.Add(label4);
            grpBoxEventEconomy.Location = new Point(538, 23);
            grpBoxEventEconomy.Name = "grpBoxEventEconomy";
            grpBoxEventEconomy.Size = new Size(366, 193);
            grpBoxEventEconomy.TabIndex = 1;
            grpBoxEventEconomy.TabStop = false;
            grpBoxEventEconomy.Text = "Event economy";
            // 
            // lblSurplusDeficit
            // 
            lblSurplusDeficit.BorderStyle = BorderStyle.Fixed3D;
            lblSurplusDeficit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSurplusDeficit.ForeColor = Color.DarkGreen;
            lblSurplusDeficit.Location = new Point(256, 139);
            lblSurplusDeficit.Name = "lblSurplusDeficit";
            lblSurplusDeficit.Size = new Size(100, 23);
            lblSurplusDeficit.TabIndex = 7;
            lblSurplusDeficit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalFees
            // 
            lblTotalFees.BorderStyle = BorderStyle.Fixed3D;
            lblTotalFees.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalFees.ForeColor = Color.DarkGreen;
            lblTotalFees.Location = new Point(256, 104);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(100, 23);
            lblTotalFees.TabIndex = 6;
            lblTotalFees.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalCost
            // 
            lblTotalCost.BorderStyle = BorderStyle.Fixed3D;
            lblTotalCost.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCost.ForeColor = Color.DarkGreen;
            lblTotalCost.Location = new Point(256, 66);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(100, 23);
            lblTotalCost.TabIndex = 5;
            lblTotalCost.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumOfParticipants
            // 
            lblNumOfParticipants.BorderStyle = BorderStyle.Fixed3D;
            lblNumOfParticipants.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumOfParticipants.ForeColor = Color.DarkGreen;
            lblNumOfParticipants.Location = new Point(256, 28);
            lblNumOfParticipants.Name = "lblNumOfParticipants";
            lblNumOfParticipants.Size = new Size(100, 23);
            lblNumOfParticipants.TabIndex = 4;
            lblNumOfParticipants.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(17, 144);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 3;
            label7.Text = "Surplus/Deficit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(17, 109);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 2;
            label6.Text = "Total Fees";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(16, 71);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 1;
            label5.Text = "Total Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(16, 33);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 0;
            label4.Text = "Number of participants";
            // 
            // grpBoxAddParticipant
            // 
            grpBoxAddParticipant.Controls.Add(cmbCountry);
            grpBoxAddParticipant.Controls.Add(label13);
            grpBoxAddParticipant.Controls.Add(label12);
            grpBoxAddParticipant.Controls.Add(label11);
            grpBoxAddParticipant.Controls.Add(btnAdd);
            grpBoxAddParticipant.Controls.Add(label10);
            grpBoxAddParticipant.Controls.Add(label9);
            grpBoxAddParticipant.Controls.Add(txtCity);
            grpBoxAddParticipant.Controls.Add(txtZipCode);
            grpBoxAddParticipant.Controls.Add(txtLastName);
            grpBoxAddParticipant.Controls.Add(txtStreet);
            grpBoxAddParticipant.Controls.Add(txtFirstName);
            grpBoxAddParticipant.Controls.Add(label8);
            grpBoxAddParticipant.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBoxAddParticipant.ForeColor = Color.Teal;
            grpBoxAddParticipant.Location = new Point(17, 247);
            grpBoxAddParticipant.Name = "grpBoxAddParticipant";
            grpBoxAddParticipant.Size = new Size(290, 277);
            grpBoxAddParticipant.TabIndex = 2;
            grpBoxAddParticipant.TabStop = false;
            grpBoxAddParticipant.Text = "Add participant";
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(125, 179);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(148, 23);
            cmbCountry.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(10, 179);
            label13.Name = "label13";
            label13.Size = new Size(50, 15);
            label13.TabIndex = 15;
            label13.Text = "Country";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(10, 150);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 14;
            label12.Text = "City";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(10, 121);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 13;
            label11.Text = "Zip Code";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(41, 229);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(154, 33);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(10, 92);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 12;
            label10.Text = "Street";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(10, 63);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 11;
            label9.Text = "Last Name";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(125, 147);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(148, 23);
            txtCity.TabIndex = 8;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(125, 118);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(148, 23);
            txtZipCode.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(125, 60);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(148, 23);
            txtLastName.TabIndex = 5;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(125, 89);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(148, 23);
            txtStreet.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(125, 31);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(148, 23);
            txtFirstName.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(10, 34);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 3;
            label8.Text = "First Name";
            // 
            // grpBoxParticipants
            // 
            grpBoxParticipants.Controls.Add(label15);
            grpBoxParticipants.Controls.Add(btnDelete);
            grpBoxParticipants.Controls.Add(btnChange);
            grpBoxParticipants.Controls.Add(label14);
            grpBoxParticipants.Controls.Add(lstAllParticipants);
            grpBoxParticipants.Location = new Point(325, 247);
            grpBoxParticipants.Name = "grpBoxParticipants";
            grpBoxParticipants.Size = new Size(579, 277);
            grpBoxParticipants.TabIndex = 3;
            grpBoxParticipants.TabStop = false;
            grpBoxParticipants.Text = "Participants";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Teal;
            label15.Location = new Point(274, 19);
            label15.Name = "label15";
            label15.Size = new Size(57, 17);
            label15.TabIndex = 4;
            label15.Text = "Address";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Teal;
            btnDelete.Location = new Point(274, 229);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 33);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChange
            // 
            btnChange.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChange.ForeColor = Color.Teal;
            btnChange.Location = new Point(50, 229);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(154, 33);
            btnChange.TabIndex = 2;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Teal;
            label14.Location = new Point(35, 19);
            label14.Name = "label14";
            label14.Size = new Size(73, 17);
            label14.TabIndex = 1;
            label14.Text = "Participant";
            // 
            // lstAllParticipants
            // 
            lstAllParticipants.FormattingEnabled = true;
            lstAllParticipants.ItemHeight = 15;
            lstAllParticipants.Location = new Point(6, 45);
            lstAllParticipants.Name = "lstAllParticipants";
            lstAllParticipants.Size = new Size(563, 169);
            lstAllParticipants.TabIndex = 0;
            lstAllParticipants.SelectedIndexChanged += lstAllParticipants_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 536);
            Controls.Add(grpBoxParticipants);
            Controls.Add(grpBoxAddParticipant);
            Controls.Add(grpBoxEventEconomy);
            Controls.Add(grpBoxNewEvent);
            Name = "MainForm";
            Text = "Event Organizer - Version 2 by David Radic";
            grpBoxNewEvent.ResumeLayout(false);
            grpBoxNewEvent.PerformLayout();
            grpBoxEventEconomy.ResumeLayout(false);
            grpBoxEventEconomy.PerformLayout();
            grpBoxAddParticipant.ResumeLayout(false);
            grpBoxAddParticipant.PerformLayout();
            grpBoxParticipants.ResumeLayout(false);
            grpBoxParticipants.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxNewEvent;
        private TextBox txtCostPerParticipant;
        private TextBox txtEventTitle;
        private Label label3;
        private Label label2;
        private TextBox txtFeePerParticipant;
        private Button btnCreateEvent;
        private GroupBox grpBoxEventEconomy;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblNumOfParticipants;
        private Label lblTotalCost;
        private Label lblSurplusDeficit;
        private Label lblTotalFees;
        private GroupBox grpBoxAddParticipant;
        private Label label1;
        private Label label8;
        private TextBox txtFirstName;
        private TextBox txtCity;
        private TextBox txtZipCode;
        private TextBox txtLastName;
        private TextBox txtStreet;
        private ComboBox cmbCountry;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button btnAdd;
        private GroupBox grpBoxParticipants;
        private Button btnChange;
        private Label label14;
        private ListBox lstAllParticipants;
        private Button btnDelete;
        private Label label15;
    }
}
