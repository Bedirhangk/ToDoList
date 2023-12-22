namespace ToDoList;

public static class EnumPri
{
    public enum Buyukluk
    {
        XS=1,
        S,
        M,
        L,
        XL

    }

    public static int Range (int chs)
    {
        if(chs<1 || chs>5)
        {
            Console.WriteLine("Please make choose between 1 to 5");
            return 0;
        }
        else
        {
            return chs;
        }
    }

}