using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    //opgave 3
    public class Reservationer
    {
        private int _id;
        Dictionary<int, Reservation> reservations;
        public Reservationer(int id)
        {
            _id = id;
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        
        //opgave 6
        
        public void RegistrerReservation(Reservation reservation)
        {
            reservations.Add(reservation.ID, reservation);     
        }

        public void PrintReservation()
        {
            foreach (var reservation in reservations)
            {
                Console.WriteLine(reservation);
            }
        }

        public void FjernReservatione(Reservation reservation)
        {
            reservations.Remove(reservation.ID);
        }
        //denne udkomenteret sektion er ikke færdig. programmet kan køre sådan her.
       /* public int AntalReservationer(Boernegruppe bgruppe)
        {

        }
        public bool ReservationLedig(Reservation reservation)
        {

        }
        ReservationsTidspunktOK(Reservation reservation) { }*/





    }



}
