using ClinicManager.Enozom.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Enozom.Repository.Data
{
    public class StoreContextSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Doctor>().HasData(
                    new Doctor
                    {
                        Id = 1,
                        Name = "Mohamed",
                    },
                    new Doctor
                    {
                        Id = 2,
                        Name = "Ahmed",
                    });
            modelBuilder.Entity<Availability>().HasData(
                    new Availability
                    {
                        Id = 1,
                        DayOfWeek = DaysOfWeek.Monday,
                        StartTime = "9:00",
                        EndTime = "13:00",
                        DoctorId = 1,
                    },
                    new Availability
                    {
                        Id= 2,
                        DayOfWeek = DaysOfWeek.Monday,
                        StartTime = "2:00",
                        EndTime = "18:00",
                        DoctorId = 1,
                    },
                    new Availability
                    {

                        Id = 3,
                        DayOfWeek = DaysOfWeek.Tuesday,
                        StartTime = "9:00",
                        EndTime = "13:00",
                        DoctorId = 1,
                    },
                    new Availability
                    {
                        Id = 4,
                        DayOfWeek = DaysOfWeek.Tuesday,
                        StartTime = "2:00",
                        EndTime = "18:00",
                        DoctorId = 1,
                    },
                    new Availability
                    {

                        Id = 5,
                        DayOfWeek = DaysOfWeek.Tuesday,
                        StartTime = "20:00",
                        EndTime = "21:00",
                        DoctorId = 1,
                    },
                    new Availability
                    { 
                        Id = 6,
                        DayOfWeek = DaysOfWeek.Wednesday,
                        StartTime = "9:00",
                        EndTime = "13:00",
                        DoctorId = 1,
                    },
                    new Availability
                    {
                        Id = 7,
                        DayOfWeek = DaysOfWeek.Wednesday,
                        StartTime = "02:00",
                        EndTime = "18:00",
                        DoctorId = 1,
                    },
                    new Availability
                    {

                        Id = 8,
                        DayOfWeek = DaysOfWeek.Thursday,
                        StartTime = "02:00",
                        EndTime = "18:00",
                        DoctorId = 1,
                    },
                    new Availability
                    {
                        Id = 9,
                        DayOfWeek = DaysOfWeek.Friday,
                        StartTime = "9:00",
                        EndTime = "13:00",
                        DoctorId = 1,
                    },
                    new Availability
                    {
                        Id = 10,
                        DayOfWeek = DaysOfWeek.Monday,
                        StartTime = "9:00",
                        EndTime = "17:00",
                        DoctorId = 2,
                    },
                    new Availability
                    {
                        Id = 11,
                        DayOfWeek = DaysOfWeek.Tuesday,
                        StartTime = "9:00",
                        EndTime = "13:00",
                        DoctorId = 2,
                    },
                    new Availability
                    {
                        Id = 12,
                        DayOfWeek = DaysOfWeek.Tuesday,
                        StartTime = "20:00",
                        EndTime = "21:00",
                        DoctorId = 2,
                    },
                    new Availability
                    {
                        Id = 13,
                        DayOfWeek = DaysOfWeek.Thursday,
                        StartTime = "02:00",
                        EndTime = "18:00",
                        DoctorId = 2,
                    },
                    new Availability
                    {
                        Id = 14,
                        DayOfWeek = DaysOfWeek.Friday,
                        StartTime = "09:00",
                        EndTime = "13:00",
                        DoctorId = 2,
                    });

        }
               }
                    
         }
 
