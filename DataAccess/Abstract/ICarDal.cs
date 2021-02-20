using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal: IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
    }
}
