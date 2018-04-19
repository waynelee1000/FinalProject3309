namespace EmpMan
{
    partial class Form1
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
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.btnCreateManager = new System.Windows.Forms.Button();
            this.btnCreateWorker = new System.Windows.Forms.Button();
            this.lblDataEntry = new System.Windows.Forms.Label();
            this.lblCreate = new System.Windows.Forms.Label();
            this.lblToFind = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblHourlyPay = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnFindDisplay = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpEntryControl = new System.Windows.Forms.GroupBox();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.grpManager = new System.Windows.Forms.GroupBox();
            this.grpWorker = new System.Windows.Forms.GroupBox();
            this.grpPerson = new System.Windows.Forms.GroupBox();
            this.grpFormControl = new System.Windows.Forms.GroupBox();
            this.grpEntryControl.SuspendLayout();
            this.grpClient.SuspendLayout();
            this.grpEmployee.SuspendLayout();
            this.grpManager.SuspendLayout();
            this.grpWorker.SuspendLayout();
            this.grpPerson.SuspendLayout();
            this.grpFormControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Location = new System.Drawing.Point(6, 19);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(75, 23);
            this.btnCreateClient.TabIndex = 0;
            this.btnCreateClient.Text = "Create Client";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            // 
            // btnCreateManager
            // 
            this.btnCreateManager.Location = new System.Drawing.Point(123, 19);
            this.btnCreateManager.Name = "btnCreateManager";
            this.btnCreateManager.Size = new System.Drawing.Size(93, 23);
            this.btnCreateManager.TabIndex = 1;
            this.btnCreateManager.Text = "Create Manager";
            this.btnCreateManager.UseVisualStyleBackColor = true;
            // 
            // btnCreateWorker
            // 
            this.btnCreateWorker.Location = new System.Drawing.Point(256, 19);
            this.btnCreateWorker.Name = "btnCreateWorker";
            this.btnCreateWorker.Size = new System.Drawing.Size(91, 23);
            this.btnCreateWorker.TabIndex = 2;
            this.btnCreateWorker.Text = "Create Worker";
            this.btnCreateWorker.UseVisualStyleBackColor = true;
            // 
            // lblDataEntry
            // 
            this.lblDataEntry.AutoSize = true;
            this.lblDataEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntry.Location = new System.Drawing.Point(121, 9);
            this.lblDataEntry.Name = "lblDataEntry";
            this.lblDataEntry.Size = new System.Drawing.Size(270, 13);
            this.lblDataEntry.TabIndex = 3;
            this.lblDataEntry.Text = "Data Entry and Display for SamLia Corporation";
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreate.ForeColor = System.Drawing.Color.Red;
            this.lblCreate.Location = new System.Drawing.Point(37, 46);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(522, 13);
            this.lblCreate.TabIndex = 4;
            this.lblCreate.Text = "To CREATE a new client, manager or worker, always press the button below before t" +
    "yping.";
            // 
            // lblToFind
            // 
            this.lblToFind.AutoSize = true;
            this.lblToFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblToFind.Location = new System.Drawing.Point(37, 126);
            this.lblToFind.Name = "lblToFind";
            this.lblToFind.Size = new System.Drawing.Size(636, 13);
            this.lblToFind.TabIndex = 5;
            this.lblToFind.Text = "To FIND/SEARCH, Edit/UPDATE or DELETE enter person ID and Select appropriate cont" +
    "rol at buttom of form.";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(22, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(170, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(341, 29);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 9;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(14, 27);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(14, 25);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(47, 13);
            this.lblJobTitle.TabIndex = 13;
            this.lblJobTitle.Text = "Job Title";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(19, 25);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 15;
            this.lblSalary.Text = "Salary";
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(21, 52);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(37, 13);
            this.lblBonus.TabIndex = 16;
            this.lblBonus.Text = "Bonus";
            // 
            // lblHourlyPay
            // 
            this.lblHourlyPay.AutoSize = true;
            this.lblHourlyPay.Location = new System.Drawing.Point(19, 22);
            this.lblHourlyPay.Name = "lblHourlyPay";
            this.lblHourlyPay.Size = new System.Drawing.Size(58, 13);
            this.lblHourlyPay.TabIndex = 18;
            this.lblHourlyPay.Text = "Hourly Pay";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(217, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(401, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(62, 24);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(67, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(246, 20);
            this.textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(68, 22);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 24;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(68, 49);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 25;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(94, 19);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 26;
            // 
            // btnFindDisplay
            // 
            this.btnFindDisplay.Location = new System.Drawing.Point(36, 28);
            this.btnFindDisplay.Name = "btnFindDisplay";
            this.btnFindDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnFindDisplay.TabIndex = 27;
            this.btnFindDisplay.Text = "Find/Display";
            this.btnFindDisplay.UseVisualStyleBackColor = true;
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.Location = new System.Drawing.Point(149, 28);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnEditUpdate.TabIndex = 28;
            this.btnEditUpdate.Text = "Edit/Update";
            this.btnEditUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(369, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(598, 157);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(75, 42);
            this.btnClearForm.TabIndex = 30;
            this.btnClearForm.Text = "Clear Form Entries";
            this.btnClearForm.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(598, 235);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // grpEntryControl
            // 
            this.grpEntryControl.Controls.Add(this.btnCreateWorker);
            this.grpEntryControl.Controls.Add(this.btnCreateManager);
            this.grpEntryControl.Controls.Add(this.btnCreateClient);
            this.grpEntryControl.Location = new System.Drawing.Point(74, 66);
            this.grpEntryControl.Name = "grpEntryControl";
            this.grpEntryControl.Size = new System.Drawing.Size(353, 46);
            this.grpEntryControl.TabIndex = 34;
            this.grpEntryControl.TabStop = false;
            this.grpEntryControl.Text = "Controls for Creating a New Entry";
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(this.lblType);
            this.grpClient.Controls.Add(this.textBox4);
            this.grpClient.Location = new System.Drawing.Point(25, 78);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(476, 59);
            this.grpClient.TabIndex = 35;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Client";
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.lblJobTitle);
            this.grpEmployee.Controls.Add(this.textBox5);
            this.grpEmployee.Location = new System.Drawing.Point(25, 154);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(476, 69);
            this.grpEmployee.TabIndex = 36;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Employee";
            // 
            // grpManager
            // 
            this.grpManager.Controls.Add(this.lblSalary);
            this.grpManager.Controls.Add(this.textBox6);
            this.grpManager.Controls.Add(this.lblBonus);
            this.grpManager.Controls.Add(this.textBox7);
            this.grpManager.Location = new System.Drawing.Point(25, 240);
            this.grpManager.Name = "grpManager";
            this.grpManager.Size = new System.Drawing.Size(218, 89);
            this.grpManager.TabIndex = 37;
            this.grpManager.TabStop = false;
            this.grpManager.Text = "Manager";
            // 
            // grpWorker
            // 
            this.grpWorker.Controls.Add(this.lblHourlyPay);
            this.grpWorker.Controls.Add(this.textBox8);
            this.grpWorker.Location = new System.Drawing.Point(281, 240);
            this.grpWorker.Name = "grpWorker";
            this.grpWorker.Size = new System.Drawing.Size(220, 89);
            this.grpWorker.TabIndex = 38;
            this.grpWorker.TabStop = false;
            this.grpWorker.Text = "Worker";
            // 
            // grpPerson
            // 
            this.grpPerson.Controls.Add(this.lblName);
            this.grpPerson.Controls.Add(this.grpWorker);
            this.grpPerson.Controls.Add(this.textBox2);
            this.grpPerson.Controls.Add(this.grpManager);
            this.grpPerson.Controls.Add(this.textBox3);
            this.grpPerson.Controls.Add(this.grpEmployee);
            this.grpPerson.Controls.Add(this.lblID);
            this.grpPerson.Controls.Add(this.grpClient);
            this.grpPerson.Controls.Add(this.lblBirthDate);
            this.grpPerson.Controls.Add(this.textBox1);
            this.grpPerson.Location = new System.Drawing.Point(74, 157);
            this.grpPerson.Name = "grpPerson";
            this.grpPerson.Size = new System.Drawing.Size(518, 345);
            this.grpPerson.TabIndex = 39;
            this.grpPerson.TabStop = false;
            this.grpPerson.Text = "Person";
            // 
            // grpFormControl
            // 
            this.grpFormControl.Controls.Add(this.btnFindDisplay);
            this.grpFormControl.Controls.Add(this.btnEditUpdate);
            this.grpFormControl.Controls.Add(this.btnDelete);
            this.grpFormControl.Location = new System.Drawing.Point(74, 508);
            this.grpFormControl.Name = "grpFormControl";
            this.grpFormControl.Size = new System.Drawing.Size(518, 65);
            this.grpFormControl.TabIndex = 40;
            this.grpFormControl.TabStop = false;
            this.grpFormControl.Text = "Form Controls for Data Processing";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 798);
            this.Controls.Add(this.grpFormControl);
            this.Controls.Add(this.grpPerson);
            this.Controls.Add(this.grpEntryControl);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.lblToFind);
            this.Controls.Add(this.lblCreate);
            this.Controls.Add(this.lblDataEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpEntryControl.ResumeLayout(false);
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            this.grpManager.ResumeLayout(false);
            this.grpManager.PerformLayout();
            this.grpWorker.ResumeLayout(false);
            this.grpWorker.PerformLayout();
            this.grpPerson.ResumeLayout(false);
            this.grpPerson.PerformLayout();
            this.grpFormControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.Button btnCreateManager;
        private System.Windows.Forms.Button btnCreateWorker;
        private System.Windows.Forms.Label lblDataEntry;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Label lblToFind;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblHourlyPay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnFindDisplay;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpEntryControl;
        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.GroupBox grpManager;
        private System.Windows.Forms.GroupBox grpWorker;
        private System.Windows.Forms.GroupBox grpPerson;
        private System.Windows.Forms.GroupBox grpFormControl;
    }
}

