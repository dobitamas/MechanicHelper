using MechanicHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicHelper.Repos
{
    public class SQLCarsRepository : ICarsRepository
    {
        private readonly MechanicDbContext context;

        public SQLCarsRepository(MechanicDbContext context)
        {
            this.context = context;
        }

        public Car Add(Car car)
        {
            context.Cars.Add(car);
            context.SaveChanges();
            return car;
        }

        public Car Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public ICarsRepository GetCar(int id)
        {
            throw new NotImplementedException();
        }

        public Car Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}