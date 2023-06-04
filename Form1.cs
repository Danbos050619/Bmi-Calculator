using System.Diagnostics;

using System.Globalization;


namespace Bmi_Calc

  
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculate calc = new Calculate();
        //en lista som sparar bmi resultaten 
        List<string> history = new List<string>();
        //Vid buttoncalculateclick så kommer det med hjälp av klassen calculate räkna ut bmi
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            float Weight;
            float Height;
            if(float.TryParse(textWeight.Text, out Weight))
            {
                calc.setWeight(Weight);
            }

            if (float.TryParse(textHeight.Text, out Height))
            {
                calc.setHeight(Height);
            }

            else MessageBox.Show("Invalid input, please try again.");
            //visar en messagebox med name + your bmi is + klassen calculate som räknar ut funktionen calculatebmi()
            MessageBox.Show(textName.Text + " your BMI is: " + calc.CalculateBMI());
            //history
            history.Add(calc.CalculateBMI().ToString());


        }
        // vid buttonExit Click så kommer hela window stängas ner.
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // vid buttonReset click så kommer vikt, längd, namn försvinna med hjälp av "" , listan history kommer även att Clear
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textHeight.Text = "";
            textWeight.Text = "";
            textResult.Text = "";
            textName.Text = "";
            history.Clear();

            
        }
        // vid showHistory click visas historiken med hjälp av for loop, string printout och messagebox
        private void showHistory_Click(object sender, EventArgs e)
        {

            string printout = "";
            for (int i = 0; i < history.Count; i++)
            { //printar + historik listans element och konvertar det till string, \n betyder att new line. Samt sparar alla värden från printout i en txt fil som sedan delas i en synkad mapp på drive.
                printout += history[i].ToString() +"\n";
                MessageBox.Show(printout);
                File.WriteAllText("G:/Min enhet/BMI.data.txt", printout);
            }
            
        }

    }
}
