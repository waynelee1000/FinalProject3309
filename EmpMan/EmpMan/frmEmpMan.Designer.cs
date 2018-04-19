namespace EmpMan
{
    public partial class frmEmpMan
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
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.txtPersonBirthDate = new System.Windows.Forms.TextBox();
            this.txtClientType = new System.Windows.Forms.TextBox();
            this.txtEmployeeJobTitle = new System.Windows.Forms.TextBox();
            this.txtManagerSalary = new System.Windows.Forms.TextBox();
            this.txtManagerBonus = new System.Windows.Forms.TextBox();
            this.txtWorkerHourlyPay = new System.Windows.Forms.TextBox();
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
            this.btnCreateClient.Location = new System.Drawing.Point(8, 23);
            this.btnCreateClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(100, 28);
            this.btnCreateClient.TabIndex = 0;
            this.btnCreateClient.Text = "Create Client";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            // 
            // btnCreateManager
            // 
            this.btnCreateManager.Location = new System.Drawing.Point(164, 23);
            this.btnCreateManager.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateManager.Name = "btnCreateManager";
            this.btnCreateManager.Size = new System.Drawing.Size(124, 28);
            this.btnCreateManager.TabIndex = 1;
            this.btnCreateManager.Text = "Create Manager";
            this.btnCreateManager.UseVisualStyleBackColor = true;
            // 
            // btnCreateWorker
            // 
            this.btnCreateWorker.Location = new System.Drawing.Point(341, 23);
            this.btnCreateWorker.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateWorker.Name = "btnCreateWorker";
            this.btnCreateWorker.Size = new System.Drawing.Size(121, 28);
            this.btnCreateWorker.TabIndex = 2;
            this.btnCreateWorker.Text = "Create Worker";
            this.btnCreateWorker.UseVisualStyleBackColor = true;
            // 
            // lblDataEntry
            // 
            this.lblDataEntry.AutoSize = true;
            this.lblDataEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntry.Location = new System.Drawing.Point(161, 11);
            this.lblDataEntry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataEntry.Name = "lblDataEntry";
            this.lblDataEntry.Size = new System.Drawing.Size(348, 17);
            this.lblDataEntry.TabIndex = 3;
            this.lblDataEntry.Text = "Data Entry and Display for SamLia Corporation";
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreate.ForeColor = System.Drawing.Color.Red;
            this.lblCreate.Location = new System.Drawing.Point(49, 57);
            this.lblCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(664, 17);
            this.lblCreate.TabIndex = 4;
            this.lblCreate.Text = "To CREATE a new client, manager or worker, always press the button below before t" +
    "yping.";
            // 
            // lblToFind
            // 
            this.lblToFind.AutoSize = true;
            this.lblToFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblToFind.Location = new System.Drawing.Point(49, 155);
            this.lblToFind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToFind.Name = "lblToFind";
            this.lblToFind.Size = new System.Drawing.Size(802, 17);
            this.lblToFind.TabIndex = 5;
            this.lblToFind.Text = "To FIND/SEARCH, Edit/UPDATE or DELETE enter person ID and Select appropriate cont" +
    "rol at buttom of form.";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(29, 36);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(227, 36);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(455, 36);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(71, 17);
            this.lblBirthDate.TabIndex = 9;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(19, 33);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(19, 31);
            this.lblJobTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(62, 17);
            this.lblJobTitle.TabIndex = 13;
            this.lblJobTitle.Text = "Job Title";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(25, 31);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(48, 17);
            this.lblSalary.TabIndex = 15;
            this.lblSalary.Text = "Salary";
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(28, 64);
            this.lblBonus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(48, 17);
            this.lblBonus.TabIndex = 16;
            this.lblBonus.Text = "Bonus";
            // 
            // lblHourlyPay
            // 
            this.lblHourlyPay.AutoSize = true;
            this.lblHourlyPay.Location = new System.Drawing.Point(25, 27);
            this.lblHourlyPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHourlyPay.Name = "lblHourlyPay";
            this.lblHourlyPay.Size = new System.Drawing.Size(77, 17);
            this.lblHourlyPay.TabIndex = 18;
            this.lblHourlyPay.Text = "Hourly Pay";
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(67, 32);
            this.txtPersonID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(132, 22);
            this.txtPersonID.TabIndex = 19;
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(289, 32);
            this.txtPersonName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(132, 22);
            this.txtPersonName.TabIndex = 20;
            // 
            // txtPersonBirthDate
            // 
            this.txtPersonBirthDate.Location = new System.Drawing.Point(535, 32);
            this.txtPersonBirthDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonBirthDate.Name = "txtPersonBirthDate";
            this.txtPersonBirthDate.Size = new System.Drawing.Size(132, 22);
            this.txtPersonBirthDate.TabIndex = 21;
            // 
            // txtClientType
            // 
            this.txtClientType.Location = new System.Drawing.Point(83, 30);
            this.txtClientType.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientType.Name = "txtClientType";
            this.txtClientType.Size = new System.Drawing.Size(132, 22);
            this.txtClientType.TabIndex = 22;
            // 
            // txtEmployeeJobTitle
            // 
            this.txtEmployeeJobTitle.Location = new System.Drawing.Point(89, 23);
            this.txtEmployeeJobTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeJobTitle.Name = "txtEmployeeJobTitle";
            this.txtEmployeeJobTitle.Size = new System.Drawing.Size(327, 22);
            this.txtEmployeeJobTitle.TabIndex = 23;
            // 
            // txtManagerSalary
            // 
            this.txtManagerSalary.Location = new System.Drawing.Point(91, 27);
            this.txtManagerSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagerSalary.Name = "txtManagerSalary";
            this.txtManagerSalary.Size = new System.Drawing.Size(132, 22);
            this.txtManagerSalary.TabIndex = 24;
            // 
            // txtManagerBonus
            // 
            this.txtManagerBonus.Location = new System.Drawing.Point(91, 60);
            this.txtManagerBonus.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagerBonus.Name = "txtManagerBonus";
            this.txtManagerBonus.Size = new System.Drawing.Size(132, 22);
            this.txtManagerBonus.TabIndex = 25;
            // 
            // txtWorkerHourlyPay
            // 
            this.txtWorkerHourlyPay.Location = new System.Drawing.Point(125, 23);
            this.txtWorkerHourlyPay.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkerHourlyPay.Name = "txtWorkerHourlyPay";
            this.txtWorkerHourlyPay.Size = new System.Drawing.Size(132, 22);
            this.txtWorkerHourlyPay.TabIndex = 26;
            // 
            // btnFindDisplay
            // 
            this.btnFindDisplay.Location = new System.Drawing.Point(48, 34);
            this.btnFindDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindDisplay.Name = "btnFindDisplay";
            this.btnFindDisplay.Size = new System.Drawing.Size(100, 28);
            this.btnFindDisplay.TabIndex = 27;
            this.btnFindDisplay.Text = "Find/Display";
            this.btnFindDisplay.UseVisualStyleBackColor = true;
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.Location = new System.Drawing.Point(199, 34);
            this.btnEditUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnEditUpdate.TabIndex = 28;
            this.btnEditUpdate.Text = "Edit/Update";
            this.btnEditUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(492, 34);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(797, 193);
            this.btnClearForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(100, 52);
            this.btnClearForm.TabIndex = 30;
            this.btnClearForm.Text = "Clear Form Entries";
            this.btnClearForm.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(797, 289);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // grpEntryControl
            // 
            this.grpEntryControl.Controls.Add(this.btnCreateWorker);
            this.grpEntryControl.Controls.Add(this.btnCreateManager);
            this.grpEntryControl.Controls.Add(this.btnCreateClient);
            this.grpEntryControl.Location = new System.Drawing.Point(99, 81);
            this.grpEntryControl.Margin = new System.Windows.Forms.Padding(4);
            this.grpEntryControl.Name = "grpEntryControl";
            this.grpEntryControl.Padding = new System.Windows.Forms.Padding(4);
            this.grpEntryControl.Size = new System.Drawing.Size(471, 57);
            this.grpEntryControl.TabIndex = 34;
            this.grpEntryControl.TabStop = false;
            this.grpEntryControl.Text = "Controls for Creating a New Entry";
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(this.lblType);
            this.grpClient.Controls.Add(this.txtClientType);
            this.grpClient.Location = new System.Drawing.Point(33, 96);
            this.grpClient.Margin = new System.Windows.Forms.Padding(4);
            this.grpClient.Name = "grpClient";
            this.grpClient.Padding = new System.Windows.Forms.Padding(4);
            this.grpClient.Size = new System.Drawing.Size(635, 73);
            this.grpClient.TabIndex = 35;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Client";
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.lblJobTitle);
            this.grpEmployee.Controls.Add(this.txtEmployeeJobTitle);
            this.grpEmployee.Location = new System.Drawing.Point(33, 190);
            this.grpEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Padding = new System.Windows.Forms.Padding(4);
            this.grpEmployee.Size = new System.Drawing.Size(635, 85);
            this.grpEmployee.TabIndex = 36;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Employee";
            // 
            // grpManager
            // 
            this.grpManager.Controls.Add(this.lblSalary);
            this.grpManager.Controls.Add(this.txtManagerSalary);
            this.grpManager.Controls.Add(this.lblBonus);
            this.grpManager.Controls.Add(this.txtManagerBonus);
            this.grpManager.Location = new System.Drawing.Point(33, 295);
            this.grpManager.Margin = new System.Windows.Forms.Padding(4);
            this.grpManager.Name = "grpManager";
            this.grpManager.Padding = new System.Windows.Forms.Padding(4);
            this.grpManager.Size = new System.Drawing.Size(291, 110);
            this.grpManager.TabIndex = 37;
            this.grpManager.TabStop = false;
            this.grpManager.Text = "Manager";
            // 
            // grpWorker
            // 
            this.grpWorker.Controls.Add(this.lblHourlyPay);
            this.grpWorker.Controls.Add(this.txtWorkerHourlyPay);
            this.grpWorker.Location = new System.Drawing.Point(375, 295);
            this.grpWorker.Margin = new System.Windows.Forms.Padding(4);
            this.grpWorker.Name = "grpWorker";
            this.grpWorker.Padding = new System.Windows.Forms.Padding(4);
            this.grpWorker.Size = new System.Drawing.Size(293, 110);
            this.grpWorker.TabIndex = 38;
            this.grpWorker.TabStop = false;
            this.grpWorker.Text = "Worker";
            // 
            // grpPerson
            // 
            this.grpPerson.Controls.Add(this.lblName);
            this.grpPerson.Controls.Add(this.grpWorker);
            this.grpPerson.Controls.Add(this.txtPersonName);
            this.grpPerson.Controls.Add(this.grpManager);
            this.grpPerson.Controls.Add(this.txtPersonBirthDate);
            this.grpPerson.Controls.Add(this.grpEmployee);
            this.grpPerson.Controls.Add(this.lblID);
            this.grpPerson.Controls.Add(this.grpClient);
            this.grpPerson.Controls.Add(this.lblBirthDate);
            this.grpPerson.Controls.Add(this.txtPersonID);
            this.grpPerson.Location = new System.Drawing.Point(99, 193);
            this.grpPerson.Margin = new System.Windows.Forms.Padding(4);
            this.grpPerson.Name = "grpPerson";
            this.grpPerson.Padding = new System.Windows.Forms.Padding(4);
            this.grpPerson.Size = new System.Drawing.Size(691, 425);
            this.grpPerson.TabIndex = 39;
            this.grpPerson.TabStop = false;
            this.grpPerson.Text = "Person";
            // 
            // grpFormControl
            // 
            this.grpFormControl.Controls.Add(this.btnFindDisplay);
            this.grpFormControl.Controls.Add(this.btnEditUpdate);
            this.grpFormControl.Controls.Add(this.btnDelete);
            this.grpFormControl.Location = new System.Drawing.Point(99, 625);
            this.grpFormControl.Margin = new System.Windows.Forms.Padding(4);
            this.grpFormControl.Name = "grpFormControl";
            this.grpFormControl.Padding = new System.Windows.Forms.Padding(4);
            this.grpFormControl.Size = new System.Drawing.Size(691, 80);
            this.grpFormControl.TabIndex = 40;
            this.grpFormControl.TabStop = false;
            this.grpFormControl.Text = "Form Controls for Data Processing";
            // 
            // frmEmpMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 746);
            this.Controls.Add(this.grpFormControl);
            this.Controls.Add(this.grpPerson);
            this.Controls.Add(this.grpEntryControl);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.lblToFind);
            this.Controls.Add(this.lblCreate);
            this.Controls.Add(this.lblDataEntry);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmpMan";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmEmpMan_Load);
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

        public System.Windows.Forms.Button btnCreateClient;
        public System.Windows.Forms.Button btnCreateManager;
        public System.Windows.Forms.Button btnCreateWorker;
        public System.Windows.Forms.Label lblDataEntry;
        public System.Windows.Forms.Label lblCreate;
        public System.Windows.Forms.Label lblToFind;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblBirthDate;
        public System.Windows.Forms.Label lblType;
        public System.Windows.Forms.Label lblJobTitle;
        public System.Windows.Forms.Label lblSalary;
        public System.Windows.Forms.Label lblBonus;
        public System.Windows.Forms.Label lblHourlyPay;
        public System.Windows.Forms.TextBox txtPersonID;
        public System.Windows.Forms.TextBox txtPersonName;
        public System.Windows.Forms.TextBox txtPersonBirthDate;
        public System.Windows.Forms.TextBox txtClientType;
        public System.Windows.Forms.TextBox txtEmployeeJobTitle;
        public System.Windows.Forms.TextBox txtManagerSalary;
        public System.Windows.Forms.TextBox txtManagerBonus;
        public System.Windows.Forms.TextBox txtWorkerHourlyPay;
        public System.Windows.Forms.Button btnFindDisplay;
        public System.Windows.Forms.Button btnEditUpdate;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnClearForm;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.GroupBox grpEntryControl;
        public System.Windows.Forms.GroupBox grpClient;
        public System.Windows.Forms.GroupBox grpEmployee;
        public System.Windows.Forms.GroupBox grpManager;
        public System.Windows.Forms.GroupBox grpWorker;
        public System.Windows.Forms.GroupBox grpPerson;
        public System.Windows.Forms.GroupBox grpFormControl;
    }
}

