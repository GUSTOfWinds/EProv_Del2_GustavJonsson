using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv_Del2_GustavJonsson
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool startCreation = false;
            bool wasConverted = false;
            int carMaker = 0;
            string carCreator;

            while (startCreation == false)
            {
                Console.WriteLine("Hur många bilar ska skapas? Skriv in ett nummer som är minst 1");
                carCreator = Console.ReadLine();
                wasConverted = int.TryParse(carCreator, out carMaker);
                if (carMaker >= 1 && wasConverted == true)
                {
                    startCreation = true;
                }
            }





            int creationCounter = 0;
            int carPicker = 0;

            List<Car> CarList = new List<Car>();

            while (creationCounter <= carMaker)
            {
                creationCounter++;

                carPicker = random.Next(2);
                if (carPicker == 0)
                {
                    CleanCar ACar = new CleanCar();
                    CarList.Add(ACar);
                }
                if (carPicker == 1)
                {
                    ContrabandCar ACar = new ContrabandCar();
                    CarList.Add(ACar);
                }
            }
            Console.WriteLine("Vilken bil vill du titta på? Svara med en siffra");


        }
    }
}