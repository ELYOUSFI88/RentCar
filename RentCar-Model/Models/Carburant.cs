using System;
using System.Collections.Generic;

namespace RentCar_Model.Models
{
    public partial class Carburant
    {
        public Carburant()
        {
            Vehicules = new HashSet<Vehicule>();
        }

        public int IdCar { get; set; }
        public string? LibCar { get; set; }

        public virtual ICollection<Vehicule> Vehicules { get; set; }
    }
}
