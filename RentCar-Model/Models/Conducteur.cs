using System;
using System.Collections.Generic;

namespace RentCar_Model.Models
{
    public partial class Conducteur
    {
        public Conducteur()
        {
            Documents = new HashSet<Document>();
        }

        public int IdCond { get; set; }
        public int IdTypecli { get; set; }
        public string? NomCond { get; set; }
        public string? PrenomCond { get; set; }
        public string? TelCond { get; set; }
        public string? AdresseCond { get; set; }
        public string? CinCond { get; set; }

        public virtual Typeclient IdTypecliNavigation { get; set; } = null!;
        public virtual ICollection<Document> Documents { get; set; }
    }
}
