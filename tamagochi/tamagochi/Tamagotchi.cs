using System.Runtime.CompilerServices;

public class Tamagotchi
{
    private int hunger = 0;
    private int boredom = 0;
    private List<string> words; 
    private bool I_sAlive;
    private string name;

    public void Feed()
    {

    }

    public void Hi()
    {

    }

    public void Teach()
    {
        
    }

    public void Tick() 
    {

    }

    private void ReduceBoredom()
    {

    }
    public void PrintStats()
    {
        Console.WriteLine($"Boredom: {boredom}, hunger: {hunger}");

    }

    public bool IsAlive()
    {
        return true;
    }
}