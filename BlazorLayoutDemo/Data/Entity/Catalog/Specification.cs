namespace BlazorLayoutDemo.Entity;
public class Specification
{
    public Guid Id { get; set; }

    public string? Name { get; set; }
    public string? Description { get; set; }
    public int Position { get; set; }

    public bool Published { get; set; }
    public DateTime DateAdded { get; set; }
    public DateTime DateModified { get; set; }
}
