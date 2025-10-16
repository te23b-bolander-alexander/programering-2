using System.Threading.Tasks.Dataflow;

Tamagotchi tama = new();
tama.name();
tama.PrintStats();
while (tama.GetAlive() == true)
{
    tama.PrintStats();
    string sigma = Console.ReadLine();
}
if (tama.GetAlive() == false)
{
    Console.WriteLine("It died :(");
}
Console.ReadLine();