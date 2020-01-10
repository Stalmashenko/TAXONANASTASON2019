using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAXONANASTASON.Models
{
    public class CAR
    {
        public int Id { get; set; }
        public string TypeModel { get; set; }
        public int? TarifId { get; set; }
        public virtual TARIF Tarif { get; set; }
        public int? CarModelId { get; set; }
        public virtual CAR_MODEL CarModel { get; set; }
    }
}
