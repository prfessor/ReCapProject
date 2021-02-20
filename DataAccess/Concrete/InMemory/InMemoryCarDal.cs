using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDeleted = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDeleted);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.BrandId == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car updatingCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            updatingCar.BrandId = car.BrandId;
            updatingCar.DailyPrice = car.DailyPrice;
            updatingCar.Description = car.Description;
            updatingCar.ModelYear = car.ModelYear;
        }


    }


}
