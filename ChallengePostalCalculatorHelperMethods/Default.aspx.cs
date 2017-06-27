using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void checkChanged(object sender, EventArgs e)
        {
            // Do the values in text and checked exist
            if (!valuesExist()) return;

            // Volume of container
            int volume = 0;
            // Test if text can be parsed to int
            if (!tryGetVolume(out volume)) return;

            // Multiplied by
            double postageMultiplier = getPostageMultiplier();

            // Cost 
            double cost = volume * postageMultiplier;

            
            resultLabel.Text = String.Format("Your parcel will cost {0:C} to ship.", cost);
        }

        // check if boxes are checked or not
        private bool valuesExist()
        {
            // wont perform w/o a buttom checked
            if (!airRadioButton.Checked
                && !groundRadioButton.Checked
                && !nextDayRadioButton.Checked)
                return false;
            // performs check and now can use numbers to put in volumn
            if (widthTextBox.Text.Trim().Length == 0
                || heightTextBox.Text.Trim().Length == 0)
                return false;

            return true;
        }


        // Set L/W/H  needs to return true (values match up) to perfom task
        private bool tryGetVolume(out int volume)
        {
            volume = 0;
            int width = 0;
            int height = 0;
            int length = 0;

            // Checking to see if has intigers that can be evaluated to find Volume
            if (!int.TryParse(widthTextBox.Text.Trim(), out width)) return false;
            if (!int.TryParse(heightTextBox.Text.Trim(), out height)) return false;
            if (!int.TryParse(lengthTextBox.Text.Trim(), out length)) length = 1;

            volume = width * height * length;
            return true;
        }
         //Postage Multiplyer w/$ tied to Radio Buttons
        private double getPostageMultiplier()
        {
            if (groundRadioButton.Checked) return .15;
            else if (airRadioButton.Checked) return .25;
            else if (nextDayRadioButton.Checked) return .45;
            else return 0;
        }

    }
}