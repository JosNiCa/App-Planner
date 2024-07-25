

namespace App_Planner.Core.Models;

public class Event
{
    public int EventID { get; set; }
    public int UserID { get; set; }
    public string EventName { get; set; }
    public int CategoryID { get; set; }
    public DateTime Date { get; set; }
    
    public User User { get; set; }
    public EventCategory Category { get; set; }
}