namespace NewsWebAPI;

public class News
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public DateTime Date { get; set; }
    public string Image { get; set; }
    public string Category { get; set; }
    public string Author { get; set; }


}
