using System.Reflection.Metadata;

namespace ToDoList;

class TodoLists
{
    private string? Title;
    private string? Content;
    private string? Priority;
    private int Id;

    public TodoLists(){}

    public TodoLists(string? Title, string? Content, string? Priority, int Id)
    {
        this.Title=Title;
        this.Content=Content;
        this.Priority=Priority;
        this.Id=Id;
    }

    public string? Title1 { get => Title; set => Title = value; }
    public string? Content1 { get => Content; set => Content = value; }
    public string? Priority1 { get => Priority; set => Priority = value; }
    public int Id1 { get => Id; set => Id = value; }
}