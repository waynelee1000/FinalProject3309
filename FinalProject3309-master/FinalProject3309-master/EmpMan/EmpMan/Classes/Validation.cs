using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

//Validation class
//Contains all methods for validating input data of all textboxes
namespace EmpMan.Classes
{
    class Validation
    {
        //constructor
        public Validation()
        {

        }// end constructor

        //validation for txtPersonName txtClientType txtEmployeeJobTitle
        //Accepts only letters or letters and spaces
        //cannot be blank
        public Boolean checkName(string s)
        {
            string[] Characters = new string[] { "`", "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+", "[", "{", "]", "}", ";", ":", "'", ",", "<", ".", ">", "/", "?", " " };
            if (Characters.Any(c => s.Contains(c))) //check for special characters
            {
                //MessageBox.Show("name is special character");
                return false;
            }
            else if (s.Any(c => char.IsDigit(c))) //check for numbers
            {
                //MessageBox.Show("name is number");
                return false;
            }
            else if (s == "") //check if is blank
            {
                //MessageBox.Show("name is blank");
                return false;
            }
            else
            {
                return true;
            }
        } // end checkName

        //validation for txtPersonBirthDate
        //must be in format of month day year
        //date must be in range from 01/01/1900 to yesterday(cannot be today)
        //cannot be blank
        public Boolean checkBirthDate(string s)
        {
            string[] characters = new string[] { "`", "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+", "[", "{", "]", "}", ";", ":", "'", ",", "<", ".", ">", "?", " " };
            if (characters.Any(c => s.Contains(c))) //check for special characters
            {
                //MessageBox.Show("special character");
                return false;
            }
            else if (s.Any(c => char.IsLetter(c))) //check for letters
            {
                //MessageBox.Show("letter");
                return false;
            }
            else if (s == "") //check if is blank
            {
                //MessageBox.Show("blank");
                return false;
            }
            else
            {
                int month;
                int date;
                int year;

                if (s.Contains("/")) //if input contains "/"
                {
                    if (s.Length != 10)
                    {
                        //MessageBox.Show("/too short");
                        return false;
                    }
                    else
                    {
                        month = Convert.ToInt16(s.Substring(0, 2));
                        date = Convert.ToInt16(s.Substring(3, 2));
                        year = Convert.ToInt16(s.Substring(6, 4));
                    }
                }
                else
                {
                    if (s.Length != 8)
                    {
                        //MessageBox.Show("too short");
                        return false;
                    }
                    else
                    {
                        month = Convert.ToInt16(s.Substring(0, 2));
                        date = Convert.ToInt16(s.Substring(2, 2));
                        year = Convert.ToInt16(s.Substring(4, 4));
                    }
                }
                if (month < 1 || month > 12) //check if month is valid
                {
                    //MessageBox.Show("month");
                    return false;
                }
                else if (year < 1900 || year > DateTime.Now.Year) //check if year is valid
                {
                    //MessageBox.Show("year");
                    return false;

                    //check if day is valid according to month
                }
                else if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && (date < 1 || date > 31))
                {
                    //MessageBox.Show("wrong 31");
                    return false;
                }
                else if ((month == 4 || month == 6 || month == 9 || month == 11) && (date < 1 || date > 30))
                {
                    //MessageBox.Show("wrong 30");
                    return false;
                }
                else if ((month == 2) && (year % 4 == 0) && (date != 29))
                {
                    //MessageBox.Show("wrong 29");
                    return false;
                }
                else if ((month == 2) && (year % 4 != 0) && (date != 28))
                {
                    //MessageBox.Show("wrong 28");
                    return false;
                }
                else
                {
                    DateTime dt = new DateTime(year, month, date);
                    DateTime start = new DateTime(1900, 01, 01);
                    DateTime end = DateTime.Now.AddDays(-1);
                    if (dt.Ticks > start.Ticks && dt.Ticks < end.Ticks) //if date is in valid range 
                    {
                        //MessageBox.Show(dt.ToString());
                        return true;
                    }
                    else
                    {
                        //MessageBox.Show("out of range");
                        return false;
                    }
                }
            }// end else
        }// end checkBirthDate  

        //validation for txtPersonID
        //accept only integers
        //cannot be blank
        public Boolean checkID(string s)
        {
            if (s == "")
            {
                //MessageBox.Show("blank");
                return false;
            }
            else if (s.Any(c => char.IsDigit(c)) == false)
            {
                //MessageBox.Show("special character");
                return false;
            }
            else
            {
                //MessageBox.Show("valid");
                return true;
            }
        }// end checkID

        //validation for txtManagerSalary txtManagerBonus txtWorkerHourlyPay
        //must be decimal number
        //accept "$" and "." no other special characters
        //cannot be blank
        public Boolean checkMoney(string s)
        {
            string[] characters = new string[] { "`", "~", "!", "@", "#", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+", "[", "{", "]", "}", ";", ":", "'", ",", "<", ">", "?", " " };
            if (s == "") //check if is blank
            {
                //MessageBox.Show("blank");
                return false;
            } else if (characters.Any(c => s.Contains(c))) //check for special characters
            {
                //MessageBox.Show("special character");
                return false;
            } else
            {
                if (s.Contains("$")) //if input contains "$"
                {
                    s = s.Remove(0, 1);
                }
                decimal d;
                if(decimal.TryParse(s, out d)) //check if is decimal
                {
                    //MessageBox.Show(d.ToString());
                    return true;
                }else
                {
                    //MessageBox.Show("not decimal");
                    return false;
                }
            }
        }//end checkMoney
      }// end class
    }// end namespace
