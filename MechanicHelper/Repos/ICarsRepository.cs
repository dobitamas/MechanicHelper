using MechanicHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicHelper.Repos
{
    public interface ICarsRepository
    {
        ICarsRepository GetCar(int id);

        IEnumerable<Car> GetAllCars();

        Car Add(Car car);

        Car Update(Car car);

        Car Delete(int id);
    }
}