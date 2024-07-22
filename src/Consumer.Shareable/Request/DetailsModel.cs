namespace Consumer.Shareable.Request
{
    public class DetailsModel 
    {
    
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Details { get; set; }
        public DateOnly Date { get; set; } = DateOnly.FromDateTime( DateTime.UtcNow );

        public TimeOnly Time  { get; set; } = TimeOnly.FromDateTime(DateTime.UtcNow);
    }

}
