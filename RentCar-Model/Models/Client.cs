using System;
using System.Collections.Generic;

namespace RentCar_Model.Models
{
    public partial class Client
    {
        public Client()
        {
            Listenoirs = new HashSet<Listenoir>();
            Reservations = new HashSet<Reservation>();
        }

        public int IdCli { get; set; }
        public int IdAgen { get; set; }
        public int IdVil { get; set; }
        public int IdTypecli { get; set; }
        public string? NomCli { get; set; }
        public string? PrenomCli { get; set; }
        public string? CinCli { get; set; }
        public string? AdresseCli { get; set; }
        public string? TelCli { get; set; }

        public virtual Agence IdAgenNavigation { get; set; } = null!;
        public virtual Typeclient IdTypecliNavigation { get; set; } = null!;
        public virtual Ville IdVilNavigation { get; set; } = null!;
        public virtual ICollection<Listenoir> Listenoirs { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
