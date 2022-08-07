using System;
using System.Threading;
using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
        Console.ReadKey();
        
    }
    static void Menu(){
        string? tmp;
        string UnidTempo;
        int s,m;
         Console.WriteLine("\n ///////CRONOMETRO//////////\n");
         Console.WriteLine("\n s = segundos(S)");
         Console.WriteLine("\n m = minutos (M)");
        Comeco:
        Console.Write("tmp: ");
        tmp = Console.ReadLine();

        if(tmp != null){
            UnidTempo = tmp.Substring(tmp.Length -1);//.length é a quantidade de caracteres que a string tem, ex: 120s<<possui 4 caracter.
            if (!Regex.IsMatch(UnidTempo, @"[0_9]+#~"))
            {
                s = int.Parse(tmp.Substring(0, tmp.Length - 1));
                m = int.Parse(tmp.Substring(0, tmp.Length - 1));
            }
           
            else
            {
                goto Comeco;}
        
            PreStart();
            Start(UnidTempo,m,s);

            }
    static void PreStart(){
        Console.WriteLine("Iniciando...");
        Thread.Sleep(1000);
            }

        }

    private static void Start(string unidTempo, int s, int m)
    {
       int Segundos = 59;

        Console.Clear();

        if (unidTempo == "m")
        {
            Console.Write(m + unidTempo);
            s = m*60;
            Thread.Sleep(1000);

            m--;

            Console.Clear();

            while (m >= 0)
            {
                Console.WriteLine("{0}{1} {2}{3}", m, unidTempo, Segundos, "s");
                Thread.Sleep(1000);
                Segundos--;
                Console.Clear();

                if (m > 0 && Segundos == 0)
                {
                    Console.WriteLine("{0}{1} {2}{3}", m, unidTempo, Segundos, "s");
                    Thread.Sleep(1000);


                m--;
                    Segundos = 59;
                    Console.Clear();

                    while (Segundos > 0)
                    {
                        Console.WriteLine("{0}{1} {2}{3}", m, unidTempo, Segundos, "s");
                        Thread.Sleep(1000);
                        Segundos--;
                        Console.Clear();
                    }
                }
                if (m == 0 && Segundos == 0)
                {
                    Console.WriteLine(" *****fim***** ");
                    break;
                }

            }
        }
        if (unidTempo == "s")
        {
            while (s > 0)
            {
                Console.Write(s + unidTempo);
                Thread.Sleep(1000);
                s--;
                Console.Clear();

                if (s == 0)
                {
                    Console.WriteLine("*****fim***** ");
                }
            }
       }
    }
}

