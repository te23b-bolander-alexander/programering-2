using System.Runtime.CompilerServices;

public class monster
{
    private int hp;
    private int dmg;
    private string name;
    public void takedmg(int amount)
    {
        hp -= amount;
    }
    public int attack;
    public void sethp()
    {

    }
    public void setdmg()
    {

    }
    private void dmgincrease(int amount)
    {

    }
}

class T : monster //T-1000
{
    public int stab;
    public int morph;
}

class jason : monster
{
    public int slash;
    public int mask;
    
}