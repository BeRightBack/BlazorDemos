namespace BlazorLayoutDemo.Entity;

public class Image
{
    public Guid Id { get; set; }
    public string? FileName { get; set; }
    public byte[]? ImageStored { get; set; }
    public string? Path { get; set; }
    public string? ResizedPath { get; set; }
    public string? ThumbnailPath { get; set; }

    internal static object Load(FileStream input)
    {
        throw new NotImplementedException();
    }
}
