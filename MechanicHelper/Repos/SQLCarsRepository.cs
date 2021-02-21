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

        public Car Delete(string id)
        {
            Car car = context.Cars.Find(id);

            if (car != null)
            {
                context.Cars.Remove(car);
                context.SaveChanges();
            }

            return car;
        }

        public IQueryable<Car> GetAllCars()
        {
            return context.Cars;
        }

        public Car GetCar(string id)
        {
            return context.Cars.Find(id);
        }

        public Car Update(Car carChanges)
        {
            var car = context.Cars.Attach(carChanges);
            car.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return carChanges;
        }
    }
}