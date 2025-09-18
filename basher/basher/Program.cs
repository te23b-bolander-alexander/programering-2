Enemy jack = new();

jack.Name = "jack";
jack.Hp = 5;
jack.Damage = 1;

Enemy pegasus = new()
{
    Name = "pegasus",
    Hp = 10,
    Damage = 3
};



jack.Hp++;

jack.Hp -= pegasus.Damage;



