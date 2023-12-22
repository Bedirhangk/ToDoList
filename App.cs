namespace ToDoList;

class App
{
    public void Run()
    {
        TodoListMethods a =new TodoListMethods();
        int choose;
        while(true)
        {
            Console.Clear();
            choose = menu();
            switch (choose)
            {
                case 1:
                    a.AddCard();
                    break;
                case 2:
                    a.RemoveCard();
                    break;
                case 3:
                    a.UpdateCard();
                    break;
                case 4:
                    a.ShowLines();
                    break;
                case 5:
                    a.MoveCard();
                    break;
                case 6:
                    Environment.Exit(0);
                    return;
            }
        }
    }

    int menu()
    {
        int Chs=0;
        bool test=true;

        Console.WriteLine("****************** Welcome Your ToDo List *********************");
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Please choose what do you want");
        Console.WriteLine("------------------------------");
        Console.WriteLine("Press One (1) For Add New Card");
        Console.WriteLine("Press Two (2) For Delete Card");
        Console.WriteLine("Press Three (3) For Uptade Card");
        Console.WriteLine("Press Four (4) For List Your ToDo Lines");
        Console.WriteLine("Press Five (5) For Move Card to Another line");
        Console.WriteLine("Press Six (6) For Exit");
        
        while(test)
        {
            try
        {
            Console.Write("Please Make Your Choose (Don't Forget Just Numbers :D): ");
            Chs=int.Parse(Console.ReadLine());
            if(Chs<1||Chs>6)
                Console.WriteLine("Ahhhh Dude it so simple. You need just press a key between 1 to 6. Okey? Now go and make your choose.");
            else
                test=false;
            
        }
        catch (System.Exception)
        {
            Console.WriteLine("I SAID JUST NUMBERS !!!!!!");
        }
        }

        return Chs; 
    }
}