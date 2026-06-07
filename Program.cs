
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

wizzard wizzardA = new wizzard("IS", 20);
wizzard wizzardB = new wizzard("dapi", 30);
string pilihan;

Console.WriteLine("Permainan Dimukai...\n");
wizzardA.ShowStats();
wizzardB.ShowStats();

while (wizzardA.Energy > 0 && wizzardB.Energy > 0)
{
    Console.WriteLine($"1. {wizzardA.Name} Menyerang {wizzardB.Name}");
    Console.WriteLine($"2. {wizzardB.Name} Menyerang {wizzardB.Name}");
    Console.WriteLine($"3. {wizzardA.Name} Melakukan Heal");
    Console.WriteLine($"4. {wizzardB.Name} Melakukan Heal");

    Console.Write("\nMasukkan Pilihan (1/2/3/4) : ");
    pilihan = Console.ReadLine();

    switch (pilihan)
    {
        case "1":
            wizzardA.Attack(wizzardB);
            break;
        case "2":
            wizzardB.Attack(wizzardA);
            break;
        case "3":
            wizzardA.Heal();
            break;
        case "4":
            wizzardB.Heal();
            break;
        default:
            Console.WriteLine("Pilihan Tidak Valid\n");
            break;
    }
}

Console.WriteLine("Permainan berakhir...\n");
wizzardA.ShowStats();
wizzardB.ShowStats();

if (wizzardA.Energy > wizzardB.Energy)
{
    Console.WriteLine($"{wizzardA.Name} Menang!");
}
else
{
    Console.WriteLine($"{wizzardB.Name} Menang!");
}

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

    public void Heal ()
    {
        Energy += 5;
        if (Energy < 100)
        {

            Console.WriteLine($"{Name} Melakukan Heal, Energi Meningkat Menjadi {Energy} ");
        }
        else
        {
            Energy = 100;
            Console.WriteLine("Energi Sudah Penuh");
        }
    }
}

