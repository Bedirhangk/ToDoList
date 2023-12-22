namespace ToDoList;

class Staff
{
    private int person_ID;
    private string? person_Name;
    private string? person_Surname;

    public Staff(){}

    public Staff(int Id, string Name, string Surname)
    {
        this.person_ID=Id;
        this.person_Name=Name;
        this.person_Surname=Surname;
    }

    public int Person_ID { get => person_ID; set => person_ID = value; }
    public string? Person_Name { get => person_Name; set => person_Name = value; }
    public string? Person_Surname { get => person_Surname; set => person_Surname = value; }

    public static void showstaff(List<Staff> a)
    {
        foreach (var item in a)
        {
            Console.WriteLine("Name     : "+item.person_Name);
            Console.WriteLine("Surname  : "+item.person_Surname);
            Console.WriteLine("ID       : "+item.person_ID);
            Console.WriteLine();
        }
    }
}