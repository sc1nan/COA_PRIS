using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace COA_PRIS.Utilities
{
    internal class Validator
    {
        private readonly Dictionary<Control, string> validationErrors;

        public Validator()
        {
            validationErrors = new Dictionary<Control, string>();
        }

        public bool Required(Control control, string errorMessage = null)
        {
            if (control is GunaTextBox gunaTextBox)
            {
                if (string.IsNullOrWhiteSpace(gunaTextBox.Text))
                {
                    if (!string.IsNullOrEmpty(errorMessage))
                        validationErrors[control] = errorMessage;

                    gunaTextBox.BorderColor = Color.Red;
                    return false;
                }
            }
            if (validationErrors.ContainsKey(control))
                validationErrors.Remove(control);

            return true;
        }

        public bool IsValid()
        {
            return validationErrors.Count == 0;
        }

        public string GetError(Control control)
        {
            return validationErrors.ContainsKey(control) ? validationErrors[control] : null;
        }
    }
}
