using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CS_Form
{
    internal class Testbutton : Button

        /// <samary>
        /// コンストラクタ
        /// クラスを生成したときに呼び出される
        /// </samary>
    {
        public Testbutton(int x, int y,int width,int height,int ID)
        {
            // クリックイベントにOneclick関数を登録
            // ボタンをクリックしたときに登録した関数を実行させます
            Click += Oneclick;

            // ボタン内に文字を表示させる
            Text = "(=^・・^=)"+ID.ToString();

            Console.Write(Text);

            Location = new Point(x,y);

            Size = new Size(width,height);


        }

        public void Oneclick(object sender, EventArgs s)
        {
            MessageBox.Show(Text);
        }
    }
}
