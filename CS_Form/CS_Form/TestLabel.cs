using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;
using System.Windows.Forms;

namespace CS_Form
{
    class TestLabel : Label
    {
        public TestLabel(string str,int x, int y, int width, int height)
        {
            // ボタン内に文字を表示させる
            Text = str;

            Console.Write(Text);

            Location = new Point(x, y);

            Size = new Size(width, height);
        }
    }
}
