using System.Runtime.InteropServices;

namespace Baalhyttebooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boernegruppe boernegruppe = new Boernegruppe("1","A.I.S","8-11",21);
            Reservation reservation = new Reservation(1,new DateTime().AddHours(12).AddMinutes(00),boernegruppe);
            Console.WriteLine(boernegruppe);
            Console.WriteLine();
            Console.WriteLine(reservation);
            Console.WriteLine();

            //opgave 6
            Boernegruppe boernegruppe1 = new Boernegruppe("2", "Ø.I.S", "11-13", 18);
            Reservation reservation1 = new Reservation(2, new DateTime().AddHours(14).AddMinutes(00),boernegruppe1);
            Console.WriteLine(boernegruppe1);
            Console.WriteLine();
            Console.WriteLine(reservation1);
            Console.WriteLine();
            Reservationer reservationer = new Reservationer(1);

            
        }
    }
}