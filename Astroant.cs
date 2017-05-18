using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quadient_Hires
{
    public class Astroant
    {
        //Private variables
        private int colonyColor;
        private string name;

        //public constructor with 2 parameters - color of colony and astroant's name
        public Astroant(int color, string name)
        {
            setAstroantsColor(color);
            setName(name);
        }
        //Constructor with parameters - size of the army and its color
        public Astroant(int color)
        {
            //define a color of this army
            setAstroantsColor(color);
        }

        //public method to set value of private variable color
        public void setAstroantsColor(int color)
        {
            this.colonyColor = color;
        }

        //public method to get value of private variable color
        public int getAstroantsColor()
        {
            return this.colonyColor;
        }

        //public method to set value of private variable name
        public void setName(string name)
        {
            this.name = name;
        }

        //public method to get value of private variable name
        public string getName()
        {
            return this.name;
        }
        
    }
}
