
namespace C_lesson9Generic.Models;

public class DocumentProgram : IDisposable
{
    public DocumentProgram() { }
    public Guid Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public DateTime Created { get; set; }
    public string Title { get; set; }
    public virtual void EditDocument()
    {
        
            Console.WriteLine("Can Edit in Pro and Expert versions");
        

    }
    public virtual void SaveDocument()
    {
        Console.WriteLine("Can Save in Pro and Expert versions");


    }
    public void OpenDocument()
    {
        Console.WriteLine("Document Opened");

    }
    public DocumentProgram(string name, string description, string author, DateTime created, string title)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Author = author;
        Created = created;
        Title = title;

    }


    public virtual void Show()
    {
        Console.WriteLine($"Id: {Id}\n" +
               $"Name: {Name}\n" +
               $"Description: {Description}\n" +
               $"Author: {Author}\n" +
               $"Created: {Created.Hour}/ { Created.Minute} /{ Created.Second}\n" +
               $"Title: {Title}\n");
    }

    public void Dispose()
    {
        Console.WriteLine("End ");
    }
}
