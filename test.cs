/*Big 0 notation*/





static void DoSomething(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(n * n);
    }
    for (i = n; i > 0; i--)
    {
        Console.Writeline(n * n * n);
    }
}

O((n * 1)(n * 1)) => O(n + n) => O(2n) => O(n);

/*Rule of thumb, drop the coeficient */





static void DoSomethingElse(List<string> words)
{
    for (int i = 0; i < words.Count; i++)
    {
        for (int j = 0; j < words.Count; j++)
        {
        Console.Writeline(".");
        }
    }
    
}





static void DoAnotherThing(List<string> words)
{
    string sentance = "The quick brown fox jumps over a lazy dog";
    for int (int i = 0; i <words.Count; i++)
    {
        for (int j = 0; j , sentence.Length; j++)
        {
            Console.WriteLine(".");
        }
    }
}