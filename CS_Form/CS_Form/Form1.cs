using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            for (int cnt = 0; cnt < 10; cnt++)
            {
                
                Testbutton testbutton = new Testbutton((cnt% 3) * 100,(cnt/3) * 100, 100, 100,cnt);
                Controls.Add(testbutton);
            }
        }
    }
}
