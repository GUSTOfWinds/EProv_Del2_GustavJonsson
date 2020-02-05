using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv_Del2_GustavJonsson
{
    class Car
    {
        //Public variables to make sure the rest of the code block function
        public Random randomgenerator = new Random();
        public int passangers = 0;
        public int contrabandamount = 0;
        public bool alreadyChecked = false;

        //This method examines a car, and returns a result based on if it "contains contraband" or not, with lowered chances with lower amounts of contraband within the car
        public bool Examine()
        {
            alreadyChecked = true;
            if (contrabandamount == 0)
            {
                return false;
            }
            else
            {
                int contraCheck = randomgenerator.Next(0, 6);

                if (contraCheck >= contrabandamount)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}