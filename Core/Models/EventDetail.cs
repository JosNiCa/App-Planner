

namespace App_Planner.Core.Models;

public class EventDetail
{
    public int EventDetailID { get; set; }
    public int EventID { get; set; }    
    public string Details { get; set; }
    public int StatusID { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    
    public Event Event { get; set; }
    public Status Status { get; set; }
}