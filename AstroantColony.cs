using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quadient_Hires
{
    public class AstroantColony
    {
        private int colonyColor;
        private List<Astroant> colony;

        //constructor to create a colony of astroants, first parameter is the size of the colony, second parameter is a color of this colony 
        public AstroantColony(int colonySize, int color)
        {
            //define a color of this army
            setColonyColor(color);

            //create new empty colony
            this.colony = new List<Astroant>();

            //create members of this colony
            for (int i = 0; i < colonySize; i++)
            {
                colony.Add(new Astroant(color, "Astroant" + i));
            }
        }

        //constructor without parameters
        public AstroantColony()
        {
            //create new empty colony
            this.colony = new List<Astroant>();
        }

        //set color of this colony
        private void setColonyColor(int color)
        {
            this.colonyColor = color;
        }

        // get color of this colony
        public int getColonyColor()
        {
            return this.colonyColor;
        }

        //get a member of this colony at specific position
        public Astroant getColonyMember(int position)
        {
            return this.colony.ElementAt(position);
        }

        //return this colony
        public List<Astroant> getColony()
        {
            return this.colony;            
        }

        //Swap two and at specific positions
        public void swapAnts(int pos1, int pos2)
        {
            Astroant tempAnt;
            tempAnt = this.colony.ElementAt(pos1);
            this.colony[pos1] = this.colony.ElementAt(pos2);
            this.colony[pos2] = tempAnt;
        }

        //Add whole colony to current colony
        public void addColony(List<Astroant> list)
        {
            this.colony.AddRange(list);            
        }

        //get size of this colony
        public int getColonySize()
        {
            return this.colony.Count;
        }

        //static method to print each member of given colony
        public static void printColony(AstroantColony colony)
        {
            
            for (int i = 0; i < colony.getColonySize(); i++)
            {
                Console.Write(colony.getColonyMember(i).getAstroantsColor());
            }

        }

        //move the colony if possible
        public void move(int numberOfSteps, AstroantColony colony)
        {
            for (int i = 0; i < numberOfSteps; i++ )
            {

                for (int j = 0; j < colony.getColonySize()-1; j++)
                {
                    if ((colony.getColonyMember(j).getAstroantsColor() != colony.getColonyMember(j + 1).getAstroantsColor()) && colony.getColonyMember(j).getAstroantsColor() == 0)
                    {
                        colony.swapAnts(j, j + 1);
                        j++;
                    }
                }
            }


        }

    }
}
