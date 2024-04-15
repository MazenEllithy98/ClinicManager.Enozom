using ClinicManager.Enozom.Core.Entities;
using ClinicManager.Enozom.Core.Repositories.Contract;
using ClinicManager.Enozom.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Enozom.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly StoreContext _dbContext;

        public GenericRepository(StoreContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            if (entity is Doctor doctor)
            {
                _dbContext.Set<Doctor>().Add(new Doctor
                {
                    Name = doctor.Name,
                    Availabilities = doctor.Availabilities.Select(a => new Availability
                    {
                        DayOfWeek = a.DayOfWeek,
                        StartTime = a.StartTime,
                        EndTime = a.EndTime,
                        DoctorId = 0 // set DoctorId to 0 or null
                    }).ToList()
                });
            }
            else
            {
                _dbContext.Set<T>().Add(entity);
            }

            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            if (typeof(T) == typeof(Doctor))
                return (IEnumerable<T>)await _dbContext.Set<Doctor>().Include(D => D.Availabilities).ToListAsync();
            return await _dbContext.Set<T>().ToListAsync();

        }

        public async Task<T?> GetAsync(int id)
        {
            if (typeof(T) == typeof(Doctor))
            {
                var doctor = await _dbContext.Set<Doctor>().Include(d => d.Availabilities)
                    .FirstOrDefaultAsync(d => d.Id == id);
                if (doctor == null)
                {
                    return null;
                }
                // set the Id property of the Doctor entity to the generated value
                doctor.Id = id;
                return (T)(object)doctor;
            }
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }

    }
}
