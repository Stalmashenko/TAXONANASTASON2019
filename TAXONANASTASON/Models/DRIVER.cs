using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TAXONANASTASON.Models
{
    public class DRIVER
    {
        public int Id { get; set; }

        [RegularExpression(@"\D*", ErrorMessage = "ФАМИЛИЯ\t\t | Формат неверен\n")]
        [Required(ErrorMessage = "ФАМИЛИЯ\t\t | Введите данные\n")]
        [StringLength(20)]
        public string Surname { get; set; }

        [RegularExpression(@"\D*", ErrorMessage = "ИМЯ\t\t\t | Формат неверен\n")]
        [Required(ErrorMessage = "ИМЯ\t\t\t | Введите данные\n")]
        [StringLength(20)]
        public string Firstname { get; set; }

        [RegularExpression(@"\D*", ErrorMessage = "ОТЧЕСТВО\t\t | Формат неверен\n")]
        [Required(ErrorMessage = "ОТЧЕСТВО\t\t | Введите данные\n")]
        [StringLength(20)]
        public string Fathersname { get; set; }

        [RegularExpression(@"\d*", ErrorMessage = "НОМЕР КАРТЫ\t\t | Формат неверен\n")]
        [Required(ErrorMessage = "НОМЕР КАРТЫ\t\t | Введите данные\n")]
        [StringLength(16)]
        public string Card { get; set; }

        [RegularExpression(@"^\+375(17|29|33|44|25)[0-9]{7}$", ErrorMessage = "МОБИЛЬНЫЙ ТЕЛЕФОН\t\t | Формат неверен\n")]
        [Required(ErrorMessage = "МОБИЛЬНЫЙ ТЕЛЕФОН\t | Введите данные.\n\t\t\t | Пример: +375291234567")]
        [StringLength(13)]
        public string Phone { get; set; }
        public double Balance { get; set; }
        public int? CarId { get; set; }
        public virtual CAR Car { get; set; }
        public int? StatusId { get; set; }
        public virtual DRIVER_STATUS Status { get; set; }
    }
}
