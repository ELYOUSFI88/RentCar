using System;
using System.Collections.Generic;

namespace RentCar_Model.Models
{
    public partial class Listenoir
    {
        public int IdAgen { get; set; }
        public int IdCli { get; set; }
        public int IdLst { get; set; }
        public string? RemarqueLst { get; set; }
        public DateTime? DtRemarqueLst { get; set; }

        public virtual Agence IdAgenNavigation { get; set; } = null!;
        public virtual Client IdCliNavigation { get; set; } = null!;
    }
}
