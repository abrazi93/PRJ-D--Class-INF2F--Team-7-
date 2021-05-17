using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Configuration;


namespace DataAccess
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options){}
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<TrainingSchedule> TrainingSchedules { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<Cycling> Cyclings { get; set; }
        public DbSet<RopeSkipping> RopeSkippings { get; set; }
        public DbSet<Running> Runnings { get; set; }

        public class Profile
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime DOB { get; set; }
            public int Height { get; set; }
            public int Weight { get; set; }
            public string Gender { get; set; }
            public int TrDays { get; set; }
        }
        public class TrainingSchedule
        {
            public int Id { get; set; }
            public string CardioTraining { get; set; }
            public int DaysN { get; set; }
            public int ProfileId { get; set; }
        }
        public class Measurement
        {
            public int Id { get; set; }
            public int MaxHR { get; set; }
            public int RestHR { get; set; }
            public int Vo2Max { get; set; }
            public int ProfileId { get; set; }
        }
        public class Cycling
        {
            public int Id { get; set; }
            public string CardioTraining { get; set; }
            public int DaysN { get; set; }
            public int KM { get; set; }
            public int TrainingScheduleId { get; set; }
        }
        public class RopeSkipping
        {
            public int Id { get; set; }
            public string CardioTraining { get; set; }
            public int DaysN { get; set; }
            public int TrainingScheduleId { get; set; }
        }
        public class Running
        {
            public int Id { get; set; }
            public string CardioTraining { get; set; }
            public int DaysN { get; set; }
            public int KM { get; set; }
            public int TrainingScheduleId { get; set; }
        }
    }

}
