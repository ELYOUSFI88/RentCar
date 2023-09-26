using System;
using System.Collections.Generic;

namespace RentCar_Model.Models
{
    public partial class Typeclient
    {
        public Typeclient()
        {
            Clients = new HashSet<Client>();
            Conducteurs = new HashSet<Conducteur>();
        }

        public int IdTypecli { get; set; }
        public string? NomTypecli { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Conducteur> Conducteurs { get; set; }
    }
}
