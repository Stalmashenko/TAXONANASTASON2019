using System;
using BespokeFusion;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TAXONANASTASON
{
    class Validation
    {
        public bool CheckValid(object o)
        {
            var results = new List<ValidationResult>();

            var context = new ValidationContext(o);

            if (!Validator.TryValidateObject(o, context, results, true))
            {
                string strWithError = "";
                foreach (var error in results)
                {
                    strWithError += error.ErrorMessage;
                }

                MaterialMessageBox.ShowError(strWithError);
                return false;
            }
            else
                return true;
        }

    }
}
