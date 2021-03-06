﻿namespace EmpMan
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
            this.btnWorker = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.grpManager = new System.Windows.Forms.GroupBox();
            this.grpWorker = new System.Windows.Forms.GroupBox();
            this.grpPerson = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpFormControl = new System.Windows.Forms.GroupBox();
            this.btndisplayList = new System.Windows.Forms.Button();
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
            this.btnCreateClient.Location = new System.Drawing.Point(116, 328);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(109, 23);
            this.btnCreateClient.TabIndex = 0;
            this.btnCreateClient.Text = "Create Client";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Visible = false;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // btnCreateManager
            // 
            this.btnCreateManager.Location = new System.Drawing.Point(116, 328);
            this.btnCreateManager.Name = "btnCreateManager";
            this.btnCreateManager.Size = new System.Drawing.Size(109, 23);
            this.btnCreateManager.TabIndex = 1;
            this.btnCreateManager.Text = "Create Manager";
            this.btnCreateManager.UseVisualStyleBackColor = true;
            this.btnCreateManager.Visible = false;
            this.btnCreateManager.Click += new System.EventHandler(this.btnCreateManager_Click_1);
            // 
            // btnCreateWorker
            // 
            this.btnCreateWorker.Location = new System.Drawing.Point(116, 328);
            this.btnCreateWorker.Name = "btnCreateWorker";
            this.btnCreateWorker.Size = new System.Drawing.Size(109, 23);
            this.btnCreateWorker.TabIndex = 2;
            this.btnCreateWorker.Text = "Create Worker";
            this.btnCreateWorker.UseVisualStyleBackColor = true;
            this.btnCreateWorker.Visible = false;
            this.btnCreateWorker.Click += new System.EventHandler(this.btnCreateWorker_Click_1);
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
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(50, 26);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(100, 20);
            this.txtPersonID.TabIndex = 0;
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(217, 26);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(100, 20);
            this.txtPersonName.TabIndex = 20;
            // 
            // txtPersonBirthDate
            // 
            this.txtPersonBirthDate.Location = new System.Drawing.Point(401, 26);
            this.txtPersonBirthDate.Name = "txtPersonBirthDate";
            this.txtPersonBirthDate.Size = new System.Drawing.Size(100, 20);
            this.txtPersonBirthDate.TabIndex = 21;
            // 
            // txtClientType
            // 
            this.txtClientType.Location = new System.Drawing.Point(62, 25);
            this.txtClientType.Name = "txtClientType";
            this.txtClientType.Size = new System.Drawing.Size(100, 20);
            this.txtClientType.TabIndex = 22;
            // 
            // txtEmployeeJobTitle
            // 
            this.txtEmployeeJobTitle.Location = new System.Drawing.Point(67, 19);
            this.txtEmployeeJobTitle.Name = "txtEmployeeJobTitle";
            this.txtEmployeeJobTitle.Size = new System.Drawing.Size(246, 20);
            this.txtEmployeeJobTitle.TabIndex = 23;
            // 
            // txtManagerSalary
            // 
            this.txtManagerSalary.Location = new System.Drawing.Point(68, 22);
            this.txtManagerSalary.Name = "txtManagerSalary";
            this.txtManagerSalary.Size = new System.Drawing.Size(100, 20);
            this.txtManagerSalary.TabIndex = 24;
            // 
            // txtManagerBonus
            // 
            this.txtManagerBonus.Location = new System.Drawing.Point(68, 49);
            this.txtManagerBonus.Name = "txtManagerBonus";
            this.txtManagerBonus.Size = new System.Drawing.Size(100, 20);
            this.txtManagerBonus.TabIndex = 25;
            // 
            // txtWorkerHourlyPay
            // 
            this.txtWorkerHourlyPay.Location = new System.Drawing.Point(94, 19);
            this.txtWorkerHourlyPay.Name = "txtWorkerHourlyPay";
            this.txtWorkerHourlyPay.Size = new System.Drawing.Size(100, 20);
            this.txtWorkerHourlyPay.TabIndex = 26;
            // 
            // btnFindDisplay
            // 
            this.btnFindDisplay.Location = new System.Drawing.Point(36, 27);
            this.btnFindDisplay.Name = "btnFindDisplay";
            this.btnFindDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnFindDisplay.TabIndex = 27;
            this.btnFindDisplay.Text = "Find/Display";
            this.btnFindDisplay.UseVisualStyleBackColor = true;
            this.btnFindDisplay.Click += new System.EventHandler(this.btnFindDisplay_Click_1);
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.Location = new System.Drawing.Point(149, 27);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnEditUpdate.TabIndex = 28;
            this.btnEditUpdate.Text = "Edit/Update";
            this.btnEditUpdate.UseVisualStyleBackColor = true;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(369, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(598, 171);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(75, 42);
            this.btnClearForm.TabIndex = 30;
            this.btnClearForm.Text = "Clear Form Entries";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpEntryControl
            // 
            this.grpEntryControl.Controls.Add(this.btnWorker);
            this.grpEntryControl.Controls.Add(this.btnManager);
            this.grpEntryControl.Controls.Add(this.btnClient);
            this.grpEntryControl.Location = new System.Drawing.Point(74, 66);
            this.grpEntryControl.Name = "grpEntryControl";
            this.grpEntryControl.Size = new System.Drawing.Size(353, 46);
            this.grpEntryControl.TabIndex = 34;
            this.grpEntryControl.TabStop = false;
            this.grpEntryControl.Text = "Controls for Creating a New Entry";
            // 
            // btnWorker
            // 
            this.btnWorker.Location = new System.Drawing.Point(233, 19);
            this.btnWorker.Name = "btnWorker";
            this.btnWorker.Size = new System.Drawing.Size(91, 23);
            this.btnWorker.TabIndex = 44;
            this.btnWorker.Text = "Create Worker";
            this.btnWorker.UseVisualStyleBackColor = true;
            this.btnWorker.Click += new System.EventHandler(this.btnWorker_Click);
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(111, 19);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(93, 23);
            this.btnManager.TabIndex = 43;
            this.btnManager.Text = "Create Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click_1);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(4, 17);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(75, 23);
            this.btnClient.TabIndex = 42;
            this.btnClient.Text = "Create Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(this.lblType);
            this.grpClient.Controls.Add(this.txtClientType);
            this.grpClient.Location = new System.Drawing.Point(24, 63);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(476, 59);
            this.grpClient.TabIndex = 35;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Client";
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.lblJobTitle);
            this.grpEmployee.Controls.Add(this.txtEmployeeJobTitle);
            this.grpEmployee.Location = new System.Drawing.Point(24, 136);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(476, 69);
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
            this.grpManager.Location = new System.Drawing.Point(24, 221);
            this.grpManager.Name = "grpManager";
            this.grpManager.Size = new System.Drawing.Size(217, 82);
            this.grpManager.TabIndex = 37;
            this.grpManager.TabStop = false;
            this.grpManager.Text = "Manager";
            // 
            // grpWorker
            // 
            this.grpWorker.Controls.Add(this.lblHourlyPay);
            this.grpWorker.Controls.Add(this.txtWorkerHourlyPay);
            this.grpWorker.Location = new System.Drawing.Point(276, 221);
            this.grpWorker.Name = "grpWorker";
            this.grpWorker.Size = new System.Drawing.Size(224, 82);
            this.grpWorker.TabIndex = 38;
            this.grpWorker.TabStop = false;
            this.grpWorker.Text = "Worker";
            // 
            // grpPerson
            // 
            this.grpPerson.Controls.Add(this.btnCancel);
            this.grpPerson.Controls.Add(this.btnCreateWorker);
            this.grpPerson.Controls.Add(this.lblName);
            this.grpPerson.Controls.Add(this.btnCreateManager);
            this.grpPerson.Controls.Add(this.grpWorker);
            this.grpPerson.Controls.Add(this.btnCreateClient);
            this.grpPerson.Controls.Add(this.txtPersonName);
            this.grpPerson.Controls.Add(this.grpManager);
            this.grpPerson.Controls.Add(this.txtPersonBirthDate);
            this.grpPerson.Controls.Add(this.grpEmployee);
            this.grpPerson.Controls.Add(this.lblID);
            this.grpPerson.Controls.Add(this.grpClient);
            this.grpPerson.Controls.Add(this.lblBirthDate);
            this.grpPerson.Controls.Add(this.txtPersonID);
            this.grpPerson.Location = new System.Drawing.Point(74, 157);
            this.grpPerson.Name = "grpPerson";
            this.grpPerson.Size = new System.Drawing.Size(518, 373);
            this.grpPerson.TabIndex = 39;
            this.grpPerson.TabStop = false;
            this.grpPerson.Text = "Person";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(276, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpFormControl
            // 
            this.grpFormControl.Controls.Add(this.btndisplayList);
            this.grpFormControl.Controls.Add(this.btnFindDisplay);
            this.grpFormControl.Controls.Add(this.btnEditUpdate);
            this.grpFormControl.Controls.Add(this.btnDelete);
            this.grpFormControl.Location = new System.Drawing.Point(74, 536);
            this.grpFormControl.Name = "grpFormControl";
            this.grpFormControl.Size = new System.Drawing.Size(518, 65);
            this.grpFormControl.TabIndex = 40;
            this.grpFormControl.TabStop = false;
            this.grpFormControl.Text = "Form Controls for Data Processing";
            // 
            // btndisplayList
            // 
            this.btndisplayList.Location = new System.Drawing.Point(248, 27);
            this.btndisplayList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndisplayList.Name = "btndisplayList";
            this.btndisplayList.Size = new System.Drawing.Size(76, 23);
            this.btndisplayList.TabIndex = 41;
            this.btndisplayList.Text = "Display List";
            this.btndisplayList.UseVisualStyleBackColor = true;
            this.btndisplayList.Click += new System.EventHandler(this.btndisplayList_Click);
            // 
            // frmEmpMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(734, 609);
            this.Controls.Add(this.grpFormControl);
            this.Controls.Add(this.grpPerson);
            this.Controls.Add(this.grpEntryControl);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.lblToFind);
            this.Controls.Add(this.lblCreate);
            this.Controls.Add(this.lblDataEntry);
            this.Name = "frmEmpMan";
            this.Text = "EmpMan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmpMan_FormClosing);
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
        public System.Windows.Forms.Button btnWorker;
        public System.Windows.Forms.Button btnManager;
        public System.Windows.Forms.Button btnClient;
        public System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btndisplayList;
    }
}

