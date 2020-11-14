using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidencija.OstaleKlase
{
  public class Validation
    {
        public static bool RequiredEntry(ErrorProvider err, TextBox TextB, string message)
        {
            if (string.IsNullOrEmpty(TextB.Text) == true)
            {
                err.SetError(TextB, message);
                MessageBox.Show(message);
                return false;
            }
            else
                err.Clear();
             return true;
        }
        public static bool RequiredEntry(ErrorProvider err, PictureBox PictureB, string message)
        {
            if (PictureB.Image == null)
            {
                err.SetError(PictureB, message);
                MessageBox.Show(message);
                return false;
            }
            else
                err.Clear();
            return true;
        }
        public static bool RequiredEntry(ErrorProvider err, ComboBox GenderB, string message)
        {
            if (GenderB.SelectedIndex < 0)
            {
                err.SetError(GenderB, message);
                MessageBox.Show(message);
                return false;
            }
            else
                err.Clear();
            return true;
        }
    }
}
