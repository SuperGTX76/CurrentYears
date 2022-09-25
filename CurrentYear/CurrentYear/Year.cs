using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentYear
{
    class Year
    {
        
        private static void Main()
        {
            int year;


            
            year = GetCurrentYear();
            Console.WriteLine("Хай!!!");
            Console.WriteLine("Нынче у нас уже " + year + "год!!!");
            Console.WriteLine("Ну, и значится - надо по маленькой :)");

        }

        private static int GetCurrentYear()
        {
            int god =(int)DateTime.Now.Year;
            return god;
        }
    }
}