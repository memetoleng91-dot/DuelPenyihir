
wizzard wizzardA = new wizzard("IS", 20);
wizzard wizzardB = new wizzard("dapi", 30);

Console.WriteLine("Permainan Dimukai...\n");
wizzardA.ShowStats();
wizzardB.ShowStats();

wizzardA.Attack(wizzardB);
wizzardB.Attack(wizzardA);
wizzardA.Attack(wizzardB);

Console.WriteLine("Permainan berakhir...\n");
wizzardA.ShowStats();
wizzardB.ShowStats();
public class wizzard
{

    public string Name;
    public int Energy;
    public int Damage;


    public wizzard(string name, int demage)
    {
        Name = name;
        Energy = 100;
        Damage = demage;
    }

    public void ShowStats()
    {
        Console.WriteLine("Statistik Wizard");
        Console.WriteLine($"Nama: {Name}, Energy: {Energy} \n");
    }

    public void Attack(wizzard wizzardLawanObj)
    {
        wizzardLawanObj.Energy -= Damage;
        Console.WriteLine($"{Name} menyerang {wizzardLawanObj.Name}");
        Console.WriteLine($" Sisa Energy {wizzardLawanObj.Name} adalah {wizzardLawanObj.Energy}");
    }

}