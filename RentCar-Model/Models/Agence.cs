using System;
using System.Collections.Generic;

namespace RentCar_Model.Models
{
    public partial class Agence
    {
        public Agence()
        {
            Clients = new HashSet<Client>();
            Listenoirs = new HashSet<Listenoir>();
            Vehicules = new HashSet<Vehicule>();
        }

        public int IdAgen { get; set; }
        public int IdVil { get; set; }
        public string? NomAgen { get; set; }
        public string? Identitycode { get; set; }
        public string? TelFixAgen { get; set; }
        public string? TelMobileAgen { get; set; }
        public string? EmailAgen { get; set; }
        public string? SitewebAgen { get; set; }
        public string? PatenteAgen { get; set; }
        public string? IfAgen { get; set; }
        public string? IceAgen { get; set; }
        public string? AdresseAgen { get; set; }
        public string? LogoAgen { get; set; }

        public virtual Ville IdVilNavigation { get; set; } = null!;
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Listenoir> Listenoirs { get; set; }
        public virtual ICollection<Vehicule> Vehicules { get; set; }
    }
}
