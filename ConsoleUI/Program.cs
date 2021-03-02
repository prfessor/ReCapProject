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

            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine(item.Description);
            //}
            //var getCarDetails = carManager.GetCarDetails();
            //foreach (var item in getCarDetails.Data)
            //{
            //    Console.WriteLine(item.CarName + " " + item.BrandName + " " + item.ColorName + " " + item.DailyPrice);
            //}
            //Console.WriteLine(getCarDetails.Message);


            foreach (var item in carManager.GetAll().Data)
            {
                Console.WriteLine(item.Description);
            }
            


        }
    }
}
