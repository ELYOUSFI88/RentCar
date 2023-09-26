using System;
using System.Collections.Generic;

namespace RentCar_Model.Models
{
    public partial class Reservation
    {
        public int IdRes { get; set; }
        public int IdVeh { get; set; }
        public int IdCli { get; set; }
        public int IdVil { get; set; }
        public int? DureeRes { get; set; }
        public DateTime? DtDebutRes { get; set; }
        public DateTime? DtFinRes { get; set; }
        public string? AdresseLivraison { get; set; }
        public string? AdresseRetour { get; set; }

        public virtual Client IdCliNavigation { get; set; } = null!;
        public virtual Vehicule IdVehNavigation { get; set; } = null!;
        public virtual Ville IdVilNavigation { get; set; } = null!;
    }
}
