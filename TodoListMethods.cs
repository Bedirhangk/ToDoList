using System.Runtime.InteropServices;

namespace ToDoList;

public class TodoListMethods
{
    List <Staff> Person = new List<Staff>();
    List <TodoLists> ToDoLine = new List<TodoLists>();
    List <TodoLists> InProgressLine = new List<TodoLists>();
    List <TodoLists> DoneLine = new List<TodoLists>();
    

    public TodoListMethods()
    {
        Person.Add(new Staff(1,"Bedirhan","Gökkaya"));
        Person.Add(new Staff(2,"Selin","Gürtürk"));
        Person.Add(new Staff(3,"Yasemin Sude","Aktaş"));
        Person.Add(new Staff(4,"Büşra","Yön"));
        Person.Add(new Staff(5,"Umut Yasin","Gürtürk"));

        ToDoLine.Add(new TodoLists("Healty Life","Brush Your Teeth","L",1));
        InProgressLine.Add(new TodoLists("Make MONEY","find a job for money","XL",4));
        DoneLine.Add(new TodoLists("Travel","Come To Ankara","M",2));
    }

    public void ShowLines()
    {
        Console.WriteLine("*******************ToDo Line*******************");
        Console.WriteLine();
        foreach(var a in ToDoLine)
        {
            Console.WriteLine("Title        : "+a.Title1);
            Console.WriteLine("Content      : "+a.Content1);
            Console.WriteLine("Priority     : "+a.Priority1);
            Console.WriteLine("Duty Person  : "+Person[a.Id1-1].Person_Name);
            Console.WriteLine("--------------------------------------------------");
        }

        Console.WriteLine("*******************In Progress Line*******************");
        Console.WriteLine();
        foreach(var a in InProgressLine)
        {
            Console.WriteLine("Title        : "+a.Title1);
            Console.WriteLine("Content      : "+a.Content1);
            Console.WriteLine("Priority     : "+a.Priority1);
            Console.WriteLine("Duty Person  : "+Person[a.Id1-1].Person_Name);
            Console.WriteLine("--------------------------------------------------");
        }

        Console.WriteLine("*******************Done Line*******************");
        Console.WriteLine();
        foreach(var a in DoneLine)
        {
            Console.WriteLine("Title        : "+a.Title1);
            Console.WriteLine("Content      : "+a.Content1);
            Console.WriteLine("Priority     : "+a.Priority1);
            Console.WriteLine("Duty Person  : "+Person[a.Id1-1].Person_Name);
            Console.WriteLine("--------------------------------------------------");
        }
    }

    public void AddCard()
    {
        Console.Clear();

        string name,content;
        int chs,id=1,idenum=1;
        bool loop=true;
        
        Console.WriteLine("To-Do Line       --> 1");
        Console.WriteLine("In Progress Line --> 2");
        Console.WriteLine("Done Line        --> 3");
        //This Part Checking input
        while(true)
        {
            try
            {
                Console.Write("Which line do you want add card: ");
                chs=int.Parse(Console.ReadLine());
                if(chs<=3 || chs>=1)
                    break;
                else
                    Console.WriteLine("Dear User Please press a key between 1 to 3 (include 1 and 3)");
            }
            catch
            {
                Console.WriteLine("Please Just Numbers!!!");
            }
        }
        //This Part Redirecting input
        loop=true;
        switch (chs)
        {
            case 1:

                Console.Write("Card Title:");
                name=Console.ReadLine();
                
                Console.Write("Card Content:");
                content=Console.ReadLine();

                //this part checking Priorty input and takes user input.

                while(loop)
                {
                    try
                    {
                        Console.Write("Card Priorty (XS->1 S->2 M->3 L->4 XL->5):");
                        idenum=int.Parse(Console.ReadLine());
                        idenum=EnumPri.Range(idenum);
                        if(idenum!=0)
                            loop=false;
                        else
                            Console.WriteLine("Wrong Range. Pls input must be between 1 to 5");


                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Please just numbers");
                        Console.WriteLine();
                    }

                }

                //This Part Checking ID And Takes User İnput

                while(loop)
                {
                    try
                    {
                        Console.Write("Worker ID: ");
                        id=int.Parse(Console.ReadLine());
                        foreach (var item in Person)
                        {
                            if(item.Person_ID==id)
                                loop=false;
                        }
                        if(loop==true)
                            Console.WriteLine("Wrong ID");
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Please enter just number");
                        Console.WriteLine();
                    }
                } 
            
                EnumPri.Buyukluk d = (EnumPri.Buyukluk)idenum;
                ToDoLine.Add(new TodoLists(name,content,Enum.GetName(typeof(EnumPri.Buyukluk),d),id));          

                break;
            case 2:
                Console.Write("Card Title:");
                name=Console.ReadLine();
                
                Console.Write("Card Content:");
                content=Console.ReadLine();

                //this part checking Priorty input and takes user input.

                while(loop)
                {
                    try
                    {
                        Console.Write("Card Priorty (XS->1 S->2 M->3 L->4 XL->5):");
                        idenum=int.Parse(Console.ReadLine());
                        idenum=EnumPri.Range(idenum);
                        if(idenum!=0)
                            loop=false;
                        else
                            Console.WriteLine("Wrong Range. Pls input must be between 1 to 5");


                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Please just numbers");
                        Console.WriteLine();
                    }

                }

                //This Part Checking ID And Takes User İnput

                while(loop)
                {
                    try
                    {
                        Console.Write("Worker ID: ");
                        id=int.Parse(Console.ReadLine());
                        foreach (var item in Person)
                        {
                            if(item.Person_ID==id)
                                loop=false;
                        }
                        if(loop==true)
                            Console.WriteLine("Wrong ID");
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Please enter just number");
                        Console.WriteLine();
                    }
                } 
            
                EnumPri.Buyukluk a = (EnumPri.Buyukluk)idenum;
                InProgressLine.Add(new TodoLists(name,content,Enum.GetName(typeof(EnumPri.Buyukluk),a),id));          

                break;
            case 3:
                Console.Write("Card Title:");
                name=Console.ReadLine();
                
                Console.Write("Card Content:");
                content=Console.ReadLine();

                //this part checking Priorty input and takes user input.

                while(loop)
                {
                    try
                    {
                        Console.Write("Card Priorty (XS->1 S->2 M->3 L->4 XL->5):");
                        idenum=int.Parse(Console.ReadLine());
                        idenum=EnumPri.Range(idenum);
                        if(idenum!=0)
                            loop=false;
                        else
                            Console.WriteLine("Wrong Range. Pls input must be between 1 to 5");


                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Please just numbers");
                        Console.WriteLine();
                    }

                }

                //This Part Checking ID And Takes User İnput

                while(loop)
                {
                    try
                    {
                        Console.Write("Worker ID: ");
                        id=int.Parse(Console.ReadLine());
                        foreach (var item in Person)
                        {
                            if(item.Person_ID==id)
                                loop=false;
                        }
                        if(loop==true)
                            Console.WriteLine("Wrong ID");
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Please enter just number");
                        Console.WriteLine();
                    }
                } 
            
                EnumPri.Buyukluk b = (EnumPri.Buyukluk)idenum;
                DoneLine.Add(new TodoLists(name,content,Enum.GetName(typeof(EnumPri.Buyukluk),b),id));          

                break;
        }


    }

    public void MoveCard()
    {

    }
    public void UpdateCard()
    {

    }
    public void RemoveCard()
    {

    }

    
}