using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vavatech.PSI.WPF.IServices;
using Vavatech.PSI.WPF.Models;

namespace Vavatech.PSI.WPF.MockServices
{
    public class MockActivitiesService : IActivitiesService
    {
        private IList<Activity> entities = new List<Activity>();

        public MockActivitiesService(IEmployeesService employeesService)
        {
            Random random = new Random();

            entities = Enumerable.Range(1, 100)
              .Select(i => new Activity(i,
                    DateTime.Today.AddHours(random.Next(0, 8)),
                    DateTime.Today.AddHours(random.Next(9, 16)),
                    employeesService.Get(random.Next(1, 1000)),
                    (ActivityType) random.Next(0, 3),
                    new Location(random.Next(0,1000), random.Next(0, 400))
                )).ToList();

        }

        public IList<Activity> Get(Employee assigned)
        {
            return entities.Where(e => e.Assigned == assigned).ToList();
        }

        public void Add(Activity entity) => entities.Add(entity);

        public IList<Activity> Get()
        {
            // Thread.Sleep(TimeSpan.FromSeconds(3));
            return entities;
        }

        public Activity Get(int id) => entities.SingleOrDefault(e => e.Id == id);
        public void Remove(Activity entity) => entities.Remove(entity);
        public void Update(Activity entity) => throw new NotImplementedException();

        public Task<IList<Activity>> GetAsync()
        {
            return Task.Run(() => Get());
        }
    }
}
