using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car();
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
            
            
            

        }
    }
}
