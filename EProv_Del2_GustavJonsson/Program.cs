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
            //These variables are necessary for the following block of code to function correctly
            Random random = new Random();
            bool startCreation = false;
            bool wasConverted = false;
            int carMaker = 0;
            string carCreator;

            //This block of code checks the user-input, and makes sure that the input is "correct" and will not crash when put into the rest of the program. Forces repeats on failures
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


            //This block of code creates a list, and adds cars onto that list based on user input.
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

            //This block of code asks the user which car to check, and returns relevant results depending on random chance using the class functionalities
            Console.WriteLine("Vilken bil vill du titta på? Svara med en siffra");
            //METOD: KONTROLLERA ANVÄNDARE-INPUT
            //METOD: ANVÄND EXAMINE-METOD PÅ RELEVANT BIL ELLER BE OM EN KORREKT INPUT
        }
    }
}