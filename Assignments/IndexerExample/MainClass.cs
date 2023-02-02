using System;
class Indexer
{
    string[] name = new string[size];
    int[] id = new int[size];
    public static int size = 5;
    public string this[int index]
    {
        get
        {

            if (index >= 0 && index < size)
            {
                return name[index];
            }

            else
            {
                return null;
            }
        }
        set
        {
            if (index >= 0 && index < size)
            {
                name[index] = value;
            }
        }
    }
    public int this[string index]
    {
        get
        {
            for (int i = 0; i < size; i++)
            {
                if (name[i] == index)
                {
                    return id[i];
                }
            }
            return 0;
        }
        set
        {
            for (int i = 0; i < size; i++)
            {
                if (name[i] == index)
                {
                    id[i] = value;
                }
            }
        }
    }
    class MainClass
    {
        static void Main()
        {
            Indexer indexobj = new Indexer();
            
            indexobj[0] = "Naveen";
            indexobj[1] = "Ranjini";
            indexobj[2] = "Pruthvi";
            indexobj[3] = "Mukesh";
            indexobj[4] = "Abinaya";
            for (int i = 0; i < Indexer.size; i++)
            {
                Console.WriteLine(indexobj[i]);
            }
            Console.WriteLine("----------------");
            indexobj["Naveen"] = 101;
            indexobj["Ranjini"] = 102;
            indexobj["Pruthvi"] = 103;
            indexobj["Mukesh"] = 104;
            indexobj["Abinaya"] = 105;
            for (int i = 0; i < Indexer.size; i++)
            {
                Console.WriteLine(indexobj[indexobj[i]]);
            }
        }
    }
}

    

