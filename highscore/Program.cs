using System.Drawing;

List<string> names = ["Alex", "Sara"];
List<int> points = [];
names.Add("Swedlund");
bool poängmednummer = false; 
Console.WriteLine("Skriv namn");
string efternamn = Console.ReadLine();
int point = 0;
names.Add(efternamn);
while (poängmednummer == false)
{
    Console.WriteLine("skriv hurm ånga poäng den här personen förtjänar");
    string poäng = Console.ReadLine();
    poängmednummer = int.TryParse(poäng, out point);
    if (poängmednummer == false) Console.WriteLine("skriv i nummer din goofball");

}


//stygg ike(jo(nope(beta(*sigma(*host*beta cuc *host* (*simga enigma med en stor mängd smegma som får alla hussar (nilo tengman ) och är tuff (no(jo)))))))) sigma


Console.ReadLine();