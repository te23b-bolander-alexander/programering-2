using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Tamagotchi
{
    private int hunger = 0;
    private int boredom = 0;
    private List<string> words = ["Hallo"];
    private bool IsAlive = true;
    private string name = "";
    public void naming()
    {
        Console.WriteLine("sdfghjk ");
        name = Console.ReadLine();
    }

    public void Feed()
    {
        hunger = -2;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }

    public void Hi()
    {
        Console.WriteLine($"{words[Random.Shared.Next(words.Count)]}");
        ReduceBoredom();
    }

    public void Teach(String word)
    {
        words.Add(word);
    }

    public void Tick()
    {
        hunger = +1;
        boredom = +1;
        if (hunger > 9 || boredom > 9)
        {
            IsAlive = false;
        }
    }

    private void ReduceBoredom()
    {
        boredom = -2;
        if (boredom < 0)
        {
            boredom = 0;
        }
    }
    public void PrintStats()
    {
        Console.WriteLine($"Name {name}, Boredom: {boredom}, hunger: {hunger}, Alive {IsAlive}");

    }

    public bool GetAlive()
    {
        return IsAlive;
    }
}