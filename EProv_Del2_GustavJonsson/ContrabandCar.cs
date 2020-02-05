using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv_Del2_GustavJonsson
{
    class ContrabandCar : Car
    {
        //Simple constructor that follows the project guideline.
        public ContrabandCar()
        {
            passangers = randomgenerator.Next(1, 5);
            contrabandamount = randomgenerator.Next(1, 5);
        }
    }
}