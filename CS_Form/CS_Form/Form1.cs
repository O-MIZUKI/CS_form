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
        TestLabel _testLabel;

        public Form1()
        {
            InitializeComponent();

            string a = "l";

            for (int cnt = 0; cnt < 10; cnt++)
            {
                Testbutton testbutton = new Testbutton(this, (cnt % 5) * 100, (cnt / 5) * 100, 100, 100, a);
                Controls.Add(testbutton);
                a = a + a;
            }

            _testLabel = new TestLabel("label", 10, 200, 50, 50);
            Controls.Add(_testLabel);
        }


        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }
    }
}
