using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public class TestTextBox : TextBox
    {
        public TestTextBox(string str, int x, int y, int width, int height)
        {
            // ボタン内に文字を表示させる
            Text = str;

            Console.Write(Text);

            Location = new Point(x, y);

            Size = new Size(width, height);
        }
        public void TextUpdate(string str)
        {
            Text = str;
        }
    }
}
