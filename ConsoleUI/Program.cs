using System;
using Business.Concrete;
using DataAccess.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            foreach (var car in carManager.GetByModelYear(2010))
            {
                Console.WriteLine(car.ModelYear);
            }
            
            foreach (var car in carManager.GetByDailyPrice(100, 900))
            {
                Console.WriteLine(car.DailyPrice);
            }

        }
    }
}
