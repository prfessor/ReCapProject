using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car>  _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { BrandId = 1, ColorId = 1, DailyPrice = 300, Description="TEMİZ DİZEL ARAÇ OPEL", Id = 121, ModelYear=2010  },
                new Car { BrandId = 2, ColorId = 1, DailyPrice = 600, Description = "MANUEL BENZİNLİ ARAÇ RENAULT", Id = 145, ModelYear = 2013 },
                new Car { BrandId = 3, ColorId = 2, DailyPrice = 800, Description = "2020 MODEL PEUGEOT", Id = 187, ModelYear = 2020 },
                new Car { BrandId = 4, ColorId = 2, DailyPrice = 1300, Description = "LPGLİ VOLKSWAGEN 2017", Id = 198, ModelYear = 2017 }
            };
        }
        

        public void Add(Car carEntity)
        {
            _cars.Add(carEntity);
        }

        public void Delete(Car carEntity)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(c => c.Id == carEntity.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car carEntity)
        {
            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == carEntity.Id);
            carToUpdate.BrandId = carEntity.BrandId;
            carToUpdate.ColorId = carEntity.ColorId;
            carToUpdate.DailyPrice = carEntity.DailyPrice;
            carToUpdate.Description = carEntity.Description;
            carToUpdate.ModelYear = carEntity.ModelYear;
            
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _cars.Where(c => c.DailyPrice>=min && c.DailyPrice<=max).ToList();           
        }

       

        public List<Car> GetByModelYear(int modelYear)
        {
            return _cars.Where(c => c.ModelYear == modelYear).ToList();
        }
    }


}
