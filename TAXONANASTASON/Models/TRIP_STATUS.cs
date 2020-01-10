using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TAXONANASTASON.Models
{
    public class TRIP_STATUS
    {
        public int Id { get; set; }

        [RegularExpression(@"\D*", ErrorMessage = "СТАТУС\t\t\t | Формат неверен\n")]
        [Required(ErrorMessage = "CТАТУС\t\t\t | Введите данные\n")]
        [StringLength(20)]
        public string Status { get; set; }
    }
}
