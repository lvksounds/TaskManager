namespace TaskManaerAPI.Models
{
    public class Task
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ConclusionDate { get; set; }
        public string Status { get; set; }

    }    
}
