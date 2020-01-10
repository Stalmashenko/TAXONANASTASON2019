using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAXONANASTASON.Models
{
    public class TRIP
    {
        public int Id { get; set; }
        public string StartDate { get; set; }
        public string FinishDate { get; set; }
        public string Tarif { get; set; }
        public double Summa { get; set; }
        public double Distance { get; set; }
        public int? ToAddressId { get; set; }
        public double Rating { get; set; }
        public virtual ADDRESS ToAddress { get; set; }
        public int? FromAddressId { get; set; }
        public virtual ADDRESS FromAddress { get; set; }
        public int? ClientId { get; set; }
        public virtual CLIENT Client { get; set; }
        public int? DriverId { get; set; }
        public virtual DRIVER Driver { get; set; }
        public int? StatusId { get; set; }
        public virtual TRIP_STATUS Status { get; set; }
    }
}
