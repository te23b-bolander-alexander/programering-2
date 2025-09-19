void Window ()
{
    Console.WriteLine("""    
    .----------------.
   |          _       |
   |      _.-'|'-._   |
   | .__.|    |    |  |
   |     |_.-'|'-._|  |
   | '--'|    |    |  |
   | '--'|_.-'`'-._|  |
jgs| '--'          `  |
    '----------------'
""");
}

static void stars()
{
    Console.SetCursorPosition(Random.Shared.Next, (120), Random.Shared.Next(29));
    Console.WriteLine("*");

}



//Window();

void typeWriter()
{
    string[] ord = ("L", "I", "G", "M", "A", "E", "N", "I", "G", "M", "A",);
    int a = 12;
    for (int i = 0; i < a; i++)
    {
        Console.Write(ord[a]);
        Thread.Sleep(200);
    }
}




Console.ReadLine();