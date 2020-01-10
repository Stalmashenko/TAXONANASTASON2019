using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TAXONANASTASON.Models
{
    public class ADDRESS
    {
        public int Id { get; set; }

        [RegularExpression(@"\d*", ErrorMessage = "ДОМ\t\t | Формат неверен\n")]
        [Required(ErrorMessage = "ДОМ\t\t | Введите данные\n")]
        public string House { get; set; }
        public int? StreetId { get; set; }
        public virtual STREET Street { get; set; }
    }
}
