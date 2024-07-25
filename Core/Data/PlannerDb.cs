using App_Planner.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace App_Planner.Core.Data;

public class PlannerDb : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<EventCategory> EventCategories { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<EventDetail> EventDetails { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=planner.db");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User { UserID = 1, UserName = "admin", Password = "admin" }
        );
        
        modelBuilder.Entity<Status>().HasData(
            new Status { StatusID = 1, StatusName = "Pending", StatusDescription = "Event is pending" },
            new Status { StatusID = 2, StatusName = "Completed", StatusDescription = "Event is completed" },
            new Status { StatusID = 3, StatusName = "Cancelled", StatusDescription = "Event is cancelled" }
        );
        
        modelBuilder.Entity<EventCategory>().HasData(
            new EventCategory { CategoryID = 1, CategoryName = "Meeting", CategoryDescription = "Meeting with team" },
            new EventCategory { CategoryID = 2, CategoryName = "Training", CategoryDescription = "Training session" },
            new EventCategory { CategoryID = 3, CategoryName = "Seminar", CategoryDescription = "Seminar event" }
        );
    }
}