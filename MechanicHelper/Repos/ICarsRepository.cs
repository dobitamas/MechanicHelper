using MechanicHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicHelper.Repos
{
    public interface ICarsRepository
    {
        Car GetCar(Guid id);

        IQueryable<Car> GetAllCars();

        Car Add(Car car);

        Car Update(Car carChanges);

        Car Delete(Guid id);
    }
}