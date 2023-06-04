using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi_Calc
{
    //validate class för att se att weight och height är positiva värden annars printas det ut felm
    public class Validator
    {

        public bool ValidateWeight(float Weight)
        {
            if (Weight <= 0)
            {
                MessageBox.Show("Invalid weight input. Weight must be a positive value.", "Input Error");
                return false;
            }

            return true;
        }

        public bool ValidateHeight(float Height)
        {
            if (Height <= 0)
            {
                MessageBox.Show("Invalid height input. Height must be a positive value.", "Input Error");
                return false;
            }

            return true;
        }
    }
}
