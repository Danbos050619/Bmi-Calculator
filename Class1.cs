using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi_Calc
{ 
    //skapar en internal class som heter calculate, klassen tar float height och weight och med hjälp av funktionen CalculateBMI returnerar vikten/(längd^2)
    internal class Calculate

    {
        private float Weight;
        private float Height;

        public void setHeight(float He) { Height = He; }
        public float getHeight() { return this.Height; }
        public void setWeight(float We) { this.Weight = We; }
        public float getWeight() { return this.Weight; }
        public float CalculateBMI()
        {
            return Weight / (Height * Height);
        }

    }
}
