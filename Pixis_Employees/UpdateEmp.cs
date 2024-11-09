using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixis_Employees
{
    internal class UpdateEmp
    {
        public string empNum;

        public static void update(List<GroupBox> groupBoxes)
        {
            foreach (var group in groupBoxes)
            {
                foreach (Control control in group.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        
                    }
                }
            }
        }
    }
}
