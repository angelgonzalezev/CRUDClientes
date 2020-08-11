using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CROUDClientes
{
    class ValidatorInterface
    {
        public static void ShowErrorListMessageBox(List<string> errors)
        {
            string errorMessage = "Lista de errores: \r\n";
            foreach (string error in errors)
            {
                errorMessage += ("\r\n" + error);
            }

            MessageBox.Show(errorMessage);


        }
    }
}
