using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv_Del2_GustavJonsson
{
    class CleanCar : Car
    {
        //Simple constructor that follows the project guideline.
        public CleanCar()
        {
            passangers = randomgenerator.Next(1, 4);
            contrabandamount = 0;
        }
    }
}