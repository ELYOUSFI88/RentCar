using System;
using System.Collections.Generic;

namespace RentCar_Model.Models
{
    public partial class Document
    {
        public int IdDoc { get; set; }
        public int IdVeh { get; set; }
        public int IdCli { get; set; }
        public int IdAgen { get; set; }
        public int IdCond { get; set; }
        public string? NomDoc { get; set; }
        public string? CheminDoc { get; set; }
        public DateTime? DtEnreDoc { get; set; }

        public virtual Conducteur IdCondNavigation { get; set; } = null!;
        public virtual Vehicule IdVehNavigation { get; set; } = null!;
    }
}
