
using System;
using System.Security.Cryptography.X509Certificates;

enum Typ { Nalozit, Nalozeno, Vylozit, PrijezdDoB, PrijezdDoA };

public int pisekA;
public int pisekB;
int pisekcelkem;
public int cas;
public int KdyNakladat;
public int pocetAut = 4;

for (int i = 0; i<pocetAut; i++)
{
    new Auto(15, 60, 5, 120);
}

var kalendar = new PriorityQueue<string, int>();

public void Planuj(Auto a, int k, Typ c)
{
    kalendar.Enqueue(new Udalost(a, k, c));
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
