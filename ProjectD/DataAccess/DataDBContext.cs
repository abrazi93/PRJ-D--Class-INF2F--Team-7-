using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;

namespace DataAccess
{
    public class DataDbContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<TrainingSchedule> TrainingSchedules { get; set; }
        public DbSet<Measurement> Measurements {get; set;}
        public DbSet<Cycling> Cyclings { get; set; }
        public DbSet<RopeSkipping> RopeSkippings { get; set; }
        public DbSet<Running> Runnings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        }
        public class Profile
        {

        }
        public class TrainingSchedule
        {

        }
        public class Measurement
        {

        }
        public class Cycling
        {

        }
        public class RopeSkipping
        {

        }
        public class Running
        {

        }
    }

}
