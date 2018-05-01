// Form Controller Class
// Responsible for all background processing related to frmEmpMan 
// Written in VB by Joseph Jupin     Fall 2009
// Converted to CSharp by Frank Friedman     Spring 2016

// This class contains "static" methods to automate complex tasks
//     on frmEmpMan components

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace EmpMan
{
    class FormController
    {
        private frmEmpMan f;
        public FormController(frmEmpMan parentForm)
        {
            f = parentForm;
        }


        // Resets form to initial state after form is loaded or
        //    an add Employee operation is performed

        public static void resetForm(frmEmpMan f)
        {
            //  Reset button components
           // f.btnClear.Enabled = true;
            f.btnDelete.Enabled = false;
            //f.btnEdit.Enabled = false;
           // f.btnToString.Enabled = false;
            f.btnCreateManager.Enabled = true;
            f.btnCreateManager.Text = "Create Manager";
            f.btnCreateWorker.Enabled = true;
            f.btnCreateWorker.Text = "Create Worker";
            f.btnCreateClient.Enabled = true;
            f.btnCreateClient.Text = "Create Client";
            //f.btnNext.Visible = true;
            //f.btnPrevious.Visible = true;
            //f.btnCancel.Visible = false;

            // Reset group components
            f.grpPerson.Enabled = false;
            f.grpPerson.BackColor = Color.Gainsboro;
            f.grpEmployee.Enabled = false;
            f.grpEmployee.BackColor = Color.Gainsboro;
            f.grpClient.Enabled = false;
            f.grpClient.BackColor = Color.Gainsboro;
            f.grpManager.Enabled = false;
            f.grpManager.BackColor = Color.Gainsboro;
            f.grpWorker.Enabled = false;
            f.grpWorker.BackColor = Color.Gainsboro;
        } // end resetForm


        // Activates and deactivates necessary form buttons
        //    when in add mode
        public static void formAddMode(frmEmpMan f)
        {
            clear(f);
          //  f.btnClear.Enabled = true;
            f.btnDelete.Enabled = false;
            // f.btnEdit.Enabled = false;
            //  f.btnToString.Enabled = false;
            //  f.btnNext.Visible = false;
            //  f.btnPrevious.Visible = false;
            //   f.btnCancel.Visible = true;
        }  // end formAddMode


        // Enable/disable buttons when not in edit mode
        public static void activateAddButtons(frmEmpMan f)
        {
            f.btnCreateManager.Enabled = true;
            f.btnCreateWorker.Enabled = true;
            f.btnCreateClient.Enabled = true;
            //  f.btnNext.Visible = true;
            //  f.btnPrevious.Visible = true;
            //  f.btnCancel.Visible = false;
        }  // end activateAddButtons


        // Enable/disable buttons when not in edit mode
        public static void deactivateAddButtons(frmEmpMan f)
        {
            f.btnCreateManager.Enabled = false;
            f.btnCreateWorker.Enabled = false;
            f.btnCreateClient.Enabled = false;
            //   f.btnNext.Visible = false;
            //  f.btnPrevious.Visible = false;
            //  f.btnCancel.Visible = true;
        }  // end deactivateAddButtons


        //  Enables Employee textboxes and highlights the Person groupbox
        public static void activatePerson(frmEmpMan f)
        {
            f.grpPerson.Enabled = true;
            f.grpPerson.BackColor = Color.LimeGreen;

        }  // end activatePerson


        //  Enables Employee textboxes and highlights the Employee groupbox
        public static void activateEmployee(frmEmpMan f)
        {
            activatePerson(f);
            f.grpEmployee.Enabled = true;
            f.grpEmployee.BackColor = Color.LimeGreen;
        }  // end ActivateEm[ployee


        // Enables Employee textboxes and highlights the Client groupbox
        public static void activateClient(frmEmpMan f)
        {
            activatePerson(f);
            f.grpClient.Enabled = true;
            f.grpClient.BackColor = Color.LimeGreen;
        }  // end activateClient


        // Enables Manager textboxes and highlights the Manager groupbox
        public static void activateManager(frmEmpMan f)
        {
            activateEmployee(f);   // Employee must be activated too
            f.grpManager.Enabled = true;
            f.grpManager.BackColor = Color.LimeGreen;
        }  // end activateManager


        // Enables Worker textboxes and highlights the Worker groupbox
        public static void activateWorker(frmEmpMan f)
        {
            activateEmployee(f);  // Employee must be activated too
            f.grpWorker.Enabled = true;
            f.grpWorker.BackColor = Color.LimeGreen;
        }  // end activateWorker


        // Disables Person textboxes and highlights the Person groupbox
        public static void deactivatePerson(frmEmpMan f)
        {
            deactivateEmployee(f);   // Must deactivate Employee too
            deactivateClient(f);     // Must deactivate Client too
            f.grpPerson.Enabled = false;
            f.grpPerson.BackColor = Color.Red;
        }  // end deactivatePerson


        // Disables Employee textboxes and highlights the Employee groupbox
        public static void deactivateEmployee(frmEmpMan f)
        {
            deactivateManager(f);   // Must deactivate Manager too
            deactivateWorker(f);    // Must deactivate Worker too
            f.grpEmployee.Enabled = false;
            f.grpEmployee.BackColor = Color.Red;
        }  // end deactivateEmployee


        // Disables Client textboxes and highlights the Client groupbox
        public static void deactivateClient(frmEmpMan f)
        {
            f.grpClient.Enabled = false;
            f.grpClient.BackColor = Color.Red;
        }  // end deactivateClient


        // Disables Manager textboxes and highlights the Manager groupbox
        public static void deactivateManager(frmEmpMan f)
        {
            f.grpManager.Enabled = false;
            f.grpManager.BackColor = Color.Red;
        }  // end deactivateManager


        // Disables Worker textboxes and highlights the Worker groupbox
        public static void deactivateWorker(frmEmpMan f)
        {
            f.grpWorker.Enabled = false;
            f.grpWorker.BackColor = Color.Red;
        }  // end deativateWorker


        // Clear all textboxes on the form
        public static void clear(frmEmpMan f)
        {
            f.txtPersonName.Text = "";
            f.txtPersonBirthDate.Text = "";
            f.txtPersonID.Text = "";
            f.txtClientType.Text = "";
            f.txtEmployeeJobTitle.Text = "";
            f.txtManagerSalary.Text = "";
            f.txtManagerBonus.Text = "";
            f.txtWorkerHourlyPay.Text = "";
        } // end Clear

    }  // end FormController class
}  // end namespace


