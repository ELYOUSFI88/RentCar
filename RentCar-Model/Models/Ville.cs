using System;
using System.Collections.Generic;

namespace RentCar_Model.Models
{
    public partial class Ville
    {
        public Ville()
        {
            Agences = new HashSet<Agence>();
            Clients = new HashSet<Client>();
            Reservations = new HashSet<Reservation>();
        }

        public int IdVil { get; set; }
        public string? NomVil { get; set; }

        public virtual ICollection<Agence> Agences { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
