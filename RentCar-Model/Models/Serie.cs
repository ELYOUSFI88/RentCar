using System;
using System.Collections.Generic;

namespace RentCar_Model.Models
{
    public partial class Serie
    {
        public Serie()
        {
            Vehicules = new HashSet<Vehicule>();
        }

        public int IdSerie { get; set; }
        public int IdMar { get; set; }
        public string? NomSerie { get; set; }

        public virtual Marque IdMarNavigation { get; set; } = null!;
        public virtual ICollection<Vehicule> Vehicules { get; set; }
    }
}
