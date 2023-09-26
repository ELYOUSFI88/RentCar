using System;
using System.Collections.Generic;

namespace RentCar_Model.Models
{
    public partial class Marque
    {
        public Marque()
        {
            Series = new HashSet<Serie>();
        }

        public int IdMar { get; set; }
        public string? NomMar { get; set; }

        public virtual ICollection<Serie> Series { get; set; }
    }
}
