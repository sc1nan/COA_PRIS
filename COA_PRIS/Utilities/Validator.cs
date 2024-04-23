using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Mysqlx;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using COA_PRIS.UserControlUtil.PRIS_UserControl;
using Org.BouncyCastle.Ocsp;

namespace COA_PRIS.Utilities
{
    internal class Validator
    {
        private Util util = new Util();

        public Validator(){}

        public bool Required_TextBox(Control parent, ErrorProvider error, GunaLabel error_Label = null)
        {
            List<Control> guna_TextBox = util.SearchControls<Control>(parent, new List<Type> {typeof(GunaTextBox)});

            bool is_Required = true; 

            foreach (GunaTextBox text_Box in guna_TextBox) 
            {
                if (string.IsNullOrWhiteSpace(text_Box.Text) && !text_Box.Tag.ToString().Contains("!req"))
                {
                    error.SetError(text_Box, $"{text_Box.Tag} is required.");
                    text_Box.BorderColor = Color.Red;
                    is_Required = false;
                    if (error_Label != null)
                    {
                        error_Label.Text = "Fill the required fields.";
                        error_Label.Visible = true;
                    }
                }
                else
                {
                    text_Box.BorderColor = Color.Silver; 
                }
            }

            return is_Required;
        }

        public bool PRISRequired(Control _parent, ErrorProvider _errorProvider, GunaLabel _errorLabel = null ) 
        {
            List<Control> PRISControls = util.SearchControls<Control>(_parent, new List<Type> { typeof(IPRIS_UserControl) });
            bool ret = true;
            foreach (IPRIS_UserControl pris in PRISControls)
            {
                
                if (string.IsNullOrEmpty(pris.Value) && pris.IsRequired)
                {
                    _errorProvider.SetError(pris.IndicatorRoot, $"{pris.Title} is a required field.");
                    if (_errorLabel != null)
                    {
                        _errorLabel.Text = "Fill the required fields.";
                        _errorLabel.Visible = true;
                    }
                    ret = false;
                }
                else
                {
                    _errorProvider.SetError(pris.IndicatorRoot, string.Empty);
                    if (_errorLabel != null)
                    {
                        _errorLabel.Text = "120123";
                        _errorLabel.Visible = false;
                    }
                }

                if (pris.ErrorRoot is GunaTextBox || pris.ErrorRoot is GunaDateTimePicker)
                {
                    dynamic control = pris.ErrorRoot;

                    if (string.IsNullOrEmpty(pris.Value) && pris.IsRequired)
                        control.BorderColor = Color.Red;
                    else
                        control.BorderColor = Color.Silver;
                }
                else if (pris.ErrorRoot is GunaElipsePanel)
                {
                    dynamic control = pris.ErrorRoot;

                    if (string.IsNullOrEmpty(pris.Value) && pris.IsRequired)
                        control.BaseColor = Color.Red;
                    else
                        control.BaseColor = Color.Silver;
                }

                
            }
            return ret;
        }

        public void PRISReadOnly(Control _parent, bool _is_ReadOnly) 
        {
            List<Control> PRISControls = util.SearchControls<Control>(_parent, new List<Type> { typeof(IPRIS_UserControl) });

            foreach (IPRIS_UserControl pris in PRISControls) 
            { 
                pris.ReadOnly = _is_ReadOnly;
            }
        }
        public void readOnly_Controls( Control parent, bool is_Enabled = false) 
        {
            List<Control> controls = util.SearchControls<Control>(parent, new List<Type> { typeof(GunaTextBox), typeof(GunaComboBox)});

            foreach (Control control in controls) 
            {
                if (control is GunaTextBox)
                {
                    GunaTextBox textBox = (GunaTextBox)control;
                    textBox.ReadOnly = !is_Enabled;
                }
                else if (control is GunaComboBox)
                {
                    GunaComboBox comboBox = (GunaComboBox)control;
                    comboBox.Enabled = is_Enabled;
                }
                else if (control is RichTextBox) 
                { 
                    RichTextBox textBox = (RichTextBox)control;
                    textBox.ReadOnly = is_Enabled;
                }
            }
            
        }
    }
}
