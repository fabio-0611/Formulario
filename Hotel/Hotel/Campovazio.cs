using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    class Campovazio
    {
        public bool campo(Control controle, string vazio)
        {
            if (controle.Text == "")
            {
                MessageBox.Show("O campo " + vazio + " não pode ser ser vazio!");
                controle.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}

