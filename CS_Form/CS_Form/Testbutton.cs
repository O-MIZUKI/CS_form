﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CS_Form
{
    internal class Testbutton : Button
    {
        Form1 _form1;
        TestTextBox _testBox;

        /// <samary>
        /// コンストラクタ
        /// クラスを生成したときに呼び出される
        /// </samary>
        public Testbutton(Form1 form1,int x, int y,int width,int height,string str)
        {
            _form1 = form1;

            // クリックイベントにOnclick関数を登録
            // ボタンをクリックしたときに登録した関数を実行させます
            Click += Onclick;
            
            // ボタン内に文字を表示させる
            Text = str;

            Console.Write(Text);

            Location = new Point(x,y);

            Size = new Size(width,height);


        }

        
        public void Onclick(object sender, EventArgs s)
        {
            string currentButtonText = Text;

            Text = _form1._testBox.Text;

            _form1._testBox.Text = currentButtonText;

            _form1.LabelTextUpdate(currentButtonText);
            _form1.BoxTextUpdate(currentButtonText);
            
        }
    }
}