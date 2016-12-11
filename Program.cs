using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JelenletiKonzol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OSTOR - Óraelszámolási segéd.");
            Console.WriteLine("2016, (c) csabavagyok");
            bool valasz = true;
            //Adatok a hónapról (hónap, óraszám)
            Console.WriteLine("Adja meg a hónapot");
            string month = Console.ReadLine();
            Console.WriteLine("Adja meg a havi kötelező óraszámot");
            string hours1 = Console.ReadLine();
            Byte hours = Convert.ToByte(hours1);
            do
            {
                //Adatok a dolgozóról (munkaviszony)
                Console.WriteLine("Adja meg az elszámolni kívánt dolgozó munkaviszonyát a teljes álláshoz képest");
                string workhours = Console.ReadLine();
                Double workhours1 = Convert.ToDouble(workhours);
                //Hány szolgálatot teljesített a dolgozó?
                Console.WriteLine("Hány szolgálatot teljesített a dolgozó?");
                string szolgalatok1 = Console.ReadLine();
                byte szolgalatok = Convert.ToByte(szolgalatok1);
                byte i;
                byte munkaora = 0;
                byte delutanipotlek = 0;
                byte ejszakaipotlek = 0;
                byte tulora9 = 0;
                byte tulora8 = 0;
                byte tulorae = 0;
                byte tuloranorm = 0;
                byte ossztulora = 0;
                double osszora = 0;
                for (i = 1; i <= szolgalatok; i++)
                {
                    Console.WriteLine("Adja meg a(z) " + i + ". szolgálatot " + month + " hónapra! (6,7,8,9/18,19 elfogadottak)");
                    string szolgalat1 = Console.ReadLine();
                    byte szolgalat = Convert.ToByte(szolgalat1);
                    switch (szolgalat)
                    {
                        case 6:
                            munkaora += 12;
                            delutanipotlek += 4;
                            break;
                        case 7:
                            munkaora += 12;
                            delutanipotlek += 5;
                            break;
                        case 8:
                            munkaora += 12;
                            delutanipotlek += 6;
                            break;
                        case 9:
                            munkaora += 12;
                            delutanipotlek += 7;
                            break;
                        case 18:
                            munkaora += 12;
                            delutanipotlek += 4;
                            ejszakaipotlek += 8;
                            break;
                    }
                    if (szolgalat == 9) //Speciális eset, mert ha 9-21 szolgálatban 2 óra túlóra van, 
                                        //akkor 1 délutáni és 1 éjszakai pótlékot is adni kell
                    {
                        Console.WriteLine("Adja meg a túlórát!");
                        string tulora91 = Console.ReadLine();
                        tulora9 = Convert.ToByte(tulora91);
                        if (tulora9 == 2)
                        {
                            munkaora += tulora9;
                            delutanipotlek += 1;
                            ejszakaipotlek += 1;
                            ossztulora += tulora9;
                            
                        }
                        else
                        {
                            munkaora += tulora9;
                            delutanipotlek += tulora9;
                            ossztulora += tulora9;
                        }
                    }
                    else if (szolgalat == 8) //Ha 3 óra túlóra van, akkor 2 délutáni és 1 éjszakai pótlékot is adni kell
                    {
                        Console.WriteLine("Adja meg a túlórát!");
                        string tulora81 = Console.ReadLine();
                        tulora8 = Convert.ToByte(tulora81);
                        if (tulora8 == 3)
                        {
                            munkaora += tulora8;
                            delutanipotlek += 2;
                            ejszakaipotlek += 1;
                            ossztulora += tulora8;
                        }
                    }
                    else if (szolgalat == 18 || szolgalat == 19)
                    {
                        Console.WriteLine("Adja meg a túlórát!");
                        string tulorae1 = Console.ReadLine();
                        tulorae = Convert.ToByte(tulorae1);
                        munkaora += tulorae;
                        ossztulora += tulorae;
                    }
                    else
                    {
                        Console.WriteLine("Adja meg a túlórát!");
                        string tuloranorm1 = Console.ReadLine();
                        tuloranorm = Convert.ToByte(tuloranorm1);
                        munkaora += tuloranorm;
                        delutanipotlek += tuloranorm;
                        ossztulora += tuloranorm;
                    }
                }
                Console.WriteLine("Áthozott 6 óra van? Y/N");
                char valasz1 = Console.ReadKey(true).KeyChar;
                if (valasz1 == 'y')
                {
                    munkaora += 6;
                    ejszakaipotlek += 6;
                    Console.WriteLine("Túlóra az áthozott 6 órán?");
                    string tuloraath1 = Console.ReadLine();
                    byte tuloraath = Convert.ToByte(tuloraath1);
                    munkaora += tuloraath;
                    ossztulora += tuloraath;

                }

                Console.WriteLine("Átvitt 6 óra lesz? Y/N");
                char valasz2 = Console.ReadKey(true).KeyChar;
                if (valasz2 == 'y')
                {
                    munkaora -= 6;
                    ejszakaipotlek -= 6;
                }
                Console.WriteLine("A dolgozó munkanapi betegszabadságainak száma:");
                string betegszab1 = Console.ReadLine();
                byte betegszabnap = Convert.ToByte(betegszab1);
                double betegszab = betegszabnap * 8 * workhours1;
                Console.WriteLine("A dolgozó szabadságainak száma:");
                string szabi1 = Console.ReadLine();
                byte szabinap = Convert.ToByte(szabi1);
                double szabi = szabinap * 8 * workhours1;
                Console.WriteLine("A dolgozó " + month + " havi szolgálatait rögzítettem.");
                Console.WriteLine("A dolgozó szabadnapjai: " + szabinap + ". A szabadság órái: " + szabi*workhours1);
                Console.WriteLine("A dolgozó beteg napjai: " + betegszabnap + ". A beteg órák: " + betegszab*workhours1);
                Console.WriteLine("A dolgozó munkaórája: " + munkaora);
                Console.WriteLine("A dolgozó délutáni pótlékai: " + delutanipotlek);
                Console.WriteLine("A dolgozó éjszakai pótlékai: " + ejszakaipotlek);
                Console.WriteLine("A dolgozó túlórái: " + ossztulora);
                osszora += munkaora;
                osszora += betegszab;
                osszora += szabi;
                Console.WriteLine("A dolgozó össz órája: " + osszora);
                Console.Write("A dolgozó havi túlórája: ");
                Console.WriteLine(osszora - hours*workhours1);
                Console.WriteLine();
                Console.WriteLine("Következő dolgozó? Y/N");
                char kerdes = Console.ReadKey(true).KeyChar;
                if (kerdes == 'n')
                {
                    valasz = false;
                }
            } while (valasz);
        }
    }
}
