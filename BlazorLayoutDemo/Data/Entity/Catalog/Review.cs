namespace BlazorLayoutDemo.Entity;

public class Review
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public Guid ProductId { get; set; }
    public string Title { get; set; }
    public string Message { get; set; }
    public int Rating { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime DateModified { get; set; }
}
