using System;
using System.Collections.Generic;

namespace RentCar_Model.Models
{
    public partial class Vehicule
    {
        public Vehicule()
        {
            Documents = new HashSet<Document>();
            Reservations = new HashSet<Reservation>();
        }

        public int IdVeh { get; set; }
        public int IdAgen { get; set; }
        public int IdSerie { get; set; }
        public string? MatriVeh { get; set; }
        public int IdCar { get; set; }

        public virtual Agence IdAgenNavigation { get; set; } = null!;
        public virtual Carburant IdCarNavigation { get; set; } = null!;
        public virtual Serie IdSerieNavigation { get; set; } = null!;
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
