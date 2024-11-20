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

        public TestTextBox _testBox;

        Testbutton _testButton;

        public Form1()
        {
            InitializeComponent();

            string[] str = new string[10] { "1", "s", "d", "f", "g", "h", "j", "k", "l", ";" };
            for (int cnt = 0; cnt < 10; cnt++)
            {
                Testbutton testbutton = new Testbutton(this,(cnt % 5) * 100, (cnt / 5) * 100, 100, 100, str[cnt]);
                Controls.Add(testbutton);
            }

            _testLabel = new TestLabel("label", 10, 200, 50, 50);
            Controls.Add(_testLabel);

            _testBox = new TestTextBox("textbox",10,250,200,100);
            Controls.Add(_testBox);

            if (_testButton != null) 
            { 
                _testButton.Click += OnClick;
            }

        }


        
   
        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }
        public void BoxTextUpdate(string str)
        {
            _testBox.TextUpdate(str);
        }
        private void OnClick(object sender, EventArgs e) 
        { 
            _testButton.Text = _testBox.Text; 
        }

    }
}
