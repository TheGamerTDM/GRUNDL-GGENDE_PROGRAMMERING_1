﻿using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Rap_Finands
{
    /**
    Dette BANK PROGRAM ER LAVET af Konrad Sommer! Copy(c) Right All rights reserveret 2020
    idé og udtænkt af Anne Dam for Voldum Bank I/S
    Rap Finands
    **/
    class Program
    {
        public static string reginummer = "4242";
        public static string datafil = "bank.json"; //Her ligger alt data i
        public static List<Konto> konti;

        static void Main(string[] args)
        {
            Console.WriteLine("Henter alt kontodata");
            
            hent();
            if (konti.Count == 0) 
            {
                var k = lavKonto();
                k.ejer = "Ejvind Møller";
                konti.Add(k);

                gemTrans(k,"Opsparing",100);
                gemTrans(konti[0],"Vandt i klasselotteriet",1000);
                gemTrans(konti[0],"Hævet til Petuniaer",-50);
                
                gem();
            }
            start();
        }

        static void start() 
        {
            Console.WriteLine("Velkommen til Rap Finans af Konrad Sommer");
            Console.WriteLine("Hvad vil du gøre nu?");
            
            bool blivVedOgVed = true;
            while (blivVedOgVed) 
            {
                Console.WriteLine("1. Opret ny konto");
                Console.WriteLine("2. Hæv/sæt ind");
                Console.WriteLine("3. Se en oversigt");
                Console.WriteLine("0. Afslut");

                Console.Write("> ");
                string valg1 = Console.ReadLine();

                switch (Convert.ToInt32(valg1)) 
                {
                    case 1:
                        opretKonto();
                        break;
                    case 2:
                        opretTransaktion(findKonto());
                        break;
                    case 3:
                        udSkrivKonto(findKonto());
                        break;
                    case 0:
                        blivVedOgVed = false;
                        break;
                    default:
                        Console.WriteLine("UGYLDIGT VALGT!!");
                        Console.ReadKey();
                        break;
                }
            }
            Console.Clear();
        }

        static Konto findKonto() 
        {
            for (var i = 1; i <= konti.Count;i++)
            {
                Console.WriteLine(i+". "+konti[i-1].registreringsnr+" "+konti[i-1].kontonr+" ejes af "+konti[i-1].ejer);
            }
            Console.WriteLine("Vælg et tal fra 1 til "+konti.Count);
            Console.Write(">");
            int tal = int.Parse(Console.ReadLine());
            if (tal < 1 || tal > konti.Count) 
            {
                Console.WriteLine("Ugyldigt valg");
                Console.Clear();
                return null;
            }
            return konti[tal-1];
        }
        
        static void opretTransaktion(Konto k) 
        {

            var t = new Transaktion();
            Console.WriteLine("1. Hæv");
            Console.WriteLine("2. Sæt ind");
            Console.Write("> ");
            string valg2 = Console.ReadLine();

            switch (Convert.ToInt32(valg2))
            {
                case 1:
                    Console.WriteLine("Hvor meget ville du hæve?");
                    Console.Write("Beløb: ");
                    string havBeløb = Console.ReadLine();

                    float saldoEfterHav = t.saldo - Convert.ToInt32(havBeløb);

                    Console.WriteLine("Du har hævet " + saldoEfterHav);
                    string tekst = "Du har hævet penge: ";
                    gemTrans(k, tekst, saldoEfterHav);
                    gem();
                    break;
                case 2:
                    Console.WriteLine("Hvor meget ville du sætte ind?");
                    Console.Write("Beløb: ");
                    string sætIndBeløb = Console.ReadLine();

                    float saldeEfterIndsat = t.saldo + Convert.ToInt32(sætIndBeløb);

                    Console.WriteLine("Du har sat så mange penge ind: " + saldeEfterIndsat);
                    string tekst2 = "Du har ind sat penge: ";
                    gemTrans(k, tekst2, saldeEfterIndsat);
                    gem();
                    break;
                default:
                    Console.WriteLine("UGYLDIGT VALGT!!");
                    Console.ReadKey();
                    break;
            }


            //Console.Write("Tekst: ");
            //string tekst = Console.ReadLine();
            //Console.Write("Beløb: ");
            //float amount = float.Parse(Console.ReadLine());
            //if (gemTrans(k,tekst,amount)) 
            //{
            //    Console.WriteLine("Transkationen blev gemt. Ny saldo på kontoen: "+findSaldo(k));
            //    
          
        }

        static Konto opretKonto() 
        {
            Konto k = lavKonto();
            Console.Write("Navn på kontoejer: ");
            k.ejer = Console.ReadLine();
            Console.WriteLine("Konto oprettet!");
            konti.Add(k);
            gem();
            return k;
        }

        public static Konto lavKonto() 
        {
            return new Konto();
        }

        /*
        fed metode til at lave helt nye kontonumre ~Konrad
        */
        public static string lavEtKontoNummer() 
        {
            Random tilfael = new Random();
            string nr = tilfael.Next(1,9).ToString();
            for (var i = 1; i <= 9; i++) 
            {
                nr = nr + tilfael.Next(0,9).ToString();
                if (i == 3) nr = nr + " ";
                if (i == 6) nr = nr + " ";
            }
            return nr;
        }


        static void udSkrivKonto(Konto k) 
        {
            Console.WriteLine("Konto for "+k.ejer+": "+k.registreringsnr+" "+k.kontonr);
            Console.WriteLine("================");
            Console.WriteLine("Tekst\t\t\t\tBeløb\t\tSaldo");
            foreach (Transaktion t in k.transaktioner) 
            {
                Console.Write(t.tekst+"\t\t\t");
                Console.Write(t.amount+"\t\t");
                Console.WriteLine(t.saldo);
            }
            Console.WriteLine("================\n");
        }
        
        public static bool gemTrans(Konto konto, string tekst, float beløb) 
        {
            var saldo = findSaldo(konto);
            var t = new Transaktion();
            t.tekst = tekst;
            t.saldo = t.amount + saldo;
            t.dato = DateTime.Now;
            
            konto.transaktioner.Add(t);
            return true;
        }

        public static float findSaldo(Konto k) 
        {
            Transaktion seneste = new Transaktion();
            DateTime senesteDato = DateTime.MinValue;
            foreach(var t in k.transaktioner) 
            {
                if (t.dato > senesteDato) 
                {
                    senesteDato = t.dato;
                    seneste = t;
                }
            }
            return seneste.saldo;
        }

        public static void gem() 
        {
            File.WriteAllText(datafil,JsonConvert.SerializeObject(konti));
            //File.Delete(datafil); //Fjern debug fil
        }

        public static void hent()
        {
            datafil = "debug_bank.json"; //Debug - brug en anden datafil til debug ~Konrad
            if (File.Exists(datafil)) 
            {
                string json = File.ReadAllText(datafil);
                konti = JsonConvert.DeserializeObject<List<Konto>>(json);
            } 
            else 
            {
                konti = new List<Konto>();
            }
        }
    }
}
/** 
Koden er lavet til undervisningbrug på TECHCOLLEGE
Voldum Bank og nævnte personer er fiktive.
~Simon Hoxer Bønding
**/
