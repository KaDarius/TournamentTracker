using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ///added using TrackerLibrary; (ctrl+.), <list>PrizeModel</list>
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text, 
                    placeNumberValue.Text, 
                    prizeAmountValue.Text, 
                    prizePercentageValue.Text);


                ///List of Idataconnection
               foreach(IDataConnection db in GlobalConfig.Connections)
               {
                    db.CreatePrize(model);
               }

                placeNameValue.Text = "";
                placeNumberValue.Text = ""; 
                ///default text in forms is set to 0
                prizeAmountValue.Text="0";
                prizePercentageValue.Text = "0";

                ///created prizemodel constructor in my CreatePrizeForm
            }
            //creates error message in an instance value returns anything but true
            else
            {
                MessageBox.Show("This form has invalid information. Please try again!");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
           
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            ///users input will return a string and not a value OR int. TryParse to take in string
            ///if (int.TryParse(placeNameValue.Text, out placeNumber ))
            ///int.TryParse takes the string coming from placeNumber and reverses it to text and outputs a place number

            if (!placeNumberValidNumber)
            {
                output = false;
            }
            if(placeNumber < 1)
            {
                output = false;
            }

            // basically saying any text less than 0 characters in placeName is invalid
            if (placeNameValue.Text.Length==0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            float prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = float.TryParse(prizeAmountValue.Text, out prizePercentage);

            /// do them both because they both have to be a valid number, that way if either one is invalid
            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            
            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            
            if (prizePercentage < 0 || prizePercentage>100)
            {
                output = false;
            }
            return output; 
        }
    }
}
