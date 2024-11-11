
using System;
using System.Security.Cryptography.X509Certificates;

enum Typ { Nalozit, Nalozeno, Vylozit, PrijezdDoB, PrijezdDoA };

public int pisekA;
public int pisekB;
public int pisekMezi;
public int cas;
public int KdyNakladat;
public int pocetAut = 4;
var kalendar = new PriorityQueue<Udalost, int>();
var nakladani = new PriorityQueue<Auto, int>();

for (int i = 0; i<pocetAut; i++)
{
    a = new Auto(15, 60, 5, 120);
    nakladani.Enqueue(a, a.nosnost);
}
while (true)
{
    Udalost temp = kalendar.Dequeue()
    switch (temp.Typ)
    {
        case Vylozit:
            Vylozit(temp.kdo, temp.kdy);
            break;
   //     case Nalozit:
   //        Nalozit(temp.kdo, temp.kdy);
   //        break;
        case Nalozeno:
            Nalozeno(temp.kdo, temp.kdy);
            break;
        case PrijezdDoB:
            PrijezdDoB(temp.kdo, temp.kdy);
            break;
        case PrijezdDoA:
            PrijezdDoA(temp.kdo);
            break;
    }


}



public void Planuj(Auto a, int k, Typ c)
{
    kalendar.Enqueue(new Udalost(a, k, c), k);
}
public void Nalozeno(Auto a, int k)
{
    pisekA -= a.nosnost;
    pisekMezi += a.nosnost;
    Auto temp = nakladani.Dequeue();
    Planuj(temp, k-temp.dobaNakladani, Nalozeno);
    Planuj(a, k - a.dobaJizdy, PrijezdDoB);
}
public void PrijezdDoB(Auto a, int k)
{
    Planuj(a, k - a.dobaVykladani, Vylozeno);
}
public void Vylozit(Auto a, int k)
{
    pisekMezi -= a.nosnost;
    pisekB += a.nosnost;
    Planuj(a, k-a.dobaJizdy, PrijezdDoA)
}
public void PrijezdDoA(Auto a)
{
    nakladani.Enqueue(a)
}
class Auto;
{
    int nosnost;
    int dobaNakladani;
    int dobaJizdy;
    int dobaVykladani;
    public Auto(int n, int dn, int dj, int dv)
    {
        nosnost = n;
        dobaNakladani = dn;
        dobaJizdy = dj;
        dobaVykladani = dv;
    }
}



class Udalost
{
    Auto kdo;
    int kdy;
    Typ co;
    public Udalost(Auto a, int k, Typ c)
    {
        kdo = a;
        kdy = k;
        co = c;
    }
}

